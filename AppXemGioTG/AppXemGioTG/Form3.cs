using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AppXemGioTG
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Multiselect = false;
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fn = openFileDialog1.FileName; 
                textBox1.Text = fn;
                //textBox1.Text = openFileDialog1.FileName;
                string nd = System.IO.File.ReadAllText(fn);
                textBox1.Text += "\r\n---------------------\r\n" + nd;
            }    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.Multiselect = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string kq = "";
                foreach(string fn in openFileDialog1.FileNames)
                {
                    kq += "\r\n" + fn;
                }
                textBox1.Text = "Chọn nhiều file gồm: " + kq;   

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string fn = saveFileDialog1.FileName;
                    string nd = textBox1.Text;
                    System.IO.File.WriteAllText(fn, nd);
                    MessageBox.Show("Đã lưu!" , "OK");
                }
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi!");
            }
        }
    }
}
