using QuanLyNhaSachBUS;
using QuanLyNhaSachDTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaSach
{
    public partial class frmPhieuNhapSach : Form
    {
        private PhieuNhapSachBUS bus;
        public frmPhieuNhapSach()
        {
            InitializeComponent();
        }

        private void frmPhieuNhapSach_Load(object sender, EventArgs e)
        {
            bus = new PhieuNhapSachBUS();
        }

        private void btnLapPhieu_Click(object sender, EventArgs e)
        {
            PhieuNhapSachDTO obj = new PhieuNhapSachDTO();
            obj.MaPN = this.txtMaPhieuNhap.Text;
            obj.NgayNhap = this.txtNgayNhap.Text; //xem cách get ngày nhập trong c# .net nha bây

            string result = this.bus.insert(obj);
            if (result == "0")
            {
                MessageBox.Show("Thêm mới phiếu nhập thành công");
                return;
            }
            else
            {
                MessageBox.Show("Thêm mới phiếu nhập thất bại.\n" + result);
                return;
            }
        }

        private void btnXemPhieu_Click(object sender, EventArgs e)
        {
            buildDanhSach();
        }

        private void buildDanhSach()
        {
            List<PhieuNhapSachDTO> lsObj = new List<PhieuNhapSachDTO>();
            string result = this.bus.selectAll(lsObj);
            if (result != "0")
            {
                MessageBox.Show("Lỗi khi lấy danh sách năm học.\n" + result);
                return;
            }
            dgvDanhSachPhieuNhap.Columns.Clear();
            dgvDanhSachPhieuNhap.DataSource = null;

            dgvDanhSachPhieuNhap.AutoGenerateColumns = false;
            dgvDanhSachPhieuNhap.AllowUserToAddRows = false;
            dgvDanhSachPhieuNhap.DataSource = lsObj;

            DataGridViewTextBoxColumn clMaPN = new DataGridViewTextBoxColumn();
            clMaPN.Name = "MaPN";
            clMaPN.HeaderText = "Mã Phiếu Nhập";
            clMaPN.DataPropertyName = "MaPN";
            dgvDanhSachPhieuNhap.Columns.Add(clMaPN);

            DataGridViewTextBoxColumn clNgayNhap = new DataGridViewTextBoxColumn();
            clNgayNhap.Name = "NgayNhap";
            clNgayNhap.HeaderText = "Ngày Nhập";
            clNgayNhap.DataPropertyName = "NgayNhap";
            dgvDanhSachPhieuNhap.Columns.Add(clNgayNhap);

            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dgvDanhSachPhieuNhap.DataSource];
            myCurrencyManager.Refresh();
        }

        private void btnSuaPhieu_Click(object sender, EventArgs e)
        {
            int currentRowIndex = this.dgvDanhSachPhieuNhap.CurrentCellAddress.Y; //'current row selected
            //Verify that indexing OK
            if (-1 < currentRowIndex && currentRowIndex < dgvDanhSachPhieuNhap.RowCount)
            {
                PhieuNhapSachDTO obj = (PhieuNhapSachDTO)dgvDanhSachPhieuNhap.Rows[currentRowIndex].DataBoundItem;
                this.txtMaPhieuNhap.Text = obj.MaPN;
                this.txtNgayNhap.Text = obj.NgayNhap;
            }
            else
            {
                MessageBox.Show("Chưa chọn phiếu nhập trên lưới.");
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            PhieuNhapSachDTO obj = new PhieuNhapSachDTO();
            obj.MaPN = this.txtMaPhieuNhap.Text;
            obj.NgayNhap = this.txtNgayNhap.Text;
           
            string result = this.bus.update(obj);
            if (result == "0")
            {
                MessageBox.Show("Cập nhật phiếu nhập thành công");
                this.buildDanhSach();
                return;
            }
            else
            {
                MessageBox.Show("Cập nhật phiếu nhập thất bại.\n" + result);

                return;
            }
        }
    }
}
