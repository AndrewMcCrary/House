using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace House
{
    public static class IsoTriangle
    {
        public static void Paint(Graphics g, Point p, Brush b, int Height, int Width)
        {
            Point[] points =
            {
                p,
                new Point(p.X - (Width/2), p.Y + Height),
                new Point(p.X + (Width/2), p.Y + Height)
            };
            g.FillPolygon(b, points);
        }
    }
}
