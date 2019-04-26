using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Timers;

namespace WorkingControls
{
    public class cmdEventArgs : EventArgs
    {
        public string prediction { get; set; }
        public Process process { get; set; }
        public string acc { get; set; }
    }
    public class ModelReader
    {
        string scriptname;
        public ProcessStartInfo scriptInfo;
        public Process process;
        public Label currentDisplay;

        public delegate void SoftmaxFireEventHandler(object source,cmdEventArgs e);
        public event SoftmaxFireEventHandler SoftmaxFire;


        public ModelReader(string _scriptname,string modelName)
        {
            scriptname = AppDomain.CurrentDomain.BaseDirectory + "/" + _scriptname;
            Thread thread = new Thread(() => Run(modelName));
            thread.Start();
        }

        public void Run(string modelName)
        {
            ProcessStartInfo start = new ProcessStartInfo();

            start.FileName = @"python";
            start.Arguments = string.Format("{0} {1}", scriptname,modelName);
            start.UseShellExecute = false;
            start.RedirectStandardOutput = true;
            start.RedirectStandardInput = true;
            start.CreateNoWindow = true;
            Debug.Print("Loading...");
            Thread.Sleep(1000);

            process = Process.Start(start);
            using (StreamWriter writer = process.StandardInput)
            using (StreamReader reader = process.StandardOutput)
            {
                bool first = true;
                while(true)
                {
                    writer.WriteLine("img.png " + FreeWritingWindow.currentWritingSystem);
                    //Console.WriteLine("written: " + input + i);

                    string result = null;
                   result = reader.ReadLine();
                    if (first)
                    {
                        Debug.Print("Loaded!!");
                        first = false;
                    }
                    OnSoftmaxFire(process, result);
                    //Console.WriteLine("read: " + result + "\n");
                    Thread.Sleep(1000);
                }
            }
        }

        protected virtual void OnSoftmaxFire(Process process,string stream)
        {
           // Debug.Print("loaded3");
            if (SoftmaxFire != null)
            {
                //  Debug.Print("loaded3.5");
                string[] args = stream.Split('#');
                cmdEventArgs e = new cmdEventArgs();
                e.prediction = args[0];
                e.acc = args[1];
               // Debug.Print("loaded4.5");
                e.process = process;
                SoftmaxFire(this,e);
            }
        }

        private void Process_Exited(object sender, System.EventArgs e)
        {
            Debug.Print("exited");
        }
    }
}
