using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLTV_OOP.DTO;
using QLTV_OOP.BLL;
using QLTV_OOP.DAL;
using System.Windows.Forms;

namespace QLTV_OOP.GUI.Hệ_thống
{
    public partial class Thongtintaikhoan : Form
    {
        NhanvienBLL nvBll;
        NhanvienDTO Nhanvien;
        public Thongtintaikhoan()
        {
            InitializeComponent();
            nvBll = new NhanvienBLL();
        }
        public Thongtintaikhoan(string maNV, string chucvu, string hoten, string ngaysinh, string quequan, string sdt, string maphong)
        {
            InitializeComponent();
            nvBll = new NhanvienBLL();
            Nhanvien = new NhanvienDTO();
            this.Nhanvien.MaNV = maNV;
            this.Nhanvien.Hoten = hoten;
            this.Nhanvien.Chucvu = chucvu;
            this.Nhanvien.Ngaysinh = ngaysinh;
            this.Nhanvien.Quequan = quequan;
            this.Nhanvien.Sdt = sdt;
            this.Nhanvien.Maphong = maphong;
        }
        private void Thongtintaikhoan_Load(object sender, EventArgs e)
        {
            getNVByMaNV(Nhanvien.MaNV);
        }
        public bool checkData()
        {
            if (string.IsNullOrEmpty(comboBox1.Text))
            {
                MessageBox.Show("Bạn chưa nhập quê quán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (string.IsNullOrEmpty(hotentxtBox.Text))
            {
                MessageBox.Show("Bạn chưa nhập họ tên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                hotentxtBox.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(phonetxtBox.Text))
            {
                MessageBox.Show("Bạn chưa nhập số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                phonetxtBox.Focus();
                return false;
            }
            if (phonetxtBox.Text.Length != 10)
            {
                errorMsg.Text = "Số điện thoại phải có 10 chữ số";
                return false;
            }
            if (phonetxtBox.Text.Length == 10)
            {
                errorMsg.Text = "";
                return true;
            }
            return true;
        }
        public void getNVByMaNV(string MaNV)
        {
            NhanvienDTO nhanvien = nvBll.getNVByMaNV(MaNV);
            manvtxtBox.Text = nhanvien.MaNV;
            comboBox1.Text = nhanvien.Quequan;
            hotentxtBox.Text = nhanvien.Hoten;
            string month;
            string date;
            string year;
            string[] arr = nhanvien.Ngaysinh.Substring(0, 10).Split('/');
            month = arr[0];
            date = arr[1];
            year = arr[2];
            string  Birthday = date + "/" + month + "/" + year;
            datetxtBox.Text = Birthday;
            phonetxtBox.Text = nhanvien.Sdt;
            worktxtBox.Text = nhanvien.Chucvu;
            roomtxtBox.Text = nhanvien.Maphong;
        }
        string name;
        string location;
        string phoneNumber;
        private void updateInfoBtn_Click(object sender, EventArgs e)
        {
            if (checkData())
            {
                Nhanvien.Hoten = name;
                Nhanvien.Quequan = location;
                Nhanvien.Sdt = phoneNumber;
                if (nvBll.updateNV(Nhanvien.MaNV,Nhanvien.Hoten,Nhanvien.Quequan,Nhanvien.Sdt) == true)
                {
                    if (MessageBox.Show("Cập nhật thông tin tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        getNVByMaNV(Nhanvien.MaNV);
                    }
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void hotentxtBox_TextChanged(object sender, EventArgs e)
        {
            name = hotentxtBox.Text;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            location = comboBox1.Text;
        }

        private void phonetxtBox_TextChanged(object sender, EventArgs e)
        {
            phoneNumber = phonetxtBox.Text;
        }
    }
}
