namespace WarehouseManagement.Forms
{
    partial class SupplyOrdersForm
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
            this.SupplyOrdersListPage = new System.Windows.Forms.TabPage();
            this.supplyOrderMainPanel = new System.Windows.Forms.Panel();
            this.allDataComboBox = new RJCodeAdvance.RJControls.RJComboBox();
            this.editSupplyOrderButton = new WarehouseManagement.CustamizedButton();
            this.deleteSupplyOrderButton = new WarehouseManagement.CustamizedButton();
            this.AddSupplyOrderButton = new WarehouseManagement.CustamizedButton();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.dataSearchBar = new System.Windows.Forms.TextBox();
            this.searchLbl = new System.Windows.Forms.Label();
            this.supplyOrderDataGrid = new System.Windows.Forms.DataGridView();
            this.SupplyOrdersAddEditPage = new System.Windows.Forms.TabPage();
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
            this.backBtn = new WarehouseManagement.CustamizedButton();
            this.AddEditSupplyOrderBtn = new WarehouseManagement.CustamizedButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSupplierName = new System.Windows.Forms.TextBox();
            this.SupplierNameLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.SupplyOrdersListPage.SuspendLayout();
            this.supplyOrderMainPanel.SuspendLayout();
            this.searchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplyOrderDataGrid)).BeginInit();
            this.SupplyOrdersAddEditPage.SuspendLayout();
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
            this.tabControl1.Controls.Add(this.SupplyOrdersListPage);
            this.tabControl1.Controls.Add(this.SupplyOrdersAddEditPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Verdana Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ItemSize = new System.Drawing.Size(180, 40);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(10, 5);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1579, 878);
            this.tabControl1.TabIndex = 22;
            // 
            // SupplyOrdersListPage
            // 
            this.SupplyOrdersListPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.SupplyOrdersListPage.Controls.Add(this.supplyOrderMainPanel);
            this.SupplyOrdersListPage.Font = new System.Drawing.Font("Verdana Pro Cond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SupplyOrdersListPage.Location = new System.Drawing.Point(4, 44);
            this.SupplyOrdersListPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SupplyOrdersListPage.Name = "SupplyOrdersListPage";
            this.SupplyOrdersListPage.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SupplyOrdersListPage.Size = new System.Drawing.Size(1571, 830);
            this.SupplyOrdersListPage.TabIndex = 0;
            this.SupplyOrdersListPage.Text = "Supply Orders List";
            // 
            // supplyOrderMainPanel
            // 
            this.supplyOrderMainPanel.Controls.Add(this.allDataComboBox);
            this.supplyOrderMainPanel.Controls.Add(this.editSupplyOrderButton);
            this.supplyOrderMainPanel.Controls.Add(this.deleteSupplyOrderButton);
            this.supplyOrderMainPanel.Controls.Add(this.AddSupplyOrderButton);
            this.supplyOrderMainPanel.Controls.Add(this.searchPanel);
            this.supplyOrderMainPanel.Controls.Add(this.supplyOrderDataGrid);
            this.supplyOrderMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.supplyOrderMainPanel.Location = new System.Drawing.Point(4, 5);
            this.supplyOrderMainPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.supplyOrderMainPanel.Name = "supplyOrderMainPanel";
            this.supplyOrderMainPanel.Size = new System.Drawing.Size(1563, 820);
            this.supplyOrderMainPanel.TabIndex = 6;
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
            // editSupplyOrderButton
            // 
            this.editSupplyOrderButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.editSupplyOrderButton.BackColor = System.Drawing.Color.LightSlateGray;
            this.editSupplyOrderButton.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.editSupplyOrderButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.editSupplyOrderButton.BorderRadius = 7;
            this.editSupplyOrderButton.BorderSize = 0;
            this.editSupplyOrderButton.FlatAppearance.BorderSize = 0;
            this.editSupplyOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editSupplyOrderButton.Font = new System.Drawing.Font("Verdana Pro Cond", 13.8F, System.Drawing.FontStyle.Bold);
            this.editSupplyOrderButton.ForeColor = System.Drawing.Color.White;
            this.editSupplyOrderButton.Location = new System.Drawing.Point(1190, 467);
            this.editSupplyOrderButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.editSupplyOrderButton.Name = "editSupplyOrderButton";
            this.editSupplyOrderButton.Size = new System.Drawing.Size(305, 109);
            this.editSupplyOrderButton.TabIndex = 17;
            this.editSupplyOrderButton.Text = "Edit Supply Order";
            this.editSupplyOrderButton.TextColor = System.Drawing.Color.White;
            this.editSupplyOrderButton.UseVisualStyleBackColor = false;
            this.editSupplyOrderButton.Click += new System.EventHandler(this.EditSupplyOrderButton_Click);
            // 
            // deleteSupplyOrderButton
            // 
            this.deleteSupplyOrderButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deleteSupplyOrderButton.BackColor = System.Drawing.Color.Crimson;
            this.deleteSupplyOrderButton.BackgroundColor = System.Drawing.Color.Crimson;
            this.deleteSupplyOrderButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.deleteSupplyOrderButton.BorderRadius = 7;
            this.deleteSupplyOrderButton.BorderSize = 0;
            this.deleteSupplyOrderButton.FlatAppearance.BorderSize = 0;
            this.deleteSupplyOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteSupplyOrderButton.Font = new System.Drawing.Font("Verdana Pro Cond", 13.8F, System.Drawing.FontStyle.Bold);
            this.deleteSupplyOrderButton.ForeColor = System.Drawing.Color.White;
            this.deleteSupplyOrderButton.Location = new System.Drawing.Point(1190, 626);
            this.deleteSupplyOrderButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.deleteSupplyOrderButton.Name = "deleteSupplyOrderButton";
            this.deleteSupplyOrderButton.Size = new System.Drawing.Size(305, 109);
            this.deleteSupplyOrderButton.TabIndex = 16;
            this.deleteSupplyOrderButton.Text = "Delete Supply Order";
            this.deleteSupplyOrderButton.TextColor = System.Drawing.Color.White;
            this.deleteSupplyOrderButton.UseVisualStyleBackColor = false;
            this.deleteSupplyOrderButton.Click += new System.EventHandler(this.DeleteSupplyOrderButton_Click);
            // 
            // AddSupplyOrderButton
            // 
            this.AddSupplyOrderButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddSupplyOrderButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.AddSupplyOrderButton.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.AddSupplyOrderButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.AddSupplyOrderButton.BorderRadius = 7;
            this.AddSupplyOrderButton.BorderSize = 0;
            this.AddSupplyOrderButton.FlatAppearance.BorderSize = 0;
            this.AddSupplyOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddSupplyOrderButton.Font = new System.Drawing.Font("Verdana Pro Cond", 13.8F, System.Drawing.FontStyle.Bold);
            this.AddSupplyOrderButton.ForeColor = System.Drawing.Color.White;
            this.AddSupplyOrderButton.Location = new System.Drawing.Point(1190, 308);
            this.AddSupplyOrderButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddSupplyOrderButton.Name = "AddSupplyOrderButton";
            this.AddSupplyOrderButton.Size = new System.Drawing.Size(305, 109);
            this.AddSupplyOrderButton.TabIndex = 15;
            this.AddSupplyOrderButton.Text = "Add Supply Order";
            this.AddSupplyOrderButton.TextColor = System.Drawing.Color.White;
            this.AddSupplyOrderButton.UseVisualStyleBackColor = false;
            this.AddSupplyOrderButton.Click += new System.EventHandler(this.AddSupplyOrderButton_Click);
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
            // supplyOrderDataGrid
            // 
            this.supplyOrderDataGrid.AllowUserToAddRows = false;
            this.supplyOrderDataGrid.AllowUserToDeleteRows = false;
            this.supplyOrderDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.supplyOrderDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.supplyOrderDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.supplyOrderDataGrid.Location = new System.Drawing.Point(121, 267);
            this.supplyOrderDataGrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.supplyOrderDataGrid.Name = "supplyOrderDataGrid";
            this.supplyOrderDataGrid.ReadOnly = true;
            this.supplyOrderDataGrid.RowHeadersWidth = 51;
            this.supplyOrderDataGrid.RowTemplate.Height = 24;
            this.supplyOrderDataGrid.Size = new System.Drawing.Size(1011, 486);
            this.supplyOrderDataGrid.TabIndex = 6;
            // 
            // SupplyOrdersAddEditPage
            // 
            this.SupplyOrdersAddEditPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.SupplyOrdersAddEditPage.Controls.Add(this.addWarehousPanel);
            this.SupplyOrdersAddEditPage.Location = new System.Drawing.Point(4, 44);
            this.SupplyOrdersAddEditPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SupplyOrdersAddEditPage.Name = "SupplyOrdersAddEditPage";
            this.SupplyOrdersAddEditPage.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SupplyOrdersAddEditPage.Size = new System.Drawing.Size(1571, 830);
            this.SupplyOrdersAddEditPage.TabIndex = 1;
            this.SupplyOrdersAddEditPage.Text = "Edit Supply Order";
            // 
            // addWarehousPanel
            // 
            this.addWarehousPanel.Controls.Add(this.panel5);
            this.addWarehousPanel.Controls.Add(this.panel6);
            this.addWarehousPanel.Controls.Add(this.panel2);
            this.addWarehousPanel.Controls.Add(this.panel3);
            this.addWarehousPanel.Controls.Add(this.panel4);
            this.addWarehousPanel.Controls.Add(this.backBtn);
            this.addWarehousPanel.Controls.Add(this.AddEditSupplyOrderBtn);
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
            // AddEditSupplyOrderBtn
            // 
            this.AddEditSupplyOrderBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddEditSupplyOrderBtn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.AddEditSupplyOrderBtn.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.AddEditSupplyOrderBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.AddEditSupplyOrderBtn.BorderRadius = 7;
            this.AddEditSupplyOrderBtn.BorderSize = 0;
            this.AddEditSupplyOrderBtn.FlatAppearance.BorderSize = 0;
            this.AddEditSupplyOrderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddEditSupplyOrderBtn.Font = new System.Drawing.Font("Verdana Pro Cond", 13.8F, System.Drawing.FontStyle.Bold);
            this.AddEditSupplyOrderBtn.ForeColor = System.Drawing.Color.White;
            this.AddEditSupplyOrderBtn.Location = new System.Drawing.Point(1151, 656);
            this.AddEditSupplyOrderBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddEditSupplyOrderBtn.Name = "AddEditSupplyOrderBtn";
            this.AddEditSupplyOrderBtn.Size = new System.Drawing.Size(222, 80);
            this.AddEditSupplyOrderBtn.TabIndex = 5;
            this.AddEditSupplyOrderBtn.Text = "Save";
            this.AddEditSupplyOrderBtn.TextColor = System.Drawing.Color.White;
            this.AddEditSupplyOrderBtn.UseVisualStyleBackColor = false;
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
            // SupplyOrdersForm
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
            this.Name = "SupplyOrdersForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SupplyOrdersForm";
            this.Load += new System.EventHandler(this.SupplyOrdersForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.SupplyOrdersListPage.ResumeLayout(false);
            this.supplyOrderMainPanel.ResumeLayout(false);
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplyOrderDataGrid)).EndInit();
            this.SupplyOrdersAddEditPage.ResumeLayout(false);
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
        private System.Windows.Forms.TabPage SupplyOrdersListPage;
        private System.Windows.Forms.Panel supplyOrderMainPanel;
        private RJCodeAdvance.RJControls.RJComboBox allDataComboBox;
        private CustamizedButton editSupplyOrderButton;
        private CustamizedButton deleteSupplyOrderButton;
        private CustamizedButton AddSupplyOrderButton;
        private System.Windows.Forms.Panel searchPanel;
        private System.Windows.Forms.TextBox dataSearchBar;
        private System.Windows.Forms.Label searchLbl;
        private System.Windows.Forms.DataGridView supplyOrderDataGrid;
        private System.Windows.Forms.TabPage SupplyOrdersAddEditPage;
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
        private CustamizedButton AddEditSupplyOrderBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSupplierName;
        private System.Windows.Forms.Label SupplierNameLabel;
    }
}