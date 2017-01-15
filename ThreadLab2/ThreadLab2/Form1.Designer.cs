namespace ThreadLab2
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
            this.writeLogger = new System.Windows.Forms.ListBox();
            this.readLogger = new System.Windows.Forms.ListBox();
            this.writerLogInfo = new System.Windows.Forms.Label();
            this.ReaderLogInfo = new System.Windows.Forms.Label();
            this.writerResult = new System.Windows.Forms.Label();
            this.readerResult = new System.Windows.Forms.Label();
            this.asyncButton = new System.Windows.Forms.RadioButton();
            this.syncButton = new System.Windows.Forms.RadioButton();
            this.transferTextBox = new System.Windows.Forms.TextBox();
            this.runButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.colorPanel = new System.Windows.Forms.Panel();
            this.transferInfo = new System.Windows.Forms.Label();
            this.matchLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // writeLogger
            // 
            this.writeLogger.FormattingEnabled = true;
            this.writeLogger.ItemHeight = 16;
            this.writeLogger.Location = new System.Drawing.Point(12, 29);
            this.writeLogger.Name = "writeLogger";
            this.writeLogger.Size = new System.Drawing.Size(270, 484);
            this.writeLogger.TabIndex = 0;
            // 
            // readLogger
            // 
            this.readLogger.FormattingEnabled = true;
            this.readLogger.ItemHeight = 16;
            this.readLogger.Location = new System.Drawing.Point(474, 29);
            this.readLogger.Name = "readLogger";
            this.readLogger.Size = new System.Drawing.Size(270, 484);
            this.readLogger.TabIndex = 1;
            // 
            // writerLogInfo
            // 
            this.writerLogInfo.AutoSize = true;
            this.writerLogInfo.Location = new System.Drawing.Point(9, 9);
            this.writerLogInfo.Name = "writerLogInfo";
            this.writerLogInfo.Size = new System.Drawing.Size(145, 17);
            this.writerLogInfo.TabIndex = 2;
            this.writerLogInfo.Text = "Writer Thread Logger";
            // 
            // ReaderLogInfo
            // 
            this.ReaderLogInfo.AutoSize = true;
            this.ReaderLogInfo.Location = new System.Drawing.Point(471, 9);
            this.ReaderLogInfo.Name = "ReaderLogInfo";
            this.ReaderLogInfo.Size = new System.Drawing.Size(154, 17);
            this.ReaderLogInfo.TabIndex = 3;
            this.ReaderLogInfo.Text = "Reader Thread Logger";
            // 
            // writerResult
            // 
            this.writerResult.AutoSize = true;
            this.writerResult.Location = new System.Drawing.Point(13, 531);
            this.writerResult.Name = "writerResult";
            this.writerResult.Size = new System.Drawing.Size(0, 17);
            this.writerResult.TabIndex = 4;
            // 
            // readerResult
            // 
            this.readerResult.AutoSize = true;
            this.readerResult.Location = new System.Drawing.Point(471, 531);
            this.readerResult.Name = "readerResult";
            this.readerResult.Size = new System.Drawing.Size(0, 17);
            this.readerResult.TabIndex = 5;
            this.readerResult.TextChanged += new System.EventHandler(this.readerResult_TextChanged);
            // 
            // asyncButton
            // 
            this.asyncButton.AutoSize = true;
            this.asyncButton.Checked = true;
            this.asyncButton.Location = new System.Drawing.Point(318, 59);
            this.asyncButton.Name = "asyncButton";
            this.asyncButton.Size = new System.Drawing.Size(114, 21);
            this.asyncButton.TabIndex = 6;
            this.asyncButton.TabStop = true;
            this.asyncButton.Text = "Asynchronize";
            this.asyncButton.UseVisualStyleBackColor = true;
            // 
            // syncButton
            // 
            this.syncButton.AutoSize = true;
            this.syncButton.Location = new System.Drawing.Point(318, 105);
            this.syncButton.Name = "syncButton";
            this.syncButton.Size = new System.Drawing.Size(107, 21);
            this.syncButton.TabIndex = 7;
            this.syncButton.Text = "Synchronize";
            this.syncButton.UseVisualStyleBackColor = true;
            // 
            // transferTextBox
            // 
            this.transferTextBox.Location = new System.Drawing.Point(318, 201);
            this.transferTextBox.Name = "transferTextBox";
            this.transferTextBox.Size = new System.Drawing.Size(110, 22);
            this.transferTextBox.TabIndex = 9;
            // 
            // runButton
            // 
            this.runButton.Location = new System.Drawing.Point(318, 244);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(110, 32);
            this.runButton.TabIndex = 10;
            this.runButton.Text = "Run";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Enabled = false;
            this.clearButton.Location = new System.Drawing.Point(318, 478);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(110, 35);
            this.clearButton.TabIndex = 11;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // colorPanel
            // 
            this.colorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorPanel.Location = new System.Drawing.Point(318, 293);
            this.colorPanel.Name = "colorPanel";
            this.colorPanel.Size = new System.Drawing.Size(110, 121);
            this.colorPanel.TabIndex = 12;
            // 
            // transferInfo
            // 
            this.transferInfo.AutoSize = true;
            this.transferInfo.Location = new System.Drawing.Point(315, 162);
            this.transferInfo.Name = "transferInfo";
            this.transferInfo.Size = new System.Drawing.Size(107, 17);
            this.transferInfo.TabIndex = 13;
            this.transferInfo.Text = "Transfer String ";
            // 
            // matchLabel
            // 
            this.matchLabel.AutoSize = true;
            this.matchLabel.Location = new System.Drawing.Point(318, 421);
            this.matchLabel.Name = "matchLabel";
            this.matchLabel.Size = new System.Drawing.Size(0, 17);
            this.matchLabel.TabIndex = 14;
            // 
            // Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 573);
            this.Controls.Add(this.matchLabel);
            this.Controls.Add(this.transferInfo);
            this.Controls.Add(this.colorPanel);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.runButton);
            this.Controls.Add(this.transferTextBox);
            this.Controls.Add(this.syncButton);
            this.Controls.Add(this.asyncButton);
            this.Controls.Add(this.readerResult);
            this.Controls.Add(this.writerResult);
            this.Controls.Add(this.ReaderLogInfo);
            this.Controls.Add(this.writerLogInfo);
            this.Controls.Add(this.readLogger);
            this.Controls.Add(this.writeLogger);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Screen";
            this.Text = "Writer/Reader";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Screen_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox writeLogger;
        private System.Windows.Forms.ListBox readLogger;
        private System.Windows.Forms.Label writerLogInfo;
        private System.Windows.Forms.Label ReaderLogInfo;
        private System.Windows.Forms.Label writerResult;
        private System.Windows.Forms.Label readerResult;
        private System.Windows.Forms.RadioButton asyncButton;
        private System.Windows.Forms.RadioButton syncButton;
        private System.Windows.Forms.TextBox transferTextBox;
        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Panel colorPanel;
        private System.Windows.Forms.Label transferInfo;
        private System.Windows.Forms.Label matchLabel;
    }
}

