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
        private string maNV;
        private DateTime ngayLap;
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

        public string MaNV
        {
            get => maNV;
            set => maNV = value;
        }

        public DateTime NgayLap
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
