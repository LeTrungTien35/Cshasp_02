using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _54kmt_gui
{
    public partial class frmHello : Form
    {
        public frmHello()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Program.fMain.f1 != null && !Program.fMain.f1.IsDisposed)
                Program.fMain.f1.NhanLoiChao(txtCHao.Text);
        }

        public void NhanText(string str) {
            txtCHao.Text = str;
        }
    }
}
