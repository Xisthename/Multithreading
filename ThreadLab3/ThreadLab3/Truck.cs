using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace ThreadLab3
{
    class Truck
    {
        private Thread thread;
        private Storage storage;
        private Label itemLabel;
        private Label weightLabel;
        private Label volumeLabel;
        private Label statusLabel;
        private Button startButton;
        private Button stopButton;
        private CheckBox checkLoad;
        private ListBox cargoList;
        private bool continueLoading;
        private int maxItems;
        private double maxWeight;
        private double maxVolume;
        private List<FoodItem> truckStorage;

        /// <summary>
        /// Constructor that will set our instance variables to the parameters
        /// </summary>
        /// <param name="storage"></param>
        /// <param name="itemLabel"></param>
        /// <param name="weightLabel"></param>
        /// <param name="volumeLabel"></param>
        /// <param name="statusLabel"></param>
        /// <param name="startButton"></param>
        /// <param name="stopButton"></param>
        /// <param name="checkLoad"></param>
        /// <param name="cargoList"></param>
        /// <param name="maxItems"></param>
        /// <param name="maxWeight"></param>
        /// <param name="maxVolume"></param>
        public Truck(Storage storage, Label itemLabel, Label weightLabel, Label volumeLabel, Label statusLabel, Button startButton, Button stopButton, CheckBox checkLoad, ListBox cargoList, int maxItems, double maxWeight, double maxVolume)
        {
            this.storage = storage;
            this.itemLabel = itemLabel;
            this.weightLabel = weightLabel;
            this.volumeLabel = volumeLabel;
            this.statusLabel = statusLabel;
            this.startButton = startButton;
            this.stopButton = stopButton;
            this.checkLoad = checkLoad;
            this.cargoList = cargoList;
            this.maxItems = maxItems;
            this.maxWeight = maxWeight;
            this.maxVolume = maxVolume;
            truckStorage = new List<FoodItem>();
        }

        /// <summary>
        /// First we check if continueLoading is true
        /// If true we update the status to Loading...
        /// We go into another loop that will run untill continueLoading we break out of it
        /// We will call the method IsFull which will return false if there are space in the truck
        /// Then we will get an item from the storage and add it to our truck and call on the method UpdateLabels
        /// Then we sleep 250 ms and do the procces all over again (2a loop)
        /// After a while the truck will be full and then we will update the status to Truck is full and break the loop
        /// Once the 2a loop is done we update the status to Delivering and sleep for 1500 ms (1.5 sec)
        /// Now we loop through all the items in the truck and add the item name to the UI
        /// After that we clear the truck of it's items, call upon UpdateLabels again and status = Returning to Storage...
        /// Now we have worked alot and need some rest so we sleep 5000 ms
        /// When we are back at the storage we check if the checkbox is checked to keep on loading or not
        /// If the checkbox is checked (true) we will start all over again
        /// If not checked (false) we will set continueLoading to false, update the buttons and status = Waiting...
        /// It's work is then done
        /// </summary>
        private void Work()
        {
            while (continueLoading)
            {
                statusLabel.InvokeUI(() => { statusLabel.Text = "Loading..."; });

                while (continueLoading)
                {
                    if (IsFull())
                    {
                        statusLabel.InvokeUI(() => { statusLabel.Text = "Truck is full!"; });
                        Thread.Sleep(850);
                        break;
                    }
                    truckStorage.Add(storage.GetItem());
                    UpdateLabels();
                    Thread.Sleep(250);
                }

                if (!continueLoading)
                {
                    break;
                }
                statusLabel.InvokeUI(() => { statusLabel.Text = "Delivering..."; });
                Thread.Sleep(1500);

                foreach (FoodItem foodItem in truckStorage)
                {
                    cargoList.InvokeUI(() => { cargoList.Items.Add(foodItem.getName()); });
                    statusLabel.InvokeUI(() => { statusLabel.Text = "Deliver: " + foodItem.getName(); });
                    Thread.Sleep(150);
                }
                truckStorage.Clear();
                UpdateLabels();
                statusLabel.InvokeUI(() => { statusLabel.Text = "Returning to Storage..."; });
                Thread.Sleep(5000);

                if (!checkLoad.Checked)
                {
                    continueLoading = false;
                    UpdateButtons();
                    statusLabel.InvokeUI(() => { statusLabel.Text = "Waiting..."; });
                }
            }
        }

        /// <summary>
        /// If items, weight or volume is over it's max limit we will return true otherwise we return false
        /// </summary>
        /// <returns></returns>
        private bool IsFull()
        {
            if (truckStorage.Count >= maxItems) return true;
            if (truckStorage.Sum(x => x.GetWeight()) >= maxWeight) return true;
            if (truckStorage.Sum(x => x.GetVolume()) >= maxVolume) return true;

            return false;
        }

        /// <summary>
        /// A simple method that updates the labels to their current values
        /// </summary>
        private void UpdateLabels()
        {
            itemLabel.InvokeUI(() => { itemLabel.Text = truckStorage.Count + "/" + maxItems; });
            weightLabel.InvokeUI(() => { weightLabel.Text = truckStorage.Sum(x => x.GetWeight()) + "/" + maxWeight; });
            volumeLabel.InvokeUI(() => { volumeLabel.Text = truckStorage.Sum(x => x.GetVolume()) + "/" + maxVolume; });
        }

        /// <summary>
        /// A method used to enable and disable 2 buttons
        /// </summary>
        private void UpdateButtons()
        {
            startButton.InvokeUI(() => { startButton.Enabled = true; });
            stopButton.InvokeUI(() => { stopButton.Enabled = false; });
        }

        /// <summary>
        /// Sets continueLoading to true and starts a new thread of the method Work and starts it
        /// </summary>
        public void Start()
        {
            continueLoading = true;
            thread = new Thread(Work);
            thread.Start();
        }

        /// <summary>
        /// Sets continueLoading to false which will end the loops in the method Work
        /// Sets the status to Waiting
        /// </summary>
        public void Stop()
        {
            continueLoading = false;
            statusLabel.InvokeUI(() => { statusLabel.Text = "Waiting..."; });
        }

        /// <summary>
        /// Sets continueLoading to false which will end the loops in the method Work and closes the thread
        /// </summary>
        public void closeThread()
        {
            continueLoading = false;

            if (thread != null && thread.IsAlive)
            {
                thread.Join();
            }
        }
    }
}
