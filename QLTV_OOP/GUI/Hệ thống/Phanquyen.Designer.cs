
namespace QLTV_OOP.GUI.Hệ_thống
{
    partial class Phanquyen
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.phanquyenCbBox = new System.Windows.Forms.ComboBox();
            this.authBtn = new System.Windows.Forms.Button();
            this.worktxtBox = new System.Windows.Forms.TextBox();
            this.nameNVtxtBox = new System.Windows.Forms.TextBox();
            this.idNvtxtBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nameNVLb = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.searchtxtBox = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenCV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quequan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Maphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quyentruycap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(445, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phân quyền";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.phanquyenCbBox);
            this.groupBox1.Controls.Add(this.authBtn);
            this.groupBox1.Controls.Add(this.worktxtBox);
            this.groupBox1.Controls.Add(this.nameNVtxtBox);
            this.groupBox1.Controls.Add(this.idNvtxtBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.nameNVLb);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Location = new System.Drawing.Point(80, 84);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1011, 175);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // phanquyenCbBox
            // 
            this.phanquyenCbBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phanquyenCbBox.FormattingEnabled = true;
            this.phanquyenCbBox.Items.AddRange(new object[] {
            "Quản lý",
            "Nhân viên"});
            this.phanquyenCbBox.Location = new System.Drawing.Point(737, 97);
            this.phanquyenCbBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.phanquyenCbBox.Name = "phanquyenCbBox";
            this.phanquyenCbBox.Size = new System.Drawing.Size(213, 33);
            this.phanquyenCbBox.TabIndex = 24;
            // 
            // authBtn
            // 
            this.authBtn.BackColor = System.Drawing.Color.PeachPuff;
            this.authBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authBtn.ForeColor = System.Drawing.Color.Peru;
            this.authBtn.Location = new System.Drawing.Point(429, 122);
            this.authBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.authBtn.Name = "authBtn";
            this.authBtn.Size = new System.Drawing.Size(107, 47);
            this.authBtn.TabIndex = 23;
            this.authBtn.Text = "Cập nhật";
            this.authBtn.UseVisualStyleBackColor = false;
            this.authBtn.Click += new System.EventHandler(this.authBtn_Click);
            // 
            // worktxtBox
            // 
            this.worktxtBox.Enabled = false;
            this.worktxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.worktxtBox.Location = new System.Drawing.Point(737, 34);
            this.worktxtBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.worktxtBox.Name = "worktxtBox";
            this.worktxtBox.Size = new System.Drawing.Size(213, 30);
            this.worktxtBox.TabIndex = 21;
            // 
            // nameNVtxtBox
            // 
            this.nameNVtxtBox.Enabled = false;
            this.nameNVtxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameNVtxtBox.Location = new System.Drawing.Point(187, 97);
            this.nameNVtxtBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nameNVtxtBox.Name = "nameNVtxtBox";
            this.nameNVtxtBox.Size = new System.Drawing.Size(217, 30);
            this.nameNVtxtBox.TabIndex = 20;
            // 
            // idNvtxtBox
            // 
            this.idNvtxtBox.Enabled = false;
            this.idNvtxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idNvtxtBox.Location = new System.Drawing.Point(187, 34);
            this.idNvtxtBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.idNvtxtBox.Name = "idNvtxtBox";
            this.idNvtxtBox.Size = new System.Drawing.Size(217, 30);
            this.idNvtxtBox.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(560, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 25);
            this.label5.TabIndex = 18;
            this.label5.Text = "Quyền truy cập";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(560, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 25);
            this.label4.TabIndex = 17;
            this.label4.Text = "Chức vụ";
            // 
            // nameNVLb
            // 
            this.nameNVLb.AutoSize = true;
            this.nameNVLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameNVLb.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.nameNVLb.Location = new System.Drawing.Point(28, 97);
            this.nameNVLb.Name = "nameNVLb";
            this.nameNVLb.Size = new System.Drawing.Size(104, 25);
            this.nameNVLb.TabIndex = 16;
            this.nameNVLb.Text = "Họ và tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(28, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Mã nhân viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(75, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 25);
            this.label3.TabIndex = 24;
            this.label3.Text = "Tìm kiếm nhân viên";
            // 
            // searchtxtBox
            // 
            this.searchtxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchtxtBox.Location = new System.Drawing.Point(293, 290);
            this.searchtxtBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchtxtBox.Name = "searchtxtBox";
            this.searchtxtBox.Size = new System.Drawing.Size(213, 27);
            this.searchtxtBox.TabIndex = 25;
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.Color.PeachPuff;
            this.searchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.ForeColor = System.Drawing.Color.Peru;
            this.searchBtn.Location = new System.Drawing.Point(537, 272);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(176, 59);
            this.searchBtn.TabIndex = 24;
            this.searchBtn.Text = "      Tìm kiếm";
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNV,
            this.Hoten,
            this.TenCV,
            this.Ngaysinh,
            this.Quequan,
            this.Sdt,
            this.Maphong,
            this.Quyentruycap});
            this.dataGridView1.Location = new System.Drawing.Point(66, 346);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1056, 233);
            this.dataGridView1.TabIndex = 26;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Mã nhân viên";
            this.MaNV.MinimumWidth = 6;
            this.MaNV.Name = "MaNV";
            this.MaNV.ReadOnly = true;
            this.MaNV.Width = 125;
            // 
            // Hoten
            // 
            this.Hoten.DataPropertyName = "Hoten";
            this.Hoten.HeaderText = "Họ tên";
            this.Hoten.MinimumWidth = 6;
            this.Hoten.Name = "Hoten";
            this.Hoten.ReadOnly = true;
            this.Hoten.Width = 125;
            // 
            // TenCV
            // 
            this.TenCV.DataPropertyName = "TenCV";
            this.TenCV.HeaderText = "Chức vụ";
            this.TenCV.MinimumWidth = 6;
            this.TenCV.Name = "TenCV";
            this.TenCV.ReadOnly = true;
            this.TenCV.Width = 125;
            // 
            // Ngaysinh
            // 
            this.Ngaysinh.DataPropertyName = "Ngaysinh";
            this.Ngaysinh.HeaderText = "Ngày sinh";
            this.Ngaysinh.MinimumWidth = 6;
            this.Ngaysinh.Name = "Ngaysinh";
            this.Ngaysinh.ReadOnly = true;
            this.Ngaysinh.Width = 125;
            // 
            // Quequan
            // 
            this.Quequan.DataPropertyName = "Quequan";
            this.Quequan.HeaderText = "Quê quán";
            this.Quequan.MinimumWidth = 6;
            this.Quequan.Name = "Quequan";
            this.Quequan.ReadOnly = true;
            this.Quequan.Width = 125;
            // 
            // Sdt
            // 
            this.Sdt.DataPropertyName = "Sdt";
            this.Sdt.HeaderText = "Số điện thoại";
            this.Sdt.MinimumWidth = 6;
            this.Sdt.Name = "Sdt";
            this.Sdt.ReadOnly = true;
            this.Sdt.Width = 125;
            // 
            // Maphong
            // 
            this.Maphong.DataPropertyName = "Maphong";
            this.Maphong.HeaderText = "Mã phòng";
            this.Maphong.MinimumWidth = 6;
            this.Maphong.Name = "Maphong";
            this.Maphong.ReadOnly = true;
            this.Maphong.Width = 125;
            // 
            // Quyentruycap
            // 
            this.Quyentruycap.DataPropertyName = "Quyentruycap";
            this.Quyentruycap.HeaderText = "Quyền truy cập";
            this.Quyentruycap.MinimumWidth = 6;
            this.Quyentruycap.Name = "Quyentruycap";
            this.Quyentruycap.ReadOnly = true;
            this.Quyentruycap.Width = 125;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::QLTV_OOP.Properties.Resources.search1;
            this.pictureBox1.Location = new System.Drawing.Point(547, 284);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // Phanquyen
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(1195, 590);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.searchtxtBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Phanquyen";
            this.Text = "Phanquyen";
            this.Load += new System.EventHandler(this.Phanquyen_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button authBtn;
        private System.Windows.Forms.TextBox worktxtBox;
        private System.Windows.Forms.TextBox nameNVtxtBox;
        private System.Windows.Forms.TextBox idNvtxtBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label nameNVLb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox searchtxtBox;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenCV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quequan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Maphong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quyentruycap;
        private System.Windows.Forms.ComboBox phanquyenCbBox;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}