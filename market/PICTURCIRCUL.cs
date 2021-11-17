using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Windows.Forms;

namespace market
{
    class PICTURCIRCUL: PictureBox
    {
        protected override void OnPaint(PaintEventArgs pe)
        {
            GraphicsPath n = new GraphicsPath();
            n.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            this.Region = new System.Drawing.Region(n);
            base.OnPaint(pe);
        }
    }
}
