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
    class PhongdocBLL
    {
        PhongdocDAL pdDal;
        public PhongdocBLL()
        {
            pdDal = new PhongdocDAL();
        }
        public DataTable getAllMaphong()
        {
            return pdDal.getAllMaphong();
        }
        public bool InsertPhongdoc(PhongdocDTO phongdoc)
        {
            return pdDal.InsertPhongdoc(phongdoc);
        }
        public bool UpdatePhongdoc(PhongdocDTO phongdoc)
        {
            return pdDal.UpdatePhongdoc(phongdoc);
        }
        public bool DeletePhongdoc(PhongdocDTO phongdoc)
        {
            return pdDal.DeletePhongdoc(phongdoc);
        }
        public List<String> getMaphong()
        {
            List<String> list = new List<string>();
            DataTable dt = pdDal.getAllMaphong();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                list.Add(dt.Rows[i][0].ToString());

            }
            return list;
        }
        public DataTable searchPhongdoc(string search)
        {
            return pdDal.searchPhongdoc(search);
        }
    }
}