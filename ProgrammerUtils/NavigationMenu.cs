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
    public partial class NavigationMenu : UserControl
    {
        public static readonly int EXPANDED_BUTTON_LEFT_MARGIN = 15;
        public static readonly int NOT_EXPANDED_BUTTON_LEFT_MARGIN = 5;

        public event NavigationButton.NavigationButtonClickedDelegate OnNavigationButtonClicked;

        public event NavigationButton.NavigationButtonClickedDelegate OnSortClicked;
        public event NavigationButton.NavigationButtonClickedDelegate OnCompareClicked;
        public event NavigationButton.NavigationButtonClickedDelegate OnCountClicked;
        public event NavigationButton.NavigationButtonClickedDelegate OnHTMLClicked;
        public event NavigationButton.NavigationButtonClickedDelegate OnGenerateTextClicked;

        public bool Expanded { get; private set; } = true;
        
        private HelpWindow _helpWindow;
        private bool _navigationTopButtonHover = false;

        public NavigationMenu()
        {
            InitializeComponent();
        }

        public void ChangeExpansionMode()
        {
            Expanded = !Expanded;

            int margin = Expanded ? EXPANDED_BUTTON_LEFT_MARGIN : NOT_EXPANDED_BUTTON_LEFT_MARGIN;

            navigationSortButton.ChangeImageLeftMargin(margin);
            navigationCompareButton.ChangeImageLeftMargin(margin);
            navigationCountButton.ChangeImageLeftMargin(margin);
            navigationHTMLButton.ChangeImageLeftMargin(margin);
            navigationGenerateTextButton.ChangeImageLeftMargin(margin);
            navigationHelpButton.ChangeImageLeftMargin(margin);
        }

        private void NavigationTopButton_MouseEnter(object sender, EventArgs e)
        {
            NavigationTopButton.Margin = new Padding(0, 8, 0, 0);
            NavigationTopButton.Size = new Size(NavigationTopButton.Size.Width, 32);
            _navigationTopButtonHover = true;
        }

        private void NavigationTopButton_MouseLeave(object sender, EventArgs e)
        {
            NavigationTopButton.Margin = new Padding(0, 10, 0, 0);
            NavigationTopButton.Size = new Size(NavigationTopButton.Size.Width, 27);
            _navigationTopButtonHover = false;
        }

        private void NavigationTopButton_MouseDown(object sender, MouseEventArgs e)
        {
            NavigationTopButton.Margin = new Padding(0, 10, 0, 0);
            NavigationTopButton.Size = new Size(NavigationTopButton.Size.Width, 27);
        }

        private void NavigationTopButton_MouseUp(object sender, MouseEventArgs e)
        {
            if (_navigationTopButtonHover)
                NavigationTopButton_MouseEnter(null, null);
            else
                NavigationTopButton_MouseLeave(null, null);
        }
        private void SelectNavigationButton(NavigationButton button)
        {
            navigationSortButton.SelectButton(navigationSortButton == button);
            navigationCompareButton.SelectButton(navigationCompareButton == button);
            navigationCountButton.SelectButton(navigationCountButton == button);
            navigationHTMLButton.SelectButton(navigationHTMLButton == button);
            navigationGenerateTextButton.SelectButton(navigationGenerateTextButton == button);
            navigationHelpButton.SelectButton(navigationHelpButton == button);
        }

        private void NavigationHelpButton_OnButtonClicked()
        {
            SelectNavigationButton(navigationHelpButton);
            _helpWindow = new HelpWindow();
            _helpWindow.FormClosed += (a, b) => { navigationHelpButton.SelectButton(false); };
            _helpWindow.ShowDialog();
        }

        private void NavigationSortButton_Load(object sender, EventArgs e)
        {
            OnSortClicked?.Invoke();
        }

        private void NavigationCompareButton_Load(object sender, EventArgs e)
        {
            OnCompareClicked?.Invoke();
        }

        private void NavigationCountButton_Load(object sender, EventArgs e)
        {
            OnCountClicked?.Invoke();
        }

        private void NavigationHTMLButton_Load(object sender, EventArgs e)
        {
            OnHTMLClicked?.Invoke();
        }

        private void NavigationGenerateTextButton_Load(object sender, EventArgs e)
        {
            OnGenerateTextClicked?.Invoke();
        }

        private void NavigationTopButton_Click(object sender, EventArgs e)
        {
            OnNavigationButtonClicked?.Invoke();
        }
    }
}
