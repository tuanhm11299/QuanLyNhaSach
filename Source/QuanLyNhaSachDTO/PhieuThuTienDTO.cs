using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSachDTO
{
    public class PhieuThuTienDTO
    {
        private string maPT;
        private string maKH;
        private string ngThuTien;
        private int stt;

        public string MaPT
        {
            get => maPT;
            set => maPT = value;
        }

        public string MaKH
        {
            get => maKH;
            set => maKH = value;
        }

        public string NgayThuTien
        {
            get => ngThuTien;
            set => ngThuTien = value;
        }

        public int STT
        {
            get => stt;
            set => stt = value;
        }
    }
}
