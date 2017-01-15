using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadLab4
{
    public class Reader : Runnable
    {
        public Buffer Buffer { get; private set; }
        public int numOfStrings { get; private set; }
        public List<string> StringList { get; private set; }
        public delegate void OnReadDone();
        private OnReadDone onDone;

        /// <summary>
        /// Declares the delegate OnReadDone, the buffer and how many strings from the parameter
        /// </summary>
        /// <param name="onDone"></param>
        /// <param name="buffer"></param>
        /// <param name="numOfStrings"></param>
        public Reader(OnReadDone onDone, Buffer buffer, int numOfStrings)
        {
            this.onDone = onDone;
            this.Buffer = buffer;
            this.numOfStrings = numOfStrings;
            this.StringList = new List<string>(this.numOfStrings);
            base.LoopMethod = ReadLoop;
        }

        /// <summary>
        /// Reads lines from the buffer
        /// </summary>
        public void ReadLoop()
        {
            for (int i = 0; i < numOfStrings && IsRunning; i++)
            {
                string data;
                Buffer.ReadData(out data);
                StringList.Add(data);
            }
            onDone();
        }
    }
}
