using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace ThreadLab1
{
    class Triangle
    {
        private Graphics g;
        private PointF[] vertices;
        private float angle;

        /// <summary>
        /// Gets the size in and are using it to create 3 points in the vertices array
        /// </summary>
        /// <param name="size"></param>
        public Triangle(Panel panel, int size)
        {
            g = panel.CreateGraphics();
            vertices = new PointF[3];
            vertices[0] = new PointF(0, -size / 2);
            vertices[1] = new PointF(-size / 2, size / 2);
            vertices[2] = new PointF(size / 2, size / 2);
        }

        /// <summary>
        /// Draws a Polygon of the vertices array and rotates it. Using the graphics in this case from a panel
        /// </summary>
        public void Draw()
        {
            g.Clear(Color.Gray);
            g.ResetTransform();
            g.TranslateTransform(g.VisibleClipBounds.Width / 2, g.VisibleClipBounds.Height / 2);
            angle += 10;
            g.RotateTransform(angle);
            g.DrawPolygon(new Pen(new SolidBrush(Color.Black), 3), vertices);
            Thread.Sleep(200);
        }
    }
}
