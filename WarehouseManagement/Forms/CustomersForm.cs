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
        private bool isEdit;
        public CustomersForm()
        {
            InitializeComponent();
            UpdateGridComboViews();
            allDataComboBox.SelectedItem = null;

            isEdit = false;
            tabControl1.TabPages.Remove(CustomersAddEditPage);
        }

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


    }
}
