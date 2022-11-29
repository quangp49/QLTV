﻿using System;
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
    public partial class Quanlyphieumuon : Form
    {
        PhieumuonBLL pmBLL;
        DausachBLL dsBLL;
        string maphieu;
        string tennguoimuon;
        string ngaymuon;
        string ngaytra;
        int sosach;
        string content;
        bool checkDanhsachphieu;
        public Quanlyphieumuon()
        {
            InitializeComponent();
            pmBLL = new PhieumuonBLL();
            dsBLL = new DausachBLL();
        }
        public void Danhsachphieu()
        {

            checkDanhsachphieu = true;
            DataTable listPM = pmBLL.getALLPM();
            dataGridView1.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
            dataGridView1.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
            dataGridView1.DataSource = listPM;
            if (pmBLL.getALLPM().Rows.Count != 0)
            {
                maphieu = dataGridView1.Rows[0].Cells["Maphieu"].Value.ToString();
                tennguoimuon = dataGridView1.Rows[0].Cells["Tennguoidoc"].Value.ToString();
                ngaymuon = dataGridView1.Rows[0].Cells["Ngaymuon"].Value.ToString();
                ngaytra = dataGridView1.Rows[0].Cells["Ngaytra"].Value.ToString();
                sosach = Convert.ToInt32(dataGridView1.Rows[0].Cells["Sosach"].Value.ToString());
            }
            else
            {
                checkDanhsachphieu = false;
            }

        }
        private void Quanlyphieumuon_Load(object sender, EventArgs e)
        {
            Danhsachphieu();

        }

        private void addPhieuBtn_Click_1(object sender, EventArgs e)
        {
            Chitietphieu fCTP = new Chitietphieu(this);
            fCTP.ShowDialog();
        }

        private void searchtxtb_TextChanged(object sender, EventArgs e)
        {
            content = searchtxtb.Text;
        }
        private void searchInDataGridView()
        {
            if (String.IsNullOrEmpty(content))
            {
                Danhsachphieu();
            }
            else
            {
                DataTable dt = dsBLL.searchDSByTenOrMP(content);
                dataGridView1.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
                dataGridView1.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
                dataGridView1.DataSource = dt;
            }
        }
        private void searchBtn_Click(object sender, EventArgs e)
        {
            searchInDataGridView();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                maphieu = dataGridView1.Rows[index].Cells["Maphieu"].Value.ToString();
                tennguoimuon = dataGridView1.Rows[index].Cells["Tennguoidoc"].Value.ToString();
                ngaymuon = dataGridView1.Rows[index].Cells["Ngaymuon"].Value.ToString();
                ngaytra = dataGridView1.Rows[index].Cells["Ngaytra"].Value.ToString();
                sosach = Convert.ToInt32(dataGridView1.Rows[index].Cells["Sosach"].Value.ToString());
            }
        }

        private void updatePMBtn_Click_1(object sender, EventArgs e)
        {

            if (checkDanhsachphieu == true)
            {
                Chitietphieu2 fCTP2 = new Chitietphieu2(this, maphieu, tennguoimuon, ngaymuon, ngaytra, sosach);
                fCTP2.ShowDialog();
            }
        }
    }


}


