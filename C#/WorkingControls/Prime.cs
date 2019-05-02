using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Diagnostics;

namespace WorkingControls
{
    public partial class Prime : Form
    {
        static List<Color> scheme = new List<Color>()
        {
            System.Drawing.ColorTranslator.FromHtml("#fff3bc"),
            System.Drawing.ColorTranslator.FromHtml("#b085a9"),
            System.Drawing.ColorTranslator.FromHtml("#8a85b0")
        };
        static Dictionary<string, int> tagmeaning = new Dictionary<string, int>()
        {
            {"focus" , 0},
            {"tools" , 1},
            {"utils" , 2},
        };
        private Point initClick;
        public bool isDragging;

        public Prime()
        {
            InitializeComponent();
            SplashPaint(Controls);
        }


        private void SplashPaint(Control.ControlCollection controls)
        {
            foreach(Control c in controls)
            {
                c.BackColor = ChoosePaint(c);

                if (c.HasChildren)
                    SplashPaint(c.Controls);
            }
        }
        private Color ChoosePaint(Control c)
        {
            object tag = c.Tag;
            string keyword;
            if (tag is string)
            {
                keyword = tag as string;
            }
            else
            {
                return c.BackColor;
            }
            try
            {
                return scheme[tagmeaning[keyword]];
            }
            catch(Exception e)
            {
                return c.BackColor;
            }
        }


        private void windowBar_MouseDown(object sender, MouseEventArgs e)
        {
            initClick = e.Location;
            isDragging = true;
        }
        private void windowBar_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }
        private void windowBar_MouseMove(object sender, MouseEventArgs e)
        {
            if(isDragging)
            {
                this.Location = normalizePoint(e.Location);
            }
        }
        private Point normalizePoint(Point rawClick)
        {
            rawClick = PointToScreen(rawClick);
            return new Point(rawClick.X - initClick.X, rawClick.Y - initClick.Y);
        }

        private void showSidePanelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (showSidePanelToolStripMenuItem.Checked == true)
                treeView1.Visible = true;
            else if (showSidePanelToolStripMenuItem.Checked == false)
                treeView1.Visible = false;
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.modelReader.process.Kill();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Application.OpenForms.Count==1)
            {
                System.Environment.Exit(1);
            }
            else
            {
                Debug.Print("" + Application.OpenForms.Count);
                Close();
            }
        }
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Text != "Free Writing")
            {
                Prime f = new Prime();
                f.ShowDialog();
               f.Focus();
            }
        }


        [STAThread]
        private void openAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GalleryWindow f = new GalleryWindow();
            f.Show();
            f.Focus();
        }
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        public void openFreeWritingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GalleryWindow f = new GalleryWindow();
            f.Show();
            f.Focus();
        }

        private void GameDemoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
