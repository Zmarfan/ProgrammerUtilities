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
        public enum NavigationButtons
        {
            SORT,
            COMPARE,
            COUNT,
            HTML,
            GENERATE_TEXT,
            CONVERT_COLOR,
            HELP,
        }

        public static readonly int EXPANDED_BUTTON_LEFT_MARGIN = 15;
        public static readonly int NOT_EXPANDED_BUTTON_LEFT_MARGIN = 5;

        public event NavigationButton.NavigationButtonClickedDelegate OnNavigationButtonClicked;

        public event NavigationButton.NavigationButtonClickedDelegate OnSortClicked;
        public event NavigationButton.NavigationButtonClickedDelegate OnCompareClicked;
        public event NavigationButton.NavigationButtonClickedDelegate OnCountClicked;
        public event NavigationButton.NavigationButtonClickedDelegate OnHTMLClicked;
        public event NavigationButton.NavigationButtonClickedDelegate OnGenerateTextClicked;
        public event NavigationButton.NavigationButtonClickedDelegate OnConvertColorClicked;

        public bool Expanded { get; private set; } = true;
        
        private HelpWindow _helpWindow;
        private bool _navigationTopButtonHover = false;

        public NavigationMenu()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            SelectNavigationButton(NavigationButtons.SORT);
            smallPicture.Hide();
        }

        public void StartTransitioning()
        {
            Expanded = !Expanded;
            if (!Expanded)
            {
                smallPicture.Show();
                copyrightLabel.Hide();
                contactLabel.Hide();
            }
            else
            {
                smallPicture.Hide();
                copyrightLabel.Show();
                contactLabel.Show();
                NavigationPicture.Show();
            }
        }

        public void DoneTransition()
        {
            if (!Expanded)
            {
                NavigationPicture.Hide();
            }
        }

        public void ChangeImageLeftMargin(float ratio)
        {
            int deltaMargin = (int)(((EXPANDED_BUTTON_LEFT_MARGIN - NOT_EXPANDED_BUTTON_LEFT_MARGIN) * ratio) + NOT_EXPANDED_BUTTON_LEFT_MARGIN);

            navigationSortButton.ChangeImageLeftMargin(deltaMargin);
            navigationCompareButton.ChangeImageLeftMargin(deltaMargin);
            navigationCountButton.ChangeImageLeftMargin(deltaMargin);
            navigationHTMLButton.ChangeImageLeftMargin(deltaMargin);
            navigationGenerateTextButton.ChangeImageLeftMargin(deltaMargin);
            navigationColorConverter.ChangeImageLeftMargin(deltaMargin);
            navigationHelpButton.ChangeImageLeftMargin(deltaMargin);
        }
        public void SelectNavigationButton(NavigationButtons button)
        {
            navigationSortButton.SelectButton(NavigationButtons.SORT == button);
            navigationCompareButton.SelectButton(NavigationButtons.COMPARE == button);
            navigationCountButton.SelectButton(NavigationButtons.COUNT == button);
            navigationHTMLButton.SelectButton(NavigationButtons.HTML == button);
            navigationGenerateTextButton.SelectButton(NavigationButtons.GENERATE_TEXT == button);
            navigationColorConverter.SelectButton(NavigationButtons.CONVERT_COLOR == button);
            navigationHelpButton.SelectButton(NavigationButtons.HELP == button);
        }


        private void NavigationTopButton_MouseEnter(object sender, EventArgs e)
        {
            NavigationTopButton.Margin = new Padding(0, 9, 0, 0);
            NavigationTopButton.Size = new Size(NavigationTopButton.Size.Width, 29);
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

        private void NavigationHelpButton_OnButtonClicked()
        {
            _helpWindow = new HelpWindow();
            _helpWindow.FormClosed += (a, b) => { navigationHelpButton.SelectButton(false); };
            _helpWindow.ShowDialog();
        }

        private void NavigationSortButton_OnButtonClicked()
        {
            OnSortClicked?.Invoke();
        }

        private void NavigationCompareButton_OnButtonClicked()
        {
            OnCompareClicked?.Invoke();
        }

        private void NavigationCountButton_OnButtonClicked()
        {
            OnCountClicked?.Invoke();
        }

        private void NavigationHTMLButton_OnButtonClicked()
        {
            OnHTMLClicked?.Invoke();
        }

        private void NavigationGenerateTextButton_OnButtonClicked()
        {
            OnGenerateTextClicked?.Invoke();
        }

        private void NavigationColorConverter_OnButtonClicked()
        {
            OnConvertColorClicked?.Invoke();
        }

        private void NavigationTopButton_Click(object sender, EventArgs e)
        {
            OnNavigationButtonClicked?.Invoke();
        }

        private void CopyrightLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:filippeterssoncontact@gmail.com");
        }
    }
}
