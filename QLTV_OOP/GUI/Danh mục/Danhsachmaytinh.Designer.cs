
namespace QLTV_OOP.GUI.Danh_mục
{
    partial class Danhsachmaytinh
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
            this.dataGridViewMaytinh = new System.Windows.Forms.DataGridView();
            this.MaMT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngaynhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Trangthai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Maphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Maphongcbx = new System.Windows.Forms.ComboBox();
            this.Ngaynhapdtp = new System.Windows.Forms.DateTimePicker();
            this.Tenmaytinhtxt = new System.Windows.Forms.TextBox();
            this.Mamaytinhtxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Findtxt = new System.Windows.Forms.TextBox();
            this.Findbtn = new FontAwesome.Sharp.IconButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Deletebtn = new System.Windows.Forms.Button();
            this.Changebtn = new System.Windows.Forms.Button();
            this.Addbtn = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMaytinh)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewMaytinh
            // 
            this.dataGridViewMaytinh.AllowUserToAddRows = false;
            this.dataGridViewMaytinh.AllowUserToDeleteRows = false;
            this.dataGridViewMaytinh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMaytinh.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewMaytinh.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewMaytinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMaytinh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaMT,
            this.TenMT,
            this.Ngaynhap,
            this.Trangthai,
            this.Maphong});
            this.dataGridViewMaytinh.Location = new System.Drawing.Point(9, 282);
            this.dataGridViewMaytinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewMaytinh.Name = "dataGridViewMaytinh";
            this.dataGridViewMaytinh.ReadOnly = true;
            this.dataGridViewMaytinh.RowHeadersWidth = 51;
            this.dataGridViewMaytinh.RowTemplate.Height = 24;
            this.dataGridViewMaytinh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMaytinh.Size = new System.Drawing.Size(1175, 236);
            this.dataGridViewMaytinh.TabIndex = 0;
            this.dataGridViewMaytinh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMaytinh_CellClick);
            this.dataGridViewMaytinh.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMaytinh_CellContentClick);
            // 
            // MaMT
            // 
            this.MaMT.DataPropertyName = "MaMT";
            this.MaMT.HeaderText = "Mã máy tính";
            this.MaMT.MinimumWidth = 6;
            this.MaMT.Name = "MaMT";
            this.MaMT.ReadOnly = true;
            // 
            // TenMT
            // 
            this.TenMT.DataPropertyName = "TenMT";
            this.TenMT.HeaderText = "Tên máy tính";
            this.TenMT.MinimumWidth = 6;
            this.TenMT.Name = "TenMT";
            this.TenMT.ReadOnly = true;
            // 
            // Ngaynhap
            // 
            this.Ngaynhap.DataPropertyName = "Ngaynhap";
            this.Ngaynhap.HeaderText = "Ngày nhập";
            this.Ngaynhap.MinimumWidth = 6;
            this.Ngaynhap.Name = "Ngaynhap";
            this.Ngaynhap.ReadOnly = true;
            // 
            // Trangthai
            // 
            this.Trangthai.DataPropertyName = "Trangthai";
            this.Trangthai.HeaderText = "Trạng thái";
            this.Trangthai.MinimumWidth = 6;
            this.Trangthai.Name = "Trangthai";
            this.Trangthai.ReadOnly = true;
            // 
            // Maphong
            // 
            this.Maphong.DataPropertyName = "Maphong";
            this.Maphong.HeaderText = "Mã phòng";
            this.Maphong.MinimumWidth = 6;
            this.Maphong.Name = "Maphong";
            this.Maphong.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Maphongcbx);
            this.groupBox1.Controls.Add(this.Ngaynhapdtp);
            this.groupBox1.Controls.Add(this.Tenmaytinhtxt);
            this.groupBox1.Controls.Add(this.Mamaytinhtxt);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(9, 44);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1175, 138);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin máy tính";
            // 
            // Maphongcbx
            // 
            this.Maphongcbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Maphongcbx.FormattingEnabled = true;
            this.Maphongcbx.Location = new System.Drawing.Point(770, 91);
            this.Maphongcbx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Maphongcbx.Name = "Maphongcbx";
            this.Maphongcbx.Size = new System.Drawing.Size(212, 28);
            this.Maphongcbx.TabIndex = 7;
            // 
            // Ngaynhapdtp
            // 
            this.Ngaynhapdtp.CustomFormat = "dd/MM/yyyy";
            this.Ngaynhapdtp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ngaynhapdtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Ngaynhapdtp.Location = new System.Drawing.Point(770, 56);
            this.Ngaynhapdtp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Ngaynhapdtp.Name = "Ngaynhapdtp";
            this.Ngaynhapdtp.Size = new System.Drawing.Size(212, 26);
            this.Ngaynhapdtp.TabIndex = 6;
            // 
            // Tenmaytinhtxt
            // 
            this.Tenmaytinhtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tenmaytinhtxt.Location = new System.Drawing.Point(245, 94);
            this.Tenmaytinhtxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Tenmaytinhtxt.Name = "Tenmaytinhtxt";
            this.Tenmaytinhtxt.Size = new System.Drawing.Size(212, 26);
            this.Tenmaytinhtxt.TabIndex = 5;
            // 
            // Mamaytinhtxt
            // 
            this.Mamaytinhtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mamaytinhtxt.Location = new System.Drawing.Point(245, 57);
            this.Mamaytinhtxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Mamaytinhtxt.Name = "Mamaytinhtxt";
            this.Mamaytinhtxt.Size = new System.Drawing.Size(212, 26);
            this.Mamaytinhtxt.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(586, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Mã phòng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(586, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ngày nhập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên máy tính";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã máy tính";
            // 
            // Findtxt
            // 
            this.Findtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Findtxt.Location = new System.Drawing.Point(468, 37);
            this.Findtxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Findtxt.Name = "Findtxt";
            this.Findtxt.Size = new System.Drawing.Size(212, 27);
            this.Findtxt.TabIndex = 6;
            // 
            // Findbtn
            // 
            this.Findbtn.BackColor = System.Drawing.Color.PeachPuff;
            this.Findbtn.ForeColor = System.Drawing.Color.Peru;
            this.Findbtn.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.Findbtn.IconColor = System.Drawing.Color.Peru;
            this.Findbtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Findbtn.IconSize = 20;
            this.Findbtn.Location = new System.Drawing.Point(687, 34);
            this.Findbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Findbtn.Name = "Findbtn";
            this.Findbtn.Size = new System.Drawing.Size(36, 33);
            this.Findbtn.TabIndex = 7;
            this.Findbtn.UseVisualStyleBackColor = false;
            this.Findbtn.Click += new System.EventHandler(this.Findbtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.Findbtn);
            this.groupBox2.Controls.Add(this.Findtxt);
            this.groupBox2.Controls.Add(this.Deletebtn);
            this.groupBox2.Controls.Add(this.Changebtn);
            this.groupBox2.Controls.Add(this.Addbtn);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(9, 187);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(1175, 90);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(188, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 20);
            this.label1.TabIndex = 38;
            this.label1.Text = "Tìm kiếm theo \"Tên máy tính\"";
            // 
            // Deletebtn
            // 
            this.Deletebtn.BackColor = System.Drawing.Color.PeachPuff;
            this.Deletebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deletebtn.ForeColor = System.Drawing.Color.Peru;
            this.Deletebtn.Location = new System.Drawing.Point(999, 33);
            this.Deletebtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(83, 33);
            this.Deletebtn.TabIndex = 2;
            this.Deletebtn.Text = "Xóa";
            this.Deletebtn.UseVisualStyleBackColor = false;
            this.Deletebtn.Click += new System.EventHandler(this.Deletebtn_Click);
            // 
            // Changebtn
            // 
            this.Changebtn.BackColor = System.Drawing.Color.PeachPuff;
            this.Changebtn.ForeColor = System.Drawing.Color.Peru;
            this.Changebtn.Location = new System.Drawing.Point(899, 32);
            this.Changebtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Changebtn.Name = "Changebtn";
            this.Changebtn.Size = new System.Drawing.Size(83, 33);
            this.Changebtn.TabIndex = 1;
            this.Changebtn.Text = "Sửa";
            this.Changebtn.UseVisualStyleBackColor = false;
            this.Changebtn.Click += new System.EventHandler(this.Changebtn_Click);
            // 
            // Addbtn
            // 
            this.Addbtn.BackColor = System.Drawing.Color.PeachPuff;
            this.Addbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addbtn.ForeColor = System.Drawing.Color.Peru;
            this.Addbtn.Location = new System.Drawing.Point(802, 33);
            this.Addbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(83, 33);
            this.Addbtn.TabIndex = 0;
            this.Addbtn.Text = "Thêm";
            this.Addbtn.UseVisualStyleBackColor = false;
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.Transparent;
            this.title.Location = new System.Drawing.Point(461, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(271, 31);
            this.title.TabIndex = 10;
            this.title.Text = "Danh sách máy tính";
            // 
            // Danhsachmaytinh
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(1196, 590);
            this.Controls.Add(this.title);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridViewMaytinh);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Danhsachmaytinh";
            this.Text = "Danhsachmaytinh";
            this.Load += new System.EventHandler(this.Danhsachmaytinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMaytinh)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMaytinh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox Maphongcbx;
        private System.Windows.Forms.DateTimePicker Ngaynhapdtp;
        private System.Windows.Forms.TextBox Tenmaytinhtxt;
        private System.Windows.Forms.TextBox Mamaytinhtxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngaynhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn Trangthai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Maphong;
        private System.Windows.Forms.TextBox Findtxt;
        private FontAwesome.Sharp.IconButton Findbtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Deletebtn;
        private System.Windows.Forms.Button Changebtn;
        private System.Windows.Forms.Button Addbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label title;
    }
}