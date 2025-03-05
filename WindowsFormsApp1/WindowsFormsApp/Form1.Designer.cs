namespace WindowsFormsApp1
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
            this.lbdstrieuchung = new System.Windows.Forms.ListBox();
            this.lbtrieuchung = new System.Windows.Forms.ListBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnXoaall = new System.Windows.Forms.Button();
            this.lbchuandoan = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbdstrieuchung
            // 
            this.lbdstrieuchung.FormattingEnabled = true;
            this.lbdstrieuchung.ItemHeight = 16;
            this.lbdstrieuchung.Location = new System.Drawing.Point(47, 36);
            this.lbdstrieuchung.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbdstrieuchung.Name = "lbdstrieuchung";
            this.lbdstrieuchung.Size = new System.Drawing.Size(483, 244);
            this.lbdstrieuchung.TabIndex = 1;
            this.lbdstrieuchung.SelectedIndexChanged += new System.EventHandler(this.lbdstrieuchung_SelectedIndexChanged);
            this.lbdstrieuchung.SelectedValueChanged += new System.EventHandler(this.dstc);
            // 
            // lbtrieuchung
            // 
            this.lbtrieuchung.FormattingEnabled = true;
            this.lbtrieuchung.ItemHeight = 16;
            this.lbtrieuchung.Location = new System.Drawing.Point(657, 36);
            this.lbtrieuchung.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbtrieuchung.Name = "lbtrieuchung";
            this.lbtrieuchung.Size = new System.Drawing.Size(273, 244);
            this.lbtrieuchung.TabIndex = 2;
            this.lbtrieuchung.SelectedIndexChanged += new System.EventHandler(this.clicktrieuchung);
            // 
            // btnThem
            // 
            this.btnThem.Enabled = false;
            this.btnThem.Location = new System.Drawing.Point(551, 36);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(97, 65);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Enabled = false;
            this.btnXoa.Location = new System.Drawing.Point(953, 36);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(97, 65);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnXoaall
            // 
            this.btnXoaall.Enabled = false;
            this.btnXoaall.Location = new System.Drawing.Point(953, 108);
            this.btnXoaall.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXoaall.Name = "btnXoaall";
            this.btnXoaall.Size = new System.Drawing.Size(97, 65);
            this.btnXoaall.TabIndex = 4;
            this.btnXoaall.Text = "Xóa tất cả";
            this.btnXoaall.UseVisualStyleBackColor = true;
            this.btnXoaall.Click += new System.EventHandler(this.button3_Click);
            // 
            // lbchuandoan
            // 
            this.lbchuandoan.FormattingEnabled = true;
            this.lbchuandoan.ItemHeight = 16;
            this.lbchuandoan.Location = new System.Drawing.Point(47, 369);
            this.lbchuandoan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbchuandoan.Name = "lbchuandoan";
            this.lbchuandoan.Size = new System.Drawing.Size(483, 196);
            this.lbchuandoan.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(47, 288);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 74);
            this.button1.TabIndex = 6;
            this.button1.Text = "Chuẩn đoán";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(371, 590);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nhóm 4 Chuẩn đoán bệnh về phổi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Các triệu chứng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(547, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Các triệu chứng đã chọn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 624);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbchuandoan);
            this.Controls.Add(this.btnXoaall);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.lbtrieuchung);
            this.Controls.Add(this.lbdstrieuchung);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chuẩn đoán bệnh phổi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbdstrieuchung;
        private System.Windows.Forms.ListBox lbtrieuchung;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnXoaall;
        private System.Windows.Forms.ListBox lbchuandoan;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

