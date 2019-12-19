namespace QuanLyNhaSach
{
    partial class frmLapPhieuThuTien
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxSoTienThu = new System.Windows.Forms.TextBox();
            this.textBoxMaKH = new System.Windows.Forms.TextBox();
            this.textBoxNgayThuTien = new System.Windows.Forms.TextBox();
            this.textBoxMaPhieuThu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnXoaTatCaPhieu = new System.Windows.Forms.Button();
            this.btnXoaPhieu = new System.Windows.Forms.Button();
            this.btnSuaPhieu = new System.Windows.Forms.Button();
            this.btnLapPhieuThuTien = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnTraCuuKH = new System.Windows.Forms.Button();
            this.btnHienThiTatCa = new System.Windows.Forms.Button();
            this.textBoxTenKH = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(484, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phiếu Thu Tiền";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxSoTienThu);
            this.groupBox1.Controls.Add(this.textBoxMaKH);
            this.groupBox1.Controls.Add(this.textBoxNgayThuTien);
            this.groupBox1.Controls.Add(this.textBoxMaPhieuThu);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.groupBox1.Location = new System.Drawing.Point(12, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(613, 129);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phiếu thu";
            // 
            // textBoxSoTienThu
            // 
            this.textBoxSoTienThu.Location = new System.Drawing.Point(417, 83);
            this.textBoxSoTienThu.Name = "textBoxSoTienThu";
            this.textBoxSoTienThu.Size = new System.Drawing.Size(143, 26);
            this.textBoxSoTienThu.TabIndex = 7;
            // 
            // textBoxMaKH
            // 
            this.textBoxMaKH.Location = new System.Drawing.Point(417, 28);
            this.textBoxMaKH.Name = "textBoxMaKH";
            this.textBoxMaKH.Size = new System.Drawing.Size(143, 26);
            this.textBoxMaKH.TabIndex = 6;
            // 
            // textBoxNgayThuTien
            // 
            this.textBoxNgayThuTien.Location = new System.Drawing.Point(137, 83);
            this.textBoxNgayThuTien.Name = "textBoxNgayThuTien";
            this.textBoxNgayThuTien.Size = new System.Drawing.Size(143, 26);
            this.textBoxNgayThuTien.TabIndex = 5;
            // 
            // textBoxMaPhieuThu
            // 
            this.textBoxMaPhieuThu.Location = new System.Drawing.Point(137, 28);
            this.textBoxMaPhieuThu.Name = "textBoxMaPhieuThu";
            this.textBoxMaPhieuThu.Size = new System.Drawing.Size(143, 26);
            this.textBoxMaPhieuThu.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(301, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 19);
            this.label5.TabIndex = 3;
            this.label5.Text = "Số Tiền Thu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(301, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mã Khách Hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ngày Thu Tiền";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Phiếu Thu";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column5,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(12, 201);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(850, 358);
            this.dataGridView1.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã Phiếu Thu";
            this.Column1.Name = "Column1";
            this.Column1.Width = 160;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Mã Khách Hàng";
            this.Column5.Name = "Column5";
            this.Column5.Width = 160;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Họ Tên Khách Hàng";
            this.Column2.Name = "Column2";
            this.Column2.Width = 160;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Ngày Thu Tiền";
            this.Column3.Name = "Column3";
            this.Column3.Width = 160;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Số Tiền Thu";
            this.Column4.Name = "Column4";
            this.Column4.Width = 167;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnXoaTatCaPhieu);
            this.groupBox2.Controls.Add(this.btnXoaPhieu);
            this.groupBox2.Controls.Add(this.btnSuaPhieu);
            this.groupBox2.Controls.Add(this.btnLapPhieuThuTien);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.groupBox2.Location = new System.Drawing.Point(923, 191);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(149, 258);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức Năng";
            // 
            // btnXoaTatCaPhieu
            // 
            this.btnXoaTatCaPhieu.Location = new System.Drawing.Point(6, 199);
            this.btnXoaTatCaPhieu.Name = "btnXoaTatCaPhieu";
            this.btnXoaTatCaPhieu.Size = new System.Drawing.Size(135, 33);
            this.btnXoaTatCaPhieu.TabIndex = 11;
            this.btnXoaTatCaPhieu.Text = "Xóa Tất Cả";
            this.btnXoaTatCaPhieu.UseVisualStyleBackColor = true;
            // 
            // btnXoaPhieu
            // 
            this.btnXoaPhieu.Location = new System.Drawing.Point(6, 133);
            this.btnXoaPhieu.Name = "btnXoaPhieu";
            this.btnXoaPhieu.Size = new System.Drawing.Size(135, 36);
            this.btnXoaPhieu.TabIndex = 10;
            this.btnXoaPhieu.Text = "Xóa Phiếu";
            this.btnXoaPhieu.UseVisualStyleBackColor = true;
            // 
            // btnSuaPhieu
            // 
            this.btnSuaPhieu.Location = new System.Drawing.Point(6, 76);
            this.btnSuaPhieu.Name = "btnSuaPhieu";
            this.btnSuaPhieu.Size = new System.Drawing.Size(135, 33);
            this.btnSuaPhieu.TabIndex = 9;
            this.btnSuaPhieu.Text = "Sửa Phiếu";
            this.btnSuaPhieu.UseVisualStyleBackColor = true;
            // 
            // btnLapPhieuThuTien
            // 
            this.btnLapPhieuThuTien.Location = new System.Drawing.Point(6, 25);
            this.btnLapPhieuThuTien.Name = "btnLapPhieuThuTien";
            this.btnLapPhieuThuTien.Size = new System.Drawing.Size(135, 36);
            this.btnLapPhieuThuTien.TabIndex = 8;
            this.btnLapPhieuThuTien.Text = "Lập Phiếu";
            this.btnLapPhieuThuTien.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnTraCuuKH);
            this.groupBox3.Controls.Add(this.btnHienThiTatCa);
            this.groupBox3.Controls.Add(this.textBoxTenKH);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.groupBox3.Location = new System.Drawing.Point(631, 56);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(476, 129);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tra Cứu";
            // 
            // btnTraCuuKH
            // 
            this.btnTraCuuKH.Location = new System.Drawing.Point(292, 78);
            this.btnTraCuuKH.Name = "btnTraCuuKH";
            this.btnTraCuuKH.Size = new System.Drawing.Size(141, 34);
            this.btnTraCuuKH.TabIndex = 3;
            this.btnTraCuuKH.Text = "Tra Cứu";
            this.btnTraCuuKH.UseVisualStyleBackColor = true;
            // 
            // btnHienThiTatCa
            // 
            this.btnHienThiTatCa.Location = new System.Drawing.Point(73, 78);
            this.btnHienThiTatCa.Name = "btnHienThiTatCa";
            this.btnHienThiTatCa.Size = new System.Drawing.Size(136, 34);
            this.btnHienThiTatCa.TabIndex = 2;
            this.btnHienThiTatCa.Text = "Hiển Thị Tất Cả";
            this.btnHienThiTatCa.UseVisualStyleBackColor = true;
            // 
            // textBoxTenKH
            // 
            this.textBoxTenKH.Location = new System.Drawing.Point(180, 31);
            this.textBoxTenKH.Name = "textBoxTenKH";
            this.textBoxTenKH.Size = new System.Drawing.Size(252, 26);
            this.textBoxTenKH.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tên Khách Hàng";
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnLuu.Location = new System.Drawing.Point(868, 501);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(112, 38);
            this.btnLuu.TabIndex = 5;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(1004, 501);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(112, 38);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // LapPhieuThuTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 571);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "LapPhieuThuTien";
            this.Text = "LapPhieuThuTien";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxSoTienThu;
        private System.Windows.Forms.TextBox textBoxMaKH;
        private System.Windows.Forms.TextBox textBoxNgayThuTien;
        private System.Windows.Forms.TextBox textBoxMaPhieuThu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnXoaTatCaPhieu;
        private System.Windows.Forms.Button btnXoaPhieu;
        private System.Windows.Forms.Button btnSuaPhieu;
        private System.Windows.Forms.Button btnLapPhieuThuTien;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnTraCuuKH;
        private System.Windows.Forms.Button btnHienThiTatCa;
        private System.Windows.Forms.TextBox textBoxTenKH;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThoat;
    }
}