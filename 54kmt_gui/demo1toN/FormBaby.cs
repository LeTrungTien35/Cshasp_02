using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace demo1toN
{
    public partial class FormBaby : Form
    {
        public FormBaby()
        {
            InitializeComponent();
        }


        //step1: nơi nhận có hàm public nhận, nhận 1 chuỗi
        //hiển thị chuỗi đó lên ô textBox1
        public void NhanText(string t){
            textBox1.Text = t;
        }

        //baby này biết bố là ai rồi
        public FormPapa myPapa;
        private void button1_Click(object sender, EventArgs e)
        {
            //share to all ae tôi
            //gọi bố, bảo bố gửi cho các ae của tôi
            myPapa.ShareToAllBaby(textBox1.Text);
        }
    }
}
