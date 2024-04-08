namespace Software2
{
    partial class Reports
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
            this.ReportLb = new System.Windows.Forms.Label();
            this.ReportTypeCB = new System.Windows.Forms.ComboBox();
            this.GenerateBtn = new System.Windows.Forms.Button();
            this.ReportListBox = new System.Windows.Forms.ListBox();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ReportLb
            // 
            this.ReportLb.AutoSize = true;
            this.ReportLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportLb.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ReportLb.Location = new System.Drawing.Point(12, 38);
            this.ReportLb.Name = "ReportLb";
            this.ReportLb.Size = new System.Drawing.Size(102, 16);
            this.ReportLb.TabIndex = 0;
            this.ReportLb.Text = "Select Report";
            // 
            // ReportTypeCB
            // 
            this.ReportTypeCB.FormattingEnabled = true;
            this.ReportTypeCB.Location = new System.Drawing.Point(12, 68);
            this.ReportTypeCB.Name = "ReportTypeCB";
            this.ReportTypeCB.Size = new System.Drawing.Size(191, 21);
            this.ReportTypeCB.TabIndex = 1;
            // 
            // GenerateBtn
            // 
            this.GenerateBtn.Location = new System.Drawing.Point(12, 113);
            this.GenerateBtn.Name = "GenerateBtn";
            this.GenerateBtn.Size = new System.Drawing.Size(75, 23);
            this.GenerateBtn.TabIndex = 2;
            this.GenerateBtn.Text = "Generate";
            this.GenerateBtn.UseVisualStyleBackColor = true;
            this.GenerateBtn.Click += new System.EventHandler(this.GenerateBtn_Click);
            // 
            // ReportListBox
            // 
            this.ReportListBox.FormattingEnabled = true;
            this.ReportListBox.Location = new System.Drawing.Point(232, 38);
            this.ReportListBox.Name = "ReportListBox";
            this.ReportListBox.Size = new System.Drawing.Size(804, 368);
            this.ReportListBox.TabIndex = 3;
            // 
            // CloseBtn
            // 
            this.CloseBtn.Location = new System.Drawing.Point(12, 399);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(75, 23);
            this.CloseBtn.TabIndex = 4;
            this.CloseBtn.Text = "Close";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 450);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.ReportListBox);
            this.Controls.Add(this.GenerateBtn);
            this.Controls.Add(this.ReportTypeCB);
            this.Controls.Add(this.ReportLb);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MaximizeBox = false;
            this.Name = "Reports";
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.Reports_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ReportLb;
        private System.Windows.Forms.ComboBox ReportTypeCB;
        private System.Windows.Forms.Button GenerateBtn;
        private System.Windows.Forms.ListBox ReportListBox;
        private System.Windows.Forms.Button CloseBtn;
    }
}