namespace WarehouseManagement.Forms
{
    partial class CustomersForm
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
            this.CustomersListPage = new System.Windows.Forms.TabPage();
            this.customerMainPanel = new System.Windows.Forms.Panel();
            this.allDataComboBox = new RJCodeAdvance.RJControls.RJComboBox();
            this.editCustomerButton = new WarehouseManagement.CustamizedButton();
            this.deleteCustomerButton = new WarehouseManagement.CustamizedButton();
            this.AddCustomerButton = new WarehouseManagement.CustamizedButton();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.dataSearchBar = new System.Windows.Forms.TextBox();
            this.searchLbl = new System.Windows.Forms.Label();
            this.customerDataGrid = new System.Windows.Forms.DataGridView();
            this.CustomersAddEditPage = new System.Windows.Forms.TabPage();
            this.addWarehousPanel = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtCustomerWebsite = new System.Windows.Forms.TextBox();
            this.CustomerWebsiteLabel = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtCustomerFax = new System.Windows.Forms.TextBox();
            this.CustomerFaxLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtCustomerMobile = new System.Windows.Forms.TextBox();
            this.CustomerMobileLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtCustomerPhone = new System.Windows.Forms.TextBox();
            this.CustomerPhoneLabel = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtCustomerEmail = new System.Windows.Forms.TextBox();
            this.CustomerEmailLabel = new System.Windows.Forms.Label();
            this.backBtn = new WarehouseManagement.CustamizedButton();
            this.AddEditCustomerBtn = new WarehouseManagement.CustamizedButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.CustomerNameLabel = new System.Windows.Forms.Label();
            this.customerWarehousePage = new System.Windows.Forms.TabPage();
            this.panel9 = new System.Windows.Forms.Panel();
            this.CustomerComboBox = new System.Windows.Forms.ComboBox();
            this.warehouseCustomerComboBox1 = new RJCodeAdvance.RJControls.RJComboBox();
            this.editCustomerWarehouseButton = new WarehouseManagement.CustamizedButton();
            this.deleteCustomerWarehouseButton = new WarehouseManagement.CustamizedButton();
            this.addCustomerWarehouseButton = new WarehouseManagement.CustamizedButton();
            this.panel10 = new System.Windows.Forms.Panel();
            this.searchCustomerWarehousetextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.customerWarehousesDataGridView = new System.Windows.Forms.DataGridView();
            this.customerWarehouseEditPage = new System.Windows.Forms.TabPage();
            this.panel14 = new System.Windows.Forms.Panel();
            this.custamizedButton4 = new WarehouseManagement.CustamizedButton();
            this.saveWarehouseToCustomerBtn = new WarehouseManagement.CustamizedButton();
            this.panel16 = new System.Windows.Forms.Panel();
            this.warehouseNameComboBox1 = new System.Windows.Forms.ComboBox();
            this.warehouseNameLbl = new System.Windows.Forms.Label();
            this.panel17 = new System.Windows.Forms.Panel();
            this.customerNameLbl = new System.Windows.Forms.Label();
            this.customerNameComboBox = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.CustomersListPage.SuspendLayout();
            this.customerMainPanel.SuspendLayout();
            this.searchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGrid)).BeginInit();
            this.CustomersAddEditPage.SuspendLayout();
            this.addWarehousPanel.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.customerWarehousePage.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerWarehousesDataGridView)).BeginInit();
            this.customerWarehouseEditPage.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel16.SuspendLayout();
            this.panel17.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.CausesValidation = false;
            this.tabControl1.Controls.Add(this.CustomersListPage);
            this.tabControl1.Controls.Add(this.CustomersAddEditPage);
            this.tabControl1.Controls.Add(this.customerWarehousePage);
            this.tabControl1.Controls.Add(this.customerWarehouseEditPage);
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
            // CustomersListPage
            // 
            this.CustomersListPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.CustomersListPage.Controls.Add(this.customerMainPanel);
            this.CustomersListPage.Font = new System.Drawing.Font("Verdana Pro Cond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomersListPage.Location = new System.Drawing.Point(4, 44);
            this.CustomersListPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CustomersListPage.Name = "CustomersListPage";
            this.CustomersListPage.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CustomersListPage.Size = new System.Drawing.Size(1571, 830);
            this.CustomersListPage.TabIndex = 0;
            this.CustomersListPage.Text = "Customers List";
            // 
            // customerMainPanel
            // 
            this.customerMainPanel.Controls.Add(this.allDataComboBox);
            this.customerMainPanel.Controls.Add(this.editCustomerButton);
            this.customerMainPanel.Controls.Add(this.deleteCustomerButton);
            this.customerMainPanel.Controls.Add(this.AddCustomerButton);
            this.customerMainPanel.Controls.Add(this.searchPanel);
            this.customerMainPanel.Controls.Add(this.customerDataGrid);
            this.customerMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customerMainPanel.Location = new System.Drawing.Point(4, 5);
            this.customerMainPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.customerMainPanel.Name = "customerMainPanel";
            this.customerMainPanel.Size = new System.Drawing.Size(1563, 820);
            this.customerMainPanel.TabIndex = 6;
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
            // editCustomerButton
            // 
            this.editCustomerButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.editCustomerButton.BackColor = System.Drawing.Color.LightSlateGray;
            this.editCustomerButton.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.editCustomerButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.editCustomerButton.BorderRadius = 7;
            this.editCustomerButton.BorderSize = 0;
            this.editCustomerButton.FlatAppearance.BorderSize = 0;
            this.editCustomerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editCustomerButton.Font = new System.Drawing.Font("Verdana Pro Cond", 13.8F, System.Drawing.FontStyle.Bold);
            this.editCustomerButton.ForeColor = System.Drawing.Color.White;
            this.editCustomerButton.Location = new System.Drawing.Point(1190, 467);
            this.editCustomerButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.editCustomerButton.Name = "editCustomerButton";
            this.editCustomerButton.Size = new System.Drawing.Size(305, 109);
            this.editCustomerButton.TabIndex = 17;
            this.editCustomerButton.Text = "Edit Customer";
            this.editCustomerButton.TextColor = System.Drawing.Color.White;
            this.editCustomerButton.UseVisualStyleBackColor = false;
            this.editCustomerButton.Click += new System.EventHandler(this.EditCustomerButton_Click);
            // 
            // deleteCustomerButton
            // 
            this.deleteCustomerButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deleteCustomerButton.BackColor = System.Drawing.Color.Crimson;
            this.deleteCustomerButton.BackgroundColor = System.Drawing.Color.Crimson;
            this.deleteCustomerButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.deleteCustomerButton.BorderRadius = 7;
            this.deleteCustomerButton.BorderSize = 0;
            this.deleteCustomerButton.FlatAppearance.BorderSize = 0;
            this.deleteCustomerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteCustomerButton.Font = new System.Drawing.Font("Verdana Pro Cond", 13.8F, System.Drawing.FontStyle.Bold);
            this.deleteCustomerButton.ForeColor = System.Drawing.Color.White;
            this.deleteCustomerButton.Location = new System.Drawing.Point(1190, 626);
            this.deleteCustomerButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.deleteCustomerButton.Name = "deleteCustomerButton";
            this.deleteCustomerButton.Size = new System.Drawing.Size(305, 109);
            this.deleteCustomerButton.TabIndex = 16;
            this.deleteCustomerButton.Text = "Delete Customer";
            this.deleteCustomerButton.TextColor = System.Drawing.Color.White;
            this.deleteCustomerButton.UseVisualStyleBackColor = false;
            this.deleteCustomerButton.Click += new System.EventHandler(this.DeleteCustomerButton_Click);
            // 
            // AddCustomerButton
            // 
            this.AddCustomerButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddCustomerButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.AddCustomerButton.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.AddCustomerButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.AddCustomerButton.BorderRadius = 7;
            this.AddCustomerButton.BorderSize = 0;
            this.AddCustomerButton.FlatAppearance.BorderSize = 0;
            this.AddCustomerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddCustomerButton.Font = new System.Drawing.Font("Verdana Pro Cond", 13.8F, System.Drawing.FontStyle.Bold);
            this.AddCustomerButton.ForeColor = System.Drawing.Color.White;
            this.AddCustomerButton.Location = new System.Drawing.Point(1190, 308);
            this.AddCustomerButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddCustomerButton.Name = "AddCustomerButton";
            this.AddCustomerButton.Size = new System.Drawing.Size(305, 109);
            this.AddCustomerButton.TabIndex = 15;
            this.AddCustomerButton.Text = "Add Customer";
            this.AddCustomerButton.TextColor = System.Drawing.Color.White;
            this.AddCustomerButton.UseVisualStyleBackColor = false;
            this.AddCustomerButton.Click += new System.EventHandler(this.AddCustomerButton_Click);
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
            // customerDataGrid
            // 
            this.customerDataGrid.AllowUserToAddRows = false;
            this.customerDataGrid.AllowUserToDeleteRows = false;
            this.customerDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.customerDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.customerDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.customerDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerDataGrid.Location = new System.Drawing.Point(121, 267);
            this.customerDataGrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.customerDataGrid.Name = "customerDataGrid";
            this.customerDataGrid.ReadOnly = true;
            this.customerDataGrid.RowHeadersWidth = 51;
            this.customerDataGrid.RowTemplate.Height = 24;
            this.customerDataGrid.Size = new System.Drawing.Size(1011, 486);
            this.customerDataGrid.TabIndex = 6;
            this.customerDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CustomerDataGrid_CellClick);
            // 
            // CustomersAddEditPage
            // 
            this.CustomersAddEditPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.CustomersAddEditPage.Controls.Add(this.addWarehousPanel);
            this.CustomersAddEditPage.Location = new System.Drawing.Point(4, 44);
            this.CustomersAddEditPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CustomersAddEditPage.Name = "CustomersAddEditPage";
            this.CustomersAddEditPage.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CustomersAddEditPage.Size = new System.Drawing.Size(1571, 830);
            this.CustomersAddEditPage.TabIndex = 1;
            this.CustomersAddEditPage.Text = "Customer Add";
            // 
            // addWarehousPanel
            // 
            this.addWarehousPanel.Controls.Add(this.panel5);
            this.addWarehousPanel.Controls.Add(this.panel6);
            this.addWarehousPanel.Controls.Add(this.panel2);
            this.addWarehousPanel.Controls.Add(this.panel3);
            this.addWarehousPanel.Controls.Add(this.panel4);
            this.addWarehousPanel.Controls.Add(this.backBtn);
            this.addWarehousPanel.Controls.Add(this.AddEditCustomerBtn);
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
            this.panel5.Controls.Add(this.txtCustomerWebsite);
            this.panel5.Controls.Add(this.CustomerWebsiteLabel);
            this.panel5.Location = new System.Drawing.Point(829, 481);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(613, 128);
            this.panel5.TabIndex = 5;
            // 
            // txtCustomerWebsite
            // 
            this.txtCustomerWebsite.Font = new System.Drawing.Font("Verdana Pro", 13.8F);
            this.txtCustomerWebsite.Location = new System.Drawing.Point(351, 45);
            this.txtCustomerWebsite.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCustomerWebsite.Name = "txtCustomerWebsite";
            this.txtCustomerWebsite.Size = new System.Drawing.Size(216, 35);
            this.txtCustomerWebsite.TabIndex = 2;
            // 
            // CustomerWebsiteLabel
            // 
            this.CustomerWebsiteLabel.AutoSize = true;
            this.CustomerWebsiteLabel.Font = new System.Drawing.Font("Verdana Pro Cond", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerWebsiteLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(118)))), ((int)(((byte)(161)))));
            this.CustomerWebsiteLabel.Location = new System.Drawing.Point(46, 48);
            this.CustomerWebsiteLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CustomerWebsiteLabel.Name = "CustomerWebsiteLabel";
            this.CustomerWebsiteLabel.Size = new System.Drawing.Size(198, 28);
            this.CustomerWebsiteLabel.TabIndex = 1;
            this.CustomerWebsiteLabel.Text = "Customer Website";
            // 
            // panel6
            // 
            this.panel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel6.Controls.Add(this.txtCustomerFax);
            this.panel6.Controls.Add(this.CustomerFaxLabel);
            this.panel6.Location = new System.Drawing.Point(72, 481);
            this.panel6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(618, 128);
            this.panel6.TabIndex = 4;
            // 
            // txtCustomerFax
            // 
            this.txtCustomerFax.Font = new System.Drawing.Font("Verdana Pro", 13.8F);
            this.txtCustomerFax.Location = new System.Drawing.Point(351, 45);
            this.txtCustomerFax.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCustomerFax.Name = "txtCustomerFax";
            this.txtCustomerFax.Size = new System.Drawing.Size(216, 35);
            this.txtCustomerFax.TabIndex = 2;
            // 
            // CustomerFaxLabel
            // 
            this.CustomerFaxLabel.AutoSize = true;
            this.CustomerFaxLabel.Font = new System.Drawing.Font("Verdana Pro Cond", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerFaxLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(118)))), ((int)(((byte)(161)))));
            this.CustomerFaxLabel.Location = new System.Drawing.Point(46, 48);
            this.CustomerFaxLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CustomerFaxLabel.Name = "CustomerFaxLabel";
            this.CustomerFaxLabel.Size = new System.Drawing.Size(152, 28);
            this.CustomerFaxLabel.TabIndex = 1;
            this.CustomerFaxLabel.Text = "Customer Fax";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.Controls.Add(this.txtCustomerMobile);
            this.panel2.Controls.Add(this.CustomerMobileLabel);
            this.panel2.Location = new System.Drawing.Point(829, 288);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(613, 132);
            this.panel2.TabIndex = 8;
            // 
            // txtCustomerMobile
            // 
            this.txtCustomerMobile.Font = new System.Drawing.Font("Verdana Pro", 13.8F);
            this.txtCustomerMobile.Location = new System.Drawing.Point(351, 45);
            this.txtCustomerMobile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCustomerMobile.Name = "txtCustomerMobile";
            this.txtCustomerMobile.Size = new System.Drawing.Size(216, 35);
            this.txtCustomerMobile.TabIndex = 2;
            // 
            // CustomerMobileLabel
            // 
            this.CustomerMobileLabel.AutoSize = true;
            this.CustomerMobileLabel.Font = new System.Drawing.Font("Verdana Pro Cond", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerMobileLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(118)))), ((int)(((byte)(161)))));
            this.CustomerMobileLabel.Location = new System.Drawing.Point(46, 48);
            this.CustomerMobileLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CustomerMobileLabel.Name = "CustomerMobileLabel";
            this.CustomerMobileLabel.Size = new System.Drawing.Size(186, 28);
            this.CustomerMobileLabel.TabIndex = 1;
            this.CustomerMobileLabel.Text = "Customer Mobile";
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.Controls.Add(this.txtCustomerPhone);
            this.panel3.Controls.Add(this.CustomerPhoneLabel);
            this.panel3.Location = new System.Drawing.Point(72, 288);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(618, 132);
            this.panel3.TabIndex = 7;
            // 
            // txtCustomerPhone
            // 
            this.txtCustomerPhone.Font = new System.Drawing.Font("Verdana Pro", 13.8F);
            this.txtCustomerPhone.Location = new System.Drawing.Point(351, 45);
            this.txtCustomerPhone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCustomerPhone.Name = "txtCustomerPhone";
            this.txtCustomerPhone.Size = new System.Drawing.Size(216, 35);
            this.txtCustomerPhone.TabIndex = 2;
            // 
            // CustomerPhoneLabel
            // 
            this.CustomerPhoneLabel.AutoSize = true;
            this.CustomerPhoneLabel.Font = new System.Drawing.Font("Verdana Pro Cond", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerPhoneLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(118)))), ((int)(((byte)(161)))));
            this.CustomerPhoneLabel.Location = new System.Drawing.Point(46, 48);
            this.CustomerPhoneLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CustomerPhoneLabel.Name = "CustomerPhoneLabel";
            this.CustomerPhoneLabel.Size = new System.Drawing.Size(181, 28);
            this.CustomerPhoneLabel.TabIndex = 1;
            this.CustomerPhoneLabel.Text = "Customer Phone";
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.Controls.Add(this.txtCustomerEmail);
            this.panel4.Controls.Add(this.CustomerEmailLabel);
            this.panel4.Location = new System.Drawing.Point(829, 95);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(613, 128);
            this.panel4.TabIndex = 3;
            // 
            // txtCustomerEmail
            // 
            this.txtCustomerEmail.Font = new System.Drawing.Font("Verdana Pro", 13.8F);
            this.txtCustomerEmail.Location = new System.Drawing.Point(351, 45);
            this.txtCustomerEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCustomerEmail.Name = "txtCustomerEmail";
            this.txtCustomerEmail.Size = new System.Drawing.Size(216, 35);
            this.txtCustomerEmail.TabIndex = 2;
            // 
            // CustomerEmailLabel
            // 
            this.CustomerEmailLabel.AutoSize = true;
            this.CustomerEmailLabel.Font = new System.Drawing.Font("Verdana Pro Cond", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerEmailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(118)))), ((int)(((byte)(161)))));
            this.CustomerEmailLabel.Location = new System.Drawing.Point(46, 48);
            this.CustomerEmailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CustomerEmailLabel.Name = "CustomerEmailLabel";
            this.CustomerEmailLabel.Size = new System.Drawing.Size(174, 28);
            this.CustomerEmailLabel.TabIndex = 1;
            this.CustomerEmailLabel.Text = "Customer Email";
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
            // AddEditCustomerBtn
            // 
            this.AddEditCustomerBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddEditCustomerBtn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.AddEditCustomerBtn.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.AddEditCustomerBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.AddEditCustomerBtn.BorderRadius = 7;
            this.AddEditCustomerBtn.BorderSize = 0;
            this.AddEditCustomerBtn.FlatAppearance.BorderSize = 0;
            this.AddEditCustomerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddEditCustomerBtn.Font = new System.Drawing.Font("Verdana Pro Cond", 13.8F, System.Drawing.FontStyle.Bold);
            this.AddEditCustomerBtn.ForeColor = System.Drawing.Color.White;
            this.AddEditCustomerBtn.Location = new System.Drawing.Point(1151, 656);
            this.AddEditCustomerBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddEditCustomerBtn.Name = "AddEditCustomerBtn";
            this.AddEditCustomerBtn.Size = new System.Drawing.Size(222, 80);
            this.AddEditCustomerBtn.TabIndex = 5;
            this.AddEditCustomerBtn.Text = "Save";
            this.AddEditCustomerBtn.TextColor = System.Drawing.Color.White;
            this.AddEditCustomerBtn.UseVisualStyleBackColor = false;
            this.AddEditCustomerBtn.Click += new System.EventHandler(this.AddEditCustomerBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.txtCustomerName);
            this.panel1.Controls.Add(this.CustomerNameLabel);
            this.panel1.Location = new System.Drawing.Point(72, 95);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(618, 128);
            this.panel1.TabIndex = 1;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Font = new System.Drawing.Font("Verdana Pro", 13.8F);
            this.txtCustomerName.Location = new System.Drawing.Point(351, 45);
            this.txtCustomerName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(216, 35);
            this.txtCustomerName.TabIndex = 2;
            // 
            // CustomerNameLabel
            // 
            this.CustomerNameLabel.AutoSize = true;
            this.CustomerNameLabel.Font = new System.Drawing.Font("Verdana Pro Cond", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(118)))), ((int)(((byte)(161)))));
            this.CustomerNameLabel.Location = new System.Drawing.Point(46, 48);
            this.CustomerNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CustomerNameLabel.Name = "CustomerNameLabel";
            this.CustomerNameLabel.Size = new System.Drawing.Size(176, 28);
            this.CustomerNameLabel.TabIndex = 1;
            this.CustomerNameLabel.Text = "Customer Name";
            // 
            // customerWarehousePage
            // 
            this.customerWarehousePage.Controls.Add(this.panel9);
            this.customerWarehousePage.Location = new System.Drawing.Point(4, 44);
            this.customerWarehousePage.Name = "customerWarehousePage";
            this.customerWarehousePage.Size = new System.Drawing.Size(1571, 830);
            this.customerWarehousePage.TabIndex = 2;
            this.customerWarehousePage.Text = "Customer Warehouse List";
            this.customerWarehousePage.UseVisualStyleBackColor = true;
            this.customerWarehousePage.Enter += new System.EventHandler(this.CustomerWarehousePage_Enter);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.panel9.Controls.Add(this.CustomerComboBox);
            this.panel9.Controls.Add(this.warehouseCustomerComboBox1);
            this.panel9.Controls.Add(this.editCustomerWarehouseButton);
            this.panel9.Controls.Add(this.deleteCustomerWarehouseButton);
            this.panel9.Controls.Add(this.addCustomerWarehouseButton);
            this.panel9.Controls.Add(this.panel10);
            this.panel9.Controls.Add(this.customerWarehousesDataGridView);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Font = new System.Drawing.Font("Verdana Pro Cond", 13.8F);
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1571, 830);
            this.panel9.TabIndex = 9;
            // 
            // CustomerComboBox
            // 
            this.CustomerComboBox.Font = new System.Drawing.Font("Verdana Pro Cond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerComboBox.FormattingEnabled = true;
            this.CustomerComboBox.Location = new System.Drawing.Point(125, 119);
            this.CustomerComboBox.Name = "CustomerComboBox";
            this.CustomerComboBox.Size = new System.Drawing.Size(324, 36);
            this.CustomerComboBox.TabIndex = 20;
            this.CustomerComboBox.SelectedIndexChanged += new System.EventHandler(this.CustomerComboBox_SelectedIndexChanged);
            // 
            // warehouseCustomerComboBox1
            // 
            this.warehouseCustomerComboBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.warehouseCustomerComboBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.warehouseCustomerComboBox1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.warehouseCustomerComboBox1.BorderSize = 1;
            this.warehouseCustomerComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.warehouseCustomerComboBox1.Font = new System.Drawing.Font("Verdana Pro", 13.8F);
            this.warehouseCustomerComboBox1.ForeColor = System.Drawing.Color.DimGray;
            this.warehouseCustomerComboBox1.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.warehouseCustomerComboBox1.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.warehouseCustomerComboBox1.ListTextColor = System.Drawing.Color.DimGray;
            this.warehouseCustomerComboBox1.Location = new System.Drawing.Point(1175, 111);
            this.warehouseCustomerComboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.warehouseCustomerComboBox1.MinimumSize = new System.Drawing.Size(250, 47);
            this.warehouseCustomerComboBox1.Name = "warehouseCustomerComboBox1";
            this.warehouseCustomerComboBox1.Padding = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.warehouseCustomerComboBox1.Size = new System.Drawing.Size(324, 47);
            this.warehouseCustomerComboBox1.TabIndex = 18;
            this.warehouseCustomerComboBox1.Texts = "";
            // 
            // editCustomerWarehouseButton
            // 
            this.editCustomerWarehouseButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.editCustomerWarehouseButton.BackColor = System.Drawing.Color.LightSlateGray;
            this.editCustomerWarehouseButton.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.editCustomerWarehouseButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.editCustomerWarehouseButton.BorderRadius = 7;
            this.editCustomerWarehouseButton.BorderSize = 0;
            this.editCustomerWarehouseButton.FlatAppearance.BorderSize = 0;
            this.editCustomerWarehouseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editCustomerWarehouseButton.Font = new System.Drawing.Font("Verdana Pro Cond", 13.8F, System.Drawing.FontStyle.Bold);
            this.editCustomerWarehouseButton.ForeColor = System.Drawing.Color.White;
            this.editCustomerWarehouseButton.Location = new System.Drawing.Point(1194, 472);
            this.editCustomerWarehouseButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.editCustomerWarehouseButton.Name = "editCustomerWarehouseButton";
            this.editCustomerWarehouseButton.Size = new System.Drawing.Size(305, 109);
            this.editCustomerWarehouseButton.TabIndex = 17;
            this.editCustomerWarehouseButton.Text = "Edit Warehouse";
            this.editCustomerWarehouseButton.TextColor = System.Drawing.Color.White;
            this.editCustomerWarehouseButton.UseVisualStyleBackColor = false;
            this.editCustomerWarehouseButton.Click += new System.EventHandler(this.EditCustomerWarehouseButton_Click);
            // 
            // deleteCustomerWarehouseButton
            // 
            this.deleteCustomerWarehouseButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deleteCustomerWarehouseButton.BackColor = System.Drawing.Color.Crimson;
            this.deleteCustomerWarehouseButton.BackgroundColor = System.Drawing.Color.Crimson;
            this.deleteCustomerWarehouseButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.deleteCustomerWarehouseButton.BorderRadius = 7;
            this.deleteCustomerWarehouseButton.BorderSize = 0;
            this.deleteCustomerWarehouseButton.FlatAppearance.BorderSize = 0;
            this.deleteCustomerWarehouseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteCustomerWarehouseButton.Font = new System.Drawing.Font("Verdana Pro Cond", 13.8F, System.Drawing.FontStyle.Bold);
            this.deleteCustomerWarehouseButton.ForeColor = System.Drawing.Color.White;
            this.deleteCustomerWarehouseButton.Location = new System.Drawing.Point(1194, 631);
            this.deleteCustomerWarehouseButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.deleteCustomerWarehouseButton.Name = "deleteCustomerWarehouseButton";
            this.deleteCustomerWarehouseButton.Size = new System.Drawing.Size(305, 109);
            this.deleteCustomerWarehouseButton.TabIndex = 16;
            this.deleteCustomerWarehouseButton.Text = "Delete Warehouse";
            this.deleteCustomerWarehouseButton.TextColor = System.Drawing.Color.White;
            this.deleteCustomerWarehouseButton.UseVisualStyleBackColor = false;
            this.deleteCustomerWarehouseButton.Click += new System.EventHandler(this.DeleteCustomerWarehouseButton_Click);
            // 
            // addCustomerWarehouseButton
            // 
            this.addCustomerWarehouseButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addCustomerWarehouseButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.addCustomerWarehouseButton.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.addCustomerWarehouseButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.addCustomerWarehouseButton.BorderRadius = 7;
            this.addCustomerWarehouseButton.BorderSize = 0;
            this.addCustomerWarehouseButton.FlatAppearance.BorderSize = 0;
            this.addCustomerWarehouseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCustomerWarehouseButton.Font = new System.Drawing.Font("Verdana Pro Cond", 13.8F, System.Drawing.FontStyle.Bold);
            this.addCustomerWarehouseButton.ForeColor = System.Drawing.Color.White;
            this.addCustomerWarehouseButton.Location = new System.Drawing.Point(1194, 313);
            this.addCustomerWarehouseButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addCustomerWarehouseButton.Name = "addCustomerWarehouseButton";
            this.addCustomerWarehouseButton.Size = new System.Drawing.Size(305, 109);
            this.addCustomerWarehouseButton.TabIndex = 15;
            this.addCustomerWarehouseButton.Text = "Add Warehouse";
            this.addCustomerWarehouseButton.TextColor = System.Drawing.Color.White;
            this.addCustomerWarehouseButton.UseVisualStyleBackColor = false;
            this.addCustomerWarehouseButton.Click += new System.EventHandler(this.AddCustomerWarehouseButton_Click);
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.searchCustomerWarehousetextBox);
            this.panel10.Controls.Add(this.label2);
            this.panel10.Location = new System.Drawing.Point(523, 63);
            this.panel10.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(613, 156);
            this.panel10.TabIndex = 14;
            // 
            // searchCustomerWarehousetextBox
            // 
            this.searchCustomerWarehousetextBox.Font = new System.Drawing.Font("Verdana Pro", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchCustomerWarehousetextBox.Location = new System.Drawing.Point(224, 52);
            this.searchCustomerWarehousetextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchCustomerWarehousetextBox.Name = "searchCustomerWarehousetextBox";
            this.searchCustomerWarehousetextBox.Size = new System.Drawing.Size(288, 35);
            this.searchCustomerWarehousetextBox.TabIndex = 20;
            this.searchCustomerWarehousetextBox.TextChanged += new System.EventHandler(this.SearchCustomerWarehousetextBox_TextChanged);
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
            // customerWarehousesDataGridView
            // 
            this.customerWarehousesDataGridView.AllowUserToAddRows = false;
            this.customerWarehousesDataGridView.AllowUserToDeleteRows = false;
            this.customerWarehousesDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.customerWarehousesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.customerWarehousesDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.customerWarehousesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerWarehousesDataGridView.Location = new System.Drawing.Point(125, 267);
            this.customerWarehousesDataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.customerWarehousesDataGridView.Name = "customerWarehousesDataGridView";
            this.customerWarehousesDataGridView.ReadOnly = true;
            this.customerWarehousesDataGridView.RowHeadersWidth = 51;
            this.customerWarehousesDataGridView.RowTemplate.Height = 24;
            this.customerWarehousesDataGridView.Size = new System.Drawing.Size(1011, 496);
            this.customerWarehousesDataGridView.TabIndex = 6;
            this.customerWarehousesDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CustomerWarehousesDataGrid_CellClick);
            // 
            // customerWarehouseEditPage
            // 
            this.customerWarehouseEditPage.Controls.Add(this.panel14);
            this.customerWarehouseEditPage.Location = new System.Drawing.Point(4, 44);
            this.customerWarehouseEditPage.Name = "customerWarehouseEditPage";
            this.customerWarehouseEditPage.Size = new System.Drawing.Size(1571, 830);
            this.customerWarehouseEditPage.TabIndex = 3;
            this.customerWarehouseEditPage.Text = "Customer Warehouse Add";
            this.customerWarehouseEditPage.UseVisualStyleBackColor = true;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.panel14.Controls.Add(this.custamizedButton4);
            this.panel14.Controls.Add(this.saveWarehouseToCustomerBtn);
            this.panel14.Controls.Add(this.panel16);
            this.panel14.Controls.Add(this.panel17);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel14.Location = new System.Drawing.Point(0, 0);
            this.panel14.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(1571, 830);
            this.panel14.TabIndex = 26;
            // 
            // custamizedButton4
            // 
            this.custamizedButton4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.custamizedButton4.BackColor = System.Drawing.Color.LightSlateGray;
            this.custamizedButton4.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.custamizedButton4.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.custamizedButton4.BorderRadius = 7;
            this.custamizedButton4.BorderSize = 0;
            this.custamizedButton4.FlatAppearance.BorderSize = 0;
            this.custamizedButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.custamizedButton4.Font = new System.Drawing.Font("Verdana Pro Cond", 13.8F, System.Drawing.FontStyle.Bold);
            this.custamizedButton4.ForeColor = System.Drawing.Color.White;
            this.custamizedButton4.Location = new System.Drawing.Point(875, 661);
            this.custamizedButton4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.custamizedButton4.Name = "custamizedButton4";
            this.custamizedButton4.Size = new System.Drawing.Size(222, 80);
            this.custamizedButton4.TabIndex = 7;
            this.custamizedButton4.Text = "Back";
            this.custamizedButton4.TextColor = System.Drawing.Color.White;
            this.custamizedButton4.UseVisualStyleBackColor = false;
            this.custamizedButton4.Click += new System.EventHandler(this.BackToCustomerWarehouseBtn_Click);
            // 
            // saveWarehouseToCustomerBtn
            // 
            this.saveWarehouseToCustomerBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.saveWarehouseToCustomerBtn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.saveWarehouseToCustomerBtn.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.saveWarehouseToCustomerBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.saveWarehouseToCustomerBtn.BorderRadius = 7;
            this.saveWarehouseToCustomerBtn.BorderSize = 0;
            this.saveWarehouseToCustomerBtn.FlatAppearance.BorderSize = 0;
            this.saveWarehouseToCustomerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveWarehouseToCustomerBtn.Font = new System.Drawing.Font("Verdana Pro Cond", 13.8F, System.Drawing.FontStyle.Bold);
            this.saveWarehouseToCustomerBtn.ForeColor = System.Drawing.Color.White;
            this.saveWarehouseToCustomerBtn.Location = new System.Drawing.Point(1155, 661);
            this.saveWarehouseToCustomerBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.saveWarehouseToCustomerBtn.Name = "saveWarehouseToCustomerBtn";
            this.saveWarehouseToCustomerBtn.Size = new System.Drawing.Size(222, 80);
            this.saveWarehouseToCustomerBtn.TabIndex = 5;
            this.saveWarehouseToCustomerBtn.Text = "Save";
            this.saveWarehouseToCustomerBtn.TextColor = System.Drawing.Color.White;
            this.saveWarehouseToCustomerBtn.UseVisualStyleBackColor = false;
            this.saveWarehouseToCustomerBtn.Click += new System.EventHandler(this.SaveItemToSupllierWarehouses);
            // 
            // panel16
            // 
            this.panel16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel16.Controls.Add(this.warehouseNameComboBox1);
            this.panel16.Controls.Add(this.warehouseNameLbl);
            this.panel16.Location = new System.Drawing.Point(88, 420);
            this.panel16.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(1370, 117);
            this.panel16.TabIndex = 2;
            // 
            // warehouseNameComboBox1
            // 
            this.warehouseNameComboBox1.Font = new System.Drawing.Font("Verdana Pro Cond", 13.8F);
            this.warehouseNameComboBox1.FormattingEnabled = true;
            this.warehouseNameComboBox1.Location = new System.Drawing.Point(383, 41);
            this.warehouseNameComboBox1.Name = "warehouseNameComboBox1";
            this.warehouseNameComboBox1.Size = new System.Drawing.Size(918, 36);
            this.warehouseNameComboBox1.TabIndex = 8;
            // 
            // warehouseNameLbl
            // 
            this.warehouseNameLbl.AutoSize = true;
            this.warehouseNameLbl.Font = new System.Drawing.Font("Verdana Pro Cond", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warehouseNameLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(118)))), ((int)(((byte)(161)))));
            this.warehouseNameLbl.Location = new System.Drawing.Point(88, 49);
            this.warehouseNameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.warehouseNameLbl.Name = "warehouseNameLbl";
            this.warehouseNameLbl.Size = new System.Drawing.Size(191, 28);
            this.warehouseNameLbl.TabIndex = 1;
            this.warehouseNameLbl.Text = "Warehouse Name";
            // 
            // panel17
            // 
            this.panel17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel17.Controls.Add(this.customerNameLbl);
            this.panel17.Controls.Add(this.customerNameComboBox);
            this.panel17.Location = new System.Drawing.Point(88, 223);
            this.panel17.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(1370, 117);
            this.panel17.TabIndex = 1;
            // 
            // customerNameLbl
            // 
            this.customerNameLbl.AutoSize = true;
            this.customerNameLbl.Font = new System.Drawing.Font("Verdana Pro Cond", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNameLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(118)))), ((int)(((byte)(161)))));
            this.customerNameLbl.Location = new System.Drawing.Point(88, 48);
            this.customerNameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.customerNameLbl.Name = "customerNameLbl";
            this.customerNameLbl.Size = new System.Drawing.Size(176, 28);
            this.customerNameLbl.TabIndex = 1;
            this.customerNameLbl.Text = "Customer Name";
            // 
            // customerNameComboBox
            // 
            this.customerNameComboBox.Font = new System.Drawing.Font("Verdana Pro Cond", 13.8F);
            this.customerNameComboBox.FormattingEnabled = true;
            this.customerNameComboBox.Location = new System.Drawing.Point(383, 45);
            this.customerNameComboBox.Name = "customerNameComboBox";
            this.customerNameComboBox.Size = new System.Drawing.Size(918, 36);
            this.customerNameComboBox.TabIndex = 9;
            // 
            // CustomersForm
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
            this.Name = "CustomersForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CustomersForm";
            this.tabControl1.ResumeLayout(false);
            this.CustomersListPage.ResumeLayout(false);
            this.customerMainPanel.ResumeLayout(false);
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGrid)).EndInit();
            this.CustomersAddEditPage.ResumeLayout(false);
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
            this.customerWarehousePage.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerWarehousesDataGridView)).EndInit();
            this.customerWarehouseEditPage.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.panel16.ResumeLayout(false);
            this.panel16.PerformLayout();
            this.panel17.ResumeLayout(false);
            this.panel17.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage CustomersListPage;
        private System.Windows.Forms.Panel customerMainPanel;
        private RJCodeAdvance.RJControls.RJComboBox allDataComboBox;
        private CustamizedButton editCustomerButton;
        private CustamizedButton deleteCustomerButton;
        private CustamizedButton AddCustomerButton;
        private System.Windows.Forms.Panel searchPanel;
        private System.Windows.Forms.TextBox dataSearchBar;
        private System.Windows.Forms.Label searchLbl;
        private System.Windows.Forms.DataGridView customerDataGrid;
        private System.Windows.Forms.TabPage CustomersAddEditPage;
        private System.Windows.Forms.Panel addWarehousPanel;
        private CustamizedButton backBtn;
        private CustamizedButton AddEditCustomerBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label CustomerNameLabel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtCustomerEmail;
        private System.Windows.Forms.Label CustomerEmailLabel;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtCustomerWebsite;
        private System.Windows.Forms.Label CustomerWebsiteLabel;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtCustomerFax;
        private System.Windows.Forms.Label CustomerFaxLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtCustomerMobile;
        private System.Windows.Forms.Label CustomerMobileLabel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtCustomerPhone;
        private System.Windows.Forms.Label CustomerPhoneLabel;
        private System.Windows.Forms.TabPage customerWarehousePage;
        private System.Windows.Forms.TabPage customerWarehouseEditPage;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.ComboBox CustomerComboBox;
        private RJCodeAdvance.RJControls.RJComboBox warehouseCustomerComboBox1;
        private CustamizedButton editCustomerWarehouseButton;
        private CustamizedButton deleteCustomerWarehouseButton;
        private CustamizedButton addCustomerWarehouseButton;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.TextBox searchCustomerWarehousetextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView customerWarehousesDataGridView;
        private System.Windows.Forms.Panel panel14;
        private CustamizedButton custamizedButton4;
        private CustamizedButton saveWarehouseToCustomerBtn;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.ComboBox warehouseNameComboBox1;
        private System.Windows.Forms.Label warehouseNameLbl;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Label customerNameLbl;
        private System.Windows.Forms.ComboBox customerNameComboBox;
    }
}