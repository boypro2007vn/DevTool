using System.Drawing;
using System.Windows.Forms;


namespace DevTool.CustomControl
{
    public partial class CustomPanel : Panel
    {
        private Color _colorBorder = Color.Transparent;
        public Color BorderColor
        {
            get => _colorBorder;
            set => _colorBorder = value;
        }

        public CustomPanel() : base()
        {
            this.SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.DoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            using (SolidBrush brush = new SolidBrush(BackColor))
                e.Graphics.FillRectangle(brush, ClientRectangle);
            e.Graphics.DrawRectangle(new Pen(_colorBorder), 0, 0, ClientSize.Width - 1, ClientSize.Height - 1);
        }
    }
}
