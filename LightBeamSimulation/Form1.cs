using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LightBeamSimulation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Light l = new Light(1.5, 0.05, 1, 60);
            //n0 = 1.5;
            //k = 0.05;
            //t = 1; 
            //alpha = 60;
            //textBox1.Text = Convert.ToString(l.XXmax);
            //textBox2.Text = Convert.ToString(l.YYmax);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
