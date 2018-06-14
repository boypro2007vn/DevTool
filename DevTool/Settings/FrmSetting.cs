using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using DevTool.Common;
using DevTool.Model;
using DevTool.Properties;

namespace DevTool.Settings
{
    public partial class FrmSetting : Form
    {
        #region PrivateVariable

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
            SetActiveButton(this.BtnHome);
            if (_formHome == null)
            {
                _formHome = new FrmHome();
            }
            else
            {
                _formHome.ReloadSettings();
            }
            this.PnlContent.Controls.Clear();
            this.PnlContent.Controls.Add(_formHome);
        }

        private void BtnTran_Click(object sender, EventArgs e)
        {
            SetActiveButton(this.BtnTran);
            if (_formTranslate == null)
            {
                _formTranslate = new FrmTranslate();
            }
            else
            {
                _formTranslate.ReloadSettings();
            }
            this.PnlContent.Controls.Clear();
            this.PnlContent.Controls.Add(_formTranslate);
        }

        private void SetActiveButton(Button vButton)
        {
            foreach (Control c in ((Control)this.PnlTabBar).Controls)
            {
                if (c is Button)
                {
                    if (c.Name.Equals(vButton.Name))
                    {
                        c.BackColor = Color.FromArgb(37, 47, 59);
                    }
                    else
                    {
                        c.BackColor = Color.FromArgb(25, 32, 40);
                    }
                    
                }
            }
        }
    }
}
