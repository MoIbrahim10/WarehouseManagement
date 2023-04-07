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
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.CausesValidation = false;
            this.tabControl1.Controls.Add(this.CustomersListPage);
            this.tabControl1.Controls.Add(this.CustomersAddEditPage);
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
    }
}