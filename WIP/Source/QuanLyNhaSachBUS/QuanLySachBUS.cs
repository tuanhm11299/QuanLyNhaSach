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

        public string insert(QuanLySachDTO Obj)
        {
            return dal.insert(Obj);
        }
        
        public string searchMaSach(string masach, List<QuanLySachDTO> lsObj)
        {
            return dal.searchMaSach(masach, lsObj);
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
        /*
        public string searchMaSachandTheLoai(string masach, string theloai, List<QuanLySachDTO> lsObj)
        {
            return dal.searchMaSachandTheLoai(masach, theloai, lsObj);
        }

        public string searchMaSachandTenSach(string masach, string tensach, List<QuanLySachDTO> lsObj)
        {
            return dal.searchMaSachandTenSach(masach, tensach, lsObj);
        }

        public string searchMaSachandTacGia(string masach, string tacgia, List<QuanLySachDTO> lsObj)
        {
            return dal.searchMaSachandTacGia(masach, tacgia, lsObj);
        }

        public string searchTenSachandTheLoai(string tensach, string theloai, List<QuanLySachDTO> lsObj)
        {
            return dal.searchTenSachandTheLoai(tensach, theloai, lsObj);
        }

        public string searchTenSachandTacGia(string tensach, string tacgia, List<QuanLySachDTO> lsObj)
        {
            return dal.searchTenSachandTacGia(tensach, tacgia, lsObj);
        }

        public string searchTacGiaandTheLoai(string tacgia, string theloai, List<QuanLySachDTO> lsObj)
        {
            return dal.searchTacGiaandTheLoai(tacgia, theloai, lsObj);
        }

        public string searchMaSachandTenSachandTheLoai(string masach, string tensach, string theloai, List<QuanLySachDTO> lsObj)
        {
            return dal.searchMaSachandTenSachandTheLoai(masach, tensach, theloai, lsObj);
        }

        public string searchMaSachandTenSachandTacGia(string masach, string tensach, string tacgia, List<QuanLySachDTO> lsObj)
        {
            return dal.searchMaSachandTenSachandTacGia(masach, tensach, tacgia, lsObj);
        }

        public string searchMaSachandTheLoaiandTacGia(string masach, string theloai, string tacgia, List<QuanLySachDTO> lsObj)
        {
            return dal.searchMaSachandTheLoaiandTacGia(masach, theloai, tacgia, lsObj);
        }

        public string searchTenSachandTheLoaiandTacGia(string tensach, string theloai, string tacgia, List<QuanLySachDTO> lsObj)
        {
            return dal.searchTenSachandTheLoaiandTacGia(tensach, theloai, tacgia, lsObj);
        }*/
    }
}
