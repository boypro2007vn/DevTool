using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using DevTool.Model;
using DevTool.Properties;

namespace DevTool.Settings
{
    public partial class FrmSetting : Form
    {
        #region PrivateVariable

        private Dictionary<string, string> _cboLanguage;

        #endregion
        public FrmSetting()
        {
            InitializeComponent();

            InitMouseHoverColor();
        }
        
        private void FrmSetting_Load(object sender, EventArgs e)
        {
            InitCombobox();
            LoadSetting();
        }

        private void LoadSetting()
        {
            // CboInLang.SelectedValue = Properties.Settings.Default.InputLang;
            // CboOutLang.SelectedValue = Properties.Settings.Default.OutputLang;
            // ChkCopyClipBoard.Checked = Properties.Settings.Default.CopyClipBoard;
        }
        #region ComboboxEvent

        private void InitCombobox()
        {
            try { 
                _cboLanguage = Translator.Languages;

                // Set value for combobox
                // SetCombobox(CboInLang);
                // SetCombobox(CboOutLang);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        /// <summary>
        /// Set key and value for combobox
        /// </summary>
        /// <param name="vComboBox"></param>
        private void SetCombobox(ComboBox vComboBox)
        {
            vComboBox.DataSource = new BindingSource(_cboLanguage, null);
            vComboBox.DisplayMember = "Value";
            vComboBox.ValueMember = "Key";
        }

        #endregion

        private void BtnOk_Click(object sender, EventArgs e)
        {
            //DevTool.Properties.Settings.Default.InputLang = CboInLang.SelectedValue.ToString();
            //DevTool.Properties.Settings.Default.OutputLang = CboOutLang.SelectedValue.ToString();
            //DevTool.Properties.Settings.Default.CopyClipBoard = ChkCopyClipBoard.Checked;
            DevTool.Properties.Settings.Default.Save();

            MessageBox.Show(Resources.MSG001, Resources.TitleComfirm, MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        #region Button Hover Event

        private void InitMouseHoverColor()
        {
            // Set back color when hover Panel Header
            foreach (Control control in ((Control)this.PnlHeader).Controls)
            {
                if (control is Button)
                {
                    control.MouseEnter += (sender, e) => Button_MouseHover(sender, e, Color.DarkRed);
                    control.MouseLeave += (sender, e) => Button_MouseHover(sender, e, Color.FromArgb(44, 53, 76));
                }
            }

            // Set back color when hover Panel TabBar
            foreach (Control control in ((Control)this.PnlTabBar).Controls)
            {
                if (control is Button)
                {
                    control.MouseEnter += (sender, e) => Button_MouseHover(sender, e, Color.DarkOrchid);
                    control.MouseLeave += (sender, e) => Button_MouseHover(sender, e, Color.FromArgb(44, 53, 76));
                }
            }
        }

        private void Button_MouseHover(object sender, EventArgs e, Color color)
        {
            ((Button)sender).BackColor = color;
        }

        #endregion
    }
}
