using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLTV_OOP.GUI.Hệ_thống;
using QLTV_OOP.DTO;
using QLTV_OOP.BLL;
namespace QLTV_OOP.GUI.Hệ_thống
{
    public partial class hethongMain : Form
    {
        NhanvienDTO Nhanvien;
        TaikhoanBLL tkBLL;
        public hethongMain()
        {
            InitializeComponent();
        }
        public hethongMain(string maNV, string chucvu, string hoten, string ngaysinh, string quequan, string sdt, string maphong)
        {
            InitializeComponent();
            Nhanvien = new NhanvienDTO();
            tkBLL = new TaikhoanBLL();
            this.Nhanvien.MaNV = maNV;
            this.Nhanvien.Hoten = hoten;
            this.Nhanvien.Chucvu = chucvu;
            this.Nhanvien.Ngaysinh = ngaysinh;
            this.Nhanvien.Quequan = quequan;
            this.Nhanvien.Sdt = sdt;
            this.Nhanvien.Maphong = maphong;
        }
        void HienthiHethong()
        {
            this.hethongPanel.Controls.Clear();
            Thongtintaikhoan fTTTK = new Thongtintaikhoan(Nhanvien.MaNV, Nhanvien.Chucvu, Nhanvien.Hoten, Nhanvien.Ngaysinh, Nhanvien.Quequan, Nhanvien.Sdt, Nhanvien.Maphong);
            fTTTK.TopLevel = false;
            fTTTK.TopMost = true;
            this.hethongPanel.Controls.Add(fTTTK);
            fTTTK.Show();
        }
        private void hethongMain_Load(object sender, EventArgs e)
        {
            TaikhoanDTO tk = tkBLL.getTK(Nhanvien.MaNV);
            if (tk.Quyentruycap == "Nhân viên")
            {
                createUserBtn.Enabled = false;
                authenBtn.Enabled = false;
            }
            HienthiHethong();
        }

        
        private void userInfoBtn_Click_1(object sender, EventArgs e)
        {
            HienthiHethong();
        }

        private void changePwBtn_Click_1(object sender, EventArgs e)
        {
            this.hethongPanel.Controls.Clear();
            DoiMK fDMK = new DoiMK(Nhanvien.MaNV, Nhanvien.Hoten);
            fDMK.TopLevel = false;
            fDMK.TopMost = true;
            this.hethongPanel.Controls.Add(fDMK);
            fDMK.Show();
        }

        private void createUserBtn_Click_1(object sender, EventArgs e)
        {
            this.hethongPanel.Controls.Clear();
            DangkyTK fDK = new DangkyTK();
            fDK.TopLevel = false;
            fDK.TopMost = true;
            this.hethongPanel.Controls.Add(fDK);
            fDK.Show();
        }

        private void authenBtn_Click_1(object sender, EventArgs e)
        {
            this.hethongPanel.Controls.Clear();
            Phanquyen fPQ = new Phanquyen();
            fPQ.TopLevel = false;
            fPQ.TopMost = true;
            this.hethongPanel.Controls.Add(fPQ);
            fPQ.Show();
        }
    }
}
