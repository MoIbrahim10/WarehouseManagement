namespace WarehouseManagement.Forms
{
    partial class ReportsForm
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
            this.warehouseReportsPage = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.toDatePicker = new RJCodeAdvance.RJControls.RJDatePicker();
            this.fromDatePicker = new RJCodeAdvance.RJControls.RJDatePicker();
            this.warehouseItemsRadioBtn = new CustomBox.RJControls.RJRadioButton();
            this.warehouseSupplyOrdersRadioBtn = new CustomBox.RJControls.RJRadioButton();
            this.warehouseIssuanceOrdersRadioBtn = new CustomBox.RJControls.RJRadioButton();
            this.warehouseCustomersRadioBtn = new CustomBox.RJControls.RJRadioButton();
            this.warehouseSuppliersRadioBtn = new CustomBox.RJControls.RJRadioButton();
            this.warehouseSearchBar = new System.Windows.Forms.TextBox();
            this.searchLbl = new System.Windows.Forms.Label();
            this.warehouseManagerTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.warehouseAddressTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.warehouseNameTextBox = new System.Windows.Forms.TextBox();
            this.warehousesDataGridView = new System.Windows.Forms.DataGridView();
            this.warehousesComboBox = new System.Windows.Forms.ComboBox();
            this.itemsReportsPage = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.itemToDatePicker = new RJCodeAdvance.RJControls.RJDatePicker();
            this.itemFromDatePicker = new RJCodeAdvance.RJControls.RJDatePicker();
            this.itemWarehousesRadioBtn = new CustomBox.RJControls.RJRadioButton();
            this.itemSupplyOrdersRadioBtn = new CustomBox.RJControls.RJRadioButton();
            this.itemIssuanceOrdersRadioBtn = new CustomBox.RJControls.RJRadioButton();
            this.itemSuppliersRadioBtn = new CustomBox.RJControls.RJRadioButton();
            this.ItemUnitTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.ItemCodeTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.itemSearchBar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.itemsDataGridView = new System.Windows.Forms.DataGridView();
            this.itemsComboBox = new System.Windows.Forms.ComboBox();
            this.suppliersReportsPage = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.supplierSearchBar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.supplierDataGridView = new System.Windows.Forms.DataGridView();
            this.suppliersComboBox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.supplierToDatePicker = new RJCodeAdvance.RJControls.RJDatePicker();
            this.supplierFromDatePicker = new RJCodeAdvance.RJControls.RJDatePicker();
            this.supplierWarehousesRadioBtn = new CustomBox.RJControls.RJRadioButton();
            this.supplierSupplyOrderRadioBtn = new CustomBox.RJControls.RJRadioButton();
            this.supplierIssuanceOrderRadioBtn = new CustomBox.RJControls.RJRadioButton();
            this.supplierItemsRadioBtn = new CustomBox.RJControls.RJRadioButton();
            this.supplierPhoneTextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.supplierEmailTextBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.supplierMobileTextBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.supplierWebsiteTextBox = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.warehouseReportsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.warehousesDataGridView)).BeginInit();
            this.itemsReportsPage.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemsDataGridView)).BeginInit();
            this.suppliersReportsPage.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplierDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.warehouseReportsPage);
            this.tabControl1.Controls.Add(this.itemsReportsPage);
            this.tabControl1.Controls.Add(this.suppliersReportsPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1579, 878);
            this.tabControl1.TabIndex = 4;
            // 
            // warehouseReportsPage
            // 
            this.warehouseReportsPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.warehouseReportsPage.Controls.Add(this.label7);
            this.warehouseReportsPage.Controls.Add(this.label4);
            this.warehouseReportsPage.Controls.Add(this.toDatePicker);
            this.warehouseReportsPage.Controls.Add(this.fromDatePicker);
            this.warehouseReportsPage.Controls.Add(this.warehouseItemsRadioBtn);
            this.warehouseReportsPage.Controls.Add(this.warehouseSupplyOrdersRadioBtn);
            this.warehouseReportsPage.Controls.Add(this.warehouseIssuanceOrdersRadioBtn);
            this.warehouseReportsPage.Controls.Add(this.warehouseCustomersRadioBtn);
            this.warehouseReportsPage.Controls.Add(this.warehouseSuppliersRadioBtn);
            this.warehouseReportsPage.Controls.Add(this.warehouseSearchBar);
            this.warehouseReportsPage.Controls.Add(this.searchLbl);
            this.warehouseReportsPage.Controls.Add(this.warehouseManagerTextBox);
            this.warehouseReportsPage.Controls.Add(this.label6);
            this.warehouseReportsPage.Controls.Add(this.warehouseAddressTextBox);
            this.warehouseReportsPage.Controls.Add(this.label5);
            this.warehouseReportsPage.Controls.Add(this.warehouseNameTextBox);
            this.warehouseReportsPage.Controls.Add(this.warehousesDataGridView);
            this.warehouseReportsPage.Controls.Add(this.warehousesComboBox);
            this.warehouseReportsPage.Location = new System.Drawing.Point(4, 34);
            this.warehouseReportsPage.Name = "warehouseReportsPage";
            this.warehouseReportsPage.Padding = new System.Windows.Forms.Padding(3);
            this.warehouseReportsPage.Size = new System.Drawing.Size(1571, 840);
            this.warehouseReportsPage.TabIndex = 0;
            this.warehouseReportsPage.Text = "Warehouse Reports";
            this.warehouseReportsPage.Enter += new System.EventHandler(this.WarehouseReportsPage_Enter);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(118)))), ((int)(((byte)(161)))));
            this.label7.Location = new System.Drawing.Point(1023, 303);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 25);
            this.label7.TabIndex = 34;
            this.label7.Text = "To";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(118)))), ((int)(((byte)(161)))));
            this.label4.Location = new System.Drawing.Point(1023, 261);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 25);
            this.label4.TabIndex = 33;
            this.label4.Text = "From";
            // 
            // toDatePicker
            // 
            this.toDatePicker.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.toDatePicker.BorderSize = 0;
            this.toDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.toDatePicker.Location = new System.Drawing.Point(1113, 297);
            this.toDatePicker.MinimumSize = new System.Drawing.Size(4, 35);
            this.toDatePicker.Name = "toDatePicker";
            this.toDatePicker.Size = new System.Drawing.Size(350, 35);
            this.toDatePicker.SkinColor = System.Drawing.Color.MediumSlateBlue;
            this.toDatePicker.TabIndex = 32;
            this.toDatePicker.TextColor = System.Drawing.Color.White;
            this.toDatePicker.Validating += new System.ComponentModel.CancelEventHandler(this.DatePicker_Validating);
            // 
            // fromDatePicker
            // 
            this.fromDatePicker.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.fromDatePicker.BorderSize = 0;
            this.fromDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.fromDatePicker.Location = new System.Drawing.Point(1113, 255);
            this.fromDatePicker.MinimumSize = new System.Drawing.Size(4, 35);
            this.fromDatePicker.Name = "fromDatePicker";
            this.fromDatePicker.Size = new System.Drawing.Size(350, 35);
            this.fromDatePicker.SkinColor = System.Drawing.Color.MediumSlateBlue;
            this.fromDatePicker.TabIndex = 31;
            this.fromDatePicker.TextColor = System.Drawing.Color.White;
            this.fromDatePicker.Validating += new System.ComponentModel.CancelEventHandler(this.DatePicker_Validating);
            // 
            // warehouseItemsRadioBtn
            // 
            this.warehouseItemsRadioBtn.AutoSize = true;
            this.warehouseItemsRadioBtn.CheckedColor = System.Drawing.Color.MediumSlateBlue;
            this.warehouseItemsRadioBtn.ForeColor = System.Drawing.Color.White;
            this.warehouseItemsRadioBtn.Location = new System.Drawing.Point(745, 157);
            this.warehouseItemsRadioBtn.MinimumSize = new System.Drawing.Size(0, 21);
            this.warehouseItemsRadioBtn.Name = "warehouseItemsRadioBtn";
            this.warehouseItemsRadioBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.warehouseItemsRadioBtn.Size = new System.Drawing.Size(219, 29);
            this.warehouseItemsRadioBtn.TabIndex = 30;
            this.warehouseItemsRadioBtn.TabStop = true;
            this.warehouseItemsRadioBtn.Text = "Warehouse Items";
            this.warehouseItemsRadioBtn.UnCheckedColor = System.Drawing.Color.Gray;
            this.warehouseItemsRadioBtn.UseVisualStyleBackColor = true;
            this.warehouseItemsRadioBtn.CheckedChanged += new System.EventHandler(this.RadioBtn_CheckedChanged);
            // 
            // warehouseSupplyOrdersRadioBtn
            // 
            this.warehouseSupplyOrdersRadioBtn.AutoSize = true;
            this.warehouseSupplyOrdersRadioBtn.CheckedColor = System.Drawing.Color.MediumSlateBlue;
            this.warehouseSupplyOrdersRadioBtn.ForeColor = System.Drawing.Color.White;
            this.warehouseSupplyOrdersRadioBtn.Location = new System.Drawing.Point(745, 257);
            this.warehouseSupplyOrdersRadioBtn.MinimumSize = new System.Drawing.Size(0, 21);
            this.warehouseSupplyOrdersRadioBtn.Name = "warehouseSupplyOrdersRadioBtn";
            this.warehouseSupplyOrdersRadioBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.warehouseSupplyOrdersRadioBtn.Size = new System.Drawing.Size(186, 29);
            this.warehouseSupplyOrdersRadioBtn.TabIndex = 29;
            this.warehouseSupplyOrdersRadioBtn.TabStop = true;
            this.warehouseSupplyOrdersRadioBtn.Text = "Supply Orders";
            this.warehouseSupplyOrdersRadioBtn.UnCheckedColor = System.Drawing.Color.Gray;
            this.warehouseSupplyOrdersRadioBtn.UseVisualStyleBackColor = true;
            this.warehouseSupplyOrdersRadioBtn.CheckedChanged += new System.EventHandler(this.RadioBtn_CheckedChanged);
            // 
            // warehouseIssuanceOrdersRadioBtn
            // 
            this.warehouseIssuanceOrdersRadioBtn.AutoSize = true;
            this.warehouseIssuanceOrdersRadioBtn.CheckedColor = System.Drawing.Color.MediumSlateBlue;
            this.warehouseIssuanceOrdersRadioBtn.ForeColor = System.Drawing.Color.White;
            this.warehouseIssuanceOrdersRadioBtn.Location = new System.Drawing.Point(745, 303);
            this.warehouseIssuanceOrdersRadioBtn.MinimumSize = new System.Drawing.Size(0, 21);
            this.warehouseIssuanceOrdersRadioBtn.Name = "warehouseIssuanceOrdersRadioBtn";
            this.warehouseIssuanceOrdersRadioBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.warehouseIssuanceOrdersRadioBtn.Size = new System.Drawing.Size(206, 29);
            this.warehouseIssuanceOrdersRadioBtn.TabIndex = 28;
            this.warehouseIssuanceOrdersRadioBtn.TabStop = true;
            this.warehouseIssuanceOrdersRadioBtn.Text = "Issuance Orders";
            this.warehouseIssuanceOrdersRadioBtn.UnCheckedColor = System.Drawing.Color.Gray;
            this.warehouseIssuanceOrdersRadioBtn.UseVisualStyleBackColor = true;
            this.warehouseIssuanceOrdersRadioBtn.CheckedChanged += new System.EventHandler(this.RadioBtn_CheckedChanged);
            // 
            // warehouseCustomersRadioBtn
            // 
            this.warehouseCustomersRadioBtn.AutoSize = true;
            this.warehouseCustomersRadioBtn.CheckedColor = System.Drawing.Color.MediumSlateBlue;
            this.warehouseCustomersRadioBtn.ForeColor = System.Drawing.Color.White;
            this.warehouseCustomersRadioBtn.Location = new System.Drawing.Point(1044, 206);
            this.warehouseCustomersRadioBtn.MinimumSize = new System.Drawing.Size(0, 21);
            this.warehouseCustomersRadioBtn.Name = "warehouseCustomersRadioBtn";
            this.warehouseCustomersRadioBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.warehouseCustomersRadioBtn.Size = new System.Drawing.Size(269, 29);
            this.warehouseCustomersRadioBtn.TabIndex = 27;
            this.warehouseCustomersRadioBtn.TabStop = true;
            this.warehouseCustomersRadioBtn.Text = "Warehouse Customers";
            this.warehouseCustomersRadioBtn.UnCheckedColor = System.Drawing.Color.Gray;
            this.warehouseCustomersRadioBtn.UseVisualStyleBackColor = true;
            this.warehouseCustomersRadioBtn.CheckedChanged += new System.EventHandler(this.RadioBtn_CheckedChanged);
            // 
            // warehouseSuppliersRadioBtn
            // 
            this.warehouseSuppliersRadioBtn.AutoSize = true;
            this.warehouseSuppliersRadioBtn.CheckedColor = System.Drawing.Color.MediumSlateBlue;
            this.warehouseSuppliersRadioBtn.ForeColor = System.Drawing.Color.White;
            this.warehouseSuppliersRadioBtn.Location = new System.Drawing.Point(745, 206);
            this.warehouseSuppliersRadioBtn.MinimumSize = new System.Drawing.Size(0, 21);
            this.warehouseSuppliersRadioBtn.Name = "warehouseSuppliersRadioBtn";
            this.warehouseSuppliersRadioBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.warehouseSuppliersRadioBtn.Size = new System.Drawing.Size(254, 29);
            this.warehouseSuppliersRadioBtn.TabIndex = 26;
            this.warehouseSuppliersRadioBtn.TabStop = true;
            this.warehouseSuppliersRadioBtn.Text = "Warehouse Suppliers";
            this.warehouseSuppliersRadioBtn.UnCheckedColor = System.Drawing.Color.Gray;
            this.warehouseSuppliersRadioBtn.UseVisualStyleBackColor = true;
            this.warehouseSuppliersRadioBtn.CheckedChanged += new System.EventHandler(this.RadioBtn_CheckedChanged);
            // 
            // warehouseSearchBar
            // 
            this.warehouseSearchBar.Font = new System.Drawing.Font("Verdana Pro", 13.8F);
            this.warehouseSearchBar.Location = new System.Drawing.Point(219, 94);
            this.warehouseSearchBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.warehouseSearchBar.Name = "warehouseSearchBar";
            this.warehouseSearchBar.Size = new System.Drawing.Size(407, 35);
            this.warehouseSearchBar.TabIndex = 24;
            this.warehouseSearchBar.TextChanged += new System.EventHandler(this.WarehouseSearchBar_TextChanged);
            // 
            // searchLbl
            // 
            this.searchLbl.AutoSize = true;
            this.searchLbl.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(118)))), ((int)(((byte)(161)))));
            this.searchLbl.Location = new System.Drawing.Point(102, 99);
            this.searchLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.searchLbl.Name = "searchLbl";
            this.searchLbl.Size = new System.Drawing.Size(99, 28);
            this.searchLbl.TabIndex = 23;
            this.searchLbl.Text = "Search";
            // 
            // warehouseManagerTextBox
            // 
            this.warehouseManagerTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.warehouseManagerTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.warehouseManagerTextBox.Font = new System.Drawing.Font("Verdana Pro Cond Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warehouseManagerTextBox.ForeColor = System.Drawing.Color.White;
            this.warehouseManagerTextBox.Location = new System.Drawing.Point(357, 295);
            this.warehouseManagerTextBox.Name = "warehouseManagerTextBox";
            this.warehouseManagerTextBox.ReadOnly = true;
            this.warehouseManagerTextBox.Size = new System.Drawing.Size(269, 25);
            this.warehouseManagerTextBox.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(118)))), ((int)(((byte)(161)))));
            this.label6.Location = new System.Drawing.Point(102, 295);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(241, 25);
            this.label6.TabIndex = 21;
            this.label6.Text = "Warehouse Manager";
            // 
            // warehouseAddressTextBox
            // 
            this.warehouseAddressTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.warehouseAddressTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.warehouseAddressTextBox.Font = new System.Drawing.Font("Verdana Pro Cond Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warehouseAddressTextBox.ForeColor = System.Drawing.Color.White;
            this.warehouseAddressTextBox.Location = new System.Drawing.Point(357, 242);
            this.warehouseAddressTextBox.Name = "warehouseAddressTextBox";
            this.warehouseAddressTextBox.ReadOnly = true;
            this.warehouseAddressTextBox.Size = new System.Drawing.Size(269, 25);
            this.warehouseAddressTextBox.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(118)))), ((int)(((byte)(161)))));
            this.label5.Location = new System.Drawing.Point(102, 242);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(236, 25);
            this.label5.TabIndex = 19;
            this.label5.Text = "Warehouse Address";
            // 
            // warehouseNameTextBox
            // 
            this.warehouseNameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.warehouseNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.warehouseNameTextBox.Font = new System.Drawing.Font("Verdana Pro", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warehouseNameTextBox.ForeColor = System.Drawing.Color.White;
            this.warehouseNameTextBox.Location = new System.Drawing.Point(107, 172);
            this.warehouseNameTextBox.Name = "warehouseNameTextBox";
            this.warehouseNameTextBox.ReadOnly = true;
            this.warehouseNameTextBox.Size = new System.Drawing.Size(568, 33);
            this.warehouseNameTextBox.TabIndex = 18;
            // 
            // warehousesDataGridView
            // 
            this.warehousesDataGridView.AllowUserToAddRows = false;
            this.warehousesDataGridView.AllowUserToDeleteRows = false;
            this.warehousesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.warehousesDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.warehousesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.warehousesDataGridView.Location = new System.Drawing.Point(107, 360);
            this.warehousesDataGridView.Name = "warehousesDataGridView";
            this.warehousesDataGridView.ReadOnly = true;
            this.warehousesDataGridView.RowHeadersWidth = 51;
            this.warehousesDataGridView.RowTemplate.Height = 24;
            this.warehousesDataGridView.Size = new System.Drawing.Size(1356, 430);
            this.warehousesDataGridView.TabIndex = 4;
            // 
            // warehousesComboBox
            // 
            this.warehousesComboBox.Font = new System.Drawing.Font("Verdana Pro", 13.8F);
            this.warehousesComboBox.FormattingEnabled = true;
            this.warehousesComboBox.Location = new System.Drawing.Point(745, 93);
            this.warehousesComboBox.Name = "warehousesComboBox";
            this.warehousesComboBox.Size = new System.Drawing.Size(718, 36);
            this.warehousesComboBox.TabIndex = 0;
            this.warehousesComboBox.SelectedIndexChanged += new System.EventHandler(this.WarehousesComboBox_SelectedIndexChanged);
            // 
            // itemsReportsPage
            // 
            this.itemsReportsPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.itemsReportsPage.Controls.Add(this.label8);
            this.itemsReportsPage.Controls.Add(this.label9);
            this.itemsReportsPage.Controls.Add(this.itemToDatePicker);
            this.itemsReportsPage.Controls.Add(this.itemFromDatePicker);
            this.itemsReportsPage.Controls.Add(this.itemWarehousesRadioBtn);
            this.itemsReportsPage.Controls.Add(this.itemSupplyOrdersRadioBtn);
            this.itemsReportsPage.Controls.Add(this.itemIssuanceOrdersRadioBtn);
            this.itemsReportsPage.Controls.Add(this.itemSuppliersRadioBtn);
            this.itemsReportsPage.Controls.Add(this.ItemUnitTextBox);
            this.itemsReportsPage.Controls.Add(this.label11);
            this.itemsReportsPage.Controls.Add(this.ItemCodeTextBox);
            this.itemsReportsPage.Controls.Add(this.panel1);
            this.itemsReportsPage.Controls.Add(this.itemsDataGridView);
            this.itemsReportsPage.Controls.Add(this.itemsComboBox);
            this.itemsReportsPage.Location = new System.Drawing.Point(4, 34);
            this.itemsReportsPage.Name = "itemsReportsPage";
            this.itemsReportsPage.Padding = new System.Windows.Forms.Padding(3);
            this.itemsReportsPage.Size = new System.Drawing.Size(1571, 840);
            this.itemsReportsPage.TabIndex = 1;
            this.itemsReportsPage.Text = "Items Reports";
            this.itemsReportsPage.Enter += new System.EventHandler(this.ItemsReportsPage_Enter);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(118)))), ((int)(((byte)(161)))));
            this.label8.Location = new System.Drawing.Point(1023, 344);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 25);
            this.label8.TabIndex = 48;
            this.label8.Text = "To";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(118)))), ((int)(((byte)(161)))));
            this.label9.Location = new System.Drawing.Point(1023, 302);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 25);
            this.label9.TabIndex = 47;
            this.label9.Text = "From";
            // 
            // itemToDatePicker
            // 
            this.itemToDatePicker.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.itemToDatePicker.BorderSize = 0;
            this.itemToDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.itemToDatePicker.Location = new System.Drawing.Point(1113, 338);
            this.itemToDatePicker.MinimumSize = new System.Drawing.Size(4, 35);
            this.itemToDatePicker.Name = "itemToDatePicker";
            this.itemToDatePicker.Size = new System.Drawing.Size(350, 35);
            this.itemToDatePicker.SkinColor = System.Drawing.Color.MediumSlateBlue;
            this.itemToDatePicker.TabIndex = 46;
            this.itemToDatePicker.TextColor = System.Drawing.Color.White;
            this.itemToDatePicker.Validating += new System.ComponentModel.CancelEventHandler(this.DatePickerItem_Validating);
            // 
            // itemFromDatePicker
            // 
            this.itemFromDatePicker.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.itemFromDatePicker.BorderSize = 0;
            this.itemFromDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.itemFromDatePicker.Location = new System.Drawing.Point(1113, 296);
            this.itemFromDatePicker.MinimumSize = new System.Drawing.Size(4, 35);
            this.itemFromDatePicker.Name = "itemFromDatePicker";
            this.itemFromDatePicker.Size = new System.Drawing.Size(350, 35);
            this.itemFromDatePicker.SkinColor = System.Drawing.Color.MediumSlateBlue;
            this.itemFromDatePicker.TabIndex = 45;
            this.itemFromDatePicker.TextColor = System.Drawing.Color.White;
            this.itemFromDatePicker.Validating += new System.ComponentModel.CancelEventHandler(this.DatePickerItem_Validating);
            // 
            // itemWarehousesRadioBtn
            // 
            this.itemWarehousesRadioBtn.AutoSize = true;
            this.itemWarehousesRadioBtn.CheckedColor = System.Drawing.Color.MediumSlateBlue;
            this.itemWarehousesRadioBtn.ForeColor = System.Drawing.Color.White;
            this.itemWarehousesRadioBtn.Location = new System.Drawing.Point(745, 198);
            this.itemWarehousesRadioBtn.MinimumSize = new System.Drawing.Size(0, 21);
            this.itemWarehousesRadioBtn.Name = "itemWarehousesRadioBtn";
            this.itemWarehousesRadioBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.itemWarehousesRadioBtn.Size = new System.Drawing.Size(219, 29);
            this.itemWarehousesRadioBtn.TabIndex = 44;
            this.itemWarehousesRadioBtn.TabStop = true;
            this.itemWarehousesRadioBtn.Text = "Item Warehouses";
            this.itemWarehousesRadioBtn.UnCheckedColor = System.Drawing.Color.Gray;
            this.itemWarehousesRadioBtn.UseVisualStyleBackColor = true;
            this.itemWarehousesRadioBtn.CheckedChanged += new System.EventHandler(this.RadioBtnItems_CheckedChanged);
            // 
            // itemSupplyOrdersRadioBtn
            // 
            this.itemSupplyOrdersRadioBtn.AutoSize = true;
            this.itemSupplyOrdersRadioBtn.CheckedColor = System.Drawing.Color.MediumSlateBlue;
            this.itemSupplyOrdersRadioBtn.ForeColor = System.Drawing.Color.White;
            this.itemSupplyOrdersRadioBtn.Location = new System.Drawing.Point(745, 298);
            this.itemSupplyOrdersRadioBtn.MinimumSize = new System.Drawing.Size(0, 21);
            this.itemSupplyOrdersRadioBtn.Name = "itemSupplyOrdersRadioBtn";
            this.itemSupplyOrdersRadioBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.itemSupplyOrdersRadioBtn.Size = new System.Drawing.Size(186, 29);
            this.itemSupplyOrdersRadioBtn.TabIndex = 43;
            this.itemSupplyOrdersRadioBtn.TabStop = true;
            this.itemSupplyOrdersRadioBtn.Text = "Supply Orders";
            this.itemSupplyOrdersRadioBtn.UnCheckedColor = System.Drawing.Color.Gray;
            this.itemSupplyOrdersRadioBtn.UseVisualStyleBackColor = true;
            this.itemSupplyOrdersRadioBtn.CheckedChanged += new System.EventHandler(this.RadioBtnItems_CheckedChanged);
            // 
            // itemIssuanceOrdersRadioBtn
            // 
            this.itemIssuanceOrdersRadioBtn.AutoSize = true;
            this.itemIssuanceOrdersRadioBtn.CheckedColor = System.Drawing.Color.MediumSlateBlue;
            this.itemIssuanceOrdersRadioBtn.ForeColor = System.Drawing.Color.White;
            this.itemIssuanceOrdersRadioBtn.Location = new System.Drawing.Point(745, 344);
            this.itemIssuanceOrdersRadioBtn.MinimumSize = new System.Drawing.Size(0, 21);
            this.itemIssuanceOrdersRadioBtn.Name = "itemIssuanceOrdersRadioBtn";
            this.itemIssuanceOrdersRadioBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.itemIssuanceOrdersRadioBtn.Size = new System.Drawing.Size(206, 29);
            this.itemIssuanceOrdersRadioBtn.TabIndex = 42;
            this.itemIssuanceOrdersRadioBtn.TabStop = true;
            this.itemIssuanceOrdersRadioBtn.Text = "Issuance Orders";
            this.itemIssuanceOrdersRadioBtn.UnCheckedColor = System.Drawing.Color.Gray;
            this.itemIssuanceOrdersRadioBtn.UseVisualStyleBackColor = true;
            this.itemIssuanceOrdersRadioBtn.CheckedChanged += new System.EventHandler(this.RadioBtnItems_CheckedChanged);
            // 
            // itemSuppliersRadioBtn
            // 
            this.itemSuppliersRadioBtn.AutoSize = true;
            this.itemSuppliersRadioBtn.CheckedColor = System.Drawing.Color.MediumSlateBlue;
            this.itemSuppliersRadioBtn.ForeColor = System.Drawing.Color.White;
            this.itemSuppliersRadioBtn.Location = new System.Drawing.Point(745, 247);
            this.itemSuppliersRadioBtn.MinimumSize = new System.Drawing.Size(0, 21);
            this.itemSuppliersRadioBtn.Name = "itemSuppliersRadioBtn";
            this.itemSuppliersRadioBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.itemSuppliersRadioBtn.Size = new System.Drawing.Size(189, 29);
            this.itemSuppliersRadioBtn.TabIndex = 40;
            this.itemSuppliersRadioBtn.TabStop = true;
            this.itemSuppliersRadioBtn.Text = "Item Suppliers";
            this.itemSuppliersRadioBtn.UnCheckedColor = System.Drawing.Color.Gray;
            this.itemSuppliersRadioBtn.UseVisualStyleBackColor = true;
            this.itemSuppliersRadioBtn.CheckedChanged += new System.EventHandler(this.RadioBtnItems_CheckedChanged);
            // 
            // ItemUnitTextBox
            // 
            this.ItemUnitTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.ItemUnitTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ItemUnitTextBox.Font = new System.Drawing.Font("Verdana Pro Cond Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemUnitTextBox.ForeColor = System.Drawing.Color.White;
            this.ItemUnitTextBox.Location = new System.Drawing.Point(167, 283);
            this.ItemUnitTextBox.Name = "ItemUnitTextBox";
            this.ItemUnitTextBox.ReadOnly = true;
            this.ItemUnitTextBox.Size = new System.Drawing.Size(417, 25);
            this.ItemUnitTextBox.TabIndex = 37;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(118)))), ((int)(((byte)(161)))));
            this.label11.Location = new System.Drawing.Point(102, 283);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 25);
            this.label11.TabIndex = 36;
            this.label11.Text = "Unit";
            // 
            // ItemCodeTextBox
            // 
            this.ItemCodeTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.ItemCodeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ItemCodeTextBox.Font = new System.Drawing.Font("Verdana Pro", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemCodeTextBox.ForeColor = System.Drawing.Color.White;
            this.ItemCodeTextBox.Location = new System.Drawing.Point(107, 213);
            this.ItemCodeTextBox.Name = "ItemCodeTextBox";
            this.ItemCodeTextBox.ReadOnly = true;
            this.ItemCodeTextBox.Size = new System.Drawing.Size(568, 33);
            this.ItemCodeTextBox.TabIndex = 35;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.itemSearchBar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(107, 50);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(742, 130);
            this.panel1.TabIndex = 18;
            // 
            // itemSearchBar
            // 
            this.itemSearchBar.Font = new System.Drawing.Font("Verdana Pro", 13.8F);
            this.itemSearchBar.Location = new System.Drawing.Point(151, 46);
            this.itemSearchBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.itemSearchBar.Name = "itemSearchBar";
            this.itemSearchBar.Size = new System.Drawing.Size(562, 35);
            this.itemSearchBar.TabIndex = 20;
            this.itemSearchBar.TextChanged += new System.EventHandler(this.ItemSearchBar_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(118)))), ((int)(((byte)(161)))));
            this.label1.Location = new System.Drawing.Point(25, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 28);
            this.label1.TabIndex = 16;
            this.label1.Text = "Search";
            // 
            // itemsDataGridView
            // 
            this.itemsDataGridView.AllowUserToAddRows = false;
            this.itemsDataGridView.AllowUserToDeleteRows = false;
            this.itemsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.itemsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.itemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemsDataGridView.Location = new System.Drawing.Point(107, 400);
            this.itemsDataGridView.Name = "itemsDataGridView";
            this.itemsDataGridView.ReadOnly = true;
            this.itemsDataGridView.RowHeadersWidth = 51;
            this.itemsDataGridView.RowTemplate.Height = 24;
            this.itemsDataGridView.Size = new System.Drawing.Size(1356, 390);
            this.itemsDataGridView.TabIndex = 17;
            // 
            // itemsComboBox
            // 
            this.itemsComboBox.FormattingEnabled = true;
            this.itemsComboBox.Location = new System.Drawing.Point(895, 96);
            this.itemsComboBox.Name = "itemsComboBox";
            this.itemsComboBox.Size = new System.Drawing.Size(568, 33);
            this.itemsComboBox.TabIndex = 16;
            this.itemsComboBox.SelectedIndexChanged += new System.EventHandler(this.ItemsComboBox_SelectedIndexChanged);
            // 
            // suppliersReportsPage
            // 
            this.suppliersReportsPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.suppliersReportsPage.Controls.Add(this.supplierWebsiteTextBox);
            this.suppliersReportsPage.Controls.Add(this.label16);
            this.suppliersReportsPage.Controls.Add(this.supplierMobileTextBox);
            this.suppliersReportsPage.Controls.Add(this.label15);
            this.suppliersReportsPage.Controls.Add(this.supplierEmailTextBox);
            this.suppliersReportsPage.Controls.Add(this.label14);
            this.suppliersReportsPage.Controls.Add(this.label10);
            this.suppliersReportsPage.Controls.Add(this.label12);
            this.suppliersReportsPage.Controls.Add(this.supplierToDatePicker);
            this.suppliersReportsPage.Controls.Add(this.supplierFromDatePicker);
            this.suppliersReportsPage.Controls.Add(this.supplierWarehousesRadioBtn);
            this.suppliersReportsPage.Controls.Add(this.supplierSupplyOrderRadioBtn);
            this.suppliersReportsPage.Controls.Add(this.supplierIssuanceOrderRadioBtn);
            this.suppliersReportsPage.Controls.Add(this.supplierItemsRadioBtn);
            this.suppliersReportsPage.Controls.Add(this.supplierPhoneTextBox);
            this.suppliersReportsPage.Controls.Add(this.label13);
            this.suppliersReportsPage.Controls.Add(this.panel2);
            this.suppliersReportsPage.Controls.Add(this.supplierDataGridView);
            this.suppliersReportsPage.Controls.Add(this.suppliersComboBox);
            this.suppliersReportsPage.Location = new System.Drawing.Point(4, 34);
            this.suppliersReportsPage.Name = "suppliersReportsPage";
            this.suppliersReportsPage.Size = new System.Drawing.Size(1571, 840);
            this.suppliersReportsPage.TabIndex = 2;
            this.suppliersReportsPage.Text = "Supplier Reports";
            this.suppliersReportsPage.Enter += new System.EventHandler(this.SuppliersReportsPage_Enter);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.supplierSearchBar);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(107, 50);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(742, 130);
            this.panel2.TabIndex = 21;
            // 
            // supplierSearchBar
            // 
            this.supplierSearchBar.Font = new System.Drawing.Font("Verdana Pro", 13.8F);
            this.supplierSearchBar.Location = new System.Drawing.Point(151, 46);
            this.supplierSearchBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.supplierSearchBar.Name = "supplierSearchBar";
            this.supplierSearchBar.Size = new System.Drawing.Size(562, 35);
            this.supplierSearchBar.TabIndex = 20;
            this.supplierSearchBar.TextChanged += new System.EventHandler(this.SupplierSearchBar_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(118)))), ((int)(((byte)(161)))));
            this.label2.Location = new System.Drawing.Point(25, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 28);
            this.label2.TabIndex = 16;
            this.label2.Text = "Search";
            // 
            // supplierDataGridView
            // 
            this.supplierDataGridView.AllowUserToAddRows = false;
            this.supplierDataGridView.AllowUserToDeleteRows = false;
            this.supplierDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.supplierDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.supplierDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.supplierDataGridView.Location = new System.Drawing.Point(107, 401);
            this.supplierDataGridView.Name = "supplierDataGridView";
            this.supplierDataGridView.ReadOnly = true;
            this.supplierDataGridView.RowHeadersWidth = 51;
            this.supplierDataGridView.RowTemplate.Height = 24;
            this.supplierDataGridView.Size = new System.Drawing.Size(1356, 389);
            this.supplierDataGridView.TabIndex = 20;
            // 
            // suppliersComboBox
            // 
            this.suppliersComboBox.FormattingEnabled = true;
            this.suppliersComboBox.Location = new System.Drawing.Point(895, 96);
            this.suppliersComboBox.Name = "suppliersComboBox";
            this.suppliersComboBox.Size = new System.Drawing.Size(568, 33);
            this.suppliersComboBox.TabIndex = 19;
            this.suppliersComboBox.SelectedIndexChanged += new System.EventHandler(this.SuppliersComboBox_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(118)))), ((int)(((byte)(161)))));
            this.label10.Location = new System.Drawing.Point(1023, 354);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 25);
            this.label10.TabIndex = 59;
            this.label10.Text = "To";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(118)))), ((int)(((byte)(161)))));
            this.label12.Location = new System.Drawing.Point(1023, 312);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 25);
            this.label12.TabIndex = 58;
            this.label12.Text = "From";
            // 
            // supplierToDatePicker
            // 
            this.supplierToDatePicker.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.supplierToDatePicker.BorderSize = 0;
            this.supplierToDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.supplierToDatePicker.Location = new System.Drawing.Point(1113, 348);
            this.supplierToDatePicker.MinimumSize = new System.Drawing.Size(4, 35);
            this.supplierToDatePicker.Name = "supplierToDatePicker";
            this.supplierToDatePicker.Size = new System.Drawing.Size(350, 35);
            this.supplierToDatePicker.SkinColor = System.Drawing.Color.MediumSlateBlue;
            this.supplierToDatePicker.TabIndex = 57;
            this.supplierToDatePicker.TextColor = System.Drawing.Color.White;
            this.supplierToDatePicker.Validating += new System.ComponentModel.CancelEventHandler(this.supplierDatePicker_Validating);
            // 
            // supplierFromDatePicker
            // 
            this.supplierFromDatePicker.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.supplierFromDatePicker.BorderSize = 0;
            this.supplierFromDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.supplierFromDatePicker.Location = new System.Drawing.Point(1113, 306);
            this.supplierFromDatePicker.MinimumSize = new System.Drawing.Size(4, 35);
            this.supplierFromDatePicker.Name = "supplierFromDatePicker";
            this.supplierFromDatePicker.Size = new System.Drawing.Size(350, 35);
            this.supplierFromDatePicker.SkinColor = System.Drawing.Color.MediumSlateBlue;
            this.supplierFromDatePicker.TabIndex = 56;
            this.supplierFromDatePicker.TextColor = System.Drawing.Color.White;
            this.supplierFromDatePicker.Validating += new System.ComponentModel.CancelEventHandler(this.supplierDatePicker_Validating);
            // 
            // supplierWarehousesRadioBtn
            // 
            this.supplierWarehousesRadioBtn.AutoSize = true;
            this.supplierWarehousesRadioBtn.CheckedColor = System.Drawing.Color.MediumSlateBlue;
            this.supplierWarehousesRadioBtn.ForeColor = System.Drawing.Color.White;
            this.supplierWarehousesRadioBtn.Location = new System.Drawing.Point(745, 208);
            this.supplierWarehousesRadioBtn.MinimumSize = new System.Drawing.Size(0, 21);
            this.supplierWarehousesRadioBtn.Name = "supplierWarehousesRadioBtn";
            this.supplierWarehousesRadioBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.supplierWarehousesRadioBtn.Size = new System.Drawing.Size(254, 29);
            this.supplierWarehousesRadioBtn.TabIndex = 55;
            this.supplierWarehousesRadioBtn.TabStop = true;
            this.supplierWarehousesRadioBtn.Text = "Supplier Warehouses";
            this.supplierWarehousesRadioBtn.UnCheckedColor = System.Drawing.Color.Gray;
            this.supplierWarehousesRadioBtn.UseVisualStyleBackColor = true;
            this.supplierWarehousesRadioBtn.CheckedChanged += new System.EventHandler(this.SupplierRadioBtn_CheckedChanged);
            // 
            // supplierSupplyOrderRadioBtn
            // 
            this.supplierSupplyOrderRadioBtn.AutoSize = true;
            this.supplierSupplyOrderRadioBtn.CheckedColor = System.Drawing.Color.MediumSlateBlue;
            this.supplierSupplyOrderRadioBtn.ForeColor = System.Drawing.Color.White;
            this.supplierSupplyOrderRadioBtn.Location = new System.Drawing.Point(745, 308);
            this.supplierSupplyOrderRadioBtn.MinimumSize = new System.Drawing.Size(0, 21);
            this.supplierSupplyOrderRadioBtn.Name = "supplierSupplyOrderRadioBtn";
            this.supplierSupplyOrderRadioBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.supplierSupplyOrderRadioBtn.Size = new System.Drawing.Size(186, 29);
            this.supplierSupplyOrderRadioBtn.TabIndex = 54;
            this.supplierSupplyOrderRadioBtn.TabStop = true;
            this.supplierSupplyOrderRadioBtn.Text = "Supply Orders";
            this.supplierSupplyOrderRadioBtn.UnCheckedColor = System.Drawing.Color.Gray;
            this.supplierSupplyOrderRadioBtn.UseVisualStyleBackColor = true;
            this.supplierSupplyOrderRadioBtn.CheckedChanged += new System.EventHandler(this.SupplierRadioBtn_CheckedChanged);
            // 
            // supplierIssuanceOrderRadioBtn
            // 
            this.supplierIssuanceOrderRadioBtn.AutoSize = true;
            this.supplierIssuanceOrderRadioBtn.CheckedColor = System.Drawing.Color.MediumSlateBlue;
            this.supplierIssuanceOrderRadioBtn.ForeColor = System.Drawing.Color.White;
            this.supplierIssuanceOrderRadioBtn.Location = new System.Drawing.Point(745, 354);
            this.supplierIssuanceOrderRadioBtn.MinimumSize = new System.Drawing.Size(0, 21);
            this.supplierIssuanceOrderRadioBtn.Name = "supplierIssuanceOrderRadioBtn";
            this.supplierIssuanceOrderRadioBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.supplierIssuanceOrderRadioBtn.Size = new System.Drawing.Size(206, 29);
            this.supplierIssuanceOrderRadioBtn.TabIndex = 53;
            this.supplierIssuanceOrderRadioBtn.TabStop = true;
            this.supplierIssuanceOrderRadioBtn.Text = "Issuance Orders";
            this.supplierIssuanceOrderRadioBtn.UnCheckedColor = System.Drawing.Color.Gray;
            this.supplierIssuanceOrderRadioBtn.UseVisualStyleBackColor = true;
            this.supplierIssuanceOrderRadioBtn.CheckedChanged += new System.EventHandler(this.SupplierRadioBtn_CheckedChanged);
            // 
            // supplierItemsRadioBtn
            // 
            this.supplierItemsRadioBtn.AutoSize = true;
            this.supplierItemsRadioBtn.CheckedColor = System.Drawing.Color.MediumSlateBlue;
            this.supplierItemsRadioBtn.ForeColor = System.Drawing.Color.White;
            this.supplierItemsRadioBtn.Location = new System.Drawing.Point(745, 257);
            this.supplierItemsRadioBtn.MinimumSize = new System.Drawing.Size(0, 21);
            this.supplierItemsRadioBtn.Name = "supplierItemsRadioBtn";
            this.supplierItemsRadioBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.supplierItemsRadioBtn.Size = new System.Drawing.Size(189, 29);
            this.supplierItemsRadioBtn.TabIndex = 52;
            this.supplierItemsRadioBtn.TabStop = true;
            this.supplierItemsRadioBtn.Text = "Supplier Items";
            this.supplierItemsRadioBtn.UnCheckedColor = System.Drawing.Color.Gray;
            this.supplierItemsRadioBtn.UseVisualStyleBackColor = true;
            this.supplierItemsRadioBtn.CheckedChanged += new System.EventHandler(this.SupplierRadioBtn_CheckedChanged);
            // 
            // supplierPhoneTextBox
            // 
            this.supplierPhoneTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.supplierPhoneTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.supplierPhoneTextBox.Font = new System.Drawing.Font("Verdana Pro Cond Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplierPhoneTextBox.ForeColor = System.Drawing.Color.White;
            this.supplierPhoneTextBox.Location = new System.Drawing.Point(212, 261);
            this.supplierPhoneTextBox.Name = "supplierPhoneTextBox";
            this.supplierPhoneTextBox.ReadOnly = true;
            this.supplierPhoneTextBox.Size = new System.Drawing.Size(417, 25);
            this.supplierPhoneTextBox.TabIndex = 51;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(118)))), ((int)(((byte)(161)))));
            this.label13.Location = new System.Drawing.Point(102, 257);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.MinimumSize = new System.Drawing.Size(90, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 25);
            this.label13.TabIndex = 50;
            this.label13.Text = "Phone";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // supplierEmailTextBox
            // 
            this.supplierEmailTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.supplierEmailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.supplierEmailTextBox.Font = new System.Drawing.Font("Verdana Pro Cond Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplierEmailTextBox.ForeColor = System.Drawing.Color.White;
            this.supplierEmailTextBox.Location = new System.Drawing.Point(212, 212);
            this.supplierEmailTextBox.Name = "supplierEmailTextBox";
            this.supplierEmailTextBox.ReadOnly = true;
            this.supplierEmailTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.supplierEmailTextBox.Size = new System.Drawing.Size(417, 25);
            this.supplierEmailTextBox.TabIndex = 61;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(118)))), ((int)(((byte)(161)))));
            this.label14.Location = new System.Drawing.Point(102, 208);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(74, 25);
            this.label14.TabIndex = 60;
            this.label14.Text = "Email";
            // 
            // supplierMobileTextBox
            // 
            this.supplierMobileTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.supplierMobileTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.supplierMobileTextBox.Font = new System.Drawing.Font("Verdana Pro Cond Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplierMobileTextBox.ForeColor = System.Drawing.Color.White;
            this.supplierMobileTextBox.Location = new System.Drawing.Point(212, 312);
            this.supplierMobileTextBox.Name = "supplierMobileTextBox";
            this.supplierMobileTextBox.ReadOnly = true;
            this.supplierMobileTextBox.Size = new System.Drawing.Size(417, 25);
            this.supplierMobileTextBox.TabIndex = 63;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(118)))), ((int)(((byte)(161)))));
            this.label15.Location = new System.Drawing.Point(102, 306);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(86, 25);
            this.label15.TabIndex = 62;
            this.label15.Text = "Mobile";
            // 
            // supplierWebsiteTextBox
            // 
            this.supplierWebsiteTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.supplierWebsiteTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.supplierWebsiteTextBox.Font = new System.Drawing.Font("Verdana Pro Cond Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplierWebsiteTextBox.ForeColor = System.Drawing.Color.White;
            this.supplierWebsiteTextBox.Location = new System.Drawing.Point(212, 354);
            this.supplierWebsiteTextBox.Name = "supplierWebsiteTextBox";
            this.supplierWebsiteTextBox.ReadOnly = true;
            this.supplierWebsiteTextBox.Size = new System.Drawing.Size(417, 25);
            this.supplierWebsiteTextBox.TabIndex = 65;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(118)))), ((int)(((byte)(161)))));
            this.label16.Location = new System.Drawing.Point(102, 354);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(103, 25);
            this.label16.TabIndex = 64;
            this.label16.Text = "Website";
            // 
            // ReportsForm
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
            this.Name = "ReportsForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ReportsForm";
            this.Load += new System.EventHandler(this.ReportsForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.warehouseReportsPage.ResumeLayout(false);
            this.warehouseReportsPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.warehousesDataGridView)).EndInit();
            this.itemsReportsPage.ResumeLayout(false);
            this.itemsReportsPage.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemsDataGridView)).EndInit();
            this.suppliersReportsPage.ResumeLayout(false);
            this.suppliersReportsPage.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplierDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage warehouseReportsPage;
        private System.Windows.Forms.TabPage suppliersReportsPage;
        private System.Windows.Forms.DataGridView warehousesDataGridView;
        private System.Windows.Forms.ComboBox warehousesComboBox;
        private System.Windows.Forms.TabPage itemsReportsPage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox itemSearchBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView itemsDataGridView;
        private System.Windows.Forms.ComboBox itemsComboBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox supplierSearchBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView supplierDataGridView;
        private System.Windows.Forms.ComboBox suppliersComboBox;
        private System.Windows.Forms.TextBox warehouseNameTextBox;
        private System.Windows.Forms.TextBox warehouseSearchBar;
        private System.Windows.Forms.Label searchLbl;
        private System.Windows.Forms.TextBox warehouseManagerTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox warehouseAddressTextBox;
        private System.Windows.Forms.Label label5;
        private CustomBox.RJControls.RJRadioButton warehouseCustomersRadioBtn;
        private CustomBox.RJControls.RJRadioButton warehouseSuppliersRadioBtn;
        private CustomBox.RJControls.RJRadioButton warehouseSupplyOrdersRadioBtn;
        private CustomBox.RJControls.RJRadioButton warehouseIssuanceOrdersRadioBtn;
        private CustomBox.RJControls.RJRadioButton warehouseItemsRadioBtn;
        private System.Windows.Forms.Label label4;
        private RJCodeAdvance.RJControls.RJDatePicker toDatePicker;
        private RJCodeAdvance.RJControls.RJDatePicker fromDatePicker;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private RJCodeAdvance.RJControls.RJDatePicker itemToDatePicker;
        private RJCodeAdvance.RJControls.RJDatePicker itemFromDatePicker;
        private CustomBox.RJControls.RJRadioButton itemWarehousesRadioBtn;
        private CustomBox.RJControls.RJRadioButton itemSupplyOrdersRadioBtn;
        private CustomBox.RJControls.RJRadioButton itemIssuanceOrdersRadioBtn;
        private CustomBox.RJControls.RJRadioButton itemSuppliersRadioBtn;
        private System.Windows.Forms.TextBox ItemUnitTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox ItemCodeTextBox;
        private System.Windows.Forms.TextBox supplierWebsiteTextBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox supplierMobileTextBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox supplierEmailTextBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private RJCodeAdvance.RJControls.RJDatePicker supplierToDatePicker;
        private RJCodeAdvance.RJControls.RJDatePicker supplierFromDatePicker;
        private CustomBox.RJControls.RJRadioButton supplierWarehousesRadioBtn;
        private CustomBox.RJControls.RJRadioButton supplierSupplyOrderRadioBtn;
        private CustomBox.RJControls.RJRadioButton supplierIssuanceOrderRadioBtn;
        private CustomBox.RJControls.RJRadioButton supplierItemsRadioBtn;
        private System.Windows.Forms.TextBox supplierPhoneTextBox;
        private System.Windows.Forms.Label label13;
    }
}