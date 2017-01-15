namespace ThreadLab1
{
    partial class Screen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Screen));
            this.welcomeBorder = new System.Windows.Forms.Panel();
            this.welcomeStop = new System.Windows.Forms.Button();
            this.welcomeStart = new System.Windows.Forms.Button();
            this.welcomePanel = new System.Windows.Forms.Panel();
            this.welcomeInfo = new System.Windows.Forms.Label();
            this.triangleInfo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.triangleStop = new System.Windows.Forms.Button();
            this.triangleStart = new System.Windows.Forms.Button();
            this.trianglePanel = new System.Windows.Forms.Panel();
            this.welcomeBorder.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // welcomeBorder
            // 
            this.welcomeBorder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.welcomeBorder.Controls.Add(this.welcomeStop);
            this.welcomeBorder.Controls.Add(this.welcomeStart);
            this.welcomeBorder.Controls.Add(this.welcomePanel);
            this.welcomeBorder.Location = new System.Drawing.Point(12, 21);
            this.welcomeBorder.Name = "welcomeBorder";
            this.welcomeBorder.Size = new System.Drawing.Size(334, 216);
            this.welcomeBorder.TabIndex = 0;
            // 
            // welcomeStop
            // 
            this.welcomeStop.Enabled = false;
            this.welcomeStop.Location = new System.Drawing.Point(188, 176);
            this.welcomeStop.Name = "welcomeStop";
            this.welcomeStop.Size = new System.Drawing.Size(134, 32);
            this.welcomeStop.TabIndex = 3;
            this.welcomeStop.Text = "Stop";
            this.welcomeStop.UseVisualStyleBackColor = true;
            this.welcomeStop.Click += new System.EventHandler(this.welcomeStop_Click);
            // 
            // welcomeStart
            // 
            this.welcomeStart.Location = new System.Drawing.Point(13, 176);
            this.welcomeStart.Name = "welcomeStart";
            this.welcomeStart.Size = new System.Drawing.Size(169, 32);
            this.welcomeStart.TabIndex = 2;
            this.welcomeStart.Text = "Start";
            this.welcomeStart.UseVisualStyleBackColor = true;
            this.welcomeStart.Click += new System.EventHandler(this.welcomeStart_Click);
            // 
            // welcomePanel
            // 
            this.welcomePanel.BackColor = System.Drawing.Color.Gray;
            this.welcomePanel.Location = new System.Drawing.Point(12, 9);
            this.welcomePanel.Name = "welcomePanel";
            this.welcomePanel.Size = new System.Drawing.Size(310, 161);
            this.welcomePanel.TabIndex = 1;
            // 
            // welcomeInfo
            // 
            this.welcomeInfo.AutoSize = true;
            this.welcomeInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeInfo.Location = new System.Drawing.Point(21, 9);
            this.welcomeInfo.Name = "welcomeInfo";
            this.welcomeInfo.Size = new System.Drawing.Size(122, 18);
            this.welcomeInfo.TabIndex = 2;
            this.welcomeInfo.Text = "Welcome Thread";
            // 
            // triangleInfo
            // 
            this.triangleInfo.AutoSize = true;
            this.triangleInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.triangleInfo.Location = new System.Drawing.Point(361, 9);
            this.triangleInfo.Name = "triangleInfo";
            this.triangleInfo.Size = new System.Drawing.Size(110, 18);
            this.triangleInfo.TabIndex = 4;
            this.triangleInfo.Text = "Triangle Thread";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.triangleStop);
            this.panel1.Controls.Add(this.triangleStart);
            this.panel1.Controls.Add(this.trianglePanel);
            this.panel1.Location = new System.Drawing.Point(352, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(334, 216);
            this.panel1.TabIndex = 3;
            // 
            // triangleStop
            // 
            this.triangleStop.Enabled = false;
            this.triangleStop.Location = new System.Drawing.Point(188, 176);
            this.triangleStop.Name = "triangleStop";
            this.triangleStop.Size = new System.Drawing.Size(134, 32);
            this.triangleStop.TabIndex = 3;
            this.triangleStop.Text = "Stop";
            this.triangleStop.UseVisualStyleBackColor = true;
            this.triangleStop.Click += new System.EventHandler(this.triangleStop_Click);
            // 
            // triangleStart
            // 
            this.triangleStart.Location = new System.Drawing.Point(13, 176);
            this.triangleStart.Name = "triangleStart";
            this.triangleStart.Size = new System.Drawing.Size(169, 32);
            this.triangleStart.TabIndex = 2;
            this.triangleStart.Text = "Start";
            this.triangleStart.UseVisualStyleBackColor = true;
            this.triangleStart.Click += new System.EventHandler(this.triangleStart_Click);
            // 
            // trianglePanel
            // 
            this.trianglePanel.BackColor = System.Drawing.Color.Gray;
            this.trianglePanel.Location = new System.Drawing.Point(12, 9);
            this.trianglePanel.Name = "trianglePanel";
            this.trianglePanel.Size = new System.Drawing.Size(310, 161);
            this.trianglePanel.TabIndex = 1;
            // 
            // Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 248);
            this.Controls.Add(this.triangleInfo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.welcomeInfo);
            this.Controls.Add(this.welcomeBorder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Screen";
            this.Text = "Multithreading demo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Screen_FormClosing);
            this.welcomeBorder.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel welcomeBorder;
        private System.Windows.Forms.Panel welcomePanel;
        private System.Windows.Forms.Label welcomeInfo;
        private System.Windows.Forms.Button welcomeStop;
        private System.Windows.Forms.Button welcomeStart;
        private System.Windows.Forms.Label triangleInfo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button triangleStop;
        private System.Windows.Forms.Button triangleStart;
        private System.Windows.Forms.Panel trianglePanel;
    }
}

