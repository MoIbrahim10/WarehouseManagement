using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services.Description;
using System.Windows.Controls;
using System.Windows.Forms;

namespace WarehouseManagement.Forms
{
    public partial class ReportsForm : Form
    {
        readonly WarehouseManagementDBEntities warehouseManagementDB = new WarehouseManagementDBEntities();
        public ReportsForm()
        {
            InitializeComponent();
        }
        private void ReportsForm_Load(object sender, EventArgs e)
        {
            PopulateWarehouses();
            PopulateItems();
            PopulateSuppliers();

        }


        #region Populate ComboBox Data
        private void PopulateWarehouses()
        {

            var warehouses = warehouseManagementDB.Warehouses
                .Select(warehouse => new { warehouse.WarehouseID, warehouse.WarehouseName })
                .ToList();

            warehousesComboBox.DataSource = warehouses;

            warehousesComboBox.DisplayMember = "WarehouseName";
            warehousesComboBox.ValueMember = "WarehouseID";

        }
        private void PopulateItems()
        {

            var items = warehouseManagementDB.Items
                .Select(item => new { item.ItemID, item.ItemName })
                .ToList();

            itemsComboBox.DataSource = items;

            itemsComboBox.DisplayMember = "ItemName";
            itemsComboBox.ValueMember = "ItemID";

        }

        private void PopulateSuppliers()
        {

            var suppliers = warehouseManagementDB.Suppliers
                .Select(supplier => new { supplier.SupplierID, supplier.SupplierName })
                .ToList();

            suppliersComboBox.DataSource = suppliers;

            suppliersComboBox.DisplayMember = "SupplierName";
            suppliersComboBox.ValueMember = "SupplierID";

        }

        #endregion
        #region Warehouse Section

        private void WarehouseReportsPage_Enter(object sender, EventArgs e)
        {
            // If there are warehouses in the combo box, select the first item and update the data grid view accordingly
            if (warehousesComboBox.Items.Count > 0)
            {
                warehousesComboBox.SelectedIndex = 0;
                UpdateWarehouseData();
            }
        }

        private void WarehousesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // When a warehouse is selected, update the data grid view accordingly
            UpdateWarehouseData();
        }

