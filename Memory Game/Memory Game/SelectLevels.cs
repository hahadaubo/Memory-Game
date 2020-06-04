using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memory_Game
{
    public partial class SelectLevels : Form
    {
        public SelectLevels()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Form1 formOfmedium = new Form1();
            formOfmedium.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Easy_Levels formOfeasy = new Easy_Levels();
            formOfeasy.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hard_Levels formOfhard = new Hard_Levels();
            formOfhard.Show();
        }
    }
}
