using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;
namespace LibDB
{
    public class SV
    {
        public string ma, ho, ten, lop, dc, dt, em; //string cho phép lưu trữ null
        public DateTime? ns;  //datetime ko cho lưu NULL, dấu ? : cho phép lưu trữ NULL

        public void AddParam(SqlCommand cm)
        {
            cm.Parameters.Add("@ma", SqlDbType.NVarChar, 50).Value = ma;
            cm.Parameters.Add("@ho", SqlDbType.NVarChar, 50).Value = ho;
            cm.Parameters.Add("@ten", SqlDbType.NVarChar, 50).Value = ten;
            if (ns == null)
                cm.Parameters.Add("@ns", SqlDbType.Date).Value = DBNull.Value;
            else
                cm.Parameters.Add("@ns", SqlDbType.Date).Value = ns;
            cm.Parameters.Add("@lop", SqlDbType.NVarChar, 50).Value = lop;
            cm.Parameters.Add("@dc", SqlDbType.NVarChar, 500).Value = dc;
            cm.Parameters.Add("@dt", SqlDbType.NVarChar, 50).Value = dt;
            cm.Parameters.Add("@em", SqlDbType.NVarChar, 50).Value = em;
        }

        private String getString(object obj)
        {
            try
            {
                return (String)obj;
            }
            catch
            {
                return "";
            }
        }
        private DateTime? getDate(object obj)
        {
            try
            {
                return (DateTime)obj;
            }
            catch
            {
                return null;
            }
        }

        public SV getRow(DataGridViewCellCollection c)
        {
            ma = getString(c["Mã SV"].Value);
            ho = getString(c["Họ Đệm"].Value);
            ten = getString(c["Tên"].Value);
            lop = getString(c["Lớp"].Value);
            dc = getString(c["Địa chỉ"].Value);
            dt = getString(c["Điện thoại"].Value);
            em = getString(c["Email"].Value);
            ns = getDate(c["Ngày sinh"].Value);
            return this;
        }
    }
    public class LibSV
    {
        SqlServer db;   //sử dụng đối tượng db có kiể là class SqlServer định nghĩa trong cùng DLL
        /// <summary>
        /// hàm tạo của class: cùng tên class, ko có kiểu (ko có void, int , string...)
        /// </summary>
        /// <param name="strCn"></param>
        public LibSV(string strCn)
        {
            db = new SqlServer(strCn);  //khởi tạo đối tượng sẽ thao tác với database
        }

        public bool Add(SV sv)
        {
            string sql = "insert into SV(ma,ho,ten,ns,lop,dc,dt,em)values(@ma,@ho,@ten,@ns,@lop,@dc,@dt,@em)";
            using (SqlCommand cm = new SqlCommand(sql))
            {
                sv.AddParam(cm);
                return 1 == db.RunSQL(cm);
            }
        }
        public bool Edit(SV svNew, string oldMa)
        {
            string sql = "update SV set ma=@ma,ho=@ho,ten=@ten,ns=@ns,lop=@lop,dc=@dc,dt=@dt,em=@em where ma=@oldMa";
            using (SqlCommand cm = new SqlCommand(sql))
            {
                svNew.AddParam(cm);
                cm.Parameters.Add("@oldMa", SqlDbType.NVarChar, 50).Value = oldMa;
                return 1 == db.RunSQL(cm);
            }
        }
        public bool Delete(string oldMa)
        {
            string sql = "delete SV where ma=@oldMa";
            using (SqlCommand cm = new SqlCommand(sql))
            {
                cm.Parameters.Add("@oldMa", SqlDbType.NVarChar, 50).Value = oldMa;
                return 1 == db.RunSQL(cm);
            }
        }

        public DataTable Search_to_DataTable(string search)
        {
            string sql = "";
            sql += "select ma [Mã SV],ho [Họ Đệm],ten [Tên],ns [Ngày sinh],lop [Lớp],dc [Địa chỉ], dt [Điện thoại], em [Email] ";
            sql += "from SV ";
            sql += "where(ma like @q)or(ho like @q)or(ten like @q)or(ns like @q)or(lop like @q)or(dc like @q)or(dt like @q)or(em like @q)";
            using (SqlCommand cm = new SqlCommand(sql))
            {
                cm.Parameters.Add("@q", SqlDbType.NVarChar, 500).Value = "%" + search + "%";
                return db.Query(cm);
            }
        }
        public string Search_to_HTML(DataTable dt)
        {
            if (dt == null || dt.Rows.Count == 0) return "";

            string css = "";
            css += "table{border-collapse:collapse;}";
            css += "td,th{border: 1px solid black; padding:10px;}";

            css += "thead{display: table-header-group;}";
            css += "tfoot{display: table-footer-group;}";

            css += ".ct{text-align:center;} ";

            css += "tr,th,td,div{page-break-inside: avoid; white-space: nowrap;}";

            string html = "<!DOCTYPE HTML><html><head><style type='text/css'>" + css + "</style></head><body>";
            html += "<h1>REPORT</h1>";

            html += "<table width='100%'>";
            html += "<thead><tr>";
            html += "<th>STT</th>";
            foreach (DataColumn c in dt.Columns)
            {
                if (c.ColumnName == "Họ Đệm") {
                    html += "<th colspan=2>Họ và tên SV</th>";
                }
                else if (c.ColumnName == "Tên") { }
                else
                html += string.Format("<th>{0}</th>", c.ColumnName);
            }
            html += "</tr></thead>";

            html += "<tbody>";
            int stt = 0;
            foreach (DataRow r in dt.Rows)
            {
                html += "<tr>";
                html += "<td class='ct'>" + (++stt) + "</td>";
                foreach (DataColumn c in dt.Columns)
                {

                    html += string.Format("<td><div>{0}</div></td>", r[c.ColumnName]);
                }
                html += "</tr>";
            }
            html += "</tbody>";

            html += "<tfoot>";
            html += "<tr><td colspan='" + (dt.Columns.Count + 1) + "'>Code by Đỗ Duy Cốp</td></tr>";
            html += "</tfoot>";

            html += "</table>";
            html += "</body></html>";
            return html;
        }
        public string Search_to_HTML(string search)
        {
            using (DataTable dt = Search_to_DataTable(search))
            {
                return Search_to_HTML(dt);
            }
        }
    }
}
