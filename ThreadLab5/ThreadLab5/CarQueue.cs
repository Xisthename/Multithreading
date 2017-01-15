using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Drawing;

namespace ThreadLab5
{
    class CarQueue
    {
        private Queue<Car> queue;
        public int Count { get { return queue.Count; } }
        private object LockObject { get; set; }
        private Random Random { get; set; }
        public bool Running { get; set; }
        private int maxNumber;
        private Label carLabel;
        private Color carColor;

        /// <summary>
        /// Takes in how many can be in this queue, the label to update the UI and what color the car has
        /// </summary>
        /// <param name="maxNumber"></param>
        /// <param name="carLabel"></param>
        /// <param name="carColor"></param>
        public CarQueue(int maxNumber, Label carLabel, Color carColor)
        {
            this.maxNumber = maxNumber;
            this.carLabel = carLabel;
            this.carColor = carColor;
            queue = new Queue<Car>(maxNumber);
            Random = new Random();
            LockObject = new object();
        }

        /// <summary>
        /// starts a while loop that will create cars and put them into the queue and of course update the UI
        /// </summary>
        public void Run()
        {
            queue.Clear();
            Running = true;

            while (Running)
            {
                lock (LockObject)
                {
                    if (Count < maxNumber)
                    {
                        queue.Enqueue(new Car(Random.Next(100, 2400), carColor));
                        carLabel.Invoke(new MethodInvoker(() => { carLabel.Text = Count + "/" + maxNumber; }));
                    }
                }
                Thread.Sleep(Random.Next(800, 1500));
            }
        }

        /// <summary>
        /// Tries to take a car from the queue
        /// </summary>
        /// <returns>Car, may be null</returns>
        public Car GetCar()
        {
            lock (LockObject)
            {
                if (Count > 0)
                {
                    Car car = queue.Dequeue();
                    carLabel.Invoke(new MethodInvoker(() => { carLabel.Text = Count + "/" + maxNumber; }));
                    return car;
                }
                return null;
            }
        }

        /// <summary>
        /// Clears the UI
        /// </summary>
        public void ClearUI()
        {
            carLabel.Invoke(new MethodInvoker(() => { carLabel.Text = "0/" + maxNumber; }));
        }
    }
}
