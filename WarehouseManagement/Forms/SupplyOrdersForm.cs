using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace WarehouseManagement.Forms
{
    public partial class SupplyOrdersForm : Form
    {
        WarehouseManagementDBEntities warehouseManagementDB = new WarehouseManagementDBEntities();
        private SupplyOrder currentSupplyOrder;

        private bool isEdit;
        public SupplyOrdersForm()
        {
            InitializeComponent();
        }

        private void UpdateGridComboViews()
        {


            var supplyOrders = warehouseManagementDB.SupplyOrders.ToList();
            supplyOrderDataGrid.DataSource = supplyOrders;


            allDataComboBox.DataSource = supplyOrders;
            allDataComboBox.DisplayMember = "DisplayText";
            allDataComboBox.ValueMember = "SupplyOrderID";


        }

        private void SupplyOrdersForm_Load(object sender, EventArgs e)
        {
            UpdateGridComboViews();
            isEdit = false;

        }


        private void DataSearchBar_TextChanged(object sender, EventArgs e)
        {
            string searchText = dataSearchBar.Text.ToLower();
            List<SupplyOrder> filteredSupplyOrders = warehouseManagementDB.SupplyOrders
                 .Where(supplyOrder =>
                     supplyOrder.SupplyOrderID.ToString().Contains(searchText)
                     || supplyOrder.WarehouseID.ToString().Contains(searchText)
                     || supplyOrder.OrderNumber.ToString().Contains(searchText)
                     || supplyOrder.SupplyOrderID.ToString().Contains(searchText))
                 .ToList();

            // Filter by OrderDate, ProductionDate, and ExpirationDate after the initial filtering
            filteredSupplyOrders = filteredSupplyOrders
                .Where(supplyOrder =>
                    supplyOrder.OrderDate.ToString("d").Contains(searchText))
                .ToList();
            if (filteredSupplyOrders.Any())
            {
                supplyOrderDataGrid.DataSource = filteredSupplyOrders;
            }
            else
            {
                supplyOrderDataGrid.DataSource = null;
            }
        }


        private void SupplyOdrerDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < supplyOrderDataGrid.Rows.Count)
            {
                int supplyOrderId = (int)supplyOrderDataGrid.Rows[e.RowIndex].Cells[0].Value;
                currentSupplyOrder = warehouseManagementDB.SupplyOrders.Find(supplyOrderId);
                /*                allDataComboBox.SelectedItem = currentSupplyOrder.DisplayText;
                */
            }
        }


        private void ChangeToEditAddPage()
        {
            tabControl1.TabPages.Remove(SupplyOrdersListPage);
            tabControl1.TabPages.Add(SupplyOrdersAddEditPage);

            if (!isEdit)
            {
                SupplyOrdersAddEditPage.Text = "Add Supply Order permission";
                AddEditSupplyOrderBtn.Text = "Add";
            }
            else
            {
                SupplyOrdersAddEditPage.Text = "Edit Supply Order permission";
                AddEditSupplyOrderBtn.Text = "Update";
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

        private void BackBtn_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(SupplyOrdersAddEditPage);
            tabControl1.TabPages.Add(SupplyOrdersListPage);
        }
    }
}
