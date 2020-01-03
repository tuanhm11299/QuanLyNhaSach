using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyNhaSachDTO;
using QuanLyNhaSachDAL;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace QuanLyNhaSachBUS
{
    public class HoaDonBUS
    {
        private HoaDonDAL dal;

        public HoaDonBUS()
        {
            dal = new HoaDonDAL();
        }

        public string insert(HoaDonDTO obj)
        {
            if (obj.MaHD == null || obj.MaKH == string.Empty || obj.NgayLap == string.Empty || obj.TongThanhTien == '0')
                return "Mã hóa đơn hoặc Mã khách hàng hoặc Ngày lập hoặc số tiền không hợp lệ";

            return dal.insert(obj);
        }

        public string selectAll(List<HoaDonDTO> lsObj)
        {
            return dal.selectAll(lsObj);
        }

        public string delete(HoaDonDTO obj)
        {
            return dal.delete(obj);
        }
        public string insertChiTiet(ChiTietHDDTO obj)
        {
            if (obj.MaCTHD == null || obj.MaHD == string.Empty || obj.MaSach == string.Empty || obj.SLB == '0' || obj.DonGia == '0')
                return "Thêm mã chi tiết hoặc mã hóa đơn hoặc mã sách hoặc số lượng bán hoặc đơn giá không hợp lệ";

            return dal.insertChiTiet(obj);
        }


        public string selectAllCT(List<ChiTietHDDTO> lsObj)
        {
            return dal.selectAllCT(lsObj);
        }

        public string deleteChiTiet(ChiTietHDDTO obj)
        {
            return dal.deleteChiTiet(obj);
        }
    }
}
