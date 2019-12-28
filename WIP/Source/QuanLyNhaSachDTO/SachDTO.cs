using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSachDTO
{
    public class SachDTO
    {
        private string tenSach;
        private string maSach;
        private string tacGia;
        private string theLoai;
        private int soluongTon;

        public string TenSach
        {
            get => tenSach;
            set => tenSach = value;
        }

        public string MaSach
        {
            get => maSach;
            set => maSach = value;
        }

        public string TacGia
        {
            get => tacGia;
            set => tacGia = value;
        }

        public string TheLoai
        {
            get => theLoai;
            set => theLoai = value;
        }

        public int SoLuongTon
        {
            get => soluongTon;
            set => soluongTon = value;
        }
    }
}
