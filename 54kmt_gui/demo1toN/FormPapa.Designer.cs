namespace demo1toN
{
    partial class FormPapa
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtHI = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(38, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 60);
            this.button1.TabIndex = 0;
            this.button1.Text = "tạo 1 thằng trong tập N";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.makeBaby_Click);
            // 
            // txtHI
            // 
            this.txtHI.Location = new System.Drawing.Point(155, 153);
            this.txtHI.Name = "txtHI";
            this.txtHI.Size = new System.Drawing.Size(215, 22);
            this.txtHI.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(155, 197);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(222, 63);
            this.button2.TabIndex = 2;
            this.button2.Text = "TRuyền sang mọi form N";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.SendToAll_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(409, 34);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(131, 70);
            this.button3.TabIndex = 3;
            this.button3.Text = "đẻ rơi mất";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 363);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtHI);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtHI;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