        private void UpdateWarehouseData()
        {
            if (warehousesComboBox.SelectedItem != null && warehousesComboBox.SelectedValue is int warehouseId)
            {
                // Retrieve warehouse data from the database based on the selected warehouse
                var warehouseData = warehouseManagementDB.Warehouses
                    .Where(w => w.WarehouseID == warehouseId)
                    .Select(w => new
                    {
                        w.WarehouseName,
                        w.WarehouseAddress,
                        Manager = w.Employee.EmployeeFirstName + " " + w.Employee.EmployeeLastName,
                        w.WarehouseItems,
                        w.WarehouseSuppliers,
                        w.WarehouseCustomers,
                        w.IssuanceOrders,
                        w.SupplyOrders
                    }).FirstOrDefault();

                // If no data is found for the selected warehouse, display a message to the user
                if (warehouseData == null)
                {
                    MessageBox.Show("No data found for the selected warehouse.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Populate the text boxes with the warehouse data
                warehouseNameTextBox.Text = warehouseData.WarehouseName;
                warehouseAddressTextBox.Text = warehouseData.WarehouseAddress;
                warehouseManagerTextBox.Text = warehouseData.Manager;

                // Populate the data grid view based on the selected radio button
                if (warehouseItemsRadioBtn.Checked)
                {
                    var items = warehouseData.WarehouseItems.Select(ws => new
                    {
                        ws.Item.ItemID,
                        ws.Item.ItemName,
                        ws.Item.ItemCode,
                        ws.Item.ItemUnitOfMeasurement,
                    }).ToList();
                    warehousesDataGridView.DataSource = items;

                    // If no data is found for the selected warehouse items, display a message to the user
                    if (warehousesDataGridView.Rows.Count == 0)
                    {
                        MessageBox.Show("No data found for the selected warehouse items.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (warehouseSuppliersRadioBtn.Checked)
                {
                    var suppliers = warehouseData.WarehouseSuppliers.Select(ws => new
                    {
                        ws.Supplier.SupplierID,
                        ws.Supplier.SupplierName,
                        ws.Supplier.SupplierEmail,
                        ws.Supplier.SupplierPhone,
                        ws.Supplier.SupplierWebsite
                    }).ToList();
                    warehousesDataGridView.DataSource = suppliers;

                    // If no data is found for the selected warehouse suppliers, display a message to the user
                    if (warehousesDataGridView.Rows.Count == 0)
                    {
                        MessageBox.Show("No data found for the selected warehouse suppliers.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (warehouseCustomersRadioBtn.Checked)
                {
                    var customers = warehouseData.WarehouseCustomers.Select(wc => new
                    {
                        wc.Customer.CustomerID,
                        wc.Customer.CustomerName,
                        wc.Customer.CustomerEmail,
                        wc.Customer.CustomerPhone,
                        wc.Customer.CustomerWebsite
                    }).ToList();
                    warehousesDataGridView.DataSource = customers;

                    // If no data is found for the selected warehouse customers, display a message to the user
                    if (warehousesDataGridView.Rows.Count == 0)
                    {
                        MessageBox.Show("No data found for the selected warehouse customers.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (warehouseSupplyOrdersRadioBtn.Checked)
                {
                    DateTime fromDate = fromDatePicker.Value.Date;
                    DateTime toDate = toDatePicker.Value.Date;


                    if (fromDate > toDate)
                    {
                        MessageBox.Show("Invalid date range", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    var supplyOrders = warehouseData.SupplyOrders
                                        .Where(so => so.OrderDate >= fromDate && so.OrderDate <= toDate)
                                        .Select(so => new
                                        {
                                            so.SupplyOrderID,
                                            so.OrderDate,
                                            so.WarehouseID,
                                            so.Warehouse.WarehouseName,
                                            so.SupplierID,
                                            so.Supplier.SupplierName,
                                            so.Status

                                        })
                                        .ToList();
                    warehousesDataGridView.DataSource = supplyOrders;

                    // If no data is found for the selected warehouse supply orders, display a message to the user
                    if (warehousesDataGridView.Rows.Count == 0)
                    {
                        MessageBox.Show("No data found for the selected warehouse supply orders.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }


                }
                else if (warehouseIssuanceOrdersRadioBtn.Checked)
                {

                    DateTime fromDate = fromDatePicker.Value.Date;
                    DateTime toDate = toDatePicker.Value.Date;

                    if (fromDate > toDate)
                    {
                        MessageBox.Show("Invalid date range", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    var issuanceOrders = warehouseData.IssuanceOrders
                        .Where(io => io.OrderDate >= fromDate && io.OrderDate <= toDate)
                        .Select(io => new
                        {
                            io.IssuanceOrderID,
                            io.OrderDate,
                            io.WarehouseID,
                            io.Warehouse.WarehouseName,
                            io.SupplierID,
                            io.Supplier.SupplierName,
                            io.Status

                        })
                        .ToList();
                    warehousesDataGridView.DataSource = issuanceOrders;

                    // If no data is found for the selected warehouse issuance orders, display a message to the user
                    if (warehousesDataGridView.Rows.Count == 0)
                    {
                        MessageBox.Show("No data found for the selected warehouse issuance orders.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }

        }

        private void RadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            WarehousesComboBox_SelectedIndexChanged(null, null);
        }

        private void WarehouseSearchBar_TextChanged(object sender, EventArgs e)
        {
            if (warehousesDataGridView.DataSource != null)
            {
                // Get the data displayed in the DataGridView
                var data = (IEnumerable<object>)warehousesDataGridView.DataSource;

                // Check if the data sequence is empty
                if (!data.Any())
                {
                    return; // exit the method if the sequence is empty
                }

                // Get the column names of the data
                var columnNames = data.First().GetType().GetProperties().Select(p => p.Name);

                // Filter the data based on the user's search query
                var filteredData = data.Where(d => columnNames.Any(cn => d.GetType().GetProperty(cn)?.GetValue(d)?.ToString()?.IndexOf(warehouseSearchBar.Text, StringComparison.OrdinalIgnoreCase) >= 0));

                var dataList = filteredData.ToList();
                if (dataList.Count == 0)
                {
                    MessageBox.Show("No data found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                // Update the DataGridView with the filtered data
                warehousesDataGridView.DataSource = dataList;
            }

        }
        private void DatePicker_Validating(object sender, CancelEventArgs e)
        {
            DateTime fromDate = fromDatePicker.Value.Date;
            DateTime toDate = toDatePicker.Value.Date;

            if (fromDate > toDate)
            {
                e.Cancel = true;
                fromDatePicker.Value = toDate.AddDays(-1);
                MessageBox.Show("Please select a valid date range. The 'To' date must be greater than the 'From' date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion
        #region Items Section
        private void ItemsReportsPage_Enter(object sender, EventArgs e)
        {
            // If there are items in the combo box, select the first item and update the data grid view accordingly
            if (itemsComboBox.Items.Count > 0)
            {
                itemsComboBox.SelectedIndex = 0;
                UpdateItemData();
            }
        }

        private void ItemsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // When an item is selected, update the data grid view accordingly
            UpdateItemData();
        }

        private void UpdateItemData()
        {
            if (itemsComboBox.SelectedItem != null && itemsComboBox.SelectedValue is int itemId)
            {
                // Retrieve item data from the database based on the selected item
                var itemData = warehouseManagementDB.Items
                    .Where(i => i.ItemID == itemId)
                    .Select(i => new
                    {
                        i.ItemID,
                        i.ItemName,
                        i.ItemCode,
                        i.ItemUnitOfMeasurement,
                        i.ItemSuppliers,
                        i.WarehouseItems,
                        i.SupplyOrderItems,
                        i.IssuanceOrderItems
                    }).FirstOrDefault();

                // If no data is found for the selected item, display a message to the user
                if (itemData == null)
                {
                    MessageBox.Show("No data found for the selected item.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Populate the text boxes with the warehouse item
                ItemCodeTextBox.Text = itemData.ItemCode;
                ItemUnitTextBox.Text = itemData.ItemUnitOfMeasurement;

                // Populate the data grid view based on the selected radio button
                if (itemWarehousesRadioBtn.Checked)
                {
                    var warehouses = itemData.WarehouseItems.Select(wsItem => new
                    {
                        wsItem.Warehouse.WarehouseID,
                        wsItem.Warehouse.WarehouseName,
                        wsItem.Warehouse.WarehouseAddress,
                    }).ToList();
                    itemsDataGridView.DataSource = warehouses;

                    // If no data is found for the selected item warehouses, display a message to the user
                    if (itemsDataGridView.Rows.Count == 0)
                    {
                        MessageBox.Show("No data found for the selected item in any warehouse.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (itemSuppliersRadioBtn.Checked)
                {
                    var suppliers = itemData.ItemSuppliers.Select(itemSupplier => new
                    {
                        itemSupplier.Supplier.SupplierID,
                        itemSupplier.Supplier.SupplierName,
                        itemSupplier.Supplier.SupplierEmail,
                        itemSupplier.Supplier.SupplierPhone,
                        itemSupplier.Supplier.SupplierWebsite
                    }).ToList();
                    itemsDataGridView.DataSource = suppliers;

                    // If no data is found for the selected item suppliers, display a message to the user
                    if (itemsDataGridView.Rows.Count == 0)
                    {
                        MessageBox.Show("No suppliers found for the selected item.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                else if (itemSupplyOrdersRadioBtn.Checked)
                {
                    DateTime fromDate = itemFromDatePicker.Value.Date;
                    DateTime toDate = itemToDatePicker.Value.Date;


                    if (fromDate > toDate)
                    {
                        MessageBox.Show("Invalid date range", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    var supplyOrders = itemData.SupplyOrderItems
                                        .Where(so => so.ExpirationDate >= fromDate && so.ExpirationDate <= toDate)
                                        .Select(so => new
                                        {
                                            so.SupplyOrderID,
                                            so.SupplyOrder.OrderDate,
                                            so.SupplyOrder.Warehouse.WarehouseName,
                                            so.Quantity,
                                            so.ProductionDate,
                                            so.ExpirationDate

                                        })
                                        .ToList();
                    itemsDataGridView.DataSource = supplyOrders;

                    // If no data is found for the selected item in supply orders, display a message to the user
                    if (itemsDataGridView.Rows.Count == 0)
                    {
                        MessageBox.Show("No data found for the selected item in any supply orders.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }


                }
                else if (itemIssuanceOrdersRadioBtn.Checked)
                {
                    DateTime fromDate = itemFromDatePicker.Value.Date;
                    DateTime toDate = itemToDatePicker.Value.Date;


                    if (fromDate > toDate)
                    {
                        MessageBox.Show("Invalid date range", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    var issuanceOrders = itemData.IssuanceOrderItems
                        .Where(io => io.IssuanceOrder.OrderDate >= fromDate && io.IssuanceOrder.OrderDate <= toDate)

                        .Select(io => new
                        {
                            io.IssuanceOrderID,
                            io.IssuanceOrder.OrderDate,
                            io.IssuanceOrder.Warehouse.WarehouseName,
                            io.Quantity,
                        })
                        .ToList();
                    itemsDataGridView.DataSource = issuanceOrders;

                    // If no data is found for the selected item issuance orders, display a message to the user
                    if (itemsDataGridView.Rows.Count == 0)
                    {
                        MessageBox.Show("No data found for the selected item in any issuance orders.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }

        }


        private void RadioBtnItems_CheckedChanged(object sender, EventArgs e)
        {
            ItemsComboBox_SelectedIndexChanged(null, null);
        }

        private void ItemSearchBar_TextChanged(object sender, EventArgs e)
        {
            if (itemsDataGridView.DataSource != null)
            {
                // Get the data displayed in the DataGridView
                var data = (IEnumerable<object>)itemsDataGridView.DataSource;

                // Check if the data sequence is empty
                if (!data.Any())
                {
                    return; // exit the method if the sequence is empty
                }

                // Get the column names of the data
                var columnNames = data.First().GetType().GetProperties().Select(p => p.Name);

                // Filter the data based on the user's search query
                var filteredData = data.Where(d => columnNames.Any(cn => d.GetType().GetProperty(cn)?.GetValue(d)?.ToString()?.IndexOf(warehouseSearchBar.Text, StringComparison.OrdinalIgnoreCase) >= 0));

                var dataList = filteredData.ToList();
                if (dataList.Count == 0)
                {
                    MessageBox.Show("No data found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                // Update the DataGridView with the filtered data
                itemsDataGridView.DataSource = dataList;
            }

        }
        private void DatePickerItem_Validating(object sender, CancelEventArgs e)
        {
            DateTime fromDate = itemFromDatePicker.Value.Date;
            DateTime toDate = itemToDatePicker.Value.Date;

            if (fromDate > toDate)
            {
                e.Cancel = true;
                fromDatePicker.Value = toDate.AddDays(-1);
                MessageBox.Show("Please select a valid date range. The 'To' date must be greater than the 'From' date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion
        #region Suppliers Section

        private void SuppliersReportsPage_Enter(object sender, EventArgs e)
        {
            // If there are suppliers in the combo box, select the first supplier and update the data grid view accordingly
            if (suppliersComboBox.Items.Count > 0)
            {
                suppliersComboBox.SelectedIndex = 0;
                UpdateSupplierData();
            }
        }



        private void SuppliersComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // When a supplier is selected, update the data grid view accordingly
            UpdateSupplierData();
        }

        private void UpdateSupplierData()
        {
            if (suppliersComboBox.SelectedItem != null && suppliersComboBox.SelectedValue is int supplierId)
            {
                // Retrieve supplier data from the database based on the selected supplier
                var supplierData = warehouseManagementDB.Suppliers
                    .Where(supplier => supplier.SupplierID == supplierId)
                    .Select(supplier => new
                    {
                        supplier.SupplierEmail,
                        supplier.SupplierPhone,
                        supplier.SupplierMobile,
                        supplier.SupplierWebsite,
                        supplier.SupplyOrders,
                        supplier.IssuanceOrders,
                        supplier.WarehouseSuppliers,
                        supplier.ItemSuppliers
                    }).FirstOrDefault();

                // If no data is found for the selected supplier, display a message to the user
                if (supplierData == null)
                {
                    MessageBox.Show("No data found for the selected supplier.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Populate the text boxes with the warehouse supplier
                supplierEmailTextBox.Text = supplierData.SupplierEmail;
                supplierPhoneTextBox.Text = supplierData.SupplierPhone;
                supplierMobileTextBox.Text = supplierData.SupplierMobile;
                supplierWebsiteTextBox.Text = supplierData.SupplierWebsite;

                // Populate the data grid view based on the selected radio button
                if (supplierWarehousesRadioBtn.Checked)
                {
                    var warehouses = supplierData.WarehouseSuppliers.Select(wsSupplier => new
                    {
                        wsSupplier.Warehouse.WarehouseID,
                        wsSupplier.Warehouse.WarehouseName,
                        wsSupplier.Warehouse.WarehouseAddress,
                    }).ToList();
                    supplierDataGridView.DataSource = warehouses;

                    // If no data is found for the selected supplier warehouses, display a message to the user
                    if (supplierDataGridView.Rows.Count == 0)
                    {
                        MessageBox.Show("No data found for the selected supplier in any warehouse.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (supplierItemsRadioBtn.Checked)
                {
                    var items = supplierData.ItemSuppliers.Select(item => new
                    {
                        item.Item.ItemID,
                        item.Item.ItemName,
                        item.Item.ItemCode,
                        item.Item.ItemUnitOfMeasurement,
                    }).ToList();
                    supplierDataGridView.DataSource = items;

                    // If no items is found for the selected supplier , display a message to the user
                    if (supplierDataGridView.Rows.Count == 0)
                    {
                        MessageBox.Show("No items found for the selected supplier.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                else if (supplierSupplyOrderRadioBtn.Checked)
                {
                    DateTime fromDate = supplierFromDatePicker.Value.Date;
                    DateTime toDate = supplierToDatePicker.Value.Date;


                    if (fromDate > toDate)
                    {
                        MessageBox.Show("Invalid date range", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    var supplyOrders = supplierData.SupplyOrders
                                        .Where(so => so.OrderDate >= fromDate && so.OrderDate <= toDate)
                                        .Select(so => new
                                        {
                                            so.SupplyOrderID,
                                            so.OrderNumber,
                                            so.OrderDate
                                        })
                                        .ToList();
                    supplierDataGridView.DataSource = supplyOrders;

                    // If no data is found for the selected supplier in supply orders, display a message to the user
                    if (supplierDataGridView.Rows.Count == 0)
                    {
                        MessageBox.Show("No data found for the selected supplier in any supply orders.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }


                }
                else if (supplierIssuanceOrderRadioBtn.Checked)
                {

                    DateTime fromDate = supplierFromDatePicker.Value.Date;
                    DateTime toDate = supplierToDatePicker.Value.Date;

                    if (fromDate > toDate)
                    {
                        MessageBox.Show("Invalid date range", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    var issuanceOrders = supplierData.IssuanceOrders
                                            .Where(io => io.OrderDate >= fromDate && io.OrderDate <= toDate)

                                            .Select(io => new
                                            {
                                                io.IssuanceOrderID,
                                                io.OrderNumber,
                                                io.OrderDate,
                                                io.Status
                                            })
                                            .ToList();
                    supplierDataGridView.DataSource = issuanceOrders;

                    // If no data is found for the selected supplier issuance orders, display a message to the user
                    if (supplierDataGridView.Rows.Count == 0)
                    {
                        MessageBox.Show("No data found for the selected supplier in any issuance orders.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }

        }


        private void SupplierRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            SuppliersComboBox_SelectedIndexChanged(null, null);
        }

        private void SupplierSearchBar_TextChanged(object sender, EventArgs e)
        {
            if (supplierDataGridView.DataSource != null)
            {
                // Get the data displayed in the DataGridView
                var data = (IEnumerable<object>)supplierDataGridView.DataSource;

                // Check if the data sequence is empty
                if (!data.Any())
                {
                    return; // exit the method if the sequence is empty
                }

                // Get the column names of the data
                var columnNames = data.First().GetType().GetProperties().Select(p => p.Name);

                // Filter the data based on the user's search query
                var filteredData = data.Where(d => columnNames.Any(cn => d.GetType().GetProperty(cn)?.GetValue(d)?.ToString()?.IndexOf(warehouseSearchBar.Text, StringComparison.OrdinalIgnoreCase) >= 0));

                var dataList = filteredData.ToList();
                if (dataList.Count == 0)
                {
                    MessageBox.Show("No data found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                // Update the DataGridView with the filtered data
                supplierDataGridView.DataSource = dataList;
            }

        }

        private void supplierDatePicker_Validating(object sender, CancelEventArgs e)
        {
            DateTime fromDate = supplierFromDatePicker.Value.Date;
            DateTime toDate = supplierToDatePicker.Value.Date;

            if (fromDate > toDate)
            {
                e.Cancel = true;
                fromDatePicker.Value = toDate.AddDays(-1);
                MessageBox.Show("Please select a valid date range. The 'To' date must be greater than the 'From' date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion



    }
}
