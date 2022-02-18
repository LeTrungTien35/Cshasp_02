namespace AppXemGioTG
{
    partial class Form2
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.NutChonMau = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.Folder = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.font = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 204);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(569, 73);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Anh Yêu Em Nhất Quả Đất Này";
            // 
            // NutChonMau
            // 
            this.NutChonMau.Location = new System.Drawing.Point(12, 23);
            this.NutChonMau.Name = "NutChonMau";
            this.NutChonMau.Size = new System.Drawing.Size(121, 42);
            this.NutChonMau.TabIndex = 1;
            this.NutChonMau.Text = "Chọn màu nền\r\n";
            this.NutChonMau.UseVisualStyleBackColor = true;
            this.NutChonMau.Click += new System.EventHandler(this.NutChonMau_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(152, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 42);
            this.button1.TabIndex = 2;
            this.button1.Text = "Chọn màu chữ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Folder
            // 
            this.Folder.Location = new System.Drawing.Point(292, 23);
            this.Folder.Name = "Folder";
            this.Folder.Size = new System.Drawing.Size(121, 42);
            this.Folder.TabIndex = 3;
            this.Folder.Text = "Folder";
            this.Folder.UseVisualStyleBackColor = true;
            this.Folder.Click += new System.EventHandler(this.Folder_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(12, 292);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(569, 30);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "Chọn Đường Dẫn";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(438, 23);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 42);
            this.button2.TabIndex = 5;
            this.button2.Text = "Gọi Form 3";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // font
            // 
            this.font.Location = new System.Drawing.Point(12, 93);
            this.font.Name = "font";
            this.font.Size = new System.Drawing.Size(121, 42);
            this.font.TabIndex = 6;
            this.font.Text = "Chọn font";
            this.font.UseVisualStyleBackColor = true;
            this.font.Click += new System.EventHandler(this.font_Click);
            // 
            // fontDialog1
            // 
            this.fontDialog1.FontMustExist = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 334);
            this.Controls.Add(this.font);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Folder);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.NutChonMau);
            this.Controls.Add(this.textBox1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button NutChonMau;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button Folder;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button font;
        private System.Windows.Forms.FontDialog fontDialog1;
    }
}