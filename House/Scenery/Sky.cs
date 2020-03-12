using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace House
{
    public static class Sky
    {
        public static void Paint(Graphics g, Brush b, Rectangle r)
        {
            g.FillRectangle(b, r);
        }
    }
}
