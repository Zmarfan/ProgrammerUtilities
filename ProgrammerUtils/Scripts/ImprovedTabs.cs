using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgrammerUtils.Scripts
{
    public class ImprovedTabs
    {
        public struct TabPair
        {
            public Button TabButton { get; set; }
            public Control ShowControl { get; set; }

            public TabPair(Button tabButton, Control showControl)
            {
                TabButton = tabButton;
                ShowControl = showControl;
            }
        }

        readonly List<TabPair> _tabButtons;
        readonly Color _tabButtonDefaultColor;
        readonly Color _tabButtonSelectedColor;

        public ImprovedTabs(List<TabPair> tabButtons, Color tabButtonDefaultColor, Color tabButtonSelectedColor)
        {
            _tabButtons = tabButtons;
            _tabButtonDefaultColor = tabButtonDefaultColor;
            _tabButtonSelectedColor = tabButtonSelectedColor;

            _tabButtons.ForEach(tab =>
            {
                tab.ShowControl.Dock = DockStyle.Fill;
            });

            TabClicked(_tabButtons.First().TabButton);
        }

        public void TabClicked(Button button)
        {
            _tabButtons.ForEach(tab => ToggleTabShow(tab, tab.TabButton == button));
        }

        private void ToggleTabShow(TabPair tab, bool show)
        {
            if (show)
                tab.ShowControl.Show();
            else
                tab.ShowControl.Hide();

            tab.TabButton.BackColor = show ? _tabButtonSelectedColor : _tabButtonDefaultColor;
        }
    }
}
