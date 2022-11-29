using QLTV_OOP.DAL;
using QLTV_OOP.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV_OOP.BLL
{
    class ChucvuBLL
    {
        ChucvuDAL dalCV;
        public ChucvuBLL()
        {
            dalCV = new ChucvuDAL();
        }
        public DataTable ShowAllChucvu()
        {
           return dalCV.ShowAllChucvu();
        }
        public bool InsertChucvu(ChucvuDTO cv)
        {
            return dalCV.InsertChucvu(cv);
        }
        public bool UpdateChucvu(ChucvuDTO cv)
        {
            return dalCV.UpdateChucvu(cv);
        }
        public bool DeleteChucvu(ChucvuDTO cv)
        {
            return dalCV.DeleteChucvu(cv);
        }
        public DataTable FindChucvu(string s)
        {
            return dalCV.FindChucvu(s);
        }
    }
}
