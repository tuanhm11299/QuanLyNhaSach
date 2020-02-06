using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSachDTO
{
    public class ThamSoDTO
    {
        private int mathamso;
        private int slnmin;
        private int slttoidatruocnhap;
        private int sltsautoithieu;
        private int stnmax;
        private int sdqd4;

        public int Mathamso
        {
            get => mathamso;
            set => mathamso = value;
        }

        public int SoLuongNhapItNhat
        {
            get => slnmin;
            set => slnmin = value;
        }

        public int SoLuongTonToiDaTruocNhap {
            get => slttoidatruocnhap;
            set => slttoidatruocnhap = value;
        }

        public int SoLuongTonSauToiThieu
        {
            get => sltsautoithieu;
            set => sltsautoithieu = value;
        }
        public int SoTienNoToiDa
        {
            get => stnmax;
            set => stnmax = value;
        }

        public int SuDungQuyDinh4
        {
            get => sdqd4;
            set => sdqd4 = value;
        }
    }
}
