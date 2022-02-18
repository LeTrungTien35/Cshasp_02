using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _54kmt_gui
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        public frmTimKiem f1;  //f1 là null
        private void button1_Click(object sender, EventArgs e)
        {
            //frmTimKiem f = new frmTimKiem();
            //f.Show();

            //hoặc viết nhanh
            new frmTimKiem().Show();

            //nếu muốn chỉ có 1 frmTimKiem Xuất hiện mà thôi
            //dù cho trên Fmain bấm nhiều lần:
            //if (f1 == null || f1.IsDisposed)
            //{
            //    f1 = new frmTimKiem();  //cấp phát bộ nhớ cho biến đối tượng f1
            //}
            //f1.Show();
        }

        //viết 1 method PUBLIC trên NƠI NHẬN dữ liệu
        //nhận cái gì: thông qua tham số
        public void NhanDuLieu(string str)
        {
            textBox1.Text = str;
        }

        public string ChoDiTyGia()
        {
            return txtBitCOin.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (f1 != null && !f1.IsDisposed)
            {
                f1.NhanTyGia(txtBitCOin.Text);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new frmHello().Show();
        }
    }
}
