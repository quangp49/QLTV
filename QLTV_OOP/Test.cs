using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLTV_OOP.DTO;
namespace QLTV_OOP
{
    public partial class Test : Form
    {
        NhanvienDTO Nhanvien;
        public Test()
        {
            InitializeComponent();
        }
        public Test(string maNV, string chucvu, string hoten, string ngaysinh, string quequan, string sdt, string maphong)
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

        private void Test_Load(object sender, EventArgs e)
        {
            Console.WriteLine(Nhanvien.MaNV);
            txtMaNV.Text = Nhanvien.MaNV;
            txtHoten.Text = Nhanvien.Hoten;
            txtChucvu.Text = Nhanvien.Chucvu;
            txtNgaysinh.Text = Nhanvien.Ngaysinh;
            txtQuequan.Text = Nhanvien.Quequan;
            txtSdt.Text = Nhanvien.Sdt;
            txtMaphong.Text = Nhanvien.Maphong;
        }
    }
}
