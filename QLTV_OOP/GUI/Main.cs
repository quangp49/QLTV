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
using QLTV_OOP.GUI.Danh_mục;
using QLTV_OOP.GUI.Quản_lý;
using QLTV_OOP.GUI.Thống_kê;
using QLTV_OOP.DTO;
using QLTV_OOP.BLL;
namespace QLTV_OOP.GUI
{
    public partial class Main : Form
    {
        NhanvienDTO Nhanvien;
        public Main()
        {
            InitializeComponent();
        }
        public Main(string maNV, string chucvu, string hoten, string ngaysinh, string quequan, string sdt, string maphong)
        {
            InitializeComponent();
            Nhanvien = new NhanvienDTO();
            this.Nhanvien.MaNV = maNV;
            this.Nhanvien.Hoten = hoten;
            this.Nhanvien.Chucvu = chucvu;
            this.Nhanvien.Ngaysinh = ngaysinh;
            this.Nhanvien.Quequan = quequan;
            this.Nhanvien.Sdt = sdt;
            this.Nhanvien.Maphong = maphong;

        }
        void Hienthi()
        {
            this.containerPanel.Controls.Clear();
            hethongMain ht = new hethongMain(Nhanvien.MaNV,Nhanvien.Chucvu, Nhanvien.Hoten, Nhanvien.Ngaysinh,Nhanvien.Quequan,Nhanvien.Sdt,Nhanvien.Maphong);
            ht.TopLevel = false;
            ht.TopMost = true;
            this.containerPanel.Controls.Add(ht);
            ht.Show();
        }
        private void Main_Load(object sender, EventArgs e)
        {
            Hienthi();
        }

        private void hethongBtn_Click(object sender, EventArgs e)
        {
            Hienthi();
        }

        private void danhmucBtn_Click(object sender, EventArgs e)
        {
            this.containerPanel.Controls.Clear();
            danhmucMain dm = new danhmucMain();
            dm.TopLevel = false;
            dm.TopMost = true;
            this.containerPanel.Controls.Add(dm);
            dm.Show();
        }

        private void quanlyBtn_Click(object sender, EventArgs e)
        {
            this.containerPanel.Controls.Clear();
            quanlyMain ql = new quanlyMain();
            ql.TopLevel = false;
            ql.TopMost = true;
            this.containerPanel.Controls.Add(ql);
            ql.Show();
        }

        private void thongkeBtn_Click(object sender, EventArgs e)
        {
            this.containerPanel.Controls.Clear();
            thongkeMain tk = new thongkeMain();
            tk.TopLevel = false;
            tk.TopMost = true;
            this.containerPanel.Controls.Add(tk);
            tk.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn đăng xuất khỏi tài khoản này?","Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Login fLogin = new Login();
                fLogin.Show();
                this.Hide();
            }
        }
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }

            base.WndProc(ref m);
        }

        private void helpBtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/quangp49");
        }
    }
}
