using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormTestTPT.Util
{
    public class Tool
    {
        public static void PaintGradientBackground(Control sender, PaintEventArgs e, Color a, Color b, float angle)
        {
            Graphics graphics = e.Graphics;
            RectangleF gradient_rectangle = new RectangleF(0, 0, sender.Width, sender.Height);
            Brush br = new System.Drawing.Drawing2D.LinearGradientBrush(gradient_rectangle, a, b, angle);
            graphics.FillRectangle(br, gradient_rectangle);
        }
    }
}
