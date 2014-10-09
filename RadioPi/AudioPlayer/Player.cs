using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using LibMPlayerCommon;

namespace RadioPi
{
    class AudioPlayer : App
    {
        #region vars

        private MPlayer player;

        #endregion

        #region instantiation

        public AudioPlayer(Panel parent) : base(parent) { }

        #endregion

        #region

        protected override void OnStart()
        {
            MplayerBackends backend;
            if (Info.Platform == System.PlatformID.Unix)
                backend = MplayerBackends.GL2;
            else if (Info.Platform == PlatformID.MacOSX)
                backend = MplayerBackends.OpenGL;
            else
                backend = MplayerBackends.Direct3D;

            player = new MPlayer(parent.Handle.ToInt32(), backend, Application.StartupPath + "\\mplayer\\MediaPlayer.exe");
        }

        protected override void OnClose()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnUpdate()
        {
        }

        #endregion
    }
}
