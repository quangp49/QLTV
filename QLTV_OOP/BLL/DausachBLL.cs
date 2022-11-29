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
    class DausachBLL
    {
        DausachDAL dalDS;
        public DausachBLL()
        {
            dalDS = new DausachDAL();
        }
        public DataTable getAllDausach()
        {
            return dalDS.getAllDausach();
        }
        public bool InsertDausach(DausachDTO ds)
        {
            return dalDS.InsertDausach(ds);
        }
        public bool UpdateDausach(DausachDTO ds)
        {
            return dalDS.UpdateDausach(ds);
        }
        public bool DeleteDausach(DausachDTO ds)
        {
            return dalDS.DeleteDausach(ds);
        }
        public DataTable FindDausach(string s)
        {
            return dalDS.FindDausach(s);
        }
        public DataTable getDausach()
        {
            return dalDS.getDausach();
        }
        public bool updateTrangthaiDausach(string Madausach, string Trangthai)
        {
            return dalDS.updateTrangthaiDausach(Madausach,Trangthai);
        }
        public DataTable searchDSByTenOrMP(string content)
        {
            return dalDS.searchDSByTenOrMP(content);
        }
        public DataTable ShowAllTuasach()
        {
            return dalDS.ShowAllTuasach();
        }
        public DataTable getAllSachmuontheongay(string start,string end)
        {
            return dalDS.getAllSachmuontheongay(start, end);
        }
        public string getTotalSachmuontheongay(string start,string end)
        {
            return dalDS.getTotalSachdamuontheongay(start, end);
        }
    }
}
