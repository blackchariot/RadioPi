namespace AudioPlayer
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
            this.components = new System.ComponentModel.Container();
            this.openFileDlg = new System.Windows.Forms.OpenFileDialog();
            this.timeOut = new System.Windows.Forms.Label();
            this.updater = new System.Windows.Forms.Timer(this.components);
            this.filePathOut = new System.Windows.Forms.TextBox();
            this.playBtn = new System.Windows.Forms.Button();
            this.browseBtn = new System.Windows.Forms.Button();
            this.stopBtn = new System.Windows.Forms.Button();
            this.nowPlayingOut = new System.Windows.Forms.Label();
            this.AppPanel = new System.Windows.Forms.Panel();
            this.AppPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDlg
            // 
            this.openFileDlg.FileName = "openFileDlg";
            // 
            // timeOut
            // 
            this.timeOut.AutoSize = true;
            this.timeOut.Location = new System.Drawing.Point(173, 119);
            this.timeOut.Name = "timeOut";
            this.timeOut.Size = new System.Drawing.Size(0, 13);
            this.timeOut.TabIndex = 4;
            // 
            // updater
            // 
            this.updater.Tick += new System.EventHandler(this.updater_Tick);
            // 
            // filePathOut
            // 
            this.filePathOut.Location = new System.Drawing.Point(140, 61);
            this.filePathOut.Name = "filePathOut";
            this.filePathOut.ReadOnly = true;
            this.filePathOut.Size = new System.Drawing.Size(330, 20);
            this.filePathOut.TabIndex = 3;
            // 
            // playBtn
            // 
            this.playBtn.Location = new System.Drawing.Point(140, 152);
            this.playBtn.Name = "playBtn";
            this.playBtn.Size = new System.Drawing.Size(75, 23);
            this.playBtn.TabIndex = 0;
            this.playBtn.Text = "Play";
            this.playBtn.UseVisualStyleBackColor = true;
            this.playBtn.Click += new System.EventHandler(this.playBtn_Click);
            // 
            // browseBtn
            // 
            this.browseBtn.Location = new System.Drawing.Point(43, 61);
            this.browseBtn.Name = "browseBtn";
            this.browseBtn.Size = new System.Drawing.Size(75, 23);
            this.browseBtn.TabIndex = 2;
            this.browseBtn.Text = "Browse...";
            this.browseBtn.UseVisualStyleBackColor = true;
            this.browseBtn.Click += new System.EventHandler(this.browseBtn_Click);
            // 
            // stopBtn
            // 
            this.stopBtn.Location = new System.Drawing.Point(259, 152);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(75, 23);
            this.stopBtn.TabIndex = 1;
            this.stopBtn.Text = "Stop";
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // nowPlayingOut
            // 
            this.nowPlayingOut.AutoSize = true;
            this.nowPlayingOut.Location = new System.Drawing.Point(137, 84);
            this.nowPlayingOut.Name = "nowPlayingOut";
            this.nowPlayingOut.Size = new System.Drawing.Size(69, 13);
            this.nowPlayingOut.TabIndex = 5;
            this.nowPlayingOut.Text = "Now Playing:";
            // 
            // AppPanel
            // 
            this.AppPanel.Controls.Add(this.timeOut);
            this.AppPanel.Controls.Add(this.nowPlayingOut);
            this.AppPanel.Controls.Add(this.stopBtn);
            this.AppPanel.Controls.Add(this.browseBtn);
            this.AppPanel.Controls.Add(this.playBtn);
            this.AppPanel.Controls.Add(this.filePathOut);
            this.AppPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AppPanel.Location = new System.Drawing.Point(0, 0);
            this.AppPanel.Name = "AppPanel";
            this.AppPanel.Size = new System.Drawing.Size(497, 253);
            this.AppPanel.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 253);
            this.Controls.Add(this.AppPanel);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.AppPanel.ResumeLayout(false);
            this.AppPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDlg;
        private System.Windows.Forms.Label timeOut;
        private System.Windows.Forms.Timer updater;
        private System.Windows.Forms.TextBox filePathOut;
        private System.Windows.Forms.Button playBtn;
        private System.Windows.Forms.Button browseBtn;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.Label nowPlayingOut;
        private System.Windows.Forms.Panel AppPanel;
    }
}

