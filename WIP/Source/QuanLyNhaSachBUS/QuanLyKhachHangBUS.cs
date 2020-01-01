using QuanLyNhaSachDAL;
using QuanLyNhaSachDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSachBUS
{
    public class QuanLyKhachHangBUS
    {
        private QuanLyKhachHangDAL dal;

        public QuanLyKhachHangBUS()
        {
            dal = new QuanLyKhachHangDAL();
        }

        public string insert(QuanLyKhachHangDTO obj)
        {
            if (obj.MaKH == null || obj.HoTen == string.Empty || obj.DiaChi == string.Empty || obj.SDT == string.Empty || obj.Email == string.Empty || obj.SoTienNo == '0')
                return "Thông tin nhập khách hàng không hợp lệ";

            return dal.insert(obj);
        }

        public string selectAll(List<QuanLyKhachHangDTO> lsObj)
        {
            return dal.selectAll(lsObj);
        }

        public string update(QuanLyKhachHangDTO obj)
        {
            return dal.update(obj);
        }

        public string delete(QuanLyKhachHangDTO obj)
        {
            return dal.delete(obj);
        }

        //public string deleteALL(QuanLyKhachHangDTO obj)
        //{
        //    return dal.delete(obj);
        //}


    }
}
