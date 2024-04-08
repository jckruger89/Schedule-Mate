using MySql.Data.MySqlClient;
using Org.BouncyCastle.Tls;
using Software2.Database;
using System;
using System.Windows.Forms;

namespace Software2
{
    public partial class AddAppointment : CustomForm
    {
        int customerId = 0;
        int userId = 0;
        string customerName = string.Empty;
        string title = "not needed";
        string description = "not needed";
        string location = "not needed";
        string contact = "not needed";
        string url = "not needed";
        string appointmentType;
        DateTime appointmentStart;
        DateTime appointmentEnd;
        bool isWithinBusinessHours;
        bool hasOverlappingAppointment;

        public AddAppointment()
        {
            InitializeComponent();
            NameTB.ReadOnly = true;
            NameTB.BackColor = System.Drawing.Color.LightGray;
            StartDTP.Format = DateTimePickerFormat.Custom;
            StartDTP.CustomFormat = "MM-dd-yyyy    hh:mm tt";
            EndDTP.Format = DateTimePickerFormat.Custom;
            EndDTP.CustomFormat = "MM-dd-yyyy    hh:mm tt";
        }
        private void AddAppointment_Load(object sender, EventArgs e)
        {
            GetUserId();
            LoadCustomerIdComboBox();
            ComboBoxes.LoadAppointmentTypeComboBox(TypeCB);
        }
        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void LoadCustomerIdComboBox()
        {
            CustomerIdCB.Items.Clear();
            try
            {
                string query = "SELECT customerId FROM customer";
                MySqlCommand cmd = new MySqlCommand(query, DBConnection.Conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    customerId = reader.GetInt32("customerId");
                    if (!CustomerIdCB.Items.Contains(customerId))
                    {
                        CustomerIdCB.Items.Add(customerId);
                    }
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            CustomerIdCB.Sorted = true;
        }

        public void LoadNameTextBox()
        {
            var value = CustomerIdCB.SelectedItem;
            customerId = Convert.ToInt32(value);
            string query = "SELECT customerName FROM customer WHERE customerId = @customerId";
            MySqlCommand cmd = new MySqlCommand(query, DBConnection.Conn);
            cmd.Parameters.AddWithValue("@customerId", customerId);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                customerName = reader.GetString("customerName");
            }
            reader.Close();
            NameTB.Text = customerName;
        }

        private void CustomerIdCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            NameTB.ReadOnly = false;
            LoadNameTextBox();
            NameTB.ReadOnly = true;
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            appointmentType = TypeCB.SelectedItem.ToString().ToUpper();
            appointmentStart = StartDTP.Value;
            appointmentEnd = EndDTP.Value;

            string labelName = "Customer ID";
            bool isEmpty = Validation.ComboBoxEmpty(CustomerIdCB, labelName);
            if (isEmpty == true)
                return;

            isWithinBusinessHours = Validation.WithinBusinessHours(appointmentStart, appointmentEnd);
            if (isWithinBusinessHours == false)
            {
                MessageBox.Show("Error: Appointments must be scheduled within business hours 8am - 5pm");
                return;
            }

            hasOverlappingAppointment = Validation.OverlappingAppointments(userId, appointmentStart, appointmentEnd);
            if (hasOverlappingAppointment == true)
            {
                MessageBox.Show("Error: User cannot have an overlapping appointment");
                return;
            }

            if (isWithinBusinessHours == true && hasOverlappingAppointment == false)
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO appointment VALUES(NULL, @customerId, @userId, @title, @description, @location," +
                                   " @contact, @type, @url, @start, @end, @createDate, @createdBy, @lastUpdate, @lastUpdateBy)", DBConnection.Conn);
                    cmd.Parameters.AddWithValue("@customerId", customerId);
                    cmd.Parameters.AddWithValue("@userId", userId);
                    cmd.Parameters.AddWithValue("@title", title);
                    cmd.Parameters.AddWithValue("@description", description);
                    cmd.Parameters.AddWithValue("@location", location);
                    cmd.Parameters.AddWithValue("@contact", contact);
                    cmd.Parameters.AddWithValue("@type", appointmentType);
                    cmd.Parameters.AddWithValue("@url", url);
                    cmd.Parameters.AddWithValue("@start", appointmentStart.ToUniversalTime());
                    cmd.Parameters.AddWithValue("@end", appointmentEnd.ToUniversalTime());
                    cmd.Parameters.AddWithValue("@createDate", DateTime.Today);
                    cmd.Parameters.AddWithValue("@createdBy", LoginForm.currentUsername);
                    cmd.Parameters.AddWithValue("@lastUpdate", DateTime.Now);
                    cmd.Parameters.AddWithValue("@lastUpdateby", LoginForm.currentUsername);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Appointment added successfuly!");
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Error, could not add appointment.");
            }
        }

        public void GetUserId()
        {
            string query = "SELECT userId FROM user WHERE userName = @userName";
            MySqlCommand cmd = new MySqlCommand(query, DBConnection.Conn);
            cmd.Parameters.AddWithValue("@userName", LoginForm.currentUsername);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                userId = reader.GetInt32("userId");
            }
            reader.Close();
        }

        private void TypeCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            TypeCB.KeyPress += TypeCB_KeyPress;
            TypeCB.KeyDown += TypeCB_KeyDown;
        }
        private void TypeCB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true; // Cancel all key press events
        }
        private void TypeCB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                e.Handled = true; // Cancel the delete key event
            }
        }
    }
}
