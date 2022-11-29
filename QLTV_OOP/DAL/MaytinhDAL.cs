using QLTV_OOP.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace QLTV_OOP.DAL
{
    class MaytinhDAL
    {
        DataConnection dc;
        SqlDataAdapter da;
        SqlCommand cmd;
        public MaytinhDAL()
        {
            dc = new DataConnection();
        }
        public DataTable getAllMaytinh()
        {
            string sql = "SELECT * FROM dbo.MAYTINH";
            SqlConnection con = dc.getConnect();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public bool InsertMaytinh(MaytinhDTO mt)
        {
            string sql = "INSERT INTO dbo.MAYTINH(MaMT,TenMT,Ngaynhap,Trangthai,Maphong) VALUES(@MaMT,@TenMT,@Ngaynhap,@Trangthai,@Maphong)";
            SqlConnection con = dc.getConnect();  
            try
            {
                cmd = new SqlCommand(sql,con);
                con.Open();
                cmd.Parameters.Add("@MaMT", SqlDbType.VarChar).Value = mt.MaMT;
                cmd.Parameters.Add("@TenMT", SqlDbType.VarChar).Value = mt.TenMT;
                cmd.Parameters.Add("@Ngaynhap", SqlDbType.Date).Value = mt.Ngaynhap;
                cmd.Parameters.Add("@Trangthai", SqlDbType.NVarChar).Value = mt.Trangthai;
                cmd.Parameters.Add("@Maphong", SqlDbType.VarChar).Value = mt.Maphong;
                cmd.ExecuteNonQuery();
                con.Close();

            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
        public bool UpdateMaytinh(MaytinhDTO mt)
        {
            string sql = "UPDATE dbo.MAYTINH SET TenMT=@TenMT,Ngaynhap=@Ngaynhap,Maphong=@Maphong WHERE MaMT=@MaMT";    
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MaMT", SqlDbType.VarChar).Value = mt.MaMT;
                cmd.Parameters.Add("@TenMT", SqlDbType.VarChar).Value = mt.TenMT;
                cmd.Parameters.Add("@Ngaynhap", SqlDbType.Date).Value = mt.Ngaynhap;
                cmd.Parameters.Add("@Maphong", SqlDbType.VarChar).Value = mt.Maphong;
                cmd.ExecuteNonQuery();
                con.Close();

            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
        public bool DeleteMaytinh(MaytinhDTO mt)
        {
            string sql = "DELETE dbo.MAYTINH WHERE MaMT=@MaMT";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MaMT", SqlDbType.VarChar).Value = mt.MaMT;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
        public DataTable FindMaytinh(string s)
        {
            string sql = "SELECT * FROM dbo.MAYTINH WHERE TenMT like N'%" + s + "%'";
            SqlConnection con = dc.getConnect();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }

        public List<String> getAllMaPhong()
        {
            string query = "SELECT DISTINCT Maphong FROM dbo.MAYTINH ";
            SqlConnection con = dc.getConnect();
            da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            con.Open();
            da.Fill(dt);
            con.Close();
            List<String> list = new List<string>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                list.Add(dt.Rows[i][0].ToString());
            }
            return list;
        }
        public DataTable getMTbyMaphong(string Maphong)
        {
            string query = "SELECT * FROM dbo.MAYTINH WHERE Maphong='"+Maphong+"'";
            SqlConnection con = dc.getConnect();
            da = new SqlDataAdapter(query, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public bool updateTrangthaiMT(string MaMT, string trangthai)
        {
            string sql = "UPDATE dbo.MAYTINH SET Trangthai=@trangthai WHERE MaMT=@MaMT";
            SqlConnection connect = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, connect);
                connect.Open();
                cmd.Parameters.Add("@trangthai", SqlDbType.NVarChar).Value = trangthai;
                cmd.Parameters.Add("@MaMT", SqlDbType.VarChar).Value = MaMT;
                cmd.ExecuteNonQuery();
                connect.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public DataTable searchMT(string Maphong,string content)
        {
            
            string sql = "SELECT* FROM(SELECT* FROM dbo.MAYTINH WHERE Maphong= '"+Maphong+"') AS ListMT WHERE ListMT.TenMT LIKE '%"+content+"%' ";
            SqlConnection con = dc.getConnect();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        
    }
}
