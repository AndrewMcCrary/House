using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace House
{
    public static class Tree
    {
        const int TRI_H = 40;
        const int TRI_W = 60;

        /// <summary>
        /// Paints tree
        /// </summary>
        /// <param name="g"></param>
        /// <param name="p">Represents vertex of the tree</param>
        public static void Paint(Graphics g, Point p)
        {
            IsoTriangle.Paint(g, p, Brushes.ForestGreen, TRI_H, TRI_W);
            IsoTriangle.Paint(g, new Point(p.X, p.Y + (TRI_H/2)), Brushes.ForestGreen, TRI_H, TRI_W);
            IsoTriangle.Paint(g, new Point(p.X, p.Y + TRI_H), Brushes.ForestGreen, TRI_H, TRI_W);
            g.FillRectangle(Brushes.Brown, new Rectangle(p.X - TRI_W / 4, p.Y + 2 * TRI_H, TRI_W / 2, TRI_H));
        }
    }
}
