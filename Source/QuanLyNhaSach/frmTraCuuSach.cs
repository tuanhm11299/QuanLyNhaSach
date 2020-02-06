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
        //int typesearch = 0;


        public frmTraCuuSach()
        {
            InitializeComponent();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (chkMaSach.Checked == true)
            { 
                buildDanhSachMaSach(); 
            }
            else if(chkTenSach.Checked == true)
            {
                buildDanhSachTenSach();
            }
            else if (chkTheLoai.Checked == true) 
            {
                buildDanhSachTheLoai();
            }
            else if (chkTacGia.Checked == true)
            {
                buildDanhSachTacGia();
            }
            /*
            else if(chkMaSach.Checked == true && chkTenSach.Checked == true)
            {
                buildDanhSachMaSachandTenSach();
            }
            else if(chkMaSach.Checked == true && chkTheLoai.Checked == true)
            {
                buildDanhSachMaSachandTheLoai();
            }
            else if(chkMaSach.Checked == true && chkTacGia.Checked == true)
            {
                buildDanhSachMaSachandTacGia();
            }
            else if(chkTenSach.Checked == true && chkTheLoai.Checked == true)
            {
                buildDanhSachTenSachandTheLoai();
            }
            else if(chkTenSach.Checked == true && chkTacGia.Checked == true)
            {
                buildDanhSachTenSachandTacGia();
            }
            else if(chkTheLoai.Checked == true && chkTacGia.Checked == true)
            {
                buildDanhSachTacGiaandTheLoai();
            }
            else if(chkMaSach.Checked == true && chkTenSach.Checked == true && chkTheLoai.Checked == true)
            {
                buildDanhSachMaSachandTenSachandTheLoai();
            }
            else if(chkMaSach.Checked == true && chkTenSach.Checked == true && chkTacGia.Checked == true)
            {
                buildDanhSachMaSachandTenSachandTacGia();
            }
            else if(chkMaSach.Checked == true && chkTheLoai.Checked == true && chkTacGia.Checked == true)
            {
                buildDanhSachMaSachandTheLoaiandTacGia();
            }
            else if(chkTenSach.Checked == true && chkTheLoai.Checked == true && chkTacGia.Checked == true)
            {
                buildDanhSachTenSachandTheLoaiandTacGia();
            }*/
        }

        private void buildDanhSachMaSach()
        {
            List<QuanLySachDTO> lsObj = new List<QuanLySachDTO>();
            string result = this.bus.searchMaSach(this.txtMaSach.Text, lsObj);
            if (result != "0")
            {
                MessageBox.Show("Lỗi khi lấy danh sách sách.\n" + result, "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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
            clSoLuong.Name = "SoLuongTon";
            clSoLuong.HeaderText = "Số Lượng Tồn";
            clSoLuong.DataPropertyName = "SoLuongTon";
            dgvDanhSachSach.Columns.Add(clSoLuong);

            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dgvDanhSachSach.DataSource];
            myCurrencyManager.Refresh();
        }

        private void buildDanhSachTheLoai()
        {
            List<QuanLySachDTO> lsObj = new List<QuanLySachDTO>();
            string result = this.bus.searchTheLoai(this.txtTheLoai.Text, lsObj);
            if (result != "0")
            {
                MessageBox.Show("Lỗi khi lấy danh sách sách.\n" + result, "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            DataGridViewTextBoxColumn clDonGiaNhap = new DataGridViewTextBoxColumn();
            clDonGiaNhap.Name = "DonGiaNhap";
            clDonGiaNhap.HeaderText = "DonGiaNhap";
            clDonGiaNhap.DataPropertyName = "DonGiaNhap";
            dgvDanhSachSach.Columns.Add(clDonGiaNhap);

            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dgvDanhSachSach.DataSource];
            myCurrencyManager.Refresh();
        }

        private void buildDanhSachTenSach()
        {
            List<QuanLySachDTO> lsObj = new List<QuanLySachDTO>();
            string result = this.bus.searchTenSach(this.txtTenSach.Text, lsObj);
            if (result != "0")
            {
                MessageBox.Show("Lỗi khi lấy danh sách sách.\n" + result, "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            DataGridViewTextBoxColumn clDonGiaNhap = new DataGridViewTextBoxColumn();
            clDonGiaNhap.Name = "DonGiaNhap";
            clDonGiaNhap.HeaderText = "DonGiaNhap";
            clDonGiaNhap.DataPropertyName = "DonGiaNhap";
            dgvDanhSachSach.Columns.Add(clDonGiaNhap);

            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dgvDanhSachSach.DataSource];
            myCurrencyManager.Refresh();
        }

        private void buildDanhSachTacGia()
        {
            List<QuanLySachDTO> lsObj = new List<QuanLySachDTO>();
            string result = this.bus.searchTacGia(this.txtTacGia.Text, lsObj);
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

            DataGridViewTextBoxColumn clDonGiaNhap = new DataGridViewTextBoxColumn();
            clDonGiaNhap.Name = "DonGiaNhap";
            clDonGiaNhap.HeaderText = "DonGiaNhap";
            clDonGiaNhap.DataPropertyName = "DonGiaNhap";
            dgvDanhSachSach.Columns.Add(clDonGiaNhap);

            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dgvDanhSachSach.DataSource];
            myCurrencyManager.Refresh();
        }

        private void frmTraCuuSach_Load(object sender, EventArgs e)
        {
            this.bus = new QuanLySachBUS();
            chkMaSach.Checked = true;
        }

        private void buildDanhSach()
        {
            List<QuanLySachDTO> lsObj = new List<QuanLySachDTO>();
            string result = this.bus.searchMaSach(this.txtMaSach.Text,lsObj);
            if (result != "0")
            {
                MessageBox.Show("Lỗi khi lấy danh sách năm học.\n" + result, "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            DataGridViewTextBoxColumn clDonGiaNhap = new DataGridViewTextBoxColumn();
            clDonGiaNhap.Name = "DonGiaNhap";
            clDonGiaNhap.HeaderText = "DonGiaNhap";
            clDonGiaNhap.DataPropertyName = "DonGiaNhap";
            dgvDanhSachSach.Columns.Add(clDonGiaNhap);

            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dgvDanhSachSach.DataSource];
            myCurrencyManager.Refresh();
        }

        private void txtTenSach_TextChanged(object sender, EventArgs e)
        {

        }

        private void chkMaSach_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void chkTenSach_CheckedChanged(object sender, EventArgs e)
        {
            //chkTenSach.Checked = false;
        }

        private void chkTacGia_CheckedChanged(object sender, EventArgs e)
        {
            //chkTacGia.Checked = false;
        }

        private void chkTheLoai_CheckedChanged(object sender, EventArgs e)
        {
            //chkTheLoai.Checked = false;
        }
    }
}
