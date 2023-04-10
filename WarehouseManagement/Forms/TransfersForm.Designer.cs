namespace WarehouseManagement.Forms
{
    partial class TransfersForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fromWarehouseComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.toWarehouseComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.transferButton = new RJCodeAdvance.RJControls.RJButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.fromWarehouseDataGrid = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.toWarehouseDataGrid = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fromWarehouseDataGrid)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toWarehouseDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.fromWarehouseComboBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Verdana Pro Cond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(75, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(323, 188);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "From";
            // 
            // fromWarehouseComboBox
            // 
            this.fromWarehouseComboBox.FormattingEnabled = true;
            this.fromWarehouseComboBox.Location = new System.Drawing.Point(50, 108);
            this.fromWarehouseComboBox.Name = "fromWarehouseComboBox";
            this.fromWarehouseComboBox.Size = new System.Drawing.Size(228, 33);
            this.fromWarehouseComboBox.TabIndex = 5;
            this.fromWarehouseComboBox.SelectedIndexChanged += new System.EventHandler(this.FromWarehouseComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana Pro Cond", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(118)))), ((int)(((byte)(161)))));
            this.label2.Location = new System.Drawing.Point(45, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Warehouse Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.toWarehouseComboBox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Verdana Pro Cond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(433, 65);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(323, 188);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "To";
            // 
            // toWarehouseComboBox
            // 
            this.toWarehouseComboBox.FormattingEnabled = true;
            this.toWarehouseComboBox.Location = new System.Drawing.Point(50, 108);
            this.toWarehouseComboBox.Name = "toWarehouseComboBox";
            this.toWarehouseComboBox.Size = new System.Drawing.Size(228, 33);
            this.toWarehouseComboBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana Pro Cond", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(118)))), ((int)(((byte)(161)))));
            this.label1.Location = new System.Drawing.Point(45, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "Warehouse Name";
            // 
            // transferButton
            // 
            this.transferButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.transferButton.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.transferButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.transferButton.BorderRadius = 7;
            this.transferButton.BorderSize = 0;
            this.transferButton.FlatAppearance.BorderSize = 0;
            this.transferButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.transferButton.Font = new System.Drawing.Font("Verdana Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transferButton.ForeColor = System.Drawing.Color.White;
            this.transferButton.Location = new System.Drawing.Point(1308, 780);
            this.transferButton.Name = "transferButton";
            this.transferButton.Size = new System.Drawing.Size(184, 69);
            this.transferButton.TabIndex = 10;
            this.transferButton.Text = "Transfer";
            this.transferButton.TextColor = System.Drawing.Color.White;
            this.transferButton.UseVisualStyleBackColor = false;
            this.transferButton.Click += new System.EventHandler(this.TransferButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.fromWarehouseDataGrid);
            this.groupBox3.Font = new System.Drawing.Font("Verdana Pro Cond", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(75, 292);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(681, 457);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Warehouse Items";
            // 
            // fromWarehouseDataGrid
            // 
            this.fromWarehouseDataGrid.AllowUserToAddRows = false;
            this.fromWarehouseDataGrid.AllowUserToDeleteRows = false;
            this.fromWarehouseDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.fromWarehouseDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.fromWarehouseDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fromWarehouseDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fromWarehouseDataGrid.Location = new System.Drawing.Point(3, 28);
            this.fromWarehouseDataGrid.Name = "fromWarehouseDataGrid";
            this.fromWarehouseDataGrid.ReadOnly = true;
            this.fromWarehouseDataGrid.RowHeadersWidth = 51;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.fromWarehouseDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.fromWarehouseDataGrid.RowTemplate.Height = 24;
            this.fromWarehouseDataGrid.Size = new System.Drawing.Size(675, 426);
            this.fromWarehouseDataGrid.TabIndex = 10;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.toWarehouseDataGrid);
            this.groupBox4.Font = new System.Drawing.Font("Verdana Pro Cond", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(811, 292);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(681, 457);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Warehouse Items";
            // 
            // toWarehouseDataGrid
            // 
            this.toWarehouseDataGrid.AllowUserToAddRows = false;
            this.toWarehouseDataGrid.AllowUserToDeleteRows = false;
            this.toWarehouseDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.toWarehouseDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.toWarehouseDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.toWarehouseDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toWarehouseDataGrid.Location = new System.Drawing.Point(3, 28);
            this.toWarehouseDataGrid.Name = "toWarehouseDataGrid";
            this.toWarehouseDataGrid.ReadOnly = true;
            this.toWarehouseDataGrid.RowHeadersWidth = 51;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.toWarehouseDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.toWarehouseDataGrid.RowTemplate.Height = 24;
            this.toWarehouseDataGrid.Size = new System.Drawing.Size(675, 426);
            this.toWarehouseDataGrid.TabIndex = 10;
            // 
            // TransfersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1579, 878);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.transferButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Verdana Pro", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TransfersForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "TransfersForm";
            this.Load += new System.EventHandler(this.TransfersForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fromWarehouseDataGrid)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.toWarehouseDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox fromWarehouseComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox toWarehouseComboBox;
        private System.Windows.Forms.Label label1;
        private RJCodeAdvance.RJControls.RJButton transferButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView fromWarehouseDataGrid;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView toWarehouseDataGrid;
    }
}