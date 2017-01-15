using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace ThreadLab3
{
    class Factory
    {
        private Thread thread;
        private Storage storage;
        private Label factoryStatus;
        private bool isRunning;
        private List<FoodItem> foodList;

        /// <summary>
        /// Constructor that will set our instance variables to the parameters, a new food list and call on InitFoodItems
        /// </summary>
        /// <param name="storage"></param>
        /// <param name="factoryStatus"></param>
        public Factory(Storage storage, Label factoryStatus)
        {
            this.storage = storage;
            this.factoryStatus = factoryStatus;
            foodList = new List<FoodItem>();
            InitFoodItems();
        }

        /// <summary>
        /// Calls upon a method AddFoddItem and passes some arguments
        /// </summary>
        private void InitFoodItems()
        {
            AddFoodItem("Milk", 1.1, 0.5);
            AddFoodItem("Cream", 0.6, 0.1);
            AddFoodItem("Youghurt", 1.1, 0.5);
            AddFoodItem("Butter", 2.34, 0.66);
            AddFoodItem("Flower", 3.4, 1.2);
            AddFoodItem("Sugar", 3.7, 1.8);
            AddFoodItem("Salt", 1.55, 0.27);
            AddFoodItem("Almonds", 0.6, 0.19);
            AddFoodItem("Bread", 1.98, 0.75);
            AddFoodItem("Donuts", 1.4, 0.5);
            AddFoodItem("Jam", 1.3, 15);
            AddFoodItem("Ham", 4.1, 2.5);
            AddFoodItem("Chicken", 6.8, 3.9);
            AddFoodItem("Salat", 0.87, 0.55);
            AddFoodItem("Orange", 2.46, 0.29);
            AddFoodItem("Apple", 2.44, 0.40);
            AddFoodItem("Pear", 1.3, 0.77);
            AddFoodItem("Soda", 2.98, 2.0);
            AddFoodItem("Beer", 3.74, 1.5);
            AddFoodItem("Hotdogs", 2.0, 1.38);
        }

        /// <summary>
        /// Takes in some arguments and uses them to create a new food object and adds it to the foodList
        /// </summary>
        /// <param name="name"></param>
        /// <param name="weight"></param>
        /// <param name="volume"></param>
        private void AddFoodItem(String name, double weight, double volume)
        {
            foodList.Add(new FoodItem(name, weight, volume));
        }

        /// <summary>
        /// Will try to deliver a random foodItem from the foodList to the storage
        /// If the storage is full we will wait some time and try deliver the producedItem again
        /// It will run untill isRunning = false
        /// </summary>
        private void Work()
        {
            Random random = new Random();

            while (isRunning)
            {
                factoryStatus.InvokeUI(() => { factoryStatus.Text = "Status: Producing..."; });
                FoodItem producedItem = foodList[random.Next(0, foodList.Count)];
                Thread.Sleep(900);

                if (!isRunning)
                {
                    break;
                }
                factoryStatus.InvokeUI(() => { factoryStatus.Text = "Status: Delivering..."; });

                while (!storage.DeliverItem(producedItem) && isRunning)
                {
                    factoryStatus.InvokeUI(() => { factoryStatus.Text = "Status: Full waiting..."; });
                    Thread.Sleep(1000);
                }
                Thread.Sleep(300);
            }
        }

        /// <summary>
        /// Sets isRunning to true and starts a new thread of the method Work and starts it
        /// </summary>
        public void Start()
        {
            isRunning = true;
            thread = new Thread(Work);
            thread.Start();
        }

        /// <summary>
        /// Sets isRunning to false which will end the loops in the method Work and sets the status to Stopped
        /// </summary>
        public void Stop()
        {
            isRunning = false;
            factoryStatus.InvokeUI(() => { factoryStatus.Text = "Status: Stopped..."; });
        }

        /// <summary>
        /// Sets isRunning to false which will end the loops in the method Work and closes the thread
        /// </summary>
        public void closeThread()
        {
            isRunning = false;

            if (thread != null && thread.IsAlive)
            {
                thread.Join();
            }
        }
    }
}