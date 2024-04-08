namespace Software2
{
    partial class ModifyAppointment
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
            this.NameTB = new System.Windows.Forms.TextBox();
            this.NameLb = new System.Windows.Forms.Label();
            this.EndDTP = new System.Windows.Forms.DateTimePicker();
            this.StartDTP = new System.Windows.Forms.DateTimePicker();
            this.CustomerIdCB = new System.Windows.Forms.ComboBox();
            this.EndLb = new System.Windows.Forms.Label();
            this.StartLb = new System.Windows.Forms.Label();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.ModifyAppointmentTitle = new System.Windows.Forms.Label();
            this.TypeLb = new System.Windows.Forms.Label();
            this.CustomerId = new System.Windows.Forms.Label();
            this.TypeCB = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // NameTB
            // 
            this.NameTB.Location = new System.Drawing.Point(339, 161);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(200, 20);
            this.NameTB.TabIndex = 2;
            // 
            // NameLb
            // 
            this.NameLb.AutoSize = true;
            this.NameLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLb.ForeColor = System.Drawing.SystemColors.Control;
            this.NameLb.Location = new System.Drawing.Point(180, 161);
            this.NameLb.Name = "NameLb";
            this.NameLb.Size = new System.Drawing.Size(48, 16);
            this.NameLb.TabIndex = 49;
            this.NameLb.Text = "Name";
            // 
            // EndDTP
            // 
            this.EndDTP.Location = new System.Drawing.Point(339, 270);
            this.EndDTP.Name = "EndDTP";
            this.EndDTP.Size = new System.Drawing.Size(200, 20);
            this.EndDTP.TabIndex = 5;
            // 
            // StartDTP
            // 
            this.StartDTP.Location = new System.Drawing.Point(339, 231);
            this.StartDTP.Name = "StartDTP";
            this.StartDTP.Size = new System.Drawing.Size(200, 20);
            this.StartDTP.TabIndex = 4;
            // 
            // CustomerIdCB
            // 
            this.CustomerIdCB.FormattingEnabled = true;
            this.CustomerIdCB.Location = new System.Drawing.Point(339, 125);
            this.CustomerIdCB.Name = "CustomerIdCB";
            this.CustomerIdCB.Size = new System.Drawing.Size(200, 21);
            this.CustomerIdCB.TabIndex = 1;
            // 
            // EndLb
            // 
            this.EndLb.AutoSize = true;
            this.EndLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndLb.ForeColor = System.Drawing.SystemColors.Control;
            this.EndLb.Location = new System.Drawing.Point(179, 270);
            this.EndLb.Name = "EndLb";
            this.EndLb.Size = new System.Drawing.Size(73, 16);
            this.EndLb.TabIndex = 45;
            this.EndLb.Text = "End Time";
            // 
            // StartLb
            // 
            this.StartLb.AutoSize = true;
            this.StartLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartLb.ForeColor = System.Drawing.SystemColors.Control;
            this.StartLb.Location = new System.Drawing.Point(179, 235);
            this.StartLb.Name = "StartLb";
            this.StartLb.Size = new System.Drawing.Size(78, 16);
            this.StartLb.TabIndex = 44;
            this.StartLb.Text = "Start Time";
            // 
            // CloseBtn
            // 
            this.CloseBtn.Location = new System.Drawing.Point(547, 380);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(75, 23);
            this.CloseBtn.TabIndex = 7;
            this.CloseBtn.Text = "Close";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Location = new System.Drawing.Point(428, 380);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(75, 23);
            this.UpdateBtn.TabIndex = 6;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // ModifyAppointmentTitle
            // 
            this.ModifyAppointmentTitle.AutoSize = true;
            this.ModifyAppointmentTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifyAppointmentTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.ModifyAppointmentTitle.Location = new System.Drawing.Point(308, 48);
            this.ModifyAppointmentTitle.Name = "ModifyAppointmentTitle";
            this.ModifyAppointmentTitle.Size = new System.Drawing.Size(220, 25);
            this.ModifyAppointmentTitle.TabIndex = 43;
            this.ModifyAppointmentTitle.Text = "Modify Appointment";
            // 
            // TypeLb
            // 
            this.TypeLb.AutoSize = true;
            this.TypeLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeLb.ForeColor = System.Drawing.SystemColors.Control;
            this.TypeLb.Location = new System.Drawing.Point(180, 195);
            this.TypeLb.Name = "TypeLb";
            this.TypeLb.Size = new System.Drawing.Size(133, 16);
            this.TypeLb.TabIndex = 39;
            this.TypeLb.Text = "Appointment Type";
            // 
            // CustomerId
            // 
            this.CustomerId.AutoSize = true;
            this.CustomerId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerId.ForeColor = System.Drawing.SystemColors.Control;
            this.CustomerId.Location = new System.Drawing.Point(180, 130);
            this.CustomerId.Name = "CustomerId";
            this.CustomerId.Size = new System.Drawing.Size(91, 16);
            this.CustomerId.TabIndex = 38;
            this.CustomerId.Text = "Customer ID";
            // 
            // TypeCB
            // 
            this.TypeCB.FormattingEnabled = true;
            this.TypeCB.Location = new System.Drawing.Point(339, 195);
            this.TypeCB.Name = "TypeCB";
            this.TypeCB.Size = new System.Drawing.Size(200, 21);
            this.TypeCB.TabIndex = 3;
            this.TypeCB.SelectedIndexChanged += new System.EventHandler(this.TypeCB_SelectedIndexChanged);
            // 
            // ModifyAppointment
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
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.ModifyAppointmentTitle);
            this.Controls.Add(this.TypeLb);
            this.Controls.Add(this.CustomerId);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MaximizeBox = false;
            this.Name = "ModifyAppointment";
            this.Text = "Modify Appointment";
            this.Load += new System.EventHandler(this.ModifyAppointment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.Label NameLb;
        private System.Windows.Forms.DateTimePicker EndDTP;
        private System.Windows.Forms.DateTimePicker StartDTP;
        private System.Windows.Forms.ComboBox CustomerIdCB;
        private System.Windows.Forms.Label EndLb;
        private System.Windows.Forms.Label StartLb;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Label ModifyAppointmentTitle;
        private System.Windows.Forms.Label TypeLb;
        private System.Windows.Forms.Label CustomerId;
        private System.Windows.Forms.ComboBox TypeCB;
    }
}