using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkingControls
{
    public partial class GameScreen : Form
    {
        public string currentChoise = "Alphabet_of_the_Magi";
        public GameScreen()
        {
            InitializeComponent();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentChoise = comboBox1.SelectedItem.ToString();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            //open the game
        }
    }
}
