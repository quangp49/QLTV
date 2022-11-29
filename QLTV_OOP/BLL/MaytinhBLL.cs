using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLTV_OOP.DAL;
using QLTV_OOP.DTO;
namespace QLTV_OOP.BLL
{
    class MaytinhBLL
    {
        MaytinhDAL mtDal;
        public MaytinhBLL()
        {
            mtDal = new MaytinhDAL();
        }
        public DataTable getAllMaytinh()
        {
            return mtDal.getAllMaytinh();
        }
        public bool InsertMaytinh(MaytinhDTO mt)
        {
            return mtDal.InsertMaytinh(mt);
        }
        public bool UpdateMaytinh(MaytinhDTO mt)
        {
            return mtDal.UpdateMaytinh(mt);
        }
        public bool DeleteMaytinh(MaytinhDTO mt)
        {
            return mtDal.DeleteMaytinh(mt);
        }
        public DataTable FindMaytinh(string s)
        {
            return mtDal.FindMaytinh(s);
        }
        public List<String> getAllMaphong()
        {
            return mtDal.getAllMaPhong();
        }
        public DataTable getMTbyMaphong(string Maphong)
        {
           return mtDal.getMTbyMaphong(Maphong);
        }
        public bool updateTrangthaiMT(string MaMT, string trangthai)
        {
            return mtDal.updateTrangthaiMT(MaMT, trangthai);
        }
        public DataTable searchMT(string Maphong,string content)
        {
            return mtDal.searchMT(Maphong, content);
        }
    }
}
