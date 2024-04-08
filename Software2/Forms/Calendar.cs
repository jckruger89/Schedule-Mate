using MySql.Data.MySqlClient;
using Software2.Database;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Software2
{
    public partial class Calendar : CustomForm
    {
        DateTime startDate, endDate, currentDate;

        public Calendar()
        {
            InitializeComponent();
            CalendarDGV.AutoGenerateColumns = false;
            CalendarDGV.Columns.Clear();
            CalendarDGV.AllowUserToAddRows = false;
            CalendarDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            CalendarDGV.BackgroundColor = Color.CadetBlue;
            CalendarDGV.BorderStyle = BorderStyle.None;
            ColumnAutoSize();
        }

        private void Calendar_Load(object sender, EventArgs e)
        {
            //Setting Column Names for CalendarDGV
            DataGridViewTextBoxColumn apptId = new DataGridViewTextBoxColumn();
            apptId.DataPropertyName = "appointmentId";
            apptId.HeaderText = "Appointment ID";
            CalendarDGV.Columns.Add(apptId);
            apptId.Visible = true;
            DataGridViewColumn column = CalendarDGV.Columns[0];
            column.HeaderCell.Style.WrapMode = DataGridViewTriState.False;

            DataGridViewTextBoxColumn Name = new DataGridViewTextBoxColumn();
            Name.DataPropertyName = "customerName";
            Name.HeaderText = "Customer";
            CalendarDGV.Columns.Add(Name);
            Name.Visible = true;

            DataGridViewTextBoxColumn typeOfAppt = new DataGridViewTextBoxColumn();
            typeOfAppt.DataPropertyName = "type";
            typeOfAppt.HeaderText = "Meeting Type";
            CalendarDGV.Columns.Add(typeOfAppt);
            typeOfAppt.Visible = true;

            DataGridViewTextBoxColumn startingTime = new DataGridViewTextBoxColumn();
            startingTime.DataPropertyName = "start";
            startingTime.HeaderText = "Start";
            CalendarDGV.Columns.Add(startingTime);
            startingTime.Visible = true;

            DataGridViewTextBoxColumn endingTime = new DataGridViewTextBoxColumn();
            endingTime.DataPropertyName = "end";
            endingTime.HeaderText = "End";
            CalendarDGV.Columns.Add(endingTime);
            endingTime.Visible = true;

            try
            {
                RadioBtnAllView.Checked = true; //Default selection
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void ColumnAutoSize()
        {
            foreach (DataGridViewColumn column in CalendarDGV.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }
        private void RadioBtnAllView_CheckedChanged(object sender, EventArgs e)  //Get all appointments where the appointment day has not passed
        {
            startDate = DateTime.Now.Date; //exclude appointments days that have passed 
            endDate = DateTime.MaxValue;
            LoadCalendar();
        }

        private void RadioBtnMonths_CheckedChanged(object sender, EventArgs e)   //Get current month appointments only
        {
            startDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            endDate = startDate.AddMonths(1).AddDays(-1).Date.AddHours(23).AddMinutes(59).AddSeconds(59);
            LoadCalendar();
        }

        private void RadioBtnWeek_CheckedChanged(object sender, EventArgs e)  //Get current week showing Sunday - Saturday appointments only
        {
            currentDate = DateTime.Now.Date;
            startDate = currentDate.AddDays((int)DayOfWeek.Sunday - ((int)currentDate.DayOfWeek)).Date.AddHours(00).AddMinutes(00).AddSeconds(00);
            endDate = startDate.AddDays(6).Date.AddHours(23).AddMinutes(59).AddSeconds(59);
            LoadCalendar();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void LoadCalendar()
        {
            try
            {
                string query = "SELECT appointment.appointmentId, customer.customerName, appointment.type, appointment.start, appointment.end FROM appointment JOIN customer ON appointment.customerId = customer.customerId WHERE start >= @startDate AND end <= @endDate";   
                MySqlCommand cmd = new MySqlCommand(query, DBConnection.Conn);
                cmd.Parameters.AddWithValue("@startDate", startDate.ToUniversalTime());
                cmd.Parameters.AddWithValue("@endDate", endDate.ToUniversalTime());
                cmd.ExecuteNonQuery();

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                //Converting UTC times to local times
                foreach (DataRow row in dataTable.Rows)
                {
                    if (row["start"] != DBNull.Value)
                    {
                        row["start"] = Convert.ToDateTime(row["start"]).ToLocalTime();
                    }

                    if (row["end"] != DBNull.Value)
                    {
                        row["end"] = Convert.ToDateTime(row["end"]).ToLocalTime();
                    }
                }

                bindingSourceCal.DataSource = dataTable;
                CalendarDGV.DataSource = bindingSourceCal;
                dataTable.DefaultView.Sort = "start ASC";
                ColumnAutoSize();
                CalendarDGV.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
