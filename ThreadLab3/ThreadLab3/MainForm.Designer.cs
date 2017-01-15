namespace ThreadLab3
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.storageBar = new System.Windows.Forms.ProgressBar();
            this.storagePanel = new System.Windows.Forms.Panel();
            this.storageLabel = new System.Windows.Forms.Label();
            this.storageInfoLabel = new System.Windows.Forms.Label();
            this.icaPanel = new System.Windows.Forms.Panel();
            this.icaStatusHeader = new System.Windows.Forms.Label();
            this.icaStatusPanel = new System.Windows.Forms.Panel();
            this.icaStatusLabel = new System.Windows.Forms.Label();
            this.icaStop = new System.Windows.Forms.Button();
            this.icaStart = new System.Windows.Forms.Button();
            this.icaCheckLoad = new System.Windows.Forms.CheckBox();
            this.icaTruckHeader = new System.Windows.Forms.Label();
            this.icaTruckPanel = new System.Windows.Forms.Panel();
            this.icaWeightLabel = new System.Windows.Forms.Label();
            this.icaVolumeLabel = new System.Windows.Forms.Label();
            this.icaItemsLabel = new System.Windows.Forms.Label();
            this.icaCargoList = new System.Windows.Forms.ListBox();
            this.scanPanel = new System.Windows.Forms.Panel();
            this.scanStop = new System.Windows.Forms.Button();
            this.scanStart = new System.Windows.Forms.Button();
            this.scanStatus = new System.Windows.Forms.Label();
            this.arlaStatus = new System.Windows.Forms.Label();
            this.arlaStart = new System.Windows.Forms.Button();
            this.arlaStop = new System.Windows.Forms.Button();
            this.arlaPanel = new System.Windows.Forms.Panel();
            this.axFoodHeader = new System.Windows.Forms.Label();
            this.axFoodPanel = new System.Windows.Forms.Panel();
            this.axFoodStop = new System.Windows.Forms.Button();
            this.axFoodStart = new System.Windows.Forms.Button();
            this.axFoodStatus = new System.Windows.Forms.Label();
            this.producersPanel = new System.Windows.Forms.Panel();
            this.scanHeader = new System.Windows.Forms.Label();
            this.arlaHeader = new System.Windows.Forms.Label();
            this.producerHeader = new System.Windows.Forms.Label();
            this.consumersPanel = new System.Windows.Forms.Panel();
            this.cityHeader = new System.Windows.Forms.Label();
            this.cityPanel = new System.Windows.Forms.Panel();
            this.cityStatusHeader = new System.Windows.Forms.Label();
            this.cityStatusPanel = new System.Windows.Forms.Panel();
            this.cityStatusLabel = new System.Windows.Forms.Label();
            this.cityStop = new System.Windows.Forms.Button();
            this.cityStart = new System.Windows.Forms.Button();
            this.cityCheckLoad = new System.Windows.Forms.CheckBox();
            this.cityTruckHeader = new System.Windows.Forms.Label();
            this.cityTruckPanel = new System.Windows.Forms.Panel();
            this.cityWeightLabel = new System.Windows.Forms.Label();
            this.cityVolumeLabel = new System.Windows.Forms.Label();
            this.cityItemsLabel = new System.Windows.Forms.Label();
            this.cityCargoList = new System.Windows.Forms.ListBox();
            this.coopHeader = new System.Windows.Forms.Label();
            this.coopPanel = new System.Windows.Forms.Panel();
            this.coopStatusHeader = new System.Windows.Forms.Label();
            this.coopStatusPanel = new System.Windows.Forms.Panel();
            this.coopStatusLabel = new System.Windows.Forms.Label();
            this.coopStop = new System.Windows.Forms.Button();
            this.coopStart = new System.Windows.Forms.Button();
            this.coopCheckLoad = new System.Windows.Forms.CheckBox();
            this.coopTruckHeader = new System.Windows.Forms.Label();
            this.coopTruckPanel = new System.Windows.Forms.Panel();
            this.coopWeightLabel = new System.Windows.Forms.Label();
            this.coopVolumeLabel = new System.Windows.Forms.Label();
            this.coopItemsLabel = new System.Windows.Forms.Label();
            this.coopCargoList = new System.Windows.Forms.ListBox();
            this.icaHeader = new System.Windows.Forms.Label();
            this.consumersHeader = new System.Windows.Forms.Label();
            this.storagePanel.SuspendLayout();
            this.icaPanel.SuspendLayout();
            this.icaStatusPanel.SuspendLayout();
            this.icaTruckPanel.SuspendLayout();
            this.scanPanel.SuspendLayout();
            this.arlaPanel.SuspendLayout();
            this.axFoodPanel.SuspendLayout();
            this.producersPanel.SuspendLayout();
            this.consumersPanel.SuspendLayout();
            this.cityPanel.SuspendLayout();
            this.cityStatusPanel.SuspendLayout();
            this.cityTruckPanel.SuspendLayout();
            this.coopPanel.SuspendLayout();
            this.coopStatusPanel.SuspendLayout();
            this.coopTruckPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // storageBar
            // 
            this.storageBar.Location = new System.Drawing.Point(19, 32);
            this.storageBar.Name = "storageBar";
            this.storageBar.Size = new System.Drawing.Size(785, 40);
            this.storageBar.TabIndex = 0;
            // 
            // storagePanel
            // 
            this.storagePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.storagePanel.Controls.Add(this.storageLabel);
            this.storagePanel.Controls.Add(this.storageBar);
            this.storagePanel.Location = new System.Drawing.Point(14, 605);
            this.storagePanel.Name = "storagePanel";
            this.storagePanel.Size = new System.Drawing.Size(861, 101);
            this.storagePanel.TabIndex = 1;
            // 
            // storageLabel
            // 
            this.storageLabel.AutoSize = true;
            this.storageLabel.Location = new System.Drawing.Point(813, 43);
            this.storageLabel.Name = "storageLabel";
            this.storageLabel.Size = new System.Drawing.Size(36, 17);
            this.storageLabel.TabIndex = 1;
            this.storageLabel.Text = "0/50";
            // 
            // storageInfoLabel
            // 
            this.storageInfoLabel.AutoSize = true;
            this.storageInfoLabel.Location = new System.Drawing.Point(31, 595);
            this.storageInfoLabel.Name = "storageInfoLabel";
            this.storageInfoLabel.Size = new System.Drawing.Size(58, 17);
            this.storageInfoLabel.TabIndex = 1;
            this.storageInfoLabel.Text = "Storage";
            // 
            // icaPanel
            // 
            this.icaPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.icaPanel.Controls.Add(this.icaStatusHeader);
            this.icaPanel.Controls.Add(this.icaStatusPanel);
            this.icaPanel.Controls.Add(this.icaStop);
            this.icaPanel.Controls.Add(this.icaStart);
            this.icaPanel.Controls.Add(this.icaCheckLoad);
            this.icaPanel.Controls.Add(this.icaTruckHeader);
            this.icaPanel.Controls.Add(this.icaTruckPanel);
            this.icaPanel.Controls.Add(this.icaCargoList);
            this.icaPanel.Location = new System.Drawing.Point(10, 25);
            this.icaPanel.Name = "icaPanel";
            this.icaPanel.Size = new System.Drawing.Size(440, 160);
            this.icaPanel.TabIndex = 2;
            // 
            // icaStatusHeader
            // 
            this.icaStatusHeader.AutoSize = true;
            this.icaStatusHeader.Location = new System.Drawing.Point(152, 9);
            this.icaStatusHeader.Name = "icaStatusHeader";
            this.icaStatusHeader.Size = new System.Drawing.Size(48, 17);
            this.icaStatusHeader.TabIndex = 15;
            this.icaStatusHeader.Text = "Status";
            // 
            // icaStatusPanel
            // 
            this.icaStatusPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.icaStatusPanel.Controls.Add(this.icaStatusLabel);
            this.icaStatusPanel.Location = new System.Drawing.Point(140, 18);
            this.icaStatusPanel.Name = "icaStatusPanel";
            this.icaStatusPanel.Size = new System.Drawing.Size(149, 74);
            this.icaStatusPanel.TabIndex = 16;
            // 
            // icaStatusLabel
            // 
            this.icaStatusLabel.AutoSize = true;
            this.icaStatusLabel.Location = new System.Drawing.Point(10, 30);
            this.icaStatusLabel.Name = "icaStatusLabel";
            this.icaStatusLabel.Size = new System.Drawing.Size(67, 17);
            this.icaStatusLabel.TabIndex = 0;
            this.icaStatusLabel.Text = "Waiting...";
            // 
            // icaStop
            // 
            this.icaStop.Enabled = false;
            this.icaStop.Location = new System.Drawing.Point(139, 118);
            this.icaStop.Name = "icaStop";
            this.icaStop.Size = new System.Drawing.Size(150, 32);
            this.icaStop.TabIndex = 8;
            this.icaStop.Text = "Stop";
            this.icaStop.UseVisualStyleBackColor = true;
            this.icaStop.Click += new System.EventHandler(this.icaStop_Click);
            // 
            // icaStart
            // 
            this.icaStart.Location = new System.Drawing.Point(12, 118);
            this.icaStart.Name = "icaStart";
            this.icaStart.Size = new System.Drawing.Size(122, 32);
            this.icaStart.TabIndex = 6;
            this.icaStart.Text = "Start Loading";
            this.icaStart.UseVisualStyleBackColor = true;
            this.icaStart.Click += new System.EventHandler(this.icaStart_Click);
            // 
            // icaCheckLoad
            // 
            this.icaCheckLoad.AutoSize = true;
            this.icaCheckLoad.Location = new System.Drawing.Point(140, 98);
            this.icaCheckLoad.Name = "icaCheckLoad";
            this.icaCheckLoad.Size = new System.Drawing.Size(136, 21);
            this.icaCheckLoad.TabIndex = 15;
            this.icaCheckLoad.Text = "Continue loading";
            this.icaCheckLoad.UseVisualStyleBackColor = true;
            // 
            // icaTruckHeader
            // 
            this.icaTruckHeader.AutoSize = true;
            this.icaTruckHeader.Location = new System.Drawing.Point(27, 9);
            this.icaTruckHeader.Name = "icaTruckHeader";
            this.icaTruckHeader.Size = new System.Drawing.Size(84, 17);
            this.icaTruckHeader.TabIndex = 1;
            this.icaTruckHeader.Text = "Truck Limits";
            // 
            // icaTruckPanel
            // 
            this.icaTruckPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.icaTruckPanel.Controls.Add(this.icaWeightLabel);
            this.icaTruckPanel.Controls.Add(this.icaVolumeLabel);
            this.icaTruckPanel.Controls.Add(this.icaItemsLabel);
            this.icaTruckPanel.Location = new System.Drawing.Point(11, 18);
            this.icaTruckPanel.Name = "icaTruckPanel";
            this.icaTruckPanel.Size = new System.Drawing.Size(122, 94);
            this.icaTruckPanel.TabIndex = 8;
            // 
            // icaWeightLabel
            // 
            this.icaWeightLabel.AutoSize = true;
            this.icaWeightLabel.Location = new System.Drawing.Point(0, 40);
            this.icaWeightLabel.Name = "icaWeightLabel";
            this.icaWeightLabel.Size = new System.Drawing.Size(84, 17);
            this.icaWeightLabel.TabIndex = 2;
            this.icaWeightLabel.Text = "Weight:0/27";
            // 
            // icaVolumeLabel
            // 
            this.icaVolumeLabel.AutoSize = true;
            this.icaVolumeLabel.Location = new System.Drawing.Point(0, 65);
            this.icaVolumeLabel.Name = "icaVolumeLabel";
            this.icaVolumeLabel.Size = new System.Drawing.Size(99, 17);
            this.icaVolumeLabel.TabIndex = 3;
            this.icaVolumeLabel.Text = "Volume:0/12.5";
            // 
            // icaItemsLabel
            // 
            this.icaItemsLabel.AutoSize = true;
            this.icaItemsLabel.Location = new System.Drawing.Point(0, 15);
            this.icaItemsLabel.Name = "icaItemsLabel";
            this.icaItemsLabel.Size = new System.Drawing.Size(73, 17);
            this.icaItemsLabel.TabIndex = 4;
            this.icaItemsLabel.Text = "Items:0/15";
            // 
            // icaCargoList
            // 
            this.icaCargoList.FormattingEnabled = true;
            this.icaCargoList.ItemHeight = 16;
            this.icaCargoList.Location = new System.Drawing.Point(295, 18);
            this.icaCargoList.Name = "icaCargoList";
            this.icaCargoList.Size = new System.Drawing.Size(136, 132);
            this.icaCargoList.TabIndex = 7;
            // 
            // scanPanel
            // 
            this.scanPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.scanPanel.Controls.Add(this.scanStop);
            this.scanPanel.Controls.Add(this.scanStart);
            this.scanPanel.Controls.Add(this.scanStatus);
            this.scanPanel.Location = new System.Drawing.Point(21, 25);
            this.scanPanel.Name = "scanPanel";
            this.scanPanel.Size = new System.Drawing.Size(350, 160);
            this.scanPanel.TabIndex = 8;
            // 
            // scanStop
            // 
            this.scanStop.Enabled = false;
            this.scanStop.Location = new System.Drawing.Point(188, 101);
            this.scanStop.Name = "scanStop";
            this.scanStop.Size = new System.Drawing.Size(122, 32);
            this.scanStop.TabIndex = 7;
            this.scanStop.Text = "Stop";
            this.scanStop.UseVisualStyleBackColor = true;
            this.scanStop.Click += new System.EventHandler(this.scanStop_Click);
            // 
            // scanStart
            // 
            this.scanStart.Location = new System.Drawing.Point(31, 101);
            this.scanStart.Name = "scanStart";
            this.scanStart.Size = new System.Drawing.Size(122, 32);
            this.scanStart.TabIndex = 6;
            this.scanStart.Text = "Start Working";
            this.scanStart.UseVisualStyleBackColor = true;
            this.scanStart.Click += new System.EventHandler(this.scanStart_Click);
            // 
            // scanStatus
            // 
            this.scanStatus.AutoSize = true;
            this.scanStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scanStatus.Location = new System.Drawing.Point(62, 41);
            this.scanStatus.Name = "scanStatus";
            this.scanStatus.Size = new System.Drawing.Size(168, 25);
            this.scanStatus.TabIndex = 5;
            this.scanStatus.Text = "Status: Stopped...";
            // 
            // arlaStatus
            // 
            this.arlaStatus.AutoSize = true;
            this.arlaStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arlaStatus.Location = new System.Drawing.Point(62, 43);
            this.arlaStatus.Name = "arlaStatus";
            this.arlaStatus.Size = new System.Drawing.Size(168, 25);
            this.arlaStatus.TabIndex = 5;
            this.arlaStatus.Text = "Status: Stopped...";
            // 
            // arlaStart
            // 
            this.arlaStart.Location = new System.Drawing.Point(31, 102);
            this.arlaStart.Name = "arlaStart";
            this.arlaStart.Size = new System.Drawing.Size(122, 32);
            this.arlaStart.TabIndex = 6;
            this.arlaStart.Text = "Start Working";
            this.arlaStart.UseVisualStyleBackColor = true;
            this.arlaStart.Click += new System.EventHandler(this.arlaStart_Click);
            // 
            // arlaStop
            // 
            this.arlaStop.Enabled = false;
            this.arlaStop.Location = new System.Drawing.Point(188, 102);
            this.arlaStop.Name = "arlaStop";
            this.arlaStop.Size = new System.Drawing.Size(122, 32);
            this.arlaStop.TabIndex = 7;
            this.arlaStop.Text = "Stop";
            this.arlaStop.UseVisualStyleBackColor = true;
            this.arlaStop.Click += new System.EventHandler(this.arlaStop_Click);
            // 
            // arlaPanel
            // 
            this.arlaPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.arlaPanel.Controls.Add(this.arlaStop);
            this.arlaPanel.Controls.Add(this.arlaStart);
            this.arlaPanel.Controls.Add(this.arlaStatus);
            this.arlaPanel.Location = new System.Drawing.Point(21, 205);
            this.arlaPanel.Name = "arlaPanel";
            this.arlaPanel.Size = new System.Drawing.Size(350, 160);
            this.arlaPanel.TabIndex = 9;
            // 
            // axFoodHeader
            // 
            this.axFoodHeader.AutoSize = true;
            this.axFoodHeader.Location = new System.Drawing.Point(50, 373);
            this.axFoodHeader.Name = "axFoodHeader";
            this.axFoodHeader.Size = new System.Drawing.Size(55, 17);
            this.axFoodHeader.TabIndex = 12;
            this.axFoodHeader.Text = "AxFood";
            // 
            // axFoodPanel
            // 
            this.axFoodPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.axFoodPanel.Controls.Add(this.axFoodStop);
            this.axFoodPanel.Controls.Add(this.axFoodStart);
            this.axFoodPanel.Controls.Add(this.axFoodStatus);
            this.axFoodPanel.Location = new System.Drawing.Point(21, 382);
            this.axFoodPanel.Name = "axFoodPanel";
            this.axFoodPanel.Size = new System.Drawing.Size(350, 160);
            this.axFoodPanel.TabIndex = 11;
            // 
            // axFoodStop
            // 
            this.axFoodStop.Enabled = false;
            this.axFoodStop.Location = new System.Drawing.Point(188, 102);
            this.axFoodStop.Name = "axFoodStop";
            this.axFoodStop.Size = new System.Drawing.Size(122, 32);
            this.axFoodStop.TabIndex = 7;
            this.axFoodStop.Text = "Stop";
            this.axFoodStop.UseVisualStyleBackColor = true;
            this.axFoodStop.Click += new System.EventHandler(this.axFoodStop_Click);
            // 
            // axFoodStart
            // 
            this.axFoodStart.Location = new System.Drawing.Point(31, 102);
            this.axFoodStart.Name = "axFoodStart";
            this.axFoodStart.Size = new System.Drawing.Size(122, 32);
            this.axFoodStart.TabIndex = 6;
            this.axFoodStart.Text = "Start Working";
            this.axFoodStart.UseVisualStyleBackColor = true;
            this.axFoodStart.Click += new System.EventHandler(this.axFoodStart_Click);
            // 
            // axFoodStatus
            // 
            this.axFoodStatus.AutoSize = true;
            this.axFoodStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.axFoodStatus.Location = new System.Drawing.Point(62, 43);
            this.axFoodStatus.Name = "axFoodStatus";
            this.axFoodStatus.Size = new System.Drawing.Size(168, 25);
            this.axFoodStatus.TabIndex = 5;
            this.axFoodStatus.Text = "Status: Stopped...";
            // 
            // producersPanel
            // 
            this.producersPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.producersPanel.Controls.Add(this.scanHeader);
            this.producersPanel.Controls.Add(this.arlaHeader);
            this.producersPanel.Controls.Add(this.axFoodHeader);
            this.producersPanel.Controls.Add(this.scanPanel);
            this.producersPanel.Controls.Add(this.axFoodPanel);
            this.producersPanel.Controls.Add(this.arlaPanel);
            this.producersPanel.Location = new System.Drawing.Point(12, 25);
            this.producersPanel.Name = "producersPanel";
            this.producersPanel.Size = new System.Drawing.Size(393, 558);
            this.producersPanel.TabIndex = 13;
            // 
            // scanHeader
            // 
            this.scanHeader.AutoSize = true;
            this.scanHeader.Location = new System.Drawing.Point(50, 16);
            this.scanHeader.Name = "scanHeader";
            this.scanHeader.Size = new System.Drawing.Size(40, 17);
            this.scanHeader.TabIndex = 8;
            this.scanHeader.Text = "Scan";
            // 
            // arlaHeader
            // 
            this.arlaHeader.AutoSize = true;
            this.arlaHeader.Location = new System.Drawing.Point(50, 196);
            this.arlaHeader.Name = "arlaHeader";
            this.arlaHeader.Size = new System.Drawing.Size(33, 17);
            this.arlaHeader.TabIndex = 11;
            this.arlaHeader.Text = "Arla";
            // 
            // producerHeader
            // 
            this.producerHeader.AutoSize = true;
            this.producerHeader.Location = new System.Drawing.Point(31, 15);
            this.producerHeader.Name = "producerHeader";
            this.producerHeader.Size = new System.Drawing.Size(73, 17);
            this.producerHeader.TabIndex = 14;
            this.producerHeader.Text = "Producers";
            // 
            // consumersPanel
            // 
            this.consumersPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.consumersPanel.Controls.Add(this.cityHeader);
            this.consumersPanel.Controls.Add(this.cityPanel);
            this.consumersPanel.Controls.Add(this.coopHeader);
            this.consumersPanel.Controls.Add(this.coopPanel);
            this.consumersPanel.Controls.Add(this.icaHeader);
            this.consumersPanel.Controls.Add(this.icaPanel);
            this.consumersPanel.Location = new System.Drawing.Point(411, 25);
            this.consumersPanel.Name = "consumersPanel";
            this.consumersPanel.Size = new System.Drawing.Size(462, 558);
            this.consumersPanel.TabIndex = 15;
            // 
            // cityHeader
            // 
            this.cityHeader.AutoSize = true;
            this.cityHeader.Location = new System.Drawing.Point(38, 373);
            this.cityHeader.Name = "cityHeader";
            this.cityHeader.Size = new System.Drawing.Size(92, 17);
            this.cityHeader.TabIndex = 20;
            this.cityHeader.Text = "CITY GROSS";
            // 
            // cityPanel
            // 
            this.cityPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cityPanel.Controls.Add(this.cityStatusHeader);
            this.cityPanel.Controls.Add(this.cityStatusPanel);
            this.cityPanel.Controls.Add(this.cityStop);
            this.cityPanel.Controls.Add(this.cityStart);
            this.cityPanel.Controls.Add(this.cityCheckLoad);
            this.cityPanel.Controls.Add(this.cityTruckHeader);
            this.cityPanel.Controls.Add(this.cityTruckPanel);
            this.cityPanel.Controls.Add(this.cityCargoList);
            this.cityPanel.Location = new System.Drawing.Point(10, 382);
            this.cityPanel.Name = "cityPanel";
            this.cityPanel.Size = new System.Drawing.Size(440, 160);
            this.cityPanel.TabIndex = 19;
            // 
            // cityStatusHeader
            // 
            this.cityStatusHeader.AutoSize = true;
            this.cityStatusHeader.Location = new System.Drawing.Point(152, 9);
            this.cityStatusHeader.Name = "cityStatusHeader";
            this.cityStatusHeader.Size = new System.Drawing.Size(48, 17);
            this.cityStatusHeader.TabIndex = 15;
            this.cityStatusHeader.Text = "Status";
            // 
            // cityStatusPanel
            // 
            this.cityStatusPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cityStatusPanel.Controls.Add(this.cityStatusLabel);
            this.cityStatusPanel.Location = new System.Drawing.Point(140, 18);
            this.cityStatusPanel.Name = "cityStatusPanel";
            this.cityStatusPanel.Size = new System.Drawing.Size(149, 74);
            this.cityStatusPanel.TabIndex = 16;
            // 
            // cityStatusLabel
            // 
            this.cityStatusLabel.AutoSize = true;
            this.cityStatusLabel.Location = new System.Drawing.Point(10, 30);
            this.cityStatusLabel.Name = "cityStatusLabel";
            this.cityStatusLabel.Size = new System.Drawing.Size(67, 17);
            this.cityStatusLabel.TabIndex = 0;
            this.cityStatusLabel.Text = "Waiting...";
            // 
            // cityStop
            // 
            this.cityStop.Enabled = false;
            this.cityStop.Location = new System.Drawing.Point(139, 118);
            this.cityStop.Name = "cityStop";
            this.cityStop.Size = new System.Drawing.Size(150, 32);
            this.cityStop.TabIndex = 8;
            this.cityStop.Text = "Stop";
            this.cityStop.UseVisualStyleBackColor = true;
            this.cityStop.Click += new System.EventHandler(this.cityStop_Click);
            // 
            // cityStart
            // 
            this.cityStart.Location = new System.Drawing.Point(12, 118);
            this.cityStart.Name = "cityStart";
            this.cityStart.Size = new System.Drawing.Size(122, 32);
            this.cityStart.TabIndex = 6;
            this.cityStart.Text = "Start Loading";
            this.cityStart.UseVisualStyleBackColor = true;
            this.cityStart.Click += new System.EventHandler(this.cityStart_Click);
            // 
            // cityCheckLoad
            // 
            this.cityCheckLoad.AutoSize = true;
            this.cityCheckLoad.Location = new System.Drawing.Point(140, 98);
            this.cityCheckLoad.Name = "cityCheckLoad";
            this.cityCheckLoad.Size = new System.Drawing.Size(136, 21);
            this.cityCheckLoad.TabIndex = 15;
            this.cityCheckLoad.Text = "Continue loading";
            this.cityCheckLoad.UseVisualStyleBackColor = true;
            // 
            // cityTruckHeader
            // 
            this.cityTruckHeader.AutoSize = true;
            this.cityTruckHeader.Location = new System.Drawing.Point(27, 9);
            this.cityTruckHeader.Name = "cityTruckHeader";
            this.cityTruckHeader.Size = new System.Drawing.Size(84, 17);
            this.cityTruckHeader.TabIndex = 1;
            this.cityTruckHeader.Text = "Truck Limits";
            // 
            // cityTruckPanel
            // 
            this.cityTruckPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cityTruckPanel.Controls.Add(this.cityWeightLabel);
            this.cityTruckPanel.Controls.Add(this.cityVolumeLabel);
            this.cityTruckPanel.Controls.Add(this.cityItemsLabel);
            this.cityTruckPanel.Location = new System.Drawing.Point(11, 18);
            this.cityTruckPanel.Name = "cityTruckPanel";
            this.cityTruckPanel.Size = new System.Drawing.Size(122, 94);
            this.cityTruckPanel.TabIndex = 8;
            // 
            // cityWeightLabel
            // 
            this.cityWeightLabel.AutoSize = true;
            this.cityWeightLabel.Location = new System.Drawing.Point(0, 40);
            this.cityWeightLabel.Name = "cityWeightLabel";
            this.cityWeightLabel.Size = new System.Drawing.Size(96, 17);
            this.cityWeightLabel.TabIndex = 2;
            this.cityWeightLabel.Text = "Weight:0/22.3";
            // 
            // cityVolumeLabel
            // 
            this.cityVolumeLabel.AutoSize = true;
            this.cityVolumeLabel.Location = new System.Drawing.Point(0, 65);
            this.cityVolumeLabel.Name = "cityVolumeLabel";
            this.cityVolumeLabel.Size = new System.Drawing.Size(87, 17);
            this.cityVolumeLabel.TabIndex = 3;
            this.cityVolumeLabel.Text = "Volume:0/17";
            // 
            // cityItemsLabel
            // 
            this.cityItemsLabel.AutoSize = true;
            this.cityItemsLabel.Location = new System.Drawing.Point(0, 15);
            this.cityItemsLabel.Name = "cityItemsLabel";
            this.cityItemsLabel.Size = new System.Drawing.Size(73, 17);
            this.cityItemsLabel.TabIndex = 4;
            this.cityItemsLabel.Text = "Items:0/19";
            // 
            // cityCargoList
            // 
            this.cityCargoList.FormattingEnabled = true;
            this.cityCargoList.ItemHeight = 16;
            this.cityCargoList.Location = new System.Drawing.Point(295, 18);
            this.cityCargoList.Name = "cityCargoList";
            this.cityCargoList.Size = new System.Drawing.Size(136, 132);
            this.cityCargoList.TabIndex = 7;
            // 
            // coopHeader
            // 
            this.coopHeader.AutoSize = true;
            this.coopHeader.Location = new System.Drawing.Point(38, 199);
            this.coopHeader.Name = "coopHeader";
            this.coopHeader.Size = new System.Drawing.Size(48, 17);
            this.coopHeader.TabIndex = 18;
            this.coopHeader.Text = "COOP";
            // 
            // coopPanel
            // 
            this.coopPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.coopPanel.Controls.Add(this.coopStatusHeader);
            this.coopPanel.Controls.Add(this.coopStatusPanel);
            this.coopPanel.Controls.Add(this.coopStop);
            this.coopPanel.Controls.Add(this.coopStart);
            this.coopPanel.Controls.Add(this.coopCheckLoad);
            this.coopPanel.Controls.Add(this.coopTruckHeader);
            this.coopPanel.Controls.Add(this.coopTruckPanel);
            this.coopPanel.Controls.Add(this.coopCargoList);
            this.coopPanel.Location = new System.Drawing.Point(10, 208);
            this.coopPanel.Name = "coopPanel";
            this.coopPanel.Size = new System.Drawing.Size(440, 160);
            this.coopPanel.TabIndex = 17;
            // 
            // coopStatusHeader
            // 
            this.coopStatusHeader.AutoSize = true;
            this.coopStatusHeader.Location = new System.Drawing.Point(152, 9);
            this.coopStatusHeader.Name = "coopStatusHeader";
            this.coopStatusHeader.Size = new System.Drawing.Size(48, 17);
            this.coopStatusHeader.TabIndex = 15;
            this.coopStatusHeader.Text = "Status";
            // 
            // coopStatusPanel
            // 
            this.coopStatusPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.coopStatusPanel.Controls.Add(this.coopStatusLabel);
            this.coopStatusPanel.Location = new System.Drawing.Point(140, 18);
            this.coopStatusPanel.Name = "coopStatusPanel";
            this.coopStatusPanel.Size = new System.Drawing.Size(149, 74);
            this.coopStatusPanel.TabIndex = 16;
            // 
            // coopStatusLabel
            // 
            this.coopStatusLabel.AutoSize = true;
            this.coopStatusLabel.Location = new System.Drawing.Point(10, 30);
            this.coopStatusLabel.Name = "coopStatusLabel";
            this.coopStatusLabel.Size = new System.Drawing.Size(67, 17);
            this.coopStatusLabel.TabIndex = 0;
            this.coopStatusLabel.Text = "Waiting...";
            // 
            // coopStop
            // 
            this.coopStop.Enabled = false;
            this.coopStop.Location = new System.Drawing.Point(139, 118);
            this.coopStop.Name = "coopStop";
            this.coopStop.Size = new System.Drawing.Size(150, 32);
            this.coopStop.TabIndex = 8;
            this.coopStop.Text = "Stop";
            this.coopStop.UseVisualStyleBackColor = true;
            this.coopStop.Click += new System.EventHandler(this.coopStop_Click);
            // 
            // coopStart
            // 
            this.coopStart.Location = new System.Drawing.Point(12, 118);
            this.coopStart.Name = "coopStart";
            this.coopStart.Size = new System.Drawing.Size(122, 32);
            this.coopStart.TabIndex = 6;
            this.coopStart.Text = "Start Loading";
            this.coopStart.UseVisualStyleBackColor = true;
            this.coopStart.Click += new System.EventHandler(this.coopStart_Click);
            // 
            // coopCheckLoad
            // 
            this.coopCheckLoad.AutoSize = true;
            this.coopCheckLoad.Location = new System.Drawing.Point(140, 98);
            this.coopCheckLoad.Name = "coopCheckLoad";
            this.coopCheckLoad.Size = new System.Drawing.Size(136, 21);
            this.coopCheckLoad.TabIndex = 15;
            this.coopCheckLoad.Text = "Continue loading";
            this.coopCheckLoad.UseVisualStyleBackColor = true;
            // 
            // coopTruckHeader
            // 
            this.coopTruckHeader.AutoSize = true;
            this.coopTruckHeader.Location = new System.Drawing.Point(27, 9);
            this.coopTruckHeader.Name = "coopTruckHeader";
            this.coopTruckHeader.Size = new System.Drawing.Size(84, 17);
            this.coopTruckHeader.TabIndex = 1;
            this.coopTruckHeader.Text = "Truck Limits";
            // 
            // coopTruckPanel
            // 
            this.coopTruckPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.coopTruckPanel.Controls.Add(this.coopWeightLabel);
            this.coopTruckPanel.Controls.Add(this.coopVolumeLabel);
            this.coopTruckPanel.Controls.Add(this.coopItemsLabel);
            this.coopTruckPanel.Location = new System.Drawing.Point(11, 18);
            this.coopTruckPanel.Name = "coopTruckPanel";
            this.coopTruckPanel.Size = new System.Drawing.Size(122, 94);
            this.coopTruckPanel.TabIndex = 8;
            // 
            // coopWeightLabel
            // 
            this.coopWeightLabel.AutoSize = true;
            this.coopWeightLabel.Location = new System.Drawing.Point(0, 40);
            this.coopWeightLabel.Name = "coopWeightLabel";
            this.coopWeightLabel.Size = new System.Drawing.Size(96, 17);
            this.coopWeightLabel.TabIndex = 2;
            this.coopWeightLabel.Text = "Weight:0/31.5";
            // 
            // coopVolumeLabel
            // 
            this.coopVolumeLabel.AutoSize = true;
            this.coopVolumeLabel.Location = new System.Drawing.Point(0, 65);
            this.coopVolumeLabel.Name = "coopVolumeLabel";
            this.coopVolumeLabel.Size = new System.Drawing.Size(99, 17);
            this.coopVolumeLabel.TabIndex = 3;
            this.coopVolumeLabel.Text = "Volume:0/10.2";
            // 
            // coopItemsLabel
            // 
            this.coopItemsLabel.AutoSize = true;
            this.coopItemsLabel.Location = new System.Drawing.Point(0, 15);
            this.coopItemsLabel.Name = "coopItemsLabel";
            this.coopItemsLabel.Size = new System.Drawing.Size(73, 17);
            this.coopItemsLabel.TabIndex = 4;
            this.coopItemsLabel.Text = "Items:0/12";
            // 
            // coopCargoList
            // 
            this.coopCargoList.FormattingEnabled = true;
            this.coopCargoList.ItemHeight = 16;
            this.coopCargoList.Location = new System.Drawing.Point(295, 18);
            this.coopCargoList.Name = "coopCargoList";
            this.coopCargoList.Size = new System.Drawing.Size(136, 132);
            this.coopCargoList.TabIndex = 7;
            // 
            // icaHeader
            // 
            this.icaHeader.AutoSize = true;
            this.icaHeader.Location = new System.Drawing.Point(38, 16);
            this.icaHeader.Name = "icaHeader";
            this.icaHeader.Size = new System.Drawing.Size(29, 17);
            this.icaHeader.TabIndex = 16;
            this.icaHeader.Text = "ICA";
            // 
            // consumersHeader
            // 
            this.consumersHeader.AutoSize = true;
            this.consumersHeader.Location = new System.Drawing.Point(419, 15);
            this.consumersHeader.Name = "consumersHeader";
            this.consumersHeader.Size = new System.Drawing.Size(79, 17);
            this.consumersHeader.TabIndex = 16;
            this.consumersHeader.Text = "Consumers";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 715);
            this.Controls.Add(this.consumersHeader);
            this.Controls.Add(this.consumersPanel);
            this.Controls.Add(this.producerHeader);
            this.Controls.Add(this.producersPanel);
            this.Controls.Add(this.storageInfoLabel);
            this.Controls.Add(this.storagePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Delivery System";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.storagePanel.ResumeLayout(false);
            this.storagePanel.PerformLayout();
            this.icaPanel.ResumeLayout(false);
            this.icaPanel.PerformLayout();
            this.icaStatusPanel.ResumeLayout(false);
            this.icaStatusPanel.PerformLayout();
            this.icaTruckPanel.ResumeLayout(false);
            this.icaTruckPanel.PerformLayout();
            this.scanPanel.ResumeLayout(false);
            this.scanPanel.PerformLayout();
            this.arlaPanel.ResumeLayout(false);
            this.arlaPanel.PerformLayout();
            this.axFoodPanel.ResumeLayout(false);
            this.axFoodPanel.PerformLayout();
            this.producersPanel.ResumeLayout(false);
            this.producersPanel.PerformLayout();
            this.consumersPanel.ResumeLayout(false);
            this.consumersPanel.PerformLayout();
            this.cityPanel.ResumeLayout(false);
            this.cityPanel.PerformLayout();
            this.cityStatusPanel.ResumeLayout(false);
            this.cityStatusPanel.PerformLayout();
            this.cityTruckPanel.ResumeLayout(false);
            this.cityTruckPanel.PerformLayout();
            this.coopPanel.ResumeLayout(false);
            this.coopPanel.PerformLayout();
            this.coopStatusPanel.ResumeLayout(false);
            this.coopStatusPanel.PerformLayout();
            this.coopTruckPanel.ResumeLayout(false);
            this.coopTruckPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar storageBar;
        private System.Windows.Forms.Panel icaPanel;
        private System.Windows.Forms.Panel storagePanel;
        private System.Windows.Forms.Label storageInfoLabel;
        private System.Windows.Forms.Label icaVolumeLabel;
        private System.Windows.Forms.Label icaWeightLabel;
        private System.Windows.Forms.Label icaTruckHeader;
        private System.Windows.Forms.ListBox icaCargoList;
        private System.Windows.Forms.Button icaStart;
        private System.Windows.Forms.Label icaItemsLabel;
        private System.Windows.Forms.Panel scanPanel;
        private System.Windows.Forms.Button scanStart;
        private System.Windows.Forms.Label scanStatus;
        private System.Windows.Forms.Button scanStop;
        private System.Windows.Forms.Label storageLabel;
        private System.Windows.Forms.Label arlaStatus;
        private System.Windows.Forms.Button arlaStart;
        private System.Windows.Forms.Button arlaStop;
        private System.Windows.Forms.Panel arlaPanel;
        private System.Windows.Forms.Panel icaTruckPanel;
        private System.Windows.Forms.Label axFoodHeader;
        private System.Windows.Forms.Panel axFoodPanel;
        private System.Windows.Forms.Button axFoodStop;
        private System.Windows.Forms.Button axFoodStart;
        private System.Windows.Forms.Label axFoodStatus;
        private System.Windows.Forms.Panel producersPanel;
        private System.Windows.Forms.Label arlaHeader;
        private System.Windows.Forms.Label scanHeader;
        private System.Windows.Forms.Label producerHeader;
        private System.Windows.Forms.CheckBox icaCheckLoad;
        private System.Windows.Forms.Button icaStop;
        private System.Windows.Forms.Panel icaStatusPanel;
        private System.Windows.Forms.Label icaStatusHeader;
        private System.Windows.Forms.Label icaStatusLabel;
        private System.Windows.Forms.Panel consumersPanel;
        private System.Windows.Forms.Label icaHeader;
        private System.Windows.Forms.Label consumersHeader;
        private System.Windows.Forms.Label cityHeader;
        private System.Windows.Forms.Panel cityPanel;
        private System.Windows.Forms.Label cityStatusHeader;
        private System.Windows.Forms.Panel cityStatusPanel;
        private System.Windows.Forms.Label cityStatusLabel;
        private System.Windows.Forms.Button cityStop;
        private System.Windows.Forms.Button cityStart;
        private System.Windows.Forms.CheckBox cityCheckLoad;
        private System.Windows.Forms.Label cityTruckHeader;
        private System.Windows.Forms.Panel cityTruckPanel;
        private System.Windows.Forms.Label cityWeightLabel;
        private System.Windows.Forms.Label cityVolumeLabel;
        private System.Windows.Forms.Label cityItemsLabel;
        private System.Windows.Forms.ListBox cityCargoList;
        private System.Windows.Forms.Label coopHeader;
        private System.Windows.Forms.Panel coopPanel;
        private System.Windows.Forms.Label coopStatusHeader;
        private System.Windows.Forms.Panel coopStatusPanel;
        private System.Windows.Forms.Label coopStatusLabel;
        private System.Windows.Forms.Button coopStop;
        private System.Windows.Forms.Button coopStart;
        private System.Windows.Forms.CheckBox coopCheckLoad;
        private System.Windows.Forms.Label coopTruckHeader;
        private System.Windows.Forms.Panel coopTruckPanel;
        private System.Windows.Forms.Label coopWeightLabel;
        private System.Windows.Forms.Label coopVolumeLabel;
        private System.Windows.Forms.Label coopItemsLabel;
        private System.Windows.Forms.ListBox coopCargoList;
    }
}

