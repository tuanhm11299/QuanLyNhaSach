using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSachDTO
{
    public class ChiTietHDDTO
    {
        private string maCTHD;
        private string maHD;
        private string maSach;
        private int donGia;
        private int soLuong;

        public string MaCTHD
        {
            get => maCTHD;
            set => maCTHD = value;
        }
        public string MaHD
        {
            get => maHD;
            set => maHD = value;
        }

        public string MaSach
        {
            get => maSach;
            set => maSach = value;
        }

        public int DonGia
        {
            get => donGia;
            set => donGia = value;
        }

        public int SLB
        {
            get => soLuong;
            set => soLuong = value;
        }
    }
}
