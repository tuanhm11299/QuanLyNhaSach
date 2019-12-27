using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSachDTO
{
    public class DangNhapDTO
    {
        private string tenDN;
        private string mk;
        public string tcsdl;

        public string TenDN
        {
            get => tenDN;
            set => tenDN = value;
        }

        public string MatKhau
        {
            get => mk;
            set => mk = value;
        }

        public string Tcsdl
        {
            get => tcsdl;
            set => tcsdl = value;
        }
    }
}
