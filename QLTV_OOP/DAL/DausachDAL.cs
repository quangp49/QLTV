using QLTV_OOP.DTO;
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
    class DausachDAL
    {
        DataConnection dc;
        SqlDataAdapter da;
        SqlCommand cmd;
        public DausachDAL()
        {
            dc = new DataConnection();
        }
        public DataTable getAllDausach()
        {
            string sql = "SELECT * FROM dbo.DAUSACH WHERE Trangthai=N'Chưa mượn'";
            SqlConnection con = dc.getConnect();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public bool InsertDausach(DausachDTO ds)
        {
            string sql = "INSERT INTO dbo.DAUSACH(Madausach,Matuasach,Tensach,Tentacgia,NXB,Gia,Ngaynhap,Maphong,Tinhtrang,Trangthai) VALUES(@Madausach,@Matuasach,@Tensach,@Tentacgia,@NXB,@Gia,@Ngaynhap,@Maphong,@Tinhtrang,@Trangthai)";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@Madausach", SqlDbType.VarChar).Value = ds.Madausach;
                cmd.Parameters.Add("@Matuasach", SqlDbType.VarChar).Value = ds.Matuasach;
                cmd.Parameters.Add("@Tensach", SqlDbType.NVarChar).Value = ds.Tensach;
                cmd.Parameters.Add("@Tentacgia", SqlDbType.NVarChar).Value = ds.Tentacgia;
                cmd.Parameters.Add("@NXB", SqlDbType.NVarChar).Value = ds.NXB;
                cmd.Parameters.Add("@Gia", SqlDbType.Int).Value = ds.Gia;
                cmd.Parameters.Add("@Ngaynhap", SqlDbType.Date).Value = ds.Ngaynhap;
                cmd.Parameters.Add("@Maphong", SqlDbType.VarChar).Value = ds.Maphong;
                cmd.Parameters.Add("@Tinhtrang", SqlDbType.NVarChar).Value = ds.Tinhtrang;
                cmd.Parameters.Add("@Trangthai", SqlDbType.NVarChar).Value = ds.Trangthai;
                cmd.ExecuteNonQuery();
                con.Close();

            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
        public bool UpdateDausach(DausachDTO ds)
        {
            string sql = "UPDATE dbo.DAUSACH SET Tensach=@Tensach, Tentacgia= @Tentacgia,Gia=@Gia,Maphong= @Maphong,Tinhtrang=@Tinhtrang WHERE Madausach = @Madausach AND Matuasach = @Matuasach";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@Madausach", SqlDbType.VarChar).Value = ds.Madausach;
                cmd.Parameters.Add("@Matuasach", SqlDbType.VarChar).Value = ds.Matuasach;
                cmd.Parameters.Add("@Tensach", SqlDbType.NVarChar).Value = ds.Tensach;
                cmd.Parameters.Add("@Tentacgia", SqlDbType.NVarChar).Value = ds.Tentacgia;
                cmd.Parameters.Add("@NXB", SqlDbType.NVarChar).Value = ds.NXB;
                cmd.Parameters.Add("@Gia", SqlDbType.Int).Value = ds.Gia;
                cmd.Parameters.Add("@Ngaynhap", SqlDbType.Date).Value = ds.Ngaynhap;
                cmd.Parameters.Add("@Maphong", SqlDbType.VarChar).Value = ds.Maphong;
                cmd.Parameters.Add("@Tinhtrang", SqlDbType.NVarChar).Value = ds.Tinhtrang;
                cmd.ExecuteNonQuery();
                con.Close();

            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
        public bool DeleteDausach(DausachDTO ds)
        {
            string sql = "DELETE dbo.DAUSACH WHERE Madausach = @Madausach  AND Matuasach = @Matuasach";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@Madausach", SqlDbType.VarChar).Value = ds.Madausach;
                cmd.Parameters.Add("@Matuasach", SqlDbType.VarChar).Value = ds.Matuasach;
                cmd.ExecuteNonQuery();
                con.Close();

            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
        public DataTable FindDausach(string s)
        {
            string sql = "SELECT * FROM dbo.DAUSACH WHERE Tensach like N'%" + s + "%' OR Tentacgia like N'%" + s + "%'";
            SqlConnection con = dc.getConnect();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable getDausach()
        {
            string sql = "SELECT Madausach,Tensach,Tentacgia,NXB,Tinhtrang,Gia FROM dbo.DAUSACH WHERE Trangthai=N'Chưa mượn'";
            SqlConnection con = dc.getConnect();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public bool updateTrangthaiDausach(string Madausach, string Trangthai)
        {
            string sql = "UPDATE dbo.DAUSACH SET Trangthai=N'" + Trangthai + "' WHERE Madausach='" + Madausach + "'";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
        public DataTable ShowAllTuasach()
        {
            string sql = "SELECT TABLE1.Matuasach ,TABLE2.Tensach ,TABLE1.Tentacgia ,TABLE1.NXB ,TABLE1.Gia ,TABLE2.Soluong  FROM(SELECT DISTINCT Matuasach, Tentacgia, NXB, Gia FROM dbo.DAUSACH) AS TABLE1 INNER JOIN(SELECT DISTINCT Matuasach, Tensach, COUNT(*) AS Soluong FROM dbo.DAUSACH GROUP BY Matuasach, Tensach, Tentacgia, NXB, Gia) AS TABLE2 ON TABLE1.Matuasach = TABLE2.Matuasach";
            SqlConnection con = dc.getConnect();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable searchDSByTenOrMP(string content)
        {
            string sql = "SELECT * FROM (SELECT p.Maphieu,n.Tennguoidoc,p.Ngaymuon,p.Ngaytra,(SELECT COUNT(*) FROM dbo.CTPHIEU WHERE p.Maphieu=dbo.CTPHIEU.Maphieu GROUP BY dbo.CTPHIEU.Maphieu) AS Sosach FROM dbo.PHIEUMUON p, dbo.NGUOIDOC n WHERE p.Manguoidoc = n.Manguoidoc) AS list WHERE list.Tennguoidoc LIKE N'%" + content + "%' OR list.Maphieu LIKE N'%" + content + "%' COLLATE Latin1_General_BIN2";
            SqlConnection con = dc.getConnect();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable getAllSachmuontheongay(string start, string end)
        {
            string sql = "SELECT * FROM (SELECT dbo.CTPHIEU.Maphieu,dbo.DAUSACH.Madausach,dbo.DAUSACH.Matuasach,dbo.DAUSACH.Tensach,dbo.PHIEUMUON.Ngaymuon,dbo.DAUSACH.Tentacgia,dbo.DAUSACH.NXB,dbo.DAUSACH.Gia,dbo.DAUSACH.Trangthai FROM dbo.DAUSACH,dbo.CTPHIEU,dbo.PHIEUMUON WHERE dbo.DAUSACH.Madausach = dbo.CTPHIEU.Madausach AND dbo.DAUSACH.Trangthai IN(N'Đã mượn',N'Đã mất') AND dbo.PHIEUMUON.Maphieu = dbo.CTPHIEU.Maphieu) AS A WHERE A.Ngaymuon BETWEEN '" + start + "' AND '" + end + "'";
            SqlConnection con = dc.getConnect();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public string getTotalSachdamuontheongay(string start,string end)
        {
            string query = "SELECT COUNT(*) FROM (SELECT dbo.CTPHIEU.Maphieu,dbo.DAUSACH.Madausach,dbo.DAUSACH.Matuasach,dbo.DAUSACH.Tensach,dbo.PHIEUMUON.Ngaymuon,dbo.DAUSACH.Tentacgia,dbo.DAUSACH.NXB,dbo.DAUSACH.Gia,dbo.DAUSACH.Trangthai FROM dbo.DAUSACH,dbo.CTPHIEU,dbo.PHIEUMUON WHERE dbo.DAUSACH.Madausach = dbo.CTPHIEU.Madausach AND dbo.DAUSACH.Trangthai IN(N'Đã mượn',N'Đã mất') AND dbo.PHIEUMUON.Maphieu = dbo.CTPHIEU.Maphieu) AS A WHERE A.Ngaymuon BETWEEN '" + start + "' AND '" + end + "'";
            SqlConnection con = dc.getConnect();
            da = new SqlDataAdapter(query, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt.Rows[0][0].ToString();
        }
    }
}
