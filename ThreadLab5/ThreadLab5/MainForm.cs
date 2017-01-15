using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadLab5
{
    public partial class MainForm : Form
    {
        private CarQueue[] queues;
        private CarPark carPark;
        private Task[] tasks;

        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Sets up an array of 5 tasks (1 CarPark task and 4 queue tasks)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            tasks = new Task[5];
        }

        /// <summary>
        /// Sets up 4 CarQueue objects with a queue that can hold 5 cars at most
        /// Sets up the parkingplace and we make 100 places to park in 
        /// Can be changed to any number and the gui will adapte to the number
        /// (The "cars" will get smaller if you set a high number)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void startButton_Click(object sender, EventArgs e)
        {
            startButton.Enabled = false;
            stopButton.Enabled = true;

            queues = new CarQueue[4];
            queues[0] = new CarQueue(5, carRedLabel, Color.Red);
            queues[1] = new CarQueue(5, carGreenbel, Color.Green);
            queues[2] = new CarQueue(5, carBlueLabel, Color.Blue);
            queues[3] = new CarQueue(5, carYellowLabel, Color.Yellow);

            carPark = new CarPark(queues, carParkPanel, carParkLabel, 1000);

            tasks[0] = Task.Factory.StartNew(carPark.Run);
            tasks[1] = Task.Factory.StartNew(queues[0].Run);
            tasks[2] = Task.Factory.StartNew(queues[1].Run);
            tasks[3] = Task.Factory.StartNew(queues[2].Run);
            tasks[4] = Task.Factory.StartNew(queues[3].Run);
        }

        /// <summary>
        /// Ends all while loops, clears the tasks and clears the UI too
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void stopButton_Click(object sender, EventArgs e)
        {
            carPark.Running = false;
            queues[0].Running = false;
            queues[1].Running = false;
            queues[2].Running = false;
            queues[3].Running = false;

            for (int i = 0; i < tasks.Length; i++)
            {
                tasks[i].Wait();
            }

            for (int i = 0; i < tasks.Length; i++)
            {
                tasks[i] = null;
            }

            for (int i = 0; i < queues.Length; i++)
            {
                queues[i].ClearUI();
            }
            carPark.ClearUI();

            startButton.Enabled = true;
            stopButton.Enabled = false;
        }

        /// <summary>
        /// Ends all while loops before we close the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (carPark != null)
            {
                carPark.Running = false;
                queues[0].Running = false;
                queues[1].Running = false;
                queues[2].Running = false;
                queues[3].Running = false;
            }
        }
    }
}
