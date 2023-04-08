using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarehouseManagement.Forms
{
    public partial class WarehouseForm : Form
    {


        WarehouseManagementDBEntities warehouseManagementDB = new WarehouseManagementDBEntities();
        private Warehouse currentWarehouse;
        private WarehouseItem currentWarehouseItem;
        private bool isEdit;
        private bool isEditItem;

        public WarehouseForm()
        {
            InitializeComponent();
            updateGridComboViews();
            allDataComboBox.SelectedItem = null;

            isEdit = false;
            isEditItem = false;
            tabControl1.TabPages.Remove(WarehousesAddEditPage);
            tabControl1.TabPages.Remove(addItemsToWarehousePage);

        }

        #region Warehouse CRUD Methods

        // update the table with warehouse data
        private void updateGridComboViews()
        {

            var warehouses = warehouseManagementDB.Warehouses
                                        .Select(warehouse => new { warehouse.WarehouseID, warehouse.WarehouseName, warehouse.WarehouseAddress, warehouse.ManagerID })
                                        .ToList();

            // Bind the warehouses to the grid
            warehouseDataGrid.DataSource = warehouses;

            // Bind the warehouses to the combo box
            allDataComboBox.DataSource = warehouses;
            allDataComboBox.DisplayMember = "WarehouseName";
            allDataComboBox.ValueMember = "WarehouseID";


        }

        // update the comboBox with managers name
        private void PopulateManagers()
        {

            var managers = warehouseManagementDB.Employees
                .Where(e => e.EmployeeRole == "Manager")
                .Select(emp => new { emp.EmployeeID, FullName = emp.EmployeeFirstName + " " + emp.EmployeeLastName })
                .OrderBy(e => e.FullName)
                .ToList();

            // Bind the managers to the comboBox
            comboBoxWarehouseManager.DataSource = managers;

            comboBoxWarehouseManager.DisplayMember = "FullName";
            comboBoxWarehouseManager.ValueMember = "EmployeeID";

        }

        // to filter the grid based on the data in search bar
        private void dataSearchBar_TextChanged(object sender, EventArgs e)
        {

            string searchQuery = dataSearchBar.Text.ToLower();
            try
            {
                var filteredData = warehouseManagementDB.Warehouses
                                               .Where(warehouse =>
                                                   warehouse.WarehouseID.ToString().ToLower().Contains(searchQuery) ||
                                                   warehouse.WarehouseName.ToLower().Contains(searchQuery) ||
                                                   warehouse.WarehouseAddress.ToLower().Contains(searchQuery) ||
                                                   warehouse.ManagerID.ToString().ToLower().Contains(searchQuery))
                                               .Select(warehouse => new { warehouse.WarehouseID, warehouse.WarehouseName, warehouse.WarehouseAddress, warehouse.ManagerID })
                                               .ToList();



                warehouseDataGrid.DataSource = filteredData;
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

        // change combo box selected item based on selected cell in the grid
        private void warehouseDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && e.RowIndex < warehouseDataGrid.Rows.Count)
            {
                int warehouseId = (int)warehouseDataGrid.Rows[e.RowIndex].Cells[0].Value;
                currentWarehouse = warehouseManagementDB.Warehouses.Find(warehouseId);
                allDataComboBox.SelectedIndex = e.RowIndex;
            }
        }

        // redirect to add page 
        private void AddWarehouseButton_Click(object sender, EventArgs e)
        {
            isEdit = false;
            changeToEditAddPage();

        }
        // redirect to edit page 
        private void editWarehouseButton_Click(object sender, EventArgs e)
        {
            if (currentWarehouse == null)
            {
                MessageBox.Show("Please make sure to choose warehouse first", "Warning",
                                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            isEdit = true;
            changeToEditAddPage();
        }
        // delete selected warehouse data
        private void deleteWarehouseBtn_Click(object sender, EventArgs e)
        {
            if (currentWarehouse == null)
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
                    warehouseManagementDB.Warehouses.Remove(currentWarehouse);
                    warehouseManagementDB.SaveChanges();

                    updateGridComboViews();
                    MessageBox.Show("Warehouse deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while deleting the warehouse. Error details: {ex.Message}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void changeToEditAddPage()
        {
            tabControl1.TabPages.Remove(WarehousesListPage);
            tabControl1.TabPages.Remove(warehouseItemsListPage);
            tabControl1.TabPages.Add(WarehousesAddEditPage);
            PopulateManagers();

            if (!isEdit)
            {
                txtWarehouseName.Text = "";
                txtWarehouseAddress.Text = "";

                WarehousesAddEditPage.Text = "Add Warehouse";
                AddEditWarehouseBtn.Text = "Add";
            }
            else
            {
                WarehousesAddEditPage.Text = "Edit Warehouse";
                AddEditWarehouseBtn.Text = "Update";

                txtWarehouseName.Text = currentWarehouse.WarehouseName.ToString();
                txtWarehouseAddress.Text = currentWarehouse.WarehouseAddress.ToString();
                comboBoxWarehouseManager.SelectedValue = currentWarehouse.ManagerID;

            }
        }


        private void AddEditWarehouseBtn_Click(object sender, EventArgs e)
        {


            // Validate input fields
            if (string.IsNullOrWhiteSpace(txtWarehouseName.Text))
            {
                MessageBox.Show("Please enter a warehouse name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtWarehouseAddress.Text))
            {
                MessageBox.Show("Please enter a warehouse address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (comboBoxWarehouseManager.SelectedValue == null)
            {
                MessageBox.Show("Please select a warehouse manager.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (isEdit)
            {
                currentWarehouse.WarehouseName = txtWarehouseName.Text;
                currentWarehouse.WarehouseAddress = txtWarehouseAddress.Text;
                currentWarehouse.ManagerID = (int)comboBoxWarehouseManager.SelectedValue;


                warehouseManagementDB.SaveChanges();

                updateGridComboViews();
                MessageBox.Show("Warehouse updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Warehouse newWarehouse = new Warehouse
                {
                    WarehouseName = txtWarehouseName.Text,
                    WarehouseAddress = txtWarehouseAddress.Text,
                    ManagerID = (int)comboBoxWarehouseManager.SelectedValue
                };

                warehouseManagementDB.Warehouses.Add(newWarehouse);
                warehouseManagementDB.SaveChanges();

                updateGridComboViews();
                MessageBox.Show("Warehouse saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            backBtn_Click(null, null);

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(WarehousesAddEditPage);
            tabControl1.TabPages.Add(WarehousesListPage);
            tabControl1.TabPages.Add(warehouseItemsListPage);
        }

        #endregion

        #region Warehouse Items CRUD Methods

        private void warehouseItemsList_Enter(object sender, EventArgs e)
        {
            PopulateWarehouses();
        }

        private void PopulateWarehouses()
        {

            var warehouses = warehouseManagementDB.Warehouses
                .Select(wh => new { wh.WarehouseID, wh.WarehouseName })
                .ToList();


            warehouseNameComboBox.DataSource = warehouseComboBox.DataSource = warehouses;

            warehouseComboBox.DisplayMember = warehouseNameComboBox.DisplayMember = "WarehouseName";
            warehouseComboBox.ValueMember = warehouseNameComboBox.ValueMember = "WarehouseID";

        }
        private void PopulateItems()
        {

            var items = warehouseManagementDB.Items
                .Select(item => new { item.ItemID, item.ItemName })
                .ToList();

            itemNameComboBox.DataSource = items;

            itemNameComboBox.DisplayMember = "ItemName";
            itemNameComboBox.ValueMember = "ItemID";

        }

        private void PopulateWarehouseItemsDataGridView(int warehouseID)
        {
            var warehouseItems = warehouseManagementDB.WarehouseItems
                           .Where(wi => wi.WarehouseID == warehouseID)
                           .Select(wi => new
                           {
                               wi.WarehouseID,
                               wi.Warehouse.WarehouseName,
                               wi.ItemID,
                               wi.Item.ItemName,
                               wi.Item.ItemCode,
                               wi.Quantity
                           })
                           .ToList();


            var bindingSource = new BindingSource();
            bindingSource.DataSource = warehouseItems;

            warehouseItemsDataGridView.DataSource = bindingSource;


            allIteminWarehouseComboBox.DataSource = warehouseItems;
            allIteminWarehouseComboBox.DisplayMember = "ItemName";
            allIteminWarehouseComboBox.ValueMember = "ItemID";


        }

        private void warehouseItemsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && e.RowIndex < warehouseItemsDataGridView.Rows.Count)

            {
                int itemId = (int)warehouseItemsDataGridView.Rows[e.RowIndex].Cells[2].Value;
                currentWarehouseItem = warehouseManagementDB.WarehouseItems.FirstOrDefault(wi => wi.ItemID == itemId);
                allIteminWarehouseComboBox.SelectedIndex = e.RowIndex;

            }
        }

        private void warehouseComboBox_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (warehouseComboBox.SelectedItem != null && warehouseComboBox.SelectedValue is int)
            {
                int warehouseID = (int)warehouseComboBox.SelectedValue;
                PopulateWarehouseItemsDataGridView(warehouseID);
            }
        }

        // to filter the grid based on the data in search bar
        private void searchItemWarehouseTxtBox_TextChanged(object sender, EventArgs e)
        {

            string searchQuery = searchItemWarehouseTxtBox.Text.ToLower();
            try
            {
                var filteredData = warehouseManagementDB.WarehouseItems
                                               .Where(warehouseItem =>
                                                   warehouseItem.WarehouseID.ToString().Contains(searchQuery) ||
                                                   warehouseItem.Warehouse.WarehouseName.ToLower().Contains(searchQuery) ||
                                                   warehouseItem.ItemID.ToString().Contains(searchQuery) ||
                                                   warehouseItem.Item.ItemName.ToLower().Contains(searchQuery) ||
                                                   warehouseItem.Item.ItemCode.ToLower().Contains(searchQuery) ||
                                                   warehouseItem.Quantity.ToString().Contains(searchQuery))
                                               .Select(wi => new
                                               {
                                                   wi.WarehouseID,
                                                   wi.Warehouse.WarehouseName,
                                                   wi.ItemID,
                                                   wi.Item.ItemName,
                                                   wi.Item.ItemCode,
                                                   wi.Quantity
                                               })
                                               .ToList();



                warehouseItemsDataGridView.DataSource = filteredData;
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

        private void addItemToWarehouseBtn_Click(object sender, EventArgs e)
        {
            isEditItem = false;
            changeToEditAddPageForItem();

        }

        private void editItemInWarehouseBtn_Click(object sender, EventArgs e)
        {
            if (currentWarehouseItem == null)
            {
                MessageBox.Show("Please make sure to choose item first", "Warning",
                                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            isEditItem = true;
            changeToEditAddPageForItem();
        }

        private void deleteItemFromWarehouseButton_Click(object sender, EventArgs e)
        {

            if (currentWarehouseItem == null)
            {
                MessageBox.Show("Please select a item in warehouse to delete.", "Warning",
                                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show("Are you sure you want to delete the selected item from the warehouse?", "Warning",
                     MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    warehouseManagementDB.WarehouseItems.Remove(currentWarehouseItem);
                    warehouseManagementDB.SaveChanges();

                    warehouseComboBox_OnSelectedIndexChanged(null, null);
                    MessageBox.Show("Item deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while deleting the item. Error details: {ex.Message}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void changeToEditAddPageForItem()
        {
            tabControl1.TabPages.Remove(WarehousesListPage);
            tabControl1.TabPages.Remove(warehouseItemsListPage);
            tabControl1.TabPages.Add(addItemsToWarehousePage);
            PopulateItems();


            if (!isEditItem)
            {

                PopulateWarehouses();
                itemQuantityTextbox.Text = "";

                addItemsToWarehousePage.Text = "Add Item to warehouse";
                saveItemToWarehouseBtn.Text = "Add";
            }
            else
            {
                addItemsToWarehousePage.Text = "Edit Item in warehouse";
                saveItemToWarehouseBtn.Text = "Update";



                warehouseNameComboBox.SelectedValue = currentWarehouseItem.WarehouseID;
                itemNameComboBox.SelectedValue = currentWarehouseItem.ItemID;
                itemQuantityTextbox.Text = currentWarehouseItem.Quantity.ToString();

            }

        }

        private void SaveItemToWarehouse(object sender, EventArgs e)
        {
            // Validate the input values
            if (itemNameComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select an item.");
                return;
            }

            if (warehouseNameComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a warehouse.");
                return;
            }
            if (!int.TryParse(itemQuantityTextbox.Text, out int itemQuantity) || itemQuantity <= 0)
            {
                MessageBox.Show("Please enter a valid item quantity.");
                return;
            }

            if (isEditItem)
            {
                currentWarehouseItem.WarehouseID = (int)warehouseNameComboBox.SelectedValue;
                currentWarehouseItem.ItemID = (int)itemNameComboBox.SelectedValue;
                currentWarehouseItem.Quantity = itemQuantity;


                warehouseManagementDB.SaveChanges();


                MessageBox.Show("warehouse Item updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int itemId = (int)itemNameComboBox.SelectedValue;
                int warehouseId = (int)warehouseNameComboBox.SelectedValue;

                var isWarehouseItemExist = warehouseManagementDB.WarehouseItems
                                                                                .FirstOrDefault(wi => wi.ItemID == itemId && wi.WarehouseID == warehouseId);

                if (isWarehouseItemExist != null) // item already exists in the warehouse
                {
                    // update the item quantity
                    isWarehouseItemExist.Quantity += itemQuantity;
                }
                else // item doesn't exist in the warehouse
                {
                    // create a new warehouse item
                    var warehouseItem = new WarehouseItem()
                    {
                        Quantity = itemQuantity,
                        ItemID = itemId,
                        WarehouseID = warehouseId
                    };

                    // add the new warehouse item to the database context
                    warehouseManagementDB.WarehouseItems.Add(warehouseItem);
                }

                // save changes to the database
                warehouseManagementDB.SaveChanges();

                MessageBox.Show("Warehouse item saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            backToWarehouseItemBtn_Click(null, null);

        }

        private void backToWarehouseItemBtn_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(addItemsToWarehousePage);
            tabControl1.TabPages.Add(WarehousesListPage);
            tabControl1.TabPages.Add(warehouseItemsListPage);
            tabControl1.SelectedIndex = 1;
        }
        #endregion


    }
}


