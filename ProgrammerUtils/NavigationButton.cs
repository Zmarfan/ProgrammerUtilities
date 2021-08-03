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
    public partial class NavigationButton : UserControl
    {
        public delegate void NavigationButtonClickedDelegate();

        [Browsable(true)] public Color ButtonColor { get; set; }
        [Browsable(true)] public Color ButtonHoverColor { get; set; }
        [Browsable(true)] public Color ButtonClickColor { get; set; }

        [Browsable(true)]
        public string ButtonText
        {
            get => ButtonLabel.Text;
            set
            {
                ButtonLabel.Text = value;
                Invalidate();
            }
        }

        [Browsable(true)]
        public Image ButtonImage
        {
            get => Picture.BackgroundImage;
            set
            {
                Picture.BackgroundImage = value;
                Invalidate();
            }
        }

        public event NavigationButtonClickedDelegate OnButtonClicked;

        private bool _selected = false;

        public NavigationButton()
        {
            InitializeComponent();
            SubscribeToMouseEvents(ButtonLabel);
            SubscribeToMouseEvents(MainTableLayout);
            SubscribeToMouseEvents(Picture);
        }

        public void SelectButton(bool selectStatus)
        {
            _selected = selectStatus;
        }

        private void SubscribeToMouseEvents(Control control)
        {
            control.MouseDown += NavigationButton_MouseDown;
            control.MouseUp += NavigationButton_MouseUp;
            control.MouseEnter += NavigationButton_MouseEnter;
            control.MouseLeave += NavigationButton_MouseLeave;
            control.MouseClick += NavigationButton_MouseClick;
        }

        private void NavigationButton_MouseClick(object sender, MouseEventArgs e)
        {
            OnButtonClicked?.Invoke();
        }

        private void NavigationButton_MouseDown(object sender, MouseEventArgs e)
        {
            if (!_selected)
            {
                BackColor = ButtonClickColor;
            }
        }

        private void NavigationButton_MouseEnter(object sender, EventArgs e)
        {
            if (!_selected)
            {
                BackColor = ButtonHoverColor;
            } 
        }

        private void NavigationButton_MouseLeave(object sender, EventArgs e)
        {
            if (!_selected)
            {
                BackColor = ButtonColor;
            }
        }

        private void NavigationButton_MouseUp(object sender, MouseEventArgs e)
        {
            if (!_selected && BackColor == ButtonClickColor)
            {
                BackColor = ButtonHoverColor;
            }
        }
    }
}
