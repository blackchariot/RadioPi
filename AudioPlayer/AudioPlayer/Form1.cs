using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using LibMPlayerCommon;

namespace AudioPlayer
{
    public partial class MainForm : Form
    {
        MPlayer mPlayer;

        public MainForm()
        {
            InitializeComponent();

            System.PlatformID platform = System.Environment.OSVersion.Platform;
            MplayerBackends b;

            if (platform == PlatformID.Unix)
                b = MplayerBackends.GL2;
            else if (platform == PlatformID.MacOSX)
                b = MplayerBackends.OpenGL;
            else
                b = MplayerBackends.Direct3D;

            mPlayer = new MPlayer(this.Handle.ToInt32(), b, Application.StartupPath + "\\..\\..\\mplayer\\mplayer.exe");

            MainMenu menu = new MainMenu(AppPanel);
        }

        private void browseBtn_Click(object sender, EventArgs e)
        {
            openFileDlg.ShowDialog();
            filePathOut.Text = openFileDlg.FileName;
        }

        private void playBtn_Click(object sender, EventArgs e)
        {
            if (mPlayer.MplayerRunning)
                mPlayer.Pause();
            else
            {
                mPlayer.Play(filePathOut.Text);
                updater.Enabled = true;
            }
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            mPlayer.Pause();
        }

        private void updater_Tick(object sender, EventArgs e)
        {
            nowPlayingOut.Text = "Now Playing: " + mPlayer.ToString();
            timeOut.Text = TimeSpan.FromSeconds(mPlayer.GetCurrentPosition()).ToString();
        }
    }
}
