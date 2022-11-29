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
namespace QLTV_OOP.GUI
{
    public partial class Login : Form
    {
        LoginBLL loginBll;
        NhanvienBLL nvBll;
        public Login()
        {
            InitializeComponent();
            loginBll = new LoginBLL();
            nvBll = new NhanvienBLL();
        }
        private void loginQLTV()
        {
            LoginDTO account = new LoginDTO();
            account.Tendangnhap = usertxtBox.Text;
            account.Matkhau = passwordtxtBox.Text;
            if (loginBll.Login(account))
            {
                NhanvienDTO nhanvien = nvBll.getNVByUsername(account.Tendangnhap);
                string month;
                string date;
                string year;
                string[] arr = nhanvien.Ngaysinh.Substring(0, 10).Split('/');
                month = arr[0];
                date = arr[1];
                year = arr[2];
                string dateOfBirth = date + "/" + month + "/" + year;
                Main fMain = new Main(nhanvien.MaNV, nhanvien.Chucvu, nhanvien.Hoten, dateOfBirth, nhanvien.Quequan, nhanvien.Sdt, nhanvien.Maphong);
                this.Hide();
                fMain.Show();

            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void usertxtBox_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (String.IsNullOrEmpty(passwordtxtBox.Text))
                {
                    MessageBox.Show("Bạn chưa nhập mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    loginQLTV();
                }
            }
        }

        private void passwordtxtBox_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (String.IsNullOrEmpty(usertxtBox.Text))
                {
                    MessageBox.Show("Bạn chưa nhập tên đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    loginQLTV();
                }
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            loginQLTV();
        }

        private void exittxtBox_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn thoát chương trình không?","Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Application.Exit();
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


        
    }
}
