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
    public partial class thongkeMain : Form
    {
        public thongkeMain()
        {
            InitializeComponent();
        }
        void HienthiThongke()
        {
            this.thongkePanel.Controls.Clear();
            LuongNV lnv = new LuongNV();
            lnv.TopLevel = false;
            lnv.TopMost = true;
            this.thongkePanel.Controls.Add(lnv);
            lnv.Show();
        }
        private void thongkeMain_Load(object sender, EventArgs e)
        {
            HienthiThongke(); 
        }

        private void LuongNVbtn_Click(object sender, EventArgs e)
        {
            HienthiThongke();
        }

        private void errorBtn_Click(object sender, EventArgs e)
        {
            this.thongkePanel.Controls.Clear();
            Thongkesachmuontheongay fTKSM = new Thongkesachmuontheongay();
            fTKSM.TopLevel = false;
            fTKSM.TopMost = true;
            this.thongkePanel.Controls.Add(fTKSM);
            fTKSM.Show();
        }
    }
}
