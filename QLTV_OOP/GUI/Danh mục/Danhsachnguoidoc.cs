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
using QLTV_OOP.DAL;
using QLTV_OOP.DTO;

namespace QLTV_OOP.GUI.Danh_mục
{
    public partial class Danhsachnguoidoc : Form
    {
        NguoidocBLL ndBLL;
        public Danhsachnguoidoc()
        {
            InitializeComponent();
            ndBLL = new NguoidocBLL();
        }
        public void showAllnd()
        {
            DataTable dt = ndBLL.ToDataTable();
            dataGridView1.DataSource = dt;
        }

        private void Danhsachnguoidoc_Load(object sender, EventArgs e)
        {
            showAllnd();
        }

        public bool CheckData() //Kiểm tra người dùng đã nhập thông tin vào các textbox chưa
        {
            if (String.IsNullOrEmpty(mndtxt.Text) || String.IsNullOrEmpty(httxt.Text) || String.IsNullOrEmpty(nstxt.Text) || String.IsNullOrEmpty(sdttxt.Text) || String.IsNullOrEmpty(ltxt.Text))
            {
                MessageBox.Show("Bạn chưa nhập thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                MessageBox.Show("Cập nhật thông tin thành công", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                return true;
            }
        }

        private void them_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                NguoidocDTO nguoidoc = new NguoidocDTO();
                nguoidoc.Manguoidoc = mndtxt.Text;
                nguoidoc.Tennguoidoc = httxt.Text;
                nguoidoc.Ngaysinh = nstxt.Value;
                nguoidoc.Sdt = sdttxt.Text;
                nguoidoc.Lop = ltxt.Text;
                if (ndBLL.InsertNguoidoc(nguoidoc))
                    showAllnd();
                else
                    MessageBox.Show("Đã có lỗi xảy ra", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void sua_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                NguoidocDTO nguoidoc = new NguoidocDTO();
                nguoidoc.Manguoidoc = mndtxt.Text;
                nguoidoc.Tennguoidoc = httxt.Text;
                nguoidoc.Ngaysinh = nstxt.Value;
                nguoidoc.Sdt = sdttxt.Text;
                nguoidoc.Lop = ltxt.Text;
                if (ndBLL.UpdateNguoidoc(nguoidoc))
                    showAllnd();
                else
                    MessageBox.Show("Đã có lỗi xảy ra", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xoá người đọc này hay không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                NguoidocDTO nguoidoc = new NguoidocDTO();
                nguoidoc.Manguoidoc = mndtxt.Text;
                if (ndBLL.DeleteNguoidoc(nguoidoc))
                    showAllnd();
                else
                    MessageBox.Show("Đã có lỗi xảy ra", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                mndtxt.Text = dataGridView1.Rows[index].Cells["Manguoidoc"].Value.ToString();
                httxt.Text = dataGridView1.Rows[index].Cells["hoten"].Value.ToString();
                nstxt.Text = dataGridView1.Rows[index].Cells["Ngaysinh"].Value.ToString();
                sdttxt.Text = dataGridView1.Rows[index].Cells["Sdt"].Value.ToString();
                ltxt.Text = dataGridView1.Rows[index].Cells["Lop"].Value.ToString();
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string value = searchtxt.Text;
            if (!string.IsNullOrEmpty(value))
            {
                DataTable dt = ndBLL.FindNguoidoc(value);
                dataGridView1.DataSource = dt;
            }
            else
                showAllnd();
        }

    }
}
