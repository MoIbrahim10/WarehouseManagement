using Microsoft.VisualBasic;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace WarehouseManagement.Forms
{

    public partial class TransfersForm : Form
    {
        readonly WarehouseManagementDBEntities warehouseManagementDB = new WarehouseManagementDBEntities();

        public TransfersForm()
        {
            InitializeComponent();
        }


        private void TransfersForm_Load(object sender, EventArgs e)
        {
            PopulateWarehouses();
        }

        private void PopulateWarehouses()
        {

            var warehouses = warehouseManagementDB.Warehouses
                .Select(warehouse => new { warehouse.WarehouseID, warehouse.WarehouseName })
                .ToList();

            fromWarehouseComboBox.DataSource = warehouses;

            fromWarehouseComboBox.DisplayMember = "WarehouseName";
            fromWarehouseComboBox.ValueMember = "WarehouseID";


            toWarehouseComboBox.DataSource = warehouses;

            toWarehouseComboBox.DisplayMember = "WarehouseName";
            toWarehouseComboBox.ValueMember = "WarehouseID";

        }

        private void FromWarehouseComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateWarehouseData();

        }

        private void UpdateWarehouseData()
        {

            if (fromWarehouseComboBox.SelectedItem == null || !(fromWarehouseComboBox.SelectedValue is int warehouseId)) return;

            // Retrieve warehouse data from the database based on the selected warehouse
            var warehouseData = warehouseManagementDB.Warehouses
                .Where(w => w.WarehouseID == warehouseId)
                .Select(w => new
                {
                    w.WarehouseItems,
                }).FirstOrDefault();

            // If no data is found for the selected warehouse, display a message to the user
            if (warehouseData == null)
            {
                MessageBox.Show("No data found for the selected warehouse.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Map warehouse items data to anonymous objects with selected properties
            var items = warehouseData.WarehouseItems
                .Select(ws => new
                {
                    ws.Item.ItemID,
                    ws.Item.ItemName,
                    ws.Item.ItemCode,
                    ws.Item.ItemUnitOfMeasurement,
                    ws.Quantity
                }).ToList();

            // Update data source of the data grid view
            fromWarehouseDataGrid.DataSource = items;

            // If no data is found for the selected warehouse items, display a message to the user
            if (items.Count == 0)
            {
                MessageBox.Show("No data found for the selected warehouse items.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void TransferButton_Click(object sender, EventArgs e)
        {
            if (fromWarehouseDataGrid.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Please select a row to transfer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Get the selected row from the "fromWarehouseDataGrid"
            var selectedRow = fromWarehouseDataGrid.SelectedRows[0];

            if (selectedRow.Cells["ItemID"].Value != null && selectedRow.Cells["Quantity"].Value != null)
            {
                // Get the selected quantity of the item from the user
                if (int.TryParse(Interaction.InputBox("Enter the quantity to transfer:", "Transfer Quantity"), out int quantity))
                {
                    // Get the item ID and quantity from the selected row
                    var itemId = (int)selectedRow.Cells["ItemID"].Value;
                    var itemQuantity = (int)selectedRow.Cells["Quantity"].Value;

                    // Check if the selected quantity is available in the "fromWarehouseDataGrid"
                    if (quantity > itemQuantity)
                    {
                        MessageBox.Show("The selected quantity is not available in the from warehouse.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Deduct the selected quantity from the "fromWarehouseDataGrid"
                    selectedRow.Cells["Quantity"].Value = itemQuantity - quantity;

                    // Update the "fromWarehouseDataGrid" data source
                    fromWarehouseDataGrid.DataSource = fromWarehouseDataGrid.DataSource;

                    // Add the selected quantity to the "toWarehouseDataGrid"
                    var toWarehouseDataGridRow = toWarehouseDataGrid.Rows.Cast<DataGridViewRow>()
                        .FirstOrDefault(r => r.Cells["ItemID"].Value != null && (int)r.Cells["ItemID"].Value == itemId);

                    if (toWarehouseDataGridRow == null)
                    {
                        // Add a new row to the "toWarehouseDataGrid"
                        toWarehouseDataGridRow = new DataGridViewRow();
                        toWarehouseDataGridRow.CreateCells(toWarehouseDataGrid);
                        toWarehouseDataGridRow.Cells[toWarehouseDataGrid.Columns["ItemID"]?.Index ?? -1].Value = itemId;
                        toWarehouseDataGridRow.Cells[toWarehouseDataGrid.Columns["ItemName"]?.Index ?? -1].Value = selectedRow.Cells["ItemName"].Value;
                        toWarehouseDataGridRow.Cells[toWarehouseDataGrid.Columns["ItemCode"]?.Index ?? -1].Value = selectedRow.Cells["ItemCode"].Value;
                        toWarehouseDataGridRow.Cells[toWarehouseDataGrid.Columns["ItemUnitOfMeasurement"]?.Index ?? -1].Value = selectedRow.Cells["ItemUnitOfMeasurement"].Value;
                        toWarehouseDataGridRow.Cells[toWarehouseDataGrid.Columns["Quantity"]?.Index ?? -1].Value = quantity;
                        toWarehouseDataGrid.Rows.Add(toWarehouseDataGridRow);
                    }
                    else
                    {
                        // Add the selected quantity to the existing row in the "toWarehouseDataGrid"
                        var toWarehouseQuantity = (int)toWarehouseDataGridRow.Cells["Quantity"].Value;
                        toWarehouseDataGridRow.Cells["Quantity"].Value = toWarehouseQuantity + quantity;
                    }

                    // Update the "toWarehouseDataGrid" data source
                    toWarehouseDataGrid.DataSource = toWarehouseDataGrid.DataSource;

                    // Display a message to the user indicating the successful transfer
                    MessageBox.Show($"{quantity} items have been transferred successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Please enter a valid quantity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Selected row is invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
