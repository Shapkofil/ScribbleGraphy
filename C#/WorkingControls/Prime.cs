﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Diagnostics;
using System.Globalization;

namespace WorkingControls
{
    public partial class Prime : Form
    {
        static List<Color> scheme = new List<Color>()
        {
            System.Drawing.ColorTranslator.FromHtml("#fff3bc"),
            System.Drawing.ColorTranslator.FromHtml("#b085a9"),
            System.Drawing.ColorTranslator.FromHtml("#8a85b0")
        };
        static Dictionary<string, int> tagmeaning = new Dictionary<string, int>()
        {
            {"focus" , 0},
            {"tools" , 1},
            {"utils" , 2},
        };
        private Point initClick;
        public bool isDragging;
        public bool isBulgarian = WorkingControls.Properties.Settings.Default.isBulgarian;


        public Prime()
        {
            if (isBulgarian)
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("bg-BG");

            InitializeComponent();
            SplashPaint(Controls);      //Adds colour to controls

            practiceToolStripMenuItem.Click += practiceToolStripMenuItem_Click;

            isBulgarian = (fileToolStripMenuItem.Text == "Файл");
        }

        //Events for Colouring
        private void SplashPaint(Control.ControlCollection controls)
        {
            foreach(Control c in controls)
            {
                c.BackColor = ChoosePaint(c);

                if (c.HasChildren)
                    SplashPaint(c.Controls);
            }
        }
        private Color ChoosePaint(Control c)
        {
            object tag = c.Tag;
            string keyword;
            if (tag is string)                  //checks if c has a tag, only tagged controls must be changed
            {
                keyword = tag as string;
            }
            else
            {
                return c.BackColor;             //the control doesn't have a tag, so leaving it without change
            }
            try
            {
                return scheme[tagmeaning[keyword]];     //changes the colour of c
            }
            catch(Exception e)
            {
                return c.BackColor;                     //in case anything goes wrong, returns c unchanged
            }
        }

        //Events for Titlebar
        private void windowBar_MouseDown(object sender, MouseEventArgs e)
        {
            initClick = e.Location;
            isDragging = true;
        }
        private void windowBar_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }
        private void windowBar_MouseMove(object sender, MouseEventArgs e)
        {
            if(isDragging)
            {
                this.Location = normalizePoint(e.Location);
            }
        }
        private Point normalizePoint(Point rawClick)
        {
            rawClick = PointToScreen(rawClick);
            return new Point(rawClick.X - initClick.X, rawClick.Y - initClick.Y);
        }


        [STAThread]
        private void practiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GalleryWindow f = new GalleryWindow();
            f.Show();
            f.Focus();

            if (isBulgarian)
                f.label1.Text = "Изберете символ:";
            else
                f.label1.Text = "Choose character:";

            var main = Application.OpenForms.OfType<FreeWritingWindow>().First();
            main.activity = 1;
        }
        private void templateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GalleryWindow f = new GalleryWindow();
            f.Show();
            f.Focus();

            if (isBulgarian)
                f.label1.Text = "Изберете символ:";
            else
                f.label1.Text = "Choose character:";

            var main = Application.OpenForms.OfType<FreeWritingWindow>().First();
            main.activity = 2;
        }
        private void allCharactersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GalleryWindow f = new GalleryWindow();
            f.Show();
            f.Focus();
        }
        private void myCharactersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GalleryWindow f = new GalleryWindow();
            f.Show();
            f.Focus();

            f.path = @"My_characters";
            if (isBulgarian)
                f.CharactersButton.Text = "Моите Символи";
            else
                f.CharactersButton.Text = "My Characters";

            f.fillTheComboBox();
            f.path2 = f.path + @"\" + f.comboBox1.SelectedItem.ToString();
            f.fillTheDisplays();
        }
        private void openAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GalleryWindow f = new GalleryWindow();
            f.Show();
            f.Focus();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WorkingControls.Properties.Settings.Default.isBulgarian = false;
            WorkingControls.Properties.Settings.Default.Save();

            if (Application.OpenForms.Count == 1)
            {
                System.Environment.Exit(1);
            }
            else
            {
                Debug.Print("" + Application.OpenForms.Count);
                Close();
            }
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Program.modelReader.process.Kill();
        }
        private void showSidePanelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (showSidePanelToolStripMenuItem.Checked == true)
                treeView1.Visible = true;
            else if (showSidePanelToolStripMenuItem.Checked == false)
                treeView1.Visible = false;
        }

        //Tool Strip Items For Changing Language
        private void БългарскиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isBulgarian)
            {
                WorkingControls.Properties.Settings.Default.isBulgarian = true;
                WorkingControls.Properties.Settings.Default.Save();

                Application.Restart();
            }
        }
        private void EnglishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isBulgarian)
            {
                WorkingControls.Properties.Settings.Default.isBulgarian = false;
                WorkingControls.Properties.Settings.Default.Save();

                Application.Restart();
            }
        }

        //Events for Side Panel
        private void treeView1_AfterSelect_1(object sender, TreeViewEventArgs e)
        {
            if (isBulgarian)
                switch (treeView1.SelectedNode.Text)
                {
                    case "Упражнение":
                        GalleryWindow f = new GalleryWindow();
                        f.Show(this);
                        f.Focus();
                        f.label1.Text = "Изберете символ:";

                        var main = Application.OpenForms.OfType<FreeWritingWindow>().First();
                        main.activity = 1;
                        break;

                    case "Обучение":
                        f = new GalleryWindow();
                        f.Show(this);
                        f.Focus();
                        f.label1.Text = "Изберете символ:";

                        var main1 = Application.OpenForms.OfType<FreeWritingWindow>().First();
                        main1.activity = 2;
                        break;

                    case "Всички Символи":
                        f = new GalleryWindow();
                        f.Show(this);
                        f.Focus();
                        break;

                    case "Моите Символи":
                        f = new GalleryWindow();
                        f.Show(this);
                        f.Focus();
                        f.path = @"My_characters";
                        f.label1.Text = "Изберете символ:";

                        f.fillTheComboBox();
                        f.path2 = f.path + @"\" + f.comboBox1.SelectedItem.ToString();
                        f.fillTheDisplays();
                        break;
                }
            else
                switch (treeView1.SelectedNode.Text)
                {
                    case "Practice":
                        GalleryWindow f = new GalleryWindow();
                        f.Show(this);
                        f.Focus();
                        f.label1.Text = "Choose Character:";

                        var main = Application.OpenForms.OfType<FreeWritingWindow>().First();
                        main.activity = 1;
                        break;

                    case "Template Writing":
                        f = new GalleryWindow();
                        f.Show(this);
                        f.Focus();
                        f.label1.Text = "Choose Character:";
                        var main1 = Application.OpenForms.OfType<FreeWritingWindow>().First();
                        main1.activity = 2;
                        break;

                    case "All Characters":
                        f = new GalleryWindow();
                        f.Show(this);
                        f.Focus();
                        break;

                    case "My Characters":
                        f = new GalleryWindow();
                        f.Show(this);
                        f.Focus();
                        f.path = @"My_characters";
                        f.label1.Text = "Choose Character:";
                        f.fillTheComboBox();
                        f.path2 = f.path + @"\" + f.comboBox1.SelectedItem.ToString();
                        f.fillTheDisplays();
                        break;
                }
        }


    }
}
