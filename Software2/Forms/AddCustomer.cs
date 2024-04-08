using MySql.Data.MySqlClient;
using Software2.Database;
using System;
using System.Windows.Forms;

namespace Software2
{
    public partial class AddCustomer : CustomForm
    {
        private int customerId = 0;
        private string customerName = string.Empty;
        private int addressId = 0;
        private int cityId = 0;
        private int countryId = 0;
        private bool isDuplicateEntry = false;
        public event EventHandler CustomerChanged;
        bool isInvalid;

        public AddCustomer()
        {
            InitializeComponent();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            using (MySqlTransaction transaction = DBConnection.Conn.BeginTransaction())
            {
                try
                {
                    AddToCountryTable();
                    AddToCityTable();
                    AddToAddressTable();
                    AddToCustomerTable();

                    if (isDuplicateEntry == true)
                    {
                        MessageBox.Show("Error: Duplicate information!");
                        this.Close();
                    }

                    isInvalid = Validation.FieldInputCheck(NameTB);
                    if (isInvalid == true)
                        return;
                    isInvalid = Validation.FieldInputCheck(CityTB);
                    if (isInvalid == true)
                        return;
                    isInvalid = Validation.FieldInputCheck(PhoneTB);
                    if (isInvalid == true)
                        return;
                    isInvalid = Validation.FieldInputCheck(AddressTB);
                    if (isInvalid == true)
                        return;
                    isInvalid = Validation.FieldInputCheck(CountryTB);
                    if (isInvalid == true)
                        return;
                    isInvalid = Validation.FieldInputCheck(PostalCodeTB);
                    if (isInvalid == true)
                        return;

                    else
                    {
                        transaction.Commit();
                        MessageBox.Show("Customer Added!");
                        CustomerChanged?.Invoke(this, EventArgs.Empty);
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Error adding customer: " + ex.Message);
                    this.Close();
                }
            }
        }
        public void AddToCountryTable()
        {
            //Check if countryId already exists
            string query = "SELECT countryId FROM country WHERE country = @country";
            MySqlCommand command = new MySqlCommand(query, DBConnection.Conn);
            command.Parameters.AddWithValue("@country", CountryTB.Text.ToUpper());
            var existingCountryId = command.ExecuteScalar();

            if (existingCountryId != null)
            {
                countryId = Convert.ToInt32(existingCountryId);
            }
            else
            {
                MySqlCommand cmd = new MySqlCommand("INSERT INTO country VALUES (NULL, @country, @createDate, @createdBy, @lastUpdate, @lastUpdateBy)", DBConnection.Conn);
                cmd.Parameters.AddWithValue("@country", CountryTB.Text.ToUpper());
                cmd.Parameters.AddWithValue("@createDate", DateTime.Today.ToUniversalTime());
                cmd.Parameters.AddWithValue("@createdBy", LoginForm.currentUsername);
                cmd.Parameters.AddWithValue("@lastUpdate", DateTime.Now.ToUniversalTime());
                cmd.Parameters.AddWithValue("@lastUpdateBy", LoginForm.currentUsername);
                cmd.ExecuteNonQuery();
            }
        }
        public void AddToCityTable()
        {
            //Get countryId
            string query = "SELECT countryId FROM country WHERE country = @country";
            MySqlCommand command = new MySqlCommand(query, DBConnection.Conn);
            command.Parameters.AddWithValue("@country", CountryTB.Text.ToUpper());
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                countryId = reader.GetInt32("countryId");
            }
            reader.Close();

            //Check if cityId already exists
            string query2 = "SELECT cityId FROM city WHERE city = @city AND countryId = @countryId";
            MySqlCommand command2 = new MySqlCommand(query2, DBConnection.Conn);
            command2.Parameters.AddWithValue("@city", CityTB.Text.ToUpper());
            command2.Parameters.AddWithValue("@countryId", countryId);
            var existingCityId = command2.ExecuteScalar();

            if (existingCityId != null)
            {
                cityId = Convert.ToInt32(existingCityId);
            }
            else
            {
                MySqlCommand cmd = new MySqlCommand("INSERT INTO city VALUES (NULL, @city, @countryId, @createDate, @createdBy, @lastUpdate, @lastUpdateBy)", DBConnection.Conn);
                cmd.Parameters.AddWithValue("@city", CityTB.Text.ToUpper());
                cmd.Parameters.AddWithValue("@countryId", countryId);
                cmd.Parameters.AddWithValue("@createDate", DateTime.Today.ToUniversalTime());
                cmd.Parameters.AddWithValue("@createdBy", LoginForm.currentUsername);
                cmd.Parameters.AddWithValue("@lastUpdate", DateTime.Now.ToUniversalTime());
                cmd.Parameters.AddWithValue("@lastUpdateBy", LoginForm.currentUsername);
                cmd.ExecuteNonQuery();
            }
        }
        public void AddToAddressTable()
        {
            //Get cityId
            string query2 = "SELECT cityId FROM city WHERE city = @city";
            MySqlCommand command2 = new MySqlCommand(query2, DBConnection.Conn);
            command2.Parameters.AddWithValue("@city", CityTB.Text.ToUpper());
            MySqlDataReader reader = command2.ExecuteReader();
            while (reader.Read())
            {
                cityId = reader.GetInt32("cityId");
            }
            reader.Close();

            //Check if addressId already exists
            string query = "SELECT addressId FROM address WHERE address = @address AND address2 = @address2 AND postalCode = @postalCode AND phone = @phone";
            MySqlCommand command = new MySqlCommand(query, DBConnection.Conn);
            command.Parameters.AddWithValue("@address", AddressTB.Text.ToUpper());
            command.Parameters.AddWithValue("@address2", Address2TB.Text.ToUpper());
            command.Parameters.AddWithValue("@postalCode", PostalCodeTB.Text);
            command.Parameters.AddWithValue("@phone", PhoneTB.Text);
            MySqlDataReader reader2 = command.ExecuteReader();

            bool isListed = false;
            while (reader2.Read())
            {
                addressId = reader2.GetInt32("addressId");
            }
            reader2.Close();
            if (addressId != 0)
            {
                isListed = true;
            }
            if (isListed == true) // check if customerName exists
            {
                string query3 = "SELECT customerName FROM customer WHERE customerName = @customerName";
                MySqlCommand command3 = new MySqlCommand(query3, DBConnection.Conn);
                command3.Parameters.AddWithValue("@customerName", NameTB.Text.ToUpper());
                var existingCustomerName = command3.ExecuteScalar();

                if (existingCustomerName != null)
                {
                    isDuplicateEntry = true;
                }
                else
                {
                    isListed = false;
                }
            }

            if (isListed == false)
            {
                MySqlCommand cmd = new MySqlCommand("INSERT INTO address VALUES (NULL, @address, @address2, @cityId, @postalCode," +
                       " @phone, @createDate, @createdBy, @lastUpdate, @lastUpdateBy)", DBConnection.Conn);
                cmd.Parameters.AddWithValue("@address", AddressTB.Text.ToUpper());
                cmd.Parameters.AddWithValue("@address2", Address2TB.Text.ToUpper());
                cmd.Parameters.AddWithValue("@cityId", cityId);
                cmd.Parameters.AddWithValue("@postalCode", PostalCodeTB.Text);
                cmd.Parameters.AddWithValue("@phone", PhoneTB.Text);
                cmd.Parameters.AddWithValue("@createDate", DateTime.Today.ToUniversalTime());
                cmd.Parameters.AddWithValue("@createdBy", LoginForm.currentUsername);
                cmd.Parameters.AddWithValue("@lastUpdate", DateTime.Now.ToUniversalTime());
                cmd.Parameters.AddWithValue("@lastUPdateBy", LoginForm.currentUsername);
                cmd.ExecuteNonQuery();
            }
        }
        public void AddToCustomerTable()
        {
            int active;
            bool isActive = true;
            if (isActive)
            {
                active = 1;
            }
            else
            {
                active = 0;
            }

            //Get addressId
            string query = "SELECT addressId FROM address WHERE address = @address AND address2 = @address2 AND postalCode = @postalCode AND phone = @phone";
            MySqlCommand command = new MySqlCommand(query, DBConnection.Conn);
            command.Parameters.AddWithValue("@address", AddressTB.Text.ToUpper());
            command.Parameters.AddWithValue("@address2", Address2TB.Text.ToUpper());
            command.Parameters.AddWithValue("@postalCode", PostalCodeTB.Text);
            command.Parameters.AddWithValue("@phone", PhoneTB.Text);
            MySqlDataReader reader2 = command.ExecuteReader();

            while (reader2.Read())
            {
                addressId = reader2.GetInt32("addressId");
            }
            reader2.Close();

            //Checking if customerId already exists
            string query2 = "SELECT customer.customerId FROM customer JOIN address ON customer.addressId = address.addressId" +
                " WHERE customer.customerName = @Name AND address.addressId = @addressId";
            MySqlCommand command2 = new MySqlCommand(query2, DBConnection.Conn);
            command2.Parameters.AddWithValue("@Name", NameTB.Text.ToUpper());
            command2.Parameters.AddWithValue("@addressId", addressId);
            var existingCustomerId = command2.ExecuteScalar();

            if (existingCustomerId != null)
            {
                customerId = Convert.ToInt32(existingCustomerId);
                isDuplicateEntry = true;
            }
            else
            {
                MySqlCommand cmd = new MySqlCommand("INSERT INTO customer VALUES (NULL, @customerName, @addressId, @active," +
         " @createDate, @createdBy, @lastUpdate, @lastUpdateBy)", DBConnection.Conn);
                cmd.Parameters.AddWithValue("@customerName", NameTB.Text.ToUpper());
                cmd.Parameters.AddWithValue("@addressId", addressId);
                cmd.Parameters.AddWithValue("@active", active);
                cmd.Parameters.AddWithValue("@createDate", DateTime.Today.ToUniversalTime());
                cmd.Parameters.AddWithValue("@createdBy", LoginForm.currentUsername);
                cmd.Parameters.AddWithValue("@lastUpdate", DateTime.Now.ToUniversalTime());
                cmd.Parameters.AddWithValue("@lastUpdateBy", LoginForm.currentUsername);
                cmd.ExecuteNonQuery();
            }
        }

        private void NameTB_TextChanged(object sender, EventArgs e)
        {
            Validation.StringValueCheck(sender, e);
        }

        private void AddressTB_TextChanged(object sender, EventArgs e)
        {
            Validation.StringValueCheck(sender, e);
        }

        private void PostalCodeTB_TextChanged(object sender, EventArgs e)
        {
            Validation.NumericValueCheck(sender, e);
        }

        private void CityTB_TextChanged(object sender, EventArgs e)
        {
            Validation.StringValueCheck(sender, e);
        }

        private void CountryTB_TextChanged(object sender, EventArgs e)
        {
            Validation.StringValueCheck(sender, e);
        }

        private void PhoneTB_TextChanged(object sender, EventArgs e)
        {
            Validation.StringValueCheck(sender, e);
        }
    }
}
