using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace House
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void PictureBox_Paint(object sender, PaintEventArgs e)
        {
            Roof.Paint(e.Graphics, new Point(320, 100), Brushes.Red, 125, 350);

            Window.Paint(e.Graphics, new Rectangle(320, 320, 100, 100), false);
            Door.Paint(e.Graphics, Brushes.Blue, new Rectangle(50, 400, 60, 130));
        }
    }
}
