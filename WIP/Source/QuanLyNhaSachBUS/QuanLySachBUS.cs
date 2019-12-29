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
        
        public string searchTuKhoa(string kw, List<QuanLySachDTO> lsObj)
        {
            return dal.searchTuKhoa(kw, lsObj);
        }
    }
}
