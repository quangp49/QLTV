using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLTV_OOP.DAL;
using QLTV_OOP.DTO;
namespace QLTV_OOP.BLL
{
    class NguoidocBLL
    {
        NguoidocDAL ndDAL;
        public NguoidocBLL()
        {
            ndDAL = new NguoidocDAL();
        }
        public List<String> getAllNguoiDoc()
        {
            return ndDAL.getAllNguoiDoc();
        }
        public string searchNguoidoc(string name)
        {
            return ndDAL.searchNguoidoc(name);
        }
        public DataTable ToDataTable()
        {
            return ndDAL.ToDataTable();
        }
        public bool InsertNguoidoc(NguoidocDTO nguoidoc)
        {
            return ndDAL.InsertNguoidoc(nguoidoc);
        }
        public bool UpdateNguoidoc(NguoidocDTO nguoidoc)
        {
            return ndDAL.UpdateNguoidoc(nguoidoc);
        }
        public bool DeleteNguoidoc(NguoidocDTO nguoidoc)
        {
            return ndDAL.DeleteNguoidoc(nguoidoc);
        }
        public DataTable FindNguoidoc(string nguoidoc)
        {
            return ndDAL.FindNguoidoc(nguoidoc);
        }
    }
}
