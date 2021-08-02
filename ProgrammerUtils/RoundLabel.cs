using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ProgrammerUtils
{
    public partial class RoundLabel : Label
    {
        [Browsable(true)]
        public Color RoundedBackColor
        { 
            get
            {
                return _roundedBackColor;
            }
            set
            {
                _roundedBackColor = value;
                Invalidate();
            }
        }
        [Browsable(true)]
        public int CornerRadius
        {
            get
            {
                return _cornerRadius;
            }
            set
            {
                _cornerRadius = value;
                Invalidate();
            }
        }

        private Color _roundedBackColor;
        private int _cornerRadius = 15;

        public RoundLabel()
        {
            InitializeComponent();
            DoubleBuffered = true;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            using (var graphicsPath = GetRoundRectangle(ClientRectangle, CornerRadius))
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                using (var brush = new SolidBrush(RoundedBackColor))
                    e.Graphics.FillPath(brush, graphicsPath);
                using (var pen = new Pen(RoundedBackColor, 1.0f))
                    e.Graphics.DrawPath(pen, graphicsPath);
                TextRenderer.DrawText(e.Graphics, Text, this.Font, this.ClientRectangle, this.ForeColor);
            }
        }

        private GraphicsPath GetRoundRectangle(Rectangle rectangle, int cRadius)
        {
            int diminisher = 1;
            GraphicsPath path = new GraphicsPath();
            path.AddArc(rectangle.X, rectangle.Y, cRadius, cRadius, 180, 90);
            path.AddArc(rectangle.X + rectangle.Width - cRadius - diminisher, rectangle.Y, cRadius, cRadius, 270, 90);
            path.AddArc(rectangle.X + rectangle.Width - cRadius - diminisher, rectangle.Y + rectangle.Height - cRadius - diminisher, cRadius, cRadius, 0, 90);
            path.AddArc(rectangle.X, rectangle.Y + rectangle.Height - cRadius - diminisher, cRadius, cRadius, 90, 90);
            path.CloseAllFigures();
            return path;
        }
    }

}