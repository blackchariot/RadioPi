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

        Dictionary<string, Dictionary<string, string>> menu;

        #endregion

        #region instantiation

        public MainMenu(Panel parent) : base(parent) { }

        #endregion

        #region override events

        protected override void OnStart()
        {
            // set backcolor
            BackColor = Color.Black;

            // build menu
            buildMenu();
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

        void icon_MouseDown(object sender, MouseEventArgs e)
        {
            // convert to picture box
            PictureBox icon = (PictureBox)sender;

            // get and set highlight image
            icon.Image = Image.FromFile(
                Application.StartupPath + "\\resources\\" + menu[icon.Name]["icoH"]);
        }

        void icon_MouseUp(object sender, MouseEventArgs e)
        {
            // convert to picture box
            PictureBox icon = (PictureBox)sender;

            // get and set highlight image
            icon.Image = Image.FromFile(
                Application.StartupPath + "\\resources\\" + menu[icon.Name]["icoN"]);
        }

        void icon_Click(object sender, EventArgs e)
        {
        }

        #endregion

        #region private methods

        private void buildMenu()
        {
            menu = XML.GetConfig(Application.StartupPath + "\\apps\\config.xml");

            for (int i = 0; i < menu.Count; i++)
            {
                // create new picture box
                PictureBox icon = new PictureBox();

                // setup icon
                this.Controls.Add(icon);
                icon.Name = menu.ElementAt(i).Key;
                icon.Image = Image.FromFile(
                    Application.StartupPath + "\\resources\\" + menu.ElementAt(i).Value["icoN"]);
                icon.SizeMode = PictureBoxSizeMode.StretchImage;
                icon.Size = new System.Drawing.Size(64, 64);
                icon.Location = new Point(12 + (64 * i), 12 + (64 * i));
                icon.MouseDown += icon_MouseDown;
                icon.MouseUp += icon_MouseUp;
                icon.Click += icon_Click;
            }
        }

        #endregion
    }
}
