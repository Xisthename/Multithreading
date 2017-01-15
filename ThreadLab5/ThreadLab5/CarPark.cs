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
    class CarPark
    {
        public enum State { EMPTY, FILLED }
        public bool Running { get; set; }
        public int Count { get; set; }
        private Random Random { get; set; }
        private Car[] parkedCars;
        private CarQueue[] queues;
        private State[] state;
        private Label carParkLabel;

        /// <summary>
        /// UI related stuff underneath
        /// </summary>
        private Graphics g;
        private float panelWidth;
        private float panelHeight;
        private float carSide;
        private float[] positionX;
        private float[] positionY;
        private float resetRow = 0;

        /// <summary>
        /// Sets up necessary stuff, the queues, a car array, how long a car side should be depending on the parking slots
        /// And the locations of every single parking place that are stored in the arryas positionX and positionY
        /// </summary>
        public CarPark(CarQueue[] queues, Panel carParkPanel, Label carParkLabel, int slots)
        {
            this.queues = queues;
            this.carParkLabel = carParkLabel;
            this.Random = new Random();
            this.state = new State[slots];
            this.parkedCars = new Car[slots];


            g = carParkPanel.CreateGraphics();
            panelWidth = g.VisibleClipBounds.Width;
            panelHeight = g.VisibleClipBounds.Height;

            float parkArea = (float) (panelWidth * panelHeight);
            float carArea = (parkArea / slots);
            carSide = (float) Math.Sqrt(carArea);

            positionX = new float[slots];
            positionY = new float[slots];

            for (int i = 0; i < slots; i++)
            {
                if (i != 0)
                {
                    positionX[i] = positionX[i - 1] + carSide;
                    positionY[i] = positionY[i - 1];

                    if (positionX[i] > panelWidth - carSide)
                    {
                        positionX[i] = resetRow;

                        positionY[i] = positionY[i - 1] + carSide;

                        if (positionY[i] > panelHeight - carSide)
                        {
                            positionY[i] = resetRow;
                        }
                    }
                }
                else
                {
                    positionX[i] = resetRow;
                    positionY[i] = resetRow;
                }
            }
        }

        /// <summary>
        /// Starts with checking for place inside of the parking house (index = -1 -> no place)
        /// 
        /// If there are space left we let a in car from one of the queues if there were no car to be found at the queue
        /// Then we will do nothing
        /// But if a car is found we change the state of the indexed parking place to FILLED and add the car to the
        /// array of parked cars. We add one to the counter of parkedcars (note that count cannot be replaced by index)
        /// Then we set the cars rectangle which is pretty much where the car is parked and how much space it's taking up
        /// We paint the car with it's color which tells us from what entrance the car came from. Then update UI
        /// 
        /// When this is done we call upon the method CheckCars which will check if it's time for a car to leave
        /// After all this is done we deserve some sleep
        /// </summary>
        public void Run()
        {
            Running = true;

            while (Running)
            {
                int index = GetSpaceIndex();

                if (index != -1)
                {
                    int queue = Random.Next(0, 4);
                    Car car = queues[queue].GetCar();

                    if (car != null)
                    {
                        state[index] = State.FILLED;
                        parkedCars[index] = car;
                        Count++;

                        car.setCarRect(positionX[index], positionY[index], carSide, carSide);
                        g.FillRectangle(new SolidBrush(car.getCarColor()), car.getCarRect());

                        carParkLabel.Invoke(new MethodInvoker(() => { carParkLabel.Text = Count + "/" + parkedCars.Length; }));
                    }
                }
                CheckCars();
                Thread.Sleep(20);
            }
        }

        /// <summary>
        /// Loops through all the parked cars and checks if it's time for any of them to leave the parking house
        /// If so we clear the recangle by painting over it, sets the place to EMPTY, 
        /// removes the car from the array of parked cars and reduces the counter by one and finnaly update the UI
        /// </summary>
        private void CheckCars()
        {
            for (int i = 0; i < parkedCars.Length; i++)
            {
                if (state[i] == State.FILLED)
                {
                    if (parkedCars[i].TimeToLeave())
                    {
                        g.FillRectangle(new SolidBrush(Color.LightGray), parkedCars[i].getCarRect());
                        state[i] = State.EMPTY;
                        parkedCars[i] = null;
                        Count--;
                        carParkLabel.Invoke(new MethodInvoker(() => { carParkLabel.Text = Count + "/" + parkedCars.Length; }));
                    }
                }
            }
        }

        /// <summary>
        /// Loops through the parked cars array looking for an empty place
        /// If a place that index will be returned otherwise -1 will be returnd
        /// </summary>
        /// <returns></returns>
        private int GetSpaceIndex()
        {
            for (int i = 0; i < parkedCars.Length; i++)
            {
                if (state[i] == State.EMPTY)
                {
                    return i;
                }
            }
            return -1;
        }

        /// <summary>
        /// Clears the UI
        /// </summary>
        public void ClearUI()
        {
            carParkLabel.Invoke(new MethodInvoker(() => { carParkLabel.Text = "0/" + parkedCars.Length; }));
            g.Clear(Color.LightGray);
        }
    }
}
