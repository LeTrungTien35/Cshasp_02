using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
namespace SV_KMT
{
    public partial class frmMain : Form
    {
        private const string DB_CONNECTION_STRING =@"Data Source=DESKTOP-7KJ5F4U\SQLEXPRESS;Initial Catalog=DanhSachSvKmt;Integrated Security=True";
        LibDB.LibSV libSV;
        public frmMain()
        {
            InitializeComponent();
            libSV = new LibDB.LibSV(DB_CONNECTION_STRING);
        }

        DataTable dtLastSearch;
        private void cmdSearch_Click(object sender, EventArgs e)
        {
            try
            {
                dgv.DataSource = dtLastSearch = libSV.Search_to_DataTable(txtSearch.Text);
            }
            catch (Exception ex)
            {
                label_msg.Text = "Search error: " + ex.Message;
            }
        }

        string printAction = "";
        private void cmdPrintReview_Click(object sender, EventArgs e)
        {
            try
            {
                printAction = "PrintReview";
                wb.DocumentText = libSV.Search_to_HTML(dtLastSearch);
            }
            catch (Exception ex)
            {
                label_msg.Text = "PrintReview error: " + ex.Message;
            }
        }

        private void cmdPrint_Click(object sender, EventArgs e)
        {
            try
            {
                printAction = "Print";
                wb.DocumentText = libSV.Search_to_HTML(dtLastSearch);
            }
            catch (Exception ex)
            {
                label_msg.Text = "Print error: " + ex.Message;
            }
        }

        private void wb_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            try
            {
                if (printAction == "PrintReview")
                    wb.ShowPrintPreviewDialog();
                else if (printAction == "Print")
                    wb.Print();
            }
            catch (Exception ex)
            {
                label_msg.Text = "wb_DocumentCompleted error: " + ex.Message;
            }
        }

        private void dgv_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            try
            {
                string ma = e.Row.Cells[0].Value.ToString();
                if (MessageBox.Show("Xác nhận muốn xóa sv mã " + ma + "?", "Confirm delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {
                    if (libSV.Delete(ma))
                    {
                        label_msg.Text = "Xóa thành công sv có mã: " + ma;
                    }
                    else
                    {
                        e.Cancel = true;
                        label_msg.Text = "Không xóa được sv có mã: " + ma;
                    }
                }
            }
            catch (Exception ex)
            {
                e.Cancel = true;
                label_msg.Text = "Delete error: " + ex.Message;
            }
        }


        private void dgv_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (row_new >= 0 && row_new == e.RowIndex + 1)
                {
                    add(e.RowIndex);
                    return;
                }
                LibDB.SV sv = CopyRowInfo(e.RowIndex);
                if (libSV.Edit(sv, old_ma_edit))
                {
                    string msg = "Vừa Cập nhật giá trị " + dgv.Columns[e.ColumnIndex].Name + ": " + dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                    label_msg.Text = msg;
                }
                else
                {
                    add(e.RowIndex);
                }
            }
            catch (Exception ex)
            {
                dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = old_value_cell;
                label_msg.Text = "Update error: " + ex.Message;
            }
        }

        string old_ma_edit = "";
        private void dgv_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            old_ma_edit = dgv.Rows[e.RowIndex].Cells[0].Value.ToString();
        }
        
        LibDB.SV CopyRowInfo(int RowIndex)
        {
            try
            {
                DataGridViewCellCollection c = dgv.Rows[RowIndex].Cells;
                return new LibDB.SV().getRow(c);
            }
            catch
            {
                return null;
            }
        }

        int row_new = -1;
        void add(int RowIndex)
        {
            try
            {
                LibDB.SV sv = CopyRowInfo(RowIndex);
                if (libSV.Add(sv))
                {
                    label_msg.Text = "Đã thêm sv thành công";
                    row_new = -1;
                }
                else
                {
                    label_msg.Text = "Có lỗi gì đó khi thêm sv";
                }
            }
            catch (Exception ex)
            {
                label_msg.Text = "Add error: " + ex.Message;
            }
        }

        private void dgv_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            if (row_new >= 0) add(row_new);
            row_new = e.Row.Index;
            add(row_new);
        }

        private void dgv_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            label_msg.Text = "Error: " + e.Exception.Message;
            dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = old_value_cell;
            e.Cancel = true;
        }
        object old_value_cell;
        private void dgv_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            old_value_cell = dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
        }
    }
}
