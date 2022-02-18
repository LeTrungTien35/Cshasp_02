using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient; // thư viện hỗ trợ sql
namespace QuanLySinhVienKMT
{
    public partial class frmMain : Form
    {
        SqlConnection connection; // tạo biến kết nối
        SqlCommand command; // tạo câu truy vấn
        // gắn database vào biến
        string str = @"Data Source=DESKTOP-7KJ5F4U\SQLEXPRESS;Initial Catalog=DanhSachSvKmt;Integrated Security=True";

        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable(); // tạo table để nhận dữ liệu

        // hàm load dữ liệu
        void loaddata()
        {
            command = connection.CreateCommand();// khởi tạo xử lý kết nối
            command.CommandText = "select * from DanhSachKmt";
            adapter.SelectCommand = command; // thực thi câu truy vấn
            table.Clear();
            adapter.Fill(table);
            dgv.DataSource = table;  
        }

        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        // hiển thị toàn bộ danh sách sinh viên
        private void button1_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);// chuyền vào chuỗi kết nối
            connection.Open();
            loaddata();
        }
        // Tạo sự kiên cho dgv và băm nhỏ giữ liệu cho vào box
        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgv.CurrentRow.Index;
            tbMssv.Text = dgv.Rows[i].Cells[1].Value.ToString();
            tbLop.Text = dgv.Rows[i].Cells[5].Value.ToString();
            tbDiaChi.Text = dgv.Rows[i].Cells[6].Value.ToString();
            tbEmail.Text = dgv.Rows[i].Cells[8].Value.ToString();
            tbTen.Text = dgv.Rows[i].Cells[3].Value.ToString();
        }
        // Thêm sinh viên
        private void btThem_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "insert into DanhSachKmt(Mssv,Lop,DiaChi,Email,Ten) values('"+tbMssv.Text+ "', '" +tbLop.Text+"', '" +tbDiaChi+"', '" +tbEmail.Text+"', '" +tbTen.Text+"')";
            command.ExecuteNonQuery();
            loaddata();
        }
        // xóa sinh viên

        private void btXoa_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "delete from DanhSachKmt where Mssv= '" + tbMssv.Text+ "'";
            command.ExecuteNonQuery();
            loaddata();
        }

        

    }
}
