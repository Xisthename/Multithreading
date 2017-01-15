using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ThreadLab4
{
    public partial class MainForm : Form
    {
        public Buffer Buffer { get; private set; }
        public Modifier Modifier { get; private set; }
        public Writer Writer { get; private set; }
        public Reader Reader { get; private set; }

        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Lets you open a text file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                sourceTextBox.Text = File.ReadAllText(openFileDialog.FileName);
                HighlightText(sourceTextBox, findTextBox.Text);
            }
        }

        /// <summary>
        /// Declares the objects and starts a thread of them
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void copyButton_Click(object sender, EventArgs e)
        {
            this.Buffer = new Buffer(15, sourceTextBox, notifyMe.Checked, findTextBox.Text, replaceTextBox.Text);
            this.Modifier = new Modifier(Buffer, sourceTextBox.Lines.Length);
            this.Reader = new Reader(OnReadDone, Buffer, sourceTextBox.Lines.Length);
            this.Writer = new Writer(Buffer, sourceTextBox.Lines.ToList());
            Writer.Start();
            Reader.Start();
            Modifier.Start();
        }

        /// <summary>
        /// When the reader is done we will update the UI
        /// </summary>
        private void OnReadDone()
        {
            DestinationTab.BeginInvoke(new MethodInvoker(() => { tabController.SelectedIndex = 1; }));
            destinationTextBox.BeginInvoke(new MethodInvoker(() => { destinationTextBox.Lines = Reader.StringList.ToArray(); }));
            replaceCountLabel.BeginInvoke(new MethodInvoker(() => { replaceCountLabel.Text = Buffer.NumOfReplacements.ToString(); }));
            destinationTextBox.BeginInvoke(new MethodInvoker(() => { HighlightText(destinationTextBox, replaceTextBox.Text); }));
        }

        /// <summary>
        /// Clears the destination text
        /// </summary>
        private void clearButton_Click(object sender, EventArgs e)
        {
            HighlightText(destinationTextBox, String.Empty);
            destinationTextBox.Text = string.Empty;
            HighlightText(sourceTextBox, findTextBox.Text);
        }

        /// <summary>
        /// Calls the method HighlightText 
        /// </summary>
        private void findTextBox_TextChanged(object sender, EventArgs e)
        {
            HighlightText(sourceTextBox, findTextBox.Text);
        }

        /// <summary>
        /// First we take all the text and change it's color to white and black because of previous uses
        /// Then we will check if the word is an empty string we will exit the method instantly
        /// If word isn't empty we will loop through all the text looking for that exact string
        /// And if we find a string that matches we will highlight that word with green color
        /// This process is continuing until we run out of text
        /// </summary>
        /// <param name="textBox">Source text box</param>
        /// <param name="word">Word to match.</param>
        public void HighlightText(RichTextBox textBox, string word)
        {
            textBox.SelectAll();
            textBox.SelectionBackColor = Color.White;
            textBox.SelectionColor = Color.Black;
            textBox.DeselectAll();

            if (word == "")
            {
                return;
            }

            int stringStart = textBox.SelectionStart;
            int maxIndex = textBox.TextLength;
            int currentIndex = 0;
            int index;

            while ((index = textBox.Text.IndexOf(word, currentIndex)) != -1)
            {
                textBox.Select(index, word.Length);
                textBox.SelectionColor = Color.White;
                textBox.SelectionBackColor = Color.Green;
                currentIndex = index + word.Length;
            }

            textBox.SelectionStart = stringStart;
            textBox.SelectionLength = 0;
            textBox.SelectionColor = Color.Black;
            textBox.SelectionBackColor = Color.White;
        }

        /// <summary>
        /// When the form is closing we stop and close threads
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Reader != null)
            {
                Reader.StopAndJoin();
            }

            if (Writer != null)
            {
                Writer.StopAndJoin();
            }

            if (Modifier != null)
            {
                Modifier.StopAndJoin();
            }
        }
    }
}
