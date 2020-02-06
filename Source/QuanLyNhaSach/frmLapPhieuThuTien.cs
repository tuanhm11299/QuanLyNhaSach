using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhaSachBUS;
using QuanLyNhaSachDTO;

namespace QuanLyNhaSach
{
    public partial class frmLapPhieuThuTien : Form
    {
        int soTienNo, tienThu, tienNoMoi, tienThuCu, tienThuMoi, ktquydinh4;
        private PhieuThuTienBUS bus;
        private ThamSoBUS busThamSo = new ThamSoBUS();
        private QuanLyKhachHangBUS busKH = new QuanLyKhachHangBUS();
        public frmLapPhieuThuTien()
        {
            InitializeComponent();
        }

        private void frmLapPhieuThuTien_Load(object sender, EventArgs e)
        {
            bus = new PhieuThuTienBUS();
            buildDanhSach();
        }

        private void btnLapPhieuThuTien_Click(object sender, EventArgs e)
        {
            PhieuThuTienDTO obj = new PhieuThuTienDTO();
            obj.MaKH = this.textBoxMaKH.Text;
            ThamSoDTO ThamSo = new ThamSoDTO();
            ThamSo = busThamSo.QuyDinh();
            QuanLyKhachHangDTO KH = new QuanLyKhachHangDTO();
            ktquydinh4 = ThamSo.SuDungQuyDinh4;
            // sẽ viết sau
            string result;

            KH.MaKH = this.textBoxMaKH.Text;
            soTienNo = KH.SoTienNo;
            tienThu = Convert.ToInt32(this.textBoxSoTienThu.Text);
            //Kiểm tra mã khách hàng không được để trống
            if (this.textBoxMaKH.Text == string.Empty)
            {
                MessageBox.Show("Mã khách hàng không được để trống", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                obj.MaKH = this.textBoxMaKH.Text;
            }
            obj.NgayThuTien = this.dtpNgayThuTien.Text;
            obj.MaPT = this.textBoxMaPhieuThu.Text;
            obj.STT = Convert.ToInt32(this.textBoxSoTienThu.Text);
            KH = this.busKH.searchKH(KH.MaKH, KH);
            //Quy Dinh 4;
            if(ktquydinh4 == 1)
            {
                if (soTienNo < tienThu)
                {
                    MessageBox.Show("Số tiền thu lớn hơn số tiền khách hàng đang nợ", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                return;
            }
            tienNoMoi = soTienNo - tienThu;

            //obj.Email = this.textBoxEmail.Text;
            //obj.SoTienNo = Convert.ToInt32(this.textBoxSoTienNo.Text);

            result = this.bus.insert(obj);
            if (result == "0")
            {
                MessageBox.Show("Thêm phiếu thu thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            else
            {
                MessageBox.Show("Thêm phiếu thu thất bại.\n" + result, "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnHienThiTatCa_Click(object sender, EventArgs e)
        {
            buildDanhSach();
        }

        private void buildDanhSach()
        {
            List<PhieuThuTienDTO> lsObj = new List<PhieuThuTienDTO>();
            string result = this.bus.selectAll(lsObj);
            if (result != "0")
            {
                MessageBox.Show("Lỗi khi lấy danh sách phiếu thu tiền.\n" + result, "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            dgvDanhSachPhieuThu.Columns.Clear();
            dgvDanhSachPhieuThu.DataSource = null;

            dgvDanhSachPhieuThu.AutoGenerateColumns = false;
            dgvDanhSachPhieuThu.AllowUserToAddRows = false;
            dgvDanhSachPhieuThu.DataSource = lsObj;

            DataGridViewTextBoxColumn clMaPT = new DataGridViewTextBoxColumn();
            clMaPT.Name = "MaPT";
            clMaPT.HeaderText = "Mã Phiếu Thu";
            clMaPT.DataPropertyName = "MaPT";
            dgvDanhSachPhieuThu.Columns.Add(clMaPT);

            DataGridViewTextBoxColumn clSoTienThu = new DataGridViewTextBoxColumn();
            clSoTienThu.Name = "STT";
            clSoTienThu.HeaderText = "Số Tiền Thu";
            clSoTienThu.DataPropertyName = "STT";
            dgvDanhSachPhieuThu.Columns.Add(clSoTienThu);

            DataGridViewTextBoxColumn clNgayThuTien = new DataGridViewTextBoxColumn();
            clNgayThuTien.Name = "NgayThuTien";
            clNgayThuTien.HeaderText = "Ngày Thu Tiền";
            clNgayThuTien.DataPropertyName = "NgayThuTien";
            dgvDanhSachPhieuThu.Columns.Add(clNgayThuTien);

            DataGridViewTextBoxColumn clMaKH = new DataGridViewTextBoxColumn();
            clMaKH.Name = "MaKH";
            clMaKH.HeaderText = "Mã Khách Hàng";
            clMaKH.DataPropertyName = "MaKH";
            dgvDanhSachPhieuThu.Columns.Add(clMaKH);


            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dgvDanhSachPhieuThu.DataSource];
            myCurrencyManager.Refresh();
        }

        private void btnSuaPhieu_Click(object sender, EventArgs e)
        {
            int currentRowIndex = this.dgvDanhSachPhieuThu.CurrentCellAddress.Y; //'current row selected
            //Verify that indexing OK
            if (-1 < currentRowIndex && currentRowIndex < dgvDanhSachPhieuThu.RowCount)
            {
                PhieuThuTienDTO obj = (PhieuThuTienDTO)dgvDanhSachPhieuThu.Rows[currentRowIndex].DataBoundItem;
                this.textBoxMaKH.Text = obj.MaKH;
                this.textBoxMaPhieuThu.Text = obj.MaPT;
                this.textBoxSoTienThu.Text = obj.STT.ToString();
                this.dtpNgayThuTien.Text = obj.NgayThuTien;
            }
            else
            {
                MessageBox.Show("Chưa chọn phiếu thu trên lưới.", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btnXoaPhieu_Click(object sender, EventArgs e)
        {
            int currentRowIndex = this.dgvDanhSachPhieuThu.CurrentCellAddress.Y; //'current row selected
            //Verify that indexing OK
            if (-1 < currentRowIndex && currentRowIndex < dgvDanhSachPhieuThu.RowCount)
            {
                PhieuThuTienDTO obj = (PhieuThuTienDTO)dgvDanhSachPhieuThu.Rows[currentRowIndex].DataBoundItem;
                this.textBoxMaKH.Text = obj.MaKH;
                this.textBoxMaPhieuThu.Text = obj.MaPT;
                this.textBoxSoTienThu.Text = obj.STT.ToString();
                this.dtpNgayThuTien.Text = obj.NgayThuTien;
                //this.textBoxEmail.Text = obj.Email;
                //this.textBoxSoTienNo.Text = obj.SoTienNo.ToString();
                string result = this.bus.delete(obj);
                if (result == "0")
                {
                    MessageBox.Show("Xóa phiếu thu thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.buildDanhSach();
                    return;
                }
                else
                {
                    MessageBox.Show("Xóa phiếu thu thất bại.\n" + result, "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn phiếu thu trên lưới.", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btnTraCuuKH_Click(object sender, EventArgs e)
        {
            buildDanhSachMaKH();
        }

        private void buildDanhSachMaKH()
        {
            List<PhieuThuTienDTO> lsObj = new List<PhieuThuTienDTO>();
            string result = this.bus.searchMaKH(this.txtMaKH.Text, lsObj);
            if (result != "0")
            {
                MessageBox.Show("Lỗi khi lấy danh sách phiếu nhập.\n" + result, "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            dgvDanhSachPhieuThu.Columns.Clear();
            dgvDanhSachPhieuThu.DataSource = null;

            dgvDanhSachPhieuThu.AutoGenerateColumns = false;
            dgvDanhSachPhieuThu.AllowUserToAddRows = false;
            dgvDanhSachPhieuThu.DataSource = lsObj;

            DataGridViewTextBoxColumn clMaPT = new DataGridViewTextBoxColumn();
            clMaPT.Name = "MaPT";
            clMaPT.HeaderText = "Mã Phiếu Thu";
            clMaPT.DataPropertyName = "MaPT";
            dgvDanhSachPhieuThu.Columns.Add(clMaPT);

            DataGridViewTextBoxColumn clSoTienThu = new DataGridViewTextBoxColumn();
            clSoTienThu.Name = "STT";
            clSoTienThu.HeaderText = "Số Tiền Thu";
            clSoTienThu.DataPropertyName = "STT";
            dgvDanhSachPhieuThu.Columns.Add(clSoTienThu);

            DataGridViewTextBoxColumn clNgayThuTien = new DataGridViewTextBoxColumn();
            clNgayThuTien.Name = "NgayThuTien";
            clNgayThuTien.HeaderText = "Ngày Thu Tiền";
            clNgayThuTien.DataPropertyName = "NgayThuTien";
            dgvDanhSachPhieuThu.Columns.Add(clNgayThuTien);

            DataGridViewTextBoxColumn clMaKH = new DataGridViewTextBoxColumn();
            clMaKH.Name = "MaKH";
            clMaKH.HeaderText = "Mã Khách Hàng";
            clMaKH.DataPropertyName = "MaKH";
            dgvDanhSachPhieuThu.Columns.Add(clMaKH);

            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dgvDanhSachPhieuThu.DataSource];
            myCurrencyManager.Refresh();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            PhieuThuTienDTO obj = new PhieuThuTienDTO();
            obj.MaPT = this.textBoxMaPhieuThu.Text;
            //obj.STT = this.textBoxHoTenKH.Text;
            obj.NgayThuTien = this.dtpNgayThuTien.Text;
            obj.MaKH = this.textBoxMaKH.Text;
            //obj.Email = this.textBoxEmail.Text;
            obj.STT = Convert.ToInt32(this.textBoxSoTienThu.Text);

            string result = this.bus.update(obj);
            if (result == "0")
            {
                MessageBox.Show("Cập nhật thông tin thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                //this.isThemMoi = 0;
                //this.tcQLNH.SelectedIndex = 0;
                this.buildDanhSach();
                return;
            }
            else
            {
                MessageBox.Show("Cập nhật thông tin thất bại.\n" + result, "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
        }
    }
}
