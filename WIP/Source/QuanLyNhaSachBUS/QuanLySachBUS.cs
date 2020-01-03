using QuanLyNhaSachDAL;
using QuanLyNhaSachDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSachBUS
{
    public class QuanLySachBUS
    {
        private QuanLySachDAL dal;
        public QuanLySachBUS()
        {
            dal = new QuanLySachDAL();
        }

        public string insert(QuanLySachDTO obj)
        {
            if (obj.MaSach == string.Empty || obj.TenSach == string.Empty || obj.TheLoai == string.Empty || obj.TacGia == string.Empty || obj.SoLuongTon == null || obj.DonGiaNhap == null)
                return "Thêm Sách thất bại";
            return dal.insert(obj);
        }

        public string selectAll(List<QuanLySachDTO> lsObj)
        {
            return dal.selectAll(lsObj);
        }

        public string delete(QuanLySachDTO obj)
        {
            return dal.delete(obj);
        }

        public string update(QuanLySachDTO obj)
        {
            return dal.update(obj);
        }

        public string searchMaSach(string masach, List<QuanLySachDTO> lsObj)
        {
            return dal.searchMaSach(masach, lsObj);
        }

        public QuanLySachDTO laySach()
        {
            return dal.laySach();
        }

        public string searchTenSach(string tensach, List<QuanLySachDTO> lsObj)
        {
            return dal.searchTenSach(tensach, lsObj);
        }

        public string searchTheLoai(string theloai, List<QuanLySachDTO> lsObj)
        {
            return dal.searchTheLoai(theloai, lsObj);
        }

        public string searchTacGia(string tacgia, List<QuanLySachDTO> lsObj)
        {
            return dal.searchTacGia(tacgia, lsObj);
        }
        
    }
}
