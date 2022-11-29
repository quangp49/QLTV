using QLTV_OOP.BLL;
using QLTV_OOP.DAL;
using QLTV_OOP.DTO;
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

namespace QLTV_OOP.GUI.Danh_mục
{
    public partial class Danhsachdausach : Form
    {
        DausachBLL bllDS;
        public Danhsachdausach()
        {
            InitializeComponent();
            bllDS = new DausachBLL();
        }
        public void ShowAllDausach()
        {
            DataTable dt = bllDS.getAllDausach();
            dataGridViewDausach.Columns["Ngaynhap"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dataGridViewDausach.DataSource = dt;
        }

        private void Danhsachdausach_Load(object sender, EventArgs e)
        {
            ShowAllDausach();
            Showcbx();
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
        public bool CheckData()
        {
            if (string.IsNullOrEmpty(Madausachtxt.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã đầu sách.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Madausachtxt.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(Matuasachtxt.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã tựa sách.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Matuasachtxt.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(Tensachtxt.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên sách.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Tensachtxt.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(Tentacgiatxt.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên tác giả.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Tentacgiatxt.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(NXBtxt.Text))
            {
                MessageBox.Show("Bạn chưa nhập NXB.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NXBtxt.Focus();
                return false;
            }
            if (IsNumeric(Giatxt.Text) == false)
            {
                MessageBox.Show("Giá phải là số.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Giatxt.Focus();
                return false;

            }
            if (string.IsNullOrEmpty(Tinhtrangtxt.Text))
            {
                MessageBox.Show("Bạn chưa nhập tình trạng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Tinhtrangtxt.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(Giatxt.Text))
            {
                MessageBox.Show("Bạn chưa nhập Gia.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Tinhtrangtxt.Focus();
                return false;
            }
            if (DateTime.Compare(Ngaynhapdtp.Value, DateTime.Now) >0)
            {
                MessageBox.Show("Ngày nhập không thỏa đáng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Tinhtrangtxt.Focus();
                return false;
            }

            return true;
        }


        void Showcbx()
        {
            var dc = new DataConnection();
            var con = dc.getConnect();
            var cmd = new SqlCommand("SELECT Maphong FROM dbo.PHONGDOC", con);
            con.Open();
            var dr = cmd.ExecuteReader();
            var dt = new DataTable();

            dt.Load(dr);
            dr.Dispose();
            Maphongcbx.DisplayMember = "Maphong";
            Maphongcbx.DataSource = dt;
            con.Close();

        }

        private void Changebtn_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                DausachDTO ds = new DausachDTO();
                ds.Madausach = Madausachtxt.Text;
                ds.Matuasach = Matuasachtxt.Text;
                ds.Tensach = Tensachtxt.Text;
                ds.Tentacgia = Tentacgiatxt.Text;
                ds.NXB = NXBtxt.Text;
                ds.Gia = Convert.ToInt32(Giatxt.Text);
                ds.Ngaynhap = Ngaynhapdtp.Value;
                ds.Maphong = Maphongcbx.Text;
                ds.Tinhtrang = Tinhtrangtxt.Text;
                if (bllDS.UpdateDausach(ds))
                {
                    ShowAllDausach();
                    Madausachtxt.Text = "";
                    Matuasachtxt.Text = "";
                    Tensachtxt.Text = "";
                    Tentacgiatxt.Text = "";
                    NXBtxt.Text = "";
                    Giatxt.Text = "";
                    Tinhtrangtxt.Text = "";
                }
                else
                    MessageBox.Show("Đã có lỗi, không thể sửa được, hãy thử lại", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                DausachDTO ds = new DausachDTO();
                ds.Madausach = Madausachtxt.Text;
                ds.Matuasach = Matuasachtxt.Text;
                ds.Tensach = Tensachtxt.Text;
                ds.Tentacgia = Tentacgiatxt.Text;
                ds.NXB = NXBtxt.Text;
                ds.Gia = Convert.ToInt32(Giatxt.Text);
                ds.Ngaynhap = Ngaynhapdtp.Value;
                ds.Maphong = Maphongcbx.Text;
                ds.Tinhtrang = Tinhtrangtxt.Text;
                ds.Trangthai = "Chưa mượn";

                if (bllDS.InsertDausach(ds))
                {
                    ShowAllDausach();
                    Madausachtxt.Text = "";
                    Matuasachtxt.Text = "";
                    Tensachtxt.Text = "";
                    Tentacgiatxt.Text = "";
                    NXBtxt.Text = "";
                    Giatxt.Text = "";
                    Tinhtrangtxt.Text = "";
                }
                else
                    MessageBox.Show("Trùng mã đầu sách, không thể thêm được!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

        private void dataGridViewDausach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                Madausachtxt.Text = dataGridViewDausach.Rows[index].Cells["Madausach"].Value.ToString();
                Matuasachtxt.Text = dataGridViewDausach.Rows[index].Cells["Matuasach"].Value.ToString();
                Tensachtxt.Text = dataGridViewDausach.Rows[index].Cells["Tensach"].Value.ToString();
                Tentacgiatxt.Text = dataGridViewDausach.Rows[index].Cells["Tentacgia"].Value.ToString();
                NXBtxt.Text = dataGridViewDausach.Rows[index].Cells["NXB"].Value.ToString();
                Giatxt.Text = dataGridViewDausach.Rows[index].Cells["Gia"].Value.ToString();
                Ngaynhapdtp.Value = DateTime.Parse(dataGridViewDausach.Rows[index].Cells["Ngaynhap"].Value.ToString());
                Maphongcbx.Text = dataGridViewDausach.Rows[index].Cells["Maphong"].Value.ToString();
                Tinhtrangtxt.Text = dataGridViewDausach.Rows[index].Cells["Tinhtrang"].Value.ToString();
            }
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa đầu sách này?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                var ds = new DausachDTO();
                ds.Madausach = Madausachtxt.Text;
                ds.Matuasach = Matuasachtxt.Text;
                if (bllDS.DeleteDausach(ds))
                {
                    ShowAllDausach();
                    Madausachtxt.Text = "";
                    Matuasachtxt.Text = "";
                    Tensachtxt.Text = "";
                    Tentacgiatxt.Text = "";
                    NXBtxt.Text = "";
                    Giatxt.Text = "";
                    Tinhtrangtxt.Text = "";
                }
                else
                    MessageBox.Show("Đã có lỗi, không thể xóa được, thử lại sau", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        

        private void Findbtn_Click(object sender, EventArgs e)
        {
            string value = Findtxt.Text;
            if (!string.IsNullOrEmpty(value))
            {
                DataTable dt = bllDS.FindDausach(value);
                dataGridViewDausach.DataSource = dt;
            }
            else
                ShowAllDausach();
        }

        
    }
}
