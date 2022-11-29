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
    public partial class Danhsachphongdoc : Form
    {
        //dataGridView1 là tên bảng hiển thị các thông tin
        PhongdocBLL pdBLL;
        string tgdong;
        string tgmo;
        List<String> listMPdatontai;
        public Danhsachphongdoc() //Khởi tạo
        {
            InitializeComponent();
            pdBLL = new PhongdocBLL();
            listMPdatontai = new List<string>();
        }
        public void showAllpd() //Hiển thị các thông tin trong database
        {
            DataTable dt = pdBLL.getAllMaphong();
            dataGridView1.DataSource = dt;
        }
        private void Danhsachphongdoc_Load(object sender, EventArgs e)
        {
            showAllpd();
            listMPdatontai = pdBLL.getMaphong();
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
            if (String.IsNullOrEmpty(mpdtxt.Text) || String.IsNullOrEmpty(scstxt.Text) || String.IsNullOrEmpty(scmttxt.Text) || String.IsNullOrEmpty(tgmtxt.Text) || String.IsNullOrEmpty(tgdtxt.Text))
            {
                MessageBox.Show("Bạn chưa nhập thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if((IsNumeric(scstxt.Text)) == false)
            {
                MessageBox.Show("Sức chứa sách phải là một số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (listMPdatontai.Contains(mpdtxt.Text))
            {
                MessageBox.Show("Mã phòng đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if ((IsNumeric(scmttxt.Text)) == false)
            {
                MessageBox.Show("Sức chứa máy tính phải là một số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                MessageBox.Show("Cập nhật thông tin thành công", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                return true;
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                PhongdocDTO phongdoc = new PhongdocDTO();
                phongdoc.Maphong = mpdtxt.Text;
                phongdoc.Succhuasach = Int32.Parse(scstxt.Text);
                phongdoc.Suchuamaytinh = Int32.Parse(scmttxt.Text);
                phongdoc.Thoigianmo = tgmo;
                phongdoc.Thoigiandong = tgdong;
                if (pdBLL.InsertPhongdoc(phongdoc))
                {
                    showAllpd();
                    mpdtxt.Text = "";
                    scmttxt.Text = "";
                    scstxt.Text = "";
                    slmttxt.Text = "";
                    slstxt.Text = "";
                }
                else
                    MessageBox.Show("Đã có lỗi xảy ra", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                PhongdocDTO phongdoc = new PhongdocDTO();
                phongdoc.Maphong = mpdtxt.Text;
                phongdoc.Succhuasach = Int32.Parse(scstxt.Text);
                phongdoc.Suchuamaytinh = Int32.Parse(scmttxt.Text);
                phongdoc.Thoigianmo = tgmo;
                phongdoc.Thoigiandong = tgdong;
                if (pdBLL.UpdatePhongdoc(phongdoc))
                    showAllpd();
                else
                    MessageBox.Show("Đã có lỗi xảy ra", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc muốn xoá phòng đọc này hay không?", "Cảnh bảo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                PhongdocDTO phongdoc = new PhongdocDTO();
                phongdoc.Maphong = mpdtxt.Text;
                if (pdBLL.DeletePhongdoc(phongdoc))
                    showAllpd();
                else
                    MessageBox.Show("Đã có lỗi xảy ra", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                mpdtxt.Text = dataGridView1.Rows[index].Cells["Maphong"].Value.ToString();
                scstxt.Text = dataGridView1.Rows[index].Cells["Succhuasach"].Value.ToString();
                scmttxt.Text = dataGridView1.Rows[index].Cells["Suchuamaytinh"].Value.ToString();
                tgmtxt.Text = dataGridView1.Rows[index].Cells["Thoigianmo"].Value.ToString();
                tgdtxt.Text = dataGridView1.Rows[index].Cells["Thoigiandong"].Value.ToString();
                slstxt.Text = dataGridView1.Rows[index].Cells["Soluongsach"].Value.ToString();
                slmttxt.Text = dataGridView1.Rows[index].Cells["Soluongmaytinh"].Value.ToString();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private string convertTime(DateTime time)
        {
            int hour = time.Hour;
            int minute = time.Minute;
            int second = time.Second;
            return hour.ToString() + ":" + minute.ToString() + ":" + second.ToString();
        }
        private void tgmtxt_ValueChanged(object sender, EventArgs e)
        {
            tgmo = convertTime(tgmtxt.Value);
        }

        private void tgdtxt_ValueChanged(object sender, EventArgs e)
        {
            tgdong = convertTime(tgdtxt.Value);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                showAllpd();
            }
            else
            {
                DataTable dt = pdBLL.searchPhongdoc(textBox1.Text);
                dataGridView1.DataSource = dt;
            }
        }
    }
}