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
using QLTV_OOP.GUI.Quản_lý;
namespace QLTV_OOP.GUI.Quản_lý
{
    public partial class Chitietphieu : Form
    {
        Quanlyphieumuon fQLPM;
        DausachBLL dsBLL;
        PhieumuonBLL pmBLL;
        NguoidocBLL ndBLL;
        ChitietphieuBLL ctpBLL;
        public Chitietphieu()
        {
            InitializeComponent();
        }
        public Chitietphieu(Quanlyphieumuon fQL)
        {
            InitializeComponent();
            dsBLL = new DausachBLL();
            pmBLL = new PhieumuonBLL();
            ndBLL = new NguoidocBLL();
            ctpBLL = new ChitietphieuBLL();
            fQLPM = fQL;
        }
        string Maphieu;
        string Madausach;
        string Tennguoimuon;
        string Ngaymuon;
        string Ngaytra;
        List<String> listbook = new List<string>();
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
        public void getDS()
        {
            DataGridViewCheckBoxColumn dgvCb = new DataGridViewCheckBoxColumn();
            dgvCb.ValueType = typeof(bool);
            dgvCb.HeaderText = "Chọn sách";
            datagridview.Columns.Add(dgvCb);
            DataTable listBook = dsBLL.getDausach();
            datagridview.DataSource = listBook;
            datagridview.RowHeadersWidth = 60;
            datagridview.Columns[3].Width = 130;
        }
        private void getAllNguoiDoc()
        {
            List<String> listNguoidoc = ndBLL.getAllNguoiDoc();
            tenNguoidocCbb.DataSource = listNguoidoc;
        }
        private void Chitietphieu_Load(object sender, EventArgs e)
        {
            getDS();
            getAllNguoiDoc();
            tenNguoidocCbb.Text = "";
            Ngaymuon = convertDate(ngaymuonDtp.Value);
            Ngaytra = convertDate(ngaytraDtp.Value);
        }
        private void maphieuTxtBox_TextChanged(object sender, EventArgs e)
        {
            Maphieu = maphieuTxtBox.Text;
        }

        private bool checkPM()
        {
            if (String.IsNullOrEmpty(maphieuTxtBox.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã phiếu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (String.IsNullOrEmpty(tenNguoidocCbb.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên người mượn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            List<String> listMP = pmBLL.getMaPhieu();
            if (listMP.Contains(maphieuTxtBox.Text))
            {
                mpLb.Text = "Mã phiếu đã tồn tại";
                return false;
            }
            else
            {
                mpLb.Text = "";
            }
            return true;
        }

        private void tenNguoidocCbb_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Tennguoimuon = tenNguoidocCbb.SelectedItem.ToString();
        }

        private void ngaymuonDtp_ValueChanged_1(object sender, EventArgs e)
        {
            Ngaymuon = convertDate(ngaymuonDtp.Value);
        }

        private void ngaytraDtp_ValueChanged_1(object sender, EventArgs e)
        {
            Ngaytra = convertDate(ngaytraDtp.Value);
        }
        private void datagridview_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            DataGridViewRow row = datagridview.Rows[e.RowIndex];
            Madausach = row.Cells[1].Value.ToString();
            bool isChoosed = Convert.ToBoolean(row.Cells[0].Value);
            if (isChoosed == false)
            {
                listbook.Add(Madausach);
            }
            else
            {
                listbook.Remove(Madausach);
            }
        }
        private bool checkDate()
        {
            string year1 = Ngaymuon.Substring(0, 4);
            string month1 = Ngaymuon.Substring(4, 2);
            string day1 = Ngaymuon.Substring(6, 2);
            string year2 = Ngaytra.Substring(0, 4);
            string month2 = Ngaytra.Substring(4, 2);
            string day2 = Ngaytra.Substring(6, 2);
            if (Convert.ToInt32(year1) > Convert.ToInt32(year2))
            {
                return false;
            }
            if (Convert.ToInt32(year1) <= Convert.ToInt32(year2))
            {
                if (Convert.ToInt32(month1) > Convert.ToInt32(month2))
                {
                    return false;
                }
                else if (Convert.ToInt32(month1) == Convert.ToInt32(month2))
                {
                    if (Convert.ToInt32(day1) > Convert.ToInt32(day2))
                    {
                        return false;
                    }
                }
            }
            return true;
        }


        public bool checkListbook()
        {
            if (listbook.Count == 0)
            {
                MessageBox.Show("Bạn chưa chọn sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void addPhieuBtn_Click_1(object sender, EventArgs e)
        {
            if (checkDate() == false)
            {
                MessageBox.Show("Ngày mượn, ngày trả không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (checkDate() == true && checkListbook() == true && checkPM() == true)
            {
                bool result = false;
                string Manguoidoc = ndBLL.searchNguoidoc(Tennguoimuon);
                if (pmBLL.insertPM(Maphieu, Manguoidoc, Ngaymuon, Ngaytra))
                {
                    foreach (string masach in listbook)
                    {
                        if (ctpBLL.insertCTP(Maphieu, masach) == true)
                        {
                            if (dsBLL.updateTrangthaiDausach(masach, "Đã mượn") == true)
                            {
                                result = true;
                            }
                        }

                    }
                    if (result == true)
                    {
                        if (MessageBox.Show("Thêm phiếu thành công!", "Thông báo", MessageBoxButtons.OK) == DialogResult.OK)
                        {
                            fQLPM.Danhsachphieu();
                            this.Hide();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi xảy ra!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
