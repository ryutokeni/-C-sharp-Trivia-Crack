using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trivia_crack
{
    public partial class SpinButton : PictureBox
    {
        private bool _Hovering = false;
        private bool Hovering
        {
            get { return _Hovering; }
            set
            {
                if (value == _Hovering)
                    return;

                _Hovering = value;

                Invalidate();
            }
        }

        private bool _Pressed = false;
        private bool Pressed
        {
            get { return _Pressed; }
            set
            {
                if (value == _Pressed)
                    return;

                _Pressed = value;

                Invalidate();
            }
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            Hovering = true;
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            Hovering = false;
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                Pressed = true;
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                Pressed = false;
        }

        public SpinButton()
        {
            InitializeComponent();
        }

        public new string Text
        {
            get { return base.Text; }
            set
            {
                if (value == base.Text)
                    return;

                base.Text = value;
                Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            Graphics g = pe.Graphics;
            Rectangle rc = ClientRectangle;
            rc.Width -= 1;
            rc.Height -= 1;
            g.FillRectangle(new SolidBrush(Color.Transparent), ClientRectangle);
            Bitmap bmp;
            bmp = (Bitmap)Properties.Resources.ButtonNormal;
            g.DrawImage(bmp, rc);
            if (Pressed)
                bmp = (Bitmap)Properties.Resources.ButtonSpinning;
            else if (Hovering)
                bmp = (Bitmap)Properties.Resources.ButtonHovering;
            else
                bmp = (Bitmap)Properties.Resources.ButtonNormal;
            g.DrawImage(bmp, rc);
        }
    }
}
