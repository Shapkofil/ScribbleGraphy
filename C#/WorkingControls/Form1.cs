using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkingControls
{
    public partial class Form1 : Form
    {
        

        Bitmap bmp;
        Point lastPoint;
        Pen p = new Pen(Color.White, 25);
        Graphics g;
        ModelReader modelReader;
        public Form1()
        {
            InitializeComponent();

            typeof(Panel).InvokeMember("DoubleBuffered", System.Reflection.BindingFlags.SetProperty
            | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic, null,
            drawable, new object[] { true });

            bmp = new Bitmap(drawable.ClientSize.Width, drawable.ClientSize.Height,
                System.Drawing.Imaging.PixelFormat.Format32bppPArgb);

            drawable.MouseDown += drawable_MouseDown;
            drawable.MouseMove += drawable_MouseMove;
            drawable.Paint += drawable_Paint;
            
            g = Graphics.FromImage(bmp);
            g.Clear(Color.Black);

            modelReader = new ModelReader(@"D:\_BigFatProjects\ScribbleGraphy\Mixed\WorkingControls\WorkingControls\bin\Debug\ModelReader.py"
                ,"model");
            modelReader.SoftmaxFire += OnSoftmaxFire;

        }
        public void OnSoftmaxFire(object soruce,cmdEventArgs e)
        {
            if(e.prediction != null) ThreadHelperClass.SetText(this, label1, e.prediction); 
            else ThreadHelperClass.SetText(this, label1, "Recognizing.......");
        }
        private void drawable_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(bmp, Point.Empty);
        }

        private void drawable_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {

                    g.DrawLine(p, lastPoint, e.Location);
       

                lastPoint = e.Location;
                drawable.Invalidate();
                pictureBox1.Image = bmp;
                bmp.Save("img.png", System.Drawing.Imaging.ImageFormat.Png);
                
            }
        }

        private void drawable_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = e.Location;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            g.Clear(drawable.BackColor);
           
            drawable.Invalidate();
            pictureBox1.Image = null;
        }





        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            //run_cmd(@"D:\_BigFatProjects\ScribbleGraphy\Mixed\WorkingControls\WorkingControls\bin\Debug\mnist.py");
        }

        private void drawable_MouseUp(object sender, MouseEventArgs e)
        {
            //run_cmd(@"D:\_BigFatProjects\ScribbleGraphy\Mixed\WorkingControls\WorkingControls\bin\Debug\mnist.py");
            //label1.Text = modelReader.evaluate("img.png");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //modelReader.process.Kill();
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
            
            if (e.Node.Text != "Free Writing")
            {

                  Form2 f = new Form2();
                    f.Show();
                    f.Focus();  

                
            }
                
                

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string dir = @"C:\Users\evi02\source\repos\Mixed\WorkingControls\WorkingControls\bin\Debug";
            int i = 0;
            string filename = string.Format("image{0}.png", i);

            if (Directory.GetFiles(dir, "image*.png").Length ==0)
                bmp.Save("image0.png", System.Drawing.Imaging.ImageFormat.Png);
            else while(Directory.GetFiles(dir, filename).Length !=0)
                {
                    i++;
                    filename = string.Format("image{0}.png", i);
                }
            bmp.Save(filename, System.Drawing.Imaging.ImageFormat.Png);
        }
    }
}


public static class ThreadHelperClass
{
    
    delegate void SetTextCallback(Form f, Control ctrl, string text);
    /// <summary>
    /// Set text property of various controls
    /// </summary>
    /// <param name="form">The calling form</param>
    /// <param name="ctrl"></param>
    /// <param name="text"></param>
    public static void SetText(Form form, Control ctrl, string text)
    {
        // InvokeRequired required compares the thread ID of the 
        // calling thread to the thread ID of the creating thread. 
        // If these threads are different, it returns true. 
        if (ctrl.InvokeRequired)
        {
            SetTextCallback d = new SetTextCallback(SetText);
            form.Invoke(d, new object[] { form, ctrl, text });
        }
        else
        {
            ctrl.Text = text;
        }
    }
    
}
