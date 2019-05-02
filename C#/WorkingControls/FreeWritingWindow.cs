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
    public partial class FreeWritingWindow : Prime
    {
        Bitmap bmp;
        Point lastPoint;
        Pen p = new Pen(Color.White, 25);
        Graphics g;
        SolidBrush blackInk = new SolidBrush(Color.Black);
        List<string> updatableWritingSystems = new List<string>();
        string path = @"images_background";
        public static string currentWritingSystem = "Alphabet_of_the_Magi";
        static int currentIndex = -1;

            
        public FreeWritingWindow()
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
            g.Clear(Color.White);

            fillTheComboBox();

            Program.modelReader.SoftmaxFire += OnSoftmaxFire;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentWritingSystem = comboBox1.SelectedItem.ToString();
        }

        public void fillTheComboBox()
        {
            foreach (string item in updatableWritingSystems)
                comboBox1.Items.Remove(item);

            updatableWritingSystems = new List<string>();

            foreach (string writingSystem in Directory.GetDirectories(path))
            {
                string writingSystemName = new DirectoryInfo(writingSystem).Name;
                updatableWritingSystems.Add(writingSystemName);
                comboBox1.Items.Add(writingSystemName);
            }

            comboBox1.SelectedIndex = 0;
            currentWritingSystem = comboBox1.SelectedItem.ToString();
        }

        public void OnSoftmaxFire(object soruce,cmdEventArgs e)
        {
            if (e.prediction != null)
            {
                ThreadHelperClass.SetText(this, simbolLabel, "acc= " + e.acc + "%");
                PredictionDisplay.Image = 
                    VisualExamples.img_dic[currentWritingSystem][Int32.Parse(e.prediction)];
            }
            else ThreadHelperClass.SetText(this, simbolLabel, "Recognizing.......");
            if (float.Parse(e.acc) > 50 && currentIndex !=-1)
            {
                Random rnd = new Random();
                int ci = rnd.Next(VisualExamples.img_dic[currentWritingSystem].Count - 1);
                currentIndex = ci;
                PredictionDisplay.Image = VisualExamples.img_dic[currentWritingSystem][currentIndex];
            }
            
        }

        private void drawable_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(bmp, Point.Empty);
        }
        private void drawable_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {

                //g.DrawLine(p, lastPoint, e.Location);
                softbrush.drawLine(g, blackInk, lastPoint, e.Location,12);

                lastPoint = e.Location;
                drawable.Invalidate();
                if(currentIndex==-1)PredictionDisplay.Image = bmp;        
            }
        }

        private void drawable_MouseUp(object sender, MouseEventArgs e)
        {
            bmp.Save("img.png", System.Drawing.Imaging.ImageFormat.Png);
            Program.modelReader.GiveTask(currentIndex);
        }
        private void drawable_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = e.Location;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
           
            drawable.Invalidate();
            //PredictionDisplay.Image = null;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string dir = AppDomain.CurrentDomain.BaseDirectory + @"\Gallery";
            int i = 0;
            string filename = string.Format("image{0}.png", i);
            while(Directory.GetFiles(dir, filename).Length !=0)
            {
                i++;
                filename = string.Format("image{0}.png", i);
            }
            bmp.Save(string.Format("Gallery/{0}", filename), System.Drawing.Imaging.ImageFormat.Png);
        }

        private void Mgdemo_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int ci = rnd.Next(VisualExamples.img_dic[currentWritingSystem].Count - 1);
            currentIndex = ci;
            PredictionDisplay.Image = VisualExamples.img_dic[currentWritingSystem][currentIndex];
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
            try
            {
                SetTextCallback d = new SetTextCallback(SetText);
                form.Invoke(d, new object[] { form, ctrl, text });
            }
            catch(Exception e)
            {

            }
        }
        else
        {
            ctrl.Text = text;
        }
    }
    
}
