using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLTV_OOP.DAL;
namespace QLTV_OOP.BLL
{
    class ChitietphieuBLL
    {
        ChitietphieuDAL ctpDAL;
        public ChitietphieuBLL()
        {
            ctpDAL = new ChitietphieuDAL();
        }
        public bool insertCTP(string Maphieu, string Madausach)
        {
            return ctpDAL.insertCTP(Maphieu, Madausach);
        }
        public bool deleteCTP(string Maphieu)
        {
            return ctpDAL.deleteCTP(Maphieu);
        }
        public DataTable getAllDsInCTP(string Maphieu)
        {
            return ctpDAL.getAllDsInCTP(Maphieu);
        }
        public bool updateTrangthaiSuco(string Masuco, string Masach, string trangthai)
        {
            return ctpDAL.updateTrangthaiSuco(Masuco, Masach, trangthai);
        }

        public bool deleteCTPByMasach(string Masach)
        {
            return ctpDAL.deleteCTPByMasach(Masach);
        }
    }
}
