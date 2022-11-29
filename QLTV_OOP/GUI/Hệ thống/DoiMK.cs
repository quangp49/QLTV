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
using QLTV_OOP.BLL;
namespace QLTV_OOP.GUI.Hệ_thống
{
    public partial class DoiMK : Form
    {
        NhanvienDTO Nhanvien;
        TaikhoanBLL tkBll;
        string oldPassword;
        public DoiMK()
        {
            InitializeComponent();
        }
        public DoiMK(string MaNV,string Hoten)
        {
            InitializeComponent();
            Nhanvien = new NhanvienDTO();
            tkBll = new TaikhoanBLL();
            Nhanvien.MaNV = MaNV;
            Nhanvien.Hoten = Hoten;
            oldPassword = tkBll.getTK(Nhanvien.MaNV).Matkhau;
        }

        private void DoiMK_Load(object sender, EventArgs e)
        {
            manvtxtBox.Text = Nhanvien.MaNV;
            hotentxtBox.Text = Nhanvien.Hoten;
        }
        public bool checkPassWord()
        {
            if (string.IsNullOrEmpty(oldpwtxtBox.Text))
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu cũ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (string.IsNullOrEmpty(newpwtxtBox.Text))
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                newpwtxtBox.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(resetpwtxtBox.Text))
            {
                MessageBox.Show("Bạn chưa nhập lại mật khẩu mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                resetpwtxtBox.Focus();
                return false;
            }
            if (oldpwtxtBox.Text != oldPassword)
            {
                oldpwLb.Text = "Mật khẩu cũ không đúng";
                if (newpwtxtBox.Text == resetpwtxtBox.Text)
                {
                    newpwLb.Text = "";
                }
                else {
                    newpwLb.Text = "Nhập lại mật khẩu mới chưa chính xác";
                }
                return false;
            }
            else
            {
                oldpwLb.Text = "";
                if (newpwtxtBox.Text == resetpwtxtBox.Text)
                {
                    newpwLb.Text = "";
                }
                else
                {
                    newpwLb.Text = "Nhập lại mật khẩu mới chưa chính xác";
                    return false;
                }
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkPassWord())
            {
                if(tkBll.updatePW(Nhanvien.MaNV, newpwtxtBox.Text))
                {
                    MessageBox.Show("Cập nhật tài khoản thành công","Thông báo", MessageBoxButtons.OK);
                    oldpwtxtBox.Text = "";
                    newpwtxtBox.Text = "";
                    resetpwtxtBox.Text = "";
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại, vui lòng thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
