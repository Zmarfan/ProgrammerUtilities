using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace ProgrammerUtils
{
    public partial class CountDetail : UserControl
    {
        public string DetailText
        {
            get => detailLabel.Text;
            set => detailLabel.Text = value;
        }

        public string ValueText
        {
            get => valueLabel.Text;
            set => valueLabel.Text = value;
        }

        public CountDetail()
        {
            InitializeComponent();
        }
    }
}
