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
    public partial class frmTraCuuSach : Form
    {
        private QuanLySachBUS bus;
        public frmTraCuuSach()
        {
            InitializeComponent();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            buildDanhSachMaSach();
        }

        private void buildDanhSachMaSach()
        {
            List<QuanLySachDTO> lsObj = new List<QuanLySachDTO>();
            string result = this.bus.searchTuKhoa(this.txtMaSach.Text, lsObj);
            if (result != "0")
            {
                MessageBox.Show("Lỗi khi lấy danh sách sách.\n" + result);
                return;
            }
            dgvDanhSachSach.Columns.Clear();
            dgvDanhSachSach.DataSource = null;

            dgvDanhSachSach.AutoGenerateColumns = false;
            dgvDanhSachSach.AllowUserToAddRows = false;
            dgvDanhSachSach.DataSource = lsObj;

            DataGridViewTextBoxColumn clMaSach = new DataGridViewTextBoxColumn();
            clMaSach.Name = "MaSach";
            clMaSach.HeaderText = "Mã Sách";
            clMaSach.DataPropertyName = "MaSach";
            dgvDanhSachSach.Columns.Add(clMaSach);

            DataGridViewTextBoxColumn clTenSach = new DataGridViewTextBoxColumn();
            clTenSach.Name = "TenSach";
            clTenSach.HeaderText = "Tên Sách";
            clTenSach.DataPropertyName = "TenSach";
            dgvDanhSachSach.Columns.Add(clTenSach);

            DataGridViewTextBoxColumn clTheLoai = new DataGridViewTextBoxColumn();
            clTheLoai.Name = "TheLoai";
            clTheLoai.HeaderText = "Thể Loại";
            clTheLoai.DataPropertyName = "TheLoai";
            dgvDanhSachSach.Columns.Add(clTheLoai);

            DataGridViewTextBoxColumn clTacGia = new DataGridViewTextBoxColumn();
            clTacGia.Name = "TacGia";
            clTacGia.HeaderText = "Tác Giả";
            clTacGia.DataPropertyName = "TacGia";
            dgvDanhSachSach.Columns.Add(clTacGia);

            DataGridViewTextBoxColumn clSoLuong = new DataGridViewTextBoxColumn();
            clSoLuong.Name = "SoLuong";
            clSoLuong.HeaderText = "Số Lượng Tồn";
            clSoLuong.DataPropertyName = "SoLuong";
            dgvDanhSachSach.Columns.Add(clSoLuong);

            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dgvDanhSachSach.DataSource];
            myCurrencyManager.Refresh();
        }

        private void frmTraCuuSach_Load(object sender, EventArgs e)
        {
            this.bus = new QuanLySachBUS();
        }

        private void buildDanhSach()
        {
            List<QuanLySachDTO> lsObj = new List<QuanLySachDTO>();
            string result = this.bus.searchTuKhoa(this.txtMaSach.Text,lsObj);
            if (result != "0")
            {
                MessageBox.Show("Lỗi khi lấy danh sách năm học.\n" + result);
                return;
            }
            dgvDanhSachSach.Columns.Clear();
            dgvDanhSachSach.DataSource = null;

            dgvDanhSachSach.AutoGenerateColumns = false;
            dgvDanhSachSach.AllowUserToAddRows = false;
            dgvDanhSachSach.DataSource = lsObj;

            DataGridViewTextBoxColumn clMaSach = new DataGridViewTextBoxColumn();
            clMaSach.Name = "MaSach";
            clMaSach.HeaderText = "Mã Sách";
            clMaSach.DataPropertyName = "MaSach";
            dgvDanhSachSach.Columns.Add(clMaSach);

            DataGridViewTextBoxColumn clTenSach = new DataGridViewTextBoxColumn();
            clTenSach.Name = "TenSach";
            clTenSach.HeaderText = "Tên Sách";
            clTenSach.DataPropertyName = "TenSach";
            dgvDanhSachSach.Columns.Add(clTenSach);

            DataGridViewTextBoxColumn clTheLoai = new DataGridViewTextBoxColumn();
            clTheLoai.Name = "TheLoai";
            clTheLoai.HeaderText = "Thể Loại";
            clTheLoai.DataPropertyName = "TheLoai";
            dgvDanhSachSach.Columns.Add(clTheLoai);

            DataGridViewTextBoxColumn clTacGia = new DataGridViewTextBoxColumn();
            clTacGia.Name = "TacGia";
            clTacGia.HeaderText = "Tác Giả";
            clTacGia.DataPropertyName = "TacGia";
            dgvDanhSachSach.Columns.Add(clTacGia);

            DataGridViewTextBoxColumn clSoLuong = new DataGridViewTextBoxColumn();
            clSoLuong.Name = "SoLuong";
            clSoLuong.HeaderText = "Số Lượng Tồn";
            clSoLuong.DataPropertyName = "SoLuong";
            dgvDanhSachSach.Columns.Add(clSoLuong);

            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dgvDanhSachSach.DataSource];
            myCurrencyManager.Refresh();
        }
    }
}
