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
    public partial class frmThayDoiQuyDinh : Form
    {

        private ThamSoBUS quydinh = new ThamSoBUS();
        // private int maThamSo;

        public frmThayDoiQuyDinh()
        {
            InitializeComponent();
        }

        private void loadQuyDinh()
        {
            ThamSoDTO qd = new ThamSoDTO();
            qd = quydinh.QuyDinh();
            if (qd != null)
            {
                this.txtToiThieu.Text = qd.SoLuongNhapItNhat.ToString();
                this.txtTonMax.Text = qd.SoLuongTonToiDaTruocNhap.ToString();
                this.txtTonToiThieu.Text = qd.SoLuongTonSauToiThieu.ToString();
                this.txtTienNo.Text = qd.SoTienNoToiDa.ToString();
                int check = qd.SuDungQuyDinh4;
                if (check == 1)
                    this.chkQuyDinh4.Checked = true;
                else
                    this.chkQuyDinh4.Checked = false;
            }
        }       

        private ThamSoDTO QuyDinh()
        {
            ThamSoDTO q = new ThamSoDTO();
            q.SoLuongNhapItNhat = int.Parse(this.txtToiThieuMoi.Text);
            q.SoLuongTonToiDaTruocNhap = int.Parse(this.txtTonMaxMoi.Text);
            q.SoLuongTonSauToiThieu = int.Parse(this.txtTonToiThieuMoi.Text);
            q.SoTienNoToiDa = int.Parse(this.txtTienNoMoi.Text);
            if (this.chkQuyDinh4.Checked == true)
                q.SuDungQuyDinh4 = 1;
            else
                q.SuDungQuyDinh4 = 0;
            return q;
        }

        private void btnMacDinh_Click(object sender, EventArgs e)
        {
            this.txtToiThieuMoi.Text = "150";
            this.txtTonMaxMoi.Text = "300";
            this.txtTonToiThieuMoi.Text = "20";
            this.txtTienNoMoi.Text = "20000";
            this.chkQuyDinh4.Checked = true;
            ThamSoDTO qdMoi = new ThamSoDTO();
            qdMoi = quydinh.QuyDinh();

            qdMoi.SoLuongNhapItNhat = Convert.ToInt32(this.txtToiThieuMoi.Text);
            qdMoi.SoLuongTonToiDaTruocNhap = Convert.ToInt32(this.txtTonMaxMoi.Text);
            qdMoi.SoLuongTonSauToiThieu = Convert.ToInt32(this.txtTonToiThieuMoi.Text);
            qdMoi.SoTienNoToiDa = Convert.ToInt32(this.txtTienNoMoi.Text);
            qdMoi.SuDungQuyDinh4 = 1;
            bool ketqua = quydinh.chinhsuaQuyDinh(qdMoi);
            if (ketqua == true)
                MessageBox.Show("Khôi phục mặc định thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            else
                MessageBox.Show("Khôi phục mặc định thất bại \n" + ketqua, "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            loadQuyDinh();
        }

        private void btnThayDoi_Click(object sender, EventArgs e)
        {
            if (quydinh.chinhsuaQuyDinh(QuyDinh()))
                MessageBox.Show("Cập nhật quy định thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            else
                MessageBox.Show("Cập nhật quy định thất bại", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            loadQuyDinh();
        }

        private void frmThayDoiQuyDinh_Load(object sender, EventArgs e)
        {
            txtToiThieuMoi.Text = "0";
            txtTonMaxMoi.Text = "0";
            txtTonToiThieuMoi.Text = "0";
            txtTienNoMoi.Text = "0";
            loadQuyDinh();
        }
    }
}
