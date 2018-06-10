using System.Windows.Forms;

namespace DevTool.Common
{
    public class FormCommon : Form
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
                _form.SetDesktopLocation(MousePosition.X - _moveFormX, MousePosition.Y - _moveFormY);
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
    }
}
