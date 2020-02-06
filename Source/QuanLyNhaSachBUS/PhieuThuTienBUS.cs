using QuanLyNhaSachDAL;
using QuanLyNhaSachDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSachBUS
{
    public class PhieuThuTienBUS
    {
        private PhieuThuTienDAL dal;

        public PhieuThuTienBUS()
        {
            dal = new PhieuThuTienDAL();
        }

        public string insert(PhieuThuTienDTO obj)
        {
            if (obj.MaPT == null || obj.STT == null || obj.NgayThuTien == string.Empty || obj.MaKH == string.Empty)
                return "Thông tin nhập phiếu thu tiền không hợp lệ";

            return dal.insert(obj);
        }

        public string selectAll(List<PhieuThuTienDTO> lsObj)
        {
            return dal.selectAll(lsObj);
        }

        public string update(PhieuThuTienDTO obj)
        {
            return dal.update(obj);
        }

        public string delete(PhieuThuTienDTO obj)
        {
            return dal.delete(obj);
        }

        public string searchMaKH(string maKh, List<PhieuThuTienDTO> lsObj)
        {
            return dal.searchMaKH(maKh, lsObj);
        }
        
        public PhieuThuTienDTO searchKhachHang(string makh, PhieuThuTienDTO obj)
        {
            return dal.searchKhachHang(makh, obj);
        }
    }
}
