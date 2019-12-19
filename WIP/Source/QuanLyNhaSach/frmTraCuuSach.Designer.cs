namespace QuanLyNhaSach
{
    partial class frmTraCuuSach
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
            this.btnHienThi = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.Luoi = new System.Windows.Forms.DataGridView();
            this.CheckBoxTacGia = new System.Windows.Forms.CheckBox();
            this.CheckBoxTheLoai = new System.Windows.Forms.CheckBox();
            this.CheckBoxTenSach = new System.Windows.Forms.CheckBox();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.texBoxTenSach = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.textBoxTheLoai = new System.Windows.Forms.TextBox();
            this.textBoxTacGia = new System.Windows.Forms.TextBox();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.Label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Luoi)).BeginInit();
            this.GroupBox1.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnHienThi
            // 
            this.btnHienThi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHienThi.Location = new System.Drawing.Point(632, 139);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(119, 36);
            this.btnHienThi.TabIndex = 26;
            this.btnHienThi.Text = "Hiển thị tất cả";
            this.btnHienThi.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(650, 490);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(110, 36);
            this.btnThoat.TabIndex = 24;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Soluongton";
            this.Column5.HeaderText = "Số lượng tồn";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "Tacgia";
            this.Column4.HeaderText = "Tác giả";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "Theloai";
            this.Column3.HeaderText = "Thể loại";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "Tensach";
            this.Column2.HeaderText = "Tên sách";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Masach";
            this.Column1.HeaderText = "Mã sách";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Location = new System.Drawing.Point(455, 139);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(115, 36);
            this.btnTimKiem.TabIndex = 25;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // Luoi
            // 
            this.Luoi.AllowUserToAddRows = false;
            this.Luoi.AllowUserToDeleteRows = false;
            this.Luoi.BackgroundColor = System.Drawing.Color.Gray;
            this.Luoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Luoi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.Luoi.GridColor = System.Drawing.Color.White;
            this.Luoi.Location = new System.Drawing.Point(22, 181);
            this.Luoi.Name = "Luoi";
            this.Luoi.ReadOnly = true;
            this.Luoi.Size = new System.Drawing.Size(738, 303);
            this.Luoi.TabIndex = 23;
            // 
            // CheckBoxTacGia
            // 
            this.CheckBoxTacGia.AutoSize = true;
            this.CheckBoxTacGia.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBoxTacGia.Location = new System.Drawing.Point(184, 20);
            this.CheckBoxTacGia.Name = "CheckBoxTacGia";
            this.CheckBoxTacGia.Size = new System.Drawing.Size(90, 23);
            this.CheckBoxTacGia.TabIndex = 2;
            this.CheckBoxTacGia.Text = "TÁC GIẢ";
            this.CheckBoxTacGia.UseVisualStyleBackColor = true;
            // 
            // CheckBoxTheLoai
            // 
            this.CheckBoxTheLoai.AutoSize = true;
            this.CheckBoxTheLoai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBoxTheLoai.Location = new System.Drawing.Point(22, 53);
            this.CheckBoxTheLoai.Name = "CheckBoxTheLoai";
            this.CheckBoxTheLoai.Size = new System.Drawing.Size(98, 23);
            this.CheckBoxTheLoai.TabIndex = 1;
            this.CheckBoxTheLoai.Text = "THỂ LOẠI";
            this.CheckBoxTheLoai.UseVisualStyleBackColor = true;
            // 
            // CheckBoxTenSach
            // 
            this.CheckBoxTenSach.AutoSize = true;
            this.CheckBoxTenSach.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBoxTenSach.Location = new System.Drawing.Point(22, 25);
            this.CheckBoxTenSach.Name = "CheckBoxTenSach";
            this.CheckBoxTenSach.Size = new System.Drawing.Size(104, 23);
            this.CheckBoxTenSach.TabIndex = 0;
            this.CheckBoxTenSach.Text = "TÊN SÁCH";
            this.CheckBoxTenSach.UseVisualStyleBackColor = true;
            // 
            // GroupBox1
            // 
            this.GroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Controls.Add(this.Label4);
            this.GroupBox1.Controls.Add(this.texBoxTenSach);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.textBoxTheLoai);
            this.GroupBox1.Controls.Add(this.textBoxTacGia);
            this.GroupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GroupBox1.Location = new System.Drawing.Point(22, 44);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(427, 89);
            this.GroupBox1.TabIndex = 21;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Thông tin tìm kiếm";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(6, 24);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(85, 19);
            this.Label1.TabIndex = 11;
            this.Label1.Text = "TÊN SÁCH";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(227, 24);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(71, 19);
            this.Label4.TabIndex = 13;
            this.Label4.Text = "TÁC GIẢ";
            // 
            // texBoxTenSach
            // 
            this.texBoxTenSach.BackColor = System.Drawing.Color.White;
            this.texBoxTenSach.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texBoxTenSach.ForeColor = System.Drawing.Color.Black;
            this.texBoxTenSach.Location = new System.Drawing.Point(101, 20);
            this.texBoxTenSach.Name = "texBoxTenSach";
            this.texBoxTenSach.Size = new System.Drawing.Size(100, 26);
            this.texBoxTenSach.TabIndex = 7;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(6, 57);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(79, 19);
            this.Label2.TabIndex = 12;
            this.Label2.Text = "THỂ LOẠI";
            // 
            // textBoxTheLoai
            // 
            this.textBoxTheLoai.BackColor = System.Drawing.Color.White;
            this.textBoxTheLoai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTheLoai.ForeColor = System.Drawing.Color.Black;
            this.textBoxTheLoai.Location = new System.Drawing.Point(101, 57);
            this.textBoxTheLoai.Name = "textBoxTheLoai";
            this.textBoxTheLoai.Size = new System.Drawing.Size(100, 26);
            this.textBoxTheLoai.TabIndex = 8;
            // 
            // textBoxTacGia
            // 
            this.textBoxTacGia.BackColor = System.Drawing.Color.White;
            this.textBoxTacGia.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTacGia.ForeColor = System.Drawing.Color.Black;
            this.textBoxTacGia.Location = new System.Drawing.Point(304, 20);
            this.textBoxTacGia.Name = "textBoxTacGia";
            this.textBoxTacGia.Size = new System.Drawing.Size(100, 26);
            this.textBoxTacGia.TabIndex = 9;
            // 
            // GroupBox2
            // 
            this.GroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.GroupBox2.Controls.Add(this.CheckBoxTacGia);
            this.GroupBox2.Controls.Add(this.CheckBoxTheLoai);
            this.GroupBox2.Controls.Add(this.CheckBoxTenSach);
            this.GroupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GroupBox2.Location = new System.Drawing.Point(455, 44);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(296, 89);
            this.GroupBox2.TabIndex = 22;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Tìm kiếm theo";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label3.Location = new System.Drawing.Point(302, 9);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(211, 31);
            this.Label3.TabIndex = 20;
            this.Label3.Text = "TRA CỨU SÁCH";
            // 
            // TraCuuSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 536);
            this.Controls.Add(this.btnHienThi);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.Luoi);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.Label3);
            this.Name = "TraCuuSach";
            this.Text = "TraCuuSach";
            ((System.ComponentModel.ISupportInitialize)(this.Luoi)).EndInit();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnHienThi;
        internal System.Windows.Forms.Button btnThoat;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        internal System.Windows.Forms.Button btnTimKiem;
        internal System.Windows.Forms.DataGridView Luoi;
        internal System.Windows.Forms.CheckBox CheckBoxTacGia;
        internal System.Windows.Forms.CheckBox CheckBoxTheLoai;
        internal System.Windows.Forms.CheckBox CheckBoxTenSach;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox texBoxTenSach;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox textBoxTheLoai;
        internal System.Windows.Forms.TextBox textBoxTacGia;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.Label Label3;
    }
}