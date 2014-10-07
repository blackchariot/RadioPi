using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioPi
{
    /// <summary>
    /// Main Menu.  Special app class.
    /// </summary>
    class MainMenu : App
    {
        #region vars

        PictureBox player = new PictureBox();

        #endregion

        #region instantiation

        public MainMenu(Panel parent) : base(parent) { }

        #endregion

        #region override events

        protected override void OnStart()
        {
            // set backcolor
            BackColor = Color.Black;

            // place icons
            this.Controls.Add(player);
            player.Image = Image.FromFile(Application.StartupPath + "\\resources\\player_n.png");
            player.SizeMode = PictureBoxSizeMode.AutoSize;
            player.Location = new Point(12, 12);
            player.MouseDown += player_MouseDown;
            player.MouseUp += player_MouseUp;
            player.Click += player_Click;
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

        #region events

        void player_MouseDown(object sender, MouseEventArgs e)
        {
            player.Image = Image.FromFile(Application.StartupPath + "\\resources\\player_h.png");
        }

        void player_MouseUp(object sender, MouseEventArgs e)
        {
            player.Image = Image.FromFile(Application.StartupPath + "\\resources\\player_n.png");
        }

        void player_Click(object sender, EventArgs e)
        {
        }

        #endregion
    }
}
