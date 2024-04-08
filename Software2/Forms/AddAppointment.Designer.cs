﻿namespace Software2
{
    partial class AddAppointment
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
            this.EndDTP = new System.Windows.Forms.DateTimePicker();
            this.StartDTP = new System.Windows.Forms.DateTimePicker();
            this.CustomerIdCB = new System.Windows.Forms.ComboBox();
            this.EndLb = new System.Windows.Forms.Label();
            this.StartLb = new System.Windows.Forms.Label();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.CreateBtn = new System.Windows.Forms.Button();
            this.AddAppointmentTitle = new System.Windows.Forms.Label();
            this.TypeLb = new System.Windows.Forms.Label();
            this.CustomerId = new System.Windows.Forms.Label();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.NameLb = new System.Windows.Forms.Label();
            this.TypeCB = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // EndDTP
            // 
            this.EndDTP.Location = new System.Drawing.Point(338, 270);
            this.EndDTP.Name = "EndDTP";
            this.EndDTP.Size = new System.Drawing.Size(200, 20);
            this.EndDTP.TabIndex = 5;
            // 
            // StartDTP
            // 
            this.StartDTP.Location = new System.Drawing.Point(338, 231);
            this.StartDTP.Name = "StartDTP";
            this.StartDTP.Size = new System.Drawing.Size(200, 20);
            this.StartDTP.TabIndex = 4;
            // 
            // CustomerIdCB
            // 
            this.CustomerIdCB.FormattingEnabled = true;
            this.CustomerIdCB.Location = new System.Drawing.Point(338, 125);
            this.CustomerIdCB.Name = "CustomerIdCB";
            this.CustomerIdCB.Size = new System.Drawing.Size(200, 21);
            this.CustomerIdCB.TabIndex = 1;
            this.CustomerIdCB.SelectedIndexChanged += new System.EventHandler(this.CustomerIdCB_SelectedIndexChanged);
            // 
            // EndLb
            // 
            this.EndLb.AutoSize = true;
            this.EndLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndLb.ForeColor = System.Drawing.SystemColors.Control;
            this.EndLb.Location = new System.Drawing.Point(178, 270);
            this.EndLb.Name = "EndLb";
            this.EndLb.Size = new System.Drawing.Size(73, 16);
            this.EndLb.TabIndex = 32;
            this.EndLb.Text = "End Time";
            // 
            // StartLb
            // 
            this.StartLb.AutoSize = true;
            this.StartLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartLb.ForeColor = System.Drawing.SystemColors.Control;
            this.StartLb.Location = new System.Drawing.Point(178, 235);
            this.StartLb.Name = "StartLb";
            this.StartLb.Size = new System.Drawing.Size(78, 16);
            this.StartLb.TabIndex = 31;
            this.StartLb.Text = "Start Time";
            // 
            // CloseBtn
            // 
            this.CloseBtn.Location = new System.Drawing.Point(546, 380);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(75, 23);
            this.CloseBtn.TabIndex = 7;
            this.CloseBtn.Text = "Close";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // CreateBtn
            // 
            this.CreateBtn.Location = new System.Drawing.Point(427, 380);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(75, 23);
            this.CreateBtn.TabIndex = 6;
            this.CreateBtn.Text = "Create";
            this.CreateBtn.UseVisualStyleBackColor = true;
            this.CreateBtn.Click += new System.EventHandler(this.CreateBtn_Click);
            // 
            // AddAppointmentTitle
            // 
            this.AddAppointmentTitle.AutoSize = true;
            this.AddAppointmentTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddAppointmentTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.AddAppointmentTitle.Location = new System.Drawing.Point(290, 48);
            this.AddAppointmentTitle.Name = "AddAppointmentTitle";
            this.AddAppointmentTitle.Size = new System.Drawing.Size(195, 25);
            this.AddAppointmentTitle.TabIndex = 30;
            this.AddAppointmentTitle.Text = "New Appointment";
            // 
            // TypeLb
            // 
            this.TypeLb.AutoSize = true;
            this.TypeLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeLb.ForeColor = System.Drawing.SystemColors.Control;
            this.TypeLb.Location = new System.Drawing.Point(179, 195);
            this.TypeLb.Name = "TypeLb";
            this.TypeLb.Size = new System.Drawing.Size(133, 16);
            this.TypeLb.TabIndex = 18;
            this.TypeLb.Text = "Appointment Type";
            // 
            // CustomerId
            // 
            this.CustomerId.AutoSize = true;
            this.CustomerId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerId.ForeColor = System.Drawing.SystemColors.Control;
            this.CustomerId.Location = new System.Drawing.Point(179, 130);
            this.CustomerId.Name = "CustomerId";
            this.CustomerId.Size = new System.Drawing.Size(91, 16);
            this.CustomerId.TabIndex = 16;
            this.CustomerId.Text = "Customer ID";
            // 
            // NameTB
            // 
            this.NameTB.Location = new System.Drawing.Point(338, 161);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(200, 20);
            this.NameTB.TabIndex = 2;
            // 
            // NameLb
            // 
            this.NameLb.AutoSize = true;
            this.NameLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLb.ForeColor = System.Drawing.SystemColors.Control;
            this.NameLb.Location = new System.Drawing.Point(179, 161);
            this.NameLb.Name = "NameLb";
            this.NameLb.Size = new System.Drawing.Size(48, 16);
            this.NameLb.TabIndex = 36;
            this.NameLb.Text = "Name";
            // 
            // TypeCB
            // 
            this.TypeCB.FormattingEnabled = true;
            this.TypeCB.Location = new System.Drawing.Point(338, 195);
            this.TypeCB.Name = "TypeCB";
            this.TypeCB.Size = new System.Drawing.Size(200, 21);
            this.TypeCB.TabIndex = 3;
            this.TypeCB.SelectedIndexChanged += new System.EventHandler(this.TypeCB_SelectedIndexChanged);
            // 
            // AddAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TypeCB);
            this.Controls.Add(this.NameTB);
            this.Controls.Add(this.NameLb);
            this.Controls.Add(this.EndDTP);
            this.Controls.Add(this.StartDTP);
            this.Controls.Add(this.CustomerIdCB);
            this.Controls.Add(this.EndLb);
            this.Controls.Add(this.StartLb);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.CreateBtn);
            this.Controls.Add(this.AddAppointmentTitle);
            this.Controls.Add(this.TypeLb);
            this.Controls.Add(this.CustomerId);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MaximizeBox = false;
            this.Name = "AddAppointment";
            this.Text = "Add Appointment";
            this.Load += new System.EventHandler(this.AddAppointment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label EndLb;
        private System.Windows.Forms.Label StartLb;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Button CreateBtn;
        private System.Windows.Forms.Label AddAppointmentTitle;
        private System.Windows.Forms.Label TypeLb;
        private System.Windows.Forms.Label CustomerId;
        private System.Windows.Forms.ComboBox CustomerIdCB;
        private System.Windows.Forms.DateTimePicker StartDTP;
        private System.Windows.Forms.DateTimePicker EndDTP;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.Label NameLb;
        private System.Windows.Forms.ComboBox TypeCB;
    }
}