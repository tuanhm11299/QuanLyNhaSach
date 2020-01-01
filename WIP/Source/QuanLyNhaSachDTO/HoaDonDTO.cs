using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSachDTO
{
    public class HoaDonDTO
    {
        private string maKH;
        private string maHD;
        private string ngayLap;
        private int tongthanhTien;

        public string MaHD
        {
            get => maHD;
            set => maHD = value;
        }

        public string MaKH
        {
            get => maKH;
            set => maKH = value;
        }

        public string NgayLap
        {
            get => ngayLap;
            set => ngayLap = value;
        }

        public int TongThanhTien
        {
            get => tongthanhTien;
            set => tongthanhTien = value;
        }
    }
}
