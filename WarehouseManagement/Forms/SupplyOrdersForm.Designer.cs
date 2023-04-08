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
            this.searchPanel = new System.Windows.Forms.Panel();
            this.dataSearchBar = new System.Windows.Forms.TextBox();
            this.searchLbl = new System.Windows.Forms.Label();
            this.supplyOrderDataGrid = new System.Windows.Forms.DataGridView();
            this.SupplyOrdersAddEditPage = new System.Windows.Forms.TabPage();
            this.addWarehousPanel = new System.Windows.Forms.Panel();
            this.itemsListPage = new System.Windows.Forms.TabPage();
            this.panel7 = new System.Windows.Forms.Panel();
            this.rjComboBox1 = new RJCodeAdvance.RJControls.RJComboBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.itemAddEditPage = new System.Windows.Forms.TabPage();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel14 = new System.Windows.Forms.Panel();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel15 = new System.Windows.Forms.Panel();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.viewItemsButton = new WarehouseManagement.CustamizedButton();
            this.editSupplyOrderButton = new WarehouseManagement.CustamizedButton();
            this.deleteSupplyOrderButton = new WarehouseManagement.CustamizedButton();
            this.AddSupplyOrderButton = new WarehouseManagement.CustamizedButton();
            this.backBtn = new WarehouseManagement.CustamizedButton();
            this.AddEditSupplyOrderBtn = new WarehouseManagement.CustamizedButton();
            this.editItemToSupplyBtn = new WarehouseManagement.CustamizedButton();
            this.deleteItemToSupplyBtn = new WarehouseManagement.CustamizedButton();
            this.addItemToSupplyBtn = new WarehouseManagement.CustamizedButton();
            this.custamizedButton1 = new WarehouseManagement.CustamizedButton();
            this.custamizedButton2 = new WarehouseManagement.CustamizedButton();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductionDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpirationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.warehouseNameLbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.supplierNameLbl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.orderDateLbl = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.rjDatePicker1 = new RJCodeAdvance.RJControls.RJDatePicker();
            this.tabControl1.SuspendLayout();
            this.SupplyOrdersListPage.SuspendLayout();
            this.supplyOrderMainPanel.SuspendLayout();
            this.searchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplyOrderDataGrid)).BeginInit();
            this.SupplyOrdersAddEditPage.SuspendLayout();
            this.addWarehousPanel.SuspendLayout();
            this.itemsListPage.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.itemAddEditPage.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.CausesValidation = false;
            this.tabControl1.Controls.Add(this.SupplyOrdersListPage);
            this.tabControl1.Controls.Add(this.SupplyOrdersAddEditPage);
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
            this.supplyOrderMainPanel.Controls.Add(this.viewItemsButton);
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
            this.supplyOrderDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SupplyOdrerDataGrid_CellClick);
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
            this.addWarehousPanel.Controls.Add(this.panel2);
            this.addWarehousPanel.Controls.Add(this.panel1);
            this.addWarehousPanel.Controls.Add(this.panel3);
            this.addWarehousPanel.Controls.Add(this.dataGridView2);
            this.addWarehousPanel.Controls.Add(this.backBtn);
            this.addWarehousPanel.Controls.Add(this.AddEditSupplyOrderBtn);
            this.addWarehousPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addWarehousPanel.Location = new System.Drawing.Point(4, 5);
            this.addWarehousPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addWarehousPanel.Name = "addWarehousPanel";
            this.addWarehousPanel.Size = new System.Drawing.Size(1563, 820);
            this.addWarehousPanel.TabIndex = 23;
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
            this.panel7.Controls.Add(this.rjComboBox1);
            this.panel7.Controls.Add(this.editItemToSupplyBtn);
            this.panel7.Controls.Add(this.deleteItemToSupplyBtn);
            this.panel7.Controls.Add(this.addItemToSupplyBtn);
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Controls.Add(this.dataGridView1);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1571, 830);
            this.panel7.TabIndex = 7;
            // 
            // rjComboBox1
            // 
            this.rjComboBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rjComboBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rjComboBox1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjComboBox1.BorderSize = 1;
            this.rjComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.rjComboBox1.Font = new System.Drawing.Font("Verdana Pro", 13.8F);
            this.rjComboBox1.ForeColor = System.Drawing.Color.DimGray;
            this.rjComboBox1.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.rjComboBox1.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.rjComboBox1.ListTextColor = System.Drawing.Color.DimGray;
            this.rjComboBox1.Location = new System.Drawing.Point(1175, 111);
            this.rjComboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rjComboBox1.MinimumSize = new System.Drawing.Size(250, 47);
            this.rjComboBox1.Name = "rjComboBox1";
            this.rjComboBox1.Padding = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.rjComboBox1.Size = new System.Drawing.Size(324, 47);
            this.rjComboBox1.TabIndex = 18;
            this.rjComboBox1.Texts = "";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.textBox2);
            this.panel8.Controls.Add(this.label2);
            this.panel8.Location = new System.Drawing.Point(121, 66);
            this.panel8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1011, 156);
            this.panel8.TabIndex = 14;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Verdana Pro", 13.8F);
            this.textBox2.Location = new System.Drawing.Point(224, 52);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(720, 35);
            this.textBox2.TabIndex = 20;
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(121, 267);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1011, 486);
            this.dataGridView1.TabIndex = 6;
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
            this.panel9.Controls.Add(this.panel10);
            this.panel9.Controls.Add(this.panel11);
            this.panel9.Controls.Add(this.panel12);
            this.panel9.Controls.Add(this.panel13);
            this.panel9.Controls.Add(this.panel14);
            this.panel9.Controls.Add(this.custamizedButton1);
            this.panel9.Controls.Add(this.custamizedButton2);
            this.panel9.Controls.Add(this.panel15);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1571, 830);
            this.panel9.TabIndex = 24;
            // 
            // panel10
            // 
            this.panel10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel10.Controls.Add(this.textBox3);
            this.panel10.Controls.Add(this.label3);
            this.panel10.Location = new System.Drawing.Point(828, 100);
            this.panel10.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(618, 128);
            this.panel10.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Verdana Pro", 13.8F);
            this.textBox3.Location = new System.Drawing.Point(351, 45);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(216, 35);
            this.textBox3.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana Pro Cond", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(118)))), ((int)(((byte)(161)))));
            this.label3.Location = new System.Drawing.Point(46, 48);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 28);
            this.label3.TabIndex = 1;
            this.label3.Text = "Supplier Name";
            // 
            // panel11
            // 
            this.panel11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel11.Controls.Add(this.textBox4);
            this.panel11.Controls.Add(this.label4);
            this.panel11.Location = new System.Drawing.Point(833, 486);
            this.panel11.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(613, 128);
            this.panel11.TabIndex = 5;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Verdana Pro", 13.8F);
            this.textBox4.Location = new System.Drawing.Point(351, 45);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(216, 35);
            this.textBox4.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana Pro Cond", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(118)))), ((int)(((byte)(161)))));
            this.label4.Location = new System.Drawing.Point(46, 48);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 28);
            this.label4.TabIndex = 1;
            this.label4.Text = "Supplier Website";
            // 
            // panel12
            // 
            this.panel12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel12.Controls.Add(this.textBox5);
            this.panel12.Controls.Add(this.label5);
            this.panel12.Location = new System.Drawing.Point(76, 486);
            this.panel12.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(618, 128);
            this.panel12.TabIndex = 4;
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Verdana Pro", 13.8F);
            this.textBox5.Location = new System.Drawing.Point(351, 45);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(216, 35);
            this.textBox5.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana Pro Cond", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(118)))), ((int)(((byte)(161)))));
            this.label5.Location = new System.Drawing.Point(46, 48);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 28);
            this.label5.TabIndex = 1;
            this.label5.Text = "Supplier Fax";
            // 
            // panel13
            // 
            this.panel13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel13.Controls.Add(this.textBox6);
            this.panel13.Controls.Add(this.label6);
            this.panel13.Location = new System.Drawing.Point(833, 293);
            this.panel13.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(613, 132);
            this.panel13.TabIndex = 8;
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Verdana Pro", 13.8F);
            this.textBox6.Location = new System.Drawing.Point(351, 45);
            this.textBox6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(216, 35);
            this.textBox6.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana Pro Cond", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(118)))), ((int)(((byte)(161)))));
            this.label6.Location = new System.Drawing.Point(46, 48);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 28);
            this.label6.TabIndex = 1;
            this.label6.Text = "Supplier Mobile";
            // 
            // panel14
            // 
            this.panel14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel14.Controls.Add(this.textBox7);
            this.panel14.Controls.Add(this.label7);
            this.panel14.Location = new System.Drawing.Point(76, 293);
            this.panel14.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(618, 132);
            this.panel14.TabIndex = 7;
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Verdana Pro", 13.8F);
            this.textBox7.Location = new System.Drawing.Point(351, 45);
            this.textBox7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(216, 35);
            this.textBox7.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana Pro Cond", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(118)))), ((int)(((byte)(161)))));
            this.label7.Location = new System.Drawing.Point(46, 48);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(169, 28);
            this.label7.TabIndex = 1;
            this.label7.Text = "Supplier Phone";
            // 
            // panel15
            // 
            this.panel15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel15.Controls.Add(this.textBox8);
            this.panel15.Controls.Add(this.label8);
            this.panel15.Location = new System.Drawing.Point(76, 100);
            this.panel15.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(618, 128);
            this.panel15.TabIndex = 1;
            // 
            // textBox8
            // 
            this.textBox8.Font = new System.Drawing.Font("Verdana Pro", 13.8F);
            this.textBox8.Location = new System.Drawing.Point(351, 45);
            this.textBox8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(216, 35);
            this.textBox8.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana Pro Cond", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(118)))), ((int)(((byte)(161)))));
            this.label8.Location = new System.Drawing.Point(46, 48);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(164, 28);
            this.label8.TabIndex = 1;
            this.label8.Text = "Supplier Name";
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
            this.editSupplyOrderButton.Location = new System.Drawing.Point(1190, 528);
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
            this.deleteSupplyOrderButton.Location = new System.Drawing.Point(1190, 679);
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
            this.AddSupplyOrderButton.Location = new System.Drawing.Point(1190, 370);
            this.AddSupplyOrderButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddSupplyOrderButton.Name = "AddSupplyOrderButton";
            this.AddSupplyOrderButton.Size = new System.Drawing.Size(305, 109);
            this.AddSupplyOrderButton.TabIndex = 15;
            this.AddSupplyOrderButton.Text = "Add Supply Order";
            this.AddSupplyOrderButton.TextColor = System.Drawing.Color.White;
            this.AddSupplyOrderButton.UseVisualStyleBackColor = false;
            this.AddSupplyOrderButton.Click += new System.EventHandler(this.AddSupplyOrderButton_Click);
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
            // editItemToSupplyBtn
            // 
            this.editItemToSupplyBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.editItemToSupplyBtn.BackColor = System.Drawing.Color.LightSlateGray;
            this.editItemToSupplyBtn.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.editItemToSupplyBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.editItemToSupplyBtn.BorderRadius = 7;
            this.editItemToSupplyBtn.BorderSize = 0;
            this.editItemToSupplyBtn.FlatAppearance.BorderSize = 0;
            this.editItemToSupplyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editItemToSupplyBtn.Font = new System.Drawing.Font("Verdana Pro Cond", 13.8F, System.Drawing.FontStyle.Bold);
            this.editItemToSupplyBtn.ForeColor = System.Drawing.Color.White;
            this.editItemToSupplyBtn.Location = new System.Drawing.Point(1194, 451);
            this.editItemToSupplyBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.editItemToSupplyBtn.Name = "editItemToSupplyBtn";
            this.editItemToSupplyBtn.Size = new System.Drawing.Size(305, 109);
            this.editItemToSupplyBtn.TabIndex = 17;
            this.editItemToSupplyBtn.Text = "Edit Item";
            this.editItemToSupplyBtn.TextColor = System.Drawing.Color.White;
            this.editItemToSupplyBtn.UseVisualStyleBackColor = false;
            // 
            // deleteItemToSupplyBtn
            // 
            this.deleteItemToSupplyBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deleteItemToSupplyBtn.BackColor = System.Drawing.Color.Crimson;
            this.deleteItemToSupplyBtn.BackgroundColor = System.Drawing.Color.Crimson;
            this.deleteItemToSupplyBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.deleteItemToSupplyBtn.BorderRadius = 7;
            this.deleteItemToSupplyBtn.BorderSize = 0;
            this.deleteItemToSupplyBtn.FlatAppearance.BorderSize = 0;
            this.deleteItemToSupplyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteItemToSupplyBtn.Font = new System.Drawing.Font("Verdana Pro Cond", 13.8F, System.Drawing.FontStyle.Bold);
            this.deleteItemToSupplyBtn.ForeColor = System.Drawing.Color.White;
            this.deleteItemToSupplyBtn.Location = new System.Drawing.Point(1194, 622);
            this.deleteItemToSupplyBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.deleteItemToSupplyBtn.Name = "deleteItemToSupplyBtn";
            this.deleteItemToSupplyBtn.Size = new System.Drawing.Size(305, 109);
            this.deleteItemToSupplyBtn.TabIndex = 16;
            this.deleteItemToSupplyBtn.Text = "Delete Item";
            this.deleteItemToSupplyBtn.TextColor = System.Drawing.Color.White;
            this.deleteItemToSupplyBtn.UseVisualStyleBackColor = false;
            // 
            // addItemToSupplyBtn
            // 
            this.addItemToSupplyBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addItemToSupplyBtn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.addItemToSupplyBtn.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.addItemToSupplyBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.addItemToSupplyBtn.BorderRadius = 7;
            this.addItemToSupplyBtn.BorderSize = 0;
            this.addItemToSupplyBtn.FlatAppearance.BorderSize = 0;
            this.addItemToSupplyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addItemToSupplyBtn.Font = new System.Drawing.Font("Verdana Pro Cond", 13.8F, System.Drawing.FontStyle.Bold);
            this.addItemToSupplyBtn.ForeColor = System.Drawing.Color.White;
            this.addItemToSupplyBtn.Location = new System.Drawing.Point(1194, 288);
            this.addItemToSupplyBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addItemToSupplyBtn.Name = "addItemToSupplyBtn";
            this.addItemToSupplyBtn.Size = new System.Drawing.Size(305, 109);
            this.addItemToSupplyBtn.TabIndex = 15;
            this.addItemToSupplyBtn.Text = "Add Item";
            this.addItemToSupplyBtn.TextColor = System.Drawing.Color.White;
            this.addItemToSupplyBtn.UseVisualStyleBackColor = false;
            // 
            // custamizedButton1
            // 
            this.custamizedButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.custamizedButton1.BackColor = System.Drawing.Color.LightSlateGray;
            this.custamizedButton1.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.custamizedButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.custamizedButton1.BorderRadius = 7;
            this.custamizedButton1.BorderSize = 0;
            this.custamizedButton1.FlatAppearance.BorderSize = 0;
            this.custamizedButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.custamizedButton1.Font = new System.Drawing.Font("Verdana Pro Cond", 13.8F, System.Drawing.FontStyle.Bold);
            this.custamizedButton1.ForeColor = System.Drawing.Color.White;
            this.custamizedButton1.Location = new System.Drawing.Point(884, 661);
            this.custamizedButton1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.custamizedButton1.Name = "custamizedButton1";
            this.custamizedButton1.Size = new System.Drawing.Size(222, 80);
            this.custamizedButton1.TabIndex = 6;
            this.custamizedButton1.Text = "Back";
            this.custamizedButton1.TextColor = System.Drawing.Color.White;
            this.custamizedButton1.UseVisualStyleBackColor = false;
            // 
            // custamizedButton2
            // 
            this.custamizedButton2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.custamizedButton2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.custamizedButton2.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.custamizedButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.custamizedButton2.BorderRadius = 7;
            this.custamizedButton2.BorderSize = 0;
            this.custamizedButton2.FlatAppearance.BorderSize = 0;
            this.custamizedButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.custamizedButton2.Font = new System.Drawing.Font("Verdana Pro Cond", 13.8F, System.Drawing.FontStyle.Bold);
            this.custamizedButton2.ForeColor = System.Drawing.Color.White;
            this.custamizedButton2.Location = new System.Drawing.Point(1155, 661);
            this.custamizedButton2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.custamizedButton2.Name = "custamizedButton2";
            this.custamizedButton2.Size = new System.Drawing.Size(222, 80);
            this.custamizedButton2.TabIndex = 5;
            this.custamizedButton2.Text = "Save";
            this.custamizedButton2.TextColor = System.Drawing.Color.White;
            this.custamizedButton2.UseVisualStyleBackColor = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Item,
            this.Quantity,
            this.ProductionDate,
            this.ExpirationDate});
            this.dataGridView2.Location = new System.Drawing.Point(72, 296);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1370, 316);
            this.dataGridView2.TabIndex = 9;
            // 
            // Item
            // 
            this.Item.HeaderText = "Item";
            this.Item.MinimumWidth = 6;
            this.Item.Name = "Item";
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            // 
            // ProductionDate
            // 
            this.ProductionDate.HeaderText = "Production Date";
            this.ProductionDate.MinimumWidth = 6;
            this.ProductionDate.Name = "ProductionDate";
            // 
            // ExpirationDate
            // 
            this.ExpirationDate.HeaderText = "Expiration Date";
            this.ExpirationDate.MinimumWidth = 6;
            this.ExpirationDate.Name = "ExpirationDate";
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.Controls.Add(this.comboBox1);
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
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.comboBox2);
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
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.Controls.Add(this.rjDatePicker1);
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
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(51, 109);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(228, 33);
            this.comboBox1.TabIndex = 3;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(51, 109);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(228, 33);
            this.comboBox2.TabIndex = 4;
            // 
            // rjDatePicker1
            // 
            this.rjDatePicker1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjDatePicker1.BorderSize = 0;
            this.rjDatePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.rjDatePicker1.Location = new System.Drawing.Point(51, 109);
            this.rjDatePicker1.MinimumSize = new System.Drawing.Size(0, 35);
            this.rjDatePicker1.Name = "rjDatePicker1";
            this.rjDatePicker1.Size = new System.Drawing.Size(232, 35);
            this.rjDatePicker1.SkinColor = System.Drawing.Color.Thistle;
            this.rjDatePicker1.TabIndex = 11;
            this.rjDatePicker1.TextColor = System.Drawing.Color.White;
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
            this.itemsListPage.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.itemAddEditPage.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private CustamizedButton backBtn;
        private CustamizedButton AddEditSupplyOrderBtn;
        private CustamizedButton viewItemsButton;
        private System.Windows.Forms.TabPage itemsListPage;
        private System.Windows.Forms.Panel panel7;
        private RJCodeAdvance.RJControls.RJComboBox rjComboBox1;
        private CustamizedButton editItemToSupplyBtn;
        private CustamizedButton deleteItemToSupplyBtn;
        private CustamizedButton addItemToSupplyBtn;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage itemAddEditPage;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label7;
        private CustamizedButton custamizedButton1;
        private CustamizedButton custamizedButton2;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductionDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpirationDate;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label warehouseNameLbl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label orderDateLbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label supplierNameLbl;
        private RJCodeAdvance.RJControls.RJDatePicker rjDatePicker1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}