using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadLab4
{
    public class Modifier : Runnable
    {
        public Buffer Buffer { get; private set; }
        public int Count { get; private set; }

        /// <summary>
        /// Consctoutor that takes in the shared buffer refrence and the length of the text
        /// </summary>
        /// <param name="buffer"></param>
        /// <param name="textLength"></param>
        public Modifier(Buffer buffer, int textLength)
        {
            this.Buffer = buffer;
            this.Count = textLength;
            base.LoopMethod = ModifierLoop;
        }

        /// <summary>
        ///  The worker loop
        /// </summary>
        public void ModifierLoop()
        {
            for (int i = 0; i < Count && IsRunning; i++)
            {
                Buffer.Modify();
            }
        }
    }
}

