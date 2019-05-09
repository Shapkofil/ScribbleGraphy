using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
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
        public string segmentLabel;
        

        public ImgDisplay(string imgPath,int ri)
        {
            InitializeComponent();
            root = imgPath;
            image = new Bitmap(root);

            pictureBox1.Image = image;


            if (imgPath.Contains(stringData.UserDir)) label1.Visible = true;
            label1.Text = Path.GetFileNameWithoutExtension(imgPath);

            raw_index = ri;
        }

        private void TrashButton_Click(object sender, EventArgs e)
        {
            System.IO.File.Delete(root);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var main = Application.OpenForms.OfType<FreeWritingWindow>().First();
            var main1 = Application.OpenForms.OfType<GalleryWindow>().First();

            main.templateImage = image;

            main.imgindex = raw_index;

            main.updateScreens();
            main.fillTheComboBox();
            main.clearScreens();
            main.Focus();           
            main1.Close();
        }
    }
}
