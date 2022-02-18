using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TestReport.Class
{
    class Function
    {
        // khai báo biến kết nối sql
        public static SqlConnection con;

        // tạo phương thức kết nối
        public static void Connnect()
        {
            string sqlcon = @"Data Source=DESKTOP-7KJ5F4U\SQLEXPRESS;Initial Catalog=QuanLyKTX;Integrated Security=True";
            con = new SqlConnection(sqlcon);

            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            else MessageBox.Show("Kết nối DataBase không thành công!");

        }
        // Phương thức ngắt kết nối
        public static void Disconnect()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
                con.Dispose(); // giải phóng tài nguyên
                con = null;
            }
        }

        // Phương thức thực thi câu lệnh lấy dữ liệu
        public static DataTable GetDataToTable(String sql)
        {
            DataTable table = new DataTable();
            SqlDataAdapter dap = new SqlDataAdapter(sql, con);
            dap.Fill(table);
            return table;
        }

        //Hàm thực hiện câu lệnh SQL
        public static void RunSQL(string sql)
        {
            SqlCommand cmd; //Đối tượng thuộc lớp SqlCommand
            cmd = new SqlCommand();
            cmd.Connection = con; //Gán kết nối
            cmd.CommandText = sql; //Gán lệnh SQL
            try
            {
                cmd.ExecuteNonQuery(); //Thực hiện câu lệnh SQL
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            cmd.Dispose();//Giải phóng bộ nhớ
            cmd = null;
        }

        //Hàm kiểm tra mã sinh viên đã tồn tại hay chưa
        public static bool CheckKey(string sql)
        {
            SqlDataAdapter dap = new SqlDataAdapter(sql, con);
            DataTable table = new DataTable();
            dap.Fill(table);
            if (table.Rows.Count > 0)
                return true;
            else return false;
        }
    }
}
