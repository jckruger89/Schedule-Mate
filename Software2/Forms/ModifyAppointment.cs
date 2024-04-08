using MySql.Data.MySqlClient;
using Org.BouncyCastle.Tls;
using Software2.Database;
using System;
using System.Windows.Forms;

namespace Software2
{
    public partial class ModifyAppointment : CustomForm
    {
        int userId;
        int appointmentId;
        int customerId;
        string customerName;
        string type;
        DateTime start;
        DateTime end;
        string lastUpdateBy = LoginForm.currentUsername;
        DateTime lastUpdate = DateTime.Now;
        bool isWithinBusinessHours;
        bool hasOverlappingAppointment;

        public ModifyAppointment(int appointmentId, int userId, int customerId, string customerName, string type, DateTime start, DateTime end)
        {
            InitializeComponent();
            NameTB.ReadOnly = true;
            NameTB.BackColor = System.Drawing.Color.LightGray;
            StartDTP.Format = DateTimePickerFormat.Custom;
            StartDTP.CustomFormat = "MM-dd-yyyy    hh:mm tt";
            EndDTP.Format = DateTimePickerFormat.Custom;
            EndDTP.CustomFormat = "MM-dd-yyyy    hh:mm tt";

            this.appointmentId = appointmentId;
            this.userId = userId;
            this.customerId = customerId;
            this.customerName = customerName;
            this.type = type;
            this.start = start;
            this.end = end;
        }
        private void ModifyAppointment_Load(object sender, EventArgs e)
        {
            ComboBoxes.LoadAppointmentTypeComboBox(TypeCB);
            PopulateModifyForm();
        }
        public void PopulateModifyForm()
        {
            CustomerIdCB.Items.Add(customerId);
            CustomerIdCB.SelectedItem = customerId;
            CustomerIdCB.DropDownStyle = ComboBoxStyle.DropDownList;
            NameTB.Text = customerName;
            NameTB.ReadOnly = true;
            StartDTP.Value = start;
            EndDTP.Value = end;
            TypeCB.SelectedItem = type;
        }

        public void ModifyNow()
        {
            var appointmentType = TypeCB.SelectedItem.ToString().ToUpper();
            var appointmentStart = StartDTP.Value;
            var appointmentEnd = EndDTP.Value;

            isWithinBusinessHours = Validation.WithinBusinessHours(appointmentStart, appointmentEnd);
            if (isWithinBusinessHours == false)
            {
                MessageBox.Show("Error: Appointments must be scheduled within business hours 8am - 5pm");
                return;
            }

            hasOverlappingAppointment = Validation.OverlappingAppointments(userId, appointmentStart, appointmentEnd, appointmentId);
            if (hasOverlappingAppointment == true)
            {
                MessageBox.Show("Error: User cannot have an overlapping appointment");
                return;
            }

            if (isWithinBusinessHours == true && hasOverlappingAppointment == false)
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand("UPDATE appointment SET type = @type, start = @start, end = @end, " +
                        "lastUpdate = @lastUpdate, lastUpdateBy = @lastUpdateBy WHERE appointmentId = @appointmentId", DBConnection.Conn);
                    cmd.Parameters.AddWithValue("@type", appointmentType);
                    cmd.Parameters.AddWithValue("@start", appointmentStart.ToUniversalTime());
                    cmd.Parameters.AddWithValue("@end", appointmentEnd.ToUniversalTime());
                    cmd.Parameters.AddWithValue("@lastUpdate", lastUpdate.ToUniversalTime());
                    cmd.Parameters.AddWithValue("@lastUpdateBy", lastUpdateBy);
                    cmd.Parameters.AddWithValue("@appointmentId", appointmentId);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Appointment updated!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Error, could not modify appointment.");
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                ModifyNow();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
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
