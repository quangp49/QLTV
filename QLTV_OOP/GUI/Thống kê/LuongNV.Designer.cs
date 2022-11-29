namespace QLTV_OOP.GUI.Thống_kê
{
    partial class LuongNV
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
            this.dataGridViewLuongNV = new System.Windows.Forms.DataGridView();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HotenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Chucvu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quequan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Maphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Luong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Findtxt = new System.Windows.Forms.TextBox();
            this.Sumtxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Findbtn = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLuongNV)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewLuongNV
            // 
            this.dataGridViewLuongNV.AllowUserToAddRows = false;
            this.dataGridViewLuongNV.AllowUserToDeleteRows = false;
            this.dataGridViewLuongNV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewLuongNV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewLuongNV.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewLuongNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLuongNV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNV,
            this.HotenNV,
            this.Chucvu,
            this.Ngaysinh,
            this.Sdt,
            this.Quequan,
            this.Maphong,
            this.Luong});
            this.dataGridViewLuongNV.Location = new System.Drawing.Point(12, 162);
            this.dataGridViewLuongNV.Name = "dataGridViewLuongNV";
            this.dataGridViewLuongNV.ReadOnly = true;
            this.dataGridViewLuongNV.RowHeadersWidth = 51;
            this.dataGridViewLuongNV.RowTemplate.Height = 24;
            this.dataGridViewLuongNV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewLuongNV.Size = new System.Drawing.Size(1172, 324);
            this.dataGridViewLuongNV.TabIndex = 0;
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Mã nhân viên";
            this.MaNV.MinimumWidth = 6;
            this.MaNV.Name = "MaNV";
            this.MaNV.ReadOnly = true;
            // 
            // HotenNV
            // 
            this.HotenNV.DataPropertyName = "Hoten";
            this.HotenNV.HeaderText = "Họ tên";
            this.HotenNV.MinimumWidth = 6;
            this.HotenNV.Name = "HotenNV";
            this.HotenNV.ReadOnly = true;
            // 
            // Chucvu
            // 
            this.Chucvu.DataPropertyName = "TenCV";
            this.Chucvu.HeaderText = "Chức vụ";
            this.Chucvu.MinimumWidth = 6;
            this.Chucvu.Name = "Chucvu";
            this.Chucvu.ReadOnly = true;
            // 
            // Ngaysinh
            // 
            this.Ngaysinh.DataPropertyName = "Ngaysinh";
            this.Ngaysinh.HeaderText = "Ngày sinh";
            this.Ngaysinh.MinimumWidth = 6;
            this.Ngaysinh.Name = "Ngaysinh";
            this.Ngaysinh.ReadOnly = true;
            // 
            // Sdt
            // 
            this.Sdt.DataPropertyName = "Sdt";
            this.Sdt.HeaderText = "Số điện thoại";
            this.Sdt.MinimumWidth = 6;
            this.Sdt.Name = "Sdt";
            this.Sdt.ReadOnly = true;
            // 
            // Quequan
            // 
            this.Quequan.DataPropertyName = "Quequan";
            this.Quequan.HeaderText = "Quê quán";
            this.Quequan.MinimumWidth = 6;
            this.Quequan.Name = "Quequan";
            this.Quequan.ReadOnly = true;
            // 
            // Maphong
            // 
            this.Maphong.DataPropertyName = "Maphong";
            this.Maphong.HeaderText = "Mã phòng";
            this.Maphong.MinimumWidth = 6;
            this.Maphong.Name = "Maphong";
            this.Maphong.ReadOnly = true;
            // 
            // Luong
            // 
            this.Luong.DataPropertyName = "Luong";
            this.Luong.HeaderText = "Lương";
            this.Luong.MinimumWidth = 6;
            this.Luong.Name = "Luong";
            this.Luong.ReadOnly = true;
            // 
            // Findtxt
            // 
            this.Findtxt.Location = new System.Drawing.Point(187, 81);
            this.Findtxt.Name = "Findtxt";
            this.Findtxt.Size = new System.Drawing.Size(264, 22);
            this.Findtxt.TabIndex = 1;
            // 
            // Sumtxt
            // 
            this.Sumtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sumtxt.Location = new System.Drawing.Point(321, 521);
            this.Sumtxt.Name = "Sumtxt";
            this.Sumtxt.ReadOnly = true;
            this.Sumtxt.Size = new System.Drawing.Size(170, 30);
            this.Sumtxt.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(116, 521);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tổng lương phải trả";
            // 
            // Findbtn
            // 
            this.Findbtn.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.Findbtn.IconColor = System.Drawing.Color.Peru;
            this.Findbtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Findbtn.IconSize = 30;
            this.Findbtn.Location = new System.Drawing.Point(457, 74);
            this.Findbtn.Name = "Findbtn";
            this.Findbtn.Size = new System.Drawing.Size(47, 37);
            this.Findbtn.TabIndex = 4;
            this.Findbtn.UseVisualStyleBackColor = true;
            this.Findbtn.Click += new System.EventHandler(this.Findbtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(82, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tìm kiếm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(81, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(241, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "Lương nhân viên";
            // 
            // LuongNV
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(1196, 590);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Findbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Sumtxt);
            this.Controls.Add(this.Findtxt);
            this.Controls.Add(this.dataGridViewLuongNV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LuongNV";
            this.Text = "LuongNV";
            this.Load += new System.EventHandler(this.LuongNV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLuongNV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewLuongNV;
        private System.Windows.Forms.TextBox Findtxt;
        private System.Windows.Forms.TextBox Sumtxt;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton Findbtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HotenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Chucvu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quequan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Maphong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Luong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}