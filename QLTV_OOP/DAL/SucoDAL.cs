using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLTV_OOP.DTO;
namespace QLTV_OOP.DAL
{
    class SucoDAL
    {
        DataConnection dc;
        SqlDataAdapter da;
        SqlCommand cmd;
        public SucoDAL()
        {
            dc = new DataConnection();
        }
        public DataTable getAllSuco()
        {
            string query = "SELECT A.Maphieu,C.Tensuco,B.Tennguoidoc,A.Madausach,A.Tensach,C.Boithuong, C.Thoigian FROM (SELECT list.Maphieu,list.Masuco,dbo.DAUSACH.* FROM dbo.DAUSACH, (SELECT * FROM dbo.CTPHIEU WHERE Masuco!='') AS list WHERE list.Madausach=dbo.DAUSACH.Madausach) AS A, (SELECT ListPM.Maphieu, dbo.NGUOIDOC.Tennguoidoc FROM dbo.PHIEUMUON, (SELECT Maphieu FROM dbo.CTPHIEU WHERE Masuco != '') AS ListPM, dbo.NGUOIDOC WHERE dbo.PHIEUMUON.Maphieu = ListPM.Maphieu AND dbo.NGUOIDOC.Manguoidoc = dbo.PHIEUMUON.Manguoidoc) AS B, (SELECT * FROM dbo.SUCO) AS C WHERE A.Maphieu = B.Maphieu AND A.Masuco = C.Masuco";
            SqlConnection con = dc.getConnect();
            da = new SqlDataAdapter(query, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public bool insertSuco(SucoDTO suco)
        {
            string query = "INSERT INTO SUCO(Tensuco,Thoigian,Boithuong) VALUES(N'" + suco.Tensuco + "','" + suco.Thoigian + "'," + suco.Boithuong + ")";
            SqlConnection connect = dc.getConnect();
            try
            {
                cmd = new SqlCommand(query, connect);
                connect.Open();
                cmd.ExecuteNonQuery();
                connect.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public string getMaSC(string time, int boithuong)
        {
            string query = "SELECT Masuco FROM dbo.SUCO WHERE Thoigian='" + time + "' AND Boithuong=" + boithuong;
            SqlConnection con = dc.getConnect();
            da = new SqlDataAdapter(query, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt.Rows[0][0].ToString();
        }
        public bool updateSuco(string time)
        {
            return true;
        }

        public DataTable getAllSucoAndMasach()
        {
            string query = "SELECT A.Maphieu,C.Tensuco,B.Tennguoidoc,A.Madausach,A.Tensach,A.Maphong,C.Boithuong FROM (SELECT list.Maphieu,list.Masuco,dbo.DAUSACH.* FROM dbo.DAUSACH, (SELECT * FROM dbo.CTPHIEU WHERE Masuco!='') AS list WHERE list.Madausach=dbo.DAUSACH.Madausach) AS A, (SELECT ListPM.Maphieu, dbo.NGUOIDOC.Tennguoidoc FROM dbo.PHIEUMUON, (SELECT Maphieu FROM dbo.CTPHIEU WHERE Masuco != '') AS ListPM, dbo.NGUOIDOC WHERE dbo.PHIEUMUON.Maphieu = ListPM.Maphieu AND dbo.NGUOIDOC.Manguoidoc = dbo.PHIEUMUON.Manguoidoc) AS B, (SELECT * FROM dbo.SUCO) AS C WHERE A.Maphieu = B.Maphieu AND A.Masuco = C.Masuco";
            SqlConnection con = dc.getConnect();
            da = new SqlDataAdapter(query, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable findSuco(string searchContent)
        {
            string query = "SELECT * FROM (SELECT A.Maphieu,C.Tensuco,B.Tennguoidoc,A.Madausach,A.Tensach,C.Boithuong, C.Thoigian FROM (SELECT list.Maphieu,list.Masuco,dbo.DAUSACH.* FROM dbo.DAUSACH, (SELECT * FROM dbo.CTPHIEU WHERE Masuco!='') AS list WHERE list.Madausach=dbo.DAUSACH.Madausach) AS A, (SELECT ListPM.Maphieu, dbo.NGUOIDOC.Tennguoidoc FROM dbo.PHIEUMUON, (SELECT Maphieu FROM dbo.CTPHIEU WHERE Masuco != '') AS ListPM, dbo.NGUOIDOC WHERE dbo.PHIEUMUON.Maphieu = ListPM.Maphieu AND dbo.NGUOIDOC.Manguoidoc = dbo.PHIEUMUON.Manguoidoc) AS B, (SELECT * FROM dbo.SUCO) AS C WHERE A.Maphieu = B.Maphieu AND A.Masuco = C.Masuco) AS D WHERE D.Madausach LIKE '%" + searchContent + "%' OR D.Maphieu LIKE '%" + searchContent + "%'";
            SqlConnection con = dc.getConnect();
            da = new SqlDataAdapter(query, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
    }
}
