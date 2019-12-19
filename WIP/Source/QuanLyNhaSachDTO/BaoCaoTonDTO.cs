using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSachDTO
{
    class BaoCaoTonDTO
    {
        private string maCTton;
        private int month;
        private int year;
        private string maSach;
        private int tondau;
        private int tonphatsinh;
        private int toncuoi;

        public string MaCTTon
        {
            get => maCTton;
            set => maCTton = value;
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

        public string MaSach
        {
            get => maSach;
            set => maSach = value;
        }

        public int TonDau
        {
            get => tondau;
            set => tondau = value;
        }

        public int TonPhatSinh
        {
            get => tonphatsinh;
            set => tonphatsinh = value;
        }

        public int TonCuoi
        {
            get => toncuoi;
            set => toncuoi = value;
        }
    }
}
