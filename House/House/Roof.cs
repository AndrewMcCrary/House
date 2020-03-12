using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace House
{
    public static class Roof
    {
        public static void Paint(Graphics g, Point p, Brush b, int Height, int Width)
        {
            int x1 = avg(p.X, p.X + Width / 2);
            int y1 = avg(p.Y, p.Y + Height / 2);

            Chimney.Paint(g, new Rectangle(p.X + Width / 6, p.Y + Height - Height * 5 / 4, Width / 6, Height * 5 / 4));
            Smoke.Paint(g, new Rectangle(p.X + Width / 6, p.Y + Height - Height * 3 / 2, Width / 6, Width/12));
            Smoke.Paint(g, new Rectangle(p.X + Width / 6, p.Y + Height - Height * 7/4, Width / 6, Width / 12));
            Smoke.Paint(g, new Rectangle(p.X + Width / 6, p.Y + Height - Height * 2, Width / 6, Width / 12));

            IsoTriangle.Paint(g, p, b, Height, Width);
        }

        private static int avg(int a, int b)
        {
            return (a + b) / 2;
        }
    }

    public static class Chimney
    {
        private static readonly Brush CHIMNEY_COLOR = Brushes.DarkRed;

        public static void Paint(Graphics g, Rectangle r)
        {
            g.FillRectangle(CHIMNEY_COLOR, r);
        }
    }

    public static class Smoke
    {
        private static readonly Brush SMOKE_COLOR = Brushes.DarkGray;

        public static void Paint(Graphics g, Rectangle r)
        {
            g.FillEllipse(SMOKE_COLOR, r);
        }
    }
}
