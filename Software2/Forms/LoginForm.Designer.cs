namespace Software2
{
    partial class LoginForm
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
            this.UserNameTB = new System.Windows.Forms.TextBox();
            this.PasswordTB = new System.Windows.Forms.TextBox();
            this.LoginTitle = new System.Windows.Forms.Label();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.ConnectBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // UserNameTB
            // 
            this.UserNameTB.Location = new System.Drawing.Point(382, 204);
            this.UserNameTB.Name = "UserNameTB";
            this.UserNameTB.Size = new System.Drawing.Size(131, 20);
            this.UserNameTB.TabIndex = 1;
            // 
            // PasswordTB
            // 
            this.PasswordTB.Location = new System.Drawing.Point(382, 245);
            this.PasswordTB.Name = "PasswordTB";
            this.PasswordTB.PasswordChar = '*';
            this.PasswordTB.Size = new System.Drawing.Size(131, 20);
            this.PasswordTB.TabIndex = 2;
            // 
            // LoginTitle
            // 
            this.LoginTitle.AutoSize = true;
            this.LoginTitle.Font = new System.Drawing.Font("BIZ UDGothic", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginTitle.ForeColor = System.Drawing.Color.White;
            this.LoginTitle.Location = new System.Drawing.Point(255, 36);
            this.LoginTitle.Name = "LoginTitle";
            this.LoginTitle.Size = new System.Drawing.Size(332, 48);
            this.LoginTitle.TabIndex = 4;
            this.LoginTitle.Text = "Schedule Mate";
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameLabel.ForeColor = System.Drawing.Color.White;
            this.UserNameLabel.Location = new System.Drawing.Point(226, 208);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(85, 16);
            this.UserNameLabel.TabIndex = 5;
            this.UserNameLabel.Text = "User Name";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.ForeColor = System.Drawing.Color.White;
            this.PasswordLabel.Location = new System.Drawing.Point(236, 249);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(75, 16);
            this.PasswordLabel.TabIndex = 6;
            this.PasswordLabel.Text = "Password";
            // 
            // ConnectBtn
            // 
            this.ConnectBtn.Location = new System.Drawing.Point(466, 314);
            this.ConnectBtn.Name = "ConnectBtn";
            this.ConnectBtn.Size = new System.Drawing.Size(75, 23);
            this.ConnectBtn.TabIndex = 3;
            this.ConnectBtn.Text = "Connect";
            this.ConnectBtn.UseVisualStyleBackColor = true;
            this.ConnectBtn.Click += new System.EventHandler(this.ConnectBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Software2.Properties.Resources.FriendPic;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(98, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(806, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ConnectBtn);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UserNameLabel);
            this.Controls.Add(this.LoginTitle);
            this.Controls.Add(this.PasswordTB);
            this.Controls.Add(this.UserNameTB);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.Text = "Log-in";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox UserNameTB;
        private System.Windows.Forms.TextBox PasswordTB;
        private System.Windows.Forms.Label LoginTitle;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Button ConnectBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

