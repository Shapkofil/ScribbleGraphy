using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkingControls
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 

        public static ModelReader modelReader;
        public static FreeWritingWindow f;
        public static GalleryWindow f2;

        public static int activity;

        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            modelReader = new ModelReader(@"ModelReader.py", "oneshot");
            VisualExamples visualexampler = new VisualExamples(AppDomain.CurrentDomain.BaseDirectory +
                "/images_background");

            f = new FreeWritingWindow();
            Application.Run(f);


        }
    }
}
