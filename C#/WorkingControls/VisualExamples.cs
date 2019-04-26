using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace WorkingControls
{
    class VisualExamples
    {
        public static Dictionary<string, List<Bitmap>> img_dic = new Dictionary<string, List<Bitmap>>();
        public VisualExamples(string path)
        {
            
            foreach (string writingSystem in Directory.GetDirectories(path))
            {
       
                List<Bitmap> temp = new List<Bitmap>();
                foreach (string character in Directory.GetDirectories(writingSystem))
                {
                    string img_root = Directory.GetFiles(character)[0];
                    temp.Add(new Bitmap(img_root));
                }
                img_dic.Add(new DirectoryInfo(writingSystem).Name,temp);
            }
        }
    }
}
