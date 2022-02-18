using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AppXemGioTG
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = openFileDialog1.FileName;
            }    
        }

        private void pictureBox1_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            vScrollBar1.Minimum = 0;
            vScrollBar1.Maximum = pictureBox1.Image.Size.Height - panel1.Height;
            
            hScrollBar1.Minimum = 0;
            hScrollBar1.Maximum  = pictureBox1.Image.Size.Width - panel1.Width;

            pictureBox1.Height = pictureBox1.Image.Size.Height;
            pictureBox1.Width = pictureBox1.Image.Size.Width;
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            pictureBox1.Top = -vScrollBar1.Value;
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            pictureBox1.Left = -hScrollBar1.Value;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
