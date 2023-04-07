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
    public partial class ItemsForm : Form
    {

        WarehouseManagementDBEntities warehouseManagementDB = new WarehouseManagementDBEntities();
        private Item currentItem;
        private bool isEdit;
        public ItemsForm()
        {
            InitializeComponent();
            UpdateGridComboViews();
            allDataComboBox.SelectedItem = null;

            isEdit = false;
            tabControl1.TabPages.Remove(ItemAddEditPage);
        }

        private void UpdateGridComboViews()
        {

            var items = warehouseManagementDB.Items
                                        .Select(item => new { item.ItemID, item.ItemCode, item.ItemName, item.ItemUnitOfMeasurement })
                                        .ToList();
            itemDataGrid.DataSource = items;

            allDataComboBox.DataSource = items;
            allDataComboBox.DisplayMember = "ItemName";
            allDataComboBox.ValueMember = "ItemID";


        }

        private void DataSearchBar_TextChanged(object sender, EventArgs e)
        {

            string searchQuery = dataSearchBar.Text.ToLower();

            var filteredData = warehouseManagementDB.Items
                                            .Where(item =>
                                                item.ItemID.ToString().ToLower().Contains(searchQuery) ||
                                                item.ItemName.ToLower().Contains(searchQuery) ||
                                                item.ItemCode.ToLower().Contains(searchQuery) ||
                                                item.ItemUnitOfMeasurement.ToString().ToLower().Contains(searchQuery))
                                            .Select(item => new { item.ItemID, item.ItemName, item.ItemCode, item.ItemUnitOfMeasurement })
                                            .ToList();

            if (filteredData != null && filteredData.Count > 0)
            {
                itemDataGrid.DataSource = filteredData;
            }
            else
            {
                itemDataGrid.DataSource = null;
                MessageBox.Show("No matching data found.");

            }


        }

        private void ItemDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int itemId = (int)itemDataGrid.Rows[e.RowIndex].Cells[0].Value;
            currentItem = warehouseManagementDB.Items.Find(itemId);

            allDataComboBox.SelectedItem = currentItem.ItemName;
        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            isEdit = false;
            ChangeToEditAddPage();

        }
        private void EditItemButton_Click(object sender, EventArgs e)
        {
            if (currentItem == null)
            {
                MessageBox.Show("Please make sure to choose item first", "Warning",
                                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            isEdit = true;
            ChangeToEditAddPage();
        }
        private void DeleteItemBtn_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to delete the selected item?", "Warning",
                     MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                warehouseManagementDB.Items.Remove(currentItem);
                warehouseManagementDB.SaveChanges();

                UpdateGridComboViews();
                MessageBox.Show("Item deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ChangeToEditAddPage()
        {
            tabControl1.TabPages.Remove(ItemListPage);
            tabControl1.TabPages.Add(ItemAddEditPage);

            if (!isEdit)
            {
                txtItemName.Text = "";
                txtItemUnit.Text = "";

                ItemAddEditPage.Text = "Add Item";
                AddEditItemBtn.Text = "Add";
            }
            else
            {
                ItemAddEditPage.Text = "Edit Item";
                AddEditItemBtn.Text = "Update";

                txtItemName.Text = currentItem.ItemName.ToString();
                txtItemUnit.Text = currentItem.ItemUnitOfMeasurement.ToString();

            }
        }

        private void AddEditItemBtn_Click(object sender, EventArgs e)
        {


            // Validate input fields
            if (string.IsNullOrWhiteSpace(txtItemName.Text))
            {
                MessageBox.Show("Please enter a item name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtItemUnit.Text))
            {
                MessageBox.Show("Please enter a item unit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (isEdit)
            {
                currentItem.ItemName = txtItemName.Text;
                currentItem.ItemUnitOfMeasurement = txtItemUnit.Text;


                warehouseManagementDB.SaveChanges();

                UpdateGridComboViews();
                MessageBox.Show("Item update successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Item newItem = new Item
                {
                    ItemName = txtItemName.Text,
                    ItemUnitOfMeasurement = txtItemUnit.Text,
                };

                warehouseManagementDB.Items.Add(newItem);
                warehouseManagementDB.SaveChanges();

                UpdateGridComboViews();
                MessageBox.Show("Item saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            tabControl1.TabPages.Remove(ItemAddEditPage);
            tabControl1.TabPages.Add(ItemListPage);

        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(ItemAddEditPage);
            tabControl1.TabPages.Add(ItemListPage);
        }




    }
}
