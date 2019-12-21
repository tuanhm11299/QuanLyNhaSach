using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSachDTO
{
    public class PhieuNhapSachDTO
    {
        private string maPN;
        private string ngNhap;

        public string MaPN
        {
            get => maPN;
            set => maPN = value;
        }

        public string NgayNhap
        {
            get => ngNhap;
            set => ngNhap = value;
        }
    }
}
