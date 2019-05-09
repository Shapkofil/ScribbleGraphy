using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;

namespace WorkingControls
{
    public partial class GalleryWindow : WorkingControls.Prime
    {
        public string path = stringData.BackGroundImgs;                         //Path for Wriring Systems(Used in ComboBox)
        public string path2 = stringData.BackGroundImgs;                             //Path for characters(Used in Segments)
        List<GallerySegment> updatableSegments = new List<GallerySegment>();
        public List<string> updatableWritingSystems = new List<string>();

        bool isBulgarian;

        public GalleryWindow()
        {
            if (isBulgarian)
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("bg-BG");
            
            InitializeComponent();
            fillTheDisplays();
            fillTheComboBox();
<<<<<<< HEAD
            comboBox1.SelectedText = FreeWritingWindow.currentWritingSystem;

            isBulgarian = (label2.Text == "Писменост:");
=======
            comboBox1.SelectedIndex = Properties.Settings.Default.currentWSindex;
>>>>>>> 23e017fecc78ea1afe501226aaacae23f442804f
        }
       
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.currentWS = comboBox1.SelectedItem.ToString();
            Properties.Settings.Default.Save();
            path2 = path + @"\" + Properties.Settings.Default.currentWS;
            Properties.Settings.Default.currentWSindex = comboBox1.SelectedIndex;
            Properties.Settings.Default.Save();
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

            
        }

        public void fillTheDisplays()
        {
            LoadingDialog.ShowSplashScreen();
            TrueGallery.Visible = false;


            foreach (GallerySegment segment in updatableSegments)
            {                
                TrueGallery.Controls.Remove(segment);              
            }

            updatableSegments = new List<GallerySegment>();

            int raw_index = 0;

            foreach (string characterName in Directory.GetDirectories(path2))
            {            
                GallerySegment segment = new GallerySegment(characterName, Path.GetFileName(characterName),raw_index);
                updatableSegments.Add(segment);
                TrueGallery.Controls.Add(segment);
                segment.Width = TrueGallery.Width - 50;
                raw_index++;
                segment.Location = new Point(segment.Location.X + 25, segment.Location.Y);
            }


            TrueGallery.Visible = true;
            LoadingDialog.CloseForm();
        }

        private void CharactersButton_Click(object sender, EventArgs e)
        {
            if (isBulgarian)
            {
<<<<<<< HEAD
                if (CharactersButton.Text == "Всички Символи")
                {
                    path = @"My_characters";
                    CharactersButton.Text = "Моите Символи";
                }
                else if (CharactersButton.Text == "Моите Символи")
                {
                    CharactersButton.Text = "Всички Символи";
                    path = @"images_background";
                }
=======
                path = stringData.UserDir;
                CharactersButton.Text = "My Characters";
>>>>>>> 23e017fecc78ea1afe501226aaacae23f442804f
            }
            else
            {
                if (CharactersButton.Text == "All Characters")
                {
                    path = @"My_characters";
                    CharactersButton.Text = "My Characters";
                }
                else if (CharactersButton.Text == "My Characters")
                {
                    CharactersButton.Text = "All Characters";
                    path = @"images_background";
                }
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
    }
}