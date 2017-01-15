using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace ThreadLab3
{
    class Storage
    {
        private ProgressBar storageBar;
        private Label storageLabel;
        private int maxItems;
        private Queue<FoodItem> storageBuffer;
        private Semaphore fullSemaphore;
        private Semaphore emptySemaphore;
        private Mutex storageMutex;

        /// <summary>
        /// Constructor that takes in a progressBar and a label and just set our instance variables to these parameters
        /// </summary>
        /// <param name="storageBar"></param>
        /// <param name="storageLabel"></param>
        public Storage(ProgressBar storageBar, Label storageLabel, int maxItems)
        {
            this.storageBar = storageBar;
            this.storageLabel = storageLabel;
            this.maxItems = maxItems;
            storageBuffer = new Queue<FoodItem>(maxItems);
            emptySemaphore = new Semaphore(0, maxItems);
            fullSemaphore = new Semaphore(maxItems, maxItems);
            storageMutex = new Mutex();
        }

        /// <summary>
        /// Takes in the producedItem and if the storageBuffer contains more items than maxItems it returns false
        /// Otherwise we add the producedItem to the queue inside the storageBuffer, updates the UI and return true
        /// </summary>
        /// <param name="producedItem"></param>
        /// <returns></returns>
        public bool DeliverItem(FoodItem producedItem)
        {
            fullSemaphore.WaitOne();
            storageMutex.WaitOne();
            storageBuffer.Enqueue(producedItem);
            storageBar.InvokeUI(() => { storageBar.Value += (int) ((1f / maxItems) * 100); });
            storageLabel.InvokeUI(() => { storageLabel.Text = storageBuffer.Count + "/" + maxItems; });
            storageMutex.ReleaseMutex();
            emptySemaphore.Release();
            return true;
        }

        /// <summary>
        /// Takes away an item from the queue, update the UI and return true
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public FoodItem GetItem()
        {
            emptySemaphore.WaitOne();
            storageMutex.WaitOne();
            storageBar.InvokeUI(() => { storageBar.Value -= (int)((1f / maxItems) * 100); });
            FoodItem item = storageBuffer.Dequeue();
            storageLabel.InvokeUI(() => { storageLabel.Text = (storageBuffer.Count + "/" + maxItems); });
            storageMutex.ReleaseMutex();
            fullSemaphore.Release();
            return item;
        }
    }
}
