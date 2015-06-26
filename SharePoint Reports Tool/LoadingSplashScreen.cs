using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace SharePointReportsTool
{
    public partial class LoadingSplashScreen : Form
    {
        // need delegate for cross-thread calling
        private delegate void StopRunning();
        private delegate void UpdateProgress();

        // static background and loadingbar variables
        private static LoadingSplashScreen loading;
        private static BackgroundWorker work;
        private static int currentProgress;

        private static String displayName;

        public LoadingSplashScreen()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Initialize the loading bar by creating a backgroundWorker thread
        /// </summary>
        public static void startSplashScreen(String name)
        {
            // use background worker as seperate thread for progress bar
            work = new BackgroundWorker();

            // set display name for splash screen
            displayName = name;

            // sets a handler for where the backgroundworker starts when thread begins
            work.DoWork += new System.ComponentModel.DoWorkEventHandler(LoadingSplashScreen.showSplashScreen);

            // start thread
            work.RunWorkerAsync();
        }

        /// <summary>
        /// Shows loading bar
        /// </summary>
        /// <param name="sender">Placeholder object</param>
        /// <param name="e">Event activated by DoWorkEvent Handler</param>
        private static void showSplashScreen(object sender, DoWorkEventArgs e)
        {
            // start showing the loading bar when thread starts
            loading = new LoadingSplashScreen();

            loading.Text = displayName;
            loading.progressBar1.Visible = false;
            loading.pictureBox1.Visible = true;
            loading.Size = new System.Drawing.Size(338, 253);
            loading.pictureBox1.Location = new System.Drawing.Point(108, 59);

            Application.Run(loading);
        }

        /// <summary>
        /// When called, invokes the backgroundWorker thread to invoke a delegate
        /// that stops the backgroundWorker from showing the progress bar
        /// </summary>
        public static void stopSplashScreen()
        {

            // in case if there was not enough time to instantiate loading
            while (loading == null)
            {
                Thread.Sleep(5);
            }

            // in case if loading bar cancelled during loading
            if (loading.IsHandleCreated)
            {
                //invoke loading bar thread and end
                loading.Invoke(new StopRunning(LoadingSplashScreen.closeSplashScreen));
            }

            // reset loading to null to handle new cases
            loading = null;
        }

        private static void closeSplashScreen()
        {
            // end splash screen
            loading.Close();
        }

        /* Block Loading Bar Features */

        /// <summary>
        /// Initialize the loading bar (block) by creating a backgroundWorker thread
        /// </summary>
        public static void startBlockLoadingBar(String name)
        {
            // use bgWorker as seperate thread for progress bar
            work = new BackgroundWorker();

            // set display name for splash screen
            displayName = name;

            // sets a handler for where the backgroundworker starts when thread starts
            work.DoWork += new System.ComponentModel.DoWorkEventHandler(LoadingSplashScreen.showBlockLoadingBar);

            // start thread
            work.RunWorkerAsync();
        }

        /// <summary>
        /// Shows (block) loading bar
        /// </summary>
        /// <param name="sender">Placeholder object</param>
        /// <param name="e">Event actuvated by DoWorkEvent Handler</param>
        private static void showBlockLoadingBar(object sender, DoWorkEventArgs e)
        {
            //starts block loading bar
            loading = new LoadingSplashScreen();

            loading.Text = displayName;
            loading.Size = new System.Drawing.Size(338, 81);
            loading.progressBar1.Visible = true;
            loading.pictureBox1.Visible = false;

            Application.Run(loading);
        }

        /// <summary>
        /// When called, invokes the backgroundWorker thread to invoke a delegate
        /// that updates the current progress of the progressBar.
        /// </summary>
        /// <param name="progress">Current value of completion of the process</param>
        public static void updateLoadingBar(int progress)
        {
            currentProgress = progress;

            if (loading.IsHandleCreated)
            {
                //invoke loading bar thread and end
                loading.Invoke(new UpdateProgress(LoadingSplashScreen.reportProgressLoadingBar));
            }
        }

        /// <summary>
        /// When called, invokes the backgroundWorker thread to invoke a delagate that stops
        /// the backgroundWorker from showing the progress bar
        /// </summary>
        public static void stopBlockLoadingBar()
        {
            //in case if there was not enough time to instantiate loading
            while (loading == null)
            {
                Thread.Sleep(5);
            }

            //in case if loading bar cancelled during loading
            if (loading.IsHandleCreated)
            {
                //invoke loading bar thread and end
                loading.Invoke(new StopRunning(LoadingSplashScreen.closeSplashScreen));
            }

            //reset loading to null to handle new cases
            loading = null;

        }

        /// <summary>
        /// Updates the progress bar with the current progress.
        /// </summary>
        private static void reportProgressLoadingBar()
        {
            loading.progressBar1.Value = currentProgress;
        }
    }
}
