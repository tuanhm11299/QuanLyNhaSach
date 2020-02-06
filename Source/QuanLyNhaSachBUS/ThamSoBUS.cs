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

        public ThamSoDTO QuyDinh()
        {
            return dal.QuyDinh();
        }

        public bool chinhsuaQuyDinh(ThamSoDTO qd)
        {
            return dal.chinhsuaQuyDinh(qd);
        }
    }
}
