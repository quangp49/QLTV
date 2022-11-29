using QLTV_OOP.BLL;
using QLTV_OOP.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV_OOP.GUI.Danh_mục
{
    
    public partial class Danhsachtuasach : Form
    {
        DausachBLL bllDS;
        public Danhsachtuasach()
        {
            InitializeComponent();
            bllDS = new DausachBLL();
        }

        private void Danhsachtuasach_Load(object sender, EventArgs e)
        {
            dataGridViewTuasach.DataSource = bllDS.ShowAllTuasach();
        }
    }

}
