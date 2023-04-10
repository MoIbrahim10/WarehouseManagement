using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

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
            // This line of code loads data into the 'warehouseManagementDBDataSet.Suppliers' table. You can move, or remove it, as needed.
            this.suppliersTableAdapter.Fill(this.warehouseManagementDBDataSet.Suppliers);
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

            toWarehouseComboBox.DataSource = new List<object>(warehouses);
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
                        MessageBox.Show($"The selected quantity is not available in the {fromWarehouseComboBox.Text}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Deduct the selected quantity from the "fromWarehouseDataGrid"
                    selectedRow.Cells["Quantity"].Value = itemQuantity - quantity;


                    // Refresh the data grid view to reflect the updated data source
                    fromWarehouseDataGrid.Refresh();


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
                        toWarehouseDataGridRow.Cells[toWarehouseDataGrid.Columns["Quantity"]?.Index ?? -1].Value = quantity;
                        toWarehouseDataGrid.Rows.Add(toWarehouseDataGridRow);
                    }
                    else
                    {
                        // Add the selected quantity to the existing row in the "toWarehouseDataGrid"
                        var toWarehouseQuantity = (int)toWarehouseDataGridRow.Cells["Quantity"].Value;
                        if ((toWarehouseQuantity + quantity) > itemQuantity)
                        {
                            MessageBox.Show($"The selected quantity is more than it's available in the {fromWarehouseComboBox.Text}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        toWarehouseDataGridRow.Cells["Quantity"].Value = toWarehouseQuantity + quantity;
                    }

                    // Update the "toWarehouseDataGrid" data source
                    toWarehouseDataGrid.DataSource = toWarehouseDataGrid.DataSource;


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





        private void ToWarehouseDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3 || e.ColumnIndex == 4)
            {
                DateTimePicker dtp = new DateTimePicker();

                toWarehouseDataGrid.Controls.Add(dtp);
                dtp.Format = DateTimePickerFormat.Short;

                Rectangle rectangle = toWarehouseDataGrid.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                dtp.Size = new Size(rectangle.Width, rectangle.Height);
                dtp.Location = new Point(rectangle.X, rectangle.Y);
                dtp.CloseUp += new EventHandler(DateTimePicker_CloseUp);
                dtp.TextChanged += new EventHandler(DateTimePicker_TextChanged);
                dtp.Visible = true;

            }

        }
        private void DateTimePicker_CloseUp(object sender, EventArgs e)
        {
            var dtp = (DateTimePicker)sender;
            dtp.Visible = false;
            toWarehouseDataGrid.CurrentCell.Style.Padding = new Padding(0, 0, 0, toWarehouseDataGrid.RowTemplate.Height - dtp.Height);
            toWarehouseDataGrid.CurrentCell.OwningRow.Height = dtp.Height + toWarehouseDataGrid.RowTemplate.Height;
        }
        private void DateTimePicker_TextChanged(object sender, EventArgs e)
        {
            // Update the value of the current cell with the value of the DateTimePicker control
            toWarehouseDataGrid.CurrentCell.Value = ((DateTimePicker)sender).Text;
        }

        private void SaveTransferButton_Click(object sender, EventArgs e)
        {

            int fromWarehouseId = (int)fromWarehouseComboBox.SelectedValue;
            int toWarehouseId = (int)toWarehouseComboBox.SelectedValue;

            if (fromWarehouseId == toWarehouseId)
            {
                MessageBox.Show("From warehouse and To warehouse cannot be the same", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // stop the execution of the code
            }



            // flag to keep track of validation status of each row
            bool allRowsValid = true;


            // get the max TransferID from the database and add 1 to it to create a new TransferID
            int? maxTransferId = warehouseManagementDB.Transfers.Max(t => (int?)t.TransferID);
            int transferId = maxTransferId.HasValue ? maxTransferId.Value + 1 : 1;

            // create a new Transfer object
            var transferObj = new Transfer()
            {
                TransferID = transferId,
                FromWarehouseID = fromWarehouseId,
                ToWarehouseID = toWarehouseId,
                Status = "pending"
            };

            foreach (DataGridViewRow row in toWarehouseDataGrid.Rows)
            {

                int itemId = (int)row.Cells["ItemId"].Value;
                int quantity = (int)row.Cells["Quantity"].Value;

                if (row.Cells["ProductionDate"].Value == null || row.Cells["ExpirationDate"].Value == null || row.Cells["SupplierName"].Value == null ||
                    !DateTime.TryParse(row.Cells["ProductionDate"].Value.ToString(), out DateTime productionDate) ||
                    !DateTime.TryParse(row.Cells["ExpirationDate"].Value.ToString(), out DateTime expirationDate) ||
                    !int.TryParse(row.Cells["SupplierName"].Value.ToString(), out int supplierID))
                {
                    // show error message and skip the row
                    MessageBox.Show("Invalid Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    allRowsValid = false;
                    return;
                }

                MessageBox.Show($"{supplierID}");

                // check if the ProductionDate is maximum 12 days ago
                if (productionDate < DateTime.Today.AddDays(-12))
                {
                    // show error message and skip the row
                    MessageBox.Show("Production Date should be maximum 12 days ago", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    allRowsValid = false;
                    return;
                }

                // check if the ExpirationDate is after ProductionDate
                if (expirationDate <= productionDate)
                {
                    // show error message and skip the row
                    MessageBox.Show("Expiration Date should be after Production Date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    allRowsValid = false;
                    return;
                }

                // check if the SupplierName is selected
                if (supplierID <= 0)
                {
                    // show error message and skip the row
                    MessageBox.Show("Please select a supplier", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    allRowsValid = false;
                    return;
                }

                // if the row passes all validations, save it 
                // create a new TransferItem object
                var transferItem = new TransferItem()
                {
                    TransferID = transferId,
                    ItemID = itemId,
                    Quantity = quantity,
                    ProductionDate = productionDate,
                    ExpirationDate = expirationDate,
                    SupplierID = supplierID
                };

                // add the transferItem to the TransferItems collection of the Transfer object
                transferObj.TransferItems.Add(transferItem);

            }

            // add the transferObj to the database
            warehouseManagementDB.Transfers.Add(transferObj);
            if (allRowsValid)
            {
                // save changes to the database
                warehouseManagementDB.SaveChanges();
                MessageBox.Show("Transfer permission saved to database ✅", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
