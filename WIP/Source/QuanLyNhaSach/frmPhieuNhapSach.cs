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
        int nhapItNhat, luongtonMax;
        frmQuanLySach frmQLS; 
        //private int isThemMoi = 0;
        private PhieuNhapSachBUS bus;
        private ThamSoBUS busThamSo;
        //private CTPhieuNhapSachBUS busCTPN;
        
        public frmPhieuNhapSach()
        {
            InitializeComponent();
        }

        private void frmPhieuNhapSach_Load(object sender, EventArgs e)
        {
            bus = new PhieuNhapSachBUS();
           // busCTPN = new CTPhieuNhapSachBUS();
        }

        private void btnLapPhieu_Click(object sender, EventArgs e)
        {
            PhieuNhapSachDTO obj = new PhieuNhapSachDTO();
            obj.MaPN = this.txtMaPhieuNhap.Text;
            //obj.NgayNhap = this.dtpNgayNhap.Text; //xem cách get ngày nhập trong c# .net nha bây
            obj.NgayNhap = this.dtpNgayNhap.Text;
            string result = this.bus.insert(obj);
            if (result == "0")
            {
                MessageBox.Show("Thêm mới phiếu nhập thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            else
            {
                MessageBox.Show("Thêm mới phiếu nhập thất bại.\n" + result, "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Lỗi khi lấy danh sách phiếu nhập.\n" + result);
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

        private void btnXoaPhieu_Click(object sender, EventArgs e)
        {
            int currentRowIndex = this.dgvDanhSachPhieuNhap.CurrentCellAddress.Y; //'current row selected
            //Verify that indexing OK
            if (-1 < currentRowIndex && currentRowIndex < dgvDanhSachPhieuNhap.RowCount)
            {
                PhieuNhapSachDTO obj = (PhieuNhapSachDTO)dgvDanhSachPhieuNhap.Rows[currentRowIndex].DataBoundItem;
                this.txtMaPhieuNhap.Text = obj.MaPN;
                this.dtpNgayNhap.Text = obj.NgayNhap;
                string result = this.bus.delete(obj);
                if (result == "0")
                {
                    MessageBox.Show("Xóa phiếu nhập thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.buildDanhSach();
                    return;
                }
                else
                {
                    MessageBox.Show("Xóa phiếu nhập thất bại.\n" + result, "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn phiếu nhập trên lưới.", "THÔNG BÁO", MessageBoxButtons.OK);
            }
        }

        private void btnNhapChiTiet_Click(object sender, EventArgs e)
        {
            int currentRowIndex = this.dgvDanhSachPhieuNhap.CurrentCellAddress.Y; //'current row selected
            //Verify that indexing OK
            if (-1 < currentRowIndex && currentRowIndex < dgvDanhSachPhieuNhap.RowCount)
            {
                PhieuNhapSachDTO obj = (PhieuNhapSachDTO)dgvDanhSachPhieuNhap.Rows[currentRowIndex].DataBoundItem;
                this.txtMaPN.Text = obj.MaPN;
                //this.isThemMoi = 1;
                this.tcPhieuNhapSach.SelectedIndex = 1;
            }
            else
            {
                MessageBox.Show("Chưa chọn phiếu nhập trên lưới.", "THÔNG BÁO", MessageBoxButtons.OK);
            }
        }

        private void btnThemCT_Click(object sender, EventArgs e)
        {
            CTPhieuNhapSachDTO obj = new CTPhieuNhapSachDTO();
            List<ThamSoDTO> lsObjThamSo = new List<ThamSoDTO>();

            obj.MaCT = this.txtMaCTPN.Text;
            obj.MaPN = this.txtMaPN.Text;
            obj.MaSach = this.txtMaSach.Text;
            obj.SLN = Convert.ToInt32(this.txtSoLuongNhap.Text);
            string result = this.bus.insertChiTiet(obj);
            ////string loadThamSo = this.busThamSo.loadThamSo(lsObjThamSo);
            ////int nhapItNhat = int.Parse(loadThamSo.Rows(0).Item(1).ToString());
            //int nhapItNhat;
            //bool isItNhat = int.TryParse(txtSoLuongNhap.Text.Trim(), out nhapItNhat);
            if (result == "0")
            {
                MessageBox.Show("Thêm mới chi tiết phiếu nhập thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            else
            {
                MessageBox.Show("Thêm mới chi tiết phiếu nhập thất bại.\n" + result, "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }


        private void buildDanhSachCT()
        {
            List<CTPhieuNhapSachDTO> lsObj = new List<CTPhieuNhapSachDTO>();
            string result = this.bus.selectAllCT(lsObj);
            if (result != "0")
            {
                MessageBox.Show("Lỗi khi lấy danh sách chi tiết phiếu nhập.\n" + result, "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            dgvDanhSachCTPN.Columns.Clear();
            dgvDanhSachCTPN.DataSource = null;

            dgvDanhSachCTPN.AutoGenerateColumns = false;
            dgvDanhSachCTPN.AllowUserToAddRows = false;
            dgvDanhSachCTPN.DataSource = lsObj;

            DataGridViewTextBoxColumn clMaCT = new DataGridViewTextBoxColumn();
            clMaCT.Name = "MaCT";
            clMaCT.HeaderText = "Mã Chi Tiết Phiếu Nhập";
            clMaCT.DataPropertyName = "MaCT";
            dgvDanhSachCTPN.Columns.Add(clMaCT);

            DataGridViewTextBoxColumn clMaPN = new DataGridViewTextBoxColumn();
            clMaPN.Name = "MaPN";
            clMaPN.HeaderText = "Mã Phiếu Nhập";
            clMaPN.DataPropertyName = "MaPN";
            dgvDanhSachCTPN.Columns.Add(clMaPN);

            DataGridViewTextBoxColumn clMaSach = new DataGridViewTextBoxColumn();
            clMaSach.Name = "MaSach";
            clMaSach.HeaderText = "Mã Sách";
            clMaSach.DataPropertyName = "MaSach";
            dgvDanhSachCTPN.Columns.Add(clMaSach);

            DataGridViewTextBoxColumn clSLN = new DataGridViewTextBoxColumn();
            clSLN.Name = "SLN";
            clSLN.HeaderText = "Số Lượng Nhập";
            clSLN.DataPropertyName = "SLN";
            dgvDanhSachCTPN.Columns.Add(clSLN);

            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dgvDanhSachCTPN.DataSource];
            myCurrencyManager.Refresh();
        }

        private void btnXemChiTiet_Click(object sender, EventArgs e)
        {
            buildDanhSachCT();
        }

        private void btnXoaCT_Click(object sender, EventArgs e)
        {
            int currentRowIndex = this.dgvDanhSachCTPN.CurrentCellAddress.Y; //'current row selected
            //Verify that indexing OK
            if (-1 < currentRowIndex && currentRowIndex < dgvDanhSachCTPN.RowCount)
            {
                CTPhieuNhapSachDTO obj = (CTPhieuNhapSachDTO)dgvDanhSachCTPN.Rows[currentRowIndex].DataBoundItem;
                //this.txtMaCTPN.Text = obj.MaCT;
                this.txtMaPhieuNhap.Text = obj.MaPN;
                //this.txtMaSach.Text = obj.MaSach;
                //this.txtSoLuongNhap.Text = obj.SLN;
                string result = this.bus.deleteChiTiet(obj);
                if (result == "0")
                {
                    MessageBox.Show("Xóa chi tiết phiếu nhập thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.buildDanhSach();
                    return;
                }
                else
                {
                    MessageBox.Show("Xóa chi tiết phiếu nhập thất bại.\n" + result, "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn chi tiết phiếu nhập trên lưới.", "THÔNG BÁO", MessageBoxButtons.OK);
            }
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            frmQLS = new frmQuanLySach();
            DialogResult dr = frmQLS.ShowDialog(this);
            if (frmQLS.DialogResult == DialogResult.OK)
            {
                this.txtMaSach.Text = frmQLS.Text;
            }
        }
    }
}
