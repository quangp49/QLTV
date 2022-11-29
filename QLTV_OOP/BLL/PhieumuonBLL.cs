using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLTV_OOP.DAL;
namespace QLTV_OOP.BLL
{
    class PhieumuonBLL
    {
        PhieumuonDAL pmDAL;
        public PhieumuonBLL()
        {
            pmDAL = new PhieumuonDAL();
        }
        public DataTable getALLPM()
        {
            return pmDAL.getAllPM();

        }
        public List<String> getMaPhieu()
        {
            DataTable dt = pmDAL.getAllPM();
            List<String> list = new List<string>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                list.Add(dt.Rows[i][0].ToString());
            }
            return list;
        }
        public bool insertPM(string Maphieu, string Manguoimuon, string ngaymuon, string ngaytra)
        {
            return pmDAL.insertPM(Maphieu, Manguoimuon, ngaymuon, ngaytra);
        }
        public DataTable getBookByMP(string Maphieu)
        {
            return pmDAL.getBookByMP(Maphieu);
        }
        public bool updatePM(string Maphieu, string Manguoimuon, string Ngaymuon, string Ngaytra)
        {
            return pmDAL.updatePM(Maphieu, Manguoimuon, Ngaymuon, Ngaytra);
        }

        public bool deletePMByMP(string Maphieu)
        {
            return pmDAL.deletePMByMP(Maphieu);
        }
    }
}
