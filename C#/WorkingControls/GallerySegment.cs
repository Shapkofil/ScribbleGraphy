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
    public partial class GallerySegment : UserControl
    {
        string collectionDir;
        bool trash;
        string imgDir;

        public GallerySegment(string dir, string label)
        {
            InitializeComponent();
            collectionDir = dir;
            RefreshView(dir);
            label1.Text = label;
        }
        public void RefreshView(string dir)
        {
            string[] fileEntries = Directory.GetFiles(dir);

            foreach (string fileName in fileEntries)
            {
                //Debug.Print(fileName);
                ImgDisplay temp = new ImgDisplay(fileName);
                imgDir = fileName;
                CatDisplay.Controls.Add(temp);
                


                //temp.TrashButton.Click += TrashButton_Click;
            }
        }
        private void TrashButton_Click(object sender, EventArgs e)
        {
            RefreshView(collectionDir);
        }
    }
}
