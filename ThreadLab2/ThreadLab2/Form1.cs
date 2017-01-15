using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ThreadLab2
{
    public partial class Screen : Form
    {
        /// <summary>
        /// Just some variables that we will use and declare later on
        /// </summary>
        private Buffer<char> buffer;
        private Reader reader;
        private Writer writer;

        private Thread readerThread;
        private Thread writerThread;

        private String transferText;

        public Screen()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Reads the string that will be transferd and send the sync state to the buffer
        /// Creates two reference to the writer and reader classes 
        /// Starts writer and reader thread and telling them to run the methods Write and Read
        /// We will of course disable the run button too
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void runButton_Click(object sender, EventArgs e)
        {
            transferText = transferTextBox.Text;
            buffer = new Buffer<char>();

            if (!transferText.Equals(""))
            {
                if (syncButton.Checked)
                {
                    buffer.Sync = true;
                }
                else
                {
                    buffer.Sync = false;
                }
                writer = new Writer(buffer, transferText, writeLogger, writerResult);
                reader = new Reader(buffer, transferText, readLogger, readerResult);

                writerThread = new Thread(new ThreadStart(writer.Write));
                readerThread = new Thread(new ThreadStart(reader.Read));

                writerThread.Start();
                readerThread.Start();

                runButton.Enabled = false;
            }
        }

        /// <summary>
        /// Just clears some text, enables the runButton and disables this button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clearButton_Click(object sender, EventArgs e)
        {
            writerResult.Text = "";
            readerResult.Text = "";
            matchLabel.Text = "";

            writeLogger.Items.Clear();
            readLogger.Items.Clear();

            runButton.Enabled = true;
            clearButton.Enabled = false;

            colorPanel.BackColor = Color.LightGray;
        }

        /// <summary>
        /// When the ReaderThread is done it will update the text ih the readerResult label
        /// Checks the results from the writer result and the reader result
        /// Some text are displayed and a panel will change it's color and we also enable the clearButton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void readerResult_TextChanged(object sender, EventArgs e)
        {
            if (!readerResult.Text.Equals(""))
            {
                if (writerResult.Text.Equals(readerResult.Text))
                {
                    matchLabel.Text = "Match!";
                    colorPanel.BackColor = Color.Green;
                }
                else
                {
                    matchLabel.Text = "No match!";
                    colorPanel.BackColor = Color.Red;
                }
                clearButton.Enabled = true;
            }
        }

        /// <summary>
        /// When the appliction is closing we have to close the threads: writerThread and readerThread
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Screen_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (writerThread != null)
            {
                writerThread.Abort();
            }

            if (readerThread != null)
            {
                readerThread.Abort();
            }
        }
    }
}
