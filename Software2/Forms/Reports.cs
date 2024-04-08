using MySql.Data.MySqlClient;
using Software2.Database;
using System;
using System.Windows.Forms;

namespace Software2
{
    public partial class Reports : CustomForm
    {
        DateTime startDate;
        DateTime endDate;
        public Reports()
        {
            InitializeComponent();
            ReportListBox.ScrollAlwaysVisible = true;
        }

        private void GenerateBtn_Click(object sender, EventArgs e)
        {
            ReportListBox.Items.Clear();
            if (ReportTypeCB.SelectedIndex == 0)
            {
                MonthlyTypes();
            }
            else if (ReportTypeCB.SelectedIndex == 1)
            {
                MonthlyCustomerAppointments();
            }
            else
            {
                UserSchedule();
            }
        }

        private void Reports_Load(object sender, EventArgs e)
        {
            ComboBoxes.LoadReportTypeComboBox(ReportTypeCB);
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MonthlyTypes()
        {
            startDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            endDate = startDate.AddMonths(1).AddDays(-1).Date.AddHours(23).AddMinutes(59).AddSeconds(59);
            try
            {
                string query = "SELECT type, COUNT(*) AS typeCount FROM appointment WHERE start >= @startDate AND end <= @endDate GROUP BY type";
                MySqlCommand cmd = new MySqlCommand(query, DBConnection.Conn);
                cmd.Parameters.AddWithValue("@startDate", startDate.ToUniversalTime());
                cmd.Parameters.AddWithValue("@endDate", endDate.ToUniversalTime());
                cmd.ExecuteNonQuery();
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string appointmentType = reader.GetString("Type");
                    int appointmentCount = reader.GetInt32("typeCount");
                    ReportListBox.Items.Add($"Count: {appointmentCount}\t\tAppointment Type: {appointmentType}");
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void MonthlyCustomerAppointments()
        {
            startDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            endDate = startDate.AddMonths(1).AddDays(-1).Date.AddHours(23).AddMinutes(59).AddSeconds(59);
            try
            {
                string query = "SELECT customerName, type, COUNT(*) AS typeCount FROM appointment " +
                    "JOIN customer ON appointment.customerId = customer.customerId " +
                    "WHERE start >= @startDate AND end <= @endDate GROUP BY customerName, type";
                MySqlCommand cmd = new MySqlCommand(query, DBConnection.Conn);
                cmd.Parameters.AddWithValue("@startDate", startDate.ToUniversalTime());
                cmd.Parameters.AddWithValue("@endDate", endDate.ToUniversalTime());
                cmd.ExecuteNonQuery();
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string appointmentType = reader.GetString("Type");
                    int appointmentCount = reader.GetInt32("typeCount");
                    string customerName = reader.GetString("customerName");
                    ReportListBox.Items.Add($"Count: {appointmentCount}\t\tName: {customerName}");
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void UserSchedule()
        {
            try
            {
                string query = "SELECT user.userId, user.userName, appointment.type, appointment.start, appointment.end FROM appointment " +
                    "JOIN user ON appointment.userId = user.userId " +
                    "WHERE start >= @startDate ORDER BY user.userId, appointment.start";
                MySqlCommand cmd = new MySqlCommand(query, DBConnection.Conn);
                cmd.Parameters.AddWithValue("@startDate", DateTime.Now.ToUniversalTime());
                cmd.ExecuteNonQuery();
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string appointmentType = reader.GetString("type");
                    int userId = reader.GetInt32("userId");
                    string userName = reader.GetString("userName");
                    DateTime start = reader.GetDateTime("start");
                    DateTime end = reader.GetDateTime("end");
                    DateTime localStart = start.ToLocalTime();
                    string startString;
                    startString = localStart.ToString("MM/dd/yyyy hh:mm tt");
                    DateTime localEnd = end.ToLocalTime();
                    string endString;
                    endString = localEnd.ToString("MM/dd/yyyy hh:mm tt");

                    ReportListBox.Items.Add($"User ID: {userId}  Name: {userName.ToUpper()}  Appointmentype: {appointmentType}  Start: {startString}  End: {endString}");
                    ReportListBox.Items.Add("");
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
