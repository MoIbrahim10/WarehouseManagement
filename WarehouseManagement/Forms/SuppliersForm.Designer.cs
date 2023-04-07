namespace WarehouseManagement.Forms
{
    partial class SuppliersForm
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
            this.SuppliersListPage = new System.Windows.Forms.TabPage();
            this.supplierMainPanel = new System.Windows.Forms.Panel();
            this.allDataComboBox = new RJCodeAdvance.RJControls.RJComboBox();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.dataSearchBar = new System.Windows.Forms.TextBox();
            this.searchLbl = new System.Windows.Forms.Label();
            this.supplierDataGrid = new System.Windows.Forms.DataGridView();
            this.SuppliersAddEditPage = new System.Windows.Forms.TabPage();
            this.addWarehousPanel = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtSupplierWebsite = new System.Windows.Forms.TextBox();
            this.SupplierWebsiteLabel = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtSupplierFax = new System.Windows.Forms.TextBox();
            this.SupplierFaxLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtSupplierMobile = new System.Windows.Forms.TextBox();
            this.SupplierMobileLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtSupplierPhone = new System.Windows.Forms.TextBox();
            this.SupplierPhoneLabel = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtSupplierEmail = new System.Windows.Forms.TextBox();
            this.SupplierEmailLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSupplierName = new System.Windows.Forms.TextBox();
            this.SupplierNameLabel = new System.Windows.Forms.Label();
            this.editSupplierButton = new WarehouseManagement.CustamizedButton();
            this.deleteSupplierButton = new WarehouseManagement.CustamizedButton();
            this.AddSupplierButton = new WarehouseManagement.CustamizedButton();
            this.backBtn = new WarehouseManagement.CustamizedButton();
            this.AddEditSupplierBtn = new WarehouseManagement.CustamizedButton();
            this.tabControl1.SuspendLayout();
            this.SuppliersListPage.SuspendLayout();
            this.supplierMainPanel.SuspendLayout();
            this.searchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplierDataGrid)).BeginInit();
            this.SuppliersAddEditPage.SuspendLayout();
            this.addWarehousPanel.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.CausesValidation = false;
            this.tabControl1.Controls.Add(this.SuppliersListPage);
            this.tabControl1.Controls.Add(this.SuppliersAddEditPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Verdana Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ItemSize = new System.Drawing.Size(180, 40);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(10, 5);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1579, 878);
            this.tabControl1.TabIndex = 21;
            // 
            // SuppliersListPage
            // 
            this.SuppliersListPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.SuppliersListPage.Controls.Add(this.supplierMainPanel);
            this.SuppliersListPage.Font = new System.Drawing.Font("Verdana Pro Cond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SuppliersListPage.Location = new System.Drawing.Point(4, 44);
            this.SuppliersListPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SuppliersListPage.Name = "SuppliersListPage";
            this.SuppliersListPage.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SuppliersListPage.Size = new System.Drawing.Size(1571, 830);
            this.SuppliersListPage.TabIndex = 0;
            this.SuppliersListPage.Text = "Suppliers List";
            // 
            // supplierMainPanel
            // 
            this.supplierMainPanel.Controls.Add(this.allDataComboBox);
            this.supplierMainPanel.Controls.Add(this.editSupplierButton);
            this.supplierMainPanel.Controls.Add(this.deleteSupplierButton);
            this.supplierMainPanel.Controls.Add(this.AddSupplierButton);
            this.supplierMainPanel.Controls.Add(this.searchPanel);
            this.supplierMainPanel.Controls.Add(this.supplierDataGrid);
            this.supplierMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.supplierMainPanel.Location = new System.Drawing.Point(4, 5);
            this.supplierMainPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.supplierMainPanel.Name = "supplierMainPanel";
            this.supplierMainPanel.Size = new System.Drawing.Size(1563, 820);
            this.supplierMainPanel.TabIndex = 6;
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
            // supplierDataGrid
            // 
            this.supplierDataGrid.AllowUserToAddRows = false;
            this.supplierDataGrid.AllowUserToDeleteRows = false;
            this.supplierDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.supplierDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.supplierDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.supplierDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.supplierDataGrid.Location = new System.Drawing.Point(121, 267);
            this.supplierDataGrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.supplierDataGrid.Name = "supplierDataGrid";
            this.supplierDataGrid.ReadOnly = true;
            this.supplierDataGrid.RowHeadersWidth = 51;
            this.supplierDataGrid.RowTemplate.Height = 24;
            this.supplierDataGrid.Size = new System.Drawing.Size(1011, 486);
            this.supplierDataGrid.TabIndex = 6;
            this.supplierDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SupplierDataGrid_CellClick);
            // 
            // SuppliersAddEditPage
            // 
            this.SuppliersAddEditPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.SuppliersAddEditPage.Controls.Add(this.addWarehousPanel);
            this.SuppliersAddEditPage.Location = new System.Drawing.Point(4, 44);
            this.SuppliersAddEditPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SuppliersAddEditPage.Name = "SuppliersAddEditPage";
            this.SuppliersAddEditPage.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SuppliersAddEditPage.Size = new System.Drawing.Size(1571, 830);
            this.SuppliersAddEditPage.TabIndex = 1;
            this.SuppliersAddEditPage.Text = "Add Supplier ";
            // 
            // addWarehousPanel
            // 
            this.addWarehousPanel.Controls.Add(this.panel5);
            this.addWarehousPanel.Controls.Add(this.panel6);
            this.addWarehousPanel.Controls.Add(this.panel2);
            this.addWarehousPanel.Controls.Add(this.panel3);
            this.addWarehousPanel.Controls.Add(this.panel4);
            this.addWarehousPanel.Controls.Add(this.backBtn);
            this.addWarehousPanel.Controls.Add(this.AddEditSupplierBtn);
            this.addWarehousPanel.Controls.Add(this.panel1);
            this.addWarehousPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addWarehousPanel.Location = new System.Drawing.Point(4, 5);
            this.addWarehousPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addWarehousPanel.Name = "addWarehousPanel";
            this.addWarehousPanel.Size = new System.Drawing.Size(1563, 820);
            this.addWarehousPanel.TabIndex = 23;
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel5.Controls.Add(this.txtSupplierWebsite);
            this.panel5.Controls.Add(this.SupplierWebsiteLabel);
            this.panel5.Location = new System.Drawing.Point(829, 481);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(613, 128);
            this.panel5.TabIndex = 5;
            // 
            // txtSupplierWebsite
            // 
            this.txtSupplierWebsite.Font = new System.Drawing.Font("Verdana Pro", 13.8F);
            this.txtSupplierWebsite.Location = new System.Drawing.Point(351, 45);
            this.txtSupplierWebsite.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSupplierWebsite.Name = "txtSupplierWebsite";
            this.txtSupplierWebsite.Size = new System.Drawing.Size(216, 35);
            this.txtSupplierWebsite.TabIndex = 2;
            // 
            // SupplierWebsiteLabel
            // 
            this.SupplierWebsiteLabel.AutoSize = true;
            this.SupplierWebsiteLabel.Font = new System.Drawing.Font("Verdana Pro Cond", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SupplierWebsiteLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(118)))), ((int)(((byte)(161)))));
            this.SupplierWebsiteLabel.Location = new System.Drawing.Point(46, 48);
            this.SupplierWebsiteLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SupplierWebsiteLabel.Name = "SupplierWebsiteLabel";
            this.SupplierWebsiteLabel.Size = new System.Drawing.Size(186, 28);
            this.SupplierWebsiteLabel.TabIndex = 1;
            this.SupplierWebsiteLabel.Text = "Supplier Website";
            // 
            // panel6
            // 
            this.panel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel6.Controls.Add(this.txtSupplierFax);
            this.panel6.Controls.Add(this.SupplierFaxLabel);
            this.panel6.Location = new System.Drawing.Point(72, 481);
            this.panel6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(618, 128);
            this.panel6.TabIndex = 4;
            // 
            // txtSupplierFax
            // 
            this.txtSupplierFax.Font = new System.Drawing.Font("Verdana Pro", 13.8F);
            this.txtSupplierFax.Location = new System.Drawing.Point(351, 45);
            this.txtSupplierFax.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSupplierFax.Name = "txtSupplierFax";
            this.txtSupplierFax.Size = new System.Drawing.Size(216, 35);
            this.txtSupplierFax.TabIndex = 2;
            // 
            // SupplierFaxLabel
            // 
            this.SupplierFaxLabel.AutoSize = true;
            this.SupplierFaxLabel.Font = new System.Drawing.Font("Verdana Pro Cond", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SupplierFaxLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(118)))), ((int)(((byte)(161)))));
            this.SupplierFaxLabel.Location = new System.Drawing.Point(46, 48);
            this.SupplierFaxLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SupplierFaxLabel.Name = "SupplierFaxLabel";
            this.SupplierFaxLabel.Size = new System.Drawing.Size(140, 28);
            this.SupplierFaxLabel.TabIndex = 1;
            this.SupplierFaxLabel.Text = "Supplier Fax";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.Controls.Add(this.txtSupplierMobile);
            this.panel2.Controls.Add(this.SupplierMobileLabel);
            this.panel2.Location = new System.Drawing.Point(829, 288);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(613, 132);
            this.panel2.TabIndex = 8;
            // 
            // txtSupplierMobile
            // 
            this.txtSupplierMobile.Font = new System.Drawing.Font("Verdana Pro", 13.8F);
            this.txtSupplierMobile.Location = new System.Drawing.Point(351, 45);
            this.txtSupplierMobile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSupplierMobile.Name = "txtSupplierMobile";
            this.txtSupplierMobile.Size = new System.Drawing.Size(216, 35);
            this.txtSupplierMobile.TabIndex = 2;
            // 
            // SupplierMobileLabel
            // 
            this.SupplierMobileLabel.AutoSize = true;
            this.SupplierMobileLabel.Font = new System.Drawing.Font("Verdana Pro Cond", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SupplierMobileLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(118)))), ((int)(((byte)(161)))));
            this.SupplierMobileLabel.Location = new System.Drawing.Point(46, 48);
            this.SupplierMobileLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SupplierMobileLabel.Name = "SupplierMobileLabel";
            this.SupplierMobileLabel.Size = new System.Drawing.Size(174, 28);
            this.SupplierMobileLabel.TabIndex = 1;
            this.SupplierMobileLabel.Text = "Supplier Mobile";
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.Controls.Add(this.txtSupplierPhone);
            this.panel3.Controls.Add(this.SupplierPhoneLabel);
            this.panel3.Location = new System.Drawing.Point(72, 288);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(618, 132);
            this.panel3.TabIndex = 7;
            // 
            // txtSupplierPhone
            // 
            this.txtSupplierPhone.Font = new System.Drawing.Font("Verdana Pro", 13.8F);
            this.txtSupplierPhone.Location = new System.Drawing.Point(351, 45);
            this.txtSupplierPhone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSupplierPhone.Name = "txtSupplierPhone";
            this.txtSupplierPhone.Size = new System.Drawing.Size(216, 35);
            this.txtSupplierPhone.TabIndex = 2;
            // 
            // SupplierPhoneLabel
            // 
            this.SupplierPhoneLabel.AutoSize = true;
            this.SupplierPhoneLabel.Font = new System.Drawing.Font("Verdana Pro Cond", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SupplierPhoneLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(118)))), ((int)(((byte)(161)))));
            this.SupplierPhoneLabel.Location = new System.Drawing.Point(46, 48);
            this.SupplierPhoneLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SupplierPhoneLabel.Name = "SupplierPhoneLabel";
            this.SupplierPhoneLabel.Size = new System.Drawing.Size(169, 28);
            this.SupplierPhoneLabel.TabIndex = 1;
            this.SupplierPhoneLabel.Text = "Supplier Phone";
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.Controls.Add(this.txtSupplierEmail);
            this.panel4.Controls.Add(this.SupplierEmailLabel);
            this.panel4.Location = new System.Drawing.Point(829, 95);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(613, 128);
            this.panel4.TabIndex = 3;
            // 
            // txtSupplierEmail
            // 
            this.txtSupplierEmail.Font = new System.Drawing.Font("Verdana Pro", 13.8F);
            this.txtSupplierEmail.Location = new System.Drawing.Point(351, 45);
            this.txtSupplierEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSupplierEmail.Name = "txtSupplierEmail";
            this.txtSupplierEmail.Size = new System.Drawing.Size(216, 35);
            this.txtSupplierEmail.TabIndex = 2;
            // 
            // SupplierEmailLabel
            // 
            this.SupplierEmailLabel.AutoSize = true;
            this.SupplierEmailLabel.Font = new System.Drawing.Font("Verdana Pro Cond", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SupplierEmailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(118)))), ((int)(((byte)(161)))));
            this.SupplierEmailLabel.Location = new System.Drawing.Point(46, 48);
            this.SupplierEmailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SupplierEmailLabel.Name = "SupplierEmailLabel";
            this.SupplierEmailLabel.Size = new System.Drawing.Size(162, 28);
            this.SupplierEmailLabel.TabIndex = 1;
            this.SupplierEmailLabel.Text = "Supplier Email";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.txtSupplierName);
            this.panel1.Controls.Add(this.SupplierNameLabel);
            this.panel1.Location = new System.Drawing.Point(72, 95);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(618, 128);
            this.panel1.TabIndex = 1;
            // 
            // txtSupplierName
            // 
            this.txtSupplierName.Font = new System.Drawing.Font("Verdana Pro", 13.8F);
            this.txtSupplierName.Location = new System.Drawing.Point(351, 45);
            this.txtSupplierName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSupplierName.Name = "txtSupplierName";
            this.txtSupplierName.Size = new System.Drawing.Size(216, 35);
            this.txtSupplierName.TabIndex = 2;
            // 
            // SupplierNameLabel
            // 
            this.SupplierNameLabel.AutoSize = true;
            this.SupplierNameLabel.Font = new System.Drawing.Font("Verdana Pro Cond", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SupplierNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(118)))), ((int)(((byte)(161)))));
            this.SupplierNameLabel.Location = new System.Drawing.Point(46, 48);
            this.SupplierNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SupplierNameLabel.Name = "SupplierNameLabel";
            this.SupplierNameLabel.Size = new System.Drawing.Size(164, 28);
            this.SupplierNameLabel.TabIndex = 1;
            this.SupplierNameLabel.Text = "Supplier Name";
            // 
            // editSupplierButton
            // 
            this.editSupplierButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.editSupplierButton.BackColor = System.Drawing.Color.LightSlateGray;
            this.editSupplierButton.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.editSupplierButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.editSupplierButton.BorderRadius = 7;
            this.editSupplierButton.BorderSize = 0;
            this.editSupplierButton.FlatAppearance.BorderSize = 0;
            this.editSupplierButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editSupplierButton.Font = new System.Drawing.Font("Verdana Pro Cond", 13.8F, System.Drawing.FontStyle.Bold);
            this.editSupplierButton.ForeColor = System.Drawing.Color.White;
            this.editSupplierButton.Location = new System.Drawing.Point(1190, 467);
            this.editSupplierButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.editSupplierButton.Name = "editSupplierButton";
            this.editSupplierButton.Size = new System.Drawing.Size(305, 109);
            this.editSupplierButton.TabIndex = 17;
            this.editSupplierButton.Text = "Edit Supplier";
            this.editSupplierButton.TextColor = System.Drawing.Color.White;
            this.editSupplierButton.UseVisualStyleBackColor = false;
            this.editSupplierButton.Click += new System.EventHandler(this.EditSupplierButton_Click);
            // 
            // deleteSupplierButton
            // 
            this.deleteSupplierButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deleteSupplierButton.BackColor = System.Drawing.Color.Crimson;
            this.deleteSupplierButton.BackgroundColor = System.Drawing.Color.Crimson;
            this.deleteSupplierButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.deleteSupplierButton.BorderRadius = 7;
            this.deleteSupplierButton.BorderSize = 0;
            this.deleteSupplierButton.FlatAppearance.BorderSize = 0;
            this.deleteSupplierButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteSupplierButton.Font = new System.Drawing.Font("Verdana Pro Cond", 13.8F, System.Drawing.FontStyle.Bold);
            this.deleteSupplierButton.ForeColor = System.Drawing.Color.White;
            this.deleteSupplierButton.Location = new System.Drawing.Point(1190, 626);
            this.deleteSupplierButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.deleteSupplierButton.Name = "deleteSupplierButton";
            this.deleteSupplierButton.Size = new System.Drawing.Size(305, 109);
            this.deleteSupplierButton.TabIndex = 16;
            this.deleteSupplierButton.Text = "Delete Supplier";
            this.deleteSupplierButton.TextColor = System.Drawing.Color.White;
            this.deleteSupplierButton.UseVisualStyleBackColor = false;
            this.deleteSupplierButton.Click += new System.EventHandler(this.DeleteSupplierButton_Click);
            // 
            // AddSupplierButton
            // 
            this.AddSupplierButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddSupplierButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.AddSupplierButton.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.AddSupplierButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.AddSupplierButton.BorderRadius = 7;
            this.AddSupplierButton.BorderSize = 0;
            this.AddSupplierButton.FlatAppearance.BorderSize = 0;
            this.AddSupplierButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddSupplierButton.Font = new System.Drawing.Font("Verdana Pro Cond", 13.8F, System.Drawing.FontStyle.Bold);
            this.AddSupplierButton.ForeColor = System.Drawing.Color.White;
            this.AddSupplierButton.Location = new System.Drawing.Point(1190, 308);
            this.AddSupplierButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddSupplierButton.Name = "AddSupplierButton";
            this.AddSupplierButton.Size = new System.Drawing.Size(305, 109);
            this.AddSupplierButton.TabIndex = 15;
            this.AddSupplierButton.Text = "Add Supplier";
            this.AddSupplierButton.TextColor = System.Drawing.Color.White;
            this.AddSupplierButton.UseVisualStyleBackColor = false;
            this.AddSupplierButton.Click += new System.EventHandler(this.AddSupplierButton_Click);
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
            // AddEditSupplierBtn
            // 
            this.AddEditSupplierBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddEditSupplierBtn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.AddEditSupplierBtn.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.AddEditSupplierBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.AddEditSupplierBtn.BorderRadius = 7;
            this.AddEditSupplierBtn.BorderSize = 0;
            this.AddEditSupplierBtn.FlatAppearance.BorderSize = 0;
            this.AddEditSupplierBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddEditSupplierBtn.Font = new System.Drawing.Font("Verdana Pro Cond", 13.8F, System.Drawing.FontStyle.Bold);
            this.AddEditSupplierBtn.ForeColor = System.Drawing.Color.White;
            this.AddEditSupplierBtn.Location = new System.Drawing.Point(1151, 656);
            this.AddEditSupplierBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddEditSupplierBtn.Name = "AddEditSupplierBtn";
            this.AddEditSupplierBtn.Size = new System.Drawing.Size(222, 80);
            this.AddEditSupplierBtn.TabIndex = 5;
            this.AddEditSupplierBtn.Text = "Save";
            this.AddEditSupplierBtn.TextColor = System.Drawing.Color.White;
            this.AddEditSupplierBtn.UseVisualStyleBackColor = false;
            this.AddEditSupplierBtn.Click += new System.EventHandler(this.AddEditSupplierBtn_Click);
            // 
            // SuppliersForm
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
            this.Name = "SuppliersForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SuppliersForm";
            this.tabControl1.ResumeLayout(false);
            this.SuppliersListPage.ResumeLayout(false);
            this.supplierMainPanel.ResumeLayout(false);
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplierDataGrid)).EndInit();
            this.SuppliersAddEditPage.ResumeLayout(false);
            this.addWarehousPanel.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage SuppliersListPage;
        private System.Windows.Forms.Panel supplierMainPanel;
        private RJCodeAdvance.RJControls.RJComboBox allDataComboBox;
        private CustamizedButton editSupplierButton;
        private CustamizedButton deleteSupplierButton;
        private CustamizedButton AddSupplierButton;
        private System.Windows.Forms.Panel searchPanel;
        private System.Windows.Forms.TextBox dataSearchBar;
        private System.Windows.Forms.Label searchLbl;
        private System.Windows.Forms.DataGridView supplierDataGrid;
        private System.Windows.Forms.TabPage SuppliersAddEditPage;
        private System.Windows.Forms.Panel addWarehousPanel;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtSupplierWebsite;
        private System.Windows.Forms.Label SupplierWebsiteLabel;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtSupplierFax;
        private System.Windows.Forms.Label SupplierFaxLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtSupplierMobile;
        private System.Windows.Forms.Label SupplierMobileLabel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtSupplierPhone;
        private System.Windows.Forms.Label SupplierPhoneLabel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtSupplierEmail;
        private System.Windows.Forms.Label SupplierEmailLabel;
        private CustamizedButton backBtn;
        private CustamizedButton AddEditSupplierBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSupplierName;
        private System.Windows.Forms.Label SupplierNameLabel;
    }
}