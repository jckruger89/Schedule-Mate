using MySql.Data.MySqlClient;
using Software2.Database;
using System;
using System.Windows.Forms;

namespace Software2
{
    public class DeleteCustomerRecord
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string Address { get; set; }
        public int AddressId { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
        public string Phone { get; set; }

        public event EventHandler CustomerChanged;

        public DeleteCustomerRecord()
        {

        }
        public DeleteCustomerRecord(int CustomerId, string CustomerName, string Address, string Address2, string City, string PostalCode, string Country, string Phone)
        {
            this.CustomerId = CustomerId;
            this.CustomerName = CustomerName;
            this.Address = Address;
            this.Address2 = Address2;
            this.City = City;
            this.Country = Country;
            this.PostalCode = PostalCode;
            this.Phone = Phone;
        }
        public void DeleteNow()
        {
            using (MySqlTransaction transaction = DBConnection.Conn.BeginTransaction())
            {
                try
                {
                    FetchAddressId();
                    AddressCount();
                    transaction.Commit();
                    CustomerChanged?.Invoke(this, EventArgs.Empty);
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public void AddressCount()
        {
            int count = 0;
            string query = "SELECT COUNT(*) FROM customer WHERE addressId = @addressId";
            MySqlCommand command = new MySqlCommand(query, DBConnection.Conn);
            command.Parameters.AddWithValue("@addressId", AddressId);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                count = reader.GetInt32(0);
            }
            reader.Close();
            if (count == 1)
            {
                DeleteCustomerId();
                DeleteAddressId();
            }
            else
            {
                DeleteCustomerId();
            }
        }

        public void FetchAddressId()
        {
            string query = "SELECT addressId FROM address WHERE address = @address AND address2 = @address2 AND postalCode = @postalCode AND phone = @phone";
            MySqlCommand command = new MySqlCommand(query, DBConnection.Conn);
            command.Parameters.AddWithValue("@address", Address.ToUpper());
            command.Parameters.AddWithValue("@address2", Address2.ToUpper());
            command.Parameters.AddWithValue("@postalCode", PostalCode.ToUpper());
            command.Parameters.AddWithValue("@phone", Phone.ToUpper());
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                AddressId = reader.GetInt32("addressId");
            }
            reader.Close();
        }
        public void DeleteAddressId()
        {
            MySqlCommand cmd = new MySqlCommand("DELETE FROM address WHERE addressId = @addressId", DBConnection.Conn);
            cmd.Parameters.AddWithValue("@addressId", AddressId);
            cmd.ExecuteNonQuery();
        }
        public void DeleteCustomerId()
        {
            MySqlCommand cmd = new MySqlCommand("DELETE FROM customer WHERE customerId = @customerId", DBConnection.Conn);
            cmd.Parameters.AddWithValue("@customerId", CustomerId);
            cmd.ExecuteNonQuery();
        }
    }
}
