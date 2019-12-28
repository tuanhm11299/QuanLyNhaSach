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
        private string ngNhap; //xem cách get ngày nhập trong c# .net nha bây
        private string maCT;
        private string maSach;
        private int soluongNhap;
        

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

        public int SLN
        {
            get => soluongNhap;
            set => soluongNhap = value;
        }
    }
}
