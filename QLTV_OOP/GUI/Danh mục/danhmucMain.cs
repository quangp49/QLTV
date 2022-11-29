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
    public partial class danhmucMain : Form
    {
        public danhmucMain()
        {
            InitializeComponent();
        }
        void HienthiDanhmuc()
        {
            this.danhmucPanel.Controls.Clear();
            Danhsachnhanvien fDSNV = new Danhsachnhanvien();
            fDSNV.TopLevel = false;
            fDSNV.TopMost = true;
            this.danhmucPanel.Controls.Add(fDSNV);
            fDSNV.Show();
        }
        private void danhmucMain_Load(object sender, EventArgs e)
        {
            HienthiDanhmuc();
        }

        private void dsNVBtn_Click(object sender, EventArgs e)
        {
            HienthiDanhmuc();
        }

    

        private void dsTuasachBtn_Click_1(object sender, EventArgs e)
        {
            this.danhmucPanel.Controls.Clear();
            Danhsachtuasach fDSTS = new Danhsachtuasach();
            fDSTS.TopLevel = false;
            fDSTS.TopMost = true;
            this.danhmucPanel.Controls.Add(fDSTS);
            fDSTS.Show();
        }
        
        private void dsDausachBtn_Click(object sender, EventArgs e)
        {
            this.danhmucPanel.Controls.Clear();
            Danhsachdausach fDSDS = new Danhsachdausach();
            fDSDS.TopLevel = false;
            fDSDS.TopMost = true;
            this.danhmucPanel.Controls.Add(fDSDS);
            fDSDS.Show();
        }
        
        private void dsMTBtn_Click(object sender, EventArgs e)
        {
            this.danhmucPanel.Controls.Clear();
            Danhsachmaytinh fDSMT = new Danhsachmaytinh();
            fDSMT.TopLevel = false;
            fDSMT.TopMost = true;
            this.danhmucPanel.Controls.Add(fDSMT);
            fDSMT.Show();
        }

        private void dsNguoidocBtn_Click(object sender, EventArgs e)
        {
            this.danhmucPanel.Controls.Clear();
            Danhsachnguoidoc fDSND = new Danhsachnguoidoc();
            fDSND.TopLevel = false;
            fDSND.TopMost = true;
            this.danhmucPanel.Controls.Add(fDSND);
            fDSND.Show();
        }

        private void dsPhongBtn_Click_1(object sender, EventArgs e)
        {
            this.danhmucPanel.Controls.Clear();
            Danhsachphongdoc fDSPD = new Danhsachphongdoc();
            fDSPD.TopLevel = false;
            fDSPD.TopMost = true;
            this.danhmucPanel.Controls.Add(fDSPD);
            fDSPD.Show();
        }

        private void chucvuBtn_Click(object sender, EventArgs e)
        {
            this.danhmucPanel.Controls.Clear();
            DanhsachChucvu fDSCV = new DanhsachChucvu();   
            fDSCV.TopLevel = false;
            fDSCV.TopMost = true;
            this.danhmucPanel.Controls.Add(fDSCV);
            fDSCV.Show();
        }
    }
}
