using QLTV_OOP.BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
namespace QLTV_OOP.GUI.Quản_lý
{
    public partial class Phieutra : Form
    {
        Quanlyphieutra fqlPT;
        string MAPHIEU;
        string TENNM;
        string NGAYMUON;
        string NGAYHENTRA;
        string NGAYTRA;
        int Sosach;
        int Boithuong;
        DausachBLL dsBLL;
        ChitietphieuBLL ctpBLL;
        PhieumuonBLL pmBLL;
        List<String> listbooktra;
        List<String> listbookchuatra;
        List<String> listbookbiloi;
        SucoBLL suco;
        string Masach;
        public Phieutra()
        {
            InitializeComponent();
        }
        public Phieutra(Quanlyphieutra FQLPT, string maphieu, string tennguoimuon, string ngaymuon, string ngayhentra, int sosach)
        {
            InitializeComponent();
            MAPHIEU = maphieu;
            TENNM = tennguoimuon;
            NGAYMUON = ngaymuon;
            NGAYHENTRA = ngayhentra;
            ctpBLL = new ChitietphieuBLL();
            dsBLL = new DausachBLL();
            pmBLL = new PhieumuonBLL();
            suco = new SucoBLL();
            Sosach = sosach;
            listbooktra = new List<string>();
            listbookchuatra = new List<string>();
            fqlPT = FQLPT;

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
        private void getAllBookhentra()
        {
            DataTable listBooktra = ctpBLL.getAllDsInCTP(MAPHIEU);
            listBookhentra.DataSource = listBooktra;

        }
        private void Addlistchuatra(DataGridView dtgv)
        {
            for (int i = 0; i < dtgv.Rows.Count - 1; i++)
            {
                listbookchuatra.Add(listBookhentra.Rows[i].Cells[1].Value.ToString());
            }
        }
        private void Phieutra_Load(object sender, EventArgs e)
        {
            mpttxtBox.Text = MAPHIEU;
            tnmtxtBOX.Text = TENNM;
            nmDTP.Value = Convert.ToDateTime(NGAYMUON);
            nhtDTP.Value = Convert.ToDateTime(NGAYHENTRA);
            NGAYMUON = convertDate(nmDTP.Value);
            NGAYHENTRA = convertDate(nhtDTP.Value);
            NGAYTRA = convertDate(ntDTP.Value);
            getAllBookhentra();
            Addlistchuatra(listBookhentra);
            listbookbiloi = suco.getMasachInSuco();
            for (int i = 0; i < listBookhentra.Rows.Count - 1; i++)
            {
                if (listbookbiloi.Contains(listBookhentra.Rows[i].Cells[1].Value.ToString()))
                {
                    listBookhentra.Rows[i].ReadOnly = true;
                    listBookhentra.Rows[i].DefaultCellStyle.BackColor = Color.Gray;
                    listBookhentra.Rows[i].Selected = false;
                }
            }
        }
        private bool checkDate()
        {
            string year1 = NGAYMUON.Substring(0, 4);
            string month1 = NGAYMUON.Substring(4, 2);
            string day1 = NGAYMUON.Substring(6, 2);
            string year2 = NGAYTRA.Substring(0, 4);
            string month2 = NGAYTRA.Substring(4, 2);
            string day2 = NGAYTRA.Substring(6, 2);
            if (Convert.ToInt32(year1) > Convert.ToInt32(year2))
            {
                return false;
            }
            if (Convert.ToInt32(year1) == Convert.ToInt32(year2))
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
        private bool checkTramuon()
        {
            string month1 = NGAYHENTRA.Substring(4, 2);
            string day1 = NGAYHENTRA.Substring(6, 2);
            string month2 = NGAYTRA.Substring(4, 2);
            string day2 = NGAYTRA.Substring(6, 2);
            string year1 = NGAYHENTRA.Substring(0, 4);
            string year2 = NGAYTRA.Substring(0, 4);
            if (Convert.ToInt32(year1) < Convert.ToInt32(year2))
            {
                return false;
            }
            else
            {
                if (Convert.ToInt32(month1) < Convert.ToInt32(month2))
                {
                    return false;
                }
                else if (Convert.ToInt32(month1) == Convert.ToInt32(month2))
                {
                    if (Convert.ToInt32(day1) < Convert.ToInt32(day2))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        private void ntDTP_ValueChanged_1(object sender, EventArgs e)
        {
            NGAYTRA = convertDate(ntDTP.Value);
        }

        private void listBookhentra_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            DataGridViewRow row = listBookhentra.Rows[e.RowIndex];
            Masach = row.Cells[1].Value.ToString();
            bool isChoosed = Convert.ToBoolean(row.Cells[0].Value);
            if (isChoosed == false)
            {
                listbooktra.Add(Masach);
                listbookchuatra.Remove(Masach);
            }
            else
            {
                listbooktra.Remove(Masach);
                listbookchuatra.Add(Masach);
            }
        }
        private void traPhieuBtn_Click(object sender, EventArgs e)
        {
            bool checkTradu = true;
            bool isTramuon = false;
            bool checkSuco = false;
            if (checkDate() == false)
            {
                MessageBox.Show("Ngày trả không hơp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (checkTramuon() == true)
                {

                    if (listbooktra.Count != Sosach)
                    {
                        checkTradu = false;
                        foreach (string masachtra in listbooktra)
                        {
                            dsBLL.updateTrangthaiDausach(masachtra, "Chưa mượn");
                            ctpBLL.deleteCTPByMasach(masachtra);
                        }
                    }
                    else if (listbooktra.Count == Sosach)
                    {
                        checkTradu = true;
                        foreach (string sachtra in listbooktra)
                        {
                            dsBLL.updateTrangthaiDausach(sachtra, "Chưa mượn");
                            ctpBLL.deleteCTPByMasach(sachtra);
                            pmBLL.deletePMByMP(MAPHIEU);
                        }
                    }
                    if (checkTradu == false)
                    {
                        if (MessageBox.Show("Trả thiếu sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning) == DialogResult.OK)
                        {
                            fqlPT.Danhsachphieutra();
                            this.Hide();
                        }
                    }
                    else if (checkTradu == true)
                    {
                        if (MessageBox.Show("Trả đủ sách!", "Thông báo", MessageBoxButtons.OK) == DialogResult.OK)
                        {
                            fqlPT.Danhsachphieutra();
                            this.Hide();
                        }
                    }
                }
                else if (checkTramuon() == false)
                {
                    if (listbooktra.Count != Sosach)
                    {
                        checkTradu = false;
                        foreach (string masachtra in listbooktra)
                        {
                            dsBLL.updateTrangthaiDausach(masachtra, "Chưa mượn");
                            ctpBLL.deleteCTPByMasach(masachtra);
                        }
                        foreach (string masachchuatra in listbookchuatra)
                        {
                            int index = -1;
                            foreach (DataGridViewRow row in listBookhentra.Rows)
                            {
                                if (row.Cells[1].Value.ToString().Equals(masachchuatra))
                                {
                                    index = row.Index;
                                    break;
                                }
                            }
                            Boithuong = Convert.ToInt32(listBookhentra.Rows[index].Cells[6].Value.ToString());
                            suco.insertSuco(NGAYTRA, Boithuong);
                            string masuco = suco.getMaSC(NGAYTRA, Boithuong);
                            dsBLL.updateTrangthaiDausach(masachchuatra, "Đã mất");
                            ctpBLL.updateTrangthaiSuco(masuco, masachchuatra, "Mất sách");
                        }

                    }
                    else
                    {
                        checkTradu = true;
                        foreach (string sachtra in listbooktra)
                        {
                            dsBLL.updateTrangthaiDausach(sachtra, "Chưa mượn");
                            ctpBLL.deleteCTPByMasach(sachtra);
                            pmBLL.deletePMByMP(MAPHIEU);
                        }
                    }
                    if (checkTradu == false)
                    {
                        if (MessageBox.Show("Trả muộn và thiếu sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning) == DialogResult.OK)
                        {
                            fqlPT.Danhsachphieutra();
                            this.Hide();
                        }
                    }
                    else
                    {
                        if (MessageBox.Show("Trả muộn và đủ sách!", "Thông báo", MessageBoxButtons.OK) == DialogResult.OK)
                        {
                            fqlPT.Danhsachphieutra();
                            this.Hide();
                        }
                    }
                }
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

