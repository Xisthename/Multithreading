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
    class DisplayMessage
    {
        private Graphics g;
        private string message;

        /// <summary>
        /// Gets a string as parameter and sets our variable to it's value
        /// </summary>
        /// <param name="message"></param>
        public DisplayMessage(Panel panel, string message)
        {
            g = panel.CreateGraphics();
            this.message = message;
        }


        /// <summary>
        /// First we measure the message graphics size after that we create a random width and height. 
        /// Two simple checks are made to make sure that the text is going to stay in the panel at all time.
        /// Then the text is placed and drawn.
        /// </summary>
        public void Draw()
        {
            g.Clear(Color.Gray);
            g.ResetTransform();

            Font font = new Font("Arial", 16);
            SizeF messageSize = g.MeasureString(message, font);

            Random random = new Random();
            float width = (float) random.NextDouble() * g.VisibleClipBounds.Width;
            float height = (float) random.NextDouble() * g.VisibleClipBounds.Height;

            if (width >= g.VisibleClipBounds.Width - messageSize.Width)
            {
                width = g.VisibleClipBounds.Width - messageSize.Width;
            }

            if (height >= g.VisibleClipBounds.Height - messageSize.Height)
            {
                height = g.VisibleClipBounds.Height - messageSize.Height;
            }
            g.TranslateTransform(width, height);
            g.DrawString(message, font, new SolidBrush(Color.Black), 0, 0);
            Thread.Sleep(200);
        }
    }
}
