using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Windows.Forms;

namespace Software2.Database
{
    public class DBConnection
    {
        public static MySqlConnection Conn { get; set; }

        public static void StartConnection()
        {
            string connStr = ConfigurationManager.ConnectionStrings["localDb"].ConnectionString;
            try
            {
                Conn = new MySqlConnection(connStr);
                Conn.Open();                            
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void CloseConnection()
        {
            try
            {
                if (Conn != null)
                {
                    Conn.Close();
                }
                Conn = null;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
