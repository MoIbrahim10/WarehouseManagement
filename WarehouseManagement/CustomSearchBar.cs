using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace WarehouseManagement
{


    public class CustomSearchBar : TextBox
    {

        #region Fields

        private int iconSize = 20;
        private int iconSpacing = 5;
        private Image icon;
        private Color borderColor = Color.Gray;
        private int borderRadius = 10;
        private int borderWidth = 1;
        private int minHeight = 30;
        private bool isResizing = false;
        private int resizeMargin = 5;

        #endregion

        #region Properties

        [Category("Custom SearchBar")]
        public Image Icon
        {
            get { return icon; }
            set
            {
                icon = value;
                Invalidate();
            }
        }

        [Category("Custom SearchBar")]
        public int IconSize
        {
            get { return iconSize; }
            set
            {
                iconSize = value;
                Invalidate();
            }
        }

        [Category("Custom SearchBar")]
        public int IconSpacing
        {
            get { return iconSpacing; }
            set
            {
                iconSpacing = value;
                Invalidate();
            }
        }

        [Category("Custom SearchBar")]
        public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value;
                Invalidate();
            }
        }

        [Category("Custom SearchBar")]
        public int BorderRadius
        {
            get { return borderRadius; }
            set
            {
                borderRadius = value;
                Invalidate();
            }
        }

        [Category("Custom SearchBar")]
        public int BorderWidth
        {
            get { return borderWidth; }
            set
            {
                borderWidth = value;
                Invalidate();
            }
        }

        [Category("Custom SearchBar")]
        public int MinHeight
        {
            get { return minHeight; }
            set
            {
                minHeight = value;
                Invalidate();
            }
        }

        #endregion

        #region Constructor

        public CustomSearchBar()
        {
            SetStyle(ControlStyles.ResizeRedraw, true);
            Resize += CustomSearchBar_Resize;
            MouseDown += CustomSearchBar_MouseDown;
            MouseUp += CustomSearchBar_MouseUp;
            MouseMove += CustomSearchBar_MouseMove;
            Padding = new Padding(iconSize + iconSpacing, 0, 0, 0);
        }

        #endregion

        #region Methods

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (Icon != null)
            {
                int x = Padding.Left - iconSpacing - iconSize;
                int y = (Height - IconSize) / 2;
                e.Graphics.DrawImage(Icon, x, y, IconSize, IconSize);
            }

            using (var pen = new Pen(BorderColor, BorderWidth))
            using (var path = GetRoundPath(ClientRectangle, BorderRadius))
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                e.Graphics.DrawPath(pen, path);
            }
        }
        public static GraphicsPath GetRoundPath(RectangleF rect, int radius)
        {
            GraphicsPath roundPath = new GraphicsPath();

            if (radius <= 0)
            {
                roundPath.AddRectangle(rect);
                return roundPath;
            }

            roundPath.AddArc(rect.X, rect.Y, radius * 2, radius * 2, 180, 90);
            roundPath.AddArc(rect.X + rect.Width - radius * 2, rect.Y, radius * 2, radius * 2, 270, 90);
            roundPath.AddArc(rect.X + rect.Width - radius * 2, rect.Y + rect.Height - radius * 2, radius * 2, radius * 2, 0, 90);
            roundPath.AddArc(rect.X, rect.Y + rect.Height - radius * 2, radius * 2, radius * 2, 90, 90);

            roundPath.CloseFigure();

            return roundPath;
        }


        private void CustomSearchBar_Resize(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void CustomSearchBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && e.X > Width - resizeMargin && e.Y > Height - resizeMargin)
            {
                isResizing = true;
            }
        }

        private void CustomSearchBar_MouseUp(object sender, MouseEventArgs e)
        {
            isResizing = false;
        }

        private void CustomSearchBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (isResizing)
            {
                Height = e.Y + resizeMargin;
            }
        }

        #endregion
    }
}
