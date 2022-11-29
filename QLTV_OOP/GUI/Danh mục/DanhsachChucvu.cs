using QLTV_OOP.BLL;
using QLTV_OOP.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV_OOP.GUI.Danh_mục
{
    public partial class DanhsachChucvu : Form
    {
        ChucvuBLL bllCV;
        public DanhsachChucvu()
        {
            InitializeComponent();
            bllCV = new ChucvuBLL();    
        }
        public void ShowAllChucvu()
        {
            dataGridViewChucvu.DataSource = bllCV.ShowAllChucvu();
        }
        bool CheckData()
        {
            if (string.IsNullOrEmpty(MaCVtxt.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã chức vụ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MaCVtxt.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(TenCVtxt.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên chức vụ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TenCVtxt.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(Luongtxt.Text))
            {
                MessageBox.Show("Bạn chưa nhập lương.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Luongtxt.Focus();
                return false;
            }
            if(IsNumeric(Luongtxt.Text) == false)
            {
                MessageBox.Show("Lương phải là một số.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Luongtxt.Focus();
                return false;
            }
            return true;
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
        private void Addbtn_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                ChucvuDTO cv = new ChucvuDTO();
                cv.MaCV = MaCVtxt.Text;
                cv.TenCV = TenCVtxt.Text;   
                cv.Luong = Convert.ToInt32(Luongtxt.Text);
                if (bllCV.InsertChucvu(cv))
                {
                    ShowAllChucvu();
                    MaCVtxt.Text = "";
                    TenCVtxt.Text = "";
                    Luongtxt.Text = "";
                }
                else
                    MessageBox.Show("Trùng tên chức vụ, không thể thêm được!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void DanhsachChucvu_Load(object sender, EventArgs e)
        {
            ShowAllChucvu();
        }

        private void Changebtn_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                ChucvuDTO cv = new ChucvuDTO();
                cv.MaCV = MaCVtxt.Text;
                cv.TenCV = TenCVtxt.Text;
                cv.Luong = Convert.ToInt32(Luongtxt.Text);
                if (bllCV.UpdateChucvu(cv))
                {
                    ShowAllChucvu();
                    MaCVtxt.Text = "";
                    TenCVtxt.Text = "";
                    Luongtxt.Text = "";
                }
                else
                    MessageBox.Show("Đã có lỗi nào đó, không thể sửa được!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa đầu sách này?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                ChucvuDTO cv = new ChucvuDTO();
                cv.TenCV = TenCVtxt.Text;
                if (bllCV.DeleteChucvu(cv))
                {
                    ShowAllChucvu();
                    MaCVtxt.Text = "";
                    TenCVtxt.Text = "";
                    Luongtxt.Text = "";
                }
                else
                    MessageBox.Show("Đã có lỗi nào đó, không thể xóa được!, thử lại sau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void dataGridViewChucvu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if(index >= 0)
            {
                MaCVtxt.Text = dataGridViewChucvu.Rows[index].Cells["MaCV"].Value.ToString();
                TenCVtxt.Text = dataGridViewChucvu.Rows[index].Cells["TenCV"].Value.ToString();
                Luongtxt.Text = dataGridViewChucvu.Rows[index].Cells["Luong"].Value.ToString();

            }
           
        }

        private void Findbtn_Click(object sender, EventArgs e)
        {
            string value = Findtxt.Text;
            if (!string.IsNullOrEmpty(value))
            {
                DataTable dt = bllCV.FindChucvu(value);
                dataGridViewChucvu.DataSource = dt;
            }
            else
                ShowAllChucvu();
        }
    }
}
