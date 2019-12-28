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
                return "Ngày nhập hoặc mã phiếu nhập không hợp lệ";

            return dal.insert(obj);
        }
        public string selectAll(List<PhieuNhapSachDTO> lsObj)
        {
            return dal.selectAll(lsObj);
        }
        public string update(PhieuNhapSachDTO obj)
        {
            return dal.update(obj);
        }
        public string delete(PhieuNhapSachDTO obj)
        {
            return dal.delete(obj);
        }
        public string insertChiTiet(CTPhieuNhapSachDTO obj)
        {
            if (obj.MaCT == null || obj.MaPN == string.Empty || obj.MaSach == string.Empty || obj.SLN == null)
                return "Thêm mã chi tiết hoặc mã phiếu nhập hoặc mã sách hoặc số lượng nhập không hợp lệ";

            return dal.insertChiTiet(obj);
        }
        public string selectAllCT(List<CTPhieuNhapSachDTO> lsObj)
        {
            return dal.selectAllCT(lsObj);
        }
    }
}
