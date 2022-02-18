using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace demo1toN
{
    public partial class FormPapa : Form
    {
        public FormPapa()
        {
            InitializeComponent();
        }


        //method này để cho 1 thằng con nào đó gọi: method phải là public
        public void ShareToAllBaby(string str)
        {
            txtHI.Text = str;
            foreach (FormBaby baby in listBaby)
            {
                baby.NhanText(txtHI.Text);
            }
        }

        private void SendToAll_Click(object sender, EventArgs e)
        {
            //muốn truyền sang nơi nào
            //thì cần phải có biến trỏ tới nơi đó
            foreach (FormBaby baby in listBaby)
            {
                baby.NhanText(txtHI.Text);
            }
        }
        List<FormBaby> listBaby = new List<FormBaby>();
        private void makeBaby_Click(object sender, EventArgs e)
        {
            //tạo ra 1 fromN
            //sẽ chạy vô số lần
            FormBaby litterBaby = new FormBaby();
            listBaby.Add(litterBaby);
            litterBaby.Show();
            litterBaby.myPapa = this;  //gán this cho form -> myPapa vừa tạo ra
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormBaby f = new FormBaby();
            f.Show();
            f.myPapa = this; //vẫn cho nó biết bố nào là ta
        }
    }
}
