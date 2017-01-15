using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadLab4
{
    public class Buffer
    {
        /// <summary>
        /// The three states that the buffer can be in
        /// </summary>
        public enum BufferStates
        {
            Empty, Checked, New
        }

        /// <summary>
        /// Number of replacements that were done
        /// </summary>
        public int NumOfReplacements { get; private set; }

        private string[] stringBuffer;
        private BufferStates[] state;

        private object bufferLock;

        private int max;
        private int writePosition;
        private int readPosition;
        private int findPosition;
        private int linesModified;

        private bool notify;

        private string findString;
        private string replaceString;

        private RichTextBox textbox;

        /// <summary>
        /// Takes in the necery parameters and declare them and we also setup other things such as the state and the lock
        /// </summary>
        public Buffer(int elements, RichTextBox textbox, bool notify, string findString, string replaceString)
        {
            this.max = elements;
            this.notify = notify;
            this.textbox = textbox;
            this.findString = findString;
            this.replaceString = replaceString;

            this.stringBuffer = new string[max];
            this.state = new BufferStates[max];
            this.bufferLock = new object();
        }

        /// <summary>
        /// First we check so that the findString isn't null nor empty
        /// A loop runs until there are no matches left
        /// If notify = true we will ask the user, regarding a match, every single time we find a match
        /// The match is changed if the user presses "Yes" and no replacement will happen when the user presses "No"
        /// If notify = false we will replace all matches that are found
        /// 
        /// When all this is done or findString was null or empty we go over to the CS
        /// </summary>
        public void Modify()
        {
            string replacedString = stringBuffer[findPosition];

            if (findString != null && findString != "")
            {
                int index = 0;
                string currentLine = stringBuffer[findPosition];

                while ((index = replacedString.IndexOf(findString, Math.Min(index, currentLine.Length))) != -1)
                {
                    bool replace = false;

                    if (notify)
                    {
                        DialogResult result = MessageBox.Show("Replace " + findString + " with " + replaceString + "?", "Replace", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                        if (result == DialogResult.Yes)
                        {
                            replace = true;
                        }
                    }
                    else
                    {
                        replace = true;
                    }

                    if (replace)
                    {
                        replacedString = ReplaceAt(replacedString, index);
                        NumOfReplacements++;
                    }
                    index += replaceString.Length;
                }
            }

            lock (bufferLock)
            {
                while (state[findPosition] != BufferStates.New)
                {
                    Monitor.Wait(bufferLock);
                }
                linesModified++;
                stringBuffer[findPosition] = replacedString;
                state[findPosition] = BufferStates.Checked;
                Monitor.PulseAll(bufferLock);
            }
            findPosition = (findPosition + 1) % max;
        }

        /// <summary>
        /// Reads data from the buffer
        /// </summary>
        /// <param name="data">The read data</param>
        public void ReadData(out string data)
        {
            lock (bufferLock)
            {
                while (state[readPosition] != BufferStates.Checked)
                {
                    Monitor.Wait(bufferLock);
                }
                data = stringBuffer[readPosition];
                state[readPosition] = BufferStates.Empty;
                Monitor.PulseAll(bufferLock);
            }
            readPosition = (readPosition + 1) % max;
        }

        /// <summary>
        /// Writes data to the buffer
        /// </summary>
        /// <param name="data">The write data</param>
        public void WriteData(string data)
        {
            lock (bufferLock)
            {
                while (state[writePosition] != BufferStates.Empty)
                {
                    Monitor.Wait(bufferLock);
                }
                stringBuffer[writePosition] = data;
                state[writePosition] = BufferStates.New;
                Monitor.PulseAll(bufferLock);
            }
            writePosition = (writePosition + 1) % max;
        }

        /// <summary>
        /// Replace the word at a specific position
        /// </summary>
        /// <param name="source"></param>
        /// <param name="pos"></param>
        /// <returns></returns>
        private string ReplaceAt(string source, int pos)
        {
            return source.Substring(0, pos) + replaceString + source.Substring(pos + findString.Length, source.Length - (pos + findString.Length));
        }
    }
}
