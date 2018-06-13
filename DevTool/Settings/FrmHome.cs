using System;
using System.Windows.Forms;
using DevTool.Common;
using DevTool.Properties;

namespace DevTool.Settings
{
    public partial class FrmHome : UserControl
    {
        
        public FrmHome()
        {
            InitializeComponent();
        }

        private void FrmHome_Load(object sender, EventArgs e)
        {
            LoadSettings();
        }

        private void LoadSettings()
        {
            try
            {
                string[] settings = Properties.Settings.Default.ALONTOPShortcut.Split('&');
                this.ChkALONTOPCtrl.Checked = settings[0].Trim().Equals("1");
                this.ChkALONTOPShift.Checked = settings[1].Trim().Equals("1");
                this.ChkALONTOPAlt.Checked = settings[2].Trim().Equals("1");
                this.TxtALONTOP.Text = FormCommon.ConvertKeyToString((Keys)Int32.Parse(settings[3]));
            }
            catch (Exception e)
            {
                MessageBox.Show(Resources.Error001, Resources.TitleError, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.ChkALONTOPCtrl.Checked = true;
                this.ChkALONTOPShift.Checked = true;
                this.ChkALONTOPAlt.Checked = false;
                this.TxtALONTOP.Text = "F12";
                this.TxtALONTOP.Tag = "123";  // Keycode F12 is 123
            }
            
        }

        private void TxtALONTOP_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode >= Keys.PageUp && e.KeyCode <= Keys.Home) ||
                (e.KeyCode >= Keys.Insert && e.KeyCode <= Keys.Z) ||
                (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.F12) ||
                (e.KeyCode >= Keys.OemSemicolon && e.KeyCode <= Keys.OemQuotes))
            {
                e.SuppressKeyPress = true;
                this.TxtALONTOP.Text = FormCommon.ConvertKeyToString(e.KeyCode);
                this.TxtALONTOP.Tag = e.KeyCode;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
