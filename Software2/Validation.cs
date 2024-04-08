using System;
using MySql.Data.MySqlClient;
using Software2.Database;
using System.Windows.Forms;
using System.Drawing;

namespace Software2
{
    public static class Validation
    {
        public static bool FieldInputCheck(TextBox Field) =>   //Used a lambda expression here to make the code more concise and the inline usage helps eliminate code blocks and space
            string.IsNullOrWhiteSpace(Field.Text) ? 
            (MessageBox.Show("All fields marked with (*) are required.", "Empty Field Error", MessageBoxButtons.OK, MessageBoxIcon.Warning),true).Item2 : false;

        public static void NumericValueCheck(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            try
            {
                int result = Convert.ToInt32(textBox.Text);
                textBox.BackColor = SystemColors.Window;
            }
            catch (FormatException)
            {
                textBox.BackColor = Color.Red;
                MessageBox.Show("Error: Please enter a numeric value.");
            }
            catch (OverflowException ex)
            {
                textBox.BackColor = Color.Red;
                MessageBox.Show(ex.Message);
            }
        }

        public static void StringValueCheck(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            try
            {
                string result = textBox.Text;
                textBox.BackColor = SystemColors.Window;
            }
            catch (FormatException)
            {
                textBox.BackColor = Color.Red;
                MessageBox.Show("Error: Please enter a string value.");
            }
            catch (OverflowException ex)
            {
                textBox.BackColor = Color.Red;
                MessageBox.Show(ex.Message);
            }
        }
        public static bool WithinBusinessHours(DateTime appointmentStart, DateTime appointmentEnd)
        {
            DateTime businessHoursStart = appointmentStart.Date.AddHours(8).AddSeconds(00);
            DateTime businessHoursEnd = appointmentEnd.Date.AddHours(17).AddMinutes(01).AddSeconds(00);

            if (appointmentStart < businessHoursStart || appointmentEnd > businessHoursEnd)
            {
                return false;
            }
            return true;
        }

        public static bool OverlappingAppointments(int userId, DateTime appointmentStart, DateTime appointmentEnd) //Use for non existing appointments
        {
            string query = "SELECT COUNT(*) FROM appointment WHERE userId = @userId AND" +
                " ((start BETWEEN @appointmentStart AND @appointmentEnd) OR " +
                "(end BETWEEN @appointmentStart AND @appointmentEnd) OR " +
                "(start < @appointmentStart AND end > @appointmentEnd) OR " +
                "(start > @appointmentStart AND end < @appointmentEnd))";
            MySqlCommand cmd = new MySqlCommand(query, DBConnection.Conn);
            cmd.Parameters.AddWithValue("@userId", userId);
            cmd.Parameters.AddWithValue("@appointmentStart", appointmentStart.ToUniversalTime());
            cmd.Parameters.AddWithValue("@appointmentEnd", appointmentEnd.ToUniversalTime());
            int count = Convert.ToInt32(cmd.ExecuteScalar());

            if (count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool OverlappingAppointments(int userId, DateTime appointmentStart, DateTime appointmentEnd, int appointmentId)  // Use for existing appointments to be modified
        {
            //Added appointmentId so that query will not retrieve the same appointment being modified
            string query = "SELECT COUNT(*) FROM appointment WHERE userId = @userId AND" +
                " ((start BETWEEN @appointmentStart AND @appointmentEnd) OR " +
                "(end BETWEEN @appointmentStart AND @appointmentEnd) OR " +
                "(start < @appointmentStart AND end > @appointmentEnd) OR " +
                "(start > @appointmentStart AND end < @appointmentEnd)) AND " +
                "appointmentId <> @appointmentId";
            MySqlCommand cmd = new MySqlCommand(query, DBConnection.Conn);
            cmd.Parameters.AddWithValue("@userId", userId);
            cmd.Parameters.AddWithValue("@appointmentStart", appointmentStart.ToUniversalTime());
            cmd.Parameters.AddWithValue("@appointmentEnd", appointmentEnd.ToUniversalTime());
            cmd.Parameters.AddWithValue("@appointmentId", appointmentId);
            int count = Convert.ToInt32(cmd.ExecuteScalar());

            if (count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool ComboBoxEmpty(ComboBox comboName, string labelName)
        {
            if (String.IsNullOrWhiteSpace(comboName.Text))
            {
                MessageBox.Show($"{labelName} field is required.", "Empty Field Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            return false;
        }
    }
}
