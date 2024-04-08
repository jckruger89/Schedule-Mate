namespace Software2
{
    partial class ModifyCustomer
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
            this.PostalCodeTB = new System.Windows.Forms.TextBox();
            this.PostalCodeLb = new System.Windows.Forms.Label();
            this.Address2TB = new System.Windows.Forms.TextBox();
            this.Address2Lb = new System.Windows.Forms.Label();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.CountryTB = new System.Windows.Forms.TextBox();
            this.CityTB = new System.Windows.Forms.TextBox();
            this.AddressTB = new System.Windows.Forms.TextBox();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.CountryLb = new System.Windows.Forms.Label();
            this.CityLb = new System.Windows.Forms.Label();
            this.PhoneLb = new System.Windows.Forms.Label();
            this.AddressLb = new System.Windows.Forms.Label();
            this.NameLb = new System.Windows.Forms.Label();
            this.ModifyCustomerTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PhoneTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // PostalCodeTB
            // 
            this.PostalCodeTB.Location = new System.Drawing.Point(309, 187);
            this.PostalCodeTB.Name = "PostalCodeTB";
            this.PostalCodeTB.Size = new System.Drawing.Size(193, 20);
            this.PostalCodeTB.TabIndex = 4;
            this.PostalCodeTB.TextChanged += new System.EventHandler(this.PostalCodeTB_TextChanged);
            // 
            // PostalCodeLb
            // 
            this.PostalCodeLb.AutoSize = true;
            this.PostalCodeLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PostalCodeLb.ForeColor = System.Drawing.SystemColors.Control;
            this.PostalCodeLb.Location = new System.Drawing.Point(179, 191);
            this.PostalCodeLb.Name = "PostalCodeLb";
            this.PostalCodeLb.Size = new System.Drawing.Size(98, 16);
            this.PostalCodeLb.TabIndex = 31;
            this.PostalCodeLb.Text = "Postal Code*";
            // 
            // Address2TB
            // 
            this.Address2TB.Location = new System.Drawing.Point(309, 152);
            this.Address2TB.Name = "Address2TB";
            this.Address2TB.Size = new System.Drawing.Size(193, 20);
            this.Address2TB.TabIndex = 3;
            this.Address2TB.TextChanged += new System.EventHandler(this.Address2TB_TextChanged);
            // 
            // Address2Lb
            // 
            this.Address2Lb.AutoSize = true;
            this.Address2Lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address2Lb.ForeColor = System.Drawing.SystemColors.Control;
            this.Address2Lb.Location = new System.Drawing.Point(179, 156);
            this.Address2Lb.Name = "Address2Lb";
            this.Address2Lb.Size = new System.Drawing.Size(77, 16);
            this.Address2Lb.TabIndex = 30;
            this.Address2Lb.Text = "Address 2";
            // 
            // CloseBtn
            // 
            this.CloseBtn.Location = new System.Drawing.Point(546, 345);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(75, 23);
            this.CloseBtn.TabIndex = 9;
            this.CloseBtn.Text = "Close";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Location = new System.Drawing.Point(427, 345);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(75, 23);
            this.UpdateBtn.TabIndex = 8;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // CountryTB
            // 
            this.CountryTB.Location = new System.Drawing.Point(309, 261);
            this.CountryTB.Name = "CountryTB";
            this.CountryTB.Size = new System.Drawing.Size(193, 20);
            this.CountryTB.TabIndex = 6;
            this.CountryTB.TextChanged += new System.EventHandler(this.CountryTB_TextChanged);
            // 
            // CityTB
            // 
            this.CityTB.Location = new System.Drawing.Point(309, 223);
            this.CityTB.Name = "CityTB";
            this.CityTB.Size = new System.Drawing.Size(193, 20);
            this.CityTB.TabIndex = 5;
            this.CityTB.TextChanged += new System.EventHandler(this.CityTB_TextChanged);
            // 
            // AddressTB
            // 
            this.AddressTB.Location = new System.Drawing.Point(309, 116);
            this.AddressTB.Name = "AddressTB";
            this.AddressTB.Size = new System.Drawing.Size(193, 20);
            this.AddressTB.TabIndex = 2;
            this.AddressTB.TextChanged += new System.EventHandler(this.AddressTB_TextChanged);
            // 
            // NameTB
            // 
            this.NameTB.Location = new System.Drawing.Point(309, 83);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(193, 20);
            this.NameTB.TabIndex = 1;
            this.NameTB.TextChanged += new System.EventHandler(this.NameTB_TextChanged);
            // 
            // CountryLb
            // 
            this.CountryLb.AutoSize = true;
            this.CountryLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountryLb.ForeColor = System.Drawing.SystemColors.Control;
            this.CountryLb.Location = new System.Drawing.Point(180, 265);
            this.CountryLb.Name = "CountryLb";
            this.CountryLb.Size = new System.Drawing.Size(65, 16);
            this.CountryLb.TabIndex = 24;
            this.CountryLb.Text = "Country*";
            // 
            // CityLb
            // 
            this.CityLb.AutoSize = true;
            this.CityLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CityLb.ForeColor = System.Drawing.SystemColors.Control;
            this.CityLb.Location = new System.Drawing.Point(180, 227);
            this.CityLb.Name = "CityLb";
            this.CityLb.Size = new System.Drawing.Size(39, 16);
            this.CityLb.TabIndex = 22;
            this.CityLb.Text = "City*";
            // 
            // PhoneLb
            // 
            this.PhoneLb.AutoSize = true;
            this.PhoneLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneLb.ForeColor = System.Drawing.SystemColors.Control;
            this.PhoneLb.Location = new System.Drawing.Point(180, 297);
            this.PhoneLb.Name = "PhoneLb";
            this.PhoneLb.Size = new System.Drawing.Size(57, 16);
            this.PhoneLb.TabIndex = 20;
            this.PhoneLb.Text = "Phone*";
            // 
            // AddressLb
            // 
            this.AddressLb.AutoSize = true;
            this.AddressLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressLb.ForeColor = System.Drawing.SystemColors.Control;
            this.AddressLb.Location = new System.Drawing.Point(180, 116);
            this.AddressLb.Name = "AddressLb";
            this.AddressLb.Size = new System.Drawing.Size(71, 16);
            this.AddressLb.TabIndex = 18;
            this.AddressLb.Text = "Address*";
            // 
            // NameLb
            // 
            this.NameLb.AutoSize = true;
            this.NameLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLb.ForeColor = System.Drawing.SystemColors.Control;
            this.NameLb.Location = new System.Drawing.Point(180, 83);
            this.NameLb.Name = "NameLb";
            this.NameLb.Size = new System.Drawing.Size(54, 16);
            this.NameLb.TabIndex = 16;
            this.NameLb.Text = "Name*";
            // 
            // ModifyCustomerTitle
            // 
            this.ModifyCustomerTitle.AutoSize = true;
            this.ModifyCustomerTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifyCustomerTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.ModifyCustomerTitle.Location = new System.Drawing.Point(279, 27);
            this.ModifyCustomerTitle.Name = "ModifyCustomerTitle";
            this.ModifyCustomerTitle.Size = new System.Drawing.Size(271, 25);
            this.ModifyCustomerTitle.TabIndex = 32;
            this.ModifyCustomerTitle.Text = "Modify Customer Record";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(197, 355);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "*Required Fields";
            // 
            // PhoneTB
            // 
            this.PhoneTB.Location = new System.Drawing.Point(309, 297);
            this.PhoneTB.Name = "PhoneTB";
            this.PhoneTB.Size = new System.Drawing.Size(193, 20);
            this.PhoneTB.TabIndex = 7;
            this.PhoneTB.TextChanged += new System.EventHandler(this.PhoneTB_TextChanged_1);
            // 
            // ModifyCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PhoneTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ModifyCustomerTitle);
            this.Controls.Add(this.PostalCodeTB);
            this.Controls.Add(this.PostalCodeLb);
            this.Controls.Add(this.Address2TB);
            this.Controls.Add(this.Address2Lb);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.CountryTB);
            this.Controls.Add(this.CityTB);
            this.Controls.Add(this.AddressTB);
            this.Controls.Add(this.NameTB);
            this.Controls.Add(this.CountryLb);
            this.Controls.Add(this.CityLb);
            this.Controls.Add(this.PhoneLb);
            this.Controls.Add(this.AddressLb);
            this.Controls.Add(this.NameLb);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MaximizeBox = false;
            this.Name = "ModifyCustomer";
            this.Text = "Modify Customer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PostalCodeTB;
        private System.Windows.Forms.Label PostalCodeLb;
        private System.Windows.Forms.TextBox Address2TB;
        private System.Windows.Forms.Label Address2Lb;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.TextBox CountryTB;
        private System.Windows.Forms.TextBox CityTB;
        private System.Windows.Forms.TextBox AddressTB;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.Label CountryLb;
        private System.Windows.Forms.Label CityLb;
        private System.Windows.Forms.Label PhoneLb;
        private System.Windows.Forms.Label AddressLb;
        private System.Windows.Forms.Label NameLb;
        private System.Windows.Forms.Label ModifyCustomerTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PhoneTB;
    }
}