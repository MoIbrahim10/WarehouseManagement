using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace WarehouseManagement.Forms
{
    public partial class IssuanceOrdersForm : Form
    {
        readonly WarehouseManagementDBEntities warehouseManagementDB = new WarehouseManagementDBEntities();
        private IssuanceOrder currentIssuanceOrder;
        private IssuanceOrderItem currentIssuanceItem;

        private bool isEdit;
        private bool isEditItemIssuance;
        private bool isAddInIssuancePage;
        public IssuanceOrdersForm()
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


            var issuanceOrders = warehouseManagementDB.IssuanceOrders
                .Select(issuanceorder => new
                {
                    issuanceorder.IssuanceOrderID,
                    IssuanceName = "Order" + issuanceorder.OrderNumber + "_" + issuanceorder.Warehouse.WarehouseName,
                    issuanceorder.OrderNumber,
                    issuanceorder.OrderDate,
                    issuanceorder.WarehouseID,
                    issuanceorder.Warehouse.WarehouseName,
                    issuanceorder.SupplierID,
                    issuanceorder.Supplier.SupplierName,
                    issuanceorder.Status

                }).ToList();
            issuanceOrderDataGrid.DataSource = issuanceOrders;


            allDataComboBox.DataSource = issuanceOrders;
            allDataComboBox.DisplayMember = "IssuanceName";
            allDataComboBox.ValueMember = "IssuanceOrderID";


        }

        private void IssuanceOrdersForm_Load(object sender, EventArgs e)
        {
            UpdateGridComboViews();
            isEdit = false;
            isEditItemIssuance = false;
            isAddInIssuancePage = false;



            tabControl1.TabPages.Remove(itemsListPage);
            tabControl1.TabPages.Remove(itemAddEditPage);
            tabControl1.TabPages.Remove(IssuanceOrdersAddEditPage);

        }


        private void DataSearchBar_TextChanged(object sender, EventArgs e)
        {

            string searchQuery = dataSearchBar.Text.ToLower();

            try
            {
                var filteredData = warehouseManagementDB.IssuanceOrders
                    .Where(issuanceOrder =>
                     issuanceOrder.IssuanceOrderID.ToString().Contains(searchQuery)
                     || issuanceOrder.WarehouseID.ToString().Contains(searchQuery)
                     || issuanceOrder.OrderNumber.ToString().Contains(searchQuery)
                     || issuanceOrder.OrderDate.ToString().Contains(searchQuery)
                     || issuanceOrder.Warehouse.WarehouseName.ToLower().Contains(searchQuery)
                     || issuanceOrder.Supplier.SupplierName.ToLower().Contains(searchQuery)
                     || issuanceOrder.SupplierID.ToString().Contains(searchQuery)
                     || issuanceOrder.Status.ToLower().Contains(searchQuery))
                    .Select(so => new
                    {
                        so.IssuanceOrderID,
                        so.OrderNumber,
                        so.OrderDate,
                        so.WarehouseID,
                        so.Warehouse.WarehouseName,
                        so.SupplierID,
                        so.Supplier.SupplierName,
                        so.Status
                    }).ToList();

                issuanceOrderDataGrid.DataSource = filteredData;
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


        private void IssuanceOdrerDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < issuanceOrderDataGrid.Rows.Count)
            {
                int issuanceOrderId = (int)issuanceOrderDataGrid.Rows[e.RowIndex].Cells[0].Value;
                currentIssuanceOrder = warehouseManagementDB.IssuanceOrders.Find(issuanceOrderId);
                allDataComboBox.SelectedIndex = e.RowIndex;
            }
        }


        private void ChangeToEditAddPage()
        {
            tabControl1.TabPages.Remove(IssuanceOrdersListPage);
            tabControl1.TabPages.Add(IssuanceOrdersAddEditPage);
            PopulateWarehouses();
            PopulateSuppliers();

            if (!isEdit)
            {
                IssuanceOrdersAddEditPage.Text = "Add Issuance Order permission";
                AddEditIssuanceOrderBtn.Text = "Add";
            }
            else
            {
                IssuanceOrdersAddEditPage.Text = "Edit Issuance Order permission";
                AddEditIssuanceOrderBtn.Text = "Update";

                warehousesComboBox.SelectedValue = currentIssuanceOrder.WarehouseID;
                suppliersComboBox.SelectedValue = currentIssuanceOrder.SupplierID;
                orderDatePicker.Text = currentIssuanceOrder.OrderDate.ToString();

            }
        }
        private void AddIssuanceOrderButton_Click(object sender, EventArgs e)
        {
            isEdit = false;
            ChangeToEditAddPage();
        }

        private void EditIssuanceOrderButton_Click(object sender, EventArgs e)
        {
            if (currentIssuanceOrder == null)
            {
                MessageBox.Show("Please make sure to choose permission first", "Warning",
                                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            isEdit = true;
            ChangeToEditAddPage();
        }

        private void DeleteIssuanceOrderButton_Click(object sender, EventArgs e)
        {
            if (currentIssuanceOrder == null)
            {
                MessageBox.Show("Please select a IssuanceOrder permission to delete.", "Warning",
                                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show("Are you sure you want to delete the selected IssuanceOrder permission?", "Warning",
                     MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    warehouseManagementDB.IssuanceOrders.Remove(currentIssuanceOrder);
                    warehouseManagementDB.SaveChanges();

                    UpdateGridComboViews();
                    MessageBox.Show("IssuanceOrder permission deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while deleting the IssuanceOrder permission. Error details: {ex.Message}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void AddEditIssuanceOrderBtn_Click(object sender, EventArgs e)
        {
            // Validate the input values
            if (issuanceItemsDataGridView.Rows.Count == 0)
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
                    int orderNum = currentIssuanceOrder.OrderNumber;
                    if (warehouseId != currentIssuanceOrder.WarehouseID && warehouseManagementDB.IssuanceOrders.Any(issuanceorder => issuanceorder.WarehouseID == warehouseId && issuanceorder.OrderNumber == orderNum))
                    {

                        orderNum = warehouseManagementDB.IssuanceOrders
                                                     .Where(issuanceorder => issuanceorder.WarehouseID == warehouseId)
                                                     .Max(so => (int?)so.OrderNumber)
                                                     .GetValueOrDefault();
                        orderNum++;

                    }

                    // Update existing issuance order
                    currentIssuanceOrder.WarehouseID = warehouseId;
                    currentIssuanceOrder.SupplierID = supplierId;
                    currentIssuanceOrder.OrderDate = orderDate;
                    currentIssuanceOrder.OrderNumber = orderNum;

                    warehouseManagementDB.SaveChanges();

                    // Loop through each row in the DataGridView
                    foreach (DataGridViewRow row in issuanceItemsDataGridView.Rows)
                    {
                        // Get the ItemID and Quantity values from the corresponding cells
                        int itemId = (int)row.Cells["ItemID"].Value;
                        int quantity = (int)row.Cells["Quantity"].Value;

                        // Check if the Item exists in the WarehouseItems table
                        var warehouseItem = warehouseManagementDB.WarehouseItems.FirstOrDefault(wi => wi.WarehouseID == currentIssuanceOrder.WarehouseID && wi.ItemID == itemId);

                        if (warehouseItem == null)
                        {
                            MessageBox.Show("The item does not exist in the warehouse.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (quantity > warehouseItem.Quantity)
                        {
                            var result = MessageBox.Show("The available quantity in the warehouse is less than the quantity to be issued. Do you want to edit the quantity?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

                            if (result == DialogResult.Yes)
                            {
                                // Set the focus on the cell to edit the quantity
                                issuanceItemsDataGridView.CurrentCell = row.Cells["Quantity"];
                                issuanceItemsDataGridView.BeginEdit(true);
                                return;
                            }
                        }
                        else
                        {
                            // Check if the IssuanceOrderItem already exists in the database
                            var issuanceOrderItem = warehouseManagementDB.IssuanceOrderItems
                                .FirstOrDefault(soi => soi.IssuanceOrderID == currentIssuanceOrder.IssuanceOrderID && soi.ItemID == itemId);

                            if (issuanceOrderItem != null)
                            {
                                // Update existing IssuanceOrderItem
                                issuanceOrderItem.Quantity = quantity;
                            }
                            else
                            {
                                // Create new IssuanceOrderItem
                                var newIssuanceOrderItem = new IssuanceOrderItem
                                {
                                    ItemID = itemId,
                                    Quantity = quantity,
                                    IssuanceOrderID = currentIssuanceOrder.IssuanceOrderID
                                };

                                // Add the new IssuanceOrderItem to the database
                                warehouseManagementDB.IssuanceOrderItems.Add(newIssuanceOrderItem);
                            }
                        }
                    }

                    // Save changes to the database
                    warehouseManagementDB.SaveChanges();
                    MessageBox.Show("Supplier order updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    var orderNum = warehouseManagementDB.IssuanceOrders
                                                    .Where(issuanceorder => issuanceorder.WarehouseID == warehouseId)
                                                    .Max(so => (int?)so.OrderNumber)
                                                    .GetValueOrDefault();



                    var issuanceOrder = new IssuanceOrder()
                    {
                        WarehouseID = warehouseId,
                        SupplierID = supplierId,
                        OrderDate = orderDate,
                        OrderNumber = orderNum + 1,
                        Status = "pending"
                    };


                    warehouseManagementDB.IssuanceOrders.Add(issuanceOrder);
                    warehouseManagementDB.SaveChanges();

                    var isIssuanceOrder = warehouseManagementDB.IssuanceOrders.FirstOrDefault(so =>
                                     so.WarehouseID == warehouseId &&
                                     so.SupplierID == supplierId &&
                                     so.OrderDate == orderDate);

                    if (isIssuanceOrder != null)
                    {
                        int issuanceOrderId = isIssuanceOrder.IssuanceOrderID;
                        foreach (DataGridViewRow row in issuanceItemsDataGridView.Rows)
                        {
                            int itemId = (int)row.Cells["ItemID"].Value;
                            int quantity = (int)row.Cells["Quantity"].Value;



                            var issuanceItem = new IssuanceOrderItem()
                            {
                                ItemID = itemId,
                                Quantity = quantity,

                                IssuanceOrderID = issuanceOrderId
                            };
                            warehouseManagementDB.IssuanceOrderItems.Add(issuanceItem);
                            warehouseManagementDB.SaveChanges();

                        }
                        MessageBox.Show("Issuance order saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("There was an error saving the issuance items.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
            tabControl1.TabPages.Remove(IssuanceOrdersAddEditPage);
            tabControl1.TabPages.Add(IssuanceOrdersListPage);
        }

        private void ViewItemsButton_Click(object sender, EventArgs e)
        {
            if (currentIssuanceOrder == null)
            {
                MessageBox.Show("Please select a IssuanceOrder permission first.", "Warning",
                                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            tabControl1.TabPages.Remove(IssuanceOrdersListPage);
            tabControl1.TabPages.Add(itemsListPage);

            ItemsListPage_Enter(null, null);
        }


        private void AddItemInIssuancePageBtn_Click(object sender, EventArgs e)
        {
            isAddInIssuancePage = true;
            AddItemToIssuanceBtn_Click(null, null);
        }
        #endregion
        #region CRUD For Item Supplier

        private void ItemsListPage_Enter(object sender, EventArgs e)
        {
            PopulateSuppliesInIssuanceItems();
            if (IssuanceOrderComboBox.Items.Count > 0)
            {
                IssuanceOrderComboBox.SelectedValue = currentIssuanceOrder.IssuanceOrderID;

                IssuanceOrderComboBox_SelectedIndexChanged(null, null);
                PopulateItems();

            }
            selectedItemCombobox.SelectedItem = null;
        }
        private void PopulateSuppliesInIssuanceItems()
        {

            var issuanceOrders = warehouseManagementDB.IssuanceOrders
                .Select(issuanceorder => new { issuanceorder.IssuanceOrderID, issuanceOrder = "Order" + issuanceorder.OrderNumber + "-" + issuanceorder.OrderDate.ToString() + "_" + issuanceorder.Warehouse.WarehouseName })
                .ToList();

            IssuanceOrderComboBox.DataSource = issuanceOrders;

            IssuanceOrderComboBox.DisplayMember = "issuanceOrder";
            IssuanceOrderComboBox.ValueMember = "IssuanceOrderID";

        }
        private void PopulateItems()
        {

            var issuanceOrderItems = warehouseManagementDB.IssuanceOrderItems
                .Where(issuanceOrderItem => issuanceOrderItem.IssuanceOrderID == currentIssuanceOrder.IssuanceOrderID)
                .Select(issuanceOrderItem => new
                {
                    issuanceOrderItem.ItemID,
                    issuanceOrderItem.Item.ItemName,
                    issuanceOrderItem.Quantity,
                })
                .ToList();


            selectedItemCombobox.DataSource = issuanceOrderItems;

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

        private void IssuanceOrderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IssuanceOrderComboBox.SelectedItem != null && IssuanceOrderComboBox.SelectedValue is int issuanceOrderId)
            {
                int issuanceOrderID = issuanceOrderId;
                currentIssuanceOrder = warehouseManagementDB.IssuanceOrders.SingleOrDefault(issuanceOrder => issuanceOrder.IssuanceOrderID == issuanceOrderID);
                UpdateIssuanceItemsDataGrid(issuanceOrderID);
            }
        }

        private void UpdateIssuanceItemsDataGrid(int issuanceOrderID)
        {

            var issuanceItems = warehouseManagementDB.IssuanceOrderItems
                           .Where(issuanceOrderItem => issuanceOrderItem.IssuanceOrderID == issuanceOrderID)
                           .Select(issuanceOrderItem => new
                           {
                               issuanceOrderItem.IssuanceOrderID,
                               issuanceOrderItem = "Order" + issuanceOrderItem.IssuanceOrder.OrderNumber + "_" + issuanceOrderItem.IssuanceOrder.Warehouse.WarehouseName,
                               issuanceOrderItem.ItemID,
                               issuanceOrderItem.Item.ItemName,
                               issuanceOrderItem.Quantity,
                           })
                           .ToList();


            var bindingSource = new BindingSource
            {
                DataSource = issuanceItems
            };

            IssuanceItemsDtaGridView.DataSource = bindingSource;


            selectedItemCombobox.DataSource = bindingSource;
            selectedItemCombobox.DisplayMember = "ItemName";
            selectedItemCombobox.ValueMember = "ItemID";

        }


        private void IssuanceItemsDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < IssuanceItemsDtaGridView.Rows.Count)
            {
                int ItemId = (int)IssuanceItemsDtaGridView.Rows[e.RowIndex].Cells[2].Value;
                currentIssuanceItem = warehouseManagementDB.IssuanceOrderItems.FirstOrDefault(issuanceOrderItem =>
                    issuanceOrderItem.IssuanceOrderID == currentIssuanceOrder.IssuanceOrderID && issuanceOrderItem.ItemID == ItemId);

                selectedItemCombobox.SelectedIndex = e.RowIndex;
            }
        }
        // to filter the grid based on the data in search bar
        private void SearchSupplierItemtextBox_TextChanged(object sender, EventArgs e)
        {
            string searchQuery = searchIssuanceOrderItemTextBox.Text.ToLower();

            try
            {
                var filteredData = warehouseManagementDB.IssuanceOrderItems
                    .Where(issuanceOrderItem =>
                        issuanceOrderItem.IssuanceOrderID.ToString().Contains(searchQuery) ||
                        issuanceOrderItem.IssuanceOrder.DisplayText.ToLower().Contains(searchQuery) ||
                        issuanceOrderItem.ItemID.ToString().Contains(searchQuery) ||
                        issuanceOrderItem.Quantity.ToString().Contains(searchQuery) ||
                        issuanceOrderItem.Item.ItemName.ToLower().Contains(searchQuery))
                    .Select(issuanceOrderItem => new
                    {
                        issuanceOrderItem.IssuanceOrderID,
                        issuanceOrderItem = "Order" + issuanceOrderItem.IssuanceOrder.OrderNumber + "-" + issuanceOrderItem.IssuanceOrder.OrderDate.ToString() + "_" + issuanceOrderItem.IssuanceOrder.Warehouse.WarehouseName,
                        issuanceOrderItem.ItemID,
                        issuanceOrderItem.Item.ItemName,
                        issuanceOrderItem.Quantity,

                    })
            .ToList();



                IssuanceItemsDtaGridView.DataSource = filteredData;
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


        private void AddItemToIssuanceBtn_Click(object sender, EventArgs e)
        {
            isEditItemIssuance = false;
            ChangeToEditAddPageForIssuanceItem();
        }

        private void EditItemToIssuanceBtn_Click(object sender, EventArgs e)
        {
            if (currentIssuanceItem == null)
            {
                MessageBox.Show("Please make sure to choose item first", "Warning",
                                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            isEditItemIssuance = true;
            ChangeToEditAddPageForIssuanceItem();
        }

        private void DeleteItemToIssuanceBtn_Click(object sender, EventArgs e)
        {
            if (currentIssuanceItem == null)
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
                    warehouseManagementDB.IssuanceOrderItems.Remove(currentIssuanceItem);
                    warehouseManagementDB.SaveChanges();

                    IssuanceOrderComboBox_SelectedIndexChanged(null, null);
                    MessageBox.Show("Item deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while deleting the item. Error details: {ex.Message}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ChangeToEditAddPageForIssuanceItem()
        {
            if (!isAddInIssuancePage)
            {
                tabControl1.TabPages.Remove(itemsListPage);
            }
            else
            {
                tabControl1.TabPages.Remove(IssuanceOrdersAddEditPage);

            }
            tabControl1.TabPages.Add(itemAddEditPage);

            PopulateItemsInItemPage();


            if (!isEditItemIssuance)
            {

                itemAddEditPage.Text = "Add item to issuance order";
                saveItemToIssuanceBtn.Text = "Add";
            }
            else
            {
                itemAddEditPage.Text = "Edit supplier item";
                saveItemToIssuanceBtn.Text = "Update";


                itemNameComboBox.SelectedValue = currentIssuanceItem.ItemID;
                quantityTextBox.Text = currentIssuanceItem.Quantity.ToString();

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


            if (!int.TryParse(quantityTextBox.Text, out int quantity) || quantity <= 0)
            {
                MessageBox.Show("Quantity must be a positive integer.", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }





            int itemId = (int)itemNameComboBox.SelectedValue;
            if (isAddInIssuancePage)
            {
                bool idExists = issuanceItemsDataGridView.Rows
                                                            .Cast<DataGridViewRow>()
                                                            .Any(row => row.Cells["ItemID"].Value?.ToString() == itemId.ToString());

                if (idExists)
                {
                    MessageBox.Show("This item has already been added.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string itemName = itemNameComboBox.Text;

                issuanceItemsDataGridView.Rows.Add(itemId, itemName, quantity);
            }
            else
            {

                if (isEditItemIssuance)
                {

                    currentIssuanceItem.ItemID = itemId;
                    currentIssuanceItem.Quantity = quantity;



                    warehouseManagementDB.SaveChanges();


                    MessageBox.Show("supplier item updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {

                    var isItemIssuanceExist = warehouseManagementDB.IssuanceOrderItems
                                                                                    .FirstOrDefault(issuanceOrderItem => issuanceOrderItem.IssuanceOrderID == currentIssuanceOrder.IssuanceOrderID && issuanceOrderItem.ItemID == itemId);


                    if (isItemIssuanceExist != null)
                    {
                        isItemIssuanceExist.Quantity = quantity;

                    }
                    else
                    {
                        var issuanceItem = new IssuanceOrderItem()
                        {

                            ItemID = itemId,
                            Quantity = quantity,

                            IssuanceOrderID = currentIssuanceOrder.IssuanceOrderID

                        };
                        warehouseManagementDB.IssuanceOrderItems.Add(issuanceItem);
                    }

                    // save changes to the database
                    warehouseManagementDB.SaveChanges();

                    MessageBox.Show("Item issuance saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            UpdateIssuanceItemsDataGrid(currentIssuanceOrder.IssuanceOrderID);
            BackToIssuanceItemBtn_Click(null, null);

        }

        private void BackToIssuanceItemBtn_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(itemAddEditPage);
            if (isAddInIssuancePage)
            {
                tabControl1.TabPages.Add(IssuanceOrdersAddEditPage);
            }
            else
            {
                tabControl1.TabPages.Add(itemsListPage);
            }


            tabControl1.SelectedIndex = 1;
        }

        private void BackToIssuanceOrdersBtn_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(itemsListPage);
            tabControl1.TabPages.Add(IssuanceOrdersListPage);
        }

        #endregion



    }
}
