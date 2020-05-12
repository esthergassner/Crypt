using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crypt
{
    public partial class Crypt : Form
    {
        string filePath;
        string fileName;
        string extension;

        public Crypt()
        {
            InitializeComponent();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            commence(true);
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            commence(false);
        }

        private void btnBrowseSrc_Click(object sender, EventArgs e)
        {
            ofdSourceFile.ShowDialog();
            filePath = ofdSourceFile.FileName;
            tbSource.Text = filePath;
            fileName = Path.GetFileNameWithoutExtension(filePath);
            extension = Path.GetExtension(filePath);
        }

        private void btnBrowseTgt_Click(object sender, EventArgs e)
        {
            fbdTarget.RootFolder = Environment.SpecialFolder.Desktop;
            fbdTarget.ShowDialog();
            tbTarget.Text = fbdTarget.SelectedPath.ToString();
        }

        private void commence(bool encrypting)
        {
            string target;
            if (!tbPWConfirm.Text.Equals(tbPassword.Text))
            {
                MessageBox.Show("Passwords must match. Please double-check and re-enter your password.",
                                "Password Mismatch",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }
            if (encrypting)
            {
                target = fbdTarget.SelectedPath.ToString()
                            + "\\" + fileName + "-enc" + extension;
            }
            else
            {
                target = fbdTarget.SelectedPath.ToString()
                            + "\\" + fileName + "-decr" + extension;
            }
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                Algorithm.Crypt(tbSource.Text, target, tbPassword.Text,
                                (int)nudSeed.Value, extension);
                Cursor.Current = Cursors.Default;

                var result = MessageBox.Show("Encryption complete. Exit program?",
                                "Success",
                                MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                        Application.Exit();
                }
            }
            catch (Exception exc)
            {
                Cursor.Current = Cursors.Default;
                MessageBox.Show("That didn't work: " + exc.Message,
                                "Failure",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }
        
    }
}
