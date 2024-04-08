using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Software2.Database;
using System.Linq;

namespace Software2
{
    public partial class ModifyCustomer : CustomForm
    {
        private int customerId;
        int countryId;
        int cityId;
        int addressId;
        string lastUpdateBy = LoginForm.currentUsername;
        DateTime lastUpdate = DateTime.Now;
        public event EventHandler CustomerChanged;
        bool isInvalid;
        
        public ModifyCustomer()
        {
            InitializeComponent();
        }

        // Populating form from selected row in CustomerRecordsDGV & bringing customerId over
        public void PopulateForm(int customerId, string customerName, string address, string address2, string city, string postalCode, string country, string phone)
        {
            this.customerId = customerId;
            NameTB.Text = customerName;
            AddressTB.Text = address;
            Address2TB.Text = address2;
            PhoneTB.Text = phone;
            CityTB.Text = city;
            CountryTB.Text = country;
            PostalCodeTB.Text = postalCode;
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            using (MySqlTransaction transaction = DBConnection.Conn.BeginTransaction())
            {
                try
                {
                    UpdateCountryTable();
                    UpdateCityTable();
                    UpdateAddressTable();
                    UpdateCustomerTable();

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
                    
                    transaction.Commit();
                    MessageBox.Show($"Update successful!");
                    this.Close();
                    CustomerChanged?.Invoke(this, EventArgs.Empty);
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void UpdateCountryTable()
        { 
            string query = "SELECT countryId FROM country WHERE country = @country";
            MySqlCommand command = new MySqlCommand(query, DBConnection.Conn);
            command.Parameters.AddWithValue("@country", CountryTB.Text.ToUpper());
            MySqlDataReader reader = command.ExecuteReader();

            try
            {
                if (reader.HasRows)
                {
                    reader.Read();
                    countryId = reader.GetInt32("countryId");
                }
                else
                {
                    countryId = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading countryId: {ex.Message}");
            }
            finally
            {
                reader.Close();
            }
            try
            {
                if (countryId > 0)
                {
                    string updateQuery = "UPDATE country SET country = @country, lastUpdate = @lastUpdate, lastUpdateBy = @lastUpdateBy " +
                                     "WHERE countryId = @countryId";
                    MySqlCommand updateCmd = new MySqlCommand(updateQuery, DBConnection.Conn);
                    updateCmd.Parameters.AddWithValue("@countryId", countryId);
                    updateCmd.Parameters.AddWithValue("@country", CountryTB.Text.ToUpper());
                    updateCmd.Parameters.AddWithValue("@lastUpdate", lastUpdate.ToUniversalTime());
                    updateCmd.Parameters.AddWithValue("@lastUpdateBy", lastUpdateBy);
                    updateCmd.ExecuteNonQuery();
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void UpdateCityTable()
        {
            string query = "SELECT cityId FROM city WHERE city = @city";
            MySqlCommand command = new MySqlCommand(query, DBConnection.Conn);
            command.Parameters.AddWithValue("@city", CityTB.Text.ToUpper());
            MySqlDataReader reader = command.ExecuteReader();

            try
            {
               if(reader.HasRows)
                {
                    reader.Read();
                    cityId = reader.GetInt32("cityId");
                }
               else
                {
                    cityId = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading cityId data: {ex.Message}");
            }
            finally
            {
                reader.Close();
            }

            try
            {
                //Get countryId
                string query2 = "SELECT countryId FROM country WHERE country = @country";
                MySqlCommand command2 = new MySqlCommand(query2, DBConnection.Conn);
                command2.Parameters.AddWithValue("@country", CountryTB.Text.ToUpper());
                MySqlDataReader reader2 = command2.ExecuteReader();
                while (reader2.Read())
                {
                    countryId = reader2.GetInt32("countryId");
                }
                reader2.Close();

                if (cityId > 0)
                {
                    string updateQuery = "UPDATE city SET city = @city, countryId = @countryId, lastUpdate = @lastUpdate, lastUpdateBy = @lastUpdateBy" +
                                            " WHERE cityId = @cityId";
                    MySqlCommand updateCmd = new MySqlCommand(updateQuery, DBConnection.Conn);
                    updateCmd.Parameters.AddWithValue("@cityId", cityId);
                    updateCmd.Parameters.AddWithValue("@city", CityTB.Text.ToUpper());
                    updateCmd.Parameters.AddWithValue("@countryId", countryId);
                    updateCmd.Parameters.AddWithValue("lastUpdate", lastUpdate.ToUniversalTime());
                    updateCmd.Parameters.AddWithValue("lastUpdateBy", lastUpdateBy);
                    updateCmd.ExecuteNonQuery();
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void UpdateAddressTable()
        {   
            string query = "SELECT addressId FROM address WHERE address = @address AND address2 = @address2" +
                " AND postalCode = @postalCode AND phone = @phone";
            MySqlCommand command = new MySqlCommand(query, DBConnection.Conn);
            command.Parameters.AddWithValue("@address", AddressTB.Text.ToUpper());
            command.Parameters.AddWithValue("@address2", Address2TB.Text.ToUpper());
            command.Parameters.AddWithValue("@postalCode", PostalCodeTB.Text.ToUpper());
            command.Parameters.AddWithValue("@phone", PhoneTB.Text.ToUpper());
            MySqlDataReader reader = command.ExecuteReader();

            try
            {
                if (reader.HasRows)
                {
                    reader.Read();
                    addressId = reader.GetInt32("addressId");
                }
                else
                {
                    addressId = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading addressId data: {ex.Message}");
            }
            finally
            {
                reader.Close();
            }

            try
            {
                //Get cityId
                string query2 = "SELECT cityId FROM city WHERE city = @city";
                MySqlCommand command2 = new MySqlCommand(query2, DBConnection.Conn);
                command2.Parameters.AddWithValue("@city", CityTB.Text.ToUpper());
                MySqlDataReader reader2 = command2.ExecuteReader();

                while (reader2.Read())
                {
                    cityId = reader2.GetInt32("cityId");
                }
                reader2.Close();

                if (addressId > 0)
                {
                    string updateQuery = "UPDATE address SET address = @address, address2 = @address2, cityId = @cityId, postalCode = @postalCode, " +
                        "phone = @phone, lastUpdate = @lastUpdate, lastUpdateBy = @lastUpdateBy" +
                        " WHERE addressId = @addressId";
                    MySqlCommand updateCmd = new MySqlCommand(updateQuery, DBConnection.Conn);
                    updateCmd.Parameters.AddWithValue("@addressId", addressId);
                    updateCmd.Parameters.AddWithValue("@address", AddressTB.Text.ToUpper());
                    updateCmd.Parameters.AddWithValue("@address2", Address2TB.Text.ToUpper());
                    updateCmd.Parameters.AddWithValue("@cityId", cityId);
                    updateCmd.Parameters.AddWithValue("@postalCode", PostalCodeTB.Text.ToUpper());
                    updateCmd.Parameters.AddWithValue("@phone", PhoneTB.Text.ToUpper());
                    updateCmd.Parameters.AddWithValue("lastUpdate", lastUpdate.ToUniversalTime());
                    updateCmd.Parameters.AddWithValue("lastUpdateBy", lastUpdateBy);
                    updateCmd.ExecuteNonQuery();
                }
                else
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void UpdateCustomerTable()
        {
            int active;
            bool isActive = true;
            if (isActive == true)
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
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                addressId = reader.GetInt32("addressId");
            }
            reader.Close();

            try
            {
                string updateQuery = "UPDATE customer SET customerName = @customerName, addressId = @addressId, active = @active," +
                    " lastUpdate = @lastUpdate, lastUpdateBy = @lastUpdateBy" +
                    " WHERE customerId = @customerId";
                MySqlCommand updateCmd = new MySqlCommand(updateQuery, DBConnection.Conn);
                updateCmd.Parameters.AddWithValue("@customerId", customerId);
                updateCmd.Parameters.AddWithValue("@customerName", NameTB.Text.ToUpper());
                updateCmd.Parameters.AddWithValue("@addressId", addressId);
                updateCmd.Parameters.AddWithValue("@active", active);
                updateCmd.Parameters.AddWithValue("@lastUpdate", lastUpdate.ToUniversalTime());
                updateCmd.Parameters.AddWithValue("@lastUpdateBy", lastUpdateBy);
                updateCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

        private void Address2TB_TextChanged(object sender, EventArgs e)
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
            Validation.NumericValueCheck(sender, e);
        }

        private void PhoneTB_TextChanged_1(object sender, EventArgs e)
        {
            Validation.StringValueCheck(sender, e);
        }
    }
}





