using QLTV_OOP.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV_OOP.GUI.Thống_kê
{
    public partial class LuongNV : Form
    {
        NhanvienBLL bllNV;
        public LuongNV()
        {
            InitializeComponent();
            bllNV = new NhanvienBLL(); 
        }
        public void ShowLuongNV()
        {
            DataTable dt = bllNV.GetLuongNV();
            dataGridViewLuongNV.Columns["Ngaysinh"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dataGridViewLuongNV.DataSource = dt;
        }
        private void LuongNV_Load(object sender, EventArgs e)
        {
            ShowLuongNV();
            Sumtxt.Text = bllNV.TongluongNV().ToString();
        }

        private void Findbtn_Click(object sender, EventArgs e)
        {
            string value = Findtxt.Text;
            if (!string.IsNullOrEmpty(value))
            {
                DataTable dt = bllNV.FindNhanvienplusLuong(value);
                dataGridViewLuongNV.DataSource = dt;
            }
            else
                ShowLuongNV();
        }

       
    }
}
