namespace WarehouseManagement.Forms
{
    partial class ItemsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.ItemListPage = new System.Windows.Forms.TabPage();
            this.itemMainPanel = new System.Windows.Forms.Panel();
            this.allDataComboBox = new RJCodeAdvance.RJControls.RJComboBox();
            this.editItemButton = new WarehouseManagement.CustamizedButton();
            this.deleteItemButton = new WarehouseManagement.CustamizedButton();
            this.AddItemButton = new WarehouseManagement.CustamizedButton();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.dataSearchBar = new System.Windows.Forms.TextBox();
            this.searchLbl = new System.Windows.Forms.Label();
            this.itemDataGrid = new System.Windows.Forms.DataGridView();
            this.ItemAddEditPage = new System.Windows.Forms.TabPage();
            this.addWarehousPanel = new System.Windows.Forms.Panel();
            this.backBtn = new WarehouseManagement.CustamizedButton();
            this.AddEditItemBtn = new WarehouseManagement.CustamizedButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtItemUnit = new System.Windows.Forms.TextBox();
            this.itemUnitLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.ItemNameLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.ItemListPage.SuspendLayout();
            this.itemMainPanel.SuspendLayout();
            this.searchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemDataGrid)).BeginInit();
            this.ItemAddEditPage.SuspendLayout();
            this.addWarehousPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.CausesValidation = false;
            this.tabControl1.Controls.Add(this.ItemListPage);
            this.tabControl1.Controls.Add(this.ItemAddEditPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Verdana Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ItemSize = new System.Drawing.Size(180, 40);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(10, 5);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1579, 878);
            this.tabControl1.TabIndex = 20;
            // 
            // ItemListPage
            // 
            this.ItemListPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.ItemListPage.Controls.Add(this.itemMainPanel);
            this.ItemListPage.Font = new System.Drawing.Font("Verdana Pro Cond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemListPage.Location = new System.Drawing.Point(4, 44);
            this.ItemListPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ItemListPage.Name = "ItemListPage";
            this.ItemListPage.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ItemListPage.Size = new System.Drawing.Size(1571, 830);
            this.ItemListPage.TabIndex = 0;
            this.ItemListPage.Text = "Items List";
            // 
            // itemMainPanel
            // 
            this.itemMainPanel.Controls.Add(this.allDataComboBox);
            this.itemMainPanel.Controls.Add(this.editItemButton);
            this.itemMainPanel.Controls.Add(this.deleteItemButton);
            this.itemMainPanel.Controls.Add(this.AddItemButton);
            this.itemMainPanel.Controls.Add(this.searchPanel);
            this.itemMainPanel.Controls.Add(this.itemDataGrid);
            this.itemMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemMainPanel.Location = new System.Drawing.Point(4, 5);
            this.itemMainPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.itemMainPanel.Name = "itemMainPanel";
            this.itemMainPanel.Size = new System.Drawing.Size(1563, 820);
            this.itemMainPanel.TabIndex = 6;
            // 
            // allDataComboBox
            // 
            this.allDataComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.allDataComboBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.allDataComboBox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.allDataComboBox.BorderSize = 1;
            this.allDataComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.allDataComboBox.Font = new System.Drawing.Font("Verdana Pro", 13.8F);
            this.allDataComboBox.ForeColor = System.Drawing.Color.DimGray;
            this.allDataComboBox.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.allDataComboBox.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.allDataComboBox.ListTextColor = System.Drawing.Color.DimGray;
            this.allDataComboBox.Location = new System.Drawing.Point(1171, 106);
            this.allDataComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.allDataComboBox.MinimumSize = new System.Drawing.Size(250, 47);
            this.allDataComboBox.Name = "allDataComboBox";
            this.allDataComboBox.Padding = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.allDataComboBox.Size = new System.Drawing.Size(324, 47);
            this.allDataComboBox.TabIndex = 18;
            this.allDataComboBox.Texts = "";
            // 
            // editItemButton
            // 
            this.editItemButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.editItemButton.BackColor = System.Drawing.Color.LightSlateGray;
            this.editItemButton.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.editItemButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.editItemButton.BorderRadius = 7;
            this.editItemButton.BorderSize = 0;
            this.editItemButton.FlatAppearance.BorderSize = 0;
            this.editItemButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editItemButton.Font = new System.Drawing.Font("Verdana Pro Cond", 13.8F, System.Drawing.FontStyle.Bold);
            this.editItemButton.ForeColor = System.Drawing.Color.White;
            this.editItemButton.Location = new System.Drawing.Point(1190, 467);
            this.editItemButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.editItemButton.Name = "editItemButton";
            this.editItemButton.Size = new System.Drawing.Size(305, 109);
            this.editItemButton.TabIndex = 17;
            this.editItemButton.Text = "Edit Item";
            this.editItemButton.TextColor = System.Drawing.Color.White;
            this.editItemButton.UseVisualStyleBackColor = false;
            this.editItemButton.Click += new System.EventHandler(this.EditItemButton_Click);
            // 
            // deleteItemButton
            // 
            this.deleteItemButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deleteItemButton.BackColor = System.Drawing.Color.Crimson;
            this.deleteItemButton.BackgroundColor = System.Drawing.Color.Crimson;
            this.deleteItemButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.deleteItemButton.BorderRadius = 7;
            this.deleteItemButton.BorderSize = 0;
            this.deleteItemButton.FlatAppearance.BorderSize = 0;
            this.deleteItemButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteItemButton.Font = new System.Drawing.Font("Verdana Pro Cond", 13.8F, System.Drawing.FontStyle.Bold);
            this.deleteItemButton.ForeColor = System.Drawing.Color.White;
            this.deleteItemButton.Location = new System.Drawing.Point(1190, 626);
            this.deleteItemButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.deleteItemButton.Name = "deleteItemButton";
            this.deleteItemButton.Size = new System.Drawing.Size(305, 109);
            this.deleteItemButton.TabIndex = 16;
            this.deleteItemButton.Text = "Delete Item";
            this.deleteItemButton.TextColor = System.Drawing.Color.White;
            this.deleteItemButton.UseVisualStyleBackColor = false;
            this.deleteItemButton.Click += new System.EventHandler(this.DeleteItemBtn_Click);
            // 
            // AddItemButton
            // 
            this.AddItemButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddItemButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.AddItemButton.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.AddItemButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.AddItemButton.BorderRadius = 7;
            this.AddItemButton.BorderSize = 0;
            this.AddItemButton.FlatAppearance.BorderSize = 0;
            this.AddItemButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddItemButton.Font = new System.Drawing.Font("Verdana Pro Cond", 13.8F, System.Drawing.FontStyle.Bold);
            this.AddItemButton.ForeColor = System.Drawing.Color.White;
            this.AddItemButton.Location = new System.Drawing.Point(1190, 308);
            this.AddItemButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddItemButton.Name = "AddItemButton";
            this.AddItemButton.Size = new System.Drawing.Size(305, 109);
            this.AddItemButton.TabIndex = 15;
            this.AddItemButton.Text = "Add Item";
            this.AddItemButton.TextColor = System.Drawing.Color.White;
            this.AddItemButton.UseVisualStyleBackColor = false;
            this.AddItemButton.Click += new System.EventHandler(this.AddItemButton_Click);
            // 
            // searchPanel
            // 
            this.searchPanel.Controls.Add(this.dataSearchBar);
            this.searchPanel.Controls.Add(this.searchLbl);
            this.searchPanel.Location = new System.Drawing.Point(121, 66);
            this.searchPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(1011, 156);
            this.searchPanel.TabIndex = 14;
            // 
            // dataSearchBar
            // 
            this.dataSearchBar.Font = new System.Drawing.Font("Verdana Pro", 13.8F);
            this.dataSearchBar.Location = new System.Drawing.Point(224, 52);
            this.dataSearchBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataSearchBar.Name = "dataSearchBar";
            this.dataSearchBar.Size = new System.Drawing.Size(720, 35);
            this.dataSearchBar.TabIndex = 20;
            this.dataSearchBar.TextChanged += new System.EventHandler(this.DataSearchBar_TextChanged);
            // 
            // searchLbl
            // 
            this.searchLbl.AutoSize = true;
            this.searchLbl.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(118)))), ((int)(((byte)(161)))));
            this.searchLbl.Location = new System.Drawing.Point(75, 56);
            this.searchLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.searchLbl.Name = "searchLbl";
            this.searchLbl.Size = new System.Drawing.Size(99, 28);
            this.searchLbl.TabIndex = 16;
            this.searchLbl.Text = "Search";
            // 
            // itemDataGrid
            // 
            this.itemDataGrid.AllowUserToAddRows = false;
            this.itemDataGrid.AllowUserToDeleteRows = false;
            this.itemDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.itemDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.itemDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.itemDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemDataGrid.Location = new System.Drawing.Point(121, 267);
            this.itemDataGrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.itemDataGrid.Name = "itemDataGrid";
            this.itemDataGrid.ReadOnly = true;
            this.itemDataGrid.RowHeadersWidth = 51;
            this.itemDataGrid.RowTemplate.Height = 24;
            this.itemDataGrid.Size = new System.Drawing.Size(1011, 486);
            this.itemDataGrid.TabIndex = 6;
            this.itemDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ItemDataGrid_CellClick);
            // 
            // ItemAddEditPage
            // 
            this.ItemAddEditPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.ItemAddEditPage.Controls.Add(this.addWarehousPanel);
            this.ItemAddEditPage.Location = new System.Drawing.Point(4, 44);
            this.ItemAddEditPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ItemAddEditPage.Name = "ItemAddEditPage";
            this.ItemAddEditPage.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ItemAddEditPage.Size = new System.Drawing.Size(1571, 830);
            this.ItemAddEditPage.TabIndex = 1;
            this.ItemAddEditPage.Text = "Item Add";
            // 
            // addWarehousPanel
            // 
            this.addWarehousPanel.Controls.Add(this.backBtn);
            this.addWarehousPanel.Controls.Add(this.AddEditItemBtn);
            this.addWarehousPanel.Controls.Add(this.panel2);
            this.addWarehousPanel.Controls.Add(this.panel1);
            this.addWarehousPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addWarehousPanel.Location = new System.Drawing.Point(4, 5);
            this.addWarehousPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addWarehousPanel.Name = "addWarehousPanel";
            this.addWarehousPanel.Size = new System.Drawing.Size(1563, 820);
            this.addWarehousPanel.TabIndex = 23;
            // 
            // backBtn
            // 
            this.backBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.backBtn.BackColor = System.Drawing.Color.LightSlateGray;
            this.backBtn.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.backBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.backBtn.BorderRadius = 7;
            this.backBtn.BorderSize = 0;
            this.backBtn.FlatAppearance.BorderSize = 0;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Font = new System.Drawing.Font("Verdana Pro Cond", 13.8F, System.Drawing.FontStyle.Bold);
            this.backBtn.ForeColor = System.Drawing.Color.White;
            this.backBtn.Location = new System.Drawing.Point(880, 656);
            this.backBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(222, 80);
            this.backBtn.TabIndex = 6;
            this.backBtn.Text = "Back";
            this.backBtn.TextColor = System.Drawing.Color.White;
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // AddEditItemBtn
            // 
            this.AddEditItemBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddEditItemBtn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.AddEditItemBtn.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.AddEditItemBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.AddEditItemBtn.BorderRadius = 7;
            this.AddEditItemBtn.BorderSize = 0;
            this.AddEditItemBtn.FlatAppearance.BorderSize = 0;
            this.AddEditItemBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddEditItemBtn.Font = new System.Drawing.Font("Verdana Pro Cond", 13.8F, System.Drawing.FontStyle.Bold);
            this.AddEditItemBtn.ForeColor = System.Drawing.Color.White;
            this.AddEditItemBtn.Location = new System.Drawing.Point(1151, 656);
            this.AddEditItemBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddEditItemBtn.Name = "AddEditItemBtn";
            this.AddEditItemBtn.Size = new System.Drawing.Size(222, 80);
            this.AddEditItemBtn.TabIndex = 5;
            this.AddEditItemBtn.Text = "Save";
            this.AddEditItemBtn.TextColor = System.Drawing.Color.White;
            this.AddEditItemBtn.UseVisualStyleBackColor = false;
            this.AddEditItemBtn.Click += new System.EventHandler(this.AddEditItemBtn_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.Controls.Add(this.txtItemUnit);
            this.panel2.Controls.Add(this.itemUnitLabel);
            this.panel2.Location = new System.Drawing.Point(72, 292);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1370, 117);
            this.panel2.TabIndex = 2;
            // 
            // txtItemUnit
            // 
            this.txtItemUnit.Font = new System.Drawing.Font("Verdana Pro", 13.8F);
            this.txtItemUnit.Location = new System.Drawing.Point(383, 49);
            this.txtItemUnit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtItemUnit.Name = "txtItemUnit";
            this.txtItemUnit.Size = new System.Drawing.Size(918, 35);
            this.txtItemUnit.TabIndex = 2;
            // 
            // itemUnitLabel
            // 
            this.itemUnitLabel.AutoSize = true;
            this.itemUnitLabel.Font = new System.Drawing.Font("Verdana Pro Cond", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemUnitLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(118)))), ((int)(((byte)(161)))));
            this.itemUnitLabel.Location = new System.Drawing.Point(88, 52);
            this.itemUnitLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.itemUnitLabel.Name = "itemUnitLabel";
            this.itemUnitLabel.Size = new System.Drawing.Size(112, 28);
            this.itemUnitLabel.TabIndex = 1;
            this.itemUnitLabel.Text = "Item Unit";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.txtItemName);
            this.panel1.Controls.Add(this.ItemNameLabel);
            this.panel1.Location = new System.Drawing.Point(72, 95);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1370, 117);
            this.panel1.TabIndex = 1;
            // 
            // txtItemName
            // 
            this.txtItemName.Font = new System.Drawing.Font("Verdana Pro", 13.8F);
            this.txtItemName.Location = new System.Drawing.Point(383, 45);
            this.txtItemName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(918, 35);
            this.txtItemName.TabIndex = 2;
            // 
            // ItemNameLabel
            // 
            this.ItemNameLabel.AutoSize = true;
            this.ItemNameLabel.Font = new System.Drawing.Font("Verdana Pro Cond", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(118)))), ((int)(((byte)(161)))));
            this.ItemNameLabel.Location = new System.Drawing.Point(88, 48);
            this.ItemNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ItemNameLabel.Name = "ItemNameLabel";
            this.ItemNameLabel.Size = new System.Drawing.Size(128, 28);
            this.ItemNameLabel.TabIndex = 1;
            this.ItemNameLabel.Text = "Item Name";
            // 
            // ItemsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1579, 878);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Verdana Pro Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ItemsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ItemsForm";
            this.tabControl1.ResumeLayout(false);
            this.ItemListPage.ResumeLayout(false);
            this.itemMainPanel.ResumeLayout(false);
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemDataGrid)).EndInit();
            this.ItemAddEditPage.ResumeLayout(false);
            this.addWarehousPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage ItemListPage;
        private System.Windows.Forms.Panel itemMainPanel;
        private RJCodeAdvance.RJControls.RJComboBox allDataComboBox;
        private CustamizedButton editItemButton;
        private CustamizedButton deleteItemButton;
        private CustamizedButton AddItemButton;
        private System.Windows.Forms.Panel searchPanel;
        private System.Windows.Forms.TextBox dataSearchBar;
        private System.Windows.Forms.Label searchLbl;
        private System.Windows.Forms.DataGridView itemDataGrid;
        private System.Windows.Forms.TabPage ItemAddEditPage;
        private System.Windows.Forms.Panel addWarehousPanel;
        private CustamizedButton backBtn;
        private CustamizedButton AddEditItemBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtItemUnit;
        private System.Windows.Forms.Label itemUnitLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Label ItemNameLabel;
    }
}