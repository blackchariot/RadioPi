namespace RadioPi
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
            this.updater = new System.Windows.Forms.Timer(this.components);
            this.AppPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // openFileDlg
            // 
            this.openFileDlg.FileName = "openFileDlg";
            // 
            // updater
            // 
            this.updater.Interval = 16;
            this.updater.Tick += new System.EventHandler(this.updater_Tick);
            // 
            // AppPanel
            // 
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDlg;
        private System.Windows.Forms.Timer updater;
        private System.Windows.Forms.Panel AppPanel;
    }
}

