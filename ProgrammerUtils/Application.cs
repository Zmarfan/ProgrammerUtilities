using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ProgrammerUtils
{
    public partial class Application : Form
    {
        internal static class NativeWinAPI
        {
            internal static readonly int GWL_EXSTYLE = -20;
            internal static readonly int WS_EX_COMPOSITED = 0x02000000;

            [DllImport("user32")]
            internal static extern int GetWindowLong(IntPtr hWnd, int nIndex);

            [DllImport("user32")]
            internal static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);
        }


        private static readonly int EXPANDED_NAVIGATION_MENU_SIZE = 250;
        private static readonly int NOT_EXPANDED_NAVIGATION_MENU_SIZE = 44;

        GenerateText _generateText;

        public Application()
        {
            InitializeComponent();

            int style = NativeWinAPI.GetWindowLong(this.Handle, NativeWinAPI.GWL_EXSTYLE);
            style |= NativeWinAPI.WS_EX_COMPOSITED;
            NativeWinAPI.SetWindowLong(this.Handle, NativeWinAPI.GWL_EXSTYLE, style);

            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

            Init();
            InitNavigationBar();
        }
        private void Init()
        {
            FrameTimer.Start();

            generateParagraphType.SelectedIndex = 0;

            _generateText = new GenerateText(generateOutputTextbox, generateSeed);

            
            generateCopyLabel.Text = string.Empty;
        }

        #region Navigation

        readonly Timer _navigationMenuOpenCloseTimer = new Timer(0.15f);
        private bool _navigationTransitioning = false;

        private bool NavigationMenuTick(float delta)
        {
            if (_navigationTransitioning)
            {
                _navigationMenuOpenCloseTimer.Time += delta;

                TableLayoutColumnStyleCollection columns = MainTableLayout.ColumnStyles;
                float ratio = navigationMenu.Expanded ? Math.Min(_navigationMenuOpenCloseTimer.Ratio(), 1) : Math.Max(_navigationMenuOpenCloseTimer.InverseRatio(), 0);

                int deltaSize = (int)(((EXPANDED_NAVIGATION_MENU_SIZE - NOT_EXPANDED_NAVIGATION_MENU_SIZE) * ratio) + NOT_EXPANDED_NAVIGATION_MENU_SIZE);

                navigationMenu.ChangeImageLeftMargin(ratio);
                columns[0].Width = deltaSize;

                if (_navigationMenuOpenCloseTimer.Expired())
                {
                    _navigationMenuOpenCloseTimer.Reset();
                    _navigationTransitioning = false;
                }
            }
            return _navigationTransitioning;
        }

        private void InitNavigationBar()
        {
            navigationMenu.OnNavigationButtonClicked += NavigationButtonClicked;
        }

        private void NavigationButtonClicked()
        {
            _navigationTransitioning = true;
            navigationMenu.ChangeExpansionMode();
        }

        #endregion
        
        #region Generate Text
        #region Helper Methods

        private void DoGenerateText(bool customSeed)
        {
            if (_generateText != null)
                _generateText.GenerateRandomWords((int)generateNumberOfWords.Value, GetParagraphType(), customSeed, generateParagraphSizeSlider.Value);
        }

        private GenerateText.ParagraphType GetParagraphType()
        {
            string current = generateParagraphType.Text;
            switch (current)
            {
                case ("Blank row"): return GenerateText.ParagraphType.BLANK_ROW;
                case ("Indent"): return GenerateText.ParagraphType.INDENT;
                case ("No paragraphs"): return GenerateText.ParagraphType.NO_PARAGRAPHS;
                default: throw new Exception($"There exist no implementation for this paragraph type: {current}");
            }
        }

        private void EnableSeed(bool enable)
        {
            generateSeed.Enabled = enable;
            generateSeedLabel.Enabled = enable;

        }

        #endregion
        #region Events

        private void GenerateGenerateButton_Click(object sender, EventArgs e)
        {
            DoGenerateText(generateCustomSeed.Checked);
        }

        private void GenerateCopyButton_Click(object sender, EventArgs e)
        {
            //Copy(generateCopyButton, generateCopyLabel);
            if (generateOutputTextbox.Text.Length > 0)
                Clipboard.SetText(generateOutputTextbox.Text);
        }

        private void GenerateClearButton_Click(object sender, EventArgs e)
        {
            generateOutputTextbox.Text = string.Empty;
        }

        private void GenerateCustomSeed_CheckedChanged(object sender, EventArgs e)
        {
            EnableSeed(generateCustomSeed.Checked);
        }

        private void GenerateParagraphType_SelectedIndexChanged(object sender, EventArgs e)
        {
            DoGenerateText(true);
        }

        private void GenerateParagraphSizeSlider_MouseUp(object sender, MouseEventArgs e)
        {
            DoGenerateText(true);
        }

        #endregion
        #endregion

        DateTime _lastTime = DateTime.Now;

        private void FrameTimer_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            long elapsedTicks = now.Ticks - _lastTime.Ticks;
            _lastTime = now;

            TimeSpan elapsedSpan = new TimeSpan(elapsedTicks);
            float secondsPassed = (float)elapsedSpan.TotalSeconds;

            if (NavigationMenuTick(secondsPassed))
                Invalidate();
        }
    }
}
