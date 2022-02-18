using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TuongTacCSDL
{
    public partial class Form1 : Form
    {
        // tao hai bien cuc bo
        String strCon = @"Data Source=DESKTOP-7KJ5F4U\SQLEXPRESS;Initial Catalog=DanhSachSvKmt;Integrated Security=True";
        // doi tuong ket noi
        SqlConnection sqlCon = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnMoKetNoi_Click(object sender, EventArgs e)
        {
            try
            {
                if(sqlCon == null)
                {
                    sqlCon = new SqlConnection(strCon);
                    // rong thi tao moi
                }
                             
                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();// dong thi mo
                    MessageBox.Show("Kết nối thành công!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message); //show loi
            }
        }

        private void btnDongKetNoi_Click(object sender, EventArgs e)
        {
            if (sqlCon != null && sqlCon.State == ConnectionState.Open)
            {
                sqlCon.Close();
                MessageBox.Show("Đóng kết nối!");
            }
            else
            {
                MessageBox.Show("Chưa tạo kết nối!");
            }
        }
    }
}
