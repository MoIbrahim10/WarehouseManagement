using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WarehouseManagement.Forms
{
    public partial class SupplyOrdersForm : Form
    {
        readonly WarehouseManagementDBEntities warehouseManagementDB = new WarehouseManagementDBEntities();
        private SupplyOrder currentSupplyOrder;
        private SupplyOrderItem currentSupplyItem;

        private bool isEdit;
        private bool isEditItemSupply;
        private bool isAddInSupplyPage;
        public SupplyOrdersForm()
        {
            InitializeComponent();
        }
        #region CRUD FOR SUPPLY ORDER


        private void PopulateSuppliers()
        {

            var suppliers = warehouseManagementDB.Suppliers
                .Select(supplier => new { supplier.SupplierID, supplier.SupplierName })
                .ToList();

            suppliersComboBox.DataSource = suppliers;

            suppliersComboBox.DisplayMember = "SupplierName";
            suppliersComboBox.ValueMember = "SupplierID";

        }
        private void PopulateWarehouses()
        {

            var warehouses = warehouseManagementDB.Warehouses
                .Select(warehouse => new { warehouse.WarehouseID, warehouse.WarehouseName })
                .ToList();

            warehousesComboBox.DataSource = warehouses;

            warehousesComboBox.DisplayMember = "WarehouseName";
            warehousesComboBox.ValueMember = "WarehouseID";

        }
        private void UpdateGridComboViews()
        {


            var supplyOrders = warehouseManagementDB.SupplyOrders
                .Select(supplyorder => new
                {
                    supplyorder.SupplyOrderID,
                    SupplyName = "Order" + supplyorder.OrderNumber + "_" + supplyorder.Warehouse.WarehouseName,
                    supplyorder.OrderNumber,
                    supplyorder.OrderDate,
                    supplyorder.WarehouseID,
                    supplyorder.Warehouse.WarehouseName,
                    supplyorder.SupplierID,
                    supplyorder.Supplier.SupplierName,
                    supplyorder.Status

                }).ToList();
            supplyOrderDataGrid.DataSource = supplyOrders;


            allDataComboBox.DataSource = supplyOrders;
            allDataComboBox.DisplayMember = "SupplyName";
            allDataComboBox.ValueMember = "SupplyOrderID";


        }

        private void SupplyOrdersForm_Load(object sender, EventArgs e)
        {
            UpdateGridComboViews();
            isEdit = false;
            isEditItemSupply = false;
            isAddInSupplyPage = false;



            tabControl1.TabPages.Remove(itemsListPage);
            tabControl1.TabPages.Remove(itemAddEditPage);
            tabControl1.TabPages.Remove(SupplyOrdersAddEditPage);
            tabControl1.TabPages.Remove(addNewItemPage);

        }


        private void DataSearchBar_TextChanged(object sender, EventArgs e)
        {

            string searchQuery = dataSearchBar.Text.ToLower();

            try
            {
                var filteredData = warehouseManagementDB.SupplyOrders
                    .Where(supplyOrder =>
                     supplyOrder.SupplyOrderID.ToString().Contains(searchQuery)
                     || supplyOrder.WarehouseID.ToString().Contains(searchQuery)
                     || supplyOrder.OrderNumber.ToString().Contains(searchQuery)
                     || supplyOrder.OrderDate.ToString().Contains(searchQuery)
                     || supplyOrder.Warehouse.WarehouseName.ToLower().Contains(searchQuery)
                     || supplyOrder.Supplier.SupplierName.ToLower().Contains(searchQuery)
                     || supplyOrder.SupplierID.ToString().Contains(searchQuery)
                     || supplyOrder.Status.ToLower().Contains(searchQuery))
                    .Select(so => new
                    {
                        so.SupplyOrderID,
                        so.OrderNumber,
                        so.OrderDate,
                        so.WarehouseID,
                        so.Warehouse.WarehouseName,
                        so.SupplierID,
                        so.Supplier.SupplierName,
                        so.Status
                    }).ToList();

                supplyOrderDataGrid.DataSource = filteredData;
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


        private void SupplyOdrerDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < supplyOrderDataGrid.Rows.Count)
            {
                int supplyOrderId = (int)supplyOrderDataGrid.Rows[e.RowIndex].Cells[0].Value;
                currentSupplyOrder = warehouseManagementDB.SupplyOrders.Find(supplyOrderId);
                allDataComboBox.SelectedIndex = e.RowIndex;
            }
        }


        private void ChangeToEditAddPage()
        {
            tabControl1.TabPages.Remove(SupplyOrdersListPage);
            tabControl1.TabPages.Add(SupplyOrdersAddEditPage);
            PopulateWarehouses();
            PopulateSuppliers();

            if (!isEdit)
            {
                SupplyOrdersAddEditPage.Text = "Add Supply Order permission";
                AddEditSupplyOrderBtn.Text = "Add";
            }
            else
            {
                SupplyOrdersAddEditPage.Text = "Edit Supply Order permission";
                AddEditSupplyOrderBtn.Text = "Update";

                warehousesComboBox.SelectedValue = currentSupplyOrder.WarehouseID;
                suppliersComboBox.SelectedValue = currentSupplyOrder.SupplierID;
                orderDatePicker.Text = currentSupplyOrder.OrderDate.ToString();

            }
        }
        private void AddSupplyOrderButton_Click(object sender, EventArgs e)
        {
            isEdit = false;
            ChangeToEditAddPage();
        }

        private void EditSupplyOrderButton_Click(object sender, EventArgs e)
        {
            if (currentSupplyOrder == null)
            {
                MessageBox.Show("Please make sure to choose permission first", "Warning",
                                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            isEdit = true;
            ChangeToEditAddPage();
        }

        private void DeleteSupplyOrderButton_Click(object sender, EventArgs e)
        {
            if (currentSupplyOrder == null)
            {
                MessageBox.Show("Please select a SupplyOrder permission to delete.", "Warning",
                                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show("Are you sure you want to delete the selected SupplyOrder permission?", "Warning",
                     MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    warehouseManagementDB.SupplyOrders.Remove(currentSupplyOrder);
                    warehouseManagementDB.SaveChanges();

                    UpdateGridComboViews();
                    MessageBox.Show("SupplyOrder permission deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while deleting the SupplyOrder permission. Error details: {ex.Message}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void AddEditSupplyOrderBtn_Click(object sender, EventArgs e)
        {
            // Validate the input values
            if (supplyItemsDataGridView.Rows.Count == 0)
            {
                MessageBox.Show("Please add at least one item.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (warehousesComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a warehouse.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (suppliersComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a warehouse.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!DateTime.TryParse(orderDatePicker.Text, out DateTime orderDate))
            {
                MessageBox.Show("Invalid order date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (orderDate < DateTime.Today)
            {
                MessageBox.Show("Order date cannot be in the past.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            int warehouseId = (int)warehousesComboBox.SelectedValue;
            int supplierId = (int)suppliersComboBox.SelectedValue;


            var isInWarehouse = warehouseManagementDB.WarehouseSuppliers
              .Any(ws => ws.WarehouseID == warehouseId && ws.SupplierID == supplierId);

            if (!isInWarehouse)
            {
                var result = MessageBox.Show("This supplier does not supply for this warehouse. Would you like to add them?", "Supplier Not Found", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    var warehouseSupplier = new WarehouseSupplier
                    {
                        WarehouseID = warehouseId,
                        SupplierID = supplierId
                    };

                    warehouseManagementDB.WarehouseSuppliers.Add(warehouseSupplier);
                    warehouseManagementDB.SaveChanges();

                    MessageBox.Show("Supplier added successfully to the warehouse.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    return;
                }
            }


            try
            {
                if (isEdit)
                {
                    int orderNum = currentSupplyOrder.OrderNumber;
                    if (warehouseId != currentSupplyOrder.WarehouseID && warehouseManagementDB.SupplyOrders.Any(supplyorder => supplyorder.WarehouseID == warehouseId && supplyorder.OrderNumber == orderNum))
                    {

                        orderNum = warehouseManagementDB.SupplyOrders
                                                     .Where(supplyorder => supplyorder.WarehouseID == warehouseId)
                                                     .Max(so => (int?)so.OrderNumber)
                                                     .GetValueOrDefault();
                        orderNum++;

                    }

                    // Update existing supply order
                    currentSupplyOrder.WarehouseID = warehouseId;
                    currentSupplyOrder.SupplierID = supplierId;
                    currentSupplyOrder.OrderDate = orderDate;
                    currentSupplyOrder.OrderNumber = orderNum;

                    warehouseManagementDB.SaveChanges();

                    // Loop through each row in the DataGridView
                    foreach (DataGridViewRow row in supplyItemsDataGridView.Rows)
                    {
                        // Get the ItemID, Quantity, ProductionDate, and ExpirationDate values from the corresponding cells
                        int itemId = (int)row.Cells["ItemID"].Value;
                        int quantity = (int)row.Cells["Quantity"].Value;
                        DateTime productionDate = (DateTime)row.Cells["ProductionDate"].Value;
                        DateTime expirationDate = (DateTime)row.Cells["ExpirationDate"].Value;

                        // Check if the SupplyOrderItem already exists in the database
                        var supplyOrderItem = warehouseManagementDB.SupplyOrderItems
                            .FirstOrDefault(soi => soi.SupplyOrderID == currentSupplyOrder.SupplyOrderID && soi.ItemID == itemId);

                        if (supplyOrderItem != null)
                        {
                            // Update existing SupplyOrderItem
                            supplyOrderItem.Quantity = quantity;
                            supplyOrderItem.ProductionDate = productionDate;
                            supplyOrderItem.ExpirationDate = expirationDate;
                        }
                        else
                        {
                            // Create new SupplyOrderItem
                            var newSupplyOrderItem = new SupplyOrderItem
                            {
                                ItemID = itemId,
                                Quantity = quantity,
                                ProductionDate = productionDate,
                                ExpirationDate = expirationDate,
                                SupplyOrderID = currentSupplyOrder.SupplyOrderID
                            };

                            // Add the new SupplyOrderItem to the database
                            warehouseManagementDB.SupplyOrderItems.Add(newSupplyOrderItem);
                        }
                    }

                    // Save changes to the database
                    warehouseManagementDB.SaveChanges();
                    MessageBox.Show("Supplier order updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    var orderNum = warehouseManagementDB.SupplyOrders
                                                    .Where(supplyorder => supplyorder.WarehouseID == warehouseId)
                                                    .Max(so => (int?)so.OrderNumber)
                                                    .GetValueOrDefault();



                    var supplyOrder = new SupplyOrder()
                    {
                        WarehouseID = warehouseId,
                        SupplierID = supplierId,
                        OrderDate = orderDate,
                        OrderNumber = orderNum + 1,
                        Status = "pending"
                    };


                    warehouseManagementDB.SupplyOrders.Add(supplyOrder);
                    warehouseManagementDB.SaveChanges();

                    var isSupplyOrder = warehouseManagementDB.SupplyOrders.FirstOrDefault(so =>
                                     so.WarehouseID == warehouseId &&
                                     so.SupplierID == supplierId &&
                                     so.OrderDate == orderDate);

                    if (isSupplyOrder != null)
                    {
                        int supplyOrderId = isSupplyOrder.SupplyOrderID;
                        foreach (DataGridViewRow row in supplyItemsDataGridView.Rows)
                        {
                            int itemId = (int)row.Cells["ItemID"].Value;
                            int quantity = (int)row.Cells["Quantity"].Value;
                            DateTime productionDate = (DateTime)row.Cells["ProductionDate"].Value;
                            DateTime expirationDate = (DateTime)row.Cells["ExpirationDate"].Value;


                            var supplyItem = new SupplyOrderItem()
                            {
                                ItemID = itemId,
                                Quantity = quantity,
                                ProductionDate = productionDate,
                                ExpirationDate = expirationDate,
                                SupplyOrderID = supplyOrderId
                            };
                            warehouseManagementDB.SupplyOrderItems.Add(supplyItem);
                            warehouseManagementDB.SaveChanges();

                        }
                        MessageBox.Show("Supply order saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("There was an error saving the supply items.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            UpdateGridComboViews();
            BackBtn_Click(null, null);
        }
        private void BackBtn_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(SupplyOrdersAddEditPage);
            tabControl1.TabPages.Add(SupplyOrdersListPage);
        }

        private void ViewItemsButton_Click(object sender, EventArgs e)
        {
            if (currentSupplyOrder == null)
            {
                MessageBox.Show("Please select a SupplyOrder permission first.", "Warning",
                                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            tabControl1.TabPages.Remove(SupplyOrdersListPage);
            tabControl1.TabPages.Add(itemsListPage);

            ItemsListPage_Enter(null, null);
        }


        private void AddItemInSupplyPageBtn_Click(object sender, EventArgs e)
        {
            isAddInSupplyPage = true;
            AddItemToSupplyBtn_Click(null, null);
        }
        #endregion
        #region CRUD For Item Supplier

        private void ItemsListPage_Enter(object sender, EventArgs e)
        {
            PopulateSuppliesInSupplyItems();
            if (SupplyOrderComboBox.Items.Count > 0)
            {
                SupplyOrderComboBox.SelectedValue = currentSupplyOrder.SupplyOrderID;

                SupplyOrderComboBox_SelectedIndexChanged(null, null);
                PopulateItems();

            }
            selectedItemCombobox.SelectedItem = null;
        }
        private void PopulateSuppliesInSupplyItems()
        {

            var supplyOrders = warehouseManagementDB.SupplyOrders
                .Select(supplyorder => new { supplyorder.SupplyOrderID, supplyOrder = "Order" + supplyorder.OrderNumber + "-" + supplyorder.OrderDate.ToString() + "_" + supplyorder.Warehouse.WarehouseName })
                .ToList();

            SupplyOrderComboBox.DataSource = supplyOrders;

            SupplyOrderComboBox.DisplayMember = "supplyOrder";
            SupplyOrderComboBox.ValueMember = "SupplyOrderID";

        }
        private void PopulateItems()
        {

            var supplyOrderItems = warehouseManagementDB.SupplyOrderItems
                .Where(supplyOrderItem => supplyOrderItem.SupplyOrderID == currentSupplyOrder.SupplyOrderID)
                .Select(supplyOrderItem => new
                {
                    supplyOrderItem.ItemID,
                    supplyOrderItem.Item.ItemName,
                    supplyOrderItem.Quantity,
                    supplyOrderItem.ProductionDate,
                    supplyOrderItem.ExpirationDate
                })
                .ToList();


            selectedItemCombobox.DataSource = supplyOrderItems;

            selectedItemCombobox.DisplayMember = "ItemName";
            selectedItemCombobox.ValueMember = "ItemID";

        }

        private void PopulateItemsInItemPage()
        {

            var items = warehouseManagementDB.Items
                                       .Select(item => new { item.ItemID, item.ItemName })
                                       .ToList();

            itemNameComboBox.DataSource = items;
            itemNameComboBox.DisplayMember = "ItemName";
            itemNameComboBox.ValueMember = "ItemID";

        }

        private void SupplyOrderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SupplyOrderComboBox.SelectedItem != null && SupplyOrderComboBox.SelectedValue is int supplyOrderId)
            {
                int supplyOrderID = supplyOrderId;
                currentSupplyOrder = warehouseManagementDB.SupplyOrders.SingleOrDefault(supplyOrder => supplyOrder.SupplyOrderID == supplyOrderID);
                UpdateSupplyItemsDataGrid(supplyOrderID);
            }
        }

        private void UpdateSupplyItemsDataGrid(int supplyOrderID)
        {

            var supplyItems = warehouseManagementDB.SupplyOrderItems
                           .Where(supplyOrderItem => supplyOrderItem.SupplyOrderID == supplyOrderID)
                           .Select(supplyOrderItem => new
                           {
                               supplyOrderItem.SupplyOrderID,
                               supplyOrderItem = "Order" + supplyOrderItem.SupplyOrder.OrderNumber + "_" + supplyOrderItem.SupplyOrder.Warehouse.WarehouseName,
                               supplyOrderItem.ItemID,
                               supplyOrderItem.Item.ItemName,
                               supplyOrderItem.Quantity,
                               supplyOrderItem.ProductionDate,
                               supplyOrderItem.ExpirationDate
                           })
                           .ToList();


            var bindingSource = new BindingSource
            {
                DataSource = supplyItems
            };

            SupplyItemsDtaGridView.DataSource = bindingSource;


            selectedItemCombobox.DataSource = bindingSource;
            selectedItemCombobox.DisplayMember = "ItemName";
            selectedItemCombobox.ValueMember = "ItemID";

        }


        private void SupplyItemsDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < SupplyItemsDtaGridView.Rows.Count)
            {
                int ItemId = (int)SupplyItemsDtaGridView.Rows[e.RowIndex].Cells[2].Value;
                currentSupplyItem = warehouseManagementDB.SupplyOrderItems.FirstOrDefault(supplyOrderItem =>
                    supplyOrderItem.SupplyOrderID == currentSupplyOrder.SupplyOrderID && supplyOrderItem.ItemID == ItemId);

                selectedItemCombobox.SelectedIndex = e.RowIndex;
            }
        }
        // to filter the grid based on the data in search bar
        private void SearchSupplierItemtextBox_TextChanged(object sender, EventArgs e)
        {
            string searchQuery = searchSupplyOrderItemTextBox.Text.ToLower();

            try
            {
                var filteredData = warehouseManagementDB.SupplyOrderItems
                    .Where(supplyOrderItem =>
                        supplyOrderItem.SupplyOrderID.ToString().Contains(searchQuery) ||
                        supplyOrderItem.SupplyOrder.DisplayText.ToLower().Contains(searchQuery) ||
                        supplyOrderItem.ItemID.ToString().Contains(searchQuery) ||
                        supplyOrderItem.Quantity.ToString().Contains(searchQuery) ||
                        supplyOrderItem.Item.ItemName.ToLower().Contains(searchQuery) ||
                        supplyOrderItem.ProductionDate.ToString().Contains(searchQuery) ||
                        supplyOrderItem.ExpirationDate.ToString().Contains(searchQuery))
                    .Select(supplyOrderItem => new
                    {
                        supplyOrderItem.SupplyOrderID,
                        supplyOrderItem = "Order" + supplyOrderItem.SupplyOrder.OrderNumber + "-" + supplyOrderItem.SupplyOrder.OrderDate.ToString() + "_" + supplyOrderItem.SupplyOrder.Warehouse.WarehouseName,
                        supplyOrderItem.ItemID,
                        supplyOrderItem.Item.ItemName,
                        supplyOrderItem.Quantity,
                        supplyOrderItem.ProductionDate,
                        supplyOrderItem.ExpirationDate
                    })
            .ToList();



                SupplyItemsDtaGridView.DataSource = filteredData;
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


        private void AddItemToSupplyBtn_Click(object sender, EventArgs e)
        {
            isEditItemSupply = false;
            ChangeToEditAddPageForSupplyItem();
        }

        private void EditItemToSupplyBtn_Click(object sender, EventArgs e)
        {
            if (currentSupplyItem == null)
            {
                MessageBox.Show("Please make sure to choose item first", "Warning",
                                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            isEditItemSupply = true;
            ChangeToEditAddPageForSupplyItem();
        }

        private void DeleteItemToSupplyBtn_Click(object sender, EventArgs e)
        {
            if (currentSupplyItem == null)
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
                    warehouseManagementDB.SupplyOrderItems.Remove(currentSupplyItem);
                    warehouseManagementDB.SaveChanges();

                    SupplyOrderComboBox_SelectedIndexChanged(null, null);
                    MessageBox.Show("Item deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while deleting the item. Error details: {ex.Message}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ChangeToEditAddPageForSupplyItem()
        {
            if (!isAddInSupplyPage)
            {
                tabControl1.TabPages.Remove(itemsListPage);
            }
            else
            {
                tabControl1.TabPages.Remove(SupplyOrdersAddEditPage);

            }
            tabControl1.TabPages.Add(itemAddEditPage);

            PopulateItemsInItemPage();


            if (!isEditItemSupply)
            {

                itemAddEditPage.Text = "Add item to supply order";
                saveItemToSupplyBtn.Text = "Add";
            }
            else
            {
                itemAddEditPage.Text = "Edit supplier item";
                saveItemToSupplyBtn.Text = "Update";


                itemNameComboBox.SelectedValue = currentSupplyItem.ItemID;
                quantityTextBox.Text = currentSupplyItem.Quantity.ToString();
                productionDateDatePicker.Text = currentSupplyItem.ProductionDate.ToString();
                expirationDateDatePicker.Text = currentSupplyItem.ExpirationDate.ToString();

            }
            tabControl1.SelectedIndex = 1;




        }

        private void SaveItemToSupllyItems(object sender, EventArgs e)
        {
            // Validate the input values
            if (itemNameComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select an item.", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (!int.TryParse(quantityTextBox.Text, out int quantity) || quantity < 0)
            {
                MessageBox.Show("Quantity must be a positive integer.", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (!DateTime.TryParse(productionDateDatePicker.Text, out DateTime productionDate))
            {
                MessageBox.Show("Invalid production date.", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (!DateTime.TryParse(expirationDateDatePicker.Text, out DateTime expirationDate))
            {
                MessageBox.Show("Invalid expiration date.", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (expirationDate <= productionDate)
            {
                MessageBox.Show("Expiration date must be after production date.", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int itemId = (int)itemNameComboBox.SelectedValue;
            if (isAddInSupplyPage)
            {
                bool idExists = supplyItemsDataGridView.Rows
                                                            .Cast<DataGridViewRow>()
                                                            .Any(row => row.Cells["ItemID"].Value?.ToString() == itemId.ToString());

                if (idExists)
                {
                    MessageBox.Show("This item has already been added.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string itemName = itemNameComboBox.Text;

                supplyItemsDataGridView.Rows.Add(itemId, itemName, quantity, productionDate, expirationDate);
            }
            else
            {

                if (isEditItemSupply)
                {

                    currentSupplyItem.ItemID = itemId;
                    currentSupplyItem.Quantity = quantity;
                    currentSupplyItem.ProductionDate = productionDate;
                    currentSupplyItem.ExpirationDate = expirationDate;


                    warehouseManagementDB.SaveChanges();


                    MessageBox.Show("supplier item updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {

                    var isItemSupplyExist = warehouseManagementDB.SupplyOrderItems
                                                                                    .FirstOrDefault(supplyOrderItem => supplyOrderItem.SupplyOrderID == currentSupplyOrder.SupplyOrderID && supplyOrderItem.ItemID == itemId);


                    if (isItemSupplyExist != null)
                    {
                        isItemSupplyExist.Quantity = quantity;
                        isItemSupplyExist.ProductionDate = productionDate;
                        isItemSupplyExist.ExpirationDate = expirationDate;
                    }
                    else
                    {
                        var supplyItem = new SupplyOrderItem()
                        {

                            ItemID = itemId,
                            Quantity = quantity,
                            ProductionDate = productionDate,
                            ExpirationDate = expirationDate,
                            SupplyOrderID = currentSupplyOrder.SupplyOrderID

                        };
                        warehouseManagementDB.SupplyOrderItems.Add(supplyItem);
                    }

                    // save changes to the database
                    warehouseManagementDB.SaveChanges();

                    MessageBox.Show("Item supply saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }


            BackToSupplyItemBtn_Click(null, null);

        }

        private void BackToSupplyItemBtn_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(itemAddEditPage);
            if (isAddInSupplyPage)
            {
                tabControl1.TabPages.Add(SupplyOrdersAddEditPage);
            }
            else
            {
                tabControl1.TabPages.Add(itemsListPage);
            }


            tabControl1.SelectedIndex = 1;
        }

        private void BackToSupplyOrdersBtn_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(itemsListPage);
            tabControl1.TabPages.Add(SupplyOrdersListPage);
        }

        #endregion

        #region New item
        private void AddNewItemBtn_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(itemAddEditPage);
            tabControl1.TabPages.Add(addNewItemPage);
        }

        private void SaveNewItemBtn_Click(object sender, EventArgs e)
        {

            // Validate input fields
            if (string.IsNullOrWhiteSpace(txtItemName.Text) || txtItemName.Text.Length < 3 || txtItemName.Text.Length > 30)
            {
                MessageBox.Show("Please enter a valid item name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtItemUnit.Text) || txtItemUnit.Text.Length < 3 || txtItemUnit.Text.Length > 30)
            {
                MessageBox.Show("Please enter a item unit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Item newItem = new Item
            {
                ItemName = txtItemName.Text,
                ItemUnitOfMeasurement = txtItemUnit.Text,
            };

            warehouseManagementDB.Items.Add(newItem);
            warehouseManagementDB.SaveChanges();

            UpdateGridComboViews();
            MessageBox.Show("Item saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


            PopulateSuppliesInSupplyItems();
            BackToItemPage_Click(null, null);
        }

        private void BackToItemPage_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(addNewItemPage);
            tabControl1.TabPages.Add(itemAddEditPage);
        }
        #endregion

    }
}
