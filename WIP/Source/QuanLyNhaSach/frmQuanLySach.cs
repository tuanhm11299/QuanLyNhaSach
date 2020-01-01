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
        private QuanLySachBUS bus;
        public frmQuanLySach()
        {
            InitializeComponent();
        }

        private void frmQuanLySach_Load(object sender, EventArgs e)
        {
            bus = new QuanLySachBUS();
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
    }
}
