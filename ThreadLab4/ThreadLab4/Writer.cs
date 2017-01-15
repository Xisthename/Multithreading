using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadLab4
{
    public class Writer : Runnable
    {
        public List<string> TextToWrite { get; private set; }
        public Buffer Buffer { get; private set; }

        /// <summary>
        /// Declares the buffer and the string list from the parameter
        /// </summary>
        /// <param name="buffer"></param>
        /// <param name="textToWrite"></param>
        public Writer(Buffer buffer, List<string> textToWrite)
        {
            this.TextToWrite = textToWrite;
            this.Buffer = buffer;
            base.LoopMethod = WriteLoop;
        }

        /// <summary>
        /// Writes lines to the buffer
        /// </summary>
        public void WriteLoop()
        {
            while (TextToWrite.Count > 0 && IsRunning)
            {
                string data = TextToWrite[0];
                Buffer.WriteData(data);
                TextToWrite.RemoveAt(0);
            }
        }
    }
}

