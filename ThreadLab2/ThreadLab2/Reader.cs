using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ThreadLab2
{
    class Reader
    {
        private Buffer<char> Buffer { get; }

        public string text;
        private int count;

        private ListBox readList;
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
        /// <param name="readList"></param>
        /// <param name="resultLabel"></param>
        public Reader(Buffer<char> buffer, String text, ListBox readList, Label resultLabel)
        {
            this.Buffer = buffer;
            this.text = String.Empty;
            this.count = text.Length;
            this.readList = readList;
            this.resultLabel = resultLabel;
            random = new Random();
        }


        /// <summary>
        /// Loops untill the length of text is equal to the length of the transfered text called count
        /// After that we set a temp variable called isDone to false
        /// Goes through another while loop which will run untill isDone is set to true
        /// Sleeps a random period of time
        /// Tries to get data from the buffer and if we get data set IsDone to true otherwise just continue looping
        /// Gets out of Seconed loop and adds the data to text and calls the method WriteChar and passing the data
        /// This procces is repeted untill text length is equal to count
        /// Then the first loop will be exited and we call the method WriteResult
        /// </summary>
        public void Read()
        {
            while (text.Length < count)
            {
                bool isDone = false;
                char data = default(char);

                while (!isDone)
                {
                    Thread.Sleep(random.Next(200, 1000));

                    if (!Buffer.GetData(out data))
                    {
                        continue;
                    }
                    else
                    {
                        isDone = true;
                    }
                }
                text += data;
                WriteChar(data.ToString());
            }
            WriteResult();
        }

        /// <summary>
        /// Invokes the readList to add a char to the listbox
        /// </summary>
        /// <param name="data"></param>
        private void WriteChar(string data)
        {
            readList.Invoke(new AddChar(DisplayChar), new object[] { data });
        }

        /// <summary>
        /// Takes in a string and adds it to the listbox called readList
        /// </summary>
        /// <param name="text"></param>
        private void DisplayChar(String text)
        {
            readList.Items.Add(text);
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
