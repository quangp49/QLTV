using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLTV_OOP.DTO;

namespace QLTV_OOP.DAL
{
    class LoginDAL
    {
        DataConnection dc;
        SqlCommand dcm;
        public LoginDAL()
        {
            dc = new DataConnection();
        }
        public bool Login(LoginDTO account)
        {
            bool check;
            string strquery = "SELECT TAIKHOAN.Tendangnhap,TAIKHOAN.Matkhau FROM dbo.TAIKHOAN WHERE Tendangnhap='" + account.Tendangnhap + "' AND Matkhau='" + account.Matkhau + "'";
            SqlConnection con = dc.getConnect();
            dcm = new SqlCommand(strquery, con);
            con.Open();
            SqlDataReader dta = dcm.ExecuteReader();
            check = dta.Read();
            con.Close();
            return check;
        }
    }
}
