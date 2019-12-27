using QuanLyNhaSachDAL;
using QuanLyNhaSachDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSachBUS
{
    public class PhieuNhapSachBUS
    {
        private PhieuNhapSachDAL dal;
        public PhieuNhapSachBUS()
        {
            dal = new PhieuNhapSachDAL();
        }
        public string insert(PhieuNhapSachDTO obj)
        {
            if (obj.NgayNhap == null || obj.MaPN == string.Empty)
                return "Tên Năm Học không hợp lệ";

            return dal.insert(obj);
        }
        public string selectAll(List<PhieuNhapSachDTO> lsObj)
        {
            return dal.selectAll(lsObj);
        }
    }
}
