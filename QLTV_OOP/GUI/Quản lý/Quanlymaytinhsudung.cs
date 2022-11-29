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
namespace QLTV_OOP.GUI.Quản_lý
{
    public partial class Quanlymaytinhsudung : Form
    {
        MaytinhBLL mtBLL;
        public Quanlymaytinhsudung()
        {
            InitializeComponent();
            mtBLL = new MaytinhBLL();
        }
        private void Quanlymaytinhsudung_Load(object sender, EventArgs e)
        {
            List<String> list = mtBLL.getAllMaphong();
            foreach (string item in list)
            {
                Button btn = new Button();
                btn.Text = item;
                btn.BackColor = Color.White;
                btn.Size = new Size(140, 145);
                btn.Click += new System.EventHandler(this.button_Clicked);
                listRoom.Controls.Add(btn);
            }
        }
        string trangthai;
        string maphong;
        private void button_Clicked(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            DataTable dt = mtBLL.getMTbyMaphong(btn.Text);
            listMT.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
            listMT.DataSource = dt;
            maphong = btn.Text;
            maMTtxtBox.Text = "";
            tenMTtxtBox.Text = "";
            maPhongtxtBox.Text = "";
        }

        private void onBtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(maMTtxtBox.Text) && String.IsNullOrEmpty(tenMTtxtBox.Text) && String.IsNullOrEmpty(maPhongtxtBox.Text))
            {
                MessageBox.Show("Có lỗi xảy ra", "Thông báo", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else if (trangthai == "On")
            {
                MessageBox.Show("Máy tính đang bật");
            }
            else
            {
                if (MessageBox.Show("Bạn có muốn bật máy tính này không?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    if (mtBLL.updateTrangthaiMT(maMTtxtBox.Text, "On"))
                    {
                        DataTable dt = mtBLL.getMTbyMaphong(maPhongtxtBox.Text);
                        listMT.DataSource = dt;
                    }
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra", "Thông báo", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
            }
        }

        private void offBtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(maMTtxtBox.Text) && String.IsNullOrEmpty(tenMTtxtBox.Text) && String.IsNullOrEmpty(maPhongtxtBox.Text))
            {
                MessageBox.Show("Có lỗi xảy ra", "Thông báo", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else if (trangthai == "Off")
            {
                MessageBox.Show("Máy tính đang tắt");
            }
            else
            {
                if (MessageBox.Show("Bạn có muốn tắt máy tính này không?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    if (mtBLL.updateTrangthaiMT(maMTtxtBox.Text, "Off"))
                    {
                        DataTable dt = mtBLL.getMTbyMaphong(maPhongtxtBox.Text);
                        listMT.DataSource = dt;
                    }
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra", "Thông báo", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
            }
        }
        string contentSearch;

        private void searchContent_TextChanged(object sender, EventArgs e)
        {
            contentSearch = searchContent.Text;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(contentSearch))
            {
                DataTable dt = mtBLL.getMTbyMaphong(maPhongtxtBox.Text);
                listMT.DataSource = dt;
            }
            else
            {
                DataTable searchDt = mtBLL.searchMT(maphong, contentSearch);
                listMT.DataSource = searchDt;
            }
        }

        private void listMT_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            trangthai = listMT.Rows[index].Cells["a"].Value.ToString();
            if (index >= 0)
            {
                maMTtxtBox.Text = listMT.Rows[index].Cells["idMT"].Value.ToString();
                tenMTtxtBox.Text = listMT.Rows[index].Cells["nameMT"].Value.ToString();
                maPhongtxtBox.Text = listMT.Rows[index].Cells["b"].Value.ToString();
            }
        }
    }
}
