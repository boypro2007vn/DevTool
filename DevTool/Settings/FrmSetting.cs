using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevTool.Common;
using DevTool.Model;
using DevTool.Properties;

namespace DevTool.Settings
{
    public partial class FrmSetting : Form
    {
        #region PrivateVariable

        private Dictionary<string, string> _cboLanguage;
        private FrmTranslate _formTranslate;
        private FrmHome _formHome;

        #endregion
        public FrmSetting()
        {
            InitializeComponent();
        }
        
        private void FrmSetting_Load(object sender, EventArgs e)
        {
            this.BtnHome.PerformClick();
            // Move form without border
            new FormCommon().MoveForm(this.PnlHeader, this);
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            if (_formHome == null)
            {
                _formHome = new FrmHome();
            }
            this.PnlContent.Controls.Clear();
            this.PnlContent.Controls.Add(_formHome);
        }

        private void BtnTran_Click(object sender, EventArgs e)
        {
            if (_formTranslate == null)
            {
                _formTranslate = new FrmTranslate();
            }
            this.PnlContent.Controls.Clear();
            this.PnlContent.Controls.Add(_formTranslate);
        }
    }
}
