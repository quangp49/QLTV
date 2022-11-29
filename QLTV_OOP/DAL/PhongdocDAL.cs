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
    internal class PhongdocDAL
    {
        DataConnection dc;
        SqlDataAdapter da;
        SqlCommand cmd;
        public PhongdocDAL()
        {
            dc = new DataConnection();
        }
        public DataTable getAllMaphong()
        {
            //Tạo câu lệnh để lấy Maphong từ bảng PHONGDOC
            string sql = "SELECT p.*,(SELECT COUNT(*) FROM dbo.DAUSACH d WHERE d.Maphong = p.Maphong) AS Soluongsach,(SELECT COUNT(*) FROM dbo.MAYTINH m WHERE m.Maphong = p.Maphong) AS Soluongmaytinh FROM dbo.PHONGDOC p";
            // Tạo một kết nối đến Sql
            SqlConnection con = dc.getConnect();
            //Khởi tạo đối tượng của lớp SqlDataAdapter
            da = new SqlDataAdapter(sql, con);
            //Mở kết nối
            con.Open();
            //Đổ dữ liệu từ SqlDataAdapter vào SqlDataTable
            DataTable dt = new DataTable();
            da.Fill(dt);
            //Đóng kết nối 
            con.Close();
            return dt;
        }
        public bool InsertPhongdoc(PhongdocDTO phongdoc)
        {
            string sql = "INSERT INTO PHONGDOC(Maphong, Succhuasach, Suchuamaytinh, Thoigianmo, Thoigiandong) VALUES(@Maphong, @Succhuasach, @Suchuamaytinh, @Thoigianmo, @Thoigiandong)";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@Maphong", SqlDbType.VarChar).Value = phongdoc.Maphong;
                cmd.Parameters.Add("@Succhuasach", SqlDbType.Int).Value = phongdoc.Succhuasach;
                cmd.Parameters.Add("@Suchuamaytinh", SqlDbType.Int).Value = phongdoc.Suchuamaytinh;
                cmd.Parameters.Add("@Thoigianmo", SqlDbType.Time).Value = phongdoc.Thoigianmo;
                cmd.Parameters.Add("@Thoigiandong", SqlDbType.Time).Value = phongdoc.Thoigiandong;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public bool UpdatePhongdoc(PhongdocDTO phongdoc)
        {
            string sql = "UPDATE PHONGDOC SET Succhuasach = @Succhuasach, Suchuamaytinh = @Suchuamaytinh, Thoigianmo = @Thoigianmo, Thoigiandong = @Thoigiandong WHERE Maphong = @Maphong";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@Maphong", SqlDbType.VarChar).Value = phongdoc.Maphong;
                cmd.Parameters.Add("@Succhuasach", SqlDbType.Int).Value = phongdoc.Succhuasach;
                cmd.Parameters.Add("@Suchuamaytinh", SqlDbType.Int).Value = phongdoc.Suchuamaytinh;
                cmd.Parameters.Add("@Thoigianmo", SqlDbType.Time).Value = phongdoc.Thoigianmo;
                cmd.Parameters.Add("@Thoigiandong", SqlDbType.Time).Value = phongdoc.Thoigiandong;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public bool DeletePhongdoc(PhongdocDTO phongdoc)
        {
            string sql = "DELETE PHONGDOC WHERE Maphong = @Maphong";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@Maphong", SqlDbType.VarChar).Value = phongdoc.Maphong;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public DataTable searchPhongdoc(string search)
        {
            string sql = "SELECT p.*,(SELECT COUNT(*) FROM dbo.DAUSACH d WHERE d.Maphong = p.Maphong) AS Soluongsach, (SELECT COUNT(*) FROM dbo.MAYTINH m WHERE m.Maphong = p.Maphong) AS Soluongmaytinh FROM dbo.PHONGDOC p WHERE  p.Maphong LIKE '%"+search+"%'";
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
