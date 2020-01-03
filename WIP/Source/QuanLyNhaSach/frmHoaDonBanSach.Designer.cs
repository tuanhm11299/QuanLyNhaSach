namespace QuanLyNhaSach
{
    partial class frmHoaDonBanSach
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnXemHD = new System.Windows.Forms.Button();
            this.dgvDanhSachChiTietHoaDon = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnXemCT = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnXoaCT = new System.Windows.Forms.Button();
            this.btnThemCT = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtMaCTHD = new System.Windows.Forms.TextBox();
            this.maCTHD = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.btnChon3 = new System.Windows.Forms.Button();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.txtĐonGia = new System.Windows.Forms.TextBox();
            this.txtMaHD1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tcHoaDon = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvDanhSachHoaDon = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnNhapChiTiet = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLapPhieu = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpNgayLap = new System.Windows.Forms.DateTimePicker();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.btnChon = new System.Windows.Forms.Button();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachChiTietHoaDon)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tcHoaDon.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachHoaDon)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(204, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chi Tiết Hóa Đơn";
            // 
            // btnXemHD
            // 
            this.btnXemHD.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnXemHD.Location = new System.Drawing.Point(472, 475);
            this.btnXemHD.Name = "btnXemHD";
            this.btnXemHD.Size = new System.Drawing.Size(110, 37);
            this.btnXemHD.TabIndex = 4;
            this.btnXemHD.Text = "Xem Hóa Đơn";
            this.btnXemHD.UseVisualStyleBackColor = true;
            this.btnXemHD.Click += new System.EventHandler(this.btnXemHD_Click);
            // 
            // dgvDanhSachChiTietHoaDon
            // 
            this.dgvDanhSachChiTietHoaDon.AllowUserToAddRows = false;
            this.dgvDanhSachChiTietHoaDon.AllowUserToDeleteRows = false;
            this.dgvDanhSachChiTietHoaDon.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dgvDanhSachChiTietHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachChiTietHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column11,
            this.Column8,
            this.Column9});
            this.dgvDanhSachChiTietHoaDon.GridColor = System.Drawing.Color.White;
            this.dgvDanhSachChiTietHoaDon.Location = new System.Drawing.Point(6, 256);
            this.dgvDanhSachChiTietHoaDon.Name = "dgvDanhSachChiTietHoaDon";
            this.dgvDanhSachChiTietHoaDon.ReadOnly = true;
            this.dgvDanhSachChiTietHoaDon.Size = new System.Drawing.Size(580, 208);
            this.dgvDanhSachChiTietHoaDon.TabIndex = 46;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Machitiethoadon";
            this.Column5.HeaderText = "Mã chi tiết hóa đơn";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Visible = false;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Mahoadon";
            this.Column6.HeaderText = "Mã hóa đơn";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 118;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Masach";
            this.Column7.HeaderText = "Mã sách";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Visible = false;
            this.Column7.Width = 70;
            // 
            // Column11
            // 
            this.Column11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column11.DataPropertyName = "Tensach";
            this.Column11.HeaderText = "Tên sách";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "Soluongban";
            this.Column8.HeaderText = "Số lượng bán";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "Dongiaban";
            this.Column9.HeaderText = "Đơn giá bán";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // btnXemCT
            // 
            this.btnXemCT.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnXemCT.Location = new System.Drawing.Point(457, 470);
            this.btnXemCT.Name = "btnXemCT";
            this.btnXemCT.Size = new System.Drawing.Size(110, 40);
            this.btnXemCT.TabIndex = 5;
            this.btnXemCT.Text = "Xem Chi Tiết";
            this.btnXemCT.UseVisualStyleBackColor = true;
            this.btnXemCT.Click += new System.EventHandler(this.btnXemCT_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnXoaCT);
            this.groupBox4.Controls.Add(this.btnThemCT);
            this.groupBox4.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.groupBox4.Location = new System.Drawing.Point(6, 171);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(445, 79);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Chức Năng";
            // 
            // btnXoaCT
            // 
            this.btnXoaCT.Location = new System.Drawing.Point(284, 25);
            this.btnXoaCT.Name = "btnXoaCT";
            this.btnXoaCT.Size = new System.Drawing.Size(115, 44);
            this.btnXoaCT.TabIndex = 2;
            this.btnXoaCT.Text = "Xóa Chi Tiết";
            this.btnXoaCT.UseVisualStyleBackColor = true;
            this.btnXoaCT.Click += new System.EventHandler(this.btnXoaCT_Click);
            // 
            // btnThemCT
            // 
            this.btnThemCT.Location = new System.Drawing.Point(97, 25);
            this.btnThemCT.Name = "btnThemCT";
            this.btnThemCT.Size = new System.Drawing.Size(111, 44);
            this.btnThemCT.TabIndex = 0;
            this.btnThemCT.Text = "Thêm Chi Tiết";
            this.btnThemCT.UseVisualStyleBackColor = true;
            this.btnThemCT.Click += new System.EventHandler(this.btnThemCT_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtMaCTHD);
            this.groupBox2.Controls.Add(this.maCTHD);
            this.groupBox2.Controls.Add(this.txtSoLuong);
            this.groupBox2.Controls.Add(this.btnChon3);
            this.groupBox2.Controls.Add(this.txtMaSach);
            this.groupBox2.Controls.Add(this.txtĐonGia);
            this.groupBox2.Controls.Add(this.txtMaHD1);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.groupBox2.Location = new System.Drawing.Point(6, 36);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(580, 129);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin hóa đơn";
            // 
            // txtMaCTHD
            // 
            this.txtMaCTHD.Location = new System.Drawing.Point(120, 94);
            this.txtMaCTHD.Name = "txtMaCTHD";
            this.txtMaCTHD.Size = new System.Drawing.Size(118, 26);
            this.txtMaCTHD.TabIndex = 10;
            // 
            // maCTHD
            // 
            this.maCTHD.AutoSize = true;
            this.maCTHD.Location = new System.Drawing.Point(2, 98);
            this.maCTHD.Name = "maCTHD";
            this.maCTHD.Size = new System.Drawing.Size(114, 19);
            this.maCTHD.TabIndex = 9;
            this.maCTHD.Text = "Mã CT Hóa Đơn";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(351, 63);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(117, 26);
            this.txtSoLuong.TabIndex = 7;
            // 
            // btnChon3
            // 
            this.btnChon3.Location = new System.Drawing.Point(475, 25);
            this.btnChon3.Name = "btnChon3";
            this.btnChon3.Size = new System.Drawing.Size(55, 25);
            this.btnChon3.TabIndex = 8;
            this.btnChon3.Text = "Chọn";
            this.btnChon3.UseVisualStyleBackColor = true;
            this.btnChon3.Click += new System.EventHandler(this.btnChon3_Click);
            // 
            // txtMaSach
            // 
            this.txtMaSach.Location = new System.Drawing.Point(352, 25);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Size = new System.Drawing.Size(117, 26);
            this.txtMaSach.TabIndex = 6;
            // 
            // txtĐonGia
            // 
            this.txtĐonGia.Location = new System.Drawing.Point(351, 95);
            this.txtĐonGia.Name = "txtĐonGia";
            this.txtĐonGia.Size = new System.Drawing.Size(118, 26);
            this.txtĐonGia.TabIndex = 5;
            // 
            // txtMaHD1
            // 
            this.txtMaHD1.Location = new System.Drawing.Point(120, 28);
            this.txtMaHD1.Name = "txtMaHD1";
            this.txtMaHD1.Size = new System.Drawing.Size(118, 26);
            this.txtMaHD1.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(265, 66);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 19);
            this.label11.TabIndex = 3;
            this.label11.Text = "Số Lượng";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(265, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 19);
            this.label10.TabIndex = 2;
            this.label10.Text = "Mã Sách";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(265, 98);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 19);
            this.label9.TabIndex = 1;
            this.label9.Text = "Đơn Giá";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 19);
            this.label8.TabIndex = 0;
            this.label8.Text = "Mã Hóa Đơn";
            // 
            // tcHoaDon
            // 
            this.tcHoaDon.Controls.Add(this.tabPage1);
            this.tcHoaDon.Controls.Add(this.tabPage2);
            this.tcHoaDon.Location = new System.Drawing.Point(12, 12);
            this.tcHoaDon.Name = "tcHoaDon";
            this.tcHoaDon.SelectedIndex = 0;
            this.tcHoaDon.Size = new System.Drawing.Size(596, 544);
            this.tcHoaDon.TabIndex = 1;
            this.tcHoaDon.Tag = "";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnXemHD);
            this.tabPage1.Controls.Add(this.dgvDanhSachHoaDon);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage1.Size = new System.Drawing.Size(588, 518);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Hóa Đơn";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvDanhSachHoaDon
            // 
            this.dgvDanhSachHoaDon.AllowUserToAddRows = false;
            this.dgvDanhSachHoaDon.AllowUserToDeleteRows = false;
            this.dgvDanhSachHoaDon.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dgvDanhSachHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachHoaDon.GridColor = System.Drawing.Color.White;
            this.dgvDanhSachHoaDon.Location = new System.Drawing.Point(6, 261);
            this.dgvDanhSachHoaDon.Name = "dgvDanhSachHoaDon";
            this.dgvDanhSachHoaDon.ReadOnly = true;
            this.dgvDanhSachHoaDon.Size = new System.Drawing.Size(572, 208);
            this.dgvDanhSachHoaDon.TabIndex = 47;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnNhapChiTiet);
            this.groupBox3.Controls.Add(this.btnXoa);
            this.groupBox3.Controls.Add(this.btnLapPhieu);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.groupBox3.Location = new System.Drawing.Point(6, 180);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(472, 80);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chức Năng";
            // 
            // btnNhapChiTiet
            // 
            this.btnNhapChiTiet.Location = new System.Drawing.Point(326, 25);
            this.btnNhapChiTiet.Name = "btnNhapChiTiet";
            this.btnNhapChiTiet.Size = new System.Drawing.Size(105, 44);
            this.btnNhapChiTiet.TabIndex = 2;
            this.btnNhapChiTiet.Text = "Nhập Chi Tiết";
            this.btnNhapChiTiet.UseVisualStyleBackColor = true;
            this.btnNhapChiTiet.Click += new System.EventHandler(this.btnNhapChiTiet_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(181, 25);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(105, 44);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xóa Hóa Đơn";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLapPhieu
            // 
            this.btnLapPhieu.Location = new System.Drawing.Point(51, 25);
            this.btnLapPhieu.Name = "btnLapPhieu";
            this.btnLapPhieu.Size = new System.Drawing.Size(89, 44);
            this.btnLapPhieu.TabIndex = 0;
            this.btnLapPhieu.Text = "Lập Phiếu";
            this.btnLapPhieu.UseVisualStyleBackColor = true;
            this.btnLapPhieu.Click += new System.EventHandler(this.btnLapPhieu_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpNgayLap);
            this.groupBox1.Controls.Add(this.txtTongTien);
            this.groupBox1.Controls.Add(this.btnChon);
            this.groupBox1.Controls.Add(this.txtMaKH);
            this.groupBox1.Controls.Add(this.txtMaHD);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.groupBox1.Location = new System.Drawing.Point(6, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(578, 129);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin hóa đơn";
            // 
            // dtpNgayLap
            // 
            this.dtpNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayLap.Location = new System.Drawing.Point(102, 67);
            this.dtpNgayLap.Name = "dtpNgayLap";
            this.dtpNgayLap.Size = new System.Drawing.Size(115, 26);
            this.dtpNgayLap.TabIndex = 48;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(395, 67);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(118, 26);
            this.txtTongTien.TabIndex = 9;
            // 
            // btnChon
            // 
            this.btnChon.Location = new System.Drawing.Point(519, 22);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(53, 28);
            this.btnChon.TabIndex = 10;
            this.btnChon.Text = "Chọn";
            this.btnChon.UseVisualStyleBackColor = true;
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(395, 24);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(118, 26);
            this.txtMaKH.TabIndex = 7;
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(102, 22);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(115, 26);
            this.txtMaHD.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(263, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 19);
            this.label7.TabIndex = 4;
            this.label7.Text = "Tổng Thành Tiền:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(263, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 19);
            this.label5.TabIndex = 2;
            this.label5.Text = "Mã Khách Hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ngày Lập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã Hóa Đơn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(192, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hóa Đơn Bán Sách";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnXemCT);
            this.tabPage2.Controls.Add(this.dgvDanhSachChiTietHoaDon);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage2.Size = new System.Drawing.Size(588, 518);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Chi Tiết Hóa Đơn";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // frmHoaDonBanSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 556);
            this.Controls.Add(this.tcHoaDon);
            this.Name = "frmHoaDonBanSach";
            this.Text = "HoaDonBanSach";
            this.Load += new System.EventHandler(this.frmHoaDonBanSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachChiTietHoaDon)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tcHoaDon.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachHoaDon)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnXoaCT;
        private System.Windows.Forms.Button btnThemCT;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.TextBox txtĐonGia;
        private System.Windows.Forms.TextBox txtMaHD1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnXemHD;
        private System.Windows.Forms.Button btnXemCT;
        private System.Windows.Forms.Button btnChon3;
        internal System.Windows.Forms.DataGridView dgvDanhSachChiTietHoaDon;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.TabControl tcHoaDon;
        private System.Windows.Forms.TabPage tabPage1;
        internal System.Windows.Forms.DataGridView dgvDanhSachHoaDon;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnNhapChiTiet;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLapPhieu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DateTimePicker dtpNgayLap;
        private System.Windows.Forms.Label maCTHD;
        private System.Windows.Forms.TextBox txtMaCTHD;
    }
}