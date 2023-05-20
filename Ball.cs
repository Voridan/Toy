using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Toy
{
    public class Ball: PictureBox
    {
        public int Cost { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public Ball(int width, int height)
        {
            Random rnd = new Random();
            int size = rnd.Next(30, 50);
            X = rnd.Next(0, width - size - 50); // Random x position
            Y = rnd.Next(0, height - size - 150); // Random y position
            BackColor = Colors.GetRandomColor();
            Cost = Colors.GetColorCost(BackColor);
            Location = new Point(X, Y);
            Cursor = Cursors.Hand;
            
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, size, size);
            Region = new Region(path); // Create a circular shape
        }
    }
}
