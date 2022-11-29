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
    class TaikhoanDAL
    {
        DataConnection dc;
        SqlDataAdapter da;
        SqlCommand cmd;
        public TaikhoanDAL()
        {
            dc = new DataConnection();
        }
        public TaikhoanDTO getTK(string MaNV)
        {
            string query = "SELECT * FROM dbo.TAIKHOAN WHERE MaNV='" + MaNV + "'";
            SqlConnection con = dc.getConnect();
            da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            con.Open();
            da.Fill(dt);
            con.Close();
            TaikhoanDTO account = new TaikhoanDTO();
            account.Tendangnhap = dt.Rows[0][0].ToString();
            account.Matkhau = dt.Rows[0][1].ToString();
            account.MaNV = dt.Rows[0][2].ToString();
            account.Quyentruycap = dt.Rows[0][3].ToString();
            return account;
        }
        public bool updatePW(string MaNV, string password)
        {
            string query = "UPDATE dbo.TAIKHOAN SET Matkhau='"+password+"' WHERE MaNV='"+MaNV+"'";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(query, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }catch(Exception e)
            {
                return false;
            }
            return true;
        }
        public bool updateAuth(string MaNV, string Quyentruycap)
        {
            string query = "UPDATE dbo.TAIKHOAN SET Quyentruycap=N'" + Quyentruycap + "' WHERE MaNV='" + MaNV + "'";
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
