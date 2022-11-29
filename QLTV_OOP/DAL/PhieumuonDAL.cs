using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace QLTV_OOP.DAL
{
    class PhieumuonDAL
    {
        SqlDataAdapter da;
        SqlCommand cmd;
        DataConnection dc;
        public PhieumuonDAL()
        {
            dc = new DataConnection();
        }
        public DataTable getAllPM()
        {
            string query = "SELECT p.Maphieu,n.Tennguoidoc,p.Ngaymuon,p.Ngaytra,(SELECT COUNT(*) FROM dbo.CTPHIEU WHERE p.Maphieu=dbo.CTPHIEU.Maphieu GROUP BY dbo.CTPHIEU.Maphieu) AS Sosach FROM dbo.PHIEUMUON p, dbo.NGUOIDOC n WHERE p.Manguoidoc = n.Manguoidoc";
            SqlConnection con = dc.getConnect();
            da = new SqlDataAdapter(query, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public bool insertPM(string Maphieu, string Manguoimuon, string ngaymuon, string ngaytra)
        {
            string sql = " INSERT INTO dbo.PHIEUMUON(Maphieu,Manguoidoc,Ngaymuon,Ngaytra) VALUES ('" + Maphieu + "','" + Manguoimuon + "','" + ngaymuon + "', '" + ngaytra + "')";
            SqlConnection connect = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, connect);
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
        public DataTable getBookByMP(string Maphieu)
        {
            string query = "(SELECT dbo.DAUSACH.Madausach,Tensach,Tentacgia,NXB,Trangthai,Gia FROM dbo.DAUSACH, (SELECT Madausach mds FROM  dbo.CTPHIEU WHERE Maphieu='" + Maphieu + "') AS list WHERE dbo.DAUSACH.Madausach = list.mds) UNION ALL (SELECT dbo.DAUSACH.Madausach, Tensach, Tentacgia, NXB, Trangthai, Gia FROM dbo.DAUSACH WHERE Trangthai= N'Chưa mượn' EXCEPT(SELECT dbo.DAUSACH.Madausach, Tensach, Tentacgia, NXB, Tinhtrang, Gia FROM dbo.DAUSACH, (SELECT Madausach mds FROM  dbo.CTPHIEU WHERE Maphieu = '" + Maphieu + "') AS list WHERE dbo.DAUSACH.Madausach = list.mds) )";
            SqlConnection con = dc.getConnect();
            da = new SqlDataAdapter(query, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public bool updatePM(string Maphieu, string Manguoimuon, string Ngaymuon, string Ngaytra)
        {
            string query = "UPDATE dbo.PHIEUMUON SET Manguoidoc='" + Manguoimuon + "', Ngaymuon='" + Ngaymuon + "',Ngaytra='" + Ngaytra + "' WHERE Maphieu='" + Maphieu + "'";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(query, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        public bool deletePMByMP(string Maphieu)
        {
            string query = "DELETE FROM dbo.PHIEUMUON WHERE Maphieu='" + Maphieu + "'";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(query, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
    }
}
