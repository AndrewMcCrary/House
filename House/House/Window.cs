using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace House
{
    public static class Window
    {
        private static readonly Pen BORDER_COLOR = new Pen(Brushes.Brown, 8);
        private static readonly Brush WINDOW_COLOR = Brushes.LightBlue;

        public static void Paint(Graphics g, Rectangle r, bool Round)
        {
            if (Round)
            {
                g.FillEllipse(WINDOW_COLOR, r);
                g.DrawLine(BORDER_COLOR, r.X + r.Width / 2, r.Y, r.X + r.Width / 2, r.Y + r.Height);
                g.DrawLine(BORDER_COLOR, r.X, r.Y + r.Height / 2, r.X + r.Width, r.Y + r.Height / 2);
                g.DrawEllipse(BORDER_COLOR, r);
            }
            else
            {
                g.FillRectangle(WINDOW_COLOR, r);
                g.DrawLine(BORDER_COLOR, r.X + r.Width / 2, r.Y, r.X + r.Width / 2, r.Y + r.Height);
                g.DrawLine(BORDER_COLOR, r.X, r.Y + r.Height / 2, r.X + r.Width, r.Y + r.Height / 2);
                g.DrawRectangle(BORDER_COLOR, r);
            }
        }
    }
}
