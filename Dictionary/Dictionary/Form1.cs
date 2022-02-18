using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Dictionary
{
    public partial class Form1 : Form
    {
        LibDictionary.DicEnVi myDic;
        public Form1()
        {
            InitializeComponent();
            cboDic.SelectedIndex = 0;
        }

        private void cmdLoadDic_Click(object sender, EventArgs e)
        {
            myDic = new LibDictionary.DicEnVi(Application.StartupPath + "\\" + cboDic.Text + ".txt");
            myDic.LoadDic();
            showDicToList();
        }
        void showDicToList()
        {
            if (myDic == null) return;
            lstWordsDic.Items.Clear();
            foreach (string en in myDic.En)
                lstWordsDic.Items.Add(en);
            labelDicResult.Text = "Từ điển có " + lstWordsDic.Items.Count + " từ";
            tabControl1.Enabled = true; //cho phép tương tác
        }

        private void lstWordsDic_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (myDic == null) return;
            txtSearch.Text = lstWordsDic.Text;
            cmdEn2Vi_Click(sender, null);
        }

        private void cmdEn2Vi_Click(object sender, EventArgs e)
        {
            if (myDic == null) return;
            Dictionary<string, string> search = myDic.FindStartEn(txtSearch.Text);
            string result = "";
            foreach (var kq in search)
            {
                result += string.Format("{0}: {1}\r\n", kq.Key, kq.Value);
            }
            txtResultSearch.Text = result;
        }

        private void cmdVi2En_Click(object sender, EventArgs e)
        {
            if (myDic == null) return;
            Dictionary<string, string> search = myDic.FindContainVi(txtSearch.Text);
            string result = "";
            foreach (var kq in search)
            {
                result += string.Format("{0}: {1}\r\n", kq.Key, kq.Value);
            }
            txtResultSearch.Text = result;
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            if (myDic == null) return;
            string en = txtAddEn.Text;
            string vi = txtAddVi.Text;
            bool ok = myDic.AddDic(txtAddEn.Text, txtAddVi.Text);
            if (ok)
            {
                labelResultAdd.Text = "Kết quả: Đã thêm thành công vào từ điển";
                lstWordsDic.Items.Add(txtAddEn.Text);
            }
            else
            {
                string old_vi = myDic.Search(en);
                labelResultAdd.Text = string.Format("Kết quả: Từ này đã có trong từ điển.\r\n{0}: {1}", en, old_vi);
            }

        }

        private void cmdSaveDic_Click(object sender, EventArgs e)
        {
            myDic.SaveDic();
            labelDicResult.Text = "Đã cập nhật từ điển";
        }

        private void cmdUpdate_Click(object sender, EventArgs e)
        {
            string oldEn = txtOldEn.Text;
            string newVi = txtNewVi.Text;
            string oldVi = myDic.Search(oldEn);
            bool ok = myDic.UpdateDic(oldEn, newVi);
            if (ok)
            {
                labelResultUpdate.Text = string.Format("Kết quả: Đã cập nhật từ điển.\r\nTừ cũ: {0} => {1}\r\nCập nhật: {0} => {2}", oldEn, oldVi, newVi);
            }
            else
            {
                labelResultUpdate.Text = string.Format("Kết quả: Từ '{0}' không có trong từ điển.", oldEn);
            }
        }

        private void cmdDelete_Click(object sender, EventArgs e)
        {
            string en = txtDeleteEn.Text;
            bool ok = myDic.DeleteDic(en);
            if (ok)
            {
                labelResultDelete.Text = "Kết quả: Đã xóa từ khỏi từ điển";
                lstWordsDic.Items.Remove(en);
            }
            else
            {
                labelResultDelete.Text = string.Format("Kết quả: Từ '{0}' không có trong từ điển.", en);
            }
        }

        private void tabPage5_Enter(object sender, EventArgs e)
        {
            wb.DocumentText = Properties.Resources.about;
        }

        private void lstWordsDic_Click(object sender, EventArgs e)
        {
            txtSearch.Text = lstWordsDic.Text;
        }
    }
}
