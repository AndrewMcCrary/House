using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace House
{
    public static class Door
    {
        public static void Paint(Graphics g, Brush b, Rectangle r)
        {
            g.FillRectangle(b, r);
            Doorknob.Paint(g, Brushes.Silver, new Rectangle(r.Right - r.Width/4, r.Y + r.Height / 2, r.Width / 8, r.Width / 8));
        }
    }

    public static class Doorknob
    {
        public static void Paint(Graphics g, Brush b, Rectangle r)
        {
            g.FillEllipse(b, r);
        }
    }
}
