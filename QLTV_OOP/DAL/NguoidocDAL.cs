using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLTV_OOP.DTO;
using QLTV_OOP.BLL;

namespace QLTV_OOP.DAL
{
    class NguoidocDAL
    {
        DataConnection dc;
        SqlDataAdapter da;
        SqlCommand cmd;
        public NguoidocDAL()
        {
            dc = new DataConnection();
        }
        public List<String> getAllNguoiDoc()
        {
            string query = "SELECT Tennguoidoc FROM dbo.NGUOIDOC";
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
        public string searchNguoidoc(string name)
        {
            string query = "SELECT Manguoidoc FROM dbo.NGUOIDOC WHERE Tennguoidoc=N'" + name + "'";
            SqlConnection con = dc.getConnect();
            da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            con.Open();
            da.Fill(dt);
            con.Close();
            return dt.Rows[0][0].ToString();
        }
        //Quang
        public DataTable ToDataTable() //Chức năng tương tự method "getAllNguoiDoc" phía trên nhưng trả về dữ liệu dạng DataTable :)
        {
            string sql = "SELECT * FROM dbo.NGUOIDOC";
            SqlConnection con = dc.getConnect();
            da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            con.Open();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public bool InsertNguoidoc(NguoidocDTO nguoidoc)
        {
            string sql = "INSERT INTO NGUOIDOC(Manguoidoc, Tennguoidoc, Ngaysinh, Sdt, Lop) VALUES(@Manguoidoc, @Tennguoidoc, @Ngaysinh, @Sdt, @Lop)";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@Manguoidoc", SqlDbType.VarChar).Value = nguoidoc.Manguoidoc;
                cmd.Parameters.Add("@Tennguoidoc", SqlDbType.NVarChar).Value = nguoidoc.Tennguoidoc;
                cmd.Parameters.Add("@Ngaysinh", SqlDbType.Date).Value = nguoidoc.Ngaysinh;
                cmd.Parameters.Add("@Sdt", SqlDbType.VarChar).Value = nguoidoc.Sdt;
                cmd.Parameters.Add("@Lop", SqlDbType.NVarChar).Value = nguoidoc.Lop;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public bool UpdateNguoidoc(NguoidocDTO nguoidoc)
        {
            string sql = "UPDATE NGUOIDOC SET Tennguoidoc = @Tennguoidoc, Ngaysinh = @Ngaysinh, Sdt = @Sdt, Lop = @Lop WHERE  Manguoidoc = @Manguoidoc";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@Manguoidoc", SqlDbType.VarChar).Value = nguoidoc.Manguoidoc;
                cmd.Parameters.Add("@Tennguoidoc", SqlDbType.NVarChar).Value = nguoidoc.Tennguoidoc;
                cmd.Parameters.Add("@Ngaysinh", SqlDbType.Date).Value = nguoidoc.Ngaysinh;
                cmd.Parameters.Add("@Sdt", SqlDbType.VarChar).Value = nguoidoc.Sdt;
                cmd.Parameters.Add("@Lop", SqlDbType.NVarChar).Value = nguoidoc.Lop;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public bool DeleteNguoidoc(NguoidocDTO nguoidoc)
        {
            string sql = "DELETE NGUOIDOC WHERE Manguoidoc = @Manguoidoc";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@Manguoidoc", SqlDbType.VarChar).Value = nguoidoc.Manguoidoc;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public DataTable FindNguoidoc(string nguoidoc) //Chức năng tương tự như method "searchNguoidoc" ở trên nhưng dùng cho bảng DS Người đọc.
        {
            string sql = "SELECT * FROM NGUOIDOC WHERE Manguoidoc like N'%" + nguoidoc + "%' OR Tennguoidoc like N'%" + nguoidoc + "%' COLLATE Latin1_General_BIN2";
            SqlConnection con = dc.getConnect();
            da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            con.Open();
            da.Fill(dt);
            con.Close();
            return dt;
        }
    }
}
