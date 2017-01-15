using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace ThreadLab2
{
    class Writer
    {
        public Buffer<char> Buffer { get; private set; }

        private string text;
        private ListBox writeList;
        private Label resultLabel;
        private Random random;

        private delegate void AddChar(String text);
        private delegate void DisplayString(String text);

        /// <summary>
        /// The constructor takes in some references and declare the instance variables to them 
        /// A random object is also created
        /// </summary>
        /// <param name="buffer"></param>
        /// <param name="text"></param>
        /// <param name="writeList"></param>
        /// <param name="resultLabel"></param>
        public Writer(Buffer<char> buffer, String text, ListBox writeList, Label resultLabel)
        {
            this.Buffer = buffer;
            this.text = text;
            this.writeList = writeList;
            this.resultLabel = resultLabel;
            random = new Random();
        }
        
        /// <summary>
        /// A method that will lopp through the text one char at the time and passing it through to the buffer
        /// As it goes through each char it will call on a method called WriteChar
        /// When it has looped through the whole string the method WriteResult is called
        /// </summary>
        public void Write()
        {
            for (int i = 0; i < text.Length; i++)
            {
                bool isDone = false;
                while (!isDone)
                {
                    Thread.Sleep(random.Next(200, 5000));

                    char data = text[i];

                    if (!Buffer.SetData(data))
                    {
                        continue;
                    }
                    WriteChar(data.ToString());
                    isDone = true;
                }
            }
            WriteResult();
        }

        /// <summary>
        /// Invokes the writeList to add a char to the listbox
        /// </summary>
        /// <param name="data"></param>
        private void WriteChar(string data)
        {
            writeList.Invoke(new AddChar(DisplayChar), new object[] { data });
        }

        /// <summary>
        /// Takes in a string and adds it to the listbox called writeList
        /// </summary>
        /// <param name="text"></param>
        private void DisplayChar(String text)
        {
            writeList.Items.Add(text);
        }

        /// <summary>
        /// Invokes the resultLabel to display the result
        /// </summary>
        private void WriteResult()
        {
            resultLabel.Invoke(new DisplayString(DisplayResult), new object[] { text });
        }

        /// <summary>
        /// Sets resultLabel's text to the parameter string
        /// </summary>
        /// <param name="text"></param>
        private void DisplayResult(String text)
        {
            resultLabel.Text = text;
        }
    }
}
