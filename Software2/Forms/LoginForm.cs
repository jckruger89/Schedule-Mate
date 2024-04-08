using MySql.Data.MySqlClient;
using Software2.Database;
using System;
using System.Windows.Forms;
using System.Globalization;
using System.IO;

namespace Software2
{
    public partial class LoginForm : CustomForm
    {
        bool isSpanish = false;
        public static string currentUsername;
        string fileLog = "userLog.txt";
        string timeStamp = DateTime.Now.ToString();
        int customerId;
        DateTime start;
        string customerName;
        int userId;

        public LoginForm()
        {
            InitializeComponent();
            CultureInfo current = CultureInfo.CurrentCulture;

            if (current.Name.Equals("es-ES"))
            {
                LoginTitle.Text = "Programar Mate";
                UserNameLabel.Text = "Nombre de usuario";
                PasswordLabel.Text = "Contraseña";
                ConnectBtn.Text = "Conectar";
                isSpanish = true;
            }
        }
        private void SuccessfulLoginMessage()
        {
            CultureInfo current = CultureInfo.CurrentCulture;

            if (isSpanish)
            {
                MessageBox.Show($"¡Inicio de sesión exitoso!.\nIdioma & Ubicación: {current.DisplayName}");
            }
            else
            {
                MessageBox.Show($"Login successful!\nLanguage & Location: {current.DisplayName}");

            }
        }
        private void FailedLoginMessage()
        {
            CultureInfo current = CultureInfo.CurrentCulture;

            if (isSpanish)
            {
                MessageBox.Show($"Credenciales no válidas. Error de inicio de sesión.\nIdioma & Ubicación: {current.DisplayName}");
            }
            else
            {
                MessageBox.Show($"Invalid credentials. Login failed.\nLanguage & Location: {current.DisplayName}");

            }
        }
        private void ConnectBtn_Click(object sender, EventArgs e)
        {
            DBConnection.StartConnection();
            string sqlStr = "SELECT COUNT(*) FROM user WHERE userName = @UserName AND password = @Password";
            MySqlCommand cmd = new MySqlCommand(sqlStr, DBConnection.Conn);
            cmd.Parameters.AddWithValue("@UserName", UserNameTB.Text);
            cmd.Parameters.AddWithValue("@Password", PasswordTB.Text);
            int count = Convert.ToInt32(cmd.ExecuteScalar());

            if (count > 0)
            {
                // Authentication successful
                SuccessfulLoginMessage();
                currentUsername = UserNameTB.Text;
                UserLog(fileLog, timeStamp);
                AppointmentAlert();
                UserNameTB.Clear();
                PasswordTB.Clear();
                MainForm main = new MainForm();
                main.ShowDialog();
                DBConnection.CloseConnection();
                this.Close();
            }
            else
            {
                // Authentication failed
                FailedLoginMessage();
                DBConnection.CloseConnection();
            }
        }
        private void UserLog(string file, string timestamp)
        {
            StreamWriter streamWriter = null;

            string query = "SELECT userId FROM user WHERE userName = @UserName";
            MySqlCommand cmd = new MySqlCommand(query, DBConnection.Conn);
            cmd.Parameters.AddWithValue("@UserName", UserNameTB.Text);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                userId = reader.GetInt32("userId");
            }
            reader.Close();

            try
            {
                if (File.Exists(file) == false)
                {
                    File.Create(file).Close();
                }

                streamWriter = File.AppendText(file);
                streamWriter.WriteLine($"User ID: {userId}\tName: {currentUsername.ToUpper()} \tLogged in at: {timestamp}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error logging user activity: {ex.Message}");
            }
            finally
            {
                if (streamWriter != null)
                {
                    streamWriter.Dispose();
                }
            }
        }
        private void AppointmentAlert()
        {
            try
            {
                string query = "SELECT appointment.customerId, customer.customerName, appointment.start FROM appointment JOIN customer ON appointment.customerId = customer.customerId" +
                    " WHERE appointment.start BETWEEN NOW() AND (NOW() + INTERVAL 15 MINUTE) AND appointment.userId = @userId";
                MySqlCommand cmd = new MySqlCommand(query, DBConnection.Conn);
                cmd.Parameters.AddWithValue("@userId", userId);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    customerId = reader.GetInt32("customerId");
                    customerName = reader.GetString("customerName");
                    start = reader.GetDateTime("start");
                    reader.Close();
                    DateTime localStart = start.ToLocalTime();
                    string startString = localStart.ToString("t");

                    DialogResult alertMessage = MessageBox.Show($"You have a meeting with {customerName} at {startString}", "Appointment Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
