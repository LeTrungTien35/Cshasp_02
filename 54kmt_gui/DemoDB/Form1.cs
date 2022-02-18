using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient; //form này là 1 client, nên cần dùng thư viện này
namespace DemoDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = false;
            TimKiem("%" + textBox1.Text + "%");
        }

        void TimKiem(string search)
        {
            //1.kết nối
            string chuoiKN = "Server=Admin\\SQLEXPRESS;Database=K54KMT;User Id=sa;Password=11223344;";
            SqlConnection cn = new SqlConnection(chuoiKN);
            cn.Open(); //kết nối

            //2.sql show thị
            string sql = "select * from SV where ho+' '+ten like @search";
            //string sql = "select * from SV where (ho+' '+ten) like N'%" + textBox1.Text + "%'";
            //sql chứa biến, tên biến tùy ý, trước biến có @
            //ở ví dụ này có biến @search

            //3. thực thi sql -> dataTable
            SqlCommand cm = new SqlCommand(sql, cn); //đối tượng sẽ thực thi sql, trên kết nối cn
            //truyền giá trị cho biến @search trong sql
            cm.Parameters.Add("@search", SqlDbType.NVarChar, 50).Value = search;

            SqlDataReader dr = cm.ExecuteReader();//thực thi sql, trả về trong đối tượng dr
            DataTable dt = new DataTable(); //dt nơi chứa dữ liệu
            dt.Load(dr);  //load hết dữ liệu đã lấy được

            //4. đưa kq (dataTable) ra lưới (dataGridView1) để hiển thị
            dataGridView1.DataSource = dt;
        }

        private void cmdUpdate_Click(object sender, EventArgs e)
        {
            //1.kết nối
            string chuoiKN = "Server=Admin\\SQLEXPRESS;Database=K54KMT;User Id=sa;Password=11223344;";
            SqlConnection cn = new SqlConnection(chuoiKN);
            cn.Open(); //kết nối
            //2.sql tác động thay đổi dữ liệu
            string sql = "update sv set dihoc=dihoc+7 where (ho+' '+ten) like @search";

            //3. thực thi sql -> dataTable
            SqlCommand cm = new SqlCommand(sql, cn); //đối tượng sẽ thực thi sql, trên kết nối cn
            cm.Parameters.Add("@search", SqlDbType.NVarChar, 50).Value = "%" + textBox1.Text + "%";
            int n = cm.ExecuteNonQuery();
            MessageBox.Show("Số bản ghi bị tác động = " + n);
        }

        private void cmdPrint_Click(object sender, EventArgs e)
        {
            //print kq 1 lệnh SQL SELECT -> paper: máy in (PDF), máy in thật (canon,...)
            //b0. chuẩn bị công cụ là máy in đã sẵn sàng
            //b1. thực thi sql để có dữ liệu
            //b2. chuyển toàn bộ dữ liệu cần print ra HTML
            //b3. đẩy vào đối tượng WebBrowser (buildin)
            //b4. gọi phương thức: print_review: cho xem trước+chọn khổ giấy, chiều dọc|ngang,..: rồi mới print
            //    hoặc print (in ngay)

            //b1 gồm 3 step con, (copy nút tìm kiếm sang)
            //s1.kết nối db
            string chuoiKN = "Server=Admin\\SQLEXPRESS;Database=K54KMT;User Id=sa;Password=11223344;";
            SqlConnection cn = new SqlConnection(chuoiKN);
            cn.Open(); //kết nối

            //s2.sql show thị
            string sql = "select [masv],[ho] as [Họ đệm],[ten] as [Tên],isnull([malop],'&nbsp;') [Mã lớp],[tenlop] as [Tên lớp],isnull(cast([dihoc] as varchar),'&nbsp;') [Số buổi Đi học],case when [GT]=1 then 'NAM' else N'Nữ' end as [Giới tính] from SV where ho+' '+ten like @search";
            //sql chứa biến, tên biến tùy ý, trước biến có @
            //ở ví dụ này có biến @search

            //s3. thực thi sql -> dataTable
            SqlCommand cm = new SqlCommand(sql, cn); //đối tượng sẽ thực thi sql, trên kết nối cn
            //truyền giá trị cho biến @search trong sql
            cm.Parameters.Add("@search", SqlDbType.NVarChar, 50).Value = "%" + textBox1.Text + "%";

            SqlDataReader dr = cm.ExecuteReader();//thực thi sql, trả về trong đối tượng dr
            DataTable dt = new DataTable(); //dt nơi chứa dữ liệu
            dt.Load(dr);  //load hết dữ liệu đã lấy được

            //b2 chuyển dữ liệu trong dt -> biến chuỗi dạng HTML
            string html = "<html><head><style>thead {display: table-header-group;} .ct{text-align:center} td, th {border: 1px solid black; padding:10px }table {border-collapse: collapse;}</style></head><body>";
            string image_data = Properties.Resources.image_data;
            //html += "<h1><img src='" + image_data + "' align='center'>Danh sách sv lớp 54KMT</h1>";
            //ghép chuỗi tạo thành nội dung muốn PRINT: HTML,CSS,JS tùy ý, thỏa sức sáng tạo

            html += "<table border=1 width='100%'>";
            html += "<thead><tr><th>STT</th>";
            foreach (DataColumn c in dt.Columns)
            {
                html += string.Format("<th>{0}</th>", c.ColumnName);
            }
            html += "</tr></thead><tbody>";

            int stt = 0;
            foreach (DataRow r in dt.Rows)
            {
                html += "<tr><td class='ct'>" + (++stt) + "</td>";
                foreach (DataColumn c in dt.Columns)
                {
                    if (c.ColumnName == "Số buổi Đi học")
                    {
                        html += string.Format("<td class='ct'>{0}</td>", r[c.ColumnName]);
                    }else
                    html += string.Format("<td>{0}</td>", r[c.ColumnName]);
                }
                html += "</tr>";
            }

            html += "<tbody></table></body></html>";

            webBrowser1.DocumentText = html;
            //webBrowser1.ShowPrintPreviewDialog(); //show ngay để in: khong đc
            webBrowser1.Visible = true;

        }

        private void cmdPrintReview_Click(object sender, EventArgs e)
        {
            webBrowser1.ShowPrintPreviewDialog();
        }
    }
}
