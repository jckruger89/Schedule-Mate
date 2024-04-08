namespace Software2
{
    partial class Calendar
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
            this.components = new System.ComponentModel.Container();
            this.CalendarDGV = new System.Windows.Forms.DataGridView();
            this.bindingSourceCal = new System.Windows.Forms.BindingSource(this.components);
            this.RadioBtnAllView = new System.Windows.Forms.RadioButton();
            this.RadioBtnMonths = new System.Windows.Forms.RadioButton();
            this.RadioBtnWeek = new System.Windows.Forms.RadioButton();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.CalendarViewsLb = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CalendarDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCal)).BeginInit();
            this.SuspendLayout();
            // 
            // CalendarDGV
            // 
            this.CalendarDGV.AllowUserToAddRows = false;
            this.CalendarDGV.AllowUserToDeleteRows = false;
            this.CalendarDGV.AllowUserToResizeColumns = false;
            this.CalendarDGV.AllowUserToResizeRows = false;
            this.CalendarDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CalendarDGV.Location = new System.Drawing.Point(273, 52);
            this.CalendarDGV.Name = "CalendarDGV";
            this.CalendarDGV.ReadOnly = true;
            this.CalendarDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CalendarDGV.Size = new System.Drawing.Size(666, 323);
            this.CalendarDGV.TabIndex = 0;
            // 
            // RadioBtnAllView
            // 
            this.RadioBtnAllView.AutoSize = true;
            this.RadioBtnAllView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioBtnAllView.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.RadioBtnAllView.Location = new System.Drawing.Point(50, 108);
            this.RadioBtnAllView.Name = "RadioBtnAllView";
            this.RadioBtnAllView.Size = new System.Drawing.Size(119, 17);
            this.RadioBtnAllView.TabIndex = 1;
            this.RadioBtnAllView.TabStop = true;
            this.RadioBtnAllView.Text = "All Appointments";
            this.RadioBtnAllView.UseVisualStyleBackColor = true;
            this.RadioBtnAllView.CheckedChanged += new System.EventHandler(this.RadioBtnAllView_CheckedChanged);
            // 
            // RadioBtnMonths
            // 
            this.RadioBtnMonths.AutoSize = true;
            this.RadioBtnMonths.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioBtnMonths.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.RadioBtnMonths.Location = new System.Drawing.Point(50, 131);
            this.RadioBtnMonths.Name = "RadioBtnMonths";
            this.RadioBtnMonths.Size = new System.Drawing.Size(105, 17);
            this.RadioBtnMonths.TabIndex = 2;
            this.RadioBtnMonths.TabStop = true;
            this.RadioBtnMonths.Text = "Current Month";
            this.RadioBtnMonths.UseVisualStyleBackColor = true;
            this.RadioBtnMonths.CheckedChanged += new System.EventHandler(this.RadioBtnMonths_CheckedChanged);
            // 
            // RadioBtnWeek
            // 
            this.RadioBtnWeek.AutoSize = true;
            this.RadioBtnWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioBtnWeek.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.RadioBtnWeek.Location = new System.Drawing.Point(50, 154);
            this.RadioBtnWeek.Name = "RadioBtnWeek";
            this.RadioBtnWeek.Size = new System.Drawing.Size(103, 17);
            this.RadioBtnWeek.TabIndex = 3;
            this.RadioBtnWeek.TabStop = true;
            this.RadioBtnWeek.Text = "Current Week";
            this.RadioBtnWeek.UseVisualStyleBackColor = true;
            this.RadioBtnWeek.CheckedChanged += new System.EventHandler(this.RadioBtnWeek_CheckedChanged);
            // 
            // CloseBtn
            // 
            this.CloseBtn.Location = new System.Drawing.Point(935, 401);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(75, 23);
            this.CloseBtn.TabIndex = 4;
            this.CloseBtn.Text = "Close";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // CalendarViewsLb
            // 
            this.CalendarViewsLb.AutoSize = true;
            this.CalendarViewsLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalendarViewsLb.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CalendarViewsLb.Location = new System.Drawing.Point(36, 65);
            this.CalendarViewsLb.Name = "CalendarViewsLb";
            this.CalendarViewsLb.Size = new System.Drawing.Size(133, 20);
            this.CalendarViewsLb.TabIndex = 5;
            this.CalendarViewsLb.Text = "Calendar Views";
            // 
            // Calendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 453);
            this.Controls.Add(this.CalendarViewsLb);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.RadioBtnWeek);
            this.Controls.Add(this.RadioBtnMonths);
            this.Controls.Add(this.RadioBtnAllView);
            this.Controls.Add(this.CalendarDGV);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MaximizeBox = false;
            this.Name = "Calendar";
            this.Text = "Calendar";
            this.Load += new System.EventHandler(this.Calendar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CalendarDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView CalendarDGV;
        private System.Windows.Forms.BindingSource bindingSourceCal;
        private System.Windows.Forms.RadioButton RadioBtnAllView;
        private System.Windows.Forms.RadioButton RadioBtnMonths;
        private System.Windows.Forms.RadioButton RadioBtnWeek;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Label CalendarViewsLb;
    }
}