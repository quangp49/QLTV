
namespace QLTV_OOP.GUI.Danh_mục
{
    partial class Danhsachnguoidoc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.manguoidoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searchBtn = new FontAwesome.Sharp.IconButton();
            this.xoa = new System.Windows.Forms.Button();
            this.sua = new System.Windows.Forms.Button();
            this.searchtxt = new System.Windows.Forms.TextBox();
            this.them = new System.Windows.Forms.Button();
            this.mndlabel = new System.Windows.Forms.Label();
            this.sdtlabel = new System.Windows.Forms.Label();
            this.httxt = new System.Windows.Forms.TextBox();
            this.ltxt = new System.Windows.Forms.TextBox();
            this.llabel = new System.Windows.Forms.Label();
            this.sdttxt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nstxt = new System.Windows.Forms.DateTimePicker();
            this.nslabel = new System.Windows.Forms.Label();
            this.htlabel = new System.Windows.Forms.Label();
            this.mndtxt = new System.Windows.Forms.TextBox();
            this.title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.manguoidoc,
            this.hoten,
            this.ngaysinh,
            this.sdt,
            this.lop});
            this.dataGridView1.Location = new System.Drawing.Point(16, 289);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1167, 269);
            this.dataGridView1.TabIndex = 36;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // manguoidoc
            // 
            this.manguoidoc.DataPropertyName = "Manguoidoc";
            this.manguoidoc.HeaderText = "Mã người đọc";
            this.manguoidoc.MinimumWidth = 6;
            this.manguoidoc.Name = "manguoidoc";
            this.manguoidoc.ReadOnly = true;
            this.manguoidoc.Width = 200;
            // 
            // hoten
            // 
            this.hoten.DataPropertyName = "Tennguoidoc";
            this.hoten.HeaderText = "Họ tên";
            this.hoten.MinimumWidth = 6;
            this.hoten.Name = "hoten";
            this.hoten.ReadOnly = true;
            this.hoten.Width = 240;
            // 
            // ngaysinh
            // 
            this.ngaysinh.DataPropertyName = "Ngaysinh";
            this.ngaysinh.HeaderText = "Ngày sinh";
            this.ngaysinh.MinimumWidth = 6;
            this.ngaysinh.Name = "ngaysinh";
            this.ngaysinh.ReadOnly = true;
            this.ngaysinh.Width = 200;
            // 
            // sdt
            // 
            this.sdt.DataPropertyName = "Sdt";
            this.sdt.HeaderText = "SĐT";
            this.sdt.MinimumWidth = 6;
            this.sdt.Name = "sdt";
            this.sdt.ReadOnly = true;
            this.sdt.Width = 200;
            // 
            // lop
            // 
            this.lop.DataPropertyName = "Lop";
            this.lop.HeaderText = "Lớp";
            this.lop.MinimumWidth = 6;
            this.lop.Name = "lop";
            this.lop.ReadOnly = true;
            this.lop.Width = 280;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.searchBtn);
            this.groupBox2.Controls.Add(this.xoa);
            this.groupBox2.Controls.Add(this.sua);
            this.groupBox2.Controls.Add(this.searchtxt);
            this.groupBox2.Controls.Add(this.them);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(16, 208);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1167, 74);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(175, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 20);
            this.label1.TabIndex = 37;
            this.label1.Text = "Tìm kiếm theo \"Họ Tên\"";
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.Color.PeachPuff;
            this.searchBtn.ForeColor = System.Drawing.Color.Peru;
            this.searchBtn.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.searchBtn.IconColor = System.Drawing.Color.Peru;
            this.searchBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.searchBtn.IconSize = 20;
            this.searchBtn.Location = new System.Drawing.Point(633, 26);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(4);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(36, 33);
            this.searchBtn.TabIndex = 33;
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // xoa
            // 
            this.xoa.BackColor = System.Drawing.Color.PeachPuff;
            this.xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xoa.ForeColor = System.Drawing.Color.Peru;
            this.xoa.Location = new System.Drawing.Point(1055, 26);
            this.xoa.Margin = new System.Windows.Forms.Padding(4);
            this.xoa.Name = "xoa";
            this.xoa.Size = new System.Drawing.Size(79, 33);
            this.xoa.TabIndex = 6;
            this.xoa.Text = "Xoá";
            this.xoa.UseVisualStyleBackColor = false;
            this.xoa.Click += new System.EventHandler(this.xoa_Click);
            // 
            // sua
            // 
            this.sua.BackColor = System.Drawing.Color.PeachPuff;
            this.sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sua.ForeColor = System.Drawing.Color.Peru;
            this.sua.Location = new System.Drawing.Point(945, 26);
            this.sua.Margin = new System.Windows.Forms.Padding(4);
            this.sua.Name = "sua";
            this.sua.Size = new System.Drawing.Size(79, 33);
            this.sua.TabIndex = 5;
            this.sua.Text = "Sửa";
            this.sua.UseVisualStyleBackColor = false;
            this.sua.Click += new System.EventHandler(this.sua_Click);
            // 
            // searchtxt
            // 
            this.searchtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchtxt.ForeColor = System.Drawing.Color.Black;
            this.searchtxt.Location = new System.Drawing.Point(413, 30);
            this.searchtxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchtxt.Name = "searchtxt";
            this.searchtxt.Size = new System.Drawing.Size(212, 26);
            this.searchtxt.TabIndex = 29;
            // 
            // them
            // 
            this.them.BackColor = System.Drawing.Color.PeachPuff;
            this.them.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.them.ForeColor = System.Drawing.Color.Peru;
            this.them.Location = new System.Drawing.Point(838, 25);
            this.them.Margin = new System.Windows.Forms.Padding(4);
            this.them.Name = "them";
            this.them.Size = new System.Drawing.Size(79, 33);
            this.them.TabIndex = 4;
            this.them.Text = "Thêm";
            this.them.UseVisualStyleBackColor = false;
            this.them.Click += new System.EventHandler(this.them_Click);
            // 
            // mndlabel
            // 
            this.mndlabel.AutoSize = true;
            this.mndlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mndlabel.Location = new System.Drawing.Point(9, 34);
            this.mndlabel.Name = "mndlabel";
            this.mndlabel.Size = new System.Drawing.Size(142, 25);
            this.mndlabel.TabIndex = 22;
            this.mndlabel.Text = "Mã người đọc";
            // 
            // sdtlabel
            // 
            this.sdtlabel.AutoSize = true;
            this.sdtlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sdtlabel.Location = new System.Drawing.Point(604, 34);
            this.sdtlabel.Name = "sdtlabel";
            this.sdtlabel.Size = new System.Drawing.Size(42, 20);
            this.sdtlabel.TabIndex = 28;
            this.sdtlabel.Text = "SĐT";
            // 
            // httxt
            // 
            this.httxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.httxt.Location = new System.Drawing.Point(193, 69);
            this.httxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.httxt.Name = "httxt";
            this.httxt.Size = new System.Drawing.Size(212, 27);
            this.httxt.TabIndex = 25;
            // 
            // ltxt
            // 
            this.ltxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltxt.Location = new System.Drawing.Point(688, 66);
            this.ltxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ltxt.Name = "ltxt";
            this.ltxt.Size = new System.Drawing.Size(212, 27);
            this.ltxt.TabIndex = 31;
            // 
            // llabel
            // 
            this.llabel.AutoSize = true;
            this.llabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llabel.Location = new System.Drawing.Point(604, 73);
            this.llabel.Name = "llabel";
            this.llabel.Size = new System.Drawing.Size(37, 20);
            this.llabel.TabIndex = 30;
            this.llabel.Text = "Lớp";
            // 
            // sdttxt
            // 
            this.sdttxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sdttxt.Location = new System.Drawing.Point(688, 28);
            this.sdttxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sdttxt.Name = "sdttxt";
            this.sdttxt.Size = new System.Drawing.Size(212, 27);
            this.sdttxt.TabIndex = 29;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nstxt);
            this.groupBox1.Controls.Add(this.nslabel);
            this.groupBox1.Controls.Add(this.ltxt);
            this.groupBox1.Controls.Add(this.llabel);
            this.groupBox1.Controls.Add(this.sdttxt);
            this.groupBox1.Controls.Add(this.sdtlabel);
            this.groupBox1.Controls.Add(this.httxt);
            this.groupBox1.Controls.Add(this.htlabel);
            this.groupBox1.Controls.Add(this.mndtxt);
            this.groupBox1.Controls.Add(this.mndlabel);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(16, 46);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1167, 155);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin người đọc";
            // 
            // nstxt
            // 
            this.nstxt.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nstxt.CustomFormat = "dd/MM/yyyy";
            this.nstxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nstxt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.nstxt.Location = new System.Drawing.Point(193, 107);
            this.nstxt.Margin = new System.Windows.Forms.Padding(4);
            this.nstxt.Name = "nstxt";
            this.nstxt.Size = new System.Drawing.Size(212, 27);
            this.nstxt.TabIndex = 34;
            // 
            // nslabel
            // 
            this.nslabel.AutoSize = true;
            this.nslabel.Location = new System.Drawing.Point(9, 107);
            this.nslabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nslabel.Name = "nslabel";
            this.nslabel.Size = new System.Drawing.Size(108, 25);
            this.nslabel.TabIndex = 33;
            this.nslabel.Text = "Ngày sinh";
            // 
            // htlabel
            // 
            this.htlabel.AutoSize = true;
            this.htlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.htlabel.Location = new System.Drawing.Point(9, 73);
            this.htlabel.Name = "htlabel";
            this.htlabel.Size = new System.Drawing.Size(75, 25);
            this.htlabel.TabIndex = 24;
            this.htlabel.Text = "Họ tên";
            // 
            // mndtxt
            // 
            this.mndtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mndtxt.Location = new System.Drawing.Point(193, 31);
            this.mndtxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mndtxt.Name = "mndtxt";
            this.mndtxt.Size = new System.Drawing.Size(212, 27);
            this.mndtxt.TabIndex = 23;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.Transparent;
            this.title.Location = new System.Drawing.Point(434, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(300, 32);
            this.title.TabIndex = 37;
            this.title.Text = "Danh sách người đọc";
            // 
            // Danhsachnguoidoc
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(1196, 590);
            this.Controls.Add(this.title);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Danhsachnguoidoc";
            this.Text = "Danhsachnguoidoc";
            this.Load += new System.EventHandler(this.Danhsachnguoidoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button xoa;
        private System.Windows.Forms.Button sua;
        private System.Windows.Forms.TextBox searchtxt;
        private System.Windows.Forms.Button them;
        private System.Windows.Forms.Label mndlabel;
        private System.Windows.Forms.Label sdtlabel;
        private System.Windows.Forms.TextBox httxt;
        private System.Windows.Forms.TextBox ltxt;
        private System.Windows.Forms.Label llabel;
        private System.Windows.Forms.TextBox sdttxt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label htlabel;
        private System.Windows.Forms.TextBox mndtxt;
        private FontAwesome.Sharp.IconButton searchBtn;
        private System.Windows.Forms.DateTimePicker nstxt;
        private System.Windows.Forms.Label nslabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn manguoidoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn lop;
        private System.Windows.Forms.Label title;
    }
}