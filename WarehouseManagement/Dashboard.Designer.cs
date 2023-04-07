namespace WarehouseManagement
{
    partial class Dashboard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.reportsButton = new FontAwesome.Sharp.IconButton();
            this.transfersButtons = new FontAwesome.Sharp.IconButton();
            this.issuanceOrdersButton = new FontAwesome.Sharp.IconButton();
            this.supplyOrdersButton = new FontAwesome.Sharp.IconButton();
            this.customersButton = new FontAwesome.Sharp.IconButton();
            this.suppliersButton = new FontAwesome.Sharp.IconButton();
            this.itemsButton = new FontAwesome.Sharp.IconButton();
            this.warehouseButton = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.minimizeBtn = new FontAwesome.Sharp.IconPictureBox();
            this.exitBtn = new FontAwesome.Sharp.IconPictureBox();
            this.maximizeBtn = new FontAwesome.Sharp.IconPictureBox();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.currentChildFormIcon = new FontAwesome.Sharp.IconPictureBox();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximizeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentChildFormIcon)).BeginInit();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(43)))));
            this.panel1.Controls.Add(this.reportsButton);
            this.panel1.Controls.Add(this.transfersButtons);
            this.panel1.Controls.Add(this.issuanceOrdersButton);
            this.panel1.Controls.Add(this.supplyOrdersButton);
            this.panel1.Controls.Add(this.customersButton);
            this.panel1.Controls.Add(this.suppliersButton);
            this.panel1.Controls.Add(this.itemsButton);
            this.panel1.Controls.Add(this.warehouseButton);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 953);
            this.panel1.TabIndex = 0;
            // 
            // reportsButton
            // 
            this.reportsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.reportsButton.FlatAppearance.BorderSize = 0;
            this.reportsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reportsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(215)))));
            this.reportsButton.IconChar = FontAwesome.Sharp.IconChar.FileInvoice;
            this.reportsButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(118)))), ((int)(((byte)(161)))));
            this.reportsButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.reportsButton.IconSize = 32;
            this.reportsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reportsButton.Location = new System.Drawing.Point(0, 560);
            this.reportsButton.Name = "reportsButton";
            this.reportsButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.reportsButton.Size = new System.Drawing.Size(230, 60);
            this.reportsButton.TabIndex = 8;
            this.reportsButton.Text = "Reports";
            this.reportsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reportsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.reportsButton.UseVisualStyleBackColor = true;
            this.reportsButton.Click += new System.EventHandler(this.reportsButton_Click);
            // 
            // transfersButtons
            // 
            this.transfersButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.transfersButtons.FlatAppearance.BorderSize = 0;
            this.transfersButtons.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.transfersButtons.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(215)))));
            this.transfersButtons.IconChar = FontAwesome.Sharp.IconChar.ArrowRightFromFile;
            this.transfersButtons.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(118)))), ((int)(((byte)(161)))));
            this.transfersButtons.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.transfersButtons.IconSize = 32;
            this.transfersButtons.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.transfersButtons.Location = new System.Drawing.Point(0, 500);
            this.transfersButtons.Name = "transfersButtons";
            this.transfersButtons.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.transfersButtons.Size = new System.Drawing.Size(230, 60);
            this.transfersButtons.TabIndex = 7;
            this.transfersButtons.Text = "Transfers";
            this.transfersButtons.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.transfersButtons.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.transfersButtons.UseVisualStyleBackColor = true;
            this.transfersButtons.Click += new System.EventHandler(this.transfersButton_Click);
            // 
            // issuanceOrdersButton
            // 
            this.issuanceOrdersButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.issuanceOrdersButton.FlatAppearance.BorderSize = 0;
            this.issuanceOrdersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.issuanceOrdersButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(215)))));
            this.issuanceOrdersButton.IconChar = FontAwesome.Sharp.IconChar.ClipboardQuestion;
            this.issuanceOrdersButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(118)))), ((int)(((byte)(161)))));
            this.issuanceOrdersButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.issuanceOrdersButton.IconSize = 32;
            this.issuanceOrdersButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.issuanceOrdersButton.Location = new System.Drawing.Point(0, 440);
            this.issuanceOrdersButton.Name = "issuanceOrdersButton";
            this.issuanceOrdersButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.issuanceOrdersButton.Size = new System.Drawing.Size(230, 60);
            this.issuanceOrdersButton.TabIndex = 6;
            this.issuanceOrdersButton.Text = "Issuance Orders";
            this.issuanceOrdersButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.issuanceOrdersButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.issuanceOrdersButton.UseVisualStyleBackColor = true;
            this.issuanceOrdersButton.Click += new System.EventHandler(this.issuanceOrdersButton_Click);
            // 
            // supplyOrdersButton
            // 
            this.supplyOrdersButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.supplyOrdersButton.FlatAppearance.BorderSize = 0;
            this.supplyOrdersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.supplyOrdersButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(215)))));
            this.supplyOrdersButton.IconChar = FontAwesome.Sharp.IconChar.PeopleCarryBox;
            this.supplyOrdersButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(118)))), ((int)(((byte)(161)))));
            this.supplyOrdersButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.supplyOrdersButton.IconSize = 32;
            this.supplyOrdersButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.supplyOrdersButton.Location = new System.Drawing.Point(0, 380);
            this.supplyOrdersButton.Name = "supplyOrdersButton";
            this.supplyOrdersButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.supplyOrdersButton.Size = new System.Drawing.Size(230, 60);
            this.supplyOrdersButton.TabIndex = 5;
            this.supplyOrdersButton.Text = "Supply Orders";
            this.supplyOrdersButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.supplyOrdersButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.supplyOrdersButton.UseVisualStyleBackColor = true;
            this.supplyOrdersButton.Click += new System.EventHandler(this.supplyOrdersButton_Click);
            // 
            // customersButton
            // 
            this.customersButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.customersButton.FlatAppearance.BorderSize = 0;
            this.customersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customersButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(215)))));
            this.customersButton.IconChar = FontAwesome.Sharp.IconChar.PeopleLine;
            this.customersButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(118)))), ((int)(((byte)(161)))));
            this.customersButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.customersButton.IconSize = 32;
            this.customersButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customersButton.Location = new System.Drawing.Point(0, 320);
            this.customersButton.Name = "customersButton";
            this.customersButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.customersButton.Size = new System.Drawing.Size(230, 60);
            this.customersButton.TabIndex = 4;
            this.customersButton.Text = "Customers";
            this.customersButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customersButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.customersButton.UseVisualStyleBackColor = true;
            this.customersButton.Click += new System.EventHandler(this.customersButton_Click);
            // 
            // suppliersButton
            // 
            this.suppliersButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.suppliersButton.FlatAppearance.BorderSize = 0;
            this.suppliersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.suppliersButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(215)))));
            this.suppliersButton.IconChar = FontAwesome.Sharp.IconChar.Truck;
            this.suppliersButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(118)))), ((int)(((byte)(161)))));
            this.suppliersButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.suppliersButton.IconSize = 32;
            this.suppliersButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.suppliersButton.Location = new System.Drawing.Point(0, 260);
            this.suppliersButton.Name = "suppliersButton";
            this.suppliersButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.suppliersButton.Size = new System.Drawing.Size(230, 60);
            this.suppliersButton.TabIndex = 3;
            this.suppliersButton.Text = "Suppliers";
            this.suppliersButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.suppliersButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.suppliersButton.UseVisualStyleBackColor = true;
            this.suppliersButton.Click += new System.EventHandler(this.suppliersButton_Click);
            // 
            // itemsButton
            // 
            this.itemsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.itemsButton.FlatAppearance.BorderSize = 0;
            this.itemsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(215)))));
            this.itemsButton.IconChar = FontAwesome.Sharp.IconChar.BoxOpen;
            this.itemsButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(118)))), ((int)(((byte)(161)))));
            this.itemsButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.itemsButton.IconSize = 32;
            this.itemsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.itemsButton.Location = new System.Drawing.Point(0, 200);
            this.itemsButton.Name = "itemsButton";
            this.itemsButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.itemsButton.Size = new System.Drawing.Size(230, 60);
            this.itemsButton.TabIndex = 2;
            this.itemsButton.Text = "Items";
            this.itemsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.itemsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.itemsButton.UseVisualStyleBackColor = true;
            this.itemsButton.Click += new System.EventHandler(this.itemsButton_Click);
            // 
            // warehouseButton
            // 
            this.warehouseButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.warehouseButton.FlatAppearance.BorderSize = 0;
            this.warehouseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.warehouseButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(215)))));
            this.warehouseButton.IconChar = FontAwesome.Sharp.IconChar.Warehouse;
            this.warehouseButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(118)))), ((int)(((byte)(161)))));
            this.warehouseButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.warehouseButton.IconSize = 32;
            this.warehouseButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.warehouseButton.Location = new System.Drawing.Point(0, 140);
            this.warehouseButton.Name = "warehouseButton";
            this.warehouseButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.warehouseButton.Size = new System.Drawing.Size(230, 60);
            this.warehouseButton.TabIndex = 1;
            this.warehouseButton.Text = "Warehouse";
            this.warehouseButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.warehouseButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.warehouseButton.UseVisualStyleBackColor = true;
            this.warehouseButton.Click += new System.EventHandler(this.warehouseButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(230, 140);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WarehouseManagement.Properties.Resources._8256355587_ba991757_8b66_4233_a6b9_c7ac6883c312;
            this.pictureBox1.Location = new System.Drawing.Point(12, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(43)))));
            this.panelTitleBar.Controls.Add(this.minimizeBtn);
            this.panelTitleBar.Controls.Add(this.exitBtn);
            this.panelTitleBar.Controls.Add(this.maximizeBtn);
            this.panelTitleBar.Controls.Add(this.lblTitleChildForm);
            this.panelTitleBar.Controls.Add(this.currentChildFormIcon);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(230, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1579, 75);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // minimizeBtn
            // 
            this.minimizeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(43)))));
            this.minimizeBtn.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.minimizeBtn.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.minimizeBtn.IconColor = System.Drawing.SystemColors.ActiveBorder;
            this.minimizeBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.minimizeBtn.Location = new System.Drawing.Point(1411, 19);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.Size = new System.Drawing.Size(32, 33);
            this.minimizeBtn.TabIndex = 5;
            this.minimizeBtn.TabStop = false;
            this.minimizeBtn.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(43)))));
            this.exitBtn.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.exitBtn.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.exitBtn.IconColor = System.Drawing.SystemColors.ActiveBorder;
            this.exitBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.exitBtn.Location = new System.Drawing.Point(1514, 19);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(32, 33);
            this.exitBtn.TabIndex = 4;
            this.exitBtn.TabStop = false;
            this.exitBtn.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // maximizeBtn
            // 
            this.maximizeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximizeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(43)))));
            this.maximizeBtn.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.maximizeBtn.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.maximizeBtn.IconColor = System.Drawing.SystemColors.ActiveBorder;
            this.maximizeBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.maximizeBtn.Location = new System.Drawing.Point(1466, 19);
            this.maximizeBtn.Name = "maximizeBtn";
            this.maximizeBtn.Size = new System.Drawing.Size(32, 33);
            this.maximizeBtn.TabIndex = 3;
            this.maximizeBtn.TabStop = false;
            this.maximizeBtn.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblTitleChildForm.Location = new System.Drawing.Point(93, 27);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(70, 25);
            this.lblTitleChildForm.TabIndex = 1;
            this.lblTitleChildForm.Text = "Home";
            // 
            // currentChildFormIcon
            // 
            this.currentChildFormIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(43)))));
            this.currentChildFormIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(118)))), ((int)(((byte)(161)))));
            this.currentChildFormIcon.IconChar = FontAwesome.Sharp.IconChar.HomeLg;
            this.currentChildFormIcon.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(118)))), ((int)(((byte)(161)))));
            this.currentChildFormIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.currentChildFormIcon.IconSize = 31;
            this.currentChildFormIcon.Location = new System.Drawing.Point(54, 25);
            this.currentChildFormIcon.Name = "currentChildFormIcon";
            this.currentChildFormIcon.Size = new System.Drawing.Size(33, 31);
            this.currentChildFormIcon.TabIndex = 0;
            this.currentChildFormIcon.TabStop = false;
            // 
            // panelDesktop
            // 
            this.panelDesktop.Controls.Add(this.label2);
            this.panelDesktop.Controls.Add(this.label1);
            this.panelDesktop.Controls.Add(this.pictureBox2);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(230, 75);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1579, 878);
            this.panelDesktop.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana Pro", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(812, 682);
            this.label2.MaximumSize = new System.Drawing.Size(800, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(758, 72);
            this.label2.TabIndex = 3;
            this.label2.Text = "Our software helps you track and manage your inventory with ease, saving you time" +
    " and money";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana Pro", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(801, 253);
            this.label1.MaximumSize = new System.Drawing.Size(800, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(796, 402);
            this.label1.TabIndex = 1;
            this.label1.Text = "Streamline your warehouse management with SupplyPro.";
            this.label1.UseCompatibleTextRendering = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = global::WarehouseManagement.Properties.Resources.Checking_boxes_amico1;
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(16, 82);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(701, 764);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1809, 953);
            this.ControlBox = false;
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Verdana Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Warehouse Management System";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximizeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentChildFormIcon)).EndInit();
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton reportsButton;
        private FontAwesome.Sharp.IconButton transfersButtons;
        private FontAwesome.Sharp.IconButton issuanceOrdersButton;
        private FontAwesome.Sharp.IconButton supplyOrdersButton;
        private FontAwesome.Sharp.IconButton customersButton;
        private FontAwesome.Sharp.IconButton suppliersButton;
        private FontAwesome.Sharp.IconButton itemsButton;
        private FontAwesome.Sharp.IconButton warehouseButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label lblTitleChildForm;
        private FontAwesome.Sharp.IconPictureBox currentChildFormIcon;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconPictureBox minimizeBtn;
        private FontAwesome.Sharp.IconPictureBox exitBtn;
        private FontAwesome.Sharp.IconPictureBox maximizeBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}