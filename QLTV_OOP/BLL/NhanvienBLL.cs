using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLTV_OOP.DAL;
using QLTV_OOP.DTO;
namespace QLTV_OOP.BLL
{
    class NhanvienBLL
    {
        NhanvienDAL nvDal;
        public NhanvienBLL()
        {
            nvDal = new NhanvienDAL();
        }
        public NhanvienDTO getNVByUsername(string Tendangnhap)
        {
            return nvDal.getNVByUsername(Tendangnhap);
        }
        public NhanvienDTO getNVByMaNV(string MaNV)
        {
            return nvDal.getNVByMaNV(MaNV);
        }
        public bool updateNV(string MaNV,string Hoten,string Quequan,string Sdt)
        {
            return nvDal.updateNV( MaNV,Hoten,Quequan,Sdt);
        }
        public List<String> getAllNvNotHasAccount()
        {
            return nvDal.getAllNvNotHasAccount();
        }
        public string getNameNV(string MaNV)
        {
            return nvDal.getNVByMaNV(MaNV).Hoten;
        }
        public bool createNV(string MaNV,string username,string password,string auth)
        {
            TaikhoanDTO account = new TaikhoanDTO();
            account.MaNV = MaNV;
            account.Tendangnhap = username;
            account.Matkhau = password;
            account.Quyentruycap = auth;
            return nvDal.createNV(account);
        }
        public DataTable getAllNvAndQuyentruycap()
        {
            return nvDal.getAllNvAndQuyentruycap();
        }
        public DataTable searchNvAndQuyentruycap(string content)
        {
            return nvDal.searchNvAndQuyentruycap(content);
        }
        public DataTable getAllNhanvien()
        {
            return nvDal.getAllNhanvien();
        } 
        public bool InsertNhanvien(NhanvienDTO account)
        {
            return nvDal.InsertNhanvien(account);
        }
        public bool UpdateNhanvien(NhanvienDTO account)
        {
            return nvDal.UpdateNhanvien(account);
        }
        public bool DeleteNhanvien(NhanvienDTO account)
        {
            return nvDal.DeleteNhanvien(account);
        }
        public DataTable FindNhanvien(string account)
        {
            return nvDal.FindNhanvien(account);
        }
        public DataTable GetLuongNV()
        {
            return nvDal.GetLuongNV();
        }
        public int TongluongNV()
        {
            return nvDal.Tongluongnv();
        }
        public DataTable FindNhanvienplusLuong(string account)
        {
            return nvDal.FindNhanvienplusLuong(account);
        }
    }
}
