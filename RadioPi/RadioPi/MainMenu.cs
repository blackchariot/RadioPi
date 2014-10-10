using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
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
        List<App> apps = new List<App>();

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

        protected override void OnWake()
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
            // convert to picture box
            PictureBox icon = (PictureBox)sender;

            // load app
            Assembly dll = Assembly.LoadFrom(Application.StartupPath + "\\apps\\" + menu[icon.Name]["dll"].ToString());
            Type appType = dll.GetType(menu[icon.Name]["type"], true);
            //Type appType = Type.GetType(menu[icon.Name]["type"] + ", " + menu[icon.Name]["assembly"], true);

            foreach (App app in apps)
            {
                if (appType == app.GetType())
                {
                    app.Wake();
                    break;
                }
            }
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

                // create app
                Assembly dll = Assembly.LoadFrom(Application.StartupPath + "\\apps\\" + menu.ElementAt(i).Value["dll"].ToString());
                Type appType = dll.GetType(menu.ElementAt(i).Value["type"], true);
                //Type appType = Type.GetType(
                //    menu.ElementAt(i).Value["type"] + ", " + "apps\\" + menu.ElementAt(i).Value["assembly"], true);
                Object obj = Activator.CreateInstance(appType, parent);
                App app = (App)obj;
                app.Visible = false;
                apps.Add(app);
            }
        }

        #endregion
    }
}
