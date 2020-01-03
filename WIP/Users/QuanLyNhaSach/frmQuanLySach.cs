using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhaSachDTO;
using QuanLyNhaSachBUS;

namespace QuanLyNhaSach
{
    public partial class frmQuanLySach : Form
    {
        private QuanLySachBUS bus = new QuanLySachBUS();

        //bus = new QuanLySachBUS();
        public frmQuanLySach()
        {
            InitializeComponent();
        }

        private void frmQuanLySach_Load(object sender, EventArgs e)
        {
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            QuanLySachDTO obj = new QuanLySachDTO();
            obj.MaSach = this.txtMaSach.Text;
            //obj.NgayNhap = this.dtpNgayNhap.Text; //xem cách get ngày nhập trong c# .net nha bây
            obj.TenSach = this.txtTenSach.Text;
            obj.TheLoai = this.txtTheLoai.Text;
            obj.TacGia = this.txtTacGia.Text;
            obj.SoLuongTon = Convert.ToInt32(this.txtSoLuongTon.Text);
            obj.DonGiaNhap = Convert.ToInt32(this.txtDonGia.Text);
            string result = this.bus.insert(obj);
            if (result == "0")
            {
                MessageBox.Show("Thêm sách thành công");
                return;
            }
            else
            {
                MessageBox.Show("Thêm sách thất bại.\n" + result);
                return;
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            buildDanhSach();
        }

        private void buildDanhSach()
        {
            List<QuanLySachDTO> lsObj = new List<QuanLySachDTO>();
            string result = this.bus.selectAll(lsObj);
            if (result != "0")
            {
                MessageBox.Show("Lỗi khi lấy danh sách phiếu nhập.\n" + result);
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

            DataGridViewTextBoxColumn clSoLuongTon = new DataGridViewTextBoxColumn();
            clSoLuongTon.Name = "SoLuongTon";
            clSoLuongTon.HeaderText = "Số Lượng Tồn";
            clSoLuongTon.DataPropertyName = "SoLuongTon";
            dgvDanhSachSach.Columns.Add(clSoLuongTon);

            DataGridViewTextBoxColumn clDonGiaNhap = new DataGridViewTextBoxColumn();
            clDonGiaNhap.Name = "DonGiaNhap";
            clDonGiaNhap.HeaderText = "Đơn Giá Nhập";
            clDonGiaNhap.DataPropertyName = "DonGiaNhap";
            dgvDanhSachSach.Columns.Add(clDonGiaNhap);


            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dgvDanhSachSach.DataSource];
            myCurrencyManager.Refresh();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int currentRowIndex = this.dgvDanhSachSach.CurrentCellAddress.Y; //'current row selected
            //Verify that indexing OK
            if (-1 < currentRowIndex && currentRowIndex < dgvDanhSachSach.RowCount)
            {
                QuanLySachDTO obj = (QuanLySachDTO)dgvDanhSachSach.Rows[currentRowIndex].DataBoundItem;
                this.txtMaSach.Text = obj.MaSach;
                this.txtTenSach.Text = obj.TenSach;
                this.txtTheLoai.Text = obj.TheLoai;
                this.txtTacGia.Text = obj.TacGia;
                this.txtSoLuongTon.Text = obj.SoLuongTon.ToString();
                this.txtDonGia.Text = obj.DonGiaNhap.ToString();
                string result = this.bus.delete(obj);
                if (result == "0")
                {
                    MessageBox.Show("Xóa sách thành công");
                    this.buildDanhSach();
                    return;
                }
                else
                {
                    MessageBox.Show("Xóa sách thất bại.\n" + result);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn sách trên lưới.");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int currentRowIndex = this.dgvDanhSachSach.CurrentCellAddress.Y; //'current row selected
            //Verify that indexing OK
            if (-1 < currentRowIndex && currentRowIndex < dgvDanhSachSach.RowCount)
            {
                QuanLySachDTO obj = (QuanLySachDTO)dgvDanhSachSach.Rows[currentRowIndex].DataBoundItem;
                this.txtMaSach.Text = obj.MaSach;
                this.txtTenSach.Text = obj.TenSach;
                this.txtTheLoai.Text = obj.TheLoai;
                this.txtTacGia.Text = obj.TacGia;
                this.txtSoLuongTon.Text = obj.SoLuongTon.ToString();
                this.txtDonGia.Text = obj.DonGiaNhap.ToString();
            }
            else
            {
                MessageBox.Show("Chưa chọn sách trên lưới.");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            QuanLySachDTO obj = new QuanLySachDTO();
            obj.MaSach = this.txtMaSach.Text;
            obj.TenSach = this.txtTenSach.Text;
            obj.TheLoai = this.txtTheLoai.Text;
            obj.TacGia = this.txtTacGia.Text;
            obj.SoLuongTon = Convert.ToInt32(this.txtSoLuongTon.Text);
            obj.DonGiaNhap = Convert.ToInt32(this.txtDonGia.Text);

            string result = this.bus.update(obj);
            if (result == "0")
            {
                MessageBox.Show("Cập nhật thông tin thành công");
                //this.isThemMoi = 0;
                //this.tcQLNH.SelectedIndex = 0;
                this.buildDanhSach();
                return;
            }
            else
            {
                MessageBox.Show("Cập nhật thông tin thất bại.\n" + result);

                return;
            }
        }

        private void btnTraCuuSach_Click(object sender, EventArgs e)
        {
            buildDanhSachTenSach();
        }

        private void buildDanhSachTenSach()
        {
            List<QuanLySachDTO> lsObj = new List<QuanLySachDTO>();
            string result = this.bus.searchTenSach(this.txtTraCuuTenSach.Text, lsObj);
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


            DataGridViewTextBoxColumn clSoLuongTon = new DataGridViewTextBoxColumn();
            clSoLuongTon.Name = "SoLuongTon";
            clSoLuongTon.HeaderText = "Số Lượng Tồn";
            clSoLuongTon.DataPropertyName = "SoLuongTon";
            dgvDanhSachSach.Columns.Add(clSoLuongTon);

            DataGridViewTextBoxColumn clDonGiaNhap = new DataGridViewTextBoxColumn();
            clDonGiaNhap.Name = "DonGiaNhap";
            clDonGiaNhap.HeaderText = "DonGiaNhap";
            clDonGiaNhap.DataPropertyName = "DonGiaNhap";
            dgvDanhSachSach.Columns.Add(clDonGiaNhap);

            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dgvDanhSachSach.DataSource];
            myCurrencyManager.Refresh();
        }
    }
}
