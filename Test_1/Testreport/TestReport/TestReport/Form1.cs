using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;
namespace TestReport
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection
                (@"Data Source=DESKTOP-7KJ5F4U\SQLEXPRESS;Initial Catalog=QuanLyKTX;Integrated Security=True");
            SqlDataAdapter dap = new SqlDataAdapter("select * from NhanVien", conn);

            DataSet ds = new DataSet();
            dap.Fill(ds, "con cac");

            this.reportViewer1.LocalReport.ReportEmbeddedResource =
                "TestReport.Report1.rdlc";

            ReportDataSource rds = new ReportDataSource();
            rds.Name = "DataSet1";
            rds.Value = ds.Tables[0];
            reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
        }
    }
}
