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

        DateTime _lastTime = DateTime.Now;
        readonly Timer _navigationMenuOpenCloseTimer = new Timer(0.15f);
        private bool _navigationTransitioning = false;

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
        }

        #region Navigation

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
