namespace Software2
{
    partial class MainForm
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
            this.CalendarLb = new System.Windows.Forms.Label();
            this.RecordsLb = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.ReportsIMG = new System.Windows.Forms.PictureBox();
            this.CustomerRecordsPic = new System.Windows.Forms.PictureBox();
            this.AppointmentsPic = new System.Windows.Forms.PictureBox();
            this.ReportsLB = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ReportsIMG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerRecordsPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentsPic)).BeginInit();
            this.SuspendLayout();
            // 
            // CalendarLb
            // 
            this.CalendarLb.AutoSize = true;
            this.CalendarLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalendarLb.ForeColor = System.Drawing.SystemColors.Control;
            this.CalendarLb.Location = new System.Drawing.Point(63, 71);
            this.CalendarLb.Name = "CalendarLb";
            this.CalendarLb.Size = new System.Drawing.Size(107, 16);
            this.CalendarLb.TabIndex = 2;
            this.CalendarLb.Text = "Calendar View";
            // 
            // RecordsLb
            // 
            this.RecordsLb.AutoSize = true;
            this.RecordsLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecordsLb.ForeColor = System.Drawing.SystemColors.Control;
            this.RecordsLb.Location = new System.Drawing.Point(311, 71);
            this.RecordsLb.Name = "RecordsLb";
            this.RecordsLb.Size = new System.Drawing.Size(126, 16);
            this.RecordsLb.TabIndex = 3;
            this.RecordsLb.Text = "Manage Records";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "***Select the image you want to visit";
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(679, 403);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(75, 23);
            this.ExitBtn.TabIndex = 5;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // ReportsIMG
            // 
            this.ReportsIMG.Image = global::Software2.Properties.Resources.reportsIMG;
            this.ReportsIMG.Location = new System.Drawing.Point(528, 103);
            this.ReportsIMG.Name = "ReportsIMG";
            this.ReportsIMG.Size = new System.Drawing.Size(236, 194);
            this.ReportsIMG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ReportsIMG.TabIndex = 6;
            this.ReportsIMG.TabStop = false;
            this.ReportsIMG.Click += new System.EventHandler(this.ReportsIMG_Click);
            // 
            // CustomerRecordsPic
            // 
            this.CustomerRecordsPic.Image = global::Software2.Properties.Resources.customerRecords;
            this.CustomerRecordsPic.Location = new System.Drawing.Point(279, 105);
            this.CustomerRecordsPic.Name = "CustomerRecordsPic";
            this.CustomerRecordsPic.Size = new System.Drawing.Size(182, 192);
            this.CustomerRecordsPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CustomerRecordsPic.TabIndex = 1;
            this.CustomerRecordsPic.TabStop = false;
            this.CustomerRecordsPic.Click += new System.EventHandler(this.RecordsPic_Click);
            // 
            // AppointmentsPic
            // 
            this.AppointmentsPic.Image = global::Software2.Properties.Resources.appointmentPic;
            this.AppointmentsPic.Location = new System.Drawing.Point(32, 105);
            this.AppointmentsPic.Name = "AppointmentsPic";
            this.AppointmentsPic.Size = new System.Drawing.Size(182, 192);
            this.AppointmentsPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.AppointmentsPic.TabIndex = 0;
            this.AppointmentsPic.TabStop = false;
            this.AppointmentsPic.Click += new System.EventHandler(this.CalendarPic_Click);
            // 
            // ReportsLB
            // 
            this.ReportsLB.AutoSize = true;
            this.ReportsLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportsLB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ReportsLB.Location = new System.Drawing.Point(578, 71);
            this.ReportsLB.Name = "ReportsLB";
            this.ReportsLB.Size = new System.Drawing.Size(130, 16);
            this.ReportsLB.TabIndex = 7;
            this.ReportsLB.Text = "Generate Reports";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ReportsLB);
            this.Controls.Add(this.ReportsIMG);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RecordsLb);
            this.Controls.Add(this.CalendarLb);
            this.Controls.Add(this.CustomerRecordsPic);
            this.Controls.Add(this.AppointmentsPic);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.ReportsIMG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerRecordsPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentsPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox AppointmentsPic;
        private System.Windows.Forms.PictureBox CustomerRecordsPic;
        private System.Windows.Forms.Label CalendarLb;
        private System.Windows.Forms.Label RecordsLb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.PictureBox ReportsIMG;
        private System.Windows.Forms.Label ReportsLB;
    }
}