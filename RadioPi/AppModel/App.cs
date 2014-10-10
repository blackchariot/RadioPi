using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioPi
{
    public abstract class App : Panel
    {
        // protected vars
        protected Panel parent = null;

        #region Instantiation

        /// <summary>
        /// Instantiates the app.  Cannot be overridden.
        /// </summary>
        /// <param name="parent">The panel holding the app.</param>
        protected App(Panel parent)
        {
            //set parent
            this.parent = parent;

            //dock in parent
            parent.Controls.Add(this);
            this.Dock = DockStyle.Fill;

            //start the app
            OnStart();
        }

        #endregion

        #region protected abstract events

        /// <summary>
        /// Called when the app first starts, just after instantiation.
        /// </summary>
        protected abstract void OnStart();

        /// <summary>
        /// Called when the app is closed.
        /// </summary>
        protected abstract void OnClose();

        /// <summary>
        /// Called when the app goes to sleep.
        /// </summary>
        protected abstract void OnSleep();

        /// <summary>
        /// Called when the app goes to sleep.
        /// </summary>
        protected abstract void OnWake();

        #endregion

        #region public events

        /// <summary>
        /// Tell the app to close.
        /// </summary>
        public void Close()
        {
            OnClose();
        }

        /// <summary>
        /// Tell the app to wake up.
        /// </summary>
        public void Wake()
        {
            OnWake();
        }

        /// <summary>
        /// Tell the app to go to sleep.
        /// </summary>
        public void Sleep()
        {
            OnSleep();
        }

        #endregion
    }
}
