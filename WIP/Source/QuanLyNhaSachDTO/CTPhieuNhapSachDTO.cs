using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSachDTO
{
    public class CTPhieuNhapSachDTO
    {
        private string maPN;
        private string maSach;
        private string soluongNhap;
        private string maCT;

        public string MaPN
        {
            get => maPN;
            set => maPN = value;
        }

        public string MaSach
        {
            get => maSach;
            set => maSach = value;
        }

        public string MaCT
        {
            get => maCT;
            set => maCT = value;
        }

        public string SLN
        {
            get => soluongNhap;
            set => soluongNhap = value;
        }
    }
}
