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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void thayĐổiQuyĐịnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThayDoiQuyDinh frm = new frmThayDoiQuyDinh();
            frm.MdiParent = this;
            frm.Show();
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDangNhap frm = new frmDangNhap();
            frm.MdiParent = this;
            frm.Show();
        }

        private void quảnLíNhàSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLySach frm = new frmQuanLySach();
            frm.MdiParent = this;
            frm.Show();
        }

        private void quảnLíKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLyKhachHang frm = new frmQuanLyKhachHang();
            frm.MdiParent = this;
            frm.Show();
        }

        private void quảnLíNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLyNhanVien frm = new frmQuanLyNhanVien();
            frm.MdiParent = this;
            frm.Show();
        }

        private void phiếuNhậpSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPhieuNhapSach frm = new frmPhieuNhapSach();
            frm.MdiParent = this;
            frm.Show();
        }

        private void hóaĐơnBánSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHoaDonBanSach frm = new frmHoaDonBanSach();
            frm.MdiParent = this;
            frm.Show();
        }

        private void phiếuThuTiềnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLapPhieuThuTien frm = new frmLapPhieuThuTien();
            frm.MdiParent = this;
            frm.Show();
        }

        private void sáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTraCuuSach frm = new frmTraCuuSach();
            frm.MdiParent = this;
            frm.Show();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLyKhachHang frm = new frmQuanLyKhachHang();
            frm.MdiParent = this;
            frm.Show();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLyNhanVien frm = new frmQuanLyNhanVien();
            frm.MdiParent = this;
            frm.Show();
        }

        private void báoCáoTồnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBaoCaoThang frm = new frmBaoCaoThang();
            frm.MdiParent = this;
            frm.Show();
        }

        private void báoCáoCôngNợToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBaoCaoCongNo frm = new frmBaoCaoCongNo();
            frm.MdiParent = this;
            frm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
