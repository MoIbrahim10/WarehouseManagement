using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarehouseManagement.Forms
{
    public partial class SuppliersForm : Form
    {

        WarehouseManagementDBEntities warehouseManagementDB = new WarehouseManagementDBEntities();
        private Supplier currentSupplier;
        private bool isEdit;
        public SuppliersForm()
        {
            InitializeComponent();
            UpdateGridComboViews();
            allDataComboBox.SelectedItem = null;

            isEdit = false;
            tabControl1.TabPages.Remove(SuppliersAddEditPage);
        }

        private void UpdateGridComboViews()
        {

            var Suppliers = warehouseManagementDB.Suppliers
                                        .Select(Supplier => new { Supplier.SupplierID, Supplier.SupplierName, Supplier.SupplierEmail, Supplier.SupplierPhone, Supplier.SupplierMobile, Supplier.SupplierFax, Supplier.SupplierWebsite })
                                        .ToList();
            supplierDataGrid.DataSource = Suppliers;

            allDataComboBox.DataSource = Suppliers;
            allDataComboBox.DisplayMember = "SupplierName";
            allDataComboBox.ValueMember = "SupplierID";


        }

        private void DataSearchBar_TextChanged(object sender, EventArgs e)
        {

            string searchQuery = dataSearchBar.Text.ToLower();

            try
            {
                var filteredData = warehouseManagementDB.Suppliers
                    .Where(Supplier =>
                        Supplier.SupplierID.ToString().ToLower().Contains(searchQuery) ||
                        Supplier.SupplierName.ToLower().Contains(searchQuery) ||
                        Supplier.SupplierEmail.ToLower().Contains(searchQuery) ||
                        Supplier.SupplierPhone.ToLower().Contains(searchQuery) ||
                        Supplier.SupplierMobile.ToLower().Contains(searchQuery) ||
                        Supplier.SupplierFax.ToLower().Contains(searchQuery) ||
                        Supplier.SupplierWebsite.ToLower().Contains(searchQuery))
                    .Select(Supplier => new { Supplier.SupplierID, Supplier.SupplierName, Supplier.SupplierEmail, Supplier.SupplierPhone, Supplier.SupplierMobile, Supplier.SupplierFax, Supplier.SupplierWebsite })
                    .ToList();

                supplierDataGrid.DataSource = filteredData;
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

        private void SupplierDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < supplierDataGrid.Rows.Count)
            {
                int SupplierId = (int)supplierDataGrid.Rows[e.RowIndex].Cells[0].Value;
                currentSupplier = warehouseManagementDB.Suppliers.Find(SupplierId);
                allDataComboBox.SelectedItem = currentSupplier.SupplierName;
            }
        }

        private void ChangeToEditAddPage()
        {
            tabControl1.TabPages.Remove(SuppliersListPage);
            tabControl1.TabPages.Add(SuppliersAddEditPage);

            if (!isEdit)
            {
                txtSupplierName.Text = txtSupplierEmail.Text = txtSupplierPhone.Text = txtSupplierMobile.Text = txtSupplierFax.Text = txtSupplierWebsite.Text = "";

                SuppliersAddEditPage.Text = "Add Supplier";
                AddEditSupplierBtn.Text = "Add";
            }
            else
            {
                SuppliersAddEditPage.Text = "Edit Supplier";
                AddEditSupplierBtn.Text = "Update";

                txtSupplierName.Text = currentSupplier.SupplierName;
                txtSupplierEmail.Text = currentSupplier.SupplierEmail;
                txtSupplierPhone.Text = currentSupplier.SupplierPhone;
                txtSupplierMobile.Text = currentSupplier.SupplierMobile;
                txtSupplierFax.Text = currentSupplier.SupplierFax;
                txtSupplierWebsite.Text = currentSupplier.SupplierWebsite;

            }
        }
        private void AddSupplierButton_Click(object sender, EventArgs e)
        {
            isEdit = false;
            ChangeToEditAddPage();
        }

        private void EditSupplierButton_Click(object sender, EventArgs e)
        {
            if (currentSupplier == null)
            {
                MessageBox.Show("Please make sure to choose warehouse first", "Warning",
                                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            isEdit = true;
            ChangeToEditAddPage();
        }

        private void DeleteSupplierButton_Click(object sender, EventArgs e)
        {
            if (currentSupplier == null)
            {
                MessageBox.Show("Please select a Supplier to delete.", "Warning",
                                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show("Are you sure you want to delete the selected Supplier?", "Warning",
                     MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    warehouseManagementDB.Suppliers.Remove(currentSupplier);
                    warehouseManagementDB.SaveChanges();

                    UpdateGridComboViews();
                    MessageBox.Show("Supplier deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while deleting the Supplier. Error details: {ex.Message}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(SuppliersAddEditPage);
            tabControl1.TabPages.Add(SuppliersListPage);
        }

        private void AddEditSupplierBtn_Click(object sender, EventArgs e)
        {
            if (!IsValidName(txtSupplierName.Text))
            {
                MessageBox.Show("Please enter a valid supplier name (3-30 characters, only letters or spaces, dots and dashes allowed).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!IsValidEmail(txtSupplierEmail.Text))
            {
                MessageBox.Show("Please enter a valid email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!IsValidPhone(txtSupplierPhone.Text))
            {
                MessageBox.Show("Please enter a valid phone number (10 digits starting with 02).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!IsValidMobile(txtSupplierMobile.Text))
            {
                MessageBox.Show("Please enter a valid mobile number (+20 followed by 10, 11, 12, or 15 and 8 digits).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!string.IsNullOrEmpty(txtSupplierFax.Text) && !IsValidPhone(txtSupplierFax.Text))
            {
                MessageBox.Show("Please enter a valid fax number (10 digits starting with 02).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!IsValidWebsite(txtSupplierWebsite.Text))
            {
                MessageBox.Show("Please enter a valid website address (e.g., www.example.com).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }




            if (isEdit)
            {
                currentSupplier.SupplierName = txtSupplierName.Text;
                currentSupplier.SupplierEmail = txtSupplierEmail.Text;
                currentSupplier.SupplierPhone = txtSupplierPhone.Text;
                currentSupplier.SupplierMobile = txtSupplierMobile.Text;
                currentSupplier.SupplierFax = txtSupplierFax.Text;
                currentSupplier.SupplierWebsite = txtSupplierWebsite.Text;


                warehouseManagementDB.SaveChanges();

                UpdateGridComboViews();
                MessageBox.Show("Supplier updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Supplier newSupplier = new Supplier
                {
                    SupplierName = txtSupplierName.Text,
                    SupplierEmail = txtSupplierEmail.Text,
                    SupplierPhone = txtSupplierPhone.Text,
                    SupplierMobile = txtSupplierMobile.Text,
                    SupplierFax = txtSupplierFax.Text,
                    SupplierWebsite = txtSupplierWebsite.Text

                };

                warehouseManagementDB.Suppliers.Add(newSupplier);
                warehouseManagementDB.SaveChanges();

                UpdateGridComboViews();
                MessageBox.Show("Supplier  saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if (!char.IsLetter(c) && !char.IsWhiteSpace(c) && c != '.' && c != '-')
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
