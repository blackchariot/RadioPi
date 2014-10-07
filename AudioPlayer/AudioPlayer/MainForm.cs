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

namespace RadioPi
{
    public partial class MainForm : Form
    {
        MainMenu menu;

        public MainForm()
        {
            InitializeComponent();

            System.PlatformID platform = System.Environment.OSVersion.Platform;
            /*MplayerBackends b;

            if (platform == PlatformID.Unix)
                b = MplayerBackends.GL2;
            else if (platform == PlatformID.MacOSX)
                b = MplayerBackends.OpenGL;
            else
                b = MplayerBackends.Direct3D;*/

            menu = new MainMenu(AppPanel);
            updater.Enabled = true;
        }

        private void updater_Tick(object sender, EventArgs e)
        {
            menu.Update();
        }
    }
}
