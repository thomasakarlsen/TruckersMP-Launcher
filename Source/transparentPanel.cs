using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace truckersmplauncher
{
    [Description("Transparent Panel")]
    [ToolboxBitmap(typeof(Panel))]
    public class TransparentPanel : Panel
    {
        protected void TickHandler(object sender, EventArgs e)
        {
            this.InvalidateEx();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;

                cp.ExStyle |= 0x00000020; //WS_EX_TRANSPARENT

                return cp;
            }
        }

        protected void InvalidateEx()
        {
            if (Parent == null)
            {
                return;
            }

            Rectangle rc = new Rectangle(this.Location, this.Size);

            Parent.Invalidate(rc, true);
        }

        protected override void OnPaintBackground(PaintEventArgs pevent)
        {

        }

        protected override void OnPaint(PaintEventArgs e)
        {

            e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(128,0,0,0)), this.ClientRectangle);
        }
    }
}