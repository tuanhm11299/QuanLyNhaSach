namespace QuanLyNhaSach
{
    partial class frmPhieuNhapSach
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
            this.tcPhieuNhapSach = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvDanhSachPhieuNhap = new System.Windows.Forms.DataGridView();
            this.btnXemPhieu = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnXoaPhieu = new System.Windows.Forms.Button();
            this.btnNhapChiTiet = new System.Windows.Forms.Button();
            this.btnLapPhieu = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.txtMaPhieuNhap = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnXemChiTiet = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnXoaCT = new System.Windows.Forms.Button();
            this.btnThemCT = new System.Windows.Forms.Button();
            this.dgvDanhSachCTPN = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtMaPN = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnChon = new System.Windows.Forms.Button();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.txtSoLuongNhap = new System.Windows.Forms.TextBox();
            this.txtMaCTPN = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tcPhieuNhapSach.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachPhieuNhap)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachCTPN)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcPhieuNhapSach
            // 
            this.tcPhieuNhapSach.Controls.Add(this.tabPage1);
            this.tcPhieuNhapSach.Controls.Add(this.tabPage2);
            this.tcPhieuNhapSach.Location = new System.Drawing.Point(13, 12);
            this.tcPhieuNhapSach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tcPhieuNhapSach.Name = "tcPhieuNhapSach";
            this.tcPhieuNhapSach.SelectedIndex = 0;
            this.tcPhieuNhapSach.Size = new System.Drawing.Size(909, 730);
            this.tcPhieuNhapSach.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvDanhSachPhieuNhap);
            this.tabPage1.Controls.Add(this.btnXemPhieu);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(901, 701);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Phiếu Nhập ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvDanhSachPhieuNhap
            // 
            this.dgvDanhSachPhieuNhap.AllowUserToAddRows = false;
            this.dgvDanhSachPhieuNhap.AllowUserToDeleteRows = false;
            this.dgvDanhSachPhieuNhap.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dgvDanhSachPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachPhieuNhap.GridColor = System.Drawing.Color.White;
            this.dgvDanhSachPhieuNhap.Location = new System.Drawing.Point(39, 345);
            this.dgvDanhSachPhieuNhap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvDanhSachPhieuNhap.Name = "dgvDanhSachPhieuNhap";
            this.dgvDanhSachPhieuNhap.ReadOnly = true;
            this.dgvDanhSachPhieuNhap.Size = new System.Drawing.Size(820, 252);
            this.dgvDanhSachPhieuNhap.TabIndex = 47;
            // 
            // btnXemPhieu
            // 
            this.btnXemPhieu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemPhieu.Location = new System.Drawing.Point(693, 614);
            this.btnXemPhieu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXemPhieu.Name = "btnXemPhieu";
            this.btnXemPhieu.Size = new System.Drawing.Size(140, 54);
            this.btnXemPhieu.TabIndex = 3;
            this.btnXemPhieu.Text = "Xem Phiếu";
            this.btnXemPhieu.UseVisualStyleBackColor = true;
            this.btnXemPhieu.Click += new System.EventHandler(this.btnXemPhieu_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnXoaPhieu);
            this.groupBox3.Controls.Add(this.btnNhapChiTiet);
            this.groupBox3.Controls.Add(this.btnLapPhieu);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.groupBox3.Location = new System.Drawing.Point(39, 198);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(820, 122);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chức Năng";
            // 
            // btnXoaPhieu
            // 
            this.btnXoaPhieu.Location = new System.Drawing.Point(341, 42);
            this.btnXoaPhieu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXoaPhieu.Name = "btnXoaPhieu";
            this.btnXoaPhieu.Size = new System.Drawing.Size(144, 54);
            this.btnXoaPhieu.TabIndex = 2;
            this.btnXoaPhieu.Text = "Xóa Phiếu";
            this.btnXoaPhieu.UseVisualStyleBackColor = true;
            this.btnXoaPhieu.Click += new System.EventHandler(this.btnXoaPhieu_Click);
            // 
            // btnNhapChiTiet
            // 
            this.btnNhapChiTiet.Location = new System.Drawing.Point(525, 42);
            this.btnNhapChiTiet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNhapChiTiet.Name = "btnNhapChiTiet";
            this.btnNhapChiTiet.Size = new System.Drawing.Size(140, 54);
            this.btnNhapChiTiet.TabIndex = 1;
            this.btnNhapChiTiet.Text = "Nhập Chi Tiết";
            this.btnNhapChiTiet.UseVisualStyleBackColor = true;
            this.btnNhapChiTiet.Click += new System.EventHandler(this.btnNhapChiTiet_Click);
            // 
            // btnLapPhieu
            // 
            this.btnLapPhieu.Location = new System.Drawing.Point(176, 42);
            this.btnLapPhieu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLapPhieu.Name = "btnLapPhieu";
            this.btnLapPhieu.Size = new System.Drawing.Size(125, 54);
            this.btnLapPhieu.TabIndex = 0;
            this.btnLapPhieu.Text = "Tạo Phiếu";
            this.btnLapPhieu.UseVisualStyleBackColor = true;
            this.btnLapPhieu.Click += new System.EventHandler(this.btnLapPhieu_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpNgayNhap);
            this.groupBox1.Controls.Add(this.txtMaPhieuNhap);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.groupBox1.Location = new System.Drawing.Point(39, 65);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(820, 126);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phiếu nhập";
            // 
            // dtpNgayNhap
            // 
            this.dtpNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayNhap.Location = new System.Drawing.Point(451, 78);
            this.dtpNgayNhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpNgayNhap.Name = "dtpNgayNhap";
            this.dtpNgayNhap.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpNgayNhap.Size = new System.Drawing.Size(132, 30);
            this.dtpNgayNhap.TabIndex = 48;
            // 
            // txtMaPhieuNhap
            // 
            this.txtMaPhieuNhap.Location = new System.Drawing.Point(451, 31);
            this.txtMaPhieuNhap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaPhieuNhap.Name = "txtMaPhieuNhap";
            this.txtMaPhieuNhap.Size = new System.Drawing.Size(132, 30);
            this.txtMaPhieuNhap.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(239, 82);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 22);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ngày Nhập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(239, 34);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã Phiếu Nhập";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(341, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Phiếu Nhập Sách";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnXemChiTiet);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.dgvDanhSachCTPN);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(901, 701);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Chi Tiết Phiếu Nhập";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnXemChiTiet
            // 
            this.btnXemChiTiet.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemChiTiet.Location = new System.Drawing.Point(700, 620);
            this.btnXemChiTiet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXemChiTiet.Name = "btnXemChiTiet";
            this.btnXemChiTiet.Size = new System.Drawing.Size(140, 54);
            this.btnXemChiTiet.TabIndex = 6;
            this.btnXemChiTiet.Text = "Xem Chi Tiết";
            this.btnXemChiTiet.UseVisualStyleBackColor = true;
            this.btnXemChiTiet.Click += new System.EventHandler(this.btnXemChiTiet_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnXoaCT);
            this.groupBox4.Controls.Add(this.btnThemCT);
            this.groupBox4.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.groupBox4.Location = new System.Drawing.Point(40, 222);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Size = new System.Drawing.Size(823, 101);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Chức Năng";
            // 
            // btnXoaCT
            // 
            this.btnXoaCT.Location = new System.Drawing.Point(449, 31);
            this.btnXoaCT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXoaCT.Name = "btnXoaCT";
            this.btnXoaCT.Size = new System.Drawing.Size(139, 54);
            this.btnXoaCT.TabIndex = 2;
            this.btnXoaCT.Text = "Xóa Chi Tiết";
            this.btnXoaCT.UseVisualStyleBackColor = true;
            this.btnXoaCT.Click += new System.EventHandler(this.btnXoaCT_Click);
            // 
            // btnThemCT
            // 
            this.btnThemCT.Location = new System.Drawing.Point(263, 31);
            this.btnThemCT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThemCT.Name = "btnThemCT";
            this.btnThemCT.Size = new System.Drawing.Size(137, 54);
            this.btnThemCT.TabIndex = 0;
            this.btnThemCT.Text = "Thêm Chi Tiết";
            this.btnThemCT.UseVisualStyleBackColor = true;
            this.btnThemCT.Click += new System.EventHandler(this.btnThemCT_Click);
            // 
            // dgvDanhSachCTPN
            // 
            this.dgvDanhSachCTPN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachCTPN.Location = new System.Drawing.Point(40, 342);
            this.dgvDanhSachCTPN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvDanhSachCTPN.Name = "dgvDanhSachCTPN";
            this.dgvDanhSachCTPN.Size = new System.Drawing.Size(823, 258);
            this.dgvDanhSachCTPN.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtMaPN);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnChon);
            this.groupBox2.Controls.Add(this.txtMaSach);
            this.groupBox2.Controls.Add(this.txtSoLuongNhap);
            this.groupBox2.Controls.Add(this.txtMaCTPN);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.groupBox2.Location = new System.Drawing.Point(40, 66);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(823, 148);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin phiếu nhập";
            // 
            // txtMaPN
            // 
            this.txtMaPN.Location = new System.Drawing.Point(243, 87);
            this.txtMaPN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaPN.Name = "txtMaPN";
            this.txtMaPN.Size = new System.Drawing.Size(156, 30);
            this.txtMaPN.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 90);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "Mã Phiếu Nhập";
            // 
            // btnChon
            // 
            this.btnChon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChon.Location = new System.Drawing.Point(673, 90);
            this.btnChon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(73, 32);
            this.btnChon.TabIndex = 7;
            this.btnChon.Text = ">";
            this.btnChon.UseVisualStyleBackColor = true;
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // txtMaSach
            // 
            this.txtMaSach.Location = new System.Drawing.Point(509, 90);
            this.txtMaSach.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Size = new System.Drawing.Size(155, 30);
            this.txtMaSach.TabIndex = 6;
            // 
            // txtSoLuongNhap
            // 
            this.txtSoLuongNhap.Location = new System.Drawing.Point(577, 41);
            this.txtSoLuongNhap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSoLuongNhap.Name = "txtSoLuongNhap";
            this.txtSoLuongNhap.Size = new System.Drawing.Size(169, 30);
            this.txtSoLuongNhap.TabIndex = 5;
            // 
            // txtMaCTPN
            // 
            this.txtMaCTPN.Location = new System.Drawing.Point(243, 38);
            this.txtMaCTPN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaCTPN.Name = "txtMaCTPN";
            this.txtMaCTPN.Size = new System.Drawing.Size(156, 30);
            this.txtMaCTPN.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(417, 94);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 22);
            this.label10.TabIndex = 2;
            this.label10.Text = "Mã Sách";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(419, 44);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 22);
            this.label9.TabIndex = 1;
            this.label9.Text = "Số Lượng Nhập";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(72, 41);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(162, 22);
            this.label8.TabIndex = 0;
            this.label8.Text = "Mã CT Phiếu Nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(321, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(272, 34);
            this.label2.TabIndex = 2;
            this.label2.Text = "Chi Tiết Phiếu Nhập";
            // 
            // frmPhieuNhapSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 750);
            this.Controls.Add(this.tcPhieuNhapSach);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmPhieuNhapSach";
            this.Text = "Phiếu Nhập Sách";
            this.Load += new System.EventHandler(this.frmPhieuNhapSach_Load);
            this.tcPhieuNhapSach.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachPhieuNhap)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachCTPN)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcPhieuNhapSach;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnXemPhieu;
        private System.Windows.Forms.Button btnXoaPhieu;
        private System.Windows.Forms.Button btnNhapChiTiet;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMaPhieuNhap;
        private System.Windows.Forms.Button btnLapPhieu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnXoaCT;
        private System.Windows.Forms.Button btnThemCT;
        private System.Windows.Forms.DataGridView dgvDanhSachCTPN;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.TextBox txtSoLuongNhap;
        private System.Windows.Forms.TextBox txtMaCTPN;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaPN;
        private System.Windows.Forms.Label label5;
        internal System.Windows.Forms.DataGridView dgvDanhSachPhieuNhap;
        private System.Windows.Forms.Button btnXemChiTiet;
        private System.Windows.Forms.DateTimePicker dtpNgayNhap;
    }
}