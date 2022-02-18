namespace Dictionary
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lstWordsDic = new System.Windows.Forms.ListBox();
            this.cboDic = new System.Windows.Forms.ComboBox();
            this.cmdLoadDic = new System.Windows.Forms.Button();
            this.cmdSaveDic = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cmdVi2En = new System.Windows.Forms.Button();
            this.cmdEn2Vi = new System.Windows.Forms.Button();
            this.txtResultSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.labelResultAdd = new System.Windows.Forms.Label();
            this.txtAddVi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmdAdd = new System.Windows.Forms.Button();
            this.txtAddEn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.labelResultUpdate = new System.Windows.Forms.Label();
            this.txtNewVi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmdUpdate = new System.Windows.Forms.Button();
            this.txtOldEn = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.labelResultDelete = new System.Windows.Forms.Label();
            this.cmdDelete = new System.Windows.Forms.Button();
            this.txtDeleteEn = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.wb = new System.Windows.Forms.WebBrowser();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.labelDicResult = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstWordsDic
            // 
            this.lstWordsDic.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstWordsDic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstWordsDic.FormattingEnabled = true;
            this.lstWordsDic.IntegralHeight = false;
            this.lstWordsDic.ItemHeight = 16;
            this.lstWordsDic.Location = new System.Drawing.Point(5, 132);
            this.lstWordsDic.Name = "lstWordsDic";
            this.lstWordsDic.Size = new System.Drawing.Size(230, 378);
            this.lstWordsDic.TabIndex = 5;
            this.lstWordsDic.Click += new System.EventHandler(this.lstWordsDic_Click);
            this.lstWordsDic.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstWordsDic_MouseDoubleClick);
            // 
            // cboDic
            // 
            this.cboDic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboDic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDic.FormattingEnabled = true;
            this.cboDic.Items.AddRange(new object[] {
            "Anh-Viet"});
            this.cboDic.Location = new System.Drawing.Point(5, 31);
            this.cboDic.Name = "cboDic";
            this.cboDic.Size = new System.Drawing.Size(229, 24);
            this.cboDic.TabIndex = 1;
            // 
            // cmdLoadDic
            // 
            this.cmdLoadDic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLoadDic.Location = new System.Drawing.Point(3, 63);
            this.cmdLoadDic.Name = "cmdLoadDic";
            this.cmdLoadDic.Size = new System.Drawing.Size(112, 39);
            this.cmdLoadDic.TabIndex = 2;
            this.cmdLoadDic.Text = "Đọc từ điển";
            this.toolTip1.SetToolTip(this.cmdLoadDic, "Đọc từ điển từ file text");
            this.cmdLoadDic.UseVisualStyleBackColor = true;
            this.cmdLoadDic.Click += new System.EventHandler(this.cmdLoadDic_Click);
            // 
            // cmdSaveDic
            // 
            this.cmdSaveDic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdSaveDic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSaveDic.Location = new System.Drawing.Point(123, 63);
            this.cmdSaveDic.Name = "cmdSaveDic";
            this.cmdSaveDic.Size = new System.Drawing.Size(112, 39);
            this.cmdSaveDic.TabIndex = 3;
            this.cmdSaveDic.Text = "Cập nhật";
            this.toolTip1.SetToolTip(this.cmdSaveDic, "Cập nhật từ điển vào file text");
            this.cmdSaveDic.UseVisualStyleBackColor = true;
            this.cmdSaveDic.Click += new System.EventHandler(this.cmdSaveDic_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Enabled = false;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(571, 542);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cmdVi2En);
            this.tabPage1.Controls.Add(this.cmdEn2Vi);
            this.tabPage1.Controls.Add(this.txtResultSearch);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtSearch);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(563, 513);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tra cứu";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cmdVi2En
            // 
            this.cmdVi2En.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdVi2En.Location = new System.Drawing.Point(164, 63);
            this.cmdVi2En.Name = "cmdVi2En";
            this.cmdVi2En.Size = new System.Drawing.Size(149, 39);
            this.cmdVi2En.TabIndex = 3;
            this.cmdVi2En.Text = "Tra cứu Vi -> En";
            this.cmdVi2En.UseVisualStyleBackColor = true;
            this.cmdVi2En.Click += new System.EventHandler(this.cmdVi2En_Click);
            // 
            // cmdEn2Vi
            // 
            this.cmdEn2Vi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEn2Vi.Location = new System.Drawing.Point(3, 63);
            this.cmdEn2Vi.Name = "cmdEn2Vi";
            this.cmdEn2Vi.Size = new System.Drawing.Size(149, 39);
            this.cmdEn2Vi.TabIndex = 2;
            this.cmdEn2Vi.Text = "Tra cứu En -> Vi";
            this.cmdEn2Vi.UseVisualStyleBackColor = true;
            this.cmdEn2Vi.Click += new System.EventHandler(this.cmdEn2Vi_Click);
            // 
            // txtResultSearch
            // 
            this.txtResultSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResultSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultSearch.Location = new System.Drawing.Point(4, 132);
            this.txtResultSearch.Multiline = true;
            this.txtResultSearch.Name = "txtResultSearch";
            this.txtResultSearch.Size = new System.Drawing.Size(556, 377);
            this.txtResultSearch.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(2, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kết quả tra cứu:";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(4, 31);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(556, 23);
            this.txtSearch.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-1, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Từ cần tra:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.labelResultAdd);
            this.tabPage2.Controls.Add(this.txtAddVi);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.cmdAdd);
            this.tabPage2.Controls.Add(this.txtAddEn);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(563, 513);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Thêm từ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // labelResultAdd
            // 
            this.labelResultAdd.AutoSize = true;
            this.labelResultAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResultAdd.Location = new System.Drawing.Point(0, 194);
            this.labelResultAdd.Name = "labelResultAdd";
            this.labelResultAdd.Size = new System.Drawing.Size(61, 17);
            this.labelResultAdd.TabIndex = 5;
            this.labelResultAdd.Text = "Kết quả:";
            // 
            // txtAddVi
            // 
            this.txtAddVi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddVi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddVi.Location = new System.Drawing.Point(4, 90);
            this.txtAddVi.Name = "txtAddVi";
            this.txtAddVi.Size = new System.Drawing.Size(556, 23);
            this.txtAddVi.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Nghĩa của từ này:";
            // 
            // cmdAdd
            // 
            this.cmdAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAdd.Location = new System.Drawing.Point(4, 133);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(149, 39);
            this.cmdAdd.TabIndex = 4;
            this.cmdAdd.Text = "Thêm vào từ điển";
            this.cmdAdd.UseVisualStyleBackColor = true;
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
            // 
            // txtAddEn
            // 
            this.txtAddEn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddEn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddEn.Location = new System.Drawing.Point(4, 29);
            this.txtAddEn.Name = "txtAddEn";
            this.txtAddEn.Size = new System.Drawing.Size(556, 23);
            this.txtAddEn.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Từ cần thêm:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.labelResultUpdate);
            this.tabPage3.Controls.Add(this.txtNewVi);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.cmdUpdate);
            this.tabPage3.Controls.Add(this.txtOldEn);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(563, 513);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Sửa từ";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // labelResultUpdate
            // 
            this.labelResultUpdate.AutoSize = true;
            this.labelResultUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResultUpdate.Location = new System.Drawing.Point(0, 194);
            this.labelResultUpdate.Name = "labelResultUpdate";
            this.labelResultUpdate.Size = new System.Drawing.Size(61, 17);
            this.labelResultUpdate.TabIndex = 5;
            this.labelResultUpdate.Text = "Kết quả:";
            // 
            // txtNewVi
            // 
            this.txtNewVi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNewVi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewVi.Location = new System.Drawing.Point(4, 90);
            this.txtNewVi.Name = "txtNewVi";
            this.txtNewVi.Size = new System.Drawing.Size(556, 23);
            this.txtNewVi.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(0, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Nghĩa mới của từ này:";
            // 
            // cmdUpdate
            // 
            this.cmdUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdUpdate.Location = new System.Drawing.Point(4, 133);
            this.cmdUpdate.Name = "cmdUpdate";
            this.cmdUpdate.Size = new System.Drawing.Size(184, 39);
            this.cmdUpdate.TabIndex = 4;
            this.cmdUpdate.Text = "Cập nhật vào từ điển";
            this.cmdUpdate.UseVisualStyleBackColor = true;
            this.cmdUpdate.Click += new System.EventHandler(this.cmdUpdate_Click);
            // 
            // txtOldEn
            // 
            this.txtOldEn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOldEn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOldEn.Location = new System.Drawing.Point(4, 29);
            this.txtOldEn.Name = "txtOldEn";
            this.txtOldEn.Size = new System.Drawing.Size(556, 23);
            this.txtOldEn.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(0, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Từ cần sửa";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.labelResultDelete);
            this.tabPage4.Controls.Add(this.cmdDelete);
            this.tabPage4.Controls.Add(this.txtDeleteEn);
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(563, 513);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Xóa từ";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // labelResultDelete
            // 
            this.labelResultDelete.AutoSize = true;
            this.labelResultDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResultDelete.Location = new System.Drawing.Point(0, 122);
            this.labelResultDelete.Name = "labelResultDelete";
            this.labelResultDelete.Size = new System.Drawing.Size(61, 17);
            this.labelResultDelete.TabIndex = 6;
            this.labelResultDelete.Text = "Kết quả:";
            // 
            // cmdDelete
            // 
            this.cmdDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdDelete.Location = new System.Drawing.Point(3, 63);
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.Size = new System.Drawing.Size(149, 39);
            this.cmdDelete.TabIndex = 5;
            this.cmdDelete.Text = "Xóa từ";
            this.cmdDelete.UseVisualStyleBackColor = true;
            this.cmdDelete.Click += new System.EventHandler(this.cmdDelete_Click);
            // 
            // txtDeleteEn
            // 
            this.txtDeleteEn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDeleteEn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeleteEn.Location = new System.Drawing.Point(4, 31);
            this.txtDeleteEn.Name = "txtDeleteEn";
            this.txtDeleteEn.Size = new System.Drawing.Size(556, 23);
            this.txtDeleteEn.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(-1, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 17);
            this.label8.TabIndex = 3;
            this.label8.Text = "Từ cần xóa";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.wb);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(563, 513);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Tác giả";
            this.tabPage5.UseVisualStyleBackColor = true;
            this.tabPage5.Enter += new System.EventHandler(this.tabPage5_Enter);
            // 
            // wb
            // 
            this.wb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wb.IsWebBrowserContextMenuEnabled = false;
            this.wb.Location = new System.Drawing.Point(3, 3);
            this.wb.MinimumSize = new System.Drawing.Size(20, 20);
            this.wb.Name = "wb";
            this.wb.ScriptErrorsSuppressed = true;
            this.wb.ScrollBarsEnabled = false;
            this.wb.Size = new System.Drawing.Size(557, 507);
            this.wb.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabControl2);
            this.splitContainer1.Panel1MinSize = 245;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(823, 542);
            this.splitContainer1.SplitterDistance = 248;
            this.splitContainer1.TabIndex = 6;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage6);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(248, 542);
            this.tabControl2.TabIndex = 0;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.label9);
            this.tabPage6.Controls.Add(this.labelDicResult);
            this.tabPage6.Controls.Add(this.lstWordsDic);
            this.tabPage6.Controls.Add(this.cboDic);
            this.tabPage6.Controls.Add(this.cmdLoadDic);
            this.tabPage6.Controls.Add(this.cmdSaveDic);
            this.tabPage6.Location = new System.Drawing.Point(4, 25);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(240, 513);
            this.tabPage6.TabIndex = 0;
            this.tabPage6.Text = "Từ điển";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Chọn từ điển:";
            // 
            // labelDicResult
            // 
            this.labelDicResult.AutoSize = true;
            this.labelDicResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDicResult.Location = new System.Drawing.Point(2, 109);
            this.labelDicResult.Name = "labelDicResult";
            this.labelDicResult.Size = new System.Drawing.Size(109, 17);
            this.labelDicResult.TabIndex = 4;
            this.labelDicResult.Text = "Kết quả tra cứu:";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(823, 542);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Từ điển - Code by Đỗ Duy Cốp";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstWordsDic;
        private System.Windows.Forms.ComboBox cboDic;
        private System.Windows.Forms.Button cmdLoadDic;
        private System.Windows.Forms.Button cmdSaveDic;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtResultSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button cmdEn2Vi;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button cmdVi2En;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Button cmdAdd;
        private System.Windows.Forms.TextBox txtAddEn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAddVi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelResultAdd;
        private System.Windows.Forms.Label labelResultUpdate;
        private System.Windows.Forms.TextBox txtNewVi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button cmdUpdate;
        private System.Windows.Forms.TextBox txtOldEn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button cmdDelete;
        private System.Windows.Forms.TextBox txtDeleteEn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelResultDelete;
        private System.Windows.Forms.WebBrowser wb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelDicResult;
    }
}

