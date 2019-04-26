using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkingControls
{
    public partial class ImgDisplay : UserControl
    {

        public Bitmap image;
        public string root { get; set; }
        public string pricetag;


        public ImgDisplay(string imgPath)
        {
            InitializeComponent();
            root = imgPath;
            image = new Bitmap(root);
            pictureBox1.Image = image;
        }

        private void TrashButton_Click(object sender, EventArgs e)
        {
            System.IO.File.Delete(root);
        }
    }
}
