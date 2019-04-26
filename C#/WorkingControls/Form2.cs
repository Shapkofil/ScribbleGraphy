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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showSidePanelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (showSidePanelToolStripMenuItem.Checked == true)
                treeView1.Visible = true;
            else if (showSidePanelToolStripMenuItem.Checked == false)
                treeView1.Visible = false;
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Text == "Free Writing")
            {
                             
                this.Close();
            }

        }
    }
}
