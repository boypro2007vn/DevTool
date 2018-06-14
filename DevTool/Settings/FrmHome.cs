using System;
using System.Windows.Forms;
using DevTool.Common;
using DevTool.CustomControl;
using DevTool.Properties;
using Microsoft.Win32;

namespace DevTool.Settings
{
    public partial class FrmHome : CustomSettings
    {
        private RegistryKey _registryKey;

        public FrmHome()
        {
            InitializeComponent();
            base.InitSettings(this.PnlHelpDetail, this.PnlD0, this.BtnGeneralSettingsHelp);
        }

        public override void LoadSettings()
        {
            try
            {
                string[] settings = Properties.Settings.Default.ALONTOPShortcut.Split('&');
                this.ChkALONTOPCtrl.Checked = settings[0].Trim().Equals("1");
                this.ChkALONTOPShift.Checked = settings[1].Trim().Equals("1");
                this.ChkALONTOPAlt.Checked = settings[2].Trim().Equals("1");
                this.TxtALONTOP.Text = FormCommon.ConvertKeyToString((Keys)Int32.Parse(settings[3]));
                //this.ChkALONTOP.Checked = Properties.Settings.Default.ALONTOEnable;
                //this.ChkRunAtStatup.Checked = Properties.Settings.Default.RunAtStatupEnable;

                _registryKey = Registry.CurrentUser.OpenSubKey
                    ("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

                SetStatupSetting();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                MessageBox.Show(Resources.Error001, Resources.TitleError, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                DefaultSettings();
            }
            
        }

        public override void DefaultSettings()
        {
            this.ChkALONTOPCtrl.Checked = true;
            this.ChkALONTOPShift.Checked = true;
            this.ChkALONTOPAlt.Checked = false;
            this.TxtALONTOP.Text = "F12";
            this.TxtALONTOP.Tag = "123";  // Keycode F12 is 123
            //this.ChkRunAtStatup.Checked = false;
            //this.ChkALONTOP.Checked = true;
        }

        private void TxtALONTOP_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode >= Keys.PageUp && e.KeyCode <= Keys.Home) ||
                (e.KeyCode >= Keys.Insert && e.KeyCode <= Keys.Z) ||
                (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.F12) ||
                (e.KeyCode >= Keys.OemSemicolon && e.KeyCode <= Keys.OemQuotes))
            {
                e.SuppressKeyPress = true;
                this.TxtALONTOP.Tag = e.KeyValue;
                this.TxtALONTOP.Text = FormCommon.ConvertKeyToString(e.KeyCode);
            }
            else
            {
                e.Handled = true;
            }
        }

        private void BtnDefault_Click(object sender, EventArgs e)
        {
            DefaultSettings();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Properties.Settings.Default.ALONTOPShortcut = $"{(this.ChkALONTOPCtrl.Checked ? 1:0)}&" +
                                                              $"{(this.ChkALONTOPShift.Checked ? 1:0)}&" +
                                                              $"{(this.ChkALONTOPAlt.Checked ? 1:0)}&" +
                                                              $"{this.TxtALONTOP.Tag}";

                //Properties.Settings.Default.RunAtStatupEnable = this.ChkRunAtStatup.Checked;
                //Properties.Settings.Default.ALONTOEnable = this.ChkALONTOP.Checked;
                SetStatupSetting();

                Properties.Settings.Default.Save();
                MessageBox.Show(Resources.Msg001, Resources.AppName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(Resources.Msg001, Resources.Error002, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void SetStatupSetting()
        {
            // Setting for run at statup

            if (_registryKey != null)
            {
                //if (this.ChkRunAtStatup.Checked)
                //{
                //    _registryKey.SetValue(Application.ProductName, Application.ExecutablePath);
                //}
                //else
                //{
                //    _registryKey.DeleteValue(Application.ProductName, false);
                //}
            }
        }
    }
}
