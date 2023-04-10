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
            this.panel1 = new System.Windows.Forms.Panel();
            this.itemSearchBar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.itemsComboBox = new System.Windows.Forms.ComboBox();
            this.suppliersReportsPage = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.supplierSearchBar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.suppliersComboBox = new System.Windows.Forms.ComboBox();
            this.customersReportsPage = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.customerSearchBar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.customersComboBox = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.warehouseReportsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.warehousesDataGridView)).BeginInit();
            this.itemsReportsPage.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.suppliersReportsPage.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.customersReportsPage.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.warehouseReportsPage);
            this.tabControl1.Controls.Add(this.itemsReportsPage);
            this.tabControl1.Controls.Add(this.suppliersReportsPage);
            this.tabControl1.Controls.Add(this.customersReportsPage);
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
            this.itemsReportsPage.Controls.Add(this.panel1);
            this.itemsReportsPage.Controls.Add(this.dataGridView2);
            this.itemsReportsPage.Controls.Add(this.itemsComboBox);
            this.itemsReportsPage.Location = new System.Drawing.Point(4, 34);
            this.itemsReportsPage.Name = "itemsReportsPage";
            this.itemsReportsPage.Padding = new System.Windows.Forms.Padding(3);
            this.itemsReportsPage.Size = new System.Drawing.Size(1571, 840);
            this.itemsReportsPage.TabIndex = 1;
            this.itemsReportsPage.Text = "Items Reports";
            this.itemsReportsPage.Enter += new System.EventHandler(this.ItemsReportsPage_Enter);
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
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(107, 215);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1356, 575);
            this.dataGridView2.TabIndex = 17;
            // 
            // itemsComboBox
            // 
            this.itemsComboBox.FormattingEnabled = true;
            this.itemsComboBox.Location = new System.Drawing.Point(895, 96);
            this.itemsComboBox.Name = "itemsComboBox";
            this.itemsComboBox.Size = new System.Drawing.Size(568, 33);
            this.itemsComboBox.TabIndex = 16;
            // 
            // suppliersReportsPage
            // 
            this.suppliersReportsPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.suppliersReportsPage.Controls.Add(this.panel2);
            this.suppliersReportsPage.Controls.Add(this.dataGridView3);
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
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(107, 215);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(1356, 575);
            this.dataGridView3.TabIndex = 20;
            // 
            // suppliersComboBox
            // 
            this.suppliersComboBox.FormattingEnabled = true;
            this.suppliersComboBox.Location = new System.Drawing.Point(895, 96);
            this.suppliersComboBox.Name = "suppliersComboBox";
            this.suppliersComboBox.Size = new System.Drawing.Size(568, 33);
            this.suppliersComboBox.TabIndex = 19;
            // 
            // customersReportsPage
            // 
            this.customersReportsPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.customersReportsPage.Controls.Add(this.panel3);
            this.customersReportsPage.Controls.Add(this.dataGridView4);
            this.customersReportsPage.Controls.Add(this.customersComboBox);
            this.customersReportsPage.Location = new System.Drawing.Point(4, 34);
            this.customersReportsPage.Name = "customersReportsPage";
            this.customersReportsPage.Size = new System.Drawing.Size(1571, 840);
            this.customersReportsPage.TabIndex = 3;
            this.customersReportsPage.Text = "Customer Reports";
            this.customersReportsPage.Enter += new System.EventHandler(this.CustomersReportsPage_Enter);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.customerSearchBar);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(107, 50);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(742, 130);
            this.panel3.TabIndex = 21;
            // 
            // customerSearchBar
            // 
            this.customerSearchBar.Font = new System.Drawing.Font("Verdana Pro", 13.8F);
            this.customerSearchBar.Location = new System.Drawing.Point(151, 46);
            this.customerSearchBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.customerSearchBar.Name = "customerSearchBar";
            this.customerSearchBar.Size = new System.Drawing.Size(562, 35);
            this.customerSearchBar.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(118)))), ((int)(((byte)(161)))));
            this.label3.Location = new System.Drawing.Point(25, 51);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 28);
            this.label3.TabIndex = 16;
            this.label3.Text = "Search";
            // 
            // dataGridView4
            // 
            this.dataGridView4.AllowUserToAddRows = false;
            this.dataGridView4.AllowUserToDeleteRows = false;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(107, 215);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.ReadOnly = true;
            this.dataGridView4.RowHeadersWidth = 51;
            this.dataGridView4.RowTemplate.Height = 24;
            this.dataGridView4.Size = new System.Drawing.Size(1356, 575);
            this.dataGridView4.TabIndex = 20;
            // 
            // customersComboBox
            // 
            this.customersComboBox.FormattingEnabled = true;
            this.customersComboBox.Location = new System.Drawing.Point(895, 96);
            this.customersComboBox.Name = "customersComboBox";
            this.customersComboBox.Size = new System.Drawing.Size(568, 33);
            this.customersComboBox.TabIndex = 19;
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.suppliersReportsPage.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.customersReportsPage.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage warehouseReportsPage;
        private System.Windows.Forms.TabPage suppliersReportsPage;
        private System.Windows.Forms.TabPage customersReportsPage;
        private System.Windows.Forms.DataGridView warehousesDataGridView;
        private System.Windows.Forms.ComboBox warehousesComboBox;
        private System.Windows.Forms.TabPage itemsReportsPage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox itemSearchBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ComboBox itemsComboBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox supplierSearchBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.ComboBox suppliersComboBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox customerSearchBar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.ComboBox customersComboBox;
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
    }
}