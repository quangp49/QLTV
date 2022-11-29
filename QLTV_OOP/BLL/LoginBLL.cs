using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLTV_OOP.DAL;
using QLTV_OOP.DTO;
namespace QLTV_OOP.BLL
{
    class LoginBLL
    {
        LoginDAL loginDal;
        public LoginBLL()
        {
            loginDal = new LoginDAL();
        }
        public bool Login(LoginDTO account)
        {
            return loginDal.Login(account);
        }
    }
}
