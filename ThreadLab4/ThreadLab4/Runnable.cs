using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadLab4
{
    public abstract class Runnable
    {
        public Thread Thread { get; private set; }
        public ThreadStart LoopMethod { get; protected set; }
        public bool IsRunning { get; protected set; }

        /// <summary>
        /// Starts a new thread if a one isn't already running
        /// </summary>
        public void Start()
        {
            if ((Thread != null && Thread.IsAlive) || IsRunning)
            {
                return;
            }

            IsRunning = true;
            Thread = new Thread(LoopMethod);
            Thread.Start();
        }

        /// <summary>
        /// Stop working
        /// </summary>
        public void Stop()
        {
            IsRunning = false;
        }

        /// <summary>
        /// Stop working and close the thread
        /// </summary>
        public void StopAndJoin()
        {
            IsRunning = false;

            if (Thread != null && Thread.IsAlive)
            {
                Thread.Join();
            }
        }
    }
}

