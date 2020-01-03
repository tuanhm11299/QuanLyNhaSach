using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSachDTO
{
    public class BaoCaoCongNoDTO
    {
        private string maCTCongNo;
        private int month;
        private int year;
        private string maKH;
        private Single nodau;
        private Single nophatsinh;
        private Single nocuoi;

        public string MaCTCongNo
        {
            get => maCTCongNo;
            set => maCTCongNo = value;
        }

        public int Month
        {
            get => month;
            set => month = value;
        }

        public int Year
        {
            get => year;
            set => year = value;
        }

        private string MaKH
        {
            get => maKH;
            set => maKH = value;
        }

        private Single NoDau
        {
            get => nodau;
            set => nodau = value;
        }

        public Single NoPhatSinh
        {
            get => nophatsinh;
            set => nophatsinh = value;
        }

        public Single NoCuoi
        {
            get => nocuoi;
            set => nocuoi = value;
        }
    }
}
