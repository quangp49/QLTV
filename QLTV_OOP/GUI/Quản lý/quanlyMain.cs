using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV_OOP.GUI.Quản_lý
{
    public partial class quanlyMain : Form
    {
        public quanlyMain()
        {
            InitializeComponent();
        }

        void HienthiQuanly()
        {
            this.quanlyPanel.Controls.Clear();
            Quanlyphieumuon fQLPM = new Quanlyphieumuon();
            fQLPM.TopLevel = false;
            fQLPM.TopMost = true;
            this.quanlyPanel.Controls.Add(fQLPM);
            fQLPM.Show();
        }
        private void quanlyMain_Load(object sender, EventArgs e)
        {
            HienthiQuanly();
        }
        private void qlPhieuBtn_Click_1(object sender, EventArgs e)
        {
            HienthiQuanly();
        }

        private void qlMTBtn_Click_1(object sender, EventArgs e)
        {
            this.quanlyPanel.Controls.Clear();
            Quanlymaytinhsudung fQLMT = new Quanlymaytinhsudung();
            fQLMT.TopLevel = false;
            fQLMT.TopMost = true;
            this.quanlyPanel.Controls.Add(fQLMT);
            fQLMT.Show();
        }

        private void errorBtn_Click_1(object sender, EventArgs e)
        {
            this.quanlyPanel.Controls.Clear();
            Xulysuco fXLSC = new Xulysuco();
            fXLSC.TopLevel = false;
            fXLSC.TopMost = true;
            this.quanlyPanel.Controls.Add(fXLSC);
            fXLSC.Show();
        }

        private void trasachBtn_Click(object sender, EventArgs e)
        {
            this.quanlyPanel.Controls.Clear();
            Quanlyphieutra fQLPT = new Quanlyphieutra();
            fQLPT.TopLevel = false;
            fQLPT.TopMost = true;
            this.quanlyPanel.Controls.Add(fQLPT);
            fQLPT.Show();
        }
    }
}
