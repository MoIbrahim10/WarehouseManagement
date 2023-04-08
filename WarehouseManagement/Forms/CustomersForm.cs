using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarehouseManagement.Forms
{
    public partial class CustomersForm : Form
    {
        WarehouseManagementDBEntities warehouseManagementDB = new WarehouseManagementDBEntities();
        private Customer currentCustomer;
        private WarehouseCustomer currentWarehouseCustomer;
        private bool isEdit;
        private bool isEditWarehouseCustomer;

        public CustomersForm()
        {
            InitializeComponent();
            UpdateGridComboViews();

            allDataComboBox.SelectedItem = null;

            isEdit = false;
            isEditWarehouseCustomer = false;

            tabControl1.TabPages.Remove(CustomersAddEditPage);
            tabControl1.TabPages.Remove(customerWarehouseEditPage);

        }

        #region CRUD For Customers
        private void UpdateGridComboViews()
        {

            var customers = warehouseManagementDB.Customers
                                        .Select(customer => new { customer.CustomerID, customer.CustomerName, customer.CustomerEmail, customer.CustomerPhone, customer.CustomerMobile, customer.CustomerFax, customer.CustomerWebsite })
                                        .ToList();
            customerDataGrid.DataSource = customers;

            allDataComboBox.DataSource = customers;
            allDataComboBox.DisplayMember = "CustomerName";
            allDataComboBox.ValueMember = "CustomerID";


        }

        private void DataSearchBar_TextChanged(object sender, EventArgs e)
        {

            string searchQuery = dataSearchBar.Text.ToLower();

            try
            {
                var filteredData = warehouseManagementDB.Customers
                    .Where(customer =>
                        customer.CustomerID.ToString().ToLower().Contains(searchQuery) ||
                        customer.CustomerName.ToLower().Contains(searchQuery) ||
                        customer.CustomerEmail.ToLower().Contains(searchQuery) ||
                        customer.CustomerPhone.ToLower().Contains(searchQuery) ||
                        customer.CustomerMobile.ToLower().Contains(searchQuery) ||
                        customer.CustomerFax.ToLower().Contains(searchQuery) ||
                        customer.CustomerWebsite.ToLower().Contains(searchQuery))
                    .Select(customer => new { customer.CustomerID, customer.CustomerName, customer.CustomerEmail, customer.CustomerPhone, customer.CustomerMobile, customer.CustomerFax, customer.CustomerWebsite })
                    .ToList();

                customerDataGrid.DataSource = filteredData;
                if (filteredData.Count == 0)
                {
                    MessageBox.Show("No matching data found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while searching for data: " + ex.Message);
            }


        }

        private void CustomerDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < customerDataGrid.Rows.Count)
            {
                int customerId = (int)customerDataGrid.Rows[e.RowIndex].Cells[0].Value;
                currentCustomer = warehouseManagementDB.Customers.Find(customerId);
                allDataComboBox.SelectedItem = currentCustomer.CustomerName;
            }
        }

        private void ChangeToEditAddPage()
        {
            tabControl1.TabPages.Remove(CustomersListPage);
            tabControl1.TabPages.Add(CustomersAddEditPage);

            if (!isEdit)
            {
                txtCustomerName.Text = txtCustomerEmail.Text = txtCustomerPhone.Text = txtCustomerMobile.Text = txtCustomerFax.Text = txtCustomerWebsite.Text = "";

                CustomersAddEditPage.Text = "Add Customer";
                AddEditCustomerBtn.Text = "Add";
            }
            else
            {
                CustomersAddEditPage.Text = "Edit Customer";
                AddEditCustomerBtn.Text = "Update";

                txtCustomerName.Text = currentCustomer.CustomerName;
                txtCustomerEmail.Text = currentCustomer.CustomerEmail;
                txtCustomerPhone.Text = currentCustomer.CustomerPhone;
                txtCustomerMobile.Text = currentCustomer.CustomerMobile;
                txtCustomerFax.Text = currentCustomer.CustomerFax;
                txtCustomerWebsite.Text = currentCustomer.CustomerWebsite;

            }
        }
        private void AddCustomerButton_Click(object sender, EventArgs e)
        {
            isEdit = false;
            ChangeToEditAddPage();
        }

        private void EditCustomerButton_Click(object sender, EventArgs e)
        {
            if (currentCustomer == null)
            {
                MessageBox.Show("Please make sure to choose warehouse first", "Warning",
                                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            isEdit = true;
            ChangeToEditAddPage();
        }

        private void DeleteCustomerButton_Click(object sender, EventArgs e)
        {
            if (currentCustomer == null)
            {
                MessageBox.Show("Please select a customer to delete.", "Warning",
                                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show("Are you sure you want to delete the selected customer?", "Warning",
                     MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    warehouseManagementDB.Customers.Remove(currentCustomer);
                    warehouseManagementDB.SaveChanges();

                    UpdateGridComboViews();
                    MessageBox.Show("Customer deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while deleting the customer. Error details: {ex.Message}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(CustomersAddEditPage);
            tabControl1.TabPages.Add(CustomersListPage);
        }

        private void AddEditCustomerBtn_Click(object sender, EventArgs e)
        {
            // Validate input fields
            if (!IsValidName(txtCustomerName.Text))
            {
                MessageBox.Show("Please enter a valid customer name (3-30 characters, string or spaces only).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!IsValidEmail(txtCustomerEmail.Text))
            {
                MessageBox.Show("Please enter a valid email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!IsValidPhone(txtCustomerPhone.Text))
            {
                MessageBox.Show("Please enter a valid phone number (10 digits starting with 02).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!IsValidMobile(txtCustomerMobile.Text))
            {
                MessageBox.Show("Please enter a valid mobile number (+20 followed by 10, 11, 12, or 15 and 8 digits).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!string.IsNullOrEmpty(txtCustomerFax.Text) && !IsValidPhone(txtCustomerFax.Text))
            {
                MessageBox.Show("Please enter a valid fax number (10 digits starting with 02).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!IsValidWebsite(txtCustomerWebsite.Text))
            {
                MessageBox.Show("Please enter a valid website address (e.g., www.example.com).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }




            if (isEdit)
            {
                currentCustomer.CustomerName = txtCustomerName.Text;
                currentCustomer.CustomerEmail = txtCustomerEmail.Text;
                currentCustomer.CustomerPhone = txtCustomerPhone.Text;
                currentCustomer.CustomerMobile = txtCustomerMobile.Text;
                currentCustomer.CustomerFax = txtCustomerFax.Text;
                currentCustomer.CustomerWebsite = txtCustomerWebsite.Text;


                warehouseManagementDB.SaveChanges();

                UpdateGridComboViews();
                MessageBox.Show("Customer updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Customer newCustomer = new Customer
                {
                    CustomerName = txtCustomerName.Text,
                    CustomerEmail = txtCustomerEmail.Text,
                    CustomerPhone = txtCustomerPhone.Text,
                    CustomerMobile = txtCustomerMobile.Text,
                    CustomerFax = txtCustomerFax.Text,
                    CustomerWebsite = txtCustomerWebsite.Text

                };

                warehouseManagementDB.Customers.Add(newCustomer);
                warehouseManagementDB.SaveChanges();

                UpdateGridComboViews();
                MessageBox.Show("Customer  saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            BackBtn_Click(null, null);

        }

        private bool IsValidName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return false;
            }
            name = name.Trim();
            if (name.Length < 3 || name.Length > 30)
            {
                return false;
            }
            foreach (char c in name)
            {
                if (!char.IsLetter(c) && !char.IsWhiteSpace(c))
                {
                    return false;
                }
            }
            return true;
        }


        private bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                return false;
            }
            return Regex.IsMatch(email, @"^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$");
        }

        private bool IsValidPhone(string phone)
        {
            if (string.IsNullOrWhiteSpace(phone))
            {
                return false;
            }
            return Regex.IsMatch(phone, @"^02[0-9]{8}$");
        }

        private bool IsValidMobile(string mobile)
        {
            if (string.IsNullOrWhiteSpace(mobile))
            {
                return false;
            }
            return
            Regex.IsMatch(mobile, @"^(\+201|01|00201)[0-2,5]{1}[0-9]{8}");
        }

        private bool IsValidWebsite(string website)
        {
            if (string.IsNullOrWhiteSpace(website))
            {
                return false;
            }

            website = website.Trim().ToLower();

            if (!website.StartsWith("www.") || !website.EndsWith(".com"))
            {
                return false;
            }

            website = website.Substring(4, website.Length - 8);

            if (!website.All(char.IsLetterOrDigit))
            {
                return false;
            }

            return true;
        }
        #endregion

        #region CRUD For Warehouse Customer
        private void CustomerWarehousePage_Enter(object sender, EventArgs e)
        {
            PopulateCustomer();
            if (CustomerComboBox.Items.Count > 0)
            {
                CustomerComboBox.SelectedIndex = 0;
                CustomerComboBox_SelectedIndexChanged(null, null);

            }
            warehouseCustomerComboBox1.SelectedItem = null;

        }
        private void PopulateWarehouses()
        {

            var warehouses = warehouseManagementDB.Warehouses
                .Select(wh => new { wh.WarehouseID, wh.WarehouseName })
                .ToList();


            warehouseNameComboBox1.DataSource = warehouses;

            warehouseNameComboBox1.DisplayMember = "WarehouseName";
            warehouseNameComboBox1.ValueMember = "WarehouseID";

        }
        private void PopulateCustomer()
        {

            var customers = warehouseManagementDB.Customers
                .Select(customer => new { customer.CustomerID, customer.CustomerName })
                .ToList();

            CustomerComboBox.DataSource = customerNameComboBox.DataSource = customers;

            CustomerComboBox.DisplayMember = customerNameComboBox.DisplayMember = "CustomerName";
            CustomerComboBox.ValueMember = customerNameComboBox.ValueMember = "CustomerID";

        }
        private void CustomerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomerComboBox.SelectedItem != null && CustomerComboBox.SelectedValue is int)
            {
                int customerID = (int)CustomerComboBox.SelectedValue;
                UpdateCustomerWarehousesDataGrid(customerID);
            }
        }

        private void UpdateCustomerWarehousesDataGrid(int spplierID)
        {

            var customerWarehouses = warehouseManagementDB.WarehouseCustomers
                           .Where(sw => sw.CustomerID == spplierID)
                           .Select(sw => new
                           {
                               sw.WarehouseCustomerID,
                               sw.CustomerID,
                               sw.Customer.CustomerName,
                               sw.WarehouseID,
                               sw.Warehouse.WarehouseName
                           })
                           .ToList();


            var bindingSource = new BindingSource();
            bindingSource.DataSource = customerWarehouses;

            customerWarehousesDataGridView.DataSource = bindingSource;


            warehouseCustomerComboBox1.DataSource = bindingSource;
            warehouseCustomerComboBox1.DisplayMember = "WarehouseName";
            warehouseCustomerComboBox1.ValueMember = "WarehouseID";


        }


        private void CustomerWarehousesDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < customerWarehousesDataGridView.Rows.Count)
            {
                int WarehouseId = (int)customerWarehousesDataGridView.Rows[e.RowIndex].Cells[0].Value;
                currentWarehouseCustomer = warehouseManagementDB.WarehouseCustomers.Find(WarehouseId);
                warehouseCustomerComboBox1.SelectedIndex = e.RowIndex;
            }
        }
        // to filter the grid based on the data in search bar
        private void SearchCustomerWarehousetextBox_TextChanged(object sender, EventArgs e)
        {

            string searchQuery = searchCustomerWarehousetextBox.Text.ToLower();

            try
            {
                var filteredData = warehouseManagementDB.WarehouseCustomers
                    .Where(ws =>
                        ws.WarehouseCustomerID.ToString().Contains(searchQuery) ||
                        ws.CustomerID.ToString().Contains(searchQuery) ||
                        ws.WarehouseID.ToString().Contains(searchQuery) ||
                        ws.Customer.CustomerName.ToLower().Contains(searchQuery) ||
                        ws.Warehouse.WarehouseName.ToLower().Contains(searchQuery))
                    .Select(sw => new
                    {
                        sw.WarehouseCustomerID,
                        sw.CustomerID,
                        sw.Customer.CustomerName,
                        sw.WarehouseID,
                        sw.Warehouse.WarehouseName
                    })
                    .ToList();

                customerWarehousesDataGridView.DataSource = filteredData;
                if (filteredData.Count == 0)
                {
                    MessageBox.Show("No matching data found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while searching for data: " + ex.Message);
            }


        }


        private void AddCustomerWarehouseButton_Click(object sender, EventArgs e)
        {
            isEditWarehouseCustomer = false;
            ChangeToEditAddPageForCustomerWarehouse();
        }

        private void EditCustomerWarehouseButton_Click(object sender, EventArgs e)
        {
            if (currentWarehouseCustomer == null)
            {
                MessageBox.Show("Please make sure to choose warehouse first", "Warning",
                                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            isEditWarehouseCustomer = true;
            ChangeToEditAddPageForCustomerWarehouse();
        }

        private void DeleteCustomerWarehouseButton_Click(object sender, EventArgs e)
        {
            if (currentWarehouseCustomer == null)
            {
                MessageBox.Show("Please select a warehouse to delete.", "Warning",
                                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show("Are you sure you want to delete the selected warehouse?", "Warning",
                     MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    warehouseManagementDB.WarehouseCustomers.Remove(currentWarehouseCustomer);
                    warehouseManagementDB.SaveChanges();

                    CustomerComboBox_SelectedIndexChanged(null, null);
                    MessageBox.Show("Warehouse deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while deleting the warehouse. Error details: {ex.Message}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ChangeToEditAddPageForCustomerWarehouse()
        {
            tabControl1.TabPages.Remove(customerWarehousePage);
            tabControl1.TabPages.Add(customerWarehouseEditPage);
            PopulateWarehouses();


            if (!isEditWarehouseCustomer)
            {

                customerWarehouseEditPage.Text = "Add warehouse to customer";
                saveWarehouseToCustomerBtn.Text = "Add";
            }
            else
            {
                customerWarehouseEditPage.Text = "Edit customer warehouse";
                saveWarehouseToCustomerBtn.Text = "Update";



                customerNameComboBox.SelectedValue = currentWarehouseCustomer.CustomerID;
                warehouseNameComboBox1.SelectedValue = currentWarehouseCustomer.WarehouseID;

            }
            tabControl1.SelectedIndex = 1;


        }

        private void SaveItemToSupllierWarehouses(object sender, EventArgs e)
        {
            // Validate the input values
            if (customerNameComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a customer.");
                return;
            }

            if (warehouseNameComboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select a warehouse.");
                return;
            }


            if (isEditWarehouseCustomer)
            {
                currentWarehouseCustomer.WarehouseID = (int)warehouseNameComboBox1.SelectedValue;
                currentWarehouseCustomer.CustomerID = (int)customerNameComboBox.SelectedValue;


                warehouseManagementDB.SaveChanges();


                MessageBox.Show("customer warehouse updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int warehouseId = (int)warehouseNameComboBox1.SelectedValue;
                int customerId = (int)customerNameComboBox.SelectedValue;

                var isWarehouseCustomerExist = warehouseManagementDB.WarehouseCustomers
                                                                                .FirstOrDefault(ws => ws.CustomerID == customerId && ws.WarehouseID == warehouseId);

                if (isWarehouseCustomerExist != null)
                {
                    MessageBox.Show("Warehouse already exists in the customer warehouseList.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    var warehouseCustomer = new WarehouseCustomer()
                    {

                        CustomerID = customerId,
                        WarehouseID = warehouseId
                    };

                    warehouseManagementDB.WarehouseCustomers.Add(warehouseCustomer);
                }

                // save changes to the database
                warehouseManagementDB.SaveChanges();

                MessageBox.Show("Warehouse customer saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            BackToCustomerWarehouseBtn_Click(null, null);

        }

        private void BackToCustomerWarehouseBtn_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(customerWarehouseEditPage);
            tabControl1.TabPages.Add(customerWarehousePage);
            tabControl1.SelectedIndex = 1;
        }


        #endregion
    }
}
