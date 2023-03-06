using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JURNAL_MOD3_1302210084
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int x = 0; int y = 0;
        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OUTPUT.Text = OUTPUT.Text + "1";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            OUTPUT.Text = OUTPUT.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            OUTPUT.Text = OUTPUT.Text + "9";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OUTPUT.Text = OUTPUT.Text + "5";
        }

        private void button7_Click(object sender, EventArgs e)
        {
     
            OUTPUT.Text = OUTPUT.Text + "7";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OUTPUT.Text = OUTPUT.Text + "6";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OUTPUT.Text = OUTPUT.Text + "3";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OUTPUT.Text = OUTPUT.Text + "2";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OUTPUT.Text = OUTPUT.Text + "4";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            y = int.Parse(OUTPUT.Text);
            int sum = x + y;
            OUTPUT.Text = sum.ToString();
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            OUTPUT.Text = OUTPUT.Text + "0";
        }

        private void button10_Click(object sender, EventArgs e)
        {
             x = int.Parse(OUTPUT.Text);
             OUTPUT.Text = "";
        }
    }
}
