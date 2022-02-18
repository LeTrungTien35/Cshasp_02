using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _54kmt_gui
{
    public partial class frmTimKiem : Form
    {
        public frmTimKiem()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Nút 1 được bấm");
            //code tìm kiếm....
            //truyền sang from2
            Program.fMain.NhanDuLieu("tìm thấy 8 sv chứa từ '"+txtSearch.Text+"'");
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           // MessageBox.Show("Nút 2 được bấm");
            this.Close(); //đóng form lại
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string tyGia=Program.fMain.ChoDiTyGia();

            txtSearch.Text = "Tỉ giá là: " + tyGia;
        }

        public void NhanTyGia(string tyGia)
        {
            txtSearch.Text = "Nhận được Tỷ giá là: " + tyGia;
        }

        public void NhanLoiChao(string hi)
        {
            txtSearch.Text = hi;
        }

        frmHello fHello;
        private void button5_Click(object sender, EventArgs e)
        {
            if (fHello == null || fHello.IsDisposed)
                fHello = new frmHello();
            fHello.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (fHello != null && !fHello.IsDisposed)
                fHello.NhanText(txtSearch.Text);
        }
    }
}