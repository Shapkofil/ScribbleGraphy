using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace WorkingControls
{
    public partial class ImgDisplay : UserControl
    {

        public Bitmap image;
        public string root { get; set; }
        public string pricetag;
        int raw_index;

        public ImgDisplay(string imgPath,int ri)
        {
            InitializeComponent();
            root = imgPath;
            image = new Bitmap(root);
            pictureBox1.Image = image;
            raw_index = ri;
        }

        private void TrashButton_Click(object sender, EventArgs e)
        {
            System.IO.File.Delete(root);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var main = Application.OpenForms.OfType<FreeWritingWindow>().First();
            main.templateImage = image;

            if (main.activity == 0) main.activity = 1;

            main.updateScreens();
            main.Focus();

            main.imgindex = raw_index;

            var main1 = Application.OpenForms.OfType<GalleryWindow>().First();
            main1.Close();
        }
    }
}
