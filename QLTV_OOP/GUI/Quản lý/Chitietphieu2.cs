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
    public partial class Chitietphieu2 : Form
    {
        Quanlyphieumuon fPM;
        PhieumuonBLL pmBLL;
        NguoidocBLL ndBLL;
        ChitietphieuBLL ctpBLL;
        DausachBLL dsBLL;
        SucoBLL sucoBLL;
        string MaPhieu;
        string TenNguoimuon;
        string NgayMuon;
        string NgayTra;
        int Sosach;
        string Madausach;
        int index;
        List<String> list = new List<string>();
        List<String> listSachcu = new List<string>();
        List<String> listbookloi = new List<string>();
        public Chitietphieu2()
        {
            InitializeComponent();
        }
        public Chitietphieu2(Quanlyphieumuon fqlpm, string maphieu, string tennguoimuon, string ngaymuon, string ngaytra, int sosach)
        {
            InitializeComponent();
            fPM = fqlpm;
            MaPhieu = maphieu;
            TenNguoimuon = tennguoimuon;
            NgayMuon = ngaymuon;
            NgayTra = ngaytra;
            Sosach = sosach;
            pmBLL = new PhieumuonBLL();
            ndBLL = new NguoidocBLL();
            ctpBLL = new ChitietphieuBLL();
            dsBLL = new DausachBLL();
            sucoBLL = new SucoBLL();
        }
        private void getAllTenNguoiDoc()
        {
            List<String> listNguoidoc = ndBLL.getAllNguoiDoc();
            index = listNguoidoc.IndexOf(TenNguoimuon);
            tnmCbb.DataSource = listNguoidoc;
        }
        public void getBookByMP()
        {
            DataTable dt = pmBLL.getBookByMP(MaPhieu);
            listBookdamuon.DataSource = dt;
        }
        public void getAllSachcu()
        {
            for (int i = 0; i < Sosach; i++)
            {
                DataGridViewRow row = listBookdamuon.Rows[i];
                string Masachcu = row.Cells[1].Value.ToString();
                listSachcu.Add(Masachcu);
            }
        }
        private void Chitietphieu2_Load(object sender, EventArgs e)
        {

            getAllTenNguoiDoc();
            mptxtBox.Text = MaPhieu;
            tnmCbb.SelectedIndex = index;
            nmDtp.Value = Convert.ToDateTime(NgayMuon);
            ntDtp.Value = Convert.ToDateTime(NgayTra);
            getBookByMP();
            for (int i = 0; i < Sosach; i++)
            {
                DataGridViewRow row = listBookdamuon.Rows[i];
                row.Cells[0].Value = true;
            }
            if (listBookdamuon.SelectedRows.Count == 0)
            {
                for (int i = 0; i < Sosach; i++)
                {
                    DataGridViewRow row = listBookdamuon.Rows[i];
                    Madausach = row.Cells[1].Value.ToString();
                    bool isChoosed = Convert.ToBoolean(row.Cells[0].Value);
                    if (isChoosed == true)
                    {
                        list.Add(Madausach);
                    }
                }
            }
            listbookloi = sucoBLL.getMasachInSuco();
            for (int i = 0; i < listBookdamuon.Rows.Count - 1; i++)
            {
                if (listbookloi.Contains(listBookdamuon.Rows[i].Cells[1].Value.ToString()))
                {
                    listBookdamuon.Rows[i].ReadOnly = true;
                    listBookdamuon.Rows[i].DefaultCellStyle.BackColor = Color.Gray;
                    listBookdamuon.Rows[i].Selected = false;
                    updateBtn.Enabled = false;
                    updateBtn.BackColor = Color.Gray;
                }
            }
            getAllSachcu();
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
        private void nmDtp_ValueChanged(object sender, EventArgs e)
        {
            NgayMuon = convertDate(nmDtp.Value);
        }

        private void ntDtp_ValueChanged(object sender, EventArgs e)
        {
            NgayTra = convertDate(ntDtp.Value);
        }

        private bool checkDate()
        {
            string year1 = NgayMuon.Substring(0, 4);
            string month1 = NgayMuon.Substring(4, 2);
            string day1 = NgayMuon.Substring(6, 2);
            string year2 = NgayTra.Substring(0, 4);
            string month2 = NgayTra.Substring(4, 2);
            string day2 = NgayTra.Substring(6, 2);
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

        private void tnmCbb_SelectedIndexChanged(object sender, EventArgs e)
        {
            TenNguoimuon = tnmCbb.SelectedItem.ToString();
        }

        private void listBookdamuon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            else
            {
                DataGridViewRow row = listBookdamuon.Rows[e.RowIndex];
                Madausach = row.Cells[1].Value.ToString();
                bool isChoosed = Convert.ToBoolean(row.Cells[0].Value);
                if (isChoosed == false)
                {
                    list.Add(Madausach);
                }
                else
                {
                    list.Remove(Madausach);
                }
            }
        }
        private void thoatBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (checkDate() == false)
            {
                MessageBox.Show("Ngày mượn, ngày trả không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (checkDate() == true)
            {
                bool result = false;
                string Manguoidoc = ndBLL.searchNguoidoc(TenNguoimuon);
                foreach (string item in listSachcu)
                {
                    dsBLL.updateTrangthaiDausach(item, "Chưa mượn");
                }
                ctpBLL.deleteCTP(MaPhieu);
                if (pmBLL.updatePM(MaPhieu, Manguoidoc, NgayMuon, NgayTra))
                {
                    foreach (string masach in list)
                    {
                        if (ctpBLL.insertCTP(MaPhieu, masach) == true)
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
                            fPM.Danhsachphieu();
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



