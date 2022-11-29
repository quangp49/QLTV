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
    public partial class Danhsachmaytinh : Form
    {
        MaytinhBLL bllMT;
        public Danhsachmaytinh()
        {
            InitializeComponent();
            bllMT = new MaytinhBLL();
        }
        public void ShowAllMaytinh()
        {
            DataTable dt = bllMT.getAllMaytinh();
            dataGridViewMaytinh.Columns["Ngaynhap"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dataGridViewMaytinh.DataSource = dt;
        }
        private void Danhsachmaytinh_Load(object sender, EventArgs e)
        {
            ShowAllMaytinh();
            Showcbx();
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
        public bool CheckData()
        {
            if (string.IsNullOrEmpty(Mamaytinhtxt.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã máy tính","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                Mamaytinhtxt.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(Tenmaytinhtxt.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên máy tính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                Mamaytinhtxt.Focus();
                return false;
            }
            return true;
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
           
            if (CheckData())
            {
                MaytinhDTO mt = new MaytinhDTO();
                mt.MaMT = Mamaytinhtxt.Text;
                mt.TenMT = Tenmaytinhtxt.Text;
                mt.Ngaynhap = Ngaynhapdtp.Value;
                mt.Trangthai = "Off";
                mt.Maphong = Maphongcbx.Text;

                if(bllMT.InsertMaytinh(mt))
                {
                    ShowAllMaytinh();
                    Mamaytinhtxt.Text = "";
                    Tenmaytinhtxt.Text = "";
                   
                }
                else
                   MessageBox.Show("Đã có lỗi xảy ra, không thể thêm được!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }
        }

        private void Changebtn_Click(object sender, EventArgs e)
        {
            
             MaytinhDTO mt = new MaytinhDTO();
             mt.MaMT = Mamaytinhtxt.Text;
             mt.TenMT = Tenmaytinhtxt.Text;
             mt.Ngaynhap = Ngaynhapdtp.Value;
             mt.Maphong = Maphongcbx.Text;
             
             if (bllMT.UpdateMaytinh(mt))
             {  
                ShowAllMaytinh();
                Mamaytinhtxt.Text = "";
                Tenmaytinhtxt.Text = "";
             }
            else
                 MessageBox.Show("Đã có lỗi xảy ra, không thể sửa được!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa máy tính này?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                var mt = new MaytinhDTO();
                mt.MaMT = Mamaytinhtxt.Text;
                if (bllMT.DeleteMaytinh(mt))
                {
                    ShowAllMaytinh();
                    Mamaytinhtxt.Text = "";
                    Tenmaytinhtxt.Text = "";
                }
                else
                    MessageBox.Show("Đã có lỗi xảy ra, không thể xóa được!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }
        }

        private void dataGridViewMaytinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                Mamaytinhtxt.Text = dataGridViewMaytinh.Rows[index].Cells["MaMT"].Value.ToString();
                Tenmaytinhtxt.Text = dataGridViewMaytinh.Rows[index].Cells["TenMT"].Value.ToString();
                Ngaynhapdtp.Value = DateTime.Parse(dataGridViewMaytinh.Rows[index].Cells["Ngaynhap"].Value.ToString());
                Maphongcbx.Text = dataGridViewMaytinh.Rows[index].Cells["Maphong"].Value.ToString();
            }
        }

        private void Findbtn_Click(object sender, EventArgs e)
        {
            string value = Findtxt.Text;
            if (!string.IsNullOrEmpty(value))
            {
                DataTable dt = bllMT.FindMaytinh(value);
                dataGridViewMaytinh.DataSource = dt;
            }
            else
                ShowAllMaytinh();
        }

        private void dataGridViewMaytinh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
