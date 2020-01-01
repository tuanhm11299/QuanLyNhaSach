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
    public partial class frmQuanLyKhachHang : Form
    {
        private QuanLyKhachHangBUS bus;
        public frmQuanLyKhachHang()
        {
            InitializeComponent();
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {

        }

        private void frmQuanLyKhachHang_Load(object sender, EventArgs e)
        {
            bus = new QuanLyKhachHangBUS();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            QuanLyKhachHangDTO obj = new QuanLyKhachHangDTO();
            obj.MaKH = this.textBoxMaKH.Text;
            //obj.NgayNhap = this.dtpNgayNhap.Text; //xem cách get ngày nhập trong c# .net nha bây
            obj.HoTen = this.textBoxHoTenKH.Text;
            obj.DiaChi = this.textBoxDiaChi.Text;
            obj.SDT = this.textBoxSDT.Text;
            obj.Email = this.textBoxEmail.Text;
            obj.SoTienNo = Convert.ToInt32(this.textBoxSoTienNo.Text);
            string result = this.bus.insert(obj);
            if (result == "0")
            {
                MessageBox.Show("Thêm khách hàng thành công");
                return;
            }
            else
            {
                MessageBox.Show("Thêm khách hàng thất bại.\n" + result);
                return;
            }
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            buildDanhSach();
        }

        private void buildDanhSach()
        {
            List<QuanLyKhachHangDTO> lsObj = new List<QuanLyKhachHangDTO>();
            string result = this.bus.selectAll(lsObj);
            if (result != "0")
            {
                MessageBox.Show("Lỗi khi lấy danh sách phiếu nhập.\n" + result);
                return;
            }
            dgvDanhSachKH.Columns.Clear();
            dgvDanhSachKH.DataSource = null;

            dgvDanhSachKH.AutoGenerateColumns = false;
            dgvDanhSachKH.AllowUserToAddRows = false;
            dgvDanhSachKH.DataSource = lsObj;

            DataGridViewTextBoxColumn clMaKH = new DataGridViewTextBoxColumn();
            clMaKH.Name = "MaKH";
            clMaKH.HeaderText = "Mã Khách Hàng";
            clMaKH.DataPropertyName = "MaKH";
            dgvDanhSachKH.Columns.Add(clMaKH);

            DataGridViewTextBoxColumn clHoTen = new DataGridViewTextBoxColumn();
            clHoTen.Name = "HoTen";
            clHoTen.HeaderText = "Họ Tên Khách Hàng";
            clHoTen.DataPropertyName = "HoTen";
            dgvDanhSachKH.Columns.Add(clHoTen);

            DataGridViewTextBoxColumn clDiaChi = new DataGridViewTextBoxColumn();
            clDiaChi.Name = "DiaChi";
            clDiaChi.HeaderText = "Địa Chỉ";
            clDiaChi.DataPropertyName = "DiaChi";
            dgvDanhSachKH.Columns.Add(clDiaChi);

            DataGridViewTextBoxColumn clSDT = new DataGridViewTextBoxColumn();
            clSDT.Name = "SDT";
            clSDT.HeaderText = "Số Điện Thoại";
            clSDT.DataPropertyName = "SDT";
            dgvDanhSachKH.Columns.Add(clSDT);

            DataGridViewTextBoxColumn clEmail = new DataGridViewTextBoxColumn();
            clEmail.Name = "Email";
            clEmail.HeaderText = "Email";
            clEmail.DataPropertyName = "Email";
            dgvDanhSachKH.Columns.Add(clEmail);

            DataGridViewTextBoxColumn clSoTienNo = new DataGridViewTextBoxColumn();
            clSoTienNo.Name = "SoTienNo";
            clSoTienNo.HeaderText = "Số Tiền Nợ";
            clSoTienNo.DataPropertyName = "SoTienNo";
            dgvDanhSachKH.Columns.Add(clSoTienNo);

            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dgvDanhSachKH.DataSource];
            myCurrencyManager.Refresh();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            QuanLyKhachHangDTO obj = new QuanLyKhachHangDTO();
            obj.MaKH = this.textBoxMaKH.Text;
            obj.HoTen = this.textBoxHoTenKH.Text;
            obj.DiaChi = this.textBoxDiaChi.Text;
            obj.SDT = this.textBoxSDT.Text;
            obj.Email = this.textBoxEmail.Text;
            obj.SoTienNo = Convert.ToInt32(this.textBoxSoTienNo.Text);
            string result = this.bus.update(obj);
            if (result == "0")
            {
                MessageBox.Show("Sửa thông tin thành công");
                return;
            }
            else
            {
                MessageBox.Show("Sửa thông tin thất bại.\n" + result);
                return;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int currentRowIndex = this.dgvDanhSachKH.CurrentCellAddress.Y; //'current row selected
            //Verify that indexing OK
            if (-1 < currentRowIndex && currentRowIndex < dgvDanhSachKH.RowCount)
            {
                QuanLyKhachHangDTO obj = (QuanLyKhachHangDTO)dgvDanhSachKH.Rows[currentRowIndex].DataBoundItem;
                this.textBoxMaKH.Text = obj.MaKH;
                this.textBoxHoTenKH.Text = obj.HoTen;
                this.textBoxDiaChi.Text = obj.DiaChi;
                this.textBoxSDT.Text = obj.SDT;
                this.textBoxEmail.Text = obj.Email;
                this.textBoxSoTienNo.Text = obj.SoTienNo.ToString();
                string result = this.bus.delete(obj);
                if (result == "0")
                {
                    MessageBox.Show("Xóa khách hàng nhập thành công");
                    this.buildDanhSach();
                    return;
                }
                else
                {
                    MessageBox.Show("Xóa khách hàng thất bại.\n" + result);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn khách hàng trên lưới.");
            }
        }
    }
}
