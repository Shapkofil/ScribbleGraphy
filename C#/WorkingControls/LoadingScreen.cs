using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkingControls
{
    public partial class LoadingScreen : Form
    {
        public LoadingScreen()
        {
            InitializeComponent();
        }
        public void OnLoadedModel(object soruce, EventArgs e)
        {
            Program.mainWindow.Invoke(new MethodInvoker(Program.mainWindow.Show));
            //this.Hide();
        }
    }
}
