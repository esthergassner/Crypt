namespace Crypt
{
    partial class Crypt
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Crypt));
            this.tbPWConfirm = new System.Windows.Forms.TextBox();
            this.tbTarget = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbSource = new System.Windows.Forms.TextBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblSource = new System.Windows.Forms.Label();
            this.lblTarget = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblSeed = new System.Windows.Forms.Label();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.btnBrowseSrc = new System.Windows.Forms.Button();
            this.btnBrowseTgt = new System.Windows.Forms.Button();
            this.ofdSourceFile = new System.Windows.Forms.OpenFileDialog();
            this.nudSeed = new System.Windows.Forms.NumericUpDown();
            this.lblPWConfirm = new System.Windows.Forms.Label();
            this.fbdTarget = new System.Windows.Forms.FolderBrowserDialog();
            this.btnEncrypt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeed)).BeginInit();
            this.SuspendLayout();
            // 
            // tbPWConfirm
            // 
            this.tbPWConfirm.Location = new System.Drawing.Point(320, 379);
            this.tbPWConfirm.Name = "tbPWConfirm";
            this.tbPWConfirm.PasswordChar = '*';
            this.tbPWConfirm.Size = new System.Drawing.Size(369, 31);
            this.tbPWConfirm.TabIndex = 5;
            this.tbPWConfirm.UseSystemPasswordChar = true;
            // 
            // tbTarget
            // 
            this.tbTarget.Location = new System.Drawing.Point(289, 237);
            this.tbTarget.Name = "tbTarget";
            this.tbTarget.Size = new System.Drawing.Size(400, 31);
            this.tbTarget.TabIndex = 2;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(320, 306);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(369, 31);
            this.tbPassword.TabIndex = 4;
            this.tbPassword.UseSystemPasswordChar = true;
            // 
            // tbSource
            // 
            this.tbSource.Location = new System.Drawing.Point(289, 168);
            this.tbSource.Name = "tbSource";
            this.tbSource.Size = new System.Drawing.Size(400, 31);
            this.tbSource.TabIndex = 0;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(119, 55);
            this.lblInfo.MaximumSize = new System.Drawing.Size(600, 0);
            this.lblInfo.MinimumSize = new System.Drawing.Size(0, 75);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(570, 75);
            this.lblInfo.TabIndex = 8;
            this.lblInfo.Text = "Welcome to Crypt. Please enter required data below, then press the appropriate bu" +
    "tton to commence encryption or decryption.";
            // 
            // lblSource
            // 
            this.lblSource.AutoSize = true;
            this.lblSource.Location = new System.Drawing.Point(60, 171);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(127, 25);
            this.lblSource.TabIndex = 9;
            this.lblSource.Text = "Source File:";
            // 
            // lblTarget
            // 
            this.lblTarget.AutoSize = true;
            this.lblTarget.Location = new System.Drawing.Point(60, 240);
            this.lblTarget.Name = "lblTarget";
            this.lblTarget.Size = new System.Drawing.Size(193, 25);
            this.lblTarget.TabIndex = 10;
            this.lblTarget.Text = "Destination Folder:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(60, 309);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(112, 25);
            this.lblPassword.TabIndex = 11;
            this.lblPassword.Text = "Password:";
            // 
            // lblSeed
            // 
            this.lblSeed.AutoSize = true;
            this.lblSeed.Location = new System.Drawing.Point(60, 457);
            this.lblSeed.Name = "lblSeed";
            this.lblSeed.Size = new System.Drawing.Size(204, 25);
            this.lblSeed.TabIndex = 13;
            this.lblSeed.Text = "Randomization Key:";
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.BackColor = System.Drawing.Color.Red;
            this.btnDecrypt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDecrypt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDecrypt.Font = new System.Drawing.Font("Lucida Bright", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecrypt.Location = new System.Drawing.Point(697, 429);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(194, 105);
            this.btnDecrypt.TabIndex = 8;
            this.btnDecrypt.Text = "DECRYPT";
            this.btnDecrypt.UseVisualStyleBackColor = false;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // btnBrowseSrc
            // 
            this.btnBrowseSrc.Location = new System.Drawing.Point(730, 163);
            this.btnBrowseSrc.Name = "btnBrowseSrc";
            this.btnBrowseSrc.Size = new System.Drawing.Size(111, 41);
            this.btnBrowseSrc.TabIndex = 1;
            this.btnBrowseSrc.Text = "Browse...";
            this.btnBrowseSrc.UseVisualStyleBackColor = true;
            this.btnBrowseSrc.Click += new System.EventHandler(this.btnBrowseSrc_Click);
            // 
            // btnBrowseTgt
            // 
            this.btnBrowseTgt.Location = new System.Drawing.Point(730, 232);
            this.btnBrowseTgt.Name = "btnBrowseTgt";
            this.btnBrowseTgt.Size = new System.Drawing.Size(111, 41);
            this.btnBrowseTgt.TabIndex = 3;
            this.btnBrowseTgt.Text = "Browse...";
            this.btnBrowseTgt.UseVisualStyleBackColor = true;
            this.btnBrowseTgt.Click += new System.EventHandler(this.btnBrowseTgt_Click);
            // 
            // ofdSourceFile
            // 
            this.ofdSourceFile.Title = "Source File";
            // 
            // nudSeed
            // 
            this.nudSeed.Location = new System.Drawing.Point(320, 451);
            this.nudSeed.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudSeed.Name = "nudSeed";
            this.nudSeed.Size = new System.Drawing.Size(120, 31);
            this.nudSeed.TabIndex = 6;
            // 
            // lblPWConfirm
            // 
            this.lblPWConfirm.AutoSize = true;
            this.lblPWConfirm.Location = new System.Drawing.Point(60, 382);
            this.lblPWConfirm.Name = "lblPWConfirm";
            this.lblPWConfirm.Size = new System.Drawing.Size(192, 25);
            this.lblPWConfirm.TabIndex = 12;
            this.lblPWConfirm.Text = "Confirm Password:";
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.BackColor = System.Drawing.Color.Lime;
            this.btnEncrypt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEncrypt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEncrypt.Font = new System.Drawing.Font("Lucida Bright", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncrypt.Location = new System.Drawing.Point(474, 429);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(197, 105);
            this.btnEncrypt.TabIndex = 7;
            this.btnEncrypt.Text = "ENCRYPT";
            this.btnEncrypt.UseVisualStyleBackColor = false;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // Crypt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 587);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.lblPWConfirm);
            this.Controls.Add(this.nudSeed);
            this.Controls.Add(this.btnBrowseTgt);
            this.Controls.Add(this.btnBrowseSrc);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.lblSeed);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblTarget);
            this.Controls.Add(this.lblSource);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.tbSource);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbTarget);
            this.Controls.Add(this.tbPWConfirm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Crypt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crypt";
            ((System.ComponentModel.ISupportInitialize)(this.nudSeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPWConfirm;
        private System.Windows.Forms.TextBox tbTarget;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbSource;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblSource;
        private System.Windows.Forms.Label lblTarget;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblSeed;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Button btnBrowseSrc;
        private System.Windows.Forms.Button btnBrowseTgt;
        private System.Windows.Forms.OpenFileDialog ofdSourceFile;
        private System.Windows.Forms.NumericUpDown nudSeed;
        private System.Windows.Forms.Label lblPWConfirm;
        private System.Windows.Forms.FolderBrowserDialog fbdTarget;
        private System.Windows.Forms.Button btnEncrypt;
    }
}

