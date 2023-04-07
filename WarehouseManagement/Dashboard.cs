using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using WarehouseManagement.Forms;
using Color = System.Drawing.Color;

namespace WarehouseManagement
{
    public partial class Dashboard : Form
    {
        private IconButton currentButton;
        private Panel leftBorderButton;
        private Color activeColor = Color.FromArgb(252, 118, 161);
        private Form currentChildForm;

        public Dashboard()
        {
            InitializeComponent();
            leftBorderButton = new Panel();
            leftBorderButton.Size = new Size(7, 60);
            panel1.Controls.Add(leftBorderButton);

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

        }

        private void ActiveButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                currentButton = (IconButton)senderBtn;
                currentButton.BackColor = Color.FromArgb(23, 24, 31);
                currentButton.ForeColor = Color.FromArgb(213, 213, 215);
                currentButton.TextAlign = ContentAlignment.MiddleLeft;
                currentButton.IconColor = color;
                currentButton.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentButton.ImageAlign = ContentAlignment.MiddleLeft;
                leftBorderButton.BackColor = color;
                leftBorderButton.Location = new Point(0, currentButton.Location.Y);
                leftBorderButton.Visible = true;
                leftBorderButton.BringToFront();

                currentChildFormIcon.IconChar = currentButton.IconChar;
                currentChildFormIcon.IconColor = color;

            }

        }

        public void DisableButton()
        {
            if (currentButton != null)
            {
                currentButton.BackColor = Color.FromArgb(33, 33, 43);
                currentButton.ForeColor = Color.FromArgb(213, 213, 215);
                currentButton.TextAlign = ContentAlignment.MiddleLeft;
                currentButton.IconColor = Color.FromArgb(252, 118, 161);
                currentButton.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentButton.ImageAlign = ContentAlignment.MiddleLeft;

            }
        }


        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitleChildForm.Text = childForm.Text;
        }


        private void warehouseButton_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, activeColor);
            OpenChildForm(new WarehouseForm());

        }

        private void itemsButton_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, activeColor);
            OpenChildForm(new ItemsForm());

        }

        private void suppliersButton_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, activeColor);
            OpenChildForm(new SuppliersForm());


        }

        private void customersButton_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, activeColor);
            OpenChildForm(new CustomersForm());

        }

        private void supplyOrdersButton_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, activeColor);
            OpenChildForm(new SupplyOrdersForm());

        }
        private void issuanceOrdersButton_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, activeColor);
            OpenChildForm(new IssuanceOrdersForm());




        }
        private void transfersButton_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, activeColor);
            OpenChildForm(new TransfersForm());

        }

        private void reportsButton_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, activeColor);
            OpenChildForm(new ReportsForm());

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            currentChildForm?.Close();
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            leftBorderButton.Visible = false;
            currentChildFormIcon.IconChar = IconChar.Home;
            currentChildFormIcon.IconColor = Color.FromArgb(252, 118, 161);
            lblTitleChildForm.Text = "Home";
        }


        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }



        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }


    }
}
