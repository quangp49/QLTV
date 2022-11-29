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
    class ChitietphieuDAL
    {
        DataConnection dc;
        SqlDataAdapter da;
        SqlCommand cmd;
        public ChitietphieuDAL()
        {
            dc = new DataConnection();
        }
        public bool insertCTP(string Maphieu, string Madausach)
        {
            string sql = "INSERT INTO CTPHIEU(Maphieu,Madausach,Masuco) VALUES(@Maphieu,@Madausach,@Masuco)";
            SqlConnection connect = dc.getConnect();
            cmd = new SqlCommand(sql, connect);
            cmd.Parameters.Add("@Maphieu", SqlDbType.VarChar).Value = Maphieu;
            cmd.Parameters.Add("@Madausach", SqlDbType.VarChar).Value = Madausach;
            cmd.Parameters.AddWithValue("@Masuco", DBNull.Value);
            connect.Open();
            int i = cmd.ExecuteNonQuery();
            connect.Close();
            if (i == 0)
            {
                return false;
            }
            return true;
        }
        public bool deleteCTP(string Maphieu)
        {
            string sql = "DELETE FROM dbo.CTPHIEU WHERE Maphieu='" + Maphieu + "'";
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
        public DataTable getAllDsInCTP(string Maphieu)
        {
            string query = "SELECT dbo.DAUSACH.Madausach,dbo.DAUSACH.Tensach,dbo.DAUSACH.Tentacgia,dbo.DAUSACH.NXB,dbo.DAUSACH.Trangthai,dbo.DAUSACH.Gia FROM dbo.DAUSACH, (SELECT Madausach FROM dbo.CTPHIEU WHERE Maphieu='" + Maphieu + "') AS list WHERE dbo.DAUSACH.Madausach=list.Madausach";
            SqlConnection con = dc.getConnect();
            da = new SqlDataAdapter(query, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }


        public bool updateTrangthaiSuco(string Masuco, string Masach, string trangthai)
        {
            string query = "";
            if (trangthai == "Mất sách")
            {
                query = "UPDATE dbo.CTPHIEU SET Masuco='" + Masuco + "' WHERE Madausach='" + Masach + "'";
            }
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


        public bool deleteCTPByMasach(string Masach)
        {
            string query = "DELETE FROM dbo.CTPHIEU WHERE Madausach='" + Masach + "'";
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
    }
}
