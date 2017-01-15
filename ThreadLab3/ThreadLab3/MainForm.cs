using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadLab3
{
    public partial class MainForm : Form
    {
        private Storage storage;
        private Factory factoryScan;
        private Factory factoryArla;
        private Factory factoryAxFood;
        private Truck truckIca;
        private Truck truckCoop;
        private Truck truckCity;

        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Sets up a Storage, 3 Factorys and 3 trucks
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            storage = new Storage(storageBar, storageLabel, 50);
            factoryScan = new Factory(storage, scanStatus);
            factoryArla = new Factory(storage, arlaStatus);
            factoryAxFood = new Factory(storage, axFoodStatus);
            truckIca = new Truck(storage, icaItemsLabel, icaWeightLabel, icaVolumeLabel, icaStatusLabel, icaStart, icaStop, icaCheckLoad, icaCargoList, 15, 27, 12.5);
            truckCoop = new Truck(storage, coopItemsLabel, coopWeightLabel, coopVolumeLabel, coopStatusLabel, coopStart, coopStop, coopCheckLoad, coopCargoList, 12, 31.5, 10.2);
            truckCity = new Truck(storage, cityItemsLabel, cityWeightLabel, cityVolumeLabel, cityStatusLabel, cityStart, cityStop, cityCheckLoad,cityCargoList, 19, 22.3, 17);
        }

        /// <summary>
        /// Starts the factory Scan
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void scanStart_Click(object sender, EventArgs e)
        {
            factoryScan.Start();
            scanStart.Enabled = false;
            scanStop.Enabled = true;
        }

        /// <summary>
        /// Stops the factory Scan
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void scanStop_Click(object sender, EventArgs e)
        {
            factoryScan.Stop();
            scanStart.Enabled = true;
            scanStop.Enabled = false;
        }

        /// <summary>
        /// Starts the factory Arla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void arlaStart_Click(object sender, EventArgs e)
        {
            factoryArla.Start();
            arlaStart.Enabled = false;
            arlaStop.Enabled = true;
        }

        /// <summary>
        /// Stops the factory Arla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void arlaStop_Click(object sender, EventArgs e)
        {
            factoryArla.Stop();
            arlaStart.Enabled = true;
            arlaStop.Enabled = false;
        }

        /// <summary>
        /// Starts the factory AxFood
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void axFoodStart_Click(object sender, EventArgs e)
        {
            factoryAxFood.Start();
            axFoodStart.Enabled = false;
            axFoodStop.Enabled = true;
        }

        /// <summary>
        /// Stops the factory AxFood
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void axFoodStop_Click(object sender, EventArgs e)
        {
            factoryAxFood.Stop();
            axFoodStart.Enabled = true;
            axFoodStop.Enabled = false;
        }

        /// <summary>
        /// Starts the truck to Ica
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void icaStart_Click(object sender, EventArgs e)
        {
            truckIca.Start();
            icaStart.Enabled = false;
            icaStop.Enabled = true;
        }

        /// <summary>
        /// Stops the truck to Ica
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void icaStop_Click(object sender, EventArgs e)
        {
            truckIca.Stop();
            icaStart.Enabled = true;
            icaStop.Enabled = false;
        }

        /// <summary>
        /// Starts the truck to Coop
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void coopStart_Click(object sender, EventArgs e)
        {
            truckCoop.Start();
            coopStart.Enabled = false;
            coopStop.Enabled = true;
        }

        /// <summary>
        /// Stops the truck to Coop
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void coopStop_Click(object sender, EventArgs e)
        {
            truckCoop.Stop();
            coopStart.Enabled = true;
            coopStop.Enabled = false;
        }

        /// <summary>
        /// Starts the truck to City Groos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cityStart_Click(object sender, EventArgs e)
        {
            truckCity.Start();
            cityStart.Enabled = false;
            cityStop.Enabled = true;
        }

        /// <summary>
        /// Stops the truck to City Gross
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cityStop_Click(object sender, EventArgs e)
        {
            truckCity.Stop();
            cityStart.Enabled = true;
            cityStop.Enabled = false;
        }

        /// <summary>
        /// When the application is closing we close all the threads
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            factoryScan.closeThread();
            factoryArla.closeThread();
            factoryAxFood.closeThread();
            truckIca.closeThread();
            truckCoop.closeThread();
            truckCity.closeThread();
        }
    }
}
