using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.Data.SqlClient; // thư viện hỗ trợ sql

namespace Stanford.DataBaselib
{
    public class DataBase
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
    }
}
