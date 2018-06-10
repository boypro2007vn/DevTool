using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevTool.Settings
{
    public partial class FrmHome : UserControl
    {
        public FrmHome()
        {
            InitializeComponent();
        }

        private void TxtALONTOP_KeyDown(object sender, KeyEventArgs e)
        {
            
            if ((e.KeyCode >= Keys.PageUp && e.KeyCode <= Keys.Home) ||
                (e.KeyCode >= Keys.Insert && e.KeyCode <= Keys.Z) ||
                (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.F12) ||
                (e.KeyCode >= Keys.OemSemicolon && e.KeyCode <= Keys.OemQuotes))
            {
                e.SuppressKeyPress = true;
                this.TxtALONTOP.Text = Convert.ToChar(e.KeyValue).ToString();
                this.TxtALONTOP.Tag = e.KeyCode;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
