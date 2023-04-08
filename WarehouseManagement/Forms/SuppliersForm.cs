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
        private WarehouseSupplier currentWarehouseSupplier;
        private ItemSupplier currentItemSupplier;
        private bool isEdit;
        private bool isEditWarehouseSupplier;
        private bool isEditItemSupplier;

        public SuppliersForm()
        {
            InitializeComponent();
            UpdateGridComboViews();
            allDataComboBox.SelectedItem = null;

            isEdit = false;
            isEditWarehouseSupplier = false;
            isEditItemSupplier = false;
            tabControl1.TabPages.Remove(SuppliersAddEditPage);
            tabControl1.TabPages.Remove(supplierWarehouseEditPage);
            tabControl1.TabPages.Remove(itemSupplierAddPage);
        }
        #region CRUD For Supplier
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

        #endregion

        #region CRUD For Warehouse Supplier
        private void supplierWarehousePage_Enter(object sender, EventArgs e)
        {
            PopulateSupplier();
            if (SupplierComboBox.Items.Count > 0)
            {
                SupplierComboBox.SelectedIndex = 0;
                SupplierComboBox_SelectedIndexChanged(null, null);

            }
            warehouseSupplierComboBox1.SelectedItem = null;

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
        private void PopulateSupplier()
        {

            var suppliers = warehouseManagementDB.Suppliers
                .Select(supplier => new { supplier.SupplierID, supplier.SupplierName })
                .ToList();

            SupplierComboBox.DataSource = supplierNameComboBox.DataSource = suppliers;

            SupplierComboBox.DisplayMember = supplierNameComboBox.DisplayMember = "SupplierName";
            SupplierComboBox.ValueMember = supplierNameComboBox.ValueMember = "SupplierID";

        }
        private void SupplierComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SupplierComboBox.SelectedItem != null && SupplierComboBox.SelectedValue is int)
            {
                int supplierID = (int)SupplierComboBox.SelectedValue;
                UpdateSupplierWarehousesDataGrid(supplierID);
            }
        }

        private void UpdateSupplierWarehousesDataGrid(int spplierID)
        {

            var supplierWarehouses = warehouseManagementDB.WarehouseSuppliers
                           .Where(sw => sw.SupplierID == spplierID)
                           .Select(sw => new
                           {
                               sw.WarehouseSupplierID,
                               sw.SupplierID,
                               sw.Supplier.SupplierName,
                               sw.WarehouseID,
                               sw.Warehouse.WarehouseName
                           })
                           .ToList();


            var bindingSource = new BindingSource();
            bindingSource.DataSource = supplierWarehouses;

            supplierWarehousesDataGridView.DataSource = bindingSource;


            warehouseSupplierComboBox1.DataSource = bindingSource;
            warehouseSupplierComboBox1.DisplayMember = "WarehouseName";
            warehouseSupplierComboBox1.ValueMember = "WarehouseID";


        }


        private void SupplierWarehousesDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < supplierWarehousesDataGridView.Rows.Count)
            {
                int WarehouseId = (int)supplierWarehousesDataGridView.Rows[e.RowIndex].Cells[0].Value;
                currentWarehouseSupplier = warehouseManagementDB.WarehouseSuppliers.Find(WarehouseId);
                warehouseSupplierComboBox1.SelectedIndex = e.RowIndex;
            }
        }
        // to filter the grid based on the data in search bar
        private void SearchSupplierWarehousetextBox_TextChanged(object sender, EventArgs e)
        {

            string searchQuery = searchSupplierWarehousetextBox.Text.ToLower();

            try
            {
                var filteredData = warehouseManagementDB.WarehouseSuppliers
                    .Where(ws =>
                        ws.WarehouseSupplierID.ToString().Contains(searchQuery) ||
                        ws.SupplierID.ToString().Contains(searchQuery) ||
                        ws.WarehouseID.ToString().Contains(searchQuery) ||
                        ws.Supplier.SupplierName.ToLower().Contains(searchQuery) ||
                        ws.Warehouse.WarehouseName.ToLower().Contains(searchQuery))
                    .Select(sw => new
                    {
                        sw.WarehouseSupplierID,
                        sw.SupplierID,
                        sw.Supplier.SupplierName,
                        sw.WarehouseID,
                        sw.Warehouse.WarehouseName
                    })
                    .ToList();

                supplierWarehousesDataGridView.DataSource = filteredData;
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


        private void AddSupplierWarehouseButton_Click(object sender, EventArgs e)
        {
            isEditWarehouseSupplier = false;
            changeToEditAddPageForSupplierWarehouse();
        }

        private void EditSupplierWarehouseButton_Click(object sender, EventArgs e)
        {
            if (currentWarehouseSupplier == null)
            {
                MessageBox.Show("Please make sure to choose warehouse first", "Warning",
                                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            isEditWarehouseSupplier = true;
            changeToEditAddPageForSupplierWarehouse();
        }

        private void DeleteSupplierWarehouseButton_Click(object sender, EventArgs e)
        {
            if (currentWarehouseSupplier == null)
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
                    warehouseManagementDB.WarehouseSuppliers.Remove(currentWarehouseSupplier);
                    warehouseManagementDB.SaveChanges();

                    SupplierComboBox_SelectedIndexChanged(null, null);
                    MessageBox.Show("Warehouse deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while deleting the warehouse. Error details: {ex.Message}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void changeToEditAddPageForSupplierWarehouse()
        {
            tabControl1.TabPages.Remove(supplierWarehousePage);
            tabControl1.TabPages.Add(supplierWarehouseEditPage);
            PopulateWarehouses();


            if (!isEditWarehouseSupplier)
            {

                supplierWarehouseEditPage.Text = "Add warehouse to supplier";
                saveWarehouseToSupplierBtn.Text = "Add";
            }
            else
            {
                supplierWarehouseEditPage.Text = "Edit supplier warehouse";
                saveWarehouseToSupplierBtn.Text = "Update";



                supplierNameComboBox.SelectedValue = currentWarehouseSupplier.SupplierID;
                warehouseNameComboBox1.SelectedValue = currentWarehouseSupplier.WarehouseID;

            }
            tabControl1.SelectedIndex = 2;


        }

        private void SaveItemToSupllierWarehouses(object sender, EventArgs e)
        {
            // Validate the input values
            if (supplierNameComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a supplier.");
                return;
            }

            if (warehouseNameComboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select a warehouse.");
                return;
            }


            if (isEditWarehouseSupplier)
            {
                currentWarehouseSupplier.WarehouseID = (int)warehouseNameComboBox1.SelectedValue;
                currentWarehouseSupplier.SupplierID = (int)supplierNameComboBox.SelectedValue;


                warehouseManagementDB.SaveChanges();


                MessageBox.Show("supplier warehouse updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int warehouseId = (int)warehouseNameComboBox1.SelectedValue;
                int supplierId = (int)supplierNameComboBox.SelectedValue;

                var isWarehouseSupplierExist = warehouseManagementDB.WarehouseSuppliers
                                                                                .FirstOrDefault(ws => ws.SupplierID == supplierId && ws.WarehouseID == warehouseId);

                if (isWarehouseSupplierExist != null)
                {
                    MessageBox.Show("Warehouse already exists in the supplier warehouseList.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    var warehouseSupplier = new WarehouseSupplier()
                    {

                        SupplierID = supplierId,
                        WarehouseID = warehouseId
                    };

                    warehouseManagementDB.WarehouseSuppliers.Add(warehouseSupplier);
                }

                // save changes to the database
                warehouseManagementDB.SaveChanges();

                MessageBox.Show("Warehouse supplier saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            backToSupplierWarehouseBtn_Click(null, null);

        }

        private void backToSupplierWarehouseBtn_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(supplierWarehouseEditPage);
            tabControl1.TabPages.Add(supplierWarehousePage);
            tabControl1.SelectedIndex = 2;
        }


        #endregion

        #region CRUD For Item Supplier
        private void SupplierItemPage_Enter(object sender, EventArgs e)
        {
            PopulateSupplierInSupplierItems();
            if (SupplierComboBox1.Items.Count > 0)
            {
                SupplierComboBox1.SelectedIndex = 0;
                SupplierComboBox1_SelectedIndexChanged(null, null);

            }
            itemSupplierComboBox.SelectedItem = null;

        }
        private void PopulateItems()
        {

            var items = warehouseManagementDB.Items
                .Select(item => new { item.ItemID, item.ItemName })
                .ToList();


            itemsNameComboBox.DataSource = items;

            itemsNameComboBox.DisplayMember = "ItemName";
            itemsNameComboBox.ValueMember = "ItemID";

        }
        private void PopulateSupplierInSupplierItems()
        {

            var suppliers = warehouseManagementDB.Suppliers
                .Select(supplier => new { supplier.SupplierID, supplier.SupplierName })
                .ToList();

            SupplierComboBox1.DataSource = suppliersNameComboBox.DataSource = suppliers;

            SupplierComboBox1.DisplayMember = suppliersNameComboBox.DisplayMember = "SupplierName";
            SupplierComboBox1.ValueMember = suppliersNameComboBox.ValueMember = "SupplierID";

        }
        private void SupplierComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SupplierComboBox1.SelectedItem != null && SupplierComboBox1.SelectedValue is int)
            {
                int supplierID = (int)SupplierComboBox1.SelectedValue;
                UpdateSupplierItemsDataGrid(supplierID);
            }
        }

        private void UpdateSupplierItemsDataGrid(int spplierID)
        {

            var supplierItems = warehouseManagementDB.ItemSuppliers
                           .Where(si => si.SupplierID == spplierID)
                           .Select(si => new
                           {
                               si.ItemSupplierID,
                               si.SupplierID,
                               si.Supplier.SupplierName,
                               si.ItemID,
                               si.Item.ItemName,
                               si.Item.ItemUnitOfMeasurement,
                               si.UnitPrice
                           })
                           .ToList();


            var bindingSource = new BindingSource
            {
                DataSource = supplierItems
            };

            supplierItemsDataGridView.DataSource = bindingSource;


            itemSupplierComboBox.DataSource = bindingSource;
            itemSupplierComboBox.DisplayMember = "ItemName";
            itemSupplierComboBox.ValueMember = "ItemID";

        }


        private void SupplierItemsDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < supplierItemsDataGridView.Rows.Count)
            {
                int ItemId = (int)supplierItemsDataGridView.Rows[e.RowIndex].Cells[0].Value;
                currentItemSupplier = warehouseManagementDB.ItemSuppliers.Find(ItemId);
                itemSupplierComboBox.SelectedIndex = e.RowIndex;
            }
        }
        // to filter the grid based on the data in search bar
        private void SearchSupplierItemtextBox_TextChanged(object sender, EventArgs e)
        {
            string searchQuery = searchSupplierItemsTextBox.Text.ToLower();

            try
            {
                var filteredData = warehouseManagementDB.ItemSuppliers
                    .Where(si =>
                        si.ItemSupplierID.ToString().Contains(searchQuery) ||
                        si.SupplierID.ToString().Contains(searchQuery) ||
                        si.ItemID.ToString().Contains(searchQuery) ||
                        si.Supplier.SupplierName.ToLower().Contains(searchQuery) ||
                        si.Item.ItemName.ToLower().Contains(searchQuery) ||
                        si.Item.ItemUnitOfMeasurement.ToLower().Contains(searchQuery) ||
                        si.UnitPrice.ToString().Contains(searchQuery))
                    .Select(si => new
                    {
                        si.ItemSupplierID,
                        si.SupplierID,
                        si.Supplier.SupplierName,
                        si.ItemID,
                        si.Item.ItemName,
                        si.Item.ItemUnitOfMeasurement,
                        si.UnitPrice
                    })
                    .ToList();



                supplierItemsDataGridView.DataSource = filteredData;
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


        private void AddSupplierItemButton_Click(object sender, EventArgs e)
        {
            isEditItemSupplier = false;
            ChangeToEditAddPageForSupplierItem();
        }

        private void EditSupplierItemButton_Click(object sender, EventArgs e)
        {
            if (currentItemSupplier == null)
            {
                MessageBox.Show("Please make sure to choose item first", "Warning",
                                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            isEditItemSupplier = true;
            ChangeToEditAddPageForSupplierItem();
        }

        private void DeleteSupplierItemButton_Click(object sender, EventArgs e)
        {
            if (currentItemSupplier == null)
            {
                MessageBox.Show("Please select a item to delete.", "Warning",
                                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show("Are you sure you want to delete the selected item?", "Warning",
                     MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    warehouseManagementDB.ItemSuppliers.Remove(currentItemSupplier);
                    warehouseManagementDB.SaveChanges();

                    SupplierComboBox_SelectedIndexChanged(null, null);
                    MessageBox.Show("Item deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while deleting the item. Error details: {ex.Message}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ChangeToEditAddPageForSupplierItem()
        {
            tabControl1.TabPages.Remove(itemSupplierPage);
            tabControl1.TabPages.Add(itemSupplierAddPage);
            PopulateItems();


            if (!isEditItemSupplier)
            {

                itemSupplierAddPage.Text = "Add item to supplier";
                saveItemToSupplierBtn.Text = "Add";
            }
            else
            {
                itemSupplierAddPage.Text = "Edit supplier item";
                saveItemToSupplierBtn.Text = "Update";



                suppliersNameComboBox.SelectedValue = currentItemSupplier.SupplierID;
                itemsNameComboBox.SelectedValue = currentItemSupplier.ItemID;

            }
            tabControl1.SelectedIndex = 2;


        }

        private void SaveItemToSupllierItems(object sender, EventArgs e)
        {
            // Validate the input values
            if (suppliersNameComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a supplier.");
                return;
            }

            if (itemsNameComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a item.");
                return;
            }

            if (!decimal.TryParse(itemPriceTextbox.Text, out decimal itemPrice) || itemPrice <= 0)
            {
                MessageBox.Show("Please enter a valid item price.");
                return;
            }



            if (isEditItemSupplier)
            {
                currentItemSupplier.ItemID = (int)itemsNameComboBox.SelectedValue;
                currentItemSupplier.SupplierID = (int)suppliersNameComboBox.SelectedValue;
                currentItemSupplier.UnitPrice = itemPrice;


                warehouseManagementDB.SaveChanges();


                MessageBox.Show("supplier item updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int itemId = (int)itemsNameComboBox.SelectedValue;
                int supplierId = (int)suppliersNameComboBox.SelectedValue;

                var isItemSupplierExist = warehouseManagementDB.ItemSuppliers
                                                                                .FirstOrDefault(ws => ws.SupplierID == supplierId && ws.ItemID == itemId);

                if (isItemSupplierExist != null)
                {
                    isItemSupplierExist.UnitPrice = itemPrice;
                }
                else
                {
                    var warehouseSupplier = new ItemSupplier()
                    {

                        SupplierID = supplierId,
                        ItemID = itemId,
                        UnitPrice = itemPrice
                    };

                    warehouseManagementDB.ItemSuppliers.Add(warehouseSupplier);
                }

                // save changes to the database
                warehouseManagementDB.SaveChanges();

                MessageBox.Show("Item supplier saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            BackToSupplierItemBtn_Click(null, null);

        }

        private void BackToSupplierItemBtn_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(itemSupplierAddPage);
            tabControl1.TabPages.Add(itemSupplierPage);
            tabControl1.SelectedIndex = 2;
        }


        #endregion
    }
}
