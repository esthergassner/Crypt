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
            this.tbSeed = new System.Windows.Forms.TextBox();
            this.tbTarget = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbSource = new System.Windows.Forms.TextBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblSource = new System.Windows.Forms.Label();
            this.lblTarget = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblSeed = new System.Windows.Forms.Label();
            this.btnGo = new System.Windows.Forms.Button();
            this.btnBrowseSrc = new System.Windows.Forms.Button();
            this.btnBrowseTgt = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // tbSeed
            // 
            this.tbSeed.Location = new System.Drawing.Point(320, 381);
            this.tbSeed.Name = "tbSeed";
            this.tbSeed.PasswordChar = '*';
            this.tbSeed.Size = new System.Drawing.Size(369, 31);
            this.tbSeed.TabIndex = 3;
            this.tbSeed.UseSystemPasswordChar = true;
            // 
            // tbTarget
            // 
            this.tbTarget.Location = new System.Drawing.Point(262, 237);
            this.tbTarget.Name = "tbTarget";
            this.tbTarget.Size = new System.Drawing.Size(427, 31);
            this.tbTarget.TabIndex = 1;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(320, 306);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(369, 31);
            this.tbPassword.TabIndex = 2;
            this.tbPassword.UseSystemPasswordChar = true;
            // 
            // tbSource
            // 
            this.tbSource.Location = new System.Drawing.Point(262, 168);
            this.tbSource.Name = "tbSource";
            this.tbSource.Size = new System.Drawing.Size(427, 31);
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
            this.lblInfo.TabIndex = 4;
            this.lblInfo.Text = "Welcome to Crypt. Please enter required data below, then press the big red button" +
    " to commence encryption.";
            // 
            // lblSource
            // 
            this.lblSource.AutoSize = true;
            this.lblSource.Location = new System.Drawing.Point(60, 171);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(127, 25);
            this.lblSource.TabIndex = 5;
            this.lblSource.Text = "Source File:";
            // 
            // lblTarget
            // 
            this.lblTarget.AutoSize = true;
            this.lblTarget.Location = new System.Drawing.Point(60, 240);
            this.lblTarget.Name = "lblTarget";
            this.lblTarget.Size = new System.Drawing.Size(167, 25);
            this.lblTarget.TabIndex = 6;
            this.lblTarget.Text = "Destination File:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(60, 309);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(112, 25);
            this.lblPassword.TabIndex = 7;
            this.lblPassword.Text = "Password:";
            // 
            // lblSeed
            // 
            this.lblSeed.AutoSize = true;
            this.lblSeed.Location = new System.Drawing.Point(60, 384);
            this.lblSeed.Name = "lblSeed";
            this.lblSeed.Size = new System.Drawing.Size(204, 25);
            this.lblSeed.TabIndex = 8;
            this.lblSeed.Text = "Randomization Key:";
            // 
            // btnGo
            // 
            this.btnGo.BackColor = System.Drawing.Color.Red;
            this.btnGo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGo.Font = new System.Drawing.Font("Wide Latin", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGo.Location = new System.Drawing.Point(717, 429);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(114, 105);
            this.btnGo.TabIndex = 9;
            this.btnGo.Text = "GO";
            this.btnGo.UseVisualStyleBackColor = false;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // btnBrowseSrc
            // 
            this.btnBrowseSrc.Location = new System.Drawing.Point(730, 163);
            this.btnBrowseSrc.Name = "btnBrowseSrc";
            this.btnBrowseSrc.Size = new System.Drawing.Size(111, 41);
            this.btnBrowseSrc.TabIndex = 10;
            this.btnBrowseSrc.Text = "Browse...";
            this.btnBrowseSrc.UseVisualStyleBackColor = true;
            this.btnBrowseSrc.Click += new System.EventHandler(this.btnBrowseSrc_Click);
            // 
            // btnBrowseTgt
            // 
            this.btnBrowseTgt.Location = new System.Drawing.Point(730, 232);
            this.btnBrowseTgt.Name = "btnBrowseTgt";
            this.btnBrowseTgt.Size = new System.Drawing.Size(111, 41);
            this.btnBrowseTgt.TabIndex = 11;
            this.btnBrowseTgt.Text = "Browse...";
            this.btnBrowseTgt.UseVisualStyleBackColor = true;
            this.btnBrowseTgt.Click += new System.EventHandler(this.btnBrowseTgt_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Crypt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 565);
            this.Controls.Add(this.btnBrowseTgt);
            this.Controls.Add(this.btnBrowseSrc);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.lblSeed);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblTarget);
            this.Controls.Add(this.lblSource);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.tbSource);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbTarget);
            this.Controls.Add(this.tbSeed);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Crypt";
            this.Text = "Crypt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbSeed;
        private System.Windows.Forms.TextBox tbTarget;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbSource;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblSource;
        private System.Windows.Forms.Label lblTarget;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblSeed;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Button btnBrowseSrc;
        private System.Windows.Forms.Button btnBrowseTgt;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

