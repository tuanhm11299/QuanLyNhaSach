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
    public partial class frmHoaDonBanSach : Form
    {
        frmQuanLyKhachHang frmQLKH;
        int noToiDa, noKhachHang, tonSauBan, luongTon, luongTonMoi, tongThanhTien, SoTienNo, SoLuongBan, DonGiaBan;
        private HoaDonBUS bus = new HoaDonBUS();
        private ThamSoBUS busThamSo = new ThamSoBUS();
        private QuanLyKhachHangBUS busKH = new QuanLyKhachHangBUS();
        private QuanLySachBUS busSach = new QuanLySachBUS();

        public frmHoaDonBanSach()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void frmHoaDonBanSach_Load(object sender, EventArgs e)
        {
            buildDanhSach();
        }

        private void btnLapPhieu_Click(object sender, EventArgs e)
        {
            HoaDonDTO obj = new HoaDonDTO();
            ThamSoDTO ThamSo = new ThamSoDTO();
            ThamSo = busThamSo.QuyDinh();
            noToiDa = ThamSo.SoTienNoToiDa;
            QuanLyKhachHangDTO KH = new QuanLyKhachHangDTO();
            string result;

            if (this.txtMaKH.Text == String.Empty)
            {
                MessageBox.Show("Mã khách hàng không được để trống", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            obj.MaHD = this.txtMaHD.Text;
            obj.MaKH = this.txtMaKH.Text;
            obj.NgayLap = this.dtpNgayLap.Text;
            obj.TongThanhTien = Convert.ToInt32(this.txtTongTien.Text);
            KH.MaKH = this.txtMaKH.Text;
            KH = this.busKH.searchKH(KH.MaKH, KH);
            noKhachHang = KH.SoTienNo;
            if (noKhachHang > noToiDa)
            {
                MessageBox.Show(string.Format("Số tiền nợ đã vượt quá số tiền nợ tối đa ({0} vnđ)", noToiDa), "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                
            }
            else
            {
                
                result = this.bus.insert(obj);
                if (result == "0")
                {
                    MessageBox.Show("Lập hóa đơn thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    buildDanhSach();
                    return;
                }
                else
                {
                    MessageBox.Show("Lập hóa đơn thất bại.\n" + result, "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            
        }

        private void btnXemHD_Click(object sender, EventArgs e)
        {
            buildDanhSach();
        }

        private void buildDanhSach()
        {
            List<HoaDonDTO> lsObj = new List<HoaDonDTO>();
            string result = this.bus.selectAll(lsObj);
            if(result != "0")
            {
                MessageBox.Show("Lỗi khi lấy danh sách hóa đơn.\n" + result);
                return;
            }
            dgvDanhSachHoaDon.Columns.Clear();
            dgvDanhSachHoaDon.DataSource = null;

            dgvDanhSachHoaDon.AutoGenerateColumns = false;
            dgvDanhSachHoaDon.AllowUserToAddRows = false;
            dgvDanhSachHoaDon.DataSource = lsObj;

            DataGridViewTextBoxColumn clMaHoaDon = new DataGridViewTextBoxColumn();
            clMaHoaDon.Name = "MaHD";
            clMaHoaDon.HeaderText = "Mã Hóa Đơn";
            clMaHoaDon.DataPropertyName = "MaHD";
            dgvDanhSachHoaDon.Columns.Add(clMaHoaDon);

            DataGridViewTextBoxColumn clMaKhachHang = new DataGridViewTextBoxColumn();
            clMaKhachHang.Name = "MaKH";
            clMaKhachHang.HeaderText = "Mã Khách Hàng";
            clMaKhachHang.DataPropertyName = "MaKH";
            dgvDanhSachHoaDon.Columns.Add(clMaKhachHang);

            DataGridViewTextBoxColumn clNgayLapHoaDon = new DataGridViewTextBoxColumn();
            clNgayLapHoaDon.Name = "NgayLap";
            clNgayLapHoaDon.HeaderText = "Ngày Lập Hóa Đơn";
            clNgayLapHoaDon.DataPropertyName = "NgayLap";
            dgvDanhSachHoaDon.Columns.Add(clNgayLapHoaDon);

            DataGridViewTextBoxColumn clTongThanhTien = new DataGridViewTextBoxColumn();
            clTongThanhTien.Name = "TongThanhTien";
            clTongThanhTien.HeaderText = "Tổng Thành Tiền";
            clTongThanhTien.DataPropertyName = "TongThanhTien";
            dgvDanhSachHoaDon.Columns.Add(clTongThanhTien);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int currentRowIndex = this.dgvDanhSachHoaDon.CurrentCellAddress.Y; //'current row selected
            //Verify that indexing OK
            if (-1 < currentRowIndex && currentRowIndex < dgvDanhSachHoaDon.RowCount)
            {
                HoaDonDTO obj = (HoaDonDTO)dgvDanhSachHoaDon.Rows[currentRowIndex].DataBoundItem;
                this.txtMaHD.Text = obj.MaHD;
                this.txtMaKH.Text = obj.MaKH;
                this.dtpNgayLap.Text = obj.NgayLap;
                this.txtTongTien.Text = obj.TongThanhTien.ToString();
                string result = this.bus.delete(obj);
                if (result == "0")
                {
                    MessageBox.Show("Xóa hóa đơn thành công");
                    this.buildDanhSach();
                    return;
                }
                else
                {
                    MessageBox.Show("Xóa hóa đơn thất bại.\n" + result);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn phiếu nhập trên lưới.");
            }
        }

        private void btnNhapChiTiet_Click(object sender, EventArgs e)
        {
            int currentRowIndex = this.dgvDanhSachHoaDon.CurrentCellAddress.Y; //'current row selected
            //Verify that indexing OK
            if (-1 < currentRowIndex && currentRowIndex < dgvDanhSachHoaDon.RowCount)
            {
                HoaDonDTO obj = (HoaDonDTO)dgvDanhSachHoaDon.Rows[currentRowIndex].DataBoundItem;
                this.txtMaHD.Text = obj.MaHD;
                //this.isThemMoi = 1;
                this.tcHoaDon.SelectedIndex = 1;
            }
            else
            {
                MessageBox.Show("Chưa chọn hóa đơn trên lưới.");
            }
        }

        private void btnThemCT_Click(object sender, EventArgs e)
        {
            ChiTietHDDTO obj = new ChiTietHDDTO();
            ThamSoDTO ThamSo = new ThamSoDTO();
            ThamSo = busThamSo.QuyDinh();
            tonSauBan = ThamSo.SoLuongTonSauToiThieu;
            QuanLySachDTO Sach = new QuanLySachDTO();
            string result;

            obj.MaCTHD = this.txtMaCTHD.Text;
            obj.MaHD = this.txtMaHD.Text;
            obj.MaSach = this.txtMaSach.Text;
            obj.DonGia = Convert.ToInt32(this.txtĐonGia.Text);
            obj.SLB = Convert.ToInt32(this.txtSoLuong.Text);
            Sach.MaSach = this.txtMaSach.Text;
            Sach = this.busSach.laySach(Sach.MaSach, Sach);
            luongTon = Sach.SoLuongTon;
            luongTonMoi = luongTon - obj.SLB;
            if((luongTon -obj.SLB) < tonSauBan)
            {
                MessageBox.Show(string.Format("Số lượng tồn của sách này sau khi bán đã nhỏ hơn quy định ({0} quyển)", tonSauBan), "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                result = this.bus.insertChiTiet(obj);
                if (result == "0")
                {
                    MessageBox.Show("Thêm mới chi tiết hóa đơn thành công");
                    return;
                }
                else
                {
                    MessageBox.Show("Thêm mới chi tiết hóa đơn thất bại.\n" + result);
                    return;
                }
            }        
        }

        


        private void buildDanhSachCT()
        {
            List<ChiTietHDDTO> lsObj = new List<ChiTietHDDTO>();
            string result = this.bus.selectAllCT(lsObj);
            if (result != "0")
            {
                MessageBox.Show("Lỗi khi lấy danh sách chi tiết hóa đơn.\n" + result);
                return;
            }
            dgvDanhSachChiTietHoaDon.Columns.Clear();
            dgvDanhSachChiTietHoaDon.DataSource = null;

            dgvDanhSachChiTietHoaDon.AutoGenerateColumns = false;
            dgvDanhSachChiTietHoaDon.AllowUserToAddRows = false;
            dgvDanhSachChiTietHoaDon.DataSource = lsObj;

            DataGridViewTextBoxColumn clMaCThD = new DataGridViewTextBoxColumn();
            clMaCThD.Name = "MaCTHD";
            clMaCThD.HeaderText = "Mã Chi Tiết Hóa Đơn";
            clMaCThD.DataPropertyName = "MaCTHD";
            dgvDanhSachChiTietHoaDon.Columns.Add(clMaCThD);

            DataGridViewTextBoxColumn clMaHD = new DataGridViewTextBoxColumn();
            clMaHD.Name = "MaHD";
            clMaHD.HeaderText = "Mã Hóa Đơn";
            clMaHD.DataPropertyName = "MaHD";
            dgvDanhSachChiTietHoaDon.Columns.Add(clMaHD);


            DataGridViewTextBoxColumn clMaSach = new DataGridViewTextBoxColumn();
            clMaSach.Name = "MaSach";
            clMaSach.HeaderText = "Mã Sách";
            clMaSach.DataPropertyName = "MaSach";
            dgvDanhSachChiTietHoaDon.Columns.Add(clMaSach);

            DataGridViewTextBoxColumn clDonGia = new DataGridViewTextBoxColumn();
            clDonGia.Name = "DonGia";
            clDonGia.HeaderText = "Đơn Giá";
            clDonGia.DataPropertyName = "DonGia";
            dgvDanhSachChiTietHoaDon.Columns.Add(clDonGia);

            DataGridViewTextBoxColumn clSLB = new DataGridViewTextBoxColumn();
            clSLB.Name = "SLB";
            clSLB.HeaderText = "Số Lượng Bán";
            clSLB.DataPropertyName = "SLB";
            dgvDanhSachChiTietHoaDon.Columns.Add(clSLB);

            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dgvDanhSachChiTietHoaDon.DataSource];
            myCurrencyManager.Refresh();
        }


        private void btnXemCT_Click(object sender, EventArgs e)
        {
            buildDanhSachCT();
        }

        private void btnXoaCT_Click(object sender, EventArgs e)
        {
            int currentRowIndex = this.dgvDanhSachChiTietHoaDon.CurrentCellAddress.Y; //'current row selected
            //Verify that indexing OK
            if (-1 < currentRowIndex && currentRowIndex < dgvDanhSachChiTietHoaDon.RowCount)
            {
                ChiTietHDDTO obj = (ChiTietHDDTO)dgvDanhSachChiTietHoaDon.Rows[currentRowIndex].DataBoundItem;
                //this.txtMaCTPN.Text = obj.MaCT;
                this.txtMaHD.Text = obj.MaHD;
                //this.txtMaSach.Text = obj.MaSach;
                //this.txtSoLuongNhap.Text = obj.SLN;
                string result = this.bus.deleteChiTiet(obj);
                if (result == "0")
                {
                    MessageBox.Show("Xóa hóa đơn thành công");
                    this.buildDanhSach();
                    return;
                }
                else
                {
                    MessageBox.Show("Xóa hóa đơn thất bại.\n" + result);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn hóa đơn trên lưới.");
            }
        }

        private void btnChon3_Click(object sender, EventArgs e)
        {
            frmQLKH = new frmQuanLyKhachHang();
            DialogResult dr = frmQLKH.ShowDialog(this);
        }
    }
}
