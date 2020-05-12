using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crypt
{
    public partial class Crypt : Form
    {
        public Crypt()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            try
            {
                Algorithm.Crypt(tbSource.Text,
                                tbTarget.Text,
                                tbPassword.Text,
                                tbSeed.Text);

            }
            catch (Exception exc)
            {
                MessageBox.Show("That didn't work: " + exc.Message,
                                "Failure",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void btnBrowseSrc_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            tbSource.Text = openFileDialog1.FileName.ToString();
        }

        private void btnBrowseTgt_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            tbTarget.Text = openFileDialog1.FileName.ToString();
        }
    }
}
