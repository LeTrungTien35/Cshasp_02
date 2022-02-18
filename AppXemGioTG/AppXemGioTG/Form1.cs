using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AppXemGioTG
{
    public partial class Form1 : Form
    {
        int offset = 0;
        string QG = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // code này sẽ tự động thực hiện sau khoảng time là intervel

            string t = DateTime.Now.AddHours(offset).ToString(" dd/MM/yyyy HH:mm:ss");
            t = "Thời gian " + QG + t.Replace("/", "-");
            label1.Text = t;
            this.Text = t;
        }

        private void button1_Click(object sender, EventArgs e)
        {           
            timer1.Enabled = !timer1.Enabled;
            button1.Text = "Bấm để " + (timer1.Enabled ? "dừng" : "hiển thị");
        }

        void settime(String nuoc)
        {
            switch(nuoc)
            {
                case "VN":
                    offset = 0;
                    QG = "VN";
                    break;

                case "USA":
                    offset = -11;
                    QG = "USA";
                    break;
            }    

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            settime("VN");
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            settime("USA");
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label2.Text = trackBar1.Value.ToString() + "ms";
            timer1.Interval = trackBar1.Value;  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form2().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Form4().Show();
        }
    }
}
