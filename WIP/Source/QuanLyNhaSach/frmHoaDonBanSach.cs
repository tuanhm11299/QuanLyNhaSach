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
        frmHoaDonBanSach frmHDBS;
        private HoaDonBUS bus;

        public frmHoaDonBanSach()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void frmHoaDonBanSach_Load(object sender, EventArgs e)
        {
            bus = new HoaDonBUS();
        }

        private void btnLapPhieu_Click(object sender, EventArgs e)
        {
            HoaDonDTO obj = new HoaDonDTO();
            obj.MaHD = this.txtMaHD.Text;
            //obj.NgayNhap = this.dtpNgayNhap.Text; //xem cách get ngày nhập trong c# .net nha bây
            obj.MaKH = this.txtMaKH.Text;
            obj.NgayLap = this.dtpNgLap.Text;
            obj.TongThanhTien = Convert.ToInt32(this.txtTongTien.Text);
            string result = this.bus.insert(obj);
            if (result == "0")
            {
                MessageBox.Show("Lập hóa đơn thành công");
                return;
            }
            else
            {
                MessageBox.Show("Lập hóa đơn thất bại.\n" + result);
                return;
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
            if (result != "0")
            {
                MessageBox.Show("Lỗi khi lấy danh sách hóa đơn.\n" + result);
                return;
            }
            dgvDanhSachHoaDon.Columns.Clear();
            dgvDanhSachHoaDon.DataSource = null;

            dgvDanhSachHoaDon.AutoGenerateColumns = false;
            dgvDanhSachHoaDon.AllowUserToAddRows = false;
            dgvDanhSachHoaDon.DataSource = lsObj;

            DataGridViewTextBoxColumn clMaHD = new DataGridViewTextBoxColumn();
            clMaHD.Name = "MaHD";
            clMaHD.HeaderText = "Mã Hóa Đơn";
            clMaHD.DataPropertyName = "MaHD";
            dgvDanhSachHoaDon.Columns.Add(clMaHD);

            DataGridViewTextBoxColumn clMaKH = new DataGridViewTextBoxColumn();
            clMaKH.Name = "MaKH";
            clMaKH.HeaderText = "Mã Khách Hàng";
            clMaKH.DataPropertyName = "MaKH";
            dgvDanhSachHoaDon.Columns.Add(clMaKH);

            DataGridViewTextBoxColumn clNgayLap = new DataGridViewTextBoxColumn();
            clNgayLap.Name = "NgayLap";
            clNgayLap.HeaderText = "Ngày Lập";
            clNgayLap.DataPropertyName = "NgayLap";
            dgvDanhSachHoaDon.Columns.Add(clNgayLap);

            DataGridViewTextBoxColumn clTongThanhTien = new DataGridViewTextBoxColumn();
            clTongThanhTien.Name = "TongThanhTien";
            clTongThanhTien.HeaderText = "Tổng Thành Tiền";
            clTongThanhTien.DataPropertyName = "TongThanhTien";
            dgvDanhSachHoaDon.Columns.Add(clTongThanhTien);

            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dgvDanhSachHoaDon.DataSource];
            myCurrencyManager.Refresh();
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
                this.dtpNgLap.Text = obj.NgayLap;
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

            obj.MaCTHD = this.txtMaCTHD.Text;
            obj.MaHD = this.txtMaHD.Text;
            obj.MaSach = this.txtMaSach.Text;
            obj.DonGia = Convert.ToInt32(this.txtĐonGia.Text);
            obj.SLB = Convert.ToInt32(this.txtSoLuong.Text);
            string result = this.bus.insertChiTiet(obj);
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
            frmHDBS = new frmHoaDonBanSach();
            DialogResult dr = frmHDBS.ShowDialog(this);
        }
    }
}
