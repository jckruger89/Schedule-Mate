namespace Software2
{
    partial class RecordsForm
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
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.AppointmentSearchTB = new System.Windows.Forms.TextBox();
            this.AppointmentSearchBtn = new System.Windows.Forms.Button();
            this.AppointmentsTitle = new System.Windows.Forms.Label();
            this.AppointmentsDeleteBtn = new System.Windows.Forms.Button();
            this.AppointmentsModifyBtn = new System.Windows.Forms.Button();
            this.AppointmentsAddBtn = new System.Windows.Forms.Button();
            this.AppointmentsDGV = new System.Windows.Forms.DataGridView();
            this.CustomerDeleteBtn = new System.Windows.Forms.Button();
            this.CustomerModifyBtn = new System.Windows.Forms.Button();
            this.CustomerSearchTB = new System.Windows.Forms.TextBox();
            this.CustomerSearchBtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.CustomerAddBtn = new System.Windows.Forms.Button();
            this.CostomerRecordsLB = new System.Windows.Forms.Label();
            this.CustomerRecordsDGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentsDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerRecordsDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // AppointmentSearchTB
            // 
            this.AppointmentSearchTB.Location = new System.Drawing.Point(170, 234);
            this.AppointmentSearchTB.Name = "AppointmentSearchTB";
            this.AppointmentSearchTB.Size = new System.Drawing.Size(135, 20);
            this.AppointmentSearchTB.TabIndex = 17;
            // 
            // AppointmentSearchBtn
            // 
            this.AppointmentSearchBtn.Location = new System.Drawing.Point(44, 234);
            this.AppointmentSearchBtn.Name = "AppointmentSearchBtn";
            this.AppointmentSearchBtn.Size = new System.Drawing.Size(95, 23);
            this.AppointmentSearchBtn.TabIndex = 16;
            this.AppointmentSearchBtn.Text = "Search Name";
            this.AppointmentSearchBtn.UseVisualStyleBackColor = true;
            this.AppointmentSearchBtn.Click += new System.EventHandler(this.AppointmentSearchBtn_Click);
            // 
            // AppointmentsTitle
            // 
            this.AppointmentsTitle.AutoSize = true;
            this.AppointmentsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppointmentsTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.AppointmentsTitle.Location = new System.Drawing.Point(354, 237);
            this.AppointmentsTitle.Name = "AppointmentsTitle";
            this.AppointmentsTitle.Size = new System.Drawing.Size(120, 20);
            this.AppointmentsTitle.TabIndex = 15;
            this.AppointmentsTitle.Text = "Appointments";
            // 
            // AppointmentsDeleteBtn
            // 
            this.AppointmentsDeleteBtn.Location = new System.Drawing.Point(523, 458);
            this.AppointmentsDeleteBtn.Name = "AppointmentsDeleteBtn";
            this.AppointmentsDeleteBtn.Size = new System.Drawing.Size(75, 23);
            this.AppointmentsDeleteBtn.TabIndex = 14;
            this.AppointmentsDeleteBtn.Text = "Delete";
            this.AppointmentsDeleteBtn.UseVisualStyleBackColor = true;
            this.AppointmentsDeleteBtn.Click += new System.EventHandler(this.AppointmentsDeleteBtn_Click);
            // 
            // AppointmentsModifyBtn
            // 
            this.AppointmentsModifyBtn.Location = new System.Drawing.Point(617, 458);
            this.AppointmentsModifyBtn.Name = "AppointmentsModifyBtn";
            this.AppointmentsModifyBtn.Size = new System.Drawing.Size(75, 23);
            this.AppointmentsModifyBtn.TabIndex = 13;
            this.AppointmentsModifyBtn.Text = "Modify";
            this.AppointmentsModifyBtn.UseVisualStyleBackColor = true;
            this.AppointmentsModifyBtn.Click += new System.EventHandler(this.AppointmentsModifyBtn_Click);
            // 
            // AppointmentsAddBtn
            // 
            this.AppointmentsAddBtn.Location = new System.Drawing.Point(711, 458);
            this.AppointmentsAddBtn.Name = "AppointmentsAddBtn";
            this.AppointmentsAddBtn.Size = new System.Drawing.Size(75, 23);
            this.AppointmentsAddBtn.TabIndex = 12;
            this.AppointmentsAddBtn.Text = "Add";
            this.AppointmentsAddBtn.UseVisualStyleBackColor = true;
            this.AppointmentsAddBtn.Click += new System.EventHandler(this.AppointmentsAddBtn_Click);
            // 
            // AppointmentsDGV
            // 
            this.AppointmentsDGV.AllowUserToAddRows = false;
            this.AppointmentsDGV.AllowUserToDeleteRows = false;
            this.AppointmentsDGV.AllowUserToResizeColumns = false;
            this.AppointmentsDGV.AllowUserToResizeRows = false;
            this.AppointmentsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.AppointmentsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AppointmentsDGV.Location = new System.Drawing.Point(44, 270);
            this.AppointmentsDGV.MultiSelect = false;
            this.AppointmentsDGV.Name = "AppointmentsDGV";
            this.AppointmentsDGV.ReadOnly = true;
            this.AppointmentsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AppointmentsDGV.Size = new System.Drawing.Size(799, 172);
            this.AppointmentsDGV.TabIndex = 11;
            // 
            // CustomerDeleteBtn
            // 
            this.CustomerDeleteBtn.Location = new System.Drawing.Point(524, 26);
            this.CustomerDeleteBtn.Name = "CustomerDeleteBtn";
            this.CustomerDeleteBtn.Size = new System.Drawing.Size(75, 23);
            this.CustomerDeleteBtn.TabIndex = 6;
            this.CustomerDeleteBtn.Text = "Delete";
            this.CustomerDeleteBtn.UseVisualStyleBackColor = true;
            this.CustomerDeleteBtn.Click += new System.EventHandler(this.CustomersDeleteBtn_Click);
            // 
            // CustomerModifyBtn
            // 
            this.CustomerModifyBtn.Location = new System.Drawing.Point(617, 26);
            this.CustomerModifyBtn.Name = "CustomerModifyBtn";
            this.CustomerModifyBtn.Size = new System.Drawing.Size(75, 23);
            this.CustomerModifyBtn.TabIndex = 5;
            this.CustomerModifyBtn.Text = "Modify";
            this.CustomerModifyBtn.UseVisualStyleBackColor = true;
            this.CustomerModifyBtn.Click += new System.EventHandler(this.CustomerModifyBtn_Click);
            // 
            // CustomerSearchTB
            // 
            this.CustomerSearchTB.Location = new System.Drawing.Point(170, 29);
            this.CustomerSearchTB.Name = "CustomerSearchTB";
            this.CustomerSearchTB.Size = new System.Drawing.Size(135, 20);
            this.CustomerSearchTB.TabIndex = 4;
            // 
            // CustomerSearchBtn
            // 
            this.CustomerSearchBtn.Location = new System.Drawing.Point(44, 29);
            this.CustomerSearchBtn.Name = "CustomerSearchBtn";
            this.CustomerSearchBtn.Size = new System.Drawing.Size(95, 23);
            this.CustomerSearchBtn.TabIndex = 3;
            this.CustomerSearchBtn.Text = "Search Name";
            this.CustomerSearchBtn.UseVisualStyleBackColor = true;
            this.CustomerSearchBtn.Click += new System.EventHandler(this.CustomerSearchBtn_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.Location = new System.Drawing.Point(889, 458);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(75, 23);
            this.CloseBtn.TabIndex = 2;
            this.CloseBtn.Text = "Close";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // CustomerAddBtn
            // 
            this.CustomerAddBtn.Location = new System.Drawing.Point(711, 26);
            this.CustomerAddBtn.Name = "CustomerAddBtn";
            this.CustomerAddBtn.Size = new System.Drawing.Size(75, 23);
            this.CustomerAddBtn.TabIndex = 1;
            this.CustomerAddBtn.Text = "Add";
            this.CustomerAddBtn.UseVisualStyleBackColor = true;
            this.CustomerAddBtn.Click += new System.EventHandler(this.CustomerAddBtn_Click);
            // 
            // CostomerRecordsLB
            // 
            this.CostomerRecordsLB.AutoSize = true;
            this.CostomerRecordsLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CostomerRecordsLB.ForeColor = System.Drawing.SystemColors.Control;
            this.CostomerRecordsLB.Location = new System.Drawing.Point(330, 29);
            this.CostomerRecordsLB.Name = "CostomerRecordsLB";
            this.CostomerRecordsLB.Size = new System.Drawing.Size(158, 20);
            this.CostomerRecordsLB.TabIndex = 1;
            this.CostomerRecordsLB.Text = "Customer Records";
            // 
            // CustomerRecordsDGV
            // 
            this.CustomerRecordsDGV.AllowUserToAddRows = false;
            this.CustomerRecordsDGV.AllowUserToDeleteRows = false;
            this.CustomerRecordsDGV.AllowUserToResizeColumns = false;
            this.CustomerRecordsDGV.AllowUserToResizeRows = false;
            this.CustomerRecordsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.CustomerRecordsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomerRecordsDGV.Location = new System.Drawing.Point(44, 58);
            this.CustomerRecordsDGV.MultiSelect = false;
            this.CustomerRecordsDGV.Name = "CustomerRecordsDGV";
            this.CustomerRecordsDGV.ReadOnly = true;
            this.CustomerRecordsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CustomerRecordsDGV.Size = new System.Drawing.Size(799, 161);
            this.CustomerRecordsDGV.TabIndex = 0;
            // 
            // RecordsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1008, 496);
            this.Controls.Add(this.AppointmentSearchTB);
            this.Controls.Add(this.AppointmentSearchBtn);
            this.Controls.Add(this.AppointmentsTitle);
            this.Controls.Add(this.AppointmentsDeleteBtn);
            this.Controls.Add(this.AppointmentsModifyBtn);
            this.Controls.Add(this.AppointmentsAddBtn);
            this.Controls.Add(this.AppointmentsDGV);
            this.Controls.Add(this.CustomerDeleteBtn);
            this.Controls.Add(this.CustomerModifyBtn);
            this.Controls.Add(this.CustomerSearchTB);
            this.Controls.Add(this.CustomerSearchBtn);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.CustomerAddBtn);
            this.Controls.Add(this.CostomerRecordsLB);
            this.Controls.Add(this.CustomerRecordsDGV);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MaximizeBox = false;
            this.Name = "RecordsForm";
            this.Text = "Manage Records";
            this.Load += new System.EventHandler(this.RecordsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentsDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerRecordsDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView CustomerRecordsDGV;
        private System.Windows.Forms.Label CostomerRecordsLB;
        private System.Windows.Forms.Button CustomerAddBtn;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Button CustomerSearchBtn;
        private System.Windows.Forms.TextBox CustomerSearchTB;
        private System.Windows.Forms.BindingSource bindingSource;
        private System.Windows.Forms.Button CustomerModifyBtn;
        private System.Windows.Forms.Button CustomerDeleteBtn;
        private System.Windows.Forms.Button AppointmentsDeleteBtn;
        private System.Windows.Forms.Button AppointmentsModifyBtn;
        private System.Windows.Forms.Button AppointmentsAddBtn;
        private System.Windows.Forms.DataGridView AppointmentsDGV;
        private System.Windows.Forms.Label AppointmentsTitle;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TextBox AppointmentSearchTB;
        private System.Windows.Forms.Button AppointmentSearchBtn;
    }
}