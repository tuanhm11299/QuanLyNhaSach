using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSachDTO
{
    public class PhieuThuTienDTOcs
    {
        private string maPT;
        private string maKH;
        private DateTime ngThuTien;
        private Single stt;

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

        public DateTime NgayThuTien
        {
            get => ngThuTien;
            set => ngThuTien = value;
        }

        public Single STT
        {
            get => stt;
            set => stt = value;
        }
    }
}
