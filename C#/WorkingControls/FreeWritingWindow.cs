﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.Threading;

namespace WorkingControls
{
    public partial class FreeWritingWindow : Prime
    {
        //Declaring and Initializing variables for Drawing
        Bitmap bmp;
        Point lastPoint;
        Graphics g;
        SolidBrush blackInk = new SolidBrush(Color.Black);

        //Declaring and Initializing variables for Writing Systems
        List<string> updatableWritingSystems = new List<string>();
        string path = @"images_background";
        public static string currentWritingSystem;

        //Declaring and Initializing variables for Predicting
        public Thread taskThread;
        public int imgindex = -1;
        int cp;
        string resultCharacter = null;

        //Declaring and Initializing variables for Activities
        public int activity;                    //  0 == Free Writing;   1 == Practice;  2 == With template.
        public Bitmap templateImage;
        Bitmap hintMask = new Bitmap("hintMask.bmp");



        //Events for Initializing
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
            
            //Program.modelReader.SoftmaxFire += OnSoftmaxFire;
            updateScreens();
        }
        public void updateScreens()
        {
            //Free writing screen
            if (activity == 0)
            {
                label1.Text = "Free Writing";
                comboBox1.Visible = true;
                comboBox1.SelectedText = currentWritingSystem;
                fillTheComboBox();
                NextButton.Visible = false;
                ExitButton.Visible = false;
            }

            //Practice screen
            if (activity == 1)
            {
                label1.Text = "Practice";
                label2.Visible = false;
                comboBox1.Visible = false;
                NextButton.Visible = true;
                ExitButton.Visible = true;

                PredictionDisplay.Image = templateImage;
                Thread t = new Thread(HintDelay);
                t.Start();
            }

            //Template Writing screen
            if (activity == 2)
            {
                label1.Text = "Template Writing";
                label2.Visible = false;
                comboBox1.Visible = false;
                NextButton.Visible = true;
                ExitButton.Visible = true;

                drawable.BackColor = Color.White;
                g.Clear(Color.Transparent);
                drawable.BackgroundImage = ChangeColor(templateImage, Color.Black, Color.Gray);
                drawable.BackgroundImageLayout = ImageLayout.Stretch;
                PredictionDisplay.Image = templateImage;
            }
        }
        public static Bitmap ChangeColor(Image img, Color oldColor, Color newColor)
        {
            Bitmap bmp = new Bitmap(img);

            for (int x = 0; x < bmp.Width; x++)
            {
                for (int y = 0; y < bmp.Height; y++)
                {
                    Color gotColor = bmp.GetPixel(x, y);

                    if (gotColor.R == oldColor.R &&
                        gotColor.G == oldColor.G &&
                        gotColor.B == oldColor.B)
                    {
                        gotColor = Color.FromArgb(newColor.R, newColor.G, newColor.B);
                        bmp.SetPixel(x, y, gotColor);
                    }
                }
            }

            return bmp;
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
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentWritingSystem = comboBox1.SelectedItem.ToString();
        }

        //Events for Drawing and Predicting
        public void OnSoftmaxFire(object soruce,cmdEventArgs e)
        {
            if (e.prediction != null)
            {
                ThreadHelperClass.SetText(this, simbolLabel, "acc= " + e.acc + "%");
                if(activity==0) PredictionDisplay.Image = 
                    VisualExamples.img_dic[currentWritingSystem][Int32.Parse(e.prediction)];
                cp = Int32.Parse(e.prediction);
                resultCharacter = e.prediction;
                
            }
            else ThreadHelperClass.SetText(this, simbolLabel, "Recognizing.......");
        }
        private void drawable_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(bmp, Point.Empty);
        }
        private void drawable_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                softbrush.drawLine(g, blackInk, lastPoint, e.Location,12);

                lastPoint = e.Location;
                drawable.Invalidate();

                if(activity != 1) PredictionDisplay.Image = bmp;        
            }
        }
        private void drawable_MouseUp(object sender, MouseEventArgs e)
        {
            bmp.Save("img.png", System.Drawing.Imaging.ImageFormat.Png);

           Thread t = new Thread(GiveTask);
            t.Start();
        }
        private void GiveTask()
        {
            //Program.modelReader.GiveTask(imgindex);
        }
        private void drawable_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = e.Location;
        }

        //Events for Buttons
        private void ExitButton_Click(object sender, EventArgs e)
        {
            activity = 0;
            updateScreens();
            imgindex = -1;
            g.Clear(Color.White);
            simbolLabel.Text = "Ready!";
            drawable.Invalidate();
            PredictionDisplay.Image = null;
        }
        private void PredictionDisplay_Click(object sender, EventArgs e)
        {
            //Shows Hint in Practice Mode
            if (activity == 1)
            {
                PredictionDisplay.Image = templateImage;
                Thread t = new Thread(HintDelay);
                t.Start();
            }
        }
        private void HintDelay()
        {
            Thread.Sleep(1000);                         //Hint period in milliseconds
            PredictionDisplay.Image = hintMask;
        }
        private void ClearButton_Click(object sender, EventArgs e)
        {
            if (activity == 2) g.Clear(Color.Transparent);
            else g.Clear(Color.White);
            simbolLabel.Text = "Ready!";
            drawable.Invalidate();
            if (activity != 1) PredictionDisplay.Image = null;
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            string dir = AppDomain.CurrentDomain.BaseDirectory + "/My_Characters/Unidentified/Unidentified";

            int i = 0;
            string filename = string.Format("image{0}.png", i);
            while (Directory.GetFiles(dir, filename).Length != 0)
            {
                i++;
                filename = string.Format("image{0}.png", i);
            }

            if (activity == 2)
            {
                Bitmap image1 = new Bitmap(bmp.Width, bmp.Height);
                using (Graphics g1 = Graphics.FromImage(image1))
                {
                    g1.Clear(Color.White);
                    g1.DrawImage(bmp, 0, 0);
                }
                image1.Save(string.Format("My_Characters/Unidentified/Unidentified/{0}", filename), System.Drawing.Imaging.ImageFormat.Png);
            }
            else
                bmp.Save(string.Format("My_Characters/Unidentified/Unidentified/{0}", filename), System.Drawing.Imaging.ImageFormat.Png);
        }
        private void NextButton_Click(object sender, EventArgs e)
        {
            if (activity == 1)
            {
                GalleryWindow f = new GalleryWindow();
                f.Show();
                f.Focus();

                f.label1.Text = "Choose a character:";
            }

            if (activity == 2)
            {
                GalleryWindow f = new GalleryWindow();
                f.Show();
                f.Focus();

                f.label1.Text = "Choose a character:";
            }
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

