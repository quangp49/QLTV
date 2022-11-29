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
    class SucoBLL
    {

        SucoDAL scDAL;
        public SucoBLL()
        {
            scDAL = new SucoDAL();
        }
        public DataTable getAllSuco()
        {
            return scDAL.getAllSuco();
        }
        public bool insertSuco(string time, int Boithuong)
        {
            SucoDTO suco = new SucoDTO();
            suco.Tensuco = "Mất sách";
            suco.Thoigian = time;
            suco.Boithuong = Boithuong;
            return scDAL.insertSuco(suco);
        }
        public bool updateSuco(string time)
        {
            return scDAL.updateSuco(time);
        }
        public string getMaSC(string time, int boithuong)
        {
            return scDAL.getMaSC(time, boithuong);
        }
        public List<string> getMasachInSuco()
        {
            List<string> list = new List<string>();
            DataTable dt = scDAL.getAllSucoAndMasach();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                list.Add(dt.Rows[i][3].ToString());
            }
            return list;
        }
        public DataTable findSuco(string contentSearch)
        {
            return scDAL.findSuco(contentSearch);
        }
    }
}
