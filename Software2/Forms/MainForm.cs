using Software2.Database;
using System;

namespace Software2
{
    public partial class MainForm : CustomForm
    {
        public MainForm()
        {
            InitializeComponent();
        }        

        private void CalendarPic_Click(object sender, EventArgs e)
        {
            Calendar calendar = new Calendar();
            calendar.ShowDialog();
        }

        private void RecordsPic_Click(object sender, EventArgs e)
        {
            RecordsForm recordsForm = new RecordsForm();
            recordsForm.ShowDialog();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            DBConnection.CloseConnection();
            this.Close();
        }

        private void ReportsIMG_Click(object sender, EventArgs e)
        {
            Reports reports = new Reports();
            reports.ShowDialog();
        }
    }
}
