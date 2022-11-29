using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLTV_OOP.DAL;
using QLTV_OOP.DTO;
namespace QLTV_OOP.BLL
{
    class TaikhoanBLL
    {
        TaikhoanDAL tkDal;
        public TaikhoanBLL()
        {
            tkDal = new TaikhoanDAL();
        }
        public TaikhoanDTO getTK(string MaNV)
        {
            return tkDal.getTK(MaNV);
        }
        public bool updatePW(string MaNV, string password)
        {
            return tkDal.updatePW(MaNV, password);
        }
        public bool updateAuth(string MaNV, string Quyentruycap)
        {
            return tkDal.updateAuth(MaNV,Quyentruycap);
        }
    }
}
