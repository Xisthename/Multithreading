using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ThreadLab5
{
    class Car
    {
        private int timer;
        private Color carColor;
        private RectangleF rect;

        /// <summary>
        /// Create a Car
        /// </summary>
        /// <param name="timer">Time to park</param>
        public Car(int timer, Color carColor)
        {
            this.timer = timer;
            this.carColor = carColor;
        }
       
        /// <summary>
        /// A simple method returns false until it's time to leave the parking house
        /// </summary>
        /// <returns></returns>
        public bool TimeToLeave()
        {
            timer--;

            if (timer <= 0)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Sets up the cars rectangle
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        public void setCarRect(float x, float y, float width, float height)
        {
            rect = new RectangleF(x, y, width, height);
        }

        /// <summary>
        /// Gets the cars rectangle
        /// </summary>
        /// <returns></returns>
        public RectangleF getCarRect()
        {
            return rect;
        }

        /// <summary>
        /// Gets the cars color
        /// </summary>
        /// <returns></returns>
        public Color getCarColor()
        {
            return carColor;
        }
    }
}
