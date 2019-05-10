﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace WorkingControls
{
    public partial class LoadingDialog : Form
    {
        public LoadingDialog()
        {

            var main = Application.OpenForms.OfType<FreeWritingWindow>().FirstOrDefault();
            if (main.isBulgarian)
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("bg-BG");

            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        //Delegate for cross thread call to close
        private delegate void CloseDelegate();

        //The type of form to be displayed as the splash screen.
        private static LoadingDialog splashForm;

        static public void ShowSplashScreen()
        {
            // Make sure it is only launched once.

            if (splashForm != null)
                return;
            Thread thread = new Thread(new ThreadStart(LoadingDialog.ShowForm));
            thread.IsBackground = true;
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        static private void ShowForm()
        {
            splashForm = new LoadingDialog();
            Application.Run(splashForm);
        }

        static public void CloseForm()
        {
            splashForm.Invoke(new CloseDelegate(LoadingDialog.CloseFormInternal));
        }

        static private void CloseFormInternal()
        {
            splashForm.Close();
            splashForm = null;
        }
    }
}
