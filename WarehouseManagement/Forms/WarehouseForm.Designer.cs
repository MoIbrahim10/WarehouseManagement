namespace WarehouseManagement.Forms
{
    partial class WarehouseForm
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
            this.WarehousesListPage = new System.Windows.Forms.TabPage();
            this.warehouseMainPanel = new System.Windows.Forms.Panel();
            this.allDataComboBox = new RJCodeAdvance.RJControls.RJComboBox();
            this.editWarehouseButton = new WarehouseManagement.CustamizedButton();
            this.deleteWarehouseButton = new WarehouseManagement.CustamizedButton();
            this.AddWarehouseButton = new WarehouseManagement.CustamizedButton();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.dataSearchBar = new System.Windows.Forms.TextBox();
            this.searchLbl = new System.Windows.Forms.Label();
            this.warehouseDataGrid = new System.Windows.Forms.DataGridView();
            this.WarehousesAddEditPage = new System.Windows.Forms.TabPage();
            this.addWarehousPanel = new System.Windows.Forms.Panel();
            this.backBtn = new WarehouseManagement.CustamizedButton();
            this.AddEditWarehouseBtn = new WarehouseManagement.CustamizedButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboBoxWarehouseManager = new System.Windows.Forms.ComboBox();
            this.ManagerLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtWarehouseAddress = new System.Windows.Forms.TextBox();
            this.WarehouseAddressLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtWarehouseName = new System.Windows.Forms.TextBox();
            this.WarehouseNameLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.WarehousesListPage.SuspendLayout();
            this.warehouseMainPanel.SuspendLayout();
            this.searchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseDataGrid)).BeginInit();
            this.WarehousesAddEditPage.SuspendLayout();
            this.addWarehousPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.CausesValidation = false;
            this.tabControl1.Controls.Add(this.WarehousesListPage);
            this.tabControl1.Controls.Add(this.WarehousesAddEditPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Verdana Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ItemSize = new System.Drawing.Size(180, 40);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(10, 5);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1579, 878);
            this.tabControl1.TabIndex = 19;
            // 
            // WarehousesListPage
            // 
            this.WarehousesListPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.WarehousesListPage.Controls.Add(this.warehouseMainPanel);
            this.WarehousesListPage.Font = new System.Drawing.Font("Verdana Pro Cond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WarehousesListPage.Location = new System.Drawing.Point(4, 44);
            this.WarehousesListPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.WarehousesListPage.Name = "WarehousesListPage";
            this.WarehousesListPage.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.WarehousesListPage.Size = new System.Drawing.Size(1571, 830);
            this.WarehousesListPage.TabIndex = 0;
            this.WarehousesListPage.Text = "Warehouse List";
            // 
            // warehouseMainPanel
            // 
            this.warehouseMainPanel.Controls.Add(this.allDataComboBox);
            this.warehouseMainPanel.Controls.Add(this.editWarehouseButton);
            this.warehouseMainPanel.Controls.Add(this.deleteWarehouseButton);
            this.warehouseMainPanel.Controls.Add(this.AddWarehouseButton);
            this.warehouseMainPanel.Controls.Add(this.searchPanel);
            this.warehouseMainPanel.Controls.Add(this.warehouseDataGrid);
            this.warehouseMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.warehouseMainPanel.Location = new System.Drawing.Point(4, 5);
            this.warehouseMainPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.warehouseMainPanel.Name = "warehouseMainPanel";
            this.warehouseMainPanel.Size = new System.Drawing.Size(1563, 820);
            this.warehouseMainPanel.TabIndex = 6;
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
            // editWarehouseButton
            // 
            this.editWarehouseButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.editWarehouseButton.BackColor = System.Drawing.Color.LightSlateGray;
            this.editWarehouseButton.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.editWarehouseButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.editWarehouseButton.BorderRadius = 7;
            this.editWarehouseButton.BorderSize = 0;
            this.editWarehouseButton.FlatAppearance.BorderSize = 0;
            this.editWarehouseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editWarehouseButton.Font = new System.Drawing.Font("Verdana Pro Cond", 13.8F, System.Drawing.FontStyle.Bold);
            this.editWarehouseButton.ForeColor = System.Drawing.Color.White;
            this.editWarehouseButton.Location = new System.Drawing.Point(1190, 467);
            this.editWarehouseButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.editWarehouseButton.Name = "editWarehouseButton";
            this.editWarehouseButton.Size = new System.Drawing.Size(305, 109);
            this.editWarehouseButton.TabIndex = 17;
            this.editWarehouseButton.Text = "Edit Warehouse";
            this.editWarehouseButton.TextColor = System.Drawing.Color.White;
            this.editWarehouseButton.UseVisualStyleBackColor = false;
            this.editWarehouseButton.Click += new System.EventHandler(this.editWarehouseButton_Click);
            // 
            // deleteWarehouseButton
            // 
            this.deleteWarehouseButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deleteWarehouseButton.BackColor = System.Drawing.Color.Crimson;
            this.deleteWarehouseButton.BackgroundColor = System.Drawing.Color.Crimson;
            this.deleteWarehouseButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.deleteWarehouseButton.BorderRadius = 7;
            this.deleteWarehouseButton.BorderSize = 0;
            this.deleteWarehouseButton.FlatAppearance.BorderSize = 0;
            this.deleteWarehouseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteWarehouseButton.Font = new System.Drawing.Font("Verdana Pro Cond", 13.8F, System.Drawing.FontStyle.Bold);
            this.deleteWarehouseButton.ForeColor = System.Drawing.Color.White;
            this.deleteWarehouseButton.Location = new System.Drawing.Point(1190, 626);
            this.deleteWarehouseButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.deleteWarehouseButton.Name = "deleteWarehouseButton";
            this.deleteWarehouseButton.Size = new System.Drawing.Size(305, 109);
            this.deleteWarehouseButton.TabIndex = 16;
            this.deleteWarehouseButton.Text = "Delete Warehouse";
            this.deleteWarehouseButton.TextColor = System.Drawing.Color.White;
            this.deleteWarehouseButton.UseVisualStyleBackColor = false;
            this.deleteWarehouseButton.Click += new System.EventHandler(this.deleteWarehouseBtn_Click);
            // 
            // AddWarehouseButton
            // 
            this.AddWarehouseButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddWarehouseButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.AddWarehouseButton.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.AddWarehouseButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.AddWarehouseButton.BorderRadius = 7;
            this.AddWarehouseButton.BorderSize = 0;
            this.AddWarehouseButton.FlatAppearance.BorderSize = 0;
            this.AddWarehouseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddWarehouseButton.Font = new System.Drawing.Font("Verdana Pro Cond", 13.8F, System.Drawing.FontStyle.Bold);
            this.AddWarehouseButton.ForeColor = System.Drawing.Color.White;
            this.AddWarehouseButton.Location = new System.Drawing.Point(1190, 308);
            this.AddWarehouseButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddWarehouseButton.Name = "AddWarehouseButton";
            this.AddWarehouseButton.Size = new System.Drawing.Size(305, 109);
            this.AddWarehouseButton.TabIndex = 15;
            this.AddWarehouseButton.Text = "Add Warehouse";
            this.AddWarehouseButton.TextColor = System.Drawing.Color.White;
            this.AddWarehouseButton.UseVisualStyleBackColor = false;
            this.AddWarehouseButton.Click += new System.EventHandler(this.AddWarehouseButton_Click);
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
            this.dataSearchBar.TextChanged += new System.EventHandler(this.dataSearchBar_TextChanged);
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
            // warehouseDataGrid
            // 
            this.warehouseDataGrid.AllowUserToAddRows = false;
            this.warehouseDataGrid.AllowUserToDeleteRows = false;
            this.warehouseDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.warehouseDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.warehouseDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.warehouseDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.warehouseDataGrid.Location = new System.Drawing.Point(121, 267);
            this.warehouseDataGrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.warehouseDataGrid.Name = "warehouseDataGrid";
            this.warehouseDataGrid.ReadOnly = true;
            this.warehouseDataGrid.RowHeadersWidth = 51;
            this.warehouseDataGrid.RowTemplate.Height = 24;
            this.warehouseDataGrid.Size = new System.Drawing.Size(1011, 486);
            this.warehouseDataGrid.TabIndex = 6;
            this.warehouseDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.warehouseDataGrid_CellClick);
            // 
            // WarehousesAddEditPage
            // 
            this.WarehousesAddEditPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.WarehousesAddEditPage.Controls.Add(this.addWarehousPanel);
            this.WarehousesAddEditPage.Location = new System.Drawing.Point(4, 44);
            this.WarehousesAddEditPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.WarehousesAddEditPage.Name = "WarehousesAddEditPage";
            this.WarehousesAddEditPage.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.WarehousesAddEditPage.Size = new System.Drawing.Size(1571, 830);
            this.WarehousesAddEditPage.TabIndex = 1;
            this.WarehousesAddEditPage.Text = "Warehouse Add";
            // 
            // addWarehousPanel
            // 
            this.addWarehousPanel.Controls.Add(this.backBtn);
            this.addWarehousPanel.Controls.Add(this.AddEditWarehouseBtn);
            this.addWarehousPanel.Controls.Add(this.panel3);
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
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // AddEditWarehouseBtn
            // 
            this.AddEditWarehouseBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddEditWarehouseBtn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.AddEditWarehouseBtn.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.AddEditWarehouseBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.AddEditWarehouseBtn.BorderRadius = 7;
            this.AddEditWarehouseBtn.BorderSize = 0;
            this.AddEditWarehouseBtn.FlatAppearance.BorderSize = 0;
            this.AddEditWarehouseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddEditWarehouseBtn.Font = new System.Drawing.Font("Verdana Pro Cond", 13.8F, System.Drawing.FontStyle.Bold);
            this.AddEditWarehouseBtn.ForeColor = System.Drawing.Color.White;
            this.AddEditWarehouseBtn.Location = new System.Drawing.Point(1151, 656);
            this.AddEditWarehouseBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddEditWarehouseBtn.Name = "AddEditWarehouseBtn";
            this.AddEditWarehouseBtn.Size = new System.Drawing.Size(222, 80);
            this.AddEditWarehouseBtn.TabIndex = 5;
            this.AddEditWarehouseBtn.Text = "Save";
            this.AddEditWarehouseBtn.TextColor = System.Drawing.Color.White;
            this.AddEditWarehouseBtn.UseVisualStyleBackColor = false;
            this.AddEditWarehouseBtn.Click += new System.EventHandler(this.AddEditWarehouseBtn_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.Controls.Add(this.comboBoxWarehouseManager);
            this.panel3.Controls.Add(this.ManagerLabel);
            this.panel3.Location = new System.Drawing.Point(72, 485);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1370, 117);
            this.panel3.TabIndex = 3;
            // 
            // comboBoxWarehouseManager
            // 
            this.comboBoxWarehouseManager.Font = new System.Drawing.Font("Verdana Pro", 13.8F);
            this.comboBoxWarehouseManager.FormattingEnabled = true;
            this.comboBoxWarehouseManager.Location = new System.Drawing.Point(383, 44);
            this.comboBoxWarehouseManager.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxWarehouseManager.Name = "comboBoxWarehouseManager";
            this.comboBoxWarehouseManager.Size = new System.Drawing.Size(918, 36);
            this.comboBoxWarehouseManager.TabIndex = 2;
            // 
            // ManagerLabel
            // 
            this.ManagerLabel.AutoSize = true;
            this.ManagerLabel.Font = new System.Drawing.Font("Verdana Pro Cond", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManagerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(118)))), ((int)(((byte)(161)))));
            this.ManagerLabel.Location = new System.Drawing.Point(88, 47);
            this.ManagerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ManagerLabel.Name = "ManagerLabel";
            this.ManagerLabel.Size = new System.Drawing.Size(167, 28);
            this.ManagerLabel.TabIndex = 1;
            this.ManagerLabel.Text = "Manager Name";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.Controls.Add(this.txtWarehouseAddress);
            this.panel2.Controls.Add(this.WarehouseAddressLabel);
            this.panel2.Location = new System.Drawing.Point(72, 292);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1370, 117);
            this.panel2.TabIndex = 2;
            // 
            // txtWarehouseAddress
            // 
            this.txtWarehouseAddress.Font = new System.Drawing.Font("Verdana Pro", 13.8F);
            this.txtWarehouseAddress.Location = new System.Drawing.Point(383, 49);
            this.txtWarehouseAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtWarehouseAddress.Name = "txtWarehouseAddress";
            this.txtWarehouseAddress.Size = new System.Drawing.Size(918, 35);
            this.txtWarehouseAddress.TabIndex = 2;
            // 
            // WarehouseAddressLabel
            // 
            this.WarehouseAddressLabel.AutoSize = true;
            this.WarehouseAddressLabel.Font = new System.Drawing.Font("Verdana Pro Cond", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WarehouseAddressLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(118)))), ((int)(((byte)(161)))));
            this.WarehouseAddressLabel.Location = new System.Drawing.Point(88, 52);
            this.WarehouseAddressLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WarehouseAddressLabel.Name = "WarehouseAddressLabel";
            this.WarehouseAddressLabel.Size = new System.Drawing.Size(215, 28);
            this.WarehouseAddressLabel.TabIndex = 1;
            this.WarehouseAddressLabel.Text = "Warehouse Address";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.txtWarehouseName);
            this.panel1.Controls.Add(this.WarehouseNameLabel);
            this.panel1.Location = new System.Drawing.Point(72, 95);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1370, 117);
            this.panel1.TabIndex = 1;
            // 
            // txtWarehouseName
            // 
            this.txtWarehouseName.Font = new System.Drawing.Font("Verdana Pro", 13.8F);
            this.txtWarehouseName.Location = new System.Drawing.Point(383, 45);
            this.txtWarehouseName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtWarehouseName.Name = "txtWarehouseName";
            this.txtWarehouseName.Size = new System.Drawing.Size(918, 35);
            this.txtWarehouseName.TabIndex = 2;
            // 
            // WarehouseNameLabel
            // 
            this.WarehouseNameLabel.AutoSize = true;
            this.WarehouseNameLabel.Font = new System.Drawing.Font("Verdana Pro Cond", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WarehouseNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(118)))), ((int)(((byte)(161)))));
            this.WarehouseNameLabel.Location = new System.Drawing.Point(88, 48);
            this.WarehouseNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WarehouseNameLabel.Name = "WarehouseNameLabel";
            this.WarehouseNameLabel.Size = new System.Drawing.Size(191, 28);
            this.WarehouseNameLabel.TabIndex = 1;
            this.WarehouseNameLabel.Text = "Warehouse Name";
            // 
            // WarehouseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1579, 878);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Verdana Pro Cond", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WarehouseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "WarehouseForm";
            this.tabControl1.ResumeLayout(false);
            this.WarehousesListPage.ResumeLayout(false);
            this.warehouseMainPanel.ResumeLayout(false);
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseDataGrid)).EndInit();
            this.WarehousesAddEditPage.ResumeLayout(false);
            this.addWarehousPanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }



        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage WarehousesListPage;
        private System.Windows.Forms.Panel warehouseMainPanel;
        private CustamizedButton editWarehouseButton;
        private CustamizedButton deleteWarehouseButton;
        private CustamizedButton AddWarehouseButton;
        private System.Windows.Forms.Panel searchPanel;
        private System.Windows.Forms.Label searchLbl;
        private System.Windows.Forms.DataGridView warehouseDataGrid;
        private System.Windows.Forms.TabPage WarehousesAddEditPage;
        private System.Windows.Forms.Panel addWarehousPanel;
        private CustamizedButton backBtn;
        private CustamizedButton AddEditWarehouseBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox comboBoxWarehouseManager;
        private System.Windows.Forms.Label ManagerLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtWarehouseAddress;
        private System.Windows.Forms.Label WarehouseAddressLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtWarehouseName;
        private System.Windows.Forms.Label WarehouseNameLabel;
        private RJCodeAdvance.RJControls.RJComboBox allDataComboBox;
        private System.Windows.Forms.TextBox dataSearchBar;
    }
}