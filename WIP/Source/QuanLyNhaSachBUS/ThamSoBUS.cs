using QuanLyNhaSachDAL;
using QuanLyNhaSachDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSachBUS
{
    public class ThamSoBUS
    {
        private ThamSoDAL dal;

        public ThamSoBUS()
        {
            dal = new ThamSoDAL();
        }

        public string loadThamSo(List<ThamSoDTO> lsObj) //load tham số quy định mặc định
        {
            return dal.loadThamSo(lsObj);
        }
    }
}
