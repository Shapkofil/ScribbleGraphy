using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace WorkingControls
{
    public partial class GalleryWindow : WorkingControls.Prime
    {

        string path = @"images_background";
        string path2 = @"images_background";
        List<GallerySegment> updatableSegments = new List<GallerySegment>();
        public List<string> updatableWritingSystems = new List<string>();


        public GalleryWindow()
        {
            InitializeComponent();
            fillTheDisplays();
            fillTheComboBox();
        }

        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {            
            path2 = path + @"\" + comboBox1.SelectedItem.ToString();
            fillTheDisplays();
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
        }

        public void fillTheDisplays()
        {

            foreach (GallerySegment segment in updatableSegments)
            {                
                TrueGallery.Controls.Remove(segment);              
            }

            updatableSegments = new List<GallerySegment>();

            foreach (string characterName in Directory.GetDirectories(path2))
            {
                
                GallerySegment segment = new GallerySegment(characterName, Path.GetFileName(characterName));
                updatableSegments.Add(segment);
                TrueGallery.Controls.Add(segment);
                segment.Width = TrueGallery.Width - 50;
                segment.Location = new Point(segment.Location.X + 25, segment.Location.Y);
            }

            /*
            string dir = AppDomain.CurrentDomain.BaseDirectory + @"\Gallery";
            string dir2 = AppDomain.CurrentDomain.BaseDirectory + @"\images";
            GallerySegment temp = new GallerySegment(dir);
            TrueGallery.Controls.Add(temp);
            TrueGallery.Controls.Add(new GallerySegment(dir2));
            temp.Width = TrueGallery.Width - 25;
            */
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "All Characters")
            {
                path = @"My_characters";
                button1.Text = "My Characters";
            }
            else if (button1.Text == "My Characters")
            {
                button1.Text = "All Characters";
                path = @"images_background";
            }

            fillTheComboBox();
            path2 = path + @"\" + comboBox1.SelectedItem.ToString();
            fillTheDisplays();
        }

        private void GalleryWindow_Resize(object sender, EventArgs e)
        {
            foreach (GallerySegment segment in updatableSegments)
            {               
                segment.Width = TrueGallery.Width - 50;
                segment.Location = new Point(segment.Location.X + 25, segment.Location.Y);
            }
        }

        private void TrueGallery_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GalleryWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
