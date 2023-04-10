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
            PopulateCustomers();

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
        private void PopulateCustomers()
        {

            var customers = warehouseManagementDB.Customers
                .Select(customer => new { customer.CustomerID, customer.CustomerName })
                .ToList();

            customersComboBox.DataSource = customers;

            customersComboBox.DisplayMember = "CustomerName";
            customersComboBox.ValueMember = "CustomerID";

        }
        #endregion
        #region Warehouse Section

        private void WarehouseReportsPage_Enter(object sender, EventArgs e)
        {
            // If there are items in the combo box, select the first item and update the data grid view accordingly
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
                    var issuanceOrders = warehouseData.IssuanceOrders
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

        }
        #endregion
        #region Suppliers Section

        private void SuppliersReportsPage_Enter(object sender, EventArgs e)
        {

        }
        #endregion
        #region Customers Section

        private void CustomersReportsPage_Enter(object sender, EventArgs e)
        {

        }

        #endregion

    }
}
