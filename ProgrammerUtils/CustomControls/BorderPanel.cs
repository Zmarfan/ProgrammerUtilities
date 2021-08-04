using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgrammerUtils
{
    public partial class BorderPanel : Panel
    {
        [Browsable(true)]
        public Color BorderColor { get; set; } = Color.Transparent;

        [Browsable(true)]
        public int BorderWidth { get; set; } = 2;

        [Browsable(true)]
        public ButtonBorderStyle PanelBorderStyle { get; set; } = ButtonBorderStyle.Solid;

        public BorderPanel()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            ControlPaint.DrawBorder(pe.Graphics, pe.ClipRectangle,
                BorderColor, BorderWidth, PanelBorderStyle,
                BorderColor, BorderWidth, PanelBorderStyle,
                BorderColor, BorderWidth, PanelBorderStyle,
                BorderColor, BorderWidth, PanelBorderStyle
                );
        }
    }
}
