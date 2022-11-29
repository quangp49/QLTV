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

namespace QLTV_OOP.GUI.Thống_kê
{
    public partial class Thongkesachmuontheongay : Form
    {
        DausachBLL DSbll;
        public Thongkesachmuontheongay()
        {
            InitializeComponent();
            DSbll = new DausachBLL();
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
        private void getAllSachmuontheonggay(string start,string end)
        {
            DataTable dt = DSbll.getAllSachmuontheongay(start, end);
            listbookmuontheongay.Columns[4].DefaultCellStyle.Format = "dd/MM/yyyy";
            listbookmuontheongay.DataSource = dt;
            totalBooktxt.Text = DSbll.getTotalSachmuontheongay(start, end);
        }
        private void Thongkesachmuontheongay_Load(object sender, EventArgs e)
        {
            getAllSachmuontheonggay(convertDate(startDTP.Value), convertDate(endDTP.Value));
        }


        private void searchBtn_Click(object sender, EventArgs e)
        {
            getAllSachmuontheonggay(convertDate(startDTP.Value),convertDate(endDTP.Value));
        }
    }
}
