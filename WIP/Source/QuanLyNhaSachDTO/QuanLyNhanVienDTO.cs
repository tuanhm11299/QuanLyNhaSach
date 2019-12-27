using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSachDTO
{
    public class QuanLyNhanVienDTO
    {
        private string maNV;
        private string hoten;
        private string diaChi;
        private string sdt;
        private string email;
        private int tienLuong;

        public string MaNV
        {
            get => maNV;
            set => maNV = value;
        }

        public string HoTen
        {
            get => hoten;
            set => hoten = value;
        }

        public string DiaChi
        {
            get => diaChi;
            set => diaChi = value;
        }
        
        public string SDT
        {
            get => sdt;
            set => sdt = value;
        }

        public string Email
        {
            get => email;
            set => email = value;
        }

        public int TienLuong
        {
            get => tienLuong;
            set => tienLuong = value;
        }
    }
}
