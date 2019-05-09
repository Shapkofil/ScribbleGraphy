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
        public string path = @"images_background";                         //Path for Wriring Systems(Used in ComboBox)
        public string path2 = @"images_background";                             //Path for characters(Used in Segments)
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
            comboBox1.SelectedText = FreeWritingWindow.currentWritingSystem;

            isBulgarian = (label2.Text == "Писменост:");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            FreeWritingWindow.currentWritingSystem = comboBox1.SelectedItem.ToString();
            path2 = path + @"\" + FreeWritingWindow.currentWritingSystem;
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
                GallerySegment segment = new GallerySegment(characterName, Path.GetFileName(characterName), raw_index);
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