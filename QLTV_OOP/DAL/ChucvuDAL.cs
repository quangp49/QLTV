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
    class ChucvuDAL
    {
        DataConnection dc;
        SqlDataAdapter da;
        SqlCommand cmd;
        public ChucvuDAL()
        {
            dc = new DataConnection();
        }
        public DataTable ShowAllChucvu()
        {
            string sql = "SELECT * FROM dbo.CHUCVU";
            var con = dc.getConnect();
            da=new SqlDataAdapter(sql,con);
            con.Open();
            DataTable dt = new DataTable();    
            da.Fill(dt);
            con.Close();  
            return dt;
        }
        public bool InsertChucvu(ChucvuDTO cv)
        {
            string sql = " INSERT INTO dbo.CHUCVU(MaCV,TenCV,Luong) VALUES(@MaCV,@TenCV,@Luong)";
            var con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql,con);
                con.Open();
                cmd.Parameters.Add("@MaCV", SqlDbType.VarChar).Value = cv.MaCV;
                cmd.Parameters.Add("@TenCV", SqlDbType.NVarChar).Value = cv.TenCV;
                cmd.Parameters.Add("@Luong", SqlDbType.Int).Value = cv.Luong;
                cmd.ExecuteNonQuery();
                con.Close ();

            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
        public bool UpdateChucvu(ChucvuDTO cv)
        {
            string sql = " UPDATE dbo.CHUCVU SET MaCV = @MaCV, Luong = @Luong WHERE TenCV=@TenCV";
            var con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MaCV", SqlDbType.VarChar).Value = cv.MaCV;
                cmd.Parameters.Add("@TenCV", SqlDbType.NVarChar).Value = cv.TenCV;
                cmd.Parameters.Add("@Luong", SqlDbType.Int).Value = cv.Luong;
                cmd.ExecuteNonQuery();
                con.Close();

            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
        public bool DeleteChucvu(ChucvuDTO cv)
        {
            string sql = " DELETE dbo.CHUCVU WHERE TenCV=@TenCV";
            var con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@TenCV", SqlDbType.NVarChar).Value = cv.TenCV;
                cmd.ExecuteNonQuery();
                con.Close();

            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
        public DataTable FindChucvu(string s)
        {
            string sql = "SELECT * FROM dbo.CHUCVU Where MaCV like N'%" + s + "%' OR TenCV like N'%" + s + "%' OR Luong like N'%" + s + "%'";
            var con = dc.getConnect();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }

    }
}
