namespace QuanLyNhaSach
{
    partial class frmQuanLySach
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
            this.btnThoat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTraCuuSach = new System.Windows.Forms.Button();
            this.textBoxTraCuuTenSach = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSoLuongTon = new System.Windows.Forms.TextBox();
            this.txtTheLoai = new System.Windows.Forms.TextBox();
            this.txtTacGia = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnTaiDuLieu = new System.Windows.Forms.Button();
            this.btnXoaTrang = new System.Windows.Forms.Button();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnChon = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnKetThuc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnThoat.Location = new System.Drawing.Point(1364, 650);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(167, 54);
            this.btnThoat.TabIndex = 25;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(647, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 39);
            this.label1.TabIndex = 18;
            this.label1.Text = "Quản Lí Sách";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(16, 267);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1036, 466);
            this.dataGridView1.TabIndex = 21;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã Sách";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên Sách";
            this.Column2.Name = "Column2";
            this.Column2.Width = 180;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Tác Giả";
            this.Column3.Name = "Column3";
            this.Column3.Width = 180;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Thể Loại";
            this.Column4.Name = "Column4";
            this.Column4.Width = 180;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Số Lượng Tồn";
            this.Column5.Name = "Column5";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnTraCuuSach);
            this.groupBox2.Controls.Add(this.textBoxTraCuuTenSach);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.groupBox2.Location = new System.Drawing.Point(1060, 63);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(492, 197);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tra Cứu";
            // 
            // btnTraCuuSach
            // 
            this.btnTraCuuSach.Location = new System.Drawing.Point(139, 119);
            this.btnTraCuuSach.Margin = new System.Windows.Forms.Padding(4);
            this.btnTraCuuSach.Name = "btnTraCuuSach";
            this.btnTraCuuSach.Size = new System.Drawing.Size(152, 57);
            this.btnTraCuuSach.TabIndex = 13;
            this.btnTraCuuSach.Text = "Tra Cứu";
            this.btnTraCuuSach.UseVisualStyleBackColor = true;
            // 
            // textBoxTraCuuTenSach
            // 
            this.textBoxTraCuuTenSach.Location = new System.Drawing.Point(157, 47);
            this.textBoxTraCuuTenSach.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTraCuuTenSach.Name = "textBoxTraCuuTenSach";
            this.textBoxTraCuuTenSach.Size = new System.Drawing.Size(257, 30);
            this.textBoxTraCuuTenSach.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 50);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 22);
            this.label8.TabIndex = 0;
            this.label8.Text = "Tên Sách";
            // 
            // txtSoLuongTon
            // 
            this.txtSoLuongTon.Location = new System.Drawing.Point(747, 92);
            this.txtSoLuongTon.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoLuongTon.Name = "txtSoLuongTon";
            this.txtSoLuongTon.Size = new System.Drawing.Size(257, 30);
            this.txtSoLuongTon.TabIndex = 10;
            // 
            // txtTheLoai
            // 
            this.txtTheLoai.Location = new System.Drawing.Point(747, 41);
            this.txtTheLoai.Margin = new System.Windows.Forms.Padding(4);
            this.txtTheLoai.Name = "txtTheLoai";
            this.txtTheLoai.Size = new System.Drawing.Size(257, 30);
            this.txtTheLoai.TabIndex = 9;
            // 
            // txtTacGia
            // 
            this.txtTacGia.Location = new System.Drawing.Point(248, 144);
            this.txtTacGia.Margin = new System.Windows.Forms.Padding(4);
            this.txtTacGia.Name = "txtTacGia";
            this.txtTacGia.Size = new System.Drawing.Size(257, 30);
            this.txtTacGia.TabIndex = 8;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnTaiDuLieu);
            this.groupBox3.Controls.Add(this.btnXoaTrang);
            this.groupBox3.Controls.Add(this.btnShowAll);
            this.groupBox3.Controls.Add(this.btnXoa);
            this.groupBox3.Controls.Add(this.btnSua);
            this.groupBox3.Controls.Add(this.btnThem);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(1060, 267);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(247, 466);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chức Năng";
            // 
            // btnTaiDuLieu
            // 
            this.btnTaiDuLieu.Location = new System.Drawing.Point(44, 246);
            this.btnTaiDuLieu.Margin = new System.Windows.Forms.Padding(4);
            this.btnTaiDuLieu.Name = "btnTaiDuLieu";
            this.btnTaiDuLieu.Size = new System.Drawing.Size(157, 39);
            this.btnTaiDuLieu.TabIndex = 3;
            this.btnTaiDuLieu.Text = "Tải dữ liệu";
            this.btnTaiDuLieu.UseVisualStyleBackColor = true;
            // 
            // btnXoaTrang
            // 
            this.btnXoaTrang.Location = new System.Drawing.Point(48, 390);
            this.btnXoaTrang.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoaTrang.Name = "btnXoaTrang";
            this.btnXoaTrang.Size = new System.Drawing.Size(153, 39);
            this.btnXoaTrang.TabIndex = 2;
            this.btnXoaTrang.Text = "Xóa trắng";
            this.btnXoaTrang.UseVisualStyleBackColor = true;
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(44, 311);
            this.btnShowAll.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(157, 39);
            this.btnShowAll.TabIndex = 3;
            this.btnShowAll.Text = "Hiển thị tất cả";
            this.btnShowAll.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(44, 176);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(157, 39);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(44, 105);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(157, 39);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(44, 36);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(157, 39);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtTenSach
            // 
            this.txtTenSach.Location = new System.Drawing.Point(248, 92);
            this.txtTenSach.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(257, 30);
            this.txtTenSach.TabIndex = 7;
            // 
            // txtMaSach
            // 
            this.txtMaSach.Location = new System.Drawing.Point(248, 41);
            this.txtMaSach.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Size = new System.Drawing.Size(257, 30);
            this.txtMaSach.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(600, 96);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 22);
            this.label6.TabIndex = 4;
            this.label6.Text = "Số Lượng Tồn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(600, 44);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 22);
            this.label5.TabIndex = 3;
            this.label5.Text = "Thể Loại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 148);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 22);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tác Giả";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 96);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên Sách";
            // 
            // btnChon
            // 
            this.btnChon.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnChon.Location = new System.Drawing.Point(1364, 513);
            this.btnChon.Margin = new System.Windows.Forms.Padding(4);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(167, 58);
            this.btnChon.TabIndex = 24;
            this.btnChon.Text = "Chọn";
            this.btnChon.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Sách";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnSave.Location = new System.Drawing.Point(1364, 395);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(167, 54);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDonGia);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtSoLuongTon);
            this.groupBox1.Controls.Add(this.txtTheLoai);
            this.groupBox1.Controls.Add(this.txtTacGia);
            this.groupBox1.Controls.Add(this.txtTenSach);
            this.groupBox1.Controls.Add(this.txtMaSach);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.groupBox1.Location = new System.Drawing.Point(16, 63);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1036, 197);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sách";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(747, 149);
            this.txtDonGia.Margin = new System.Windows.Forms.Padding(4);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(257, 30);
            this.txtDonGia.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(600, 153);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 22);
            this.label7.TabIndex = 11;
            this.label7.Text = "Đơn Giá Nhập";
            // 
            // btnKetThuc
            // 
            this.btnKetThuc.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnKetThuc.Location = new System.Drawing.Point(1364, 284);
            this.btnKetThuc.Margin = new System.Windows.Forms.Padding(4);
            this.btnKetThuc.Name = "btnKetThuc";
            this.btnKetThuc.Size = new System.Drawing.Size(167, 58);
            this.btnKetThuc.TabIndex = 26;
            this.btnKetThuc.Text = "Kết Thúc";
            this.btnKetThuc.UseVisualStyleBackColor = true;
            // 
            // frmQuanLySach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1573, 743);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnChon);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnKetThuc);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmQuanLySach";
            this.Text = "QuanLySach";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnTraCuuSach;
        private System.Windows.Forms.TextBox textBoxTraCuuTenSach;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSoLuongTon;
        private System.Windows.Forms.TextBox txtTheLoai;
        private System.Windows.Forms.TextBox txtTacGia;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnTaiDuLieu;
        private System.Windows.Forms.Button btnXoaTrang;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnKetThuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDonGia;
    }
}