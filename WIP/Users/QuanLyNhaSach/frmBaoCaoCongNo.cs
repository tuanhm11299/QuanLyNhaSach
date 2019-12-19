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
    public partial class frmBaoCaoCongNo : Form
    {
        private BaoCaoCongNoBUS baocaocongno;
        public frmBaoCaoCongNo()
        {
            InitializeComponent();
        }

        private void frmBaoCaoCongNo_Load(object sender, EventArgs e)
        {
            baocaocongno = new BaoCaoCongNoBUS();
        }

        private void btnLapBaoCao_Click(object sender, EventArgs e)
        {
            
        }
    }
}
