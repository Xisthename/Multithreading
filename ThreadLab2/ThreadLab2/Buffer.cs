using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace ThreadLab2
{
    class Buffer<Char>
    {
        protected Mutex mutex;
        private bool sync;
        protected char data;
        protected bool hasData;

        /// <summary>
        /// Constructor that creates a new Mutex object
        /// </summary>
        public Buffer()
        {
            mutex = new Mutex();
        }

        /// <summary>
        /// Sets the sync bool to false or true when called upon 
        /// </summary>
        public bool Sync
        {
            set { sync = value; }
        }

        /// <summary>
        /// Checks how we are going to sync or not
        /// If we synchronize (sync = true) we firs check if the buffer contains any data if true we return false
        /// If false we use the mutex object to make it thread safe and we will set the data in the buffer
        /// to the one in the parameter
        /// If sync = false we dont thread safe and we will just set the data in the buffer to the parameter (data)
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public bool SetData(char data)
        {
            if (sync)
            {
                if (hasData)
                {
                    return false;
                }
                mutex.WaitOne();
                this.data = data;
                hasData = true;
                mutex.ReleaseMutex();
            }
            else
            {
                this.data = data;
                hasData = true;
            }
            return true;
        }

        /// <summary>
        /// Checks first if we are going to do the transfer synchronized or not
        /// If the syn = true we check if the buffer contains any data
        /// If the buffer has no data we will just return false and in the other classes the loop will continue
        /// But if the buffer has data we will thread safe using the mutex and sets the data to the data in the buffer
        /// The hasData will be set to false and we will return true
        /// When we have no sync (sync = false) we just dont care about making thread safe
        /// This means that the we just transfer the data immediately and return true
        /// (when this is returned true we will pass the data which you can see in the parameter using a "out")
        /// </summary>
        public bool GetData(out char data)
        {
            if (sync)
            {
                if (!hasData)
                {
                    data = default(char);
                    return false;
                }
                mutex.WaitOne();
                data = this.data;
                hasData = false;
                mutex.ReleaseMutex();
            }
            else
            {
                data = this.data;
                hasData = false;
            }
            return true;
        }
    }
}