using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLTV_OOP.BLL;
using QLTV_OOP.DTO;
namespace QLTV_OOP.GUI.Hệ_thống
{
    public partial class DangkyTK : Form
    {
        NhanvienBLL nvBLL;
        public DangkyTK()
        {
            InitializeComponent();
            nvBLL = new NhanvienBLL();
            
        }
        
        private void DangkyTK_Load(object sender, EventArgs e)
        {
            this.ActiveControl = manvCbBox;
            List<String> listMaNV = nvBLL.getAllNvNotHasAccount();
            manvCbBox.DataSource = listMaNV;
            
        }
        string idNv;
        string name;
        string chucvu;
        string username;
        string password;
        private void manvCbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
             idNv = manvCbBox.SelectedItem.ToString();
             name = nvBLL.getNameNV(idNv);
            nametxtBox.Text = name;
        }
        public bool checkAccount()
        {
            if (String.IsNullOrEmpty(usernametxtBox.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (String.IsNullOrEmpty(passwordtxtBox.Text))
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (usernametxtBox.Text.Length > 10)
            {
                usernameLb.Text = "Tên đăng nhập không được quá 10 kí tự";
                if (passwordtxtBox.Text.Length > 10)
                {
                    passwordLb.Text = "Mật khẩu không được quá 10 kí tự";
                }
                else
                {
                    passwordLb.Text = "";
                }
                return false;
            }
            else
            {
                usernameLb.Text = "";
                if (passwordtxtBox.Text.Length <= 10)
                {
                    passwordLb.Text = "";
                }
                else
                {
                    passwordLb.Text = "Mật khẩu không được quá 10 kí tự";
                    return false;
                }
            }
            return true;
        }
        private void createNVBtn_Click(object sender, EventArgs e)
        {
            if (checkAccount())
            {
                if (nvBLL.createNV(idNv, username, password, authCbBox.SelectedItem.ToString()))
                {
                    MessageBox.Show("Tạo tài khoản cho " + name + " thành công", "Thông báo", MessageBoxButtons.OK);
                    List<String> list = nvBLL.getAllNvNotHasAccount();
                    manvCbBox.DataSource = list;
                    manvCbBox.Text = "";
                    nametxtBox.Text = "";
                    usernametxtBox.Text = "";
                    passwordtxtBox.Text = "";
                    authCbBox.Text = "";
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra, vui lòng thử lại", "Thông báo", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
            }
        }

        private void usernametxtBox_TextChanged(object sender, EventArgs e)
        {
            username = usernametxtBox.Text;
        }

        private void passwordtxtBox_TextChanged(object sender, EventArgs e)
        {
            password = passwordtxtBox.Text;
        }
    }
}
