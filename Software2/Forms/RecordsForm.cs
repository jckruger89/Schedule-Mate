using MySql.Data.MySqlClient;
using Software2.Database;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Software2
{
    public partial class RecordsForm : CustomForm
    {
        int appointmentId = 0;
        int userId = 0;
        int customerId = 0;
        string customerName = String.Empty;
        string type = String.Empty;
        DateTime start;
        DateTime end;

        public RecordsForm()
        {
            InitializeComponent();
            CustomerRecordsDGV.AutoGenerateColumns = false;
            CustomerRecordsDGV.Columns.Clear();
            CustomerRecordsDGV.AllowUserToAddRows = false;
            CustomerRecordsDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            CustomerRecordsDGV.BackgroundColor = Color.CadetBlue;
            CustomerRecordsDGV.BorderStyle = BorderStyle.None;

            AppointmentsDGV.AutoGenerateColumns = false;
            AppointmentsDGV.Columns.Clear();
            AppointmentsDGV.AllowUserToAddRows = false;
            AppointmentsDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            AppointmentsDGV.BackgroundColor = Color.CadetBlue;
            AppointmentsDGV.BorderStyle = BorderStyle.None;

        }
        private void RecordsForm_Load(object sender, EventArgs e)
        {
            //Setting Column Names for CustomerRecordsDGV
            DataGridViewTextBoxColumn colCustomerId = new DataGridViewTextBoxColumn();
            colCustomerId.DataPropertyName = "customerId";
            colCustomerId.HeaderText = "Customer ID";
            CustomerRecordsDGV.Columns.Add(colCustomerId);
            colCustomerId.Visible = true;

            DataGridViewTextBoxColumn colCustomerName = new DataGridViewTextBoxColumn();
            colCustomerName.DataPropertyName = "customerName";
            colCustomerName.HeaderText = "Name";
            CustomerRecordsDGV.Columns.Add(colCustomerName);

            DataGridViewTextBoxColumn colAddress = new DataGridViewTextBoxColumn();
            colAddress.DataPropertyName = "address";
            colAddress.HeaderText = "Address";
            CustomerRecordsDGV.Columns.Add(colAddress);

            DataGridViewTextBoxColumn colAddress2 = new DataGridViewTextBoxColumn();
            colAddress2.DataPropertyName = "address2";
            colAddress2.HeaderText = "Address2";
            CustomerRecordsDGV.Columns.Add(colAddress2);

            DataGridViewTextBoxColumn colCity = new DataGridViewTextBoxColumn();
            colCity.DataPropertyName = "city";
            colCity.HeaderText = "City";
            CustomerRecordsDGV.Columns.Add(colCity);

            DataGridViewTextBoxColumn colPostalCode = new DataGridViewTextBoxColumn();
            colPostalCode.DataPropertyName = "postalCode";
            colPostalCode.HeaderText = "Postal Code";
            CustomerRecordsDGV.Columns.Add(colPostalCode);

            DataGridViewTextBoxColumn colCountry = new DataGridViewTextBoxColumn();
            colCountry.DataPropertyName = "country";
            colCountry.HeaderText = "Country";
            CustomerRecordsDGV.Columns.Add(colCountry);

            DataGridViewTextBoxColumn colPhone = new DataGridViewTextBoxColumn();
            colPhone.DataPropertyName = "phone";
            colPhone.HeaderText = "Phone";
            CustomerRecordsDGV.Columns.Add(colPhone);

            //Setting Column Names for AppointmentsDGV
            DataGridViewTextBoxColumn appointmentId = new DataGridViewTextBoxColumn();
            appointmentId.DataPropertyName = "appointmentId";
            appointmentId.HeaderText = "Appointment ID";
            AppointmentsDGV.Columns.Add(appointmentId);
            appointmentId.Visible = false;

            DataGridViewTextBoxColumn userId = new DataGridViewTextBoxColumn();
            userId.DataPropertyName = "userId";
            userId.HeaderText = "User ID";
            AppointmentsDGV.Columns.Add(userId);
            userId.Visible = true;

            DataGridViewTextBoxColumn customerId = new DataGridViewTextBoxColumn();
            customerId.DataPropertyName = "customerId";
            customerId.HeaderText = "Customer ID";
            AppointmentsDGV.Columns.Add(customerId);
            customerId.Visible = true;

            DataGridViewTextBoxColumn customerName = new DataGridViewTextBoxColumn();
            customerName.DataPropertyName = "customerName";
            customerName.HeaderText = "Name";
            AppointmentsDGV.Columns.Add(customerName);
            customerName.Visible = true;

            DataGridViewTextBoxColumn type = new DataGridViewTextBoxColumn();
            type.DataPropertyName = "type";
            type.HeaderText = "Type";
            AppointmentsDGV.Columns.Add(type);
            type.Visible = true;

            DataGridViewTextBoxColumn start = new DataGridViewTextBoxColumn();
            start.DataPropertyName = "start";
            start.HeaderText = "Start";
            AppointmentsDGV.Columns.Add(start);
            start.Visible = true;

            DataGridViewTextBoxColumn end = new DataGridViewTextBoxColumn();
            end.DataPropertyName = "end";
            end.HeaderText = "End";
            AppointmentsDGV.Columns.Add(end);
            end.Visible = true;

            //Bringing data in from MySQL Database into my two Data Grids
            try
            {
                LoadCustomerRecords();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                LoadAppointments();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadCustomerRecords()
        {
            string query = "SELECT customerId, customerName, address, address2, city, postalCode, country, phone FROM customer, address, city, country" +
                         " WHERE customer.addressId = address.addressId AND address.cityId = city.cityId" +
                         " AND city.countryId = country.countryId;";
            MySqlCommand cmd = new MySqlCommand(query, DBConnection.Conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            bindingSource.DataSource = dataTable;
            CustomerRecordsDGV.DataSource = bindingSource;
            dataTable.DefaultView.Sort = "customerName ASC";
            CustomerRecordsDGV.Refresh();
        }

        public void LoadAppointments()
        {
            string query = "SELECT appointment.appointmentId, appointment.customerId, appointment.userId, appointment.type, appointment.start, " +
                "appointment.end, customer.customerName FROM appointment JOIN user ON appointment.userId = user.userId JOIN customer" +
                " ON appointment.customerId = customer.customerId";
            MySqlCommand command = new MySqlCommand(query, DBConnection.Conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            //Convert UTC times to local times
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
            bindingSource1.DataSource = dataTable;
            AppointmentsDGV.DataSource = bindingSource1;
            dataTable.DefaultView.Sort = "start ASC";
            AppointmentsDGV.Refresh();
        }

        private void CustomerAddBtn_Click(object sender, EventArgs e)
        {
            AddCustomer addCustomer = new AddCustomer();
            //If CustomerChanged event is invoked run this added method
            addCustomer.CustomerChanged += UpdateChangedCustomer;
            addCustomer.ShowDialog();
        }

        private void UpdateChangedCustomer(object sender, EventArgs e)
        {
            LoadCustomerRecords();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CustomerSearchBtn_Click(object sender, EventArgs e)
        {
            CustomerRecordsDGV.ClearSelection();
            CustomerRecordsDGV.MultiSelect = false;
            string searchText = CustomerSearchTB.Text.Trim().ToUpper();
            if (searchText.Length > 0)
            {
                foreach (DataGridViewRow row in CustomerRecordsDGV.Rows)
                {
                    string customer = row.Cells[1].Value.ToString().ToUpper();
                    bool isMatch = customer.Contains(searchText);
                    if (isMatch == false)
                    {
                        CustomerRecordsDGV.CurrentCell = null;
                    }
                    else
                    {
                        row.Selected = true;
                        CustomerRecordsDGV.FirstDisplayedScrollingRowIndex = CustomerRecordsDGV.SelectedRows[0].Index;
                    }
                }
            }
            else
            {
                MessageBox.Show("No search information was entered.");
            }
        }

        private void CustomerModifyBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //Check if any row is selected
                if (CustomerRecordsDGV.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = CustomerRecordsDGV.SelectedRows[0];

                    int customerId = Convert.ToInt32(selectedRow.Cells[0].Value);
                    string customerName = selectedRow.Cells[1].Value.ToString().ToUpper();
                    string address = selectedRow.Cells[2].Value.ToString().ToUpper();
                    string address2 = selectedRow.Cells[3].Value != DBNull.Value && selectedRow.Cells[3].Value != null
                        ? selectedRow.Cells[3].Value.ToString()
                        : string.Empty;
                    string city = selectedRow.Cells[4].Value.ToString().ToUpper();
                    string postalCode = selectedRow.Cells[5].Value.ToString().ToUpper();
                    string country = selectedRow.Cells[6].Value.ToString().ToUpper();
                    string phone = selectedRow.Cells[7].Value.ToString();

                    ModifyCustomer modifyCustomer = new ModifyCustomer();
                    modifyCustomer.PopulateForm(customerId, customerName, address, address2, city, postalCode, country, phone);
                    //If CustomerChanged event is invoked run this added method
                    modifyCustomer.CustomerChanged += UpdateChangedCustomer;
                    modifyCustomer.ShowDialog();
                    LoadAppointments();
                }

                else
                {
                    MessageBox.Show("Please select a customer to update.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CustomersDeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //Check if any row is selected
                if (CustomerRecordsDGV.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = CustomerRecordsDGV.SelectedRows[0];
                    int customerId = Convert.ToInt32(selectedRow.Cells[0].Value);

                    //Check to see if customerId has an existing appointment in AppointmentDGV
                    BindingSource bindingSource = (BindingSource)AppointmentsDGV.DataSource;
                    DataTable dataTable = (DataTable)bindingSource.DataSource;

                    bool appointmentExists = dataTable.AsEnumerable().Any(row => row.Field<int>("customerId") == customerId);
                    if (appointmentExists == true)
                    {
                        MessageBox.Show("Customer has an existing appointment scheduled. Must delete all apointments before customer can be removed.");
                    }
                    else
                    {
                        string customerName = selectedRow.Cells[1].Value.ToString().ToUpper();
                        string address = selectedRow.Cells[2].Value.ToString().ToUpper();
                        string address2 = selectedRow.Cells[3].Value != DBNull.Value && selectedRow.Cells[3].Value != null
                            ? selectedRow.Cells[3].Value.ToString()
                            : string.Empty;
                        string city = selectedRow.Cells[4].Value.ToString().ToUpper();
                        string postalCode = selectedRow.Cells[5].Value.ToString().ToUpper();
                        string country = selectedRow.Cells[6].Value.ToString().ToUpper();
                        string phone = selectedRow.Cells[7].Value.ToString();

                        DeleteCustomerRecord deleteCustomerRecord = new DeleteCustomerRecord(customerId, customerName, address, address2, city,
                            postalCode, country, phone);
                        DialogResult dialogresult = MessageBox.Show("Are you sure you want to delete?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dialogresult == DialogResult.Yes)
                        {
                            deleteCustomerRecord.DeleteNow();
                            //If CustomerChanged event is invoked run this added method
                            deleteCustomerRecord.CustomerChanged += UpdateChangedCustomer;
                            LoadCustomerRecords();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select a customer to delete.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AppointmentsAddBtn_Click(object sender, EventArgs e)
        {
            AddAppointment addAppointment = new AddAppointment();
            addAppointment.ShowDialog();
            LoadAppointments();
        }

        private void AppointmentSearchBtn_Click(object sender, EventArgs e)
        {
            AppointmentsDGV.ClearSelection();
            AppointmentsDGV.MultiSelect = false;
            string searchText = AppointmentSearchTB.Text.Trim().ToUpper();
            if (searchText.Length > 0)
            {
                foreach (DataGridViewRow row in AppointmentsDGV.Rows)
                {
                    string appointment = row.Cells[3].Value.ToString().ToUpper();
                    bool isMatch = appointment.Contains(searchText);
                    if (isMatch == false)
                    {
                        AppointmentsDGV.CurrentCell = null;
                    }
                    else
                    {
                        row.Selected = true;
                        AppointmentsDGV.FirstDisplayedScrollingRowIndex = AppointmentsDGV.SelectedRows[0].Index;
                    }
                }
            }
            else
            {
                MessageBox.Show("No search information was entered.");
            }
        }

        private void AppointmentsDeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (AppointmentsDGV.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = AppointmentsDGV.SelectedRows[0];
                    appointmentId = Convert.ToInt32(selectedRow.Cells[0].Value);

                    DialogResult dialogresult = MessageBox.Show("Are you sure you want to delete?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogresult == DialogResult.Yes)
                    {
                        MySqlCommand cmd = new MySqlCommand("DELETE FROM appointment WHERE appointmentId = @appointmentId", DBConnection.Conn);
                        cmd.Parameters.AddWithValue("@appointmentId", appointmentId);
                        cmd.ExecuteNonQuery();
                        LoadAppointments();
                        MessageBox.Show("Appointment deleted");
                    }
                }
                else
                {
                    MessageBox.Show("Please select an appointment to delete.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AppointmentsModifyBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (AppointmentsDGV.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = AppointmentsDGV.SelectedRows[0];
                    appointmentId = Convert.ToInt32(selectedRow.Cells[0].Value);
                    userId = Convert.ToInt32(selectedRow.Cells[1].Value);
                    customerId = Convert.ToInt32(selectedRow.Cells[2].Value);
                    customerName = Convert.ToString(selectedRow.Cells[3].Value);
                    type = Convert.ToString(selectedRow.Cells[4].Value);
                    start = Convert.ToDateTime(selectedRow.Cells[5].Value);
                    end = Convert.ToDateTime(selectedRow.Cells[6].Value);

                    ModifyAppointment modifyAppointment = new ModifyAppointment(appointmentId, userId, customerId, customerName, type, start, end);
                    modifyAppointment.ShowDialog();
                    LoadAppointments();
                }
                else
                {
                    MessageBox.Show("Please select an appointment to delete.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

