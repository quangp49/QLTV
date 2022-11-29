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
    class NhanvienDAL
    {
        DataConnection dc;
        SqlDataAdapter da;
        SqlCommand cmd;
        public NhanvienDAL()
        {
            dc = new DataConnection();
        }

        public NhanvienDTO getNVByUsername(string Tendangnhap)
        {
            //string query = "SELECT * FROM dbo.NHANVIEN WHERE MaNV=(SELECT MaNV FROM dbo.TAIKHOAN WHERE Tendangnhap = " + Tendangnhap + ")";
            string query = "SELECT * FROM dbo.NHANVIEN WHERE MaNV=(SELECT MaNV FROM dbo.TAIKHOAN WHERE Tendangnhap='"+ Tendangnhap+"')";
            SqlConnection con = dc.getConnect();
            da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            con.Open();
            da.Fill(dt);
            con.Close();
            NhanvienDTO nhanvien = new NhanvienDTO();
            nhanvien.MaNV = dt.Rows[0][0].ToString();
            nhanvien.Chucvu = dt.Rows[0][1].ToString();
            nhanvien.Hoten = dt.Rows[0][2].ToString();
            nhanvien.Ngaysinh = dt.Rows[0][3].ToString();
            nhanvien.Quequan = dt.Rows[0][4].ToString();
            nhanvien.Sdt = dt.Rows[0][5].ToString();
            nhanvien.Maphong = dt.Rows[0][6].ToString();
            return nhanvien;
        }
        public NhanvienDTO getNVByMaNV(string MaNV)
        {
            //string query = "SELECT * FROM dbo.NHANVIEN WHERE MaNV=(SELECT MaNV FROM dbo.TAIKHOAN WHERE Tendangnhap = " + Tendangnhap + ")";
            string query = "SELECT * FROM dbo.NHANVIEN WHERE MaNV='"+MaNV+"'";
            SqlConnection con = dc.getConnect();
            da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            con.Open();
            da.Fill(dt);
            con.Close();
            NhanvienDTO nhanvien = new NhanvienDTO();
            nhanvien.MaNV = dt.Rows[0][0].ToString();
            nhanvien.Chucvu = dt.Rows[0][1].ToString();
            nhanvien.Hoten = dt.Rows[0][2].ToString();
            nhanvien.Ngaysinh = dt.Rows[0][3].ToString();
            nhanvien.Quequan = dt.Rows[0][4].ToString();
            nhanvien.Sdt = dt.Rows[0][5].ToString();
            nhanvien.Maphong = dt.Rows[0][6].ToString();
            return nhanvien;
        }
        public bool updateNV(string MaNV,string Hoten,string Quequan, string Sdt)
        {
            string sql = "UPDATE NHANVIEN SET Hoten=@Hoten,Quequan=@Quequan, Sdt=@Sdt WHERE MaNV=@MaNV";
            SqlConnection connect = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, connect);
                connect.Open();
                cmd.Parameters.Add("@MaNV", SqlDbType.VarChar).Value = MaNV;
                cmd.Parameters.Add("@Hoten", SqlDbType.NVarChar).Value =Hoten;
                cmd.Parameters.Add("@Quequan", SqlDbType.NVarChar).Value = Quequan;
                cmd.Parameters.Add("@Sdt", SqlDbType.VarChar).Value = Sdt;
                cmd.ExecuteNonQuery();
                connect.Close();

            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public List<String> getAllNvNotHasAccount()
        {
            string query = "SELECT * FROM dbo.NHANVIEN, (SELECT MaNV FROM dbo.NHANVIEN EXCEPT SELECT MaNV FROM dbo.TAIKHOAN) AS List WHERE dbo.NHANVIEN.MaNV = List.MaNV";
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
        public bool createNV(TaikhoanDTO account)
        {
            string sql = "INSERT INTO TAIKHOAN(Tendangnhap,Matkhau,MaNV,Quyentruycap) VALUES(@Tendangnhap,@Matkhau,@MaNV,@Quyentruycap)";
            SqlConnection connect = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, connect);
                connect.Open();
                cmd.Parameters.Add("@Tendangnhap", SqlDbType.VarChar).Value = account.Tendangnhap;
                cmd.Parameters.Add("@Matkhau", SqlDbType.NVarChar).Value = account.Matkhau;
                cmd.Parameters.Add("@MaNV", SqlDbType.NVarChar).Value = account.MaNV;
                cmd.Parameters.Add("@Quyentruycap", SqlDbType.NVarChar).Value = account.Quyentruycap;
                cmd.ExecuteNonQuery();
                connect.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public DataTable getAllNvAndQuyentruycap()
        {
            string sql = "SELECT dbo.NHANVIEN.*,dbo.TAIKHOAN.Quyentruycap FROM dbo.NHANVIEN,dbo.TAIKHOAN WHERE dbo.NHANVIEN.MaNV=dbo.TAIKHOAN.MaNV";
            SqlConnection con = dc.getConnect();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable searchNvAndQuyentruycap(string content)
        {
            string sql = "SELECT * FROM(SELECT dbo.NHANVIEN.*, dbo.TAIKHOAN.Quyentruycap FROM dbo.NHANVIEN, dbo.TAIKHOAN WHERE dbo.NHANVIEN.MaNV = dbo.TAIKHOAN.MaNV) AS List WHERE List.MaNV LIKE '%"+content+"%' OR List.Hoten LIKE N'%"+content+"%'";
            SqlConnection con = dc.getConnect();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        //Quang
        public DataTable getAllNhanvien()
        {
            string sql = "SELECT * FROM dbo.NHANVIEN";
            SqlConnection con = dc.getConnect();
            da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            con.Open();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public bool InsertNhanvien(NhanvienDTO account) //Tương tự method "InsertNV" phía trên nhưng dùng cho bảng Danh sách nhân viên
        {
            string sql = "INSERT INTO NHANVIEN(MaNV, TenCV, Hoten, Ngaysinh, Quequan, Sdt, Maphong) VALUES('"+account.MaNV+"', '"+account.Chucvu+"',N'"+account.Hoten+"','"+account.Ngaysinh+"','"+account.Quequan+"','"+account.Sdt+"','"+account.Maphong+"')";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
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
        public bool UpdateNhanvien(NhanvienDTO account) //Tương tự method "updateNV" phía trên nhưng dùng cho bảng Danh sách nhân viên
        {
            string sql = "UPDATE NHANVIEN SET TenCV = '" + account.Chucvu + "', Hoten = N'" + account.Hoten + "', Ngaysinh = '" + account.Ngaysinh + "', Quequan = N'" + account.Quequan + "', Sdt = '" + account.Sdt + "', Maphong = '" + account.Maphong + "' WHERE  MaNV = '" + account.MaNV + "'";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
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
        public bool DeleteNhanvien(NhanvienDTO account)
        {
            string sql = "DELETE NHANVIEN WHERE MaNV = '" + account.MaNV + "'";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
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
        public DataTable FindNhanvien(string account) //Chức năng tương tự như method "searchNguoidoc" ở trên nhưng dùng cho bảng DS Người đọc.
        {
            string sql = "SELECT * FROM NHANVIEN WHERE MaNV like N'%" + account + "%' OR Hoten like N'%" + account + "%' COLLATE Latin1_General_BIN2";
            SqlConnection con = dc.getConnect();
            da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            con.Open();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable GetLuongNV()
        {
            string sql = "SELECT dbo.NHANVIEN.*,dbo.CHUCVU.Luong FROM dbo.NHANVIEN, dbo.CHUCVU WHERE dbo.NHANVIEN.TenCV=dbo.CHUCVU.TenCV";
            SqlConnection con = dc.getConnect();
            da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            con.Open();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public int Tongluongnv()
        {
            string sql = "SELECT SUM(dbo.CHUCVU.Luong) AS 'SUM' FROM dbo.NHANVIEN, dbo.CHUCVU WHERE dbo.NHANVIEN.TenCV=dbo.CHUCVU.TenCV";
            SqlConnection con = dc.getConnect();
            cmd = new SqlCommand(sql, con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            int luong = dr.GetInt32(0);
            con.Close();
            return luong;
        }
        public DataTable FindNhanvienplusLuong(string account) 
        { 
            string sql = "select * from dbo.CHUCVU inner join dbo.NHANVIEN on dbo.CHUCVU.TenCV= dbo.NHANVIEN.TenCV WHERE MaNV like N'%" + account + "%' OR Hoten like N'%" + account + "%' OR Luong like N'%" + account + "%'  COLLATE Latin1_General_BIN2";
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
