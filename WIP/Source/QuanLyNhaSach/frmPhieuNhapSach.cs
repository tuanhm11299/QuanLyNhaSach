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

        private void btnLapPhieu_Click(object sender, EventArgs e)
        {
            PhieuNhapSachDTO obj = new PhieuNhapSachDTO();
            obj.MaPN = this.textBoxMaPhieuNhap.Text;
            obj.NgayNhap = Convert.ToDateTime(this.textBoxNgayNhap.Text);

            string result = this.bus.insert(obj);
            if(result == "0")
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
    }
}
