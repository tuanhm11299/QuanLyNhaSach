using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSachDTO
{
    class PhieuNhapSachDTO
    {
        private string maPN;
        private DateTime ngNhap;

        public string MaPN
        {
            get => maPN;
            set => maPN = value;
        }

        public DateTime NgayNhap
        {
            get => ngNhap;
            set => ngNhap = value;
        }
    }
}
