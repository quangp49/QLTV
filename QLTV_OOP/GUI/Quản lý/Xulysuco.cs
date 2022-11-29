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
namespace QLTV_OOP.GUI.Quản_lý
{
    public partial class Xulysuco : Form
    {
        SucoBLL sucoBLL;
        string contentSuco;
        public Xulysuco()
        {
            InitializeComponent();
            sucoBLL = new SucoBLL();
        }
        private void getAllsuco()
        {
            DataTable dt = sucoBLL.getAllSuco();
            listSuco.Columns[6].DefaultCellStyle.Format = "dd/MM/yyyy";
            listSuco.DataSource = dt;
            if (sucoBLL.getAllSuco().Rows.Count != 0)
            {
                mptxtBOX.Text = listSuco.Rows[0].Cells["Maphieu"].Value.ToString();
                tensucotxtBox.Text = listSuco.Rows[0].Cells["Tensuco"].Value.ToString();
                nguoimuontxtBox.Text = listSuco.Rows[0].Cells["Tennguoidoc"].Value.ToString();
                dstxtBox.Text = listSuco.Rows[0].Cells["Madausach"].Value.ToString();
                tensachtxtBox.Text = listSuco.Rows[0].Cells["Maphieu"].Value.ToString();
                boithuongtxtBox.Text = listSuco.Rows[0].Cells["Boithuong"].Value.ToString();
            }
        }
        private void Xulysuco_Load(object sender, EventArgs e)
        {
            getAllsuco();
           
        }

        private void listSuco_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                mptxtBOX.Text = listSuco.Rows[index].Cells["Maphieu"].Value.ToString();
                tensucotxtBox.Text= listSuco.Rows[index].Cells["Tensuco"].Value.ToString();
                nguoimuontxtBox.Text= listSuco.Rows[index].Cells["Tennguoidoc"].Value.ToString();
                dstxtBox.Text= listSuco.Rows[index].Cells["Madausach"].Value.ToString();
                tensachtxtBox.Text=listSuco.Rows[index].Cells["Maphieu"].Value.ToString();
                boithuongtxtBox.Text= listSuco.Rows[index].Cells["Boithuong"].Value.ToString();
            }
        }

        private void searchSucotxt_TextChanged(object sender, EventArgs e)
        {
            contentSuco = searchSucotxt.Text;
        }

        private void searchSucoBtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(searchSucotxt.Text))
            {
                getAllsuco();
            }
            else
            {
                DataTable dt=sucoBLL.findSuco(contentSuco);
                listSuco.DataSource = dt;
            }
        }
    }
}
