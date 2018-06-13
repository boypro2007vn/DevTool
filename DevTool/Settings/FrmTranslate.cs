using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevTool.Common;
using DevTool.Model;
using DevTool.Properties;
using Newtonsoft.Json.Linq;

namespace DevTool.Settings
{
    public partial class FrmTranslate : UserControl
    {
        public FrmTranslate()
        {
            InitializeComponent();
        }

        private void FrmTranslate_Load(object sender, EventArgs e)
        {
            InitCombobox();
            LoadSettings();
        }

        private void LoadSettings()
        {
            try
            {
                this.ChkEnableTranslate.Checked = Properties.Settings.Default.TranslatorEnable;
                this.ChkCopyToClipboard.Checked = Properties.Settings.Default.CopyClipBoard;
                this.CboInLang.SelectedValue = Properties.Settings.Default.InputLang;
                this.CboOutLang.SelectedValue = Properties.Settings.Default.OutputLang;
            }
            catch (Exception e)
            {
                MessageBox.Show(Resources.Error001, Resources.TitleError, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                DefaultSetting();
            }

        }

        private void DefaultSetting()
        {
            this.ChkEnableTranslate.Checked = true;
            this.ChkCopyToClipboard.Checked = true;
            this.CboInLang.SelectedValue = "en";
            this.CboOutLang.SelectedValue = "vi";
        }

        private void InitCombobox()
        {
            Dictionary<string, string> listLanguages = Translator.Languages;

            SetComboboxValue(this.CboInLang, listLanguages);
            SetComboboxValue(this.CboOutLang, listLanguages);
        }

        private void SetComboboxValue(ComboBox vComboBox, Dictionary<string,string> vListLanguages)
        {
            vComboBox.DataSource = new BindingSource(vListLanguages, null);
            vComboBox.DisplayMember = "Value";
            vComboBox.ValueMember = "Key";
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Properties.Settings.Default.TranslatorEnable = this.ChkEnableTranslate.Checked;
                Properties.Settings.Default.CopyClipBoard = this.ChkCopyToClipboard.Checked;
                Properties.Settings.Default.InputLang = this.CboInLang.SelectedValue.ToString();
                Properties.Settings.Default.OutputLang = this.CboOutLang.SelectedValue.ToString();
                Properties.Settings.Default.Save();
                MessageBox.Show(Resources.Msg001, Resources.AppName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exception)
            {
                MessageBox.Show(Resources.Msg001, Resources.Error002, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void BtnDefault_Click(object sender, EventArgs e)
        {
            DefaultSetting();
            
        }

        private void BtnTranslateSettingsHelp_Click(object sender, EventArgs e)
        {
           FormCommon.Animate(this.PnlHelpDetail, FormCommon.Effect.Slide, 1, true);
        }

        private void PnlD0_Click(object sender, EventArgs e)
        {
            FormCommon.Animate(this.PnlHelpDetail, FormCommon.Effect.Slide, 200, false);
        }
    }
}
