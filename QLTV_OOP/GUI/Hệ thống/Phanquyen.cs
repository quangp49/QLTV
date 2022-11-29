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
namespace QLTV_OOP.GUI.Hệ_thống
{
    public partial class Phanquyen : Form
    {
        NhanvienBLL nvBLL;
        TaikhoanBLL tkBLL;
        public Phanquyen()
        {
            InitializeComponent();
            nvBLL = new NhanvienBLL();
            tkBLL = new TaikhoanBLL();
        }
        public void showAllNV()
        {
            DataTable dt = nvBLL.getAllNvAndQuyentruycap();
            dataGridView1.DataSource = dt;
        }
        private void Phanquyen_Load(object sender, EventArgs e)
        {
            showAllNV();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                idNvtxtBox.Text = dataGridView1.Rows[index].Cells["MaNV"].Value.ToString();
                nameNVtxtBox.Text = dataGridView1.Rows[index].Cells["Hoten"].Value.ToString();
                worktxtBox.Text = dataGridView1.Rows[index].Cells["TenCV"].Value.ToString();
                phanquyenCbBox.Text = dataGridView1.Rows[index].Cells["Quyentruycap"].Value.ToString();
            }
        }

        private void authBtn_Click(object sender, EventArgs e)
        {
           if(String.IsNullOrEmpty(idNvtxtBox.Text) && String.IsNullOrEmpty(nameNVtxtBox.Text) && String.IsNullOrEmpty(worktxtBox.Text))
            {
                MessageBox.Show("Bạn chưa nhập thông tin", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else
            {
                if (tkBLL.updateAuth(idNvtxtBox.Text, phanquyenCbBox.Text))
                {
                    MessageBox.Show("Phân quyền cho " + nameNVtxtBox.Text + " thành công", "Thông báo", MessageBoxButtons.OK);
                    showAllNV();
                }
                else
                {
                    MessageBox.Show("Phân quyền thất bại, vui lòng thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(searchtxtBox.Text))
            {
                showAllNV();
            }
            else
            {
                DataTable dt2 = nvBLL.searchNvAndQuyentruycap(searchtxtBox.Text);
                dataGridView1.DataSource = dt2;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
