using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevTool.Common;

namespace DevTool.CustomControl
{
    public abstract partial class CustomSettings : UserControl
    {
        private Panel _panel;
        private Panel _detaiPanel;
        private Button _helperButton;

        public CustomSettings() : base()
        {

        }

        public void InitSettings(Panel vPanel, Panel vPanelDetail, Button vHelperButton)
        {
            _panel = vPanel;
            _detaiPanel = vPanelDetail;
            _helperButton = vHelperButton;

            _panel.Click += PanelDetail_Click;

            _detaiPanel.Click += PanelDetail_Click;
            _helperButton.Click += HelperButton_Click;
        }

        public void ReloadSettings()
        {
            LoadSettings();

            if (_panel.Visible)
            {
                _panel.Visible = false;
            }
        }

        private void HelperButton_Click(object sender, EventArgs e)
        {
            FormCommon.Animate(_panel, FormCommon.Effect.Slide, 200, 90);
        }

        private void PanelDetail_Click(object sender, EventArgs e)
        {
            if (_panel.Visible)
            {
                FormCommon.Animate(_panel, FormCommon.Effect.Slide, 200, 90);
            }
        }

        public abstract void LoadSettings();
        public abstract void DefaultSettings();
    }
}
