using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_01
{
  
    public partial class Form1 : Form
    {
        public int x = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            x++;
            textBox1.Text = x.ToString(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            x--;
            if (x < 0) x = 0;
            textBox1.Text = x.ToString();

        }
    }
}
