using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using DevTool.Services;

namespace DevTool.Common
{
    public class FormCommon
    {
        /// <summary>
        /// Target Form
        /// </summary>
        private Form _form;
        /// <summary>
        /// Flag for check form is moved
        /// </summary>
        private bool _flagFormMove;
        /// <summary>
        /// Coordinates X of form
        /// </summary>
        private int _moveFormX;
        /// <summary>
        /// Coordinates Y of form
        /// </summary>
        private int _moveFormY;

        private static ToolTip _toolTip;

        /// <summary>
        /// Move the form without border
        /// </summary>
        /// <param name="vTarget">Location active</param>
        /// <param name="vForm">Form to move</param>
        public void MoveForm(Panel vTarget, Form  vForm)
        {
            _form = vForm;
            vTarget.MouseDown += PanelMouseDown;
            vTarget.MouseUp += PanelMouseUp;
            vTarget.MouseMove += PanelMouseMove;
        }
        /// <summary>
        /// Mouse move of panel event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PanelMouseMove(object sender, MouseEventArgs e)
        {
            if (_flagFormMove)
            {
                _form.SetDesktopLocation(Cursor.Position.X - _moveFormX, Cursor.Position.Y - _moveFormY);
            }
        }

        /// <summary>
        /// Mouse up of panel event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PanelMouseUp(object sender, MouseEventArgs e)
        {
            _flagFormMove = false;
        }

        /// <summary>
        /// Mouse down of panel event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PanelMouseDown(object sender, MouseEventArgs e)
        {
            _flagFormMove = true;
            _moveFormX = e.X;
            _moveFormY = e.Y;
        }

        public static string ConvertKeyToString(Keys vKey)
        {
            if (vKey >= Keys.F1 && vKey <= Keys.F12)
            {
                return vKey.ToString();
            }

            byte[] keyboardState = new byte[255];
            bool keyboardStateStatus = WindowApi.GetKeyboardState(keyboardState);

            if (!keyboardStateStatus)
            {
                return "";
            }

            uint virtualKeyCode = (uint)vKey;
            uint scanCode = WindowApi.MapVirtualKey(virtualKeyCode, 0);
            IntPtr inputLocaleIdentifier = WindowApi.GetKeyboardLayout(0);

            StringBuilder result = new StringBuilder();
            WindowApi.ToUnicodeEx(virtualKeyCode, scanCode, keyboardState, result, (int)5, (uint)0, inputLocaleIdentifier);

            return result.ToString().ToUpper();
        }

        /// <summary>
        /// Show tooltip for target
        /// </summary>
        /// <param name="vMessage">Content ToolTip</param>
        /// <param name="vTitle">Title header</param>
        /// <param name="vTarget">Target Avtive</param>
        /// <param name="vIcon">Icon ToolTip</param>
        public static void ShowToolTip(string vMessage, string vTitle, Control vTarget, [Optional] ToolTipIcon vIcon)
        {
            // Create the ToolTip and associate with the Form container.
            if (_toolTip == null)
            {
                _toolTip = new ToolTip();
            }

            // Set up the delays for the ToolTip.
            _toolTip.ToolTipTitle = vTitle;
            _toolTip.AutoPopDelay = 5000;
            _toolTip.InitialDelay = 1000;
            _toolTip.ReshowDelay = 500;
            // Force the ToolTip text to be displayed whether or not the form is active.
            _toolTip.ShowAlways = true;

            // Design tooltip
            _toolTip.ToolTipIcon = vIcon;
            _toolTip.UseFading = true;
            _toolTip.UseAnimation = true;
            _toolTip.BackColor = Color.FromArgb(29, 165, 104);
            _toolTip.ForeColor = Color.White;

            // Set up the ToolTip text for the control.
            _toolTip.SetToolTip(vTarget, vMessage);
        }


        private static int[] dirmap = { 1, 5, 4, 6, 2, 10, 8, 9 };

        [DllImport("user32.dll")]
        private static extern bool AnimateWindow(IntPtr handle, int msec, int flags);

        /// <summary>
        /// Animation effect type
        /// </summary>
        public enum Effect { Roll, Slide, Center, Blend };

        public static void Animate(Control vControl, Effect vEffects, int vSec, int vAngle)
        {
            switch (vEffects)
            {
                case Effect.Slide:
                {
                    int flags = 0x40000;
                    if (vControl.Visible)
                    {
                        flags |= 0x10000;
                        vAngle += 180;
                    }
                    else
                    {
                        if (vControl.TopLevelControl == vControl)
                        {
                            flags |= 0x20000;
                        }
                    }
                    flags |= dirmap[(vAngle % 360) / 45];
                    AnimateWindow(vControl.Handle, vSec, flags);
                    vControl.Visible = !vControl.Visible;
                    break;
                }
            }
           
        }
    }
}
