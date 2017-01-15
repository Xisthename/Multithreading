namespace ThreadLab4
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
            this.findTextBox = new System.Windows.Forms.TextBox();
            this.replaceTextBox = new System.Windows.Forms.TextBox();
            this.findPanel = new System.Windows.Forms.Panel();
            this.replaceCountLabel = new System.Windows.Forms.Label();
            this.replaceCountInfo = new System.Windows.Forms.Label();
            this.notifyMe = new System.Windows.Forms.CheckBox();
            this.findInfo = new System.Windows.Forms.Label();
            this.replaceInfo = new System.Windows.Forms.Label();
            this.findHeader = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.copyButton = new System.Windows.Forms.Button();
            this.tabController = new System.Windows.Forms.TabControl();
            this.SouceTab = new System.Windows.Forms.TabPage();
            this.sourceTextBox = new System.Windows.Forms.RichTextBox();
            this.DestinationTab = new System.Windows.Forms.TabPage();
            this.destinationTextBox = new System.Windows.Forms.RichTextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findPanel.SuspendLayout();
            this.tabController.SuspendLayout();
            this.SouceTab.SuspendLayout();
            this.DestinationTab.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // findTextBox
            // 
            this.findTextBox.Location = new System.Drawing.Point(123, 16);
            this.findTextBox.Name = "findTextBox";
            this.findTextBox.Size = new System.Drawing.Size(299, 22);
            this.findTextBox.TabIndex = 0;
            this.findTextBox.TextChanged += new System.EventHandler(this.findTextBox_TextChanged);
            // 
            // replaceTextBox
            // 
            this.replaceTextBox.Location = new System.Drawing.Point(123, 44);
            this.replaceTextBox.Name = "replaceTextBox";
            this.replaceTextBox.Size = new System.Drawing.Size(299, 22);
            this.replaceTextBox.TabIndex = 1;
            // 
            // findPanel
            // 
            this.findPanel.Controls.Add(this.replaceCountLabel);
            this.findPanel.Controls.Add(this.replaceCountInfo);
            this.findPanel.Controls.Add(this.notifyMe);
            this.findPanel.Controls.Add(this.findInfo);
            this.findPanel.Controls.Add(this.replaceInfo);
            this.findPanel.Controls.Add(this.findTextBox);
            this.findPanel.Controls.Add(this.replaceTextBox);
            this.findPanel.Location = new System.Drawing.Point(13, 46);
            this.findPanel.Name = "findPanel";
            this.findPanel.Size = new System.Drawing.Size(440, 122);
            this.findPanel.TabIndex = 2;
            // 
            // replaceCountLabel
            // 
            this.replaceCountLabel.AutoSize = true;
            this.replaceCountLabel.Location = new System.Drawing.Point(136, 89);
            this.replaceCountLabel.Name = "replaceCountLabel";
            this.replaceCountLabel.Size = new System.Drawing.Size(0, 17);
            this.replaceCountLabel.TabIndex = 10;
            // 
            // replaceCountInfo
            // 
            this.replaceCountInfo.AutoSize = true;
            this.replaceCountInfo.Location = new System.Drawing.Point(14, 89);
            this.replaceCountInfo.Name = "replaceCountInfo";
            this.replaceCountInfo.Size = new System.Drawing.Size(124, 17);
            this.replaceCountInfo.TabIndex = 9;
            this.replaceCountInfo.Text = "No Replacements:";
            // 
            // notifyMe
            // 
            this.notifyMe.AutoSize = true;
            this.notifyMe.Location = new System.Drawing.Point(255, 85);
            this.notifyMe.Name = "notifyMe";
            this.notifyMe.Size = new System.Drawing.Size(167, 21);
            this.notifyMe.TabIndex = 5;
            this.notifyMe.Text = "Notify on every match";
            this.notifyMe.UseVisualStyleBackColor = true;
            // 
            // findInfo
            // 
            this.findInfo.AutoSize = true;
            this.findInfo.Location = new System.Drawing.Point(14, 19);
            this.findInfo.Name = "findInfo";
            this.findInfo.Size = new System.Drawing.Size(39, 17);
            this.findInfo.TabIndex = 5;
            this.findInfo.Text = "Find:";
            // 
            // replaceInfo
            // 
            this.replaceInfo.AutoSize = true;
            this.replaceInfo.Location = new System.Drawing.Point(14, 47);
            this.replaceInfo.Name = "replaceInfo";
            this.replaceInfo.Size = new System.Drawing.Size(92, 17);
            this.replaceInfo.TabIndex = 3;
            this.replaceInfo.Text = "Replace with:";
            // 
            // findHeader
            // 
            this.findHeader.AutoSize = true;
            this.findHeader.Location = new System.Drawing.Point(27, 38);
            this.findHeader.Name = "findHeader";
            this.findHeader.Size = new System.Drawing.Size(119, 17);
            this.findHeader.TabIndex = 4;
            this.findHeader.Text = "Find and Replace";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(459, 118);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(224, 50);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "Clear Dest. and remove marks";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // copyButton
            // 
            this.copyButton.Location = new System.Drawing.Point(459, 46);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(220, 50);
            this.copyButton.TabIndex = 6;
            this.copyButton.Text = "Copy to Destination";
            this.copyButton.UseVisualStyleBackColor = true;
            this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
            // 
            // tabController
            // 
            this.tabController.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabController.Controls.Add(this.SouceTab);
            this.tabController.Controls.Add(this.DestinationTab);
            this.tabController.Location = new System.Drawing.Point(12, 179);
            this.tabController.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabController.Name = "tabController";
            this.tabController.SelectedIndex = 0;
            this.tabController.Size = new System.Drawing.Size(671, 350);
            this.tabController.TabIndex = 8;
            // 
            // SouceTab
            // 
            this.SouceTab.Controls.Add(this.sourceTextBox);
            this.SouceTab.Location = new System.Drawing.Point(4, 25);
            this.SouceTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SouceTab.Name = "SouceTab";
            this.SouceTab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SouceTab.Size = new System.Drawing.Size(663, 321);
            this.SouceTab.TabIndex = 0;
            this.SouceTab.Text = "Source";
            this.SouceTab.UseVisualStyleBackColor = true;
            // 
            // sourceTextBox
            // 
            this.sourceTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sourceTextBox.Location = new System.Drawing.Point(3, 2);
            this.sourceTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sourceTextBox.Name = "sourceTextBox";
            this.sourceTextBox.Size = new System.Drawing.Size(657, 317);
            this.sourceTextBox.TabIndex = 0;
            this.sourceTextBox.Text = "";
            this.sourceTextBox.WordWrap = false;
            // 
            // DestinationTab
            // 
            this.DestinationTab.Controls.Add(this.destinationTextBox);
            this.DestinationTab.Location = new System.Drawing.Point(4, 25);
            this.DestinationTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DestinationTab.Name = "DestinationTab";
            this.DestinationTab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DestinationTab.Size = new System.Drawing.Size(663, 321);
            this.DestinationTab.TabIndex = 1;
            this.DestinationTab.Text = "Destination";
            this.DestinationTab.UseVisualStyleBackColor = true;
            // 
            // destinationTextBox
            // 
            this.destinationTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.destinationTextBox.Location = new System.Drawing.Point(3, 2);
            this.destinationTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.destinationTextBox.Name = "destinationTextBox";
            this.destinationTextBox.Size = new System.Drawing.Size(657, 317);
            this.destinationTextBox.TabIndex = 0;
            this.destinationTextBox.Text = "";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Filter = ".txt | *.txt";
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip.Size = new System.Drawing.Size(695, 26);
            this.menuStrip.TabIndex = 9;
            this.menuStrip.Text = "Menu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 540);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.tabController);
            this.Controls.Add(this.copyButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.findHeader);
            this.Controls.Add(this.findPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Text File Copier - With Find and Replace";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.findPanel.ResumeLayout(false);
            this.findPanel.PerformLayout();
            this.tabController.ResumeLayout(false);
            this.SouceTab.ResumeLayout(false);
            this.DestinationTab.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox findTextBox;
        private System.Windows.Forms.TextBox replaceTextBox;
        private System.Windows.Forms.Panel findPanel;
        private System.Windows.Forms.Label findInfo;
        private System.Windows.Forms.Label replaceInfo;
        private System.Windows.Forms.Label findHeader;
        private System.Windows.Forms.Label replaceCountInfo;
        private System.Windows.Forms.CheckBox notifyMe;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button copyButton;
        private System.Windows.Forms.TabControl tabController;
        private System.Windows.Forms.TabPage SouceTab;
        private System.Windows.Forms.RichTextBox sourceTextBox;
        private System.Windows.Forms.TabPage DestinationTab;
        private System.Windows.Forms.RichTextBox destinationTextBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label replaceCountLabel;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
    }
}

