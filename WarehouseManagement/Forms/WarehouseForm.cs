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
        private bool isEdit;

        public WarehouseForm()
        {
            InitializeComponent();
            updateGridComboViews();
            allDataComboBox.SelectedItem = null;

            isEdit = false;
            tabControl1.TabPages.Remove(WarehousesAddEditPage);

        }


        private void updateGridComboViews()
        {

            var warehouses = warehouseManagementDB.Warehouses
                                        .Select(warehouse => new { warehouse.WarehouseID, warehouse.WarehouseName, warehouse.WarehouseAddress, warehouse.ManagerID })
                                        .ToList();
            warehouseDataGrid.DataSource = warehouses;

            allDataComboBox.DataSource = warehouses;
            allDataComboBox.DisplayMember = "WarehouseName";
            allDataComboBox.ValueMember = "WarehouseID";


        }

        private void PopulateManagers()
        {

            var managers = warehouseManagementDB.Employees
                .Where(e => e.EmployeeRole == "Manager")
                .Select(emp => new { emp.EmployeeID, FullName = emp.EmployeeFirstName + " " + emp.EmployeeLastName })
                .OrderBy(e => e.FullName)
                .ToList();

            comboBoxWarehouseManager.DataSource = managers;

            comboBoxWarehouseManager.DisplayMember = "FullName";
            comboBoxWarehouseManager.ValueMember = "EmployeeID";

        }

        private void dataSearchBar_TextChanged(object sender, EventArgs e)
        {

            string searchQuery = dataSearchBar.Text.ToLower();

            var filteredData = warehouseManagementDB.Warehouses
                                            .Where(warehouse =>
                                                warehouse.WarehouseID.ToString().ToLower().Contains(searchQuery) ||
                                                warehouse.WarehouseName.ToLower().Contains(searchQuery) ||
                                                warehouse.WarehouseAddress.ToLower().Contains(searchQuery) ||
                                                warehouse.ManagerID.ToString().ToLower().Contains(searchQuery))
                                            .Select(warehouse => new { warehouse.WarehouseID, warehouse.WarehouseName, warehouse.WarehouseAddress, warehouse.ManagerID })
                                            .ToList();

            if (filteredData != null && filteredData.Count > 0)
            {
                warehouseDataGrid.DataSource = filteredData;
            }
            else
            {
                warehouseDataGrid.DataSource = null;
                MessageBox.Show("No matching data found.");

            }


        }

        private void warehouseDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int warehouseId = (int)warehouseDataGrid.Rows[e.RowIndex].Cells[0].Value;
            currentWarehouse = warehouseManagementDB.Warehouses.Find(warehouseId);

            allDataComboBox.SelectedItem = currentWarehouse.WarehouseName;
        }

        private void AddWarehouseButton_Click(object sender, EventArgs e)
        {
            isEdit = false;
            changeToEditAddPage();

        }
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
        private void deleteWarehouseBtn_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to delete the selected warehouse?", "Warning",
                     MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                warehouseManagementDB.Warehouses.Remove(currentWarehouse);
                warehouseManagementDB.SaveChanges();

                updateGridComboViews();
                MessageBox.Show("Warehouse deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void changeToEditAddPage()
        {
            tabControl1.TabPages.Remove(WarehousesListPage);
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

            tabControl1.TabPages.Remove(WarehousesAddEditPage);
            tabControl1.TabPages.Add(WarehousesListPage);

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(WarehousesAddEditPage);
            tabControl1.TabPages.Add(WarehousesListPage);
        }
    }
}


