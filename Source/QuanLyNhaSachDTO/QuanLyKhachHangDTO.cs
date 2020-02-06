using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSachDTO
{
    public class QuanLyKhachHangDTO
    {
        private string maKH;
        private string hoten;
        private string diaChi;
        private string sdt;
        private string email;
        private int sotienNo;

        public string MaKH
        {
            get => maKH;
            set => maKH = value;
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

        public int SoTienNo
        {
            get => sotienNo;
            set => sotienNo = value;
        }
    }
}
