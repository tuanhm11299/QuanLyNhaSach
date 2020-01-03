namespace QuanLyNhaSach
{
    partial class frmTraCuuKhachHang
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
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Luoi = new System.Windows.Forms.DataGridView();
            this.CheckBoxDiaChi = new System.Windows.Forms.CheckBox();
            this.CheckBoxSDT = new System.Windows.Forms.CheckBox();
            this.CheckBoxTenKH = new System.Windows.Forms.CheckBox();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.texBoxTenKH = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.texBoxSDT = new System.Windows.Forms.TextBox();
            this.textBoxDiaChi = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.Label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Luoi)).BeginInit();
            this.GroupBox2.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnHienThi
            // 
            this.btnHienThi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHienThi.Location = new System.Drawing.Point(632, 174);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(140, 36);
            this.btnHienThi.TabIndex = 27;
            this.btnHienThi.Text = "Hiển thị tất cả";
            this.btnHienThi.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(668, 518);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(105, 36);
            this.btnThoat.TabIndex = 25;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Sotienno";
            this.Column5.HeaderText = "Số tiền nợ";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "Email";
            this.Column4.HeaderText = "Email";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Dienthoai";
            this.Column6.HeaderText = "Điện thoại";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "Diachi";
            this.Column3.HeaderText = "Địa chỉ";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "Hotenkhachhang";
            this.Column2.HeaderText = "Họ tên";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "Makhachhang";
            this.Column1.HeaderText = "Mã khách hàng";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
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
            this.Column6,
            this.Column4,
            this.Column5});
            this.Luoi.GridColor = System.Drawing.Color.White;
            this.Luoi.Location = new System.Drawing.Point(42, 218);
            this.Luoi.Name = "Luoi";
            this.Luoi.ReadOnly = true;
            this.Luoi.Size = new System.Drawing.Size(730, 293);
            this.Luoi.TabIndex = 24;
            // 
            // CheckBoxDiaChi
            // 
            this.CheckBoxDiaChi.AutoSize = true;
            this.CheckBoxDiaChi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBoxDiaChi.Location = new System.Drawing.Point(212, 25);
            this.CheckBoxDiaChi.Name = "CheckBoxDiaChi";
            this.CheckBoxDiaChi.Size = new System.Drawing.Size(85, 23);
            this.CheckBoxDiaChi.TabIndex = 2;
            this.CheckBoxDiaChi.Text = "ĐỊA CHỈ";
            this.CheckBoxDiaChi.UseVisualStyleBackColor = true;
            // 
            // CheckBoxSDT
            // 
            this.CheckBoxSDT.AutoSize = true;
            this.CheckBoxSDT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBoxSDT.Location = new System.Drawing.Point(6, 53);
            this.CheckBoxSDT.Name = "CheckBoxSDT";
            this.CheckBoxSDT.Size = new System.Drawing.Size(117, 23);
            this.CheckBoxSDT.TabIndex = 1;
            this.CheckBoxSDT.Text = "ĐIỆN THOẠI";
            this.CheckBoxSDT.UseVisualStyleBackColor = true;
            // 
            // CheckBoxTenKH
            // 
            this.CheckBoxTenKH.AutoSize = true;
            this.CheckBoxTenKH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBoxTenKH.Location = new System.Drawing.Point(6, 25);
            this.CheckBoxTenKH.Name = "CheckBoxTenKH";
            this.CheckBoxTenKH.Size = new System.Drawing.Size(85, 23);
            this.CheckBoxTenKH.TabIndex = 0;
            this.CheckBoxTenKH.Text = "TÊN KH";
            this.CheckBoxTenKH.UseVisualStyleBackColor = true;
            // 
            // GroupBox2
            // 
            this.GroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.GroupBox2.Controls.Add(this.CheckBoxDiaChi);
            this.GroupBox2.Controls.Add(this.CheckBoxSDT);
            this.GroupBox2.Controls.Add(this.CheckBoxTenKH);
            this.GroupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GroupBox2.Location = new System.Drawing.Point(463, 71);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(310, 89);
            this.GroupBox2.TabIndex = 23;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Thông tin tìm kiếm";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(6, 22);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(66, 20);
            this.Label1.TabIndex = 11;
            this.Label1.Text = "TÊN KH";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(231, 22);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(69, 20);
            this.Label4.TabIndex = 13;
            this.Label4.Text = "ĐỊA CHỈ";
            // 
            // texBoxTenKH
            // 
            this.texBoxTenKH.BackColor = System.Drawing.Color.White;
            this.texBoxTenKH.ForeColor = System.Drawing.Color.Black;
            this.texBoxTenKH.Location = new System.Drawing.Point(113, 20);
            this.texBoxTenKH.Name = "texBoxTenKH";
            this.texBoxTenKH.Size = new System.Drawing.Size(100, 26);
            this.texBoxTenKH.TabIndex = 7;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(6, 57);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(101, 20);
            this.Label2.TabIndex = 12;
            this.Label2.Text = "ĐIỆN THOẠI";
            // 
            // texBoxSDT
            // 
            this.texBoxSDT.BackColor = System.Drawing.Color.White;
            this.texBoxSDT.ForeColor = System.Drawing.Color.Black;
            this.texBoxSDT.Location = new System.Drawing.Point(113, 57);
            this.texBoxSDT.Name = "texBoxSDT";
            this.texBoxSDT.Size = new System.Drawing.Size(100, 26);
            this.texBoxSDT.TabIndex = 8;
            // 
            // textBoxDiaChi
            // 
            this.textBoxDiaChi.BackColor = System.Drawing.Color.White;
            this.textBoxDiaChi.ForeColor = System.Drawing.Color.Black;
            this.textBoxDiaChi.Location = new System.Drawing.Point(306, 20);
            this.textBoxDiaChi.Name = "textBoxDiaChi";
            this.textBoxDiaChi.Size = new System.Drawing.Size(100, 26);
            this.textBoxDiaChi.TabIndex = 9;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Location = new System.Drawing.Point(463, 172);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(125, 37);
            this.btnTimKiem.TabIndex = 26;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // GroupBox1
            // 
            this.GroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Controls.Add(this.Label4);
            this.GroupBox1.Controls.Add(this.texBoxTenKH);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.texBoxSDT);
            this.GroupBox1.Controls.Add(this.textBoxDiaChi);
            this.GroupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GroupBox1.Location = new System.Drawing.Point(42, 71);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(415, 89);
            this.GroupBox1.TabIndex = 22;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Thông tin tìm kiếm";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label3.Location = new System.Drawing.Point(271, 9);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(321, 31);
            this.Label3.TabIndex = 21;
            this.Label3.Text = "TRA CỨU KHÁCH HÀNG";
            this.Label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // frmTraCuuKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 558);
            this.Controls.Add(this.btnHienThi);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.Luoi);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.Label3);
            this.Name = "frmTraCuuKhachHang";
            this.Text = "TraCuuKhachHang";
            this.Load += new System.EventHandler(this.frmTraCuuKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Luoi)).EndInit();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnHienThi;
        internal System.Windows.Forms.Button btnThoat;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        internal System.Windows.Forms.DataGridView Luoi;
        internal System.Windows.Forms.CheckBox CheckBoxDiaChi;
        internal System.Windows.Forms.CheckBox CheckBoxSDT;
        internal System.Windows.Forms.CheckBox CheckBoxTenKH;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox texBoxTenKH;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox texBoxSDT;
        internal System.Windows.Forms.TextBox textBoxDiaChi;
        internal System.Windows.Forms.Button btnTimKiem;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Label Label3;
    }
}