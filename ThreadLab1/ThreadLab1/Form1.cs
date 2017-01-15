using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadLab1
{
    public partial class Screen : Form
    {
        /// <summary>
        /// Creating two refrence to the classes DisplayMessage and Triangle
        /// Creating two Thread variables 
        /// Creating two flags and setting them to false
        /// </summary>
        private DisplayMessage welcome;
        private Triangle triangle;
        private Thread welcomeThread;
        private Thread triangleThread;
        private bool runWelcome = false;
        private bool runTriangle = false;

        public Screen()
        {
            InitializeComponent();
        }

        /// <summary>
        /// If our runWelcome flag = false we will set it to true, create the necessary graphics 
        /// and start a new thread that will run untill runWelcome flag is decleared false again.
        /// While the thread is running we will call on a method that passes the graphics to a method inside
        /// of the class Displaymessage
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void welcomeStart_Click(object sender, EventArgs e)
        {
            welcome = new DisplayMessage(welcomePanel, "Welcome");

            if (!runWelcome)
            {
                runWelcome = true;
                (welcomeThread = new Thread(() =>
                {
                    while (runWelcome)
                    {
                        welcome.Draw();
                    }

                })).Start();
            }
            welcomeStart.Enabled = false;
            welcomeStop.Enabled = true;
        }

        /// <summary>
        /// Sets runWelcome flag to false which will stop the while loop -> while (runWelcome)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void welcomeStop_Click(object sender, EventArgs e)
        {
            runWelcome = false;
            welcomeStart.Enabled = true;
            welcomeStop.Enabled = false;
        }

        /// <summary>
        /// If our runTriangle flag = false we will set it to true, create the necessary graphics 
        /// and start a new thread that will run untill runTriangle flag is decleared false again.
        /// While the thread is running we will call on a method that passes the graphics to a method inside
        /// of the class Triangle
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void triangleStart_Click(object sender, EventArgs e)
        {
            triangle = new Triangle(trianglePanel, 40);

            if (!runTriangle)
            {
                runTriangle = true;
                Graphics graphics = trianglePanel.CreateGraphics();
                (triangleThread = new Thread(() =>
                {
                    while (runTriangle)
                    {
                        triangle.Draw();
                    }

                })).Start();
            }
            triangleStart.Enabled = false;
            triangleStop.Enabled = true;
        }

        /// <summary>
        /// Sets runTriangle flag to false which will stop the while loop -> while (runTriangle)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void triangleStop_Click(object sender, EventArgs e)
        {
            runTriangle = false;
            triangleStart.Enabled = true;
            triangleStop.Enabled = false;
        }

        /// <summary>
        /// When the application is closed if also put our threads to sleep if they are running
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Screen_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (runWelcome)
            {
                runWelcome = false;
                welcomeThread.Join();
            }

            if (runTriangle)
            {
                runTriangle = false;
                triangleThread.Join();
            }
        }
    }
}