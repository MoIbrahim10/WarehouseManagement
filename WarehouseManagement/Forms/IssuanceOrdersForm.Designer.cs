namespace WarehouseManagement.Forms
{
    partial class IssuanceOrdersForm
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
            this.itemAddEditPage = new System.Windows.Forms.TabPage();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.itemNameLbl = new System.Windows.Forms.Label();
            this.itemNameComboBox = new System.Windows.Forms.ComboBox();
            this.panel11 = new System.Windows.Forms.Panel();
            this.itemQuantityLbl = new System.Windows.Forms.Label();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.itemsListPage = new System.Windows.Forms.TabPage();
            this.panel7 = new System.Windows.Forms.Panel();
            this.IssuanceItemsDtaGridView = new System.Windows.Forms.DataGridView();
            this.selectedItemCombobox = new RJCodeAdvance.RJControls.RJComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.searchIssuanceOrderItemTextBox = new System.Windows.Forms.TextBox();
            this.IssuanceOrderComboBox = new System.Windows.Forms.ComboBox();
            this.IssuanceOrdersAddEditPage = new System.Windows.Forms.TabPage();
            this.addWarehousPanel = new System.Windows.Forms.Panel();
            this.issuanceItemsDataGridView = new System.Windows.Forms.DataGridView();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.warehouseNameLbl = new System.Windows.Forms.Label();
            this.warehousesComboBox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.supplierNameLbl = new System.Windows.Forms.Label();
            this.suppliersComboBox = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.orderDateLbl = new System.Windows.Forms.Label();
            this.orderDatePicker = new RJCodeAdvance.RJControls.RJDatePicker();
            this.IssuanceOrdersListPage = new System.Windows.Forms.TabPage();
            this.issuanceOrderMainPanel = new System.Windows.Forms.Panel();
            this.issuanceOrderDataGrid = new System.Windows.Forms.DataGridView();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.searchLbl = new System.Windows.Forms.Label();
            this.dataSearchBar = new System.Windows.Forms.TextBox();
            this.allDataComboBox = new RJCodeAdvance.RJControls.RJComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.viewItemsButton = new WarehouseManagement.CustamizedButton();
            this.editIssuanceOrderButton = new WarehouseManagement.CustamizedButton();
            this.deleteIssuanceOrderButton = new WarehouseManagement.CustamizedButton();
            this.AddIssuanceOrderButton = new WarehouseManagement.CustamizedButton();
            this.addItemInIssuancePageBtn = new WarehouseManagement.CustamizedButton();
            this.backBtn = new WarehouseManagement.CustamizedButton();
            this.AddEditIssuanceOrderBtn = new WarehouseManagement.CustamizedButton();
            this.backToIssuanceOrdersBtn = new WarehouseManagement.CustamizedButton();
            this.editItemToIssuanceBtn = new WarehouseManagement.CustamizedButton();
            this.deleteItemToIssuanceBtn = new WarehouseManagement.CustamizedButton();
            this.addItemToIssuanceBtn = new WarehouseManagement.CustamizedButton();
            this.BackToIssuanceItemBtn = new WarehouseManagement.CustamizedButton();
            this.saveItemToIssuanceBtn = new WarehouseManagement.CustamizedButton();
            this.itemAddEditPage.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel11.SuspendLayout();
            this.itemsListPage.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IssuanceItemsDtaGridView)).BeginInit();
            this.panel4.SuspendLayout();
            this.IssuanceOrdersAddEditPage.SuspendLayout();
            this.addWarehousPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.issuanceItemsDataGridView)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.IssuanceOrdersListPage.SuspendLayout();
            this.issuanceOrderMainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.issuanceOrderDataGrid)).BeginInit();
            this.searchPanel.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // itemAddEditPage
            // 
            this.itemAddEditPage.Controls.Add(this.panel9);
            this.itemAddEditPage.Location = new System.Drawing.Point(4, 44);
            this.itemAddEditPage.Name = "itemAddEditPage";
            this.itemAddEditPage.Size = new System.Drawing.Size(1571, 830);
            this.itemAddEditPage.TabIndex = 3;
            this.itemAddEditPage.Text = "Add Item";
            this.itemAddEditPage.UseVisualStyleBackColor = true;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.panel9.Controls.Add(this.panel11);
            this.panel9.Controls.Add(this.BackToIssuanceItemBtn);
            this.panel9.Controls.Add(this.saveItemToIssuanceBtn);
            this.panel9.Controls.Add(this.panel15);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1571, 830);
            this.panel9.TabIndex = 24;
            // 
            // panel15
            // 
            this.panel15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel15.Controls.Add(this.itemNameComboBox);
            this.panel15.Controls.Add(this.itemNameLbl);
            this.panel15.Location = new System.Drawing.Point(186, 246);
            this.panel15.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(801, 191);
            this.panel15.TabIndex = 1;
            // 
            // itemNameLbl
            // 
            this.itemNameLbl.AutoSize = true;
            this.itemNameLbl.Font = new System.Drawing.Font("Verdana Pro Cond", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemNameLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(118)))), ((int)(((byte)(161)))));
            this.itemNameLbl.Location = new System.Drawing.Point(46, 48);
            this.itemNameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.itemNameLbl.Name = "itemNameLbl";
            this.itemNameLbl.Size = new System.Drawing.Size(128, 28);
            this.itemNameLbl.TabIndex = 1;
            this.itemNameLbl.Text = "Item Name";
            // 
            // itemNameComboBox
            // 
            this.itemNameComboBox.FormattingEnabled = true;
            this.itemNameComboBox.Location = new System.Drawing.Point(51, 109);
            this.itemNameComboBox.Name = "itemNameComboBox";
            this.itemNameComboBox.Size = new System.Drawing.Size(697, 33);
            this.itemNameComboBox.TabIndex = 18;
            // 
            // panel11
            // 
            this.panel11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel11.Controls.Add(this.quantityTextBox);
            this.panel11.Controls.Add(this.itemQuantityLbl);
            this.panel11.Location = new System.Drawing.Point(1052, 246);
            this.panel11.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(329, 191);
            this.panel11.TabIndex = 14;
            // 
            // itemQuantityLbl
            // 
            this.itemQuantityLbl.AutoSize = true;
            this.itemQuantityLbl.Font = new System.Drawing.Font("Verdana Pro Cond", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemQuantityLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(118)))), ((int)(((byte)(161)))));
            this.itemQuantityLbl.Location = new System.Drawing.Point(46, 48);
            this.itemQuantityLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.itemQuantityLbl.Name = "itemQuantityLbl";
            this.itemQuantityLbl.Size = new System.Drawing.Size(158, 28);
            this.itemQuantityLbl.TabIndex = 1;
            this.itemQuantityLbl.Text = "Item Quantity";
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(51, 109);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(237, 32);
            this.quantityTextBox.TabIndex = 16;
            // 
            // itemsListPage
            // 
            this.itemsListPage.Controls.Add(this.panel7);
            this.itemsListPage.Location = new System.Drawing.Point(4, 44);
            this.itemsListPage.Name = "itemsListPage";
            this.itemsListPage.Size = new System.Drawing.Size(1571, 830);
            this.itemsListPage.TabIndex = 2;
            this.itemsListPage.Text = "Items List";
            this.itemsListPage.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.panel7.Controls.Add(this.backToIssuanceOrdersBtn);
            this.panel7.Controls.Add(this.IssuanceOrderComboBox);
            this.panel7.Controls.Add(this.panel4);
            this.panel7.Controls.Add(this.selectedItemCombobox);
            this.panel7.Controls.Add(this.editItemToIssuanceBtn);
            this.panel7.Controls.Add(this.deleteItemToIssuanceBtn);
            this.panel7.Controls.Add(this.addItemToIssuanceBtn);
            this.panel7.Controls.Add(this.IssuanceItemsDtaGridView);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1571, 830);
            this.panel7.TabIndex = 7;
            // 
            // IssuanceItemsDtaGridView
            // 
            this.IssuanceItemsDtaGridView.AllowUserToAddRows = false;
            this.IssuanceItemsDtaGridView.AllowUserToDeleteRows = false;
            this.IssuanceItemsDtaGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.IssuanceItemsDtaGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.IssuanceItemsDtaGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.IssuanceItemsDtaGridView.Location = new System.Drawing.Point(121, 267);
            this.IssuanceItemsDtaGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.IssuanceItemsDtaGridView.Name = "IssuanceItemsDtaGridView";
            this.IssuanceItemsDtaGridView.ReadOnly = true;
            this.IssuanceItemsDtaGridView.RowHeadersWidth = 51;
            this.IssuanceItemsDtaGridView.RowTemplate.Height = 24;
            this.IssuanceItemsDtaGridView.Size = new System.Drawing.Size(1011, 486);
            this.IssuanceItemsDtaGridView.TabIndex = 6;
            // 
            // selectedItemCombobox
            // 
            this.selectedItemCombobox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.selectedItemCombobox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.selectedItemCombobox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.selectedItemCombobox.BorderSize = 1;
            this.selectedItemCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.selectedItemCombobox.Font = new System.Drawing.Font("Verdana Pro", 13.8F);
            this.selectedItemCombobox.ForeColor = System.Drawing.Color.DimGray;
            this.selectedItemCombobox.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.selectedItemCombobox.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.selectedItemCombobox.ListTextColor = System.Drawing.Color.DimGray;
            this.selectedItemCombobox.Location = new System.Drawing.Point(1175, 111);
            this.selectedItemCombobox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.selectedItemCombobox.MinimumSize = new System.Drawing.Size(250, 47);
            this.selectedItemCombobox.Name = "selectedItemCombobox";
            this.selectedItemCombobox.Padding = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.selectedItemCombobox.Size = new System.Drawing.Size(324, 47);
            this.selectedItemCombobox.TabIndex = 18;
            this.selectedItemCombobox.Texts = "";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.searchIssuanceOrderItemTextBox);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(519, 66);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(613, 156);
            this.panel4.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(118)))), ((int)(((byte)(161)))));
            this.label2.Location = new System.Drawing.Point(75, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 28);
            this.label2.TabIndex = 16;
            this.label2.Text = "Search";
            // 
            // searchIssuanceOrderItemTextBox
            // 
            this.searchIssuanceOrderItemTextBox.Font = new System.Drawing.Font("Verdana Pro", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchIssuanceOrderItemTextBox.Location = new System.Drawing.Point(224, 52);
            this.searchIssuanceOrderItemTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchIssuanceOrderItemTextBox.Name = "searchIssuanceOrderItemTextBox";
            this.searchIssuanceOrderItemTextBox.Size = new System.Drawing.Size(288, 35);
            this.searchIssuanceOrderItemTextBox.TabIndex = 20;
            this.searchIssuanceOrderItemTextBox.TextChanged += new System.EventHandler(this.SearchSupplierItemtextBox_TextChanged);
            // 
            // IssuanceOrderComboBox
            // 
            this.IssuanceOrderComboBox.Font = new System.Drawing.Font("Verdana Pro Cond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IssuanceOrderComboBox.FormattingEnabled = true;
            this.IssuanceOrderComboBox.Location = new System.Drawing.Point(121, 122);
            this.IssuanceOrderComboBox.Name = "IssuanceOrderComboBox";
            this.IssuanceOrderComboBox.Size = new System.Drawing.Size(324, 36);
            this.IssuanceOrderComboBox.TabIndex = 22;
            this.IssuanceOrderComboBox.SelectedIndexChanged += new System.EventHandler(this.IssuanceOrderComboBox_SelectedIndexChanged);
            // 
            // IssuanceOrdersAddEditPage
            // 
            this.IssuanceOrdersAddEditPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.IssuanceOrdersAddEditPage.Controls.Add(this.addWarehousPanel);
            this.IssuanceOrdersAddEditPage.Location = new System.Drawing.Point(4, 44);
            this.IssuanceOrdersAddEditPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.IssuanceOrdersAddEditPage.Name = "IssuanceOrdersAddEditPage";
            this.IssuanceOrdersAddEditPage.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.IssuanceOrdersAddEditPage.Size = new System.Drawing.Size(1571, 830);
            this.IssuanceOrdersAddEditPage.TabIndex = 1;
            this.IssuanceOrdersAddEditPage.Text = "Edit Issuance Order";
            // 
            // addWarehousPanel
            // 
            this.addWarehousPanel.Controls.Add(this.addItemInIssuancePageBtn);
            this.addWarehousPanel.Controls.Add(this.panel2);
            this.addWarehousPanel.Controls.Add(this.panel1);
            this.addWarehousPanel.Controls.Add(this.panel3);
            this.addWarehousPanel.Controls.Add(this.issuanceItemsDataGridView);
            this.addWarehousPanel.Controls.Add(this.backBtn);
            this.addWarehousPanel.Controls.Add(this.AddEditIssuanceOrderBtn);
            this.addWarehousPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addWarehousPanel.Location = new System.Drawing.Point(4, 5);
            this.addWarehousPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addWarehousPanel.Name = "addWarehousPanel";
            this.addWarehousPanel.Size = new System.Drawing.Size(1563, 820);
            this.addWarehousPanel.TabIndex = 23;
            // 
            // issuanceItemsDataGridView
            // 
            this.issuanceItemsDataGridView.AllowUserToAddRows = false;
            this.issuanceItemsDataGridView.AllowUserToResizeColumns = false;
            this.issuanceItemsDataGridView.AllowUserToResizeRows = false;
            this.issuanceItemsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.issuanceItemsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.issuanceItemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.issuanceItemsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemID,
            this.ItemName,
            this.Quantity});
            this.issuanceItemsDataGridView.Location = new System.Drawing.Point(72, 296);
            this.issuanceItemsDataGridView.Name = "issuanceItemsDataGridView";
            this.issuanceItemsDataGridView.RowHeadersWidth = 51;
            this.issuanceItemsDataGridView.RowTemplate.Height = 24;
            this.issuanceItemsDataGridView.Size = new System.Drawing.Size(1161, 316);
            this.issuanceItemsDataGridView.TabIndex = 9;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // ItemName
            // 
            this.ItemName.HeaderText = "Item Name";
            this.ItemName.MinimumWidth = 6;
            this.ItemName.Name = "ItemName";
            this.ItemName.ReadOnly = true;
            // 
            // ItemID
            // 
            this.ItemID.HeaderText = "Item ID";
            this.ItemID.MinimumWidth = 6;
            this.ItemID.Name = "ItemID";
            this.ItemID.ReadOnly = true;
            this.ItemID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.Controls.Add(this.warehousesComboBox);
            this.panel3.Controls.Add(this.warehouseNameLbl);
            this.panel3.Location = new System.Drawing.Point(72, 55);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(329, 191);
            this.panel3.TabIndex = 4;
            // 
            // warehouseNameLbl
            // 
            this.warehouseNameLbl.AutoSize = true;
            this.warehouseNameLbl.Font = new System.Drawing.Font("Verdana Pro Cond", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warehouseNameLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(118)))), ((int)(((byte)(161)))));
            this.warehouseNameLbl.Location = new System.Drawing.Point(46, 48);
            this.warehouseNameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.warehouseNameLbl.Name = "warehouseNameLbl";
            this.warehouseNameLbl.Size = new System.Drawing.Size(191, 28);
            this.warehouseNameLbl.TabIndex = 1;
            this.warehouseNameLbl.Text = "Warehouse Name";
            // 
            // warehousesComboBox
            // 
            this.warehousesComboBox.FormattingEnabled = true;
            this.warehousesComboBox.Location = new System.Drawing.Point(51, 109);
            this.warehousesComboBox.Name = "warehousesComboBox";
            this.warehousesComboBox.Size = new System.Drawing.Size(228, 33);
            this.warehousesComboBox.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.suppliersComboBox);
            this.panel1.Controls.Add(this.supplierNameLbl);
            this.panel1.Location = new System.Drawing.Point(592, 55);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(329, 191);
            this.panel1.TabIndex = 5;
            // 
            // supplierNameLbl
            // 
            this.supplierNameLbl.AutoSize = true;
            this.supplierNameLbl.Font = new System.Drawing.Font("Verdana Pro Cond", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplierNameLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(118)))), ((int)(((byte)(161)))));
            this.supplierNameLbl.Location = new System.Drawing.Point(46, 48);
            this.supplierNameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.supplierNameLbl.Name = "supplierNameLbl";
            this.supplierNameLbl.Size = new System.Drawing.Size(164, 28);
            this.supplierNameLbl.TabIndex = 1;
            this.supplierNameLbl.Text = "Supplier Name";
            // 
            // suppliersComboBox
            // 
            this.suppliersComboBox.FormattingEnabled = true;
            this.suppliersComboBox.Location = new System.Drawing.Point(51, 109);
            this.suppliersComboBox.Name = "suppliersComboBox";
            this.suppliersComboBox.Size = new System.Drawing.Size(228, 33);
            this.suppliersComboBox.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.Controls.Add(this.orderDatePicker);
            this.panel2.Controls.Add(this.orderDateLbl);
            this.panel2.Location = new System.Drawing.Point(1113, 55);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(329, 191);
            this.panel2.TabIndex = 10;
            // 
            // orderDateLbl
            // 
            this.orderDateLbl.AutoSize = true;
            this.orderDateLbl.Font = new System.Drawing.Font("Verdana Pro Cond", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderDateLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(118)))), ((int)(((byte)(161)))));
            this.orderDateLbl.Location = new System.Drawing.Point(46, 48);
            this.orderDateLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.orderDateLbl.Name = "orderDateLbl";
            this.orderDateLbl.Size = new System.Drawing.Size(124, 28);
            this.orderDateLbl.TabIndex = 3;
            this.orderDateLbl.Text = "Order Date";
            // 
            // orderDatePicker
            // 
            this.orderDatePicker.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.orderDatePicker.BorderSize = 0;
            this.orderDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.orderDatePicker.Location = new System.Drawing.Point(51, 109);
            this.orderDatePicker.MinimumSize = new System.Drawing.Size(4, 35);
            this.orderDatePicker.Name = "orderDatePicker";
            this.orderDatePicker.Size = new System.Drawing.Size(232, 35);
            this.orderDatePicker.SkinColor = System.Drawing.Color.Thistle;
            this.orderDatePicker.TabIndex = 11;
            this.orderDatePicker.TextColor = System.Drawing.Color.White;
            // 
            // IssuanceOrdersListPage
            // 
            this.IssuanceOrdersListPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.IssuanceOrdersListPage.Controls.Add(this.issuanceOrderMainPanel);
            this.IssuanceOrdersListPage.Font = new System.Drawing.Font("Verdana Pro Cond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IssuanceOrdersListPage.Location = new System.Drawing.Point(4, 44);
            this.IssuanceOrdersListPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.IssuanceOrdersListPage.Name = "IssuanceOrdersListPage";
            this.IssuanceOrdersListPage.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.IssuanceOrdersListPage.Size = new System.Drawing.Size(1571, 830);
            this.IssuanceOrdersListPage.TabIndex = 0;
            this.IssuanceOrdersListPage.Text = "Issuance Orders List";
            // 
            // issuanceOrderMainPanel
            // 
            this.issuanceOrderMainPanel.Controls.Add(this.viewItemsButton);
            this.issuanceOrderMainPanel.Controls.Add(this.allDataComboBox);
            this.issuanceOrderMainPanel.Controls.Add(this.editIssuanceOrderButton);
            this.issuanceOrderMainPanel.Controls.Add(this.deleteIssuanceOrderButton);
            this.issuanceOrderMainPanel.Controls.Add(this.AddIssuanceOrderButton);
            this.issuanceOrderMainPanel.Controls.Add(this.searchPanel);
            this.issuanceOrderMainPanel.Controls.Add(this.issuanceOrderDataGrid);
            this.issuanceOrderMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.issuanceOrderMainPanel.Location = new System.Drawing.Point(4, 5);
            this.issuanceOrderMainPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.issuanceOrderMainPanel.Name = "issuanceOrderMainPanel";
            this.issuanceOrderMainPanel.Size = new System.Drawing.Size(1563, 820);
            this.issuanceOrderMainPanel.TabIndex = 6;
            // 
            // issuanceOrderDataGrid
            // 
            this.issuanceOrderDataGrid.AllowUserToAddRows = false;
            this.issuanceOrderDataGrid.AllowUserToDeleteRows = false;
            this.issuanceOrderDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.issuanceOrderDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.issuanceOrderDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.issuanceOrderDataGrid.Location = new System.Drawing.Point(121, 267);
            this.issuanceOrderDataGrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.issuanceOrderDataGrid.Name = "issuanceOrderDataGrid";
            this.issuanceOrderDataGrid.ReadOnly = true;
            this.issuanceOrderDataGrid.RowHeadersWidth = 51;
            this.issuanceOrderDataGrid.RowTemplate.Height = 24;
            this.issuanceOrderDataGrid.Size = new System.Drawing.Size(1011, 486);
            this.issuanceOrderDataGrid.TabIndex = 6;
            this.issuanceOrderDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.IssuanceOdrerDataGrid_CellClick);
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
            // tabControl1
            // 
            this.tabControl1.CausesValidation = false;
            this.tabControl1.Controls.Add(this.IssuanceOrdersListPage);
            this.tabControl1.Controls.Add(this.IssuanceOrdersAddEditPage);
            this.tabControl1.Controls.Add(this.itemsListPage);
            this.tabControl1.Controls.Add(this.itemAddEditPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Verdana Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ItemSize = new System.Drawing.Size(180, 40);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(10, 5);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1579, 878);
            this.tabControl1.TabIndex = 23;
            // 
            // viewItemsButton
            // 
            this.viewItemsButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.viewItemsButton.BackColor = System.Drawing.Color.Plum;
            this.viewItemsButton.BackgroundColor = System.Drawing.Color.Plum;
            this.viewItemsButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.viewItemsButton.BorderRadius = 7;
            this.viewItemsButton.BorderSize = 0;
            this.viewItemsButton.FlatAppearance.BorderSize = 0;
            this.viewItemsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewItemsButton.Font = new System.Drawing.Font("Verdana Pro Cond", 13.8F, System.Drawing.FontStyle.Bold);
            this.viewItemsButton.ForeColor = System.Drawing.Color.White;
            this.viewItemsButton.Location = new System.Drawing.Point(1190, 226);
            this.viewItemsButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.viewItemsButton.Name = "viewItemsButton";
            this.viewItemsButton.Size = new System.Drawing.Size(305, 109);
            this.viewItemsButton.TabIndex = 19;
            this.viewItemsButton.Text = "View Items";
            this.viewItemsButton.TextColor = System.Drawing.Color.White;
            this.viewItemsButton.UseVisualStyleBackColor = false;
            this.viewItemsButton.Click += new System.EventHandler(this.ViewItemsButton_Click);
            // 
            // editIssuanceOrderButton
            // 
            this.editIssuanceOrderButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.editIssuanceOrderButton.BackColor = System.Drawing.Color.LightSlateGray;
            this.editIssuanceOrderButton.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.editIssuanceOrderButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.editIssuanceOrderButton.BorderRadius = 7;
            this.editIssuanceOrderButton.BorderSize = 0;
            this.editIssuanceOrderButton.FlatAppearance.BorderSize = 0;
            this.editIssuanceOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editIssuanceOrderButton.Font = new System.Drawing.Font("Verdana Pro Cond", 13.8F, System.Drawing.FontStyle.Bold);
            this.editIssuanceOrderButton.ForeColor = System.Drawing.Color.White;
            this.editIssuanceOrderButton.Location = new System.Drawing.Point(1190, 528);
            this.editIssuanceOrderButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.editIssuanceOrderButton.Name = "editIssuanceOrderButton";
            this.editIssuanceOrderButton.Size = new System.Drawing.Size(305, 109);
            this.editIssuanceOrderButton.TabIndex = 17;
            this.editIssuanceOrderButton.Text = "Edit Issuance Order";
            this.editIssuanceOrderButton.TextColor = System.Drawing.Color.White;
            this.editIssuanceOrderButton.UseVisualStyleBackColor = false;
            this.editIssuanceOrderButton.Click += new System.EventHandler(this.EditIssuanceOrderButton_Click);
            // 
            // deleteIssuanceOrderButton
            // 
            this.deleteIssuanceOrderButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deleteIssuanceOrderButton.BackColor = System.Drawing.Color.Crimson;
            this.deleteIssuanceOrderButton.BackgroundColor = System.Drawing.Color.Crimson;
            this.deleteIssuanceOrderButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.deleteIssuanceOrderButton.BorderRadius = 7;
            this.deleteIssuanceOrderButton.BorderSize = 0;
            this.deleteIssuanceOrderButton.FlatAppearance.BorderSize = 0;
            this.deleteIssuanceOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteIssuanceOrderButton.Font = new System.Drawing.Font("Verdana Pro Cond", 13.8F, System.Drawing.FontStyle.Bold);
            this.deleteIssuanceOrderButton.ForeColor = System.Drawing.Color.White;
            this.deleteIssuanceOrderButton.Location = new System.Drawing.Point(1190, 679);
            this.deleteIssuanceOrderButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.deleteIssuanceOrderButton.Name = "deleteIssuanceOrderButton";
            this.deleteIssuanceOrderButton.Size = new System.Drawing.Size(305, 109);
            this.deleteIssuanceOrderButton.TabIndex = 16;
            this.deleteIssuanceOrderButton.Text = "Delete Issuance Order";
            this.deleteIssuanceOrderButton.TextColor = System.Drawing.Color.White;
            this.deleteIssuanceOrderButton.UseVisualStyleBackColor = false;
            this.deleteIssuanceOrderButton.Click += new System.EventHandler(this.DeleteIssuanceOrderButton_Click);
            // 
            // AddIssuanceOrderButton
            // 
            this.AddIssuanceOrderButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddIssuanceOrderButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.AddIssuanceOrderButton.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.AddIssuanceOrderButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.AddIssuanceOrderButton.BorderRadius = 7;
            this.AddIssuanceOrderButton.BorderSize = 0;
            this.AddIssuanceOrderButton.FlatAppearance.BorderSize = 0;
            this.AddIssuanceOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddIssuanceOrderButton.Font = new System.Drawing.Font("Verdana Pro Cond", 13.8F, System.Drawing.FontStyle.Bold);
            this.AddIssuanceOrderButton.ForeColor = System.Drawing.Color.White;
            this.AddIssuanceOrderButton.Location = new System.Drawing.Point(1190, 370);
            this.AddIssuanceOrderButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddIssuanceOrderButton.Name = "AddIssuanceOrderButton";
            this.AddIssuanceOrderButton.Size = new System.Drawing.Size(305, 109);
            this.AddIssuanceOrderButton.TabIndex = 15;
            this.AddIssuanceOrderButton.Text = "Add Issuance Order";
            this.AddIssuanceOrderButton.TextColor = System.Drawing.Color.White;
            this.AddIssuanceOrderButton.UseVisualStyleBackColor = false;
            this.AddIssuanceOrderButton.Click += new System.EventHandler(this.AddIssuanceOrderButton_Click);
            // 
            // addItemInIssuancePageBtn
            // 
            this.addItemInIssuancePageBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addItemInIssuancePageBtn.BackColor = System.Drawing.Color.LightPink;
            this.addItemInIssuancePageBtn.BackgroundColor = System.Drawing.Color.LightPink;
            this.addItemInIssuancePageBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.addItemInIssuancePageBtn.BorderRadius = 7;
            this.addItemInIssuancePageBtn.BorderSize = 0;
            this.addItemInIssuancePageBtn.FlatAppearance.BorderSize = 0;
            this.addItemInIssuancePageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addItemInIssuancePageBtn.Font = new System.Drawing.Font("Verdana Pro Cond", 13.8F, System.Drawing.FontStyle.Bold);
            this.addItemInIssuancePageBtn.ForeColor = System.Drawing.Color.White;
            this.addItemInIssuancePageBtn.Location = new System.Drawing.Point(1274, 434);
            this.addItemInIssuancePageBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addItemInIssuancePageBtn.Name = "addItemInIssuancePageBtn";
            this.addItemInIssuancePageBtn.Size = new System.Drawing.Size(168, 66);
            this.addItemInIssuancePageBtn.TabIndex = 18;
            this.addItemInIssuancePageBtn.Text = "Add Item";
            this.addItemInIssuancePageBtn.TextColor = System.Drawing.Color.White;
            this.addItemInIssuancePageBtn.UseVisualStyleBackColor = false;
            this.addItemInIssuancePageBtn.Click += new System.EventHandler(this.AddItemInIssuancePageBtn_Click);
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
            // AddEditIssuanceOrderBtn
            // 
            this.AddEditIssuanceOrderBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddEditIssuanceOrderBtn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.AddEditIssuanceOrderBtn.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.AddEditIssuanceOrderBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.AddEditIssuanceOrderBtn.BorderRadius = 7;
            this.AddEditIssuanceOrderBtn.BorderSize = 0;
            this.AddEditIssuanceOrderBtn.FlatAppearance.BorderSize = 0;
            this.AddEditIssuanceOrderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddEditIssuanceOrderBtn.Font = new System.Drawing.Font("Verdana Pro Cond", 13.8F, System.Drawing.FontStyle.Bold);
            this.AddEditIssuanceOrderBtn.ForeColor = System.Drawing.Color.White;
            this.AddEditIssuanceOrderBtn.Location = new System.Drawing.Point(1151, 656);
            this.AddEditIssuanceOrderBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddEditIssuanceOrderBtn.Name = "AddEditIssuanceOrderBtn";
            this.AddEditIssuanceOrderBtn.Size = new System.Drawing.Size(222, 80);
            this.AddEditIssuanceOrderBtn.TabIndex = 5;
            this.AddEditIssuanceOrderBtn.Text = "Save";
            this.AddEditIssuanceOrderBtn.TextColor = System.Drawing.Color.White;
            this.AddEditIssuanceOrderBtn.UseVisualStyleBackColor = false;
            this.AddEditIssuanceOrderBtn.Click += new System.EventHandler(this.AddEditIssuanceOrderBtn_Click);
            // 
            // backToIssuanceOrdersBtn
            // 
            this.backToIssuanceOrdersBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.backToIssuanceOrdersBtn.BackColor = System.Drawing.Color.PowderBlue;
            this.backToIssuanceOrdersBtn.BackgroundColor = System.Drawing.Color.PowderBlue;
            this.backToIssuanceOrdersBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.backToIssuanceOrdersBtn.BorderRadius = 7;
            this.backToIssuanceOrdersBtn.BorderSize = 0;
            this.backToIssuanceOrdersBtn.FlatAppearance.BorderSize = 0;
            this.backToIssuanceOrdersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backToIssuanceOrdersBtn.Font = new System.Drawing.Font("Verdana Pro Cond", 13.8F, System.Drawing.FontStyle.Bold);
            this.backToIssuanceOrdersBtn.ForeColor = System.Drawing.Color.Black;
            this.backToIssuanceOrdersBtn.Location = new System.Drawing.Point(33, 28);
            this.backToIssuanceOrdersBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.backToIssuanceOrdersBtn.Name = "backToIssuanceOrdersBtn";
            this.backToIssuanceOrdersBtn.Size = new System.Drawing.Size(167, 46);
            this.backToIssuanceOrdersBtn.TabIndex = 23;
            this.backToIssuanceOrdersBtn.Text = "Back";
            this.backToIssuanceOrdersBtn.TextColor = System.Drawing.Color.Black;
            this.backToIssuanceOrdersBtn.UseVisualStyleBackColor = false;
            this.backToIssuanceOrdersBtn.Click += new System.EventHandler(this.BackToIssuanceOrdersBtn_Click);
            // 
            // editItemToIssuanceBtn
            // 
            this.editItemToIssuanceBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.editItemToIssuanceBtn.BackColor = System.Drawing.Color.LightSlateGray;
            this.editItemToIssuanceBtn.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.editItemToIssuanceBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.editItemToIssuanceBtn.BorderRadius = 7;
            this.editItemToIssuanceBtn.BorderSize = 0;
            this.editItemToIssuanceBtn.FlatAppearance.BorderSize = 0;
            this.editItemToIssuanceBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editItemToIssuanceBtn.Font = new System.Drawing.Font("Verdana Pro Cond", 13.8F, System.Drawing.FontStyle.Bold);
            this.editItemToIssuanceBtn.ForeColor = System.Drawing.Color.White;
            this.editItemToIssuanceBtn.Location = new System.Drawing.Point(1194, 451);
            this.editItemToIssuanceBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.editItemToIssuanceBtn.Name = "editItemToIssuanceBtn";
            this.editItemToIssuanceBtn.Size = new System.Drawing.Size(305, 109);
            this.editItemToIssuanceBtn.TabIndex = 17;
            this.editItemToIssuanceBtn.Text = "Edit Item";
            this.editItemToIssuanceBtn.TextColor = System.Drawing.Color.White;
            this.editItemToIssuanceBtn.UseVisualStyleBackColor = false;
            this.editItemToIssuanceBtn.Click += new System.EventHandler(this.EditIssuanceOrderButton_Click);
            // 
            // deleteItemToIssuanceBtn
            // 
            this.deleteItemToIssuanceBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deleteItemToIssuanceBtn.BackColor = System.Drawing.Color.Crimson;
            this.deleteItemToIssuanceBtn.BackgroundColor = System.Drawing.Color.Crimson;
            this.deleteItemToIssuanceBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.deleteItemToIssuanceBtn.BorderRadius = 7;
            this.deleteItemToIssuanceBtn.BorderSize = 0;
            this.deleteItemToIssuanceBtn.FlatAppearance.BorderSize = 0;
            this.deleteItemToIssuanceBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteItemToIssuanceBtn.Font = new System.Drawing.Font("Verdana Pro Cond", 13.8F, System.Drawing.FontStyle.Bold);
            this.deleteItemToIssuanceBtn.ForeColor = System.Drawing.Color.White;
            this.deleteItemToIssuanceBtn.Location = new System.Drawing.Point(1194, 622);
            this.deleteItemToIssuanceBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.deleteItemToIssuanceBtn.Name = "deleteItemToIssuanceBtn";
            this.deleteItemToIssuanceBtn.Size = new System.Drawing.Size(305, 109);
            this.deleteItemToIssuanceBtn.TabIndex = 16;
            this.deleteItemToIssuanceBtn.Text = "Delete Item";
            this.deleteItemToIssuanceBtn.TextColor = System.Drawing.Color.White;
            this.deleteItemToIssuanceBtn.UseVisualStyleBackColor = false;
            this.deleteItemToIssuanceBtn.Click += new System.EventHandler(this.DeleteIssuanceOrderButton_Click);
            // 
            // addItemToIssuanceBtn
            // 
            this.addItemToIssuanceBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addItemToIssuanceBtn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.addItemToIssuanceBtn.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.addItemToIssuanceBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.addItemToIssuanceBtn.BorderRadius = 7;
            this.addItemToIssuanceBtn.BorderSize = 0;
            this.addItemToIssuanceBtn.FlatAppearance.BorderSize = 0;
            this.addItemToIssuanceBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addItemToIssuanceBtn.Font = new System.Drawing.Font("Verdana Pro Cond", 13.8F, System.Drawing.FontStyle.Bold);
            this.addItemToIssuanceBtn.ForeColor = System.Drawing.Color.White;
            this.addItemToIssuanceBtn.Location = new System.Drawing.Point(1194, 288);
            this.addItemToIssuanceBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addItemToIssuanceBtn.Name = "addItemToIssuanceBtn";
            this.addItemToIssuanceBtn.Size = new System.Drawing.Size(305, 109);
            this.addItemToIssuanceBtn.TabIndex = 15;
            this.addItemToIssuanceBtn.Text = "Add Item";
            this.addItemToIssuanceBtn.TextColor = System.Drawing.Color.White;
            this.addItemToIssuanceBtn.UseVisualStyleBackColor = false;
            this.addItemToIssuanceBtn.Click += new System.EventHandler(this.AddItemToIssuanceBtn_Click);
            // 
            // BackToIssuanceItemBtn
            // 
            this.BackToIssuanceItemBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BackToIssuanceItemBtn.BackColor = System.Drawing.Color.LightSlateGray;
            this.BackToIssuanceItemBtn.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.BackToIssuanceItemBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BackToIssuanceItemBtn.BorderRadius = 7;
            this.BackToIssuanceItemBtn.BorderSize = 0;
            this.BackToIssuanceItemBtn.FlatAppearance.BorderSize = 0;
            this.BackToIssuanceItemBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackToIssuanceItemBtn.Font = new System.Drawing.Font("Verdana Pro Cond", 13.8F, System.Drawing.FontStyle.Bold);
            this.BackToIssuanceItemBtn.ForeColor = System.Drawing.Color.White;
            this.BackToIssuanceItemBtn.Location = new System.Drawing.Point(884, 661);
            this.BackToIssuanceItemBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BackToIssuanceItemBtn.Name = "BackToIssuanceItemBtn";
            this.BackToIssuanceItemBtn.Size = new System.Drawing.Size(222, 80);
            this.BackToIssuanceItemBtn.TabIndex = 6;
            this.BackToIssuanceItemBtn.Text = "Back";
            this.BackToIssuanceItemBtn.TextColor = System.Drawing.Color.White;
            this.BackToIssuanceItemBtn.UseVisualStyleBackColor = false;
            this.BackToIssuanceItemBtn.Click += new System.EventHandler(this.BackToIssuanceItemBtn_Click);
            // 
            // saveItemToIssuanceBtn
            // 
            this.saveItemToIssuanceBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.saveItemToIssuanceBtn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.saveItemToIssuanceBtn.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.saveItemToIssuanceBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.saveItemToIssuanceBtn.BorderRadius = 7;
            this.saveItemToIssuanceBtn.BorderSize = 0;
            this.saveItemToIssuanceBtn.FlatAppearance.BorderSize = 0;
            this.saveItemToIssuanceBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveItemToIssuanceBtn.Font = new System.Drawing.Font("Verdana Pro Cond", 13.8F, System.Drawing.FontStyle.Bold);
            this.saveItemToIssuanceBtn.ForeColor = System.Drawing.Color.White;
            this.saveItemToIssuanceBtn.Location = new System.Drawing.Point(1155, 661);
            this.saveItemToIssuanceBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.saveItemToIssuanceBtn.Name = "saveItemToIssuanceBtn";
            this.saveItemToIssuanceBtn.Size = new System.Drawing.Size(222, 80);
            this.saveItemToIssuanceBtn.TabIndex = 5;
            this.saveItemToIssuanceBtn.Text = "Save";
            this.saveItemToIssuanceBtn.TextColor = System.Drawing.Color.White;
            this.saveItemToIssuanceBtn.UseVisualStyleBackColor = false;
            this.saveItemToIssuanceBtn.Click += new System.EventHandler(this.SaveItemToSupllyItems);
            // 
            // IssuanceOrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1579, 878);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Verdana Pro", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IssuanceOrdersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IssuanceOrdersForm";
            this.Load += new System.EventHandler(this.IssuanceOrdersForm_Load);
            this.itemAddEditPage.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.itemsListPage.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IssuanceItemsDtaGridView)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.IssuanceOrdersAddEditPage.ResumeLayout(false);
            this.addWarehousPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.issuanceItemsDataGridView)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.IssuanceOrdersListPage.ResumeLayout(false);
            this.issuanceOrderMainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.issuanceOrderDataGrid)).EndInit();
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage itemAddEditPage;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.Label itemQuantityLbl;
        private CustamizedButton BackToIssuanceItemBtn;
        private CustamizedButton saveItemToIssuanceBtn;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.ComboBox itemNameComboBox;
        private System.Windows.Forms.Label itemNameLbl;
        private System.Windows.Forms.TabPage itemsListPage;
        private System.Windows.Forms.Panel panel7;
        private CustamizedButton backToIssuanceOrdersBtn;
        private System.Windows.Forms.ComboBox IssuanceOrderComboBox;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox searchIssuanceOrderItemTextBox;
        private System.Windows.Forms.Label label2;
        private RJCodeAdvance.RJControls.RJComboBox selectedItemCombobox;
        private CustamizedButton editItemToIssuanceBtn;
        private CustamizedButton deleteItemToIssuanceBtn;
        private CustamizedButton addItemToIssuanceBtn;
        private System.Windows.Forms.DataGridView IssuanceItemsDtaGridView;
        private System.Windows.Forms.TabPage IssuanceOrdersAddEditPage;
        private System.Windows.Forms.Panel addWarehousPanel;
        private CustamizedButton addItemInIssuancePageBtn;
        private System.Windows.Forms.Panel panel2;
        private RJCodeAdvance.RJControls.RJDatePicker orderDatePicker;
        private System.Windows.Forms.Label orderDateLbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox suppliersComboBox;
        private System.Windows.Forms.Label supplierNameLbl;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox warehousesComboBox;
        private System.Windows.Forms.Label warehouseNameLbl;
        private System.Windows.Forms.DataGridView issuanceItemsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private CustamizedButton backBtn;
        private CustamizedButton AddEditIssuanceOrderBtn;
        private System.Windows.Forms.TabPage IssuanceOrdersListPage;
        private System.Windows.Forms.Panel issuanceOrderMainPanel;
        private CustamizedButton viewItemsButton;
        private RJCodeAdvance.RJControls.RJComboBox allDataComboBox;
        private CustamizedButton editIssuanceOrderButton;
        private CustamizedButton deleteIssuanceOrderButton;
        private CustamizedButton AddIssuanceOrderButton;
        private System.Windows.Forms.Panel searchPanel;
        private System.Windows.Forms.TextBox dataSearchBar;
        private System.Windows.Forms.Label searchLbl;
        private System.Windows.Forms.DataGridView issuanceOrderDataGrid;
        private System.Windows.Forms.TabControl tabControl1;
    }
}