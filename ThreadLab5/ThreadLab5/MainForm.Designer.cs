namespace ThreadLab5
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
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.carYellow = new System.Windows.Forms.PictureBox();
            this.carBlue = new System.Windows.Forms.PictureBox();
            this.carGreen = new System.Windows.Forms.PictureBox();
            this.carRed = new System.Windows.Forms.PictureBox();
            this.carParkPanel = new System.Windows.Forms.Panel();
            this.carParkLabel = new System.Windows.Forms.Label();
            this.carBlueLabel = new System.Windows.Forms.Label();
            this.carYellowLabel = new System.Windows.Forms.Label();
            this.carRedLabel = new System.Windows.Forms.Label();
            this.carGreenbel = new System.Windows.Forms.Label();
            this.carParkInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.carYellow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carRed)).BeginInit();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(168, 114);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(120, 40);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Enabled = false;
            this.stopButton.Location = new System.Drawing.Point(294, 114);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(120, 40);
            this.stopButton.TabIndex = 1;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // carYellow
            // 
            this.carYellow.BackColor = System.Drawing.Color.Yellow;
            this.carYellow.Image = global::ThreadLab5.Properties.Resources.carSouth;
            this.carYellow.Location = new System.Drawing.Point(461, 474);
            this.carYellow.Name = "carYellow";
            this.carYellow.Size = new System.Drawing.Size(75, 150);
            this.carYellow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.carYellow.TabIndex = 5;
            this.carYellow.TabStop = false;
            // 
            // carBlue
            // 
            this.carBlue.BackColor = System.Drawing.Color.Blue;
            this.carBlue.Image = global::ThreadLab5.Properties.Resources.carNorth;
            this.carBlue.Location = new System.Drawing.Point(461, 12);
            this.carBlue.Name = "carBlue";
            this.carBlue.Size = new System.Drawing.Size(75, 150);
            this.carBlue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.carBlue.TabIndex = 4;
            this.carBlue.TabStop = false;
            // 
            // carGreen
            // 
            this.carGreen.BackColor = System.Drawing.Color.Green;
            this.carGreen.Image = global::ThreadLab5.Properties.Resources.carEast;
            this.carGreen.Location = new System.Drawing.Point(824, 275);
            this.carGreen.Name = "carGreen";
            this.carGreen.Size = new System.Drawing.Size(150, 75);
            this.carGreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.carGreen.TabIndex = 3;
            this.carGreen.TabStop = false;
            // 
            // carRed
            // 
            this.carRed.BackColor = System.Drawing.Color.Red;
            this.carRed.Image = global::ThreadLab5.Properties.Resources.carWest;
            this.carRed.Location = new System.Drawing.Point(12, 275);
            this.carRed.Name = "carRed";
            this.carRed.Size = new System.Drawing.Size(150, 75);
            this.carRed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.carRed.TabIndex = 2;
            this.carRed.TabStop = false;
            // 
            // carParkPanel
            // 
            this.carParkPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.carParkPanel.BackColor = System.Drawing.Color.LightGray;
            this.carParkPanel.Location = new System.Drawing.Point(168, 168);
            this.carParkPanel.Name = "carParkPanel";
            this.carParkPanel.Size = new System.Drawing.Size(650, 300);
            this.carParkPanel.TabIndex = 6;
            // 
            // carParkLabel
            // 
            this.carParkLabel.AutoSize = true;
            this.carParkLabel.Location = new System.Drawing.Point(682, 137);
            this.carParkLabel.Name = "carParkLabel";
            this.carParkLabel.Size = new System.Drawing.Size(0, 17);
            this.carParkLabel.TabIndex = 1;
            // 
            // carBlueLabel
            // 
            this.carBlueLabel.AutoSize = true;
            this.carBlueLabel.Location = new System.Drawing.Point(542, 73);
            this.carBlueLabel.Name = "carBlueLabel";
            this.carBlueLabel.Size = new System.Drawing.Size(16, 17);
            this.carBlueLabel.TabIndex = 7;
            this.carBlueLabel.Text = "0";
            // 
            // carYellowLabel
            // 
            this.carYellowLabel.AutoSize = true;
            this.carYellowLabel.Location = new System.Drawing.Point(542, 548);
            this.carYellowLabel.Name = "carYellowLabel";
            this.carYellowLabel.Size = new System.Drawing.Size(16, 17);
            this.carYellowLabel.TabIndex = 8;
            this.carYellowLabel.Text = "0";
            // 
            // carRedLabel
            // 
            this.carRedLabel.AutoSize = true;
            this.carRedLabel.Location = new System.Drawing.Point(74, 255);
            this.carRedLabel.Name = "carRedLabel";
            this.carRedLabel.Size = new System.Drawing.Size(16, 17);
            this.carRedLabel.TabIndex = 9;
            this.carRedLabel.Text = "0";
            this.carRedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // carGreenbel
            // 
            this.carGreenbel.AutoSize = true;
            this.carGreenbel.Location = new System.Drawing.Point(901, 255);
            this.carGreenbel.Name = "carGreenbel";
            this.carGreenbel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.carGreenbel.Size = new System.Drawing.Size(16, 17);
            this.carGreenbel.TabIndex = 10;
            this.carGreenbel.Text = "0";
            // 
            // carParkInfo
            // 
            this.carParkInfo.AutoSize = true;
            this.carParkInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carParkInfo.Location = new System.Drawing.Point(596, 134);
            this.carParkInfo.Name = "carParkInfo";
            this.carParkInfo.Size = new System.Drawing.Size(80, 20);
            this.carParkInfo.TabIndex = 0;
            this.carParkInfo.Text = "Car Park:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 636);
            this.Controls.Add(this.carParkLabel);
            this.Controls.Add(this.carGreenbel);
            this.Controls.Add(this.carParkInfo);
            this.Controls.Add(this.carRedLabel);
            this.Controls.Add(this.carYellowLabel);
            this.Controls.Add(this.carBlueLabel);
            this.Controls.Add(this.carParkPanel);
            this.Controls.Add(this.carYellow);
            this.Controls.Add(this.carBlue);
            this.Controls.Add(this.carGreen);
            this.Controls.Add(this.carRed);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Car Park";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.carYellow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carRed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.PictureBox carRed;
        private System.Windows.Forms.PictureBox carGreen;
        private System.Windows.Forms.PictureBox carBlue;
        private System.Windows.Forms.PictureBox carYellow;
        private System.Windows.Forms.Panel carParkPanel;
        private System.Windows.Forms.Label carBlueLabel;
        private System.Windows.Forms.Label carYellowLabel;
        private System.Windows.Forms.Label carRedLabel;
        private System.Windows.Forms.Label carGreenbel;
        private System.Windows.Forms.Label carParkInfo;
        private System.Windows.Forms.Label carParkLabel;
    }
}

