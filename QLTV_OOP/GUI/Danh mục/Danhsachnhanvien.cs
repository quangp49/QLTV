using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLTV_OOP.BLL;
using QLTV_OOP.DAL;
using QLTV_OOP.DTO;

namespace QLTV_OOP.GUI.Danh_mục
{
    public partial class Danhsachnhanvien : Form
    {
        NhanvienBLL nvBLL;
        string NGAYSINH;

        public Danhsachnhanvien()
        {
            InitializeComponent();
            nvBLL = new NhanvienBLL();
        }
        public void showAllnv()
        {
            DataTable dt = nvBLL.getAllNhanvien();
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
            Showcbxmaphong();
            Showcbxchucvu();
        }

        private void Danhsachnhanvien_Load(object sender, EventArgs e)
        {
            showAllnv();
           
        }
        bool IsNumeric(string value)
        {
            try
            {
                int number;
                bool result = int.TryParse(value, out number);
                return result;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool CheckData() //Kiểm tra người dùng đã nhập thông tin vào các textbox chưa
        {
            if (String.IsNullOrEmpty(mnvtxt.Text) || String.IsNullOrEmpty(httxt.Text) || String.IsNullOrEmpty(cvtxt.Text) || String.IsNullOrEmpty(sdttxt.Text) || String.IsNullOrEmpty(nstxt.Text) || String.IsNullOrEmpty(sdttxt.Text) || String.IsNullOrEmpty(qqtxt.Text) || String.IsNullOrEmpty(plvcbb.Text))
            {
                MessageBox.Show("Bạn chưa nhập thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            } 
            if(IsNumeric(sdttxt.Text) == false) 
            {
                MessageBox.Show("Số điện thoại phải là các số.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        void Showcbxmaphong()
        {
            var dc = new DataConnection();
            var con = dc.getConnect();
            var cmd = new SqlCommand("SELECT Maphong FROM dbo.PHONGDOC", con);
            con.Open();
            var dr = cmd.ExecuteReader();
            var dt = new DataTable();

            dt.Load(dr);
            dr.Dispose();
            plvcbb.DisplayMember = "Maphong";
            plvcbb.DataSource = dt;
            con.Close();

        }
        void Showcbxchucvu()
        {
            var dc = new DataConnection();
            var con = dc.getConnect();
            var cmd = new SqlCommand("SELECT TenCV FROM dbo.CHUCVU", con);
            con.Open();
            var dr = cmd.ExecuteReader();
            var dt = new DataTable();

            dt.Load(dr);
            dr.Dispose();
            cvtxt.DisplayMember = "TenCV";
            cvtxt.DataSource = dt;
            con.Close();

        }
        private string convertDate(DateTime date)
        {
            int day = date.Day;
            int month = date.Month;
            int year = date.Year;
            string newDay = "";
            string newMonth = "";
            if (day <= 9)
            {
                newDay = "0" + day.ToString();
            }
            else
            {
                newDay = day.ToString();
            }
            if (month <= 9)
            {
                newMonth = "0" + month.ToString();
            }
            else
            {
                newMonth = month.ToString();
            }
            return year.ToString() + newMonth + newDay;
        }
        private void nstxt_ValueChanged(object sender, EventArgs e)
        {
            NGAYSINH = convertDate(nstxt.Value);
        }
        private void them_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                NhanvienDTO account = new NhanvienDTO();
                account.MaNV = mnvtxt.Text;
                account.Hoten = httxt.Text;
                account.Chucvu = cvtxt.Text;
                account.Sdt = sdttxt.Text;
                account.Ngaysinh = NGAYSINH;
                account.Quequan = qqtxt.Text;
                account.Maphong = plvcbb.Text;
                if (nvBLL.InsertNhanvien(account))
                {
                    MessageBox.Show("Thêm thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    showAllnv();
                }
                else
                { MessageBox.Show("Trùng mã nhân viên, không thể thêm được", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop); }
            }
        }

        private void sua_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                NhanvienDTO account = new NhanvienDTO();
                account.MaNV = mnvtxt.Text;
                account.Hoten = httxt.Text;
                account.Chucvu = cvtxt.Text;
                account.Sdt = sdttxt.Text;
                account.Ngaysinh = NGAYSINH;
                account.Quequan = qqtxt.Text;
                account.Maphong = plvcbb.Text;
                if (nvBLL.UpdateNhanvien(account))
                {
                    MessageBox.Show("Sửa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    showAllnv();
                }
                else
                { MessageBox.Show("Đã có lỗi xảy ra nào đó xảy ra,thử lại sau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop); }
            }
        }
        private void xoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xoá nhân viên này hay không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                NhanvienDTO account = new NhanvienDTO();
                account.MaNV = mnvtxt.Text;
                if (nvBLL.DeleteNhanvien(account))
                {
                    showAllnv();
                    MessageBox.Show("Xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Đã có lỗi  nào đó xảy ra, hãy thử lại sau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                mnvtxt.Text = dataGridView1.Rows[index].Cells["manhanvien"].Value.ToString();
                httxt.Text = dataGridView1.Rows[index].Cells["hoten"].Value.ToString();
                cvtxt.Text = dataGridView1.Rows[index].Cells["chucvu"].Value.ToString();
                sdttxt.Text = dataGridView1.Rows[index].Cells["sdt"].Value.ToString();
                nstxt.Text = dataGridView1.Rows[index].Cells["ngaysinh"].Value.ToString();
                qqtxt.Text = dataGridView1.Rows[index].Cells["quequan"].Value.ToString();
                plvcbb.Text = dataGridView1.Rows[index].Cells["Maphong"].Value.ToString();
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string value = searchtxt.Text;
            if (!string.IsNullOrEmpty(value))
            {
                DataTable dt = nvBLL.FindNhanvien(value);
                dataGridView1.DataSource = dt;
            }
            else
                showAllnv();
        }
    }
}