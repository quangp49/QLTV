
namespace QLTV_OOP.GUI.Danh_mục
{
    partial class Danhsachphongdoc
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
            this.mpdtxt = new System.Windows.Forms.TextBox();
            this.slstxt = new System.Windows.Forms.TextBox();
            this.mpdlabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Maphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Succhuasach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soluongsach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Suchuamaytinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soluongmaytinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thoigianmo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thoigiandong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scstxt = new System.Windows.Forms.TextBox();
            this.scslabel = new System.Windows.Forms.Label();
            this.slslabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tgdtxt = new System.Windows.Forms.DateTimePicker();
            this.tgmtxt = new System.Windows.Forms.DateTimePicker();
            this.slmtlabel = new System.Windows.Forms.Label();
            this.slmttxt = new System.Windows.Forms.TextBox();
            this.scmtlabel = new System.Windows.Forms.Label();
            this.scmttxt = new System.Windows.Forms.TextBox();
            this.tgdlabel = new System.Windows.Forms.Label();
            this.tgmlabel = new System.Windows.Forms.Label();
            this.xoa = new System.Windows.Forms.Button();
            this.sua = new System.Windows.Forms.Button();
            this.them = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // mpdtxt
            // 
            this.mpdtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mpdtxt.Location = new System.Drawing.Point(176, 28);
            this.mpdtxt.Margin = new System.Windows.Forms.Padding(2);
            this.mpdtxt.Name = "mpdtxt";
            this.mpdtxt.Size = new System.Drawing.Size(160, 26);
            this.mpdtxt.TabIndex = 1;
            // 
            // slstxt
            // 
            this.slstxt.Enabled = false;
            this.slstxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slstxt.Location = new System.Drawing.Point(176, 90);
            this.slstxt.Margin = new System.Windows.Forms.Padding(2);
            this.slstxt.Name = "slstxt";
            this.slstxt.Size = new System.Drawing.Size(160, 26);
            this.slstxt.TabIndex = 3;
            // 
            // mpdlabel
            // 
            this.mpdlabel.AutoSize = true;
            this.mpdlabel.Location = new System.Drawing.Point(9, 34);
            this.mpdlabel.Name = "mpdlabel";
            this.mpdlabel.Size = new System.Drawing.Size(149, 25);
            this.mpdlabel.TabIndex = 20;
            this.mpdlabel.Text = "Mã phòng đọc";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Maphong,
            this.Succhuasach,
            this.Soluongsach,
            this.Suchuamaytinh,
            this.Soluongmaytinh,
            this.Thoigianmo,
            this.Thoigiandong});
            this.dataGridView1.Location = new System.Drawing.Point(16, 240);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1167, 335);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Maphong
            // 
            this.Maphong.DataPropertyName = "Maphong";
            this.Maphong.HeaderText = "Mã số phòng";
            this.Maphong.MinimumWidth = 6;
            this.Maphong.Name = "Maphong";
            this.Maphong.Width = 130;
            // 
            // Succhuasach
            // 
            this.Succhuasach.DataPropertyName = "Succhuasach";
            this.Succhuasach.HeaderText = "Sức chứa sách";
            this.Succhuasach.MinimumWidth = 6;
            this.Succhuasach.Name = "Succhuasach";
            this.Succhuasach.Width = 160;
            // 
            // Soluongsach
            // 
            this.Soluongsach.DataPropertyName = "Soluongsach";
            this.Soluongsach.HeaderText = "Số lượng sách";
            this.Soluongsach.MinimumWidth = 6;
            this.Soluongsach.Name = "Soluongsach";
            this.Soluongsach.Width = 160;
            // 
            // Suchuamaytinh
            // 
            this.Suchuamaytinh.DataPropertyName = "Suchuamaytinh";
            this.Suchuamaytinh.HeaderText = "Sức chứa máy tính";
            this.Suchuamaytinh.MinimumWidth = 6;
            this.Suchuamaytinh.Name = "Suchuamaytinh";
            this.Suchuamaytinh.Width = 160;
            // 
            // Soluongmaytinh
            // 
            this.Soluongmaytinh.DataPropertyName = "Soluongmaytinh";
            this.Soluongmaytinh.HeaderText = "Số lượng máy tính";
            this.Soluongmaytinh.MinimumWidth = 6;
            this.Soluongmaytinh.Name = "Soluongmaytinh";
            this.Soluongmaytinh.Width = 160;
            // 
            // Thoigianmo
            // 
            this.Thoigianmo.DataPropertyName = "Thoigianmo";
            this.Thoigianmo.HeaderText = "Thời gian mở";
            this.Thoigianmo.MinimumWidth = 6;
            this.Thoigianmo.Name = "Thoigianmo";
            this.Thoigianmo.Width = 170;
            // 
            // Thoigiandong
            // 
            this.Thoigiandong.DataPropertyName = "Thoigiandong";
            this.Thoigiandong.HeaderText = "Thời gian đóng";
            this.Thoigiandong.MinimumWidth = 6;
            this.Thoigiandong.Name = "Thoigiandong";
            this.Thoigiandong.Width = 170;
            // 
            // scstxt
            // 
            this.scstxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scstxt.Location = new System.Drawing.Point(176, 59);
            this.scstxt.Margin = new System.Windows.Forms.Padding(2);
            this.scstxt.Name = "scstxt";
            this.scstxt.Size = new System.Drawing.Size(160, 26);
            this.scstxt.TabIndex = 2;
            // 
            // scslabel
            // 
            this.scslabel.AutoSize = true;
            this.scslabel.Location = new System.Drawing.Point(9, 61);
            this.scslabel.Name = "scslabel";
            this.scslabel.Size = new System.Drawing.Size(155, 25);
            this.scslabel.TabIndex = 16;
            this.scslabel.Text = "Sức chứa sách";
            // 
            // slslabel
            // 
            this.slslabel.AutoSize = true;
            this.slslabel.Location = new System.Drawing.Point(9, 90);
            this.slslabel.Name = "slslabel";
            this.slslabel.Size = new System.Drawing.Size(150, 25);
            this.slslabel.TabIndex = 18;
            this.slslabel.Text = "Số lượng sách";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tgdtxt);
            this.groupBox1.Controls.Add(this.tgmtxt);
            this.groupBox1.Controls.Add(this.slmtlabel);
            this.groupBox1.Controls.Add(this.slmttxt);
            this.groupBox1.Controls.Add(this.scmtlabel);
            this.groupBox1.Controls.Add(this.scmttxt);
            this.groupBox1.Controls.Add(this.tgdlabel);
            this.groupBox1.Controls.Add(this.tgmlabel);
            this.groupBox1.Controls.Add(this.mpdtxt);
            this.groupBox1.Controls.Add(this.slstxt);
            this.groupBox1.Controls.Add(this.mpdlabel);
            this.groupBox1.Controls.Add(this.slslabel);
            this.groupBox1.Controls.Add(this.scstxt);
            this.groupBox1.Controls.Add(this.scslabel);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(16, 38);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1167, 124);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phòng đọc";
            // 
            // tgdtxt
            // 
            this.tgdtxt.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tgdtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tgdtxt.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.tgdtxt.Location = new System.Drawing.Point(950, 59);
            this.tgdtxt.Name = "tgdtxt";
            this.tgdtxt.ShowUpDown = true;
            this.tgdtxt.Size = new System.Drawing.Size(160, 26);
            this.tgdtxt.TabIndex = 31;
            this.tgdtxt.ValueChanged += new System.EventHandler(this.tgdtxt_ValueChanged);
            // 
            // tgmtxt
            // 
            this.tgmtxt.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tgmtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tgmtxt.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.tgmtxt.Location = new System.Drawing.Point(950, 26);
            this.tgmtxt.Name = "tgmtxt";
            this.tgmtxt.ShowUpDown = true;
            this.tgmtxt.Size = new System.Drawing.Size(160, 26);
            this.tgmtxt.TabIndex = 30;
            this.tgmtxt.ValueChanged += new System.EventHandler(this.tgmtxt_ValueChanged);
            // 
            // slmtlabel
            // 
            this.slmtlabel.AutoSize = true;
            this.slmtlabel.Location = new System.Drawing.Point(398, 59);
            this.slmtlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.slmtlabel.Name = "slmtlabel";
            this.slmtlabel.Size = new System.Drawing.Size(185, 25);
            this.slmtlabel.TabIndex = 29;
            this.slmtlabel.Text = "Số lượng máy tính";
            // 
            // slmttxt
            // 
            this.slmttxt.Enabled = false;
            this.slmttxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slmttxt.Location = new System.Drawing.Point(567, 59);
            this.slmttxt.Name = "slmttxt";
            this.slmttxt.Size = new System.Drawing.Size(160, 26);
            this.slmttxt.TabIndex = 5;
            // 
            // scmtlabel
            // 
            this.scmtlabel.AutoSize = true;
            this.scmtlabel.Location = new System.Drawing.Point(398, 28);
            this.scmtlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.scmtlabel.Name = "scmtlabel";
            this.scmtlabel.Size = new System.Drawing.Size(190, 25);
            this.scmtlabel.TabIndex = 27;
            this.scmtlabel.Text = "Sức chứa máy tính";
            // 
            // scmttxt
            // 
            this.scmttxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scmttxt.Location = new System.Drawing.Point(567, 26);
            this.scmttxt.Name = "scmttxt";
            this.scmttxt.Size = new System.Drawing.Size(160, 26);
            this.scmttxt.TabIndex = 4;
            // 
            // tgdlabel
            // 
            this.tgdlabel.AutoSize = true;
            this.tgdlabel.Location = new System.Drawing.Point(794, 59);
            this.tgdlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tgdlabel.Name = "tgdlabel";
            this.tgdlabel.Size = new System.Drawing.Size(156, 25);
            this.tgdlabel.TabIndex = 24;
            this.tgdlabel.Text = "Thời gian đóng";
            // 
            // tgmlabel
            // 
            this.tgmlabel.AutoSize = true;
            this.tgmlabel.Location = new System.Drawing.Point(794, 28);
            this.tgmlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tgmlabel.Name = "tgmlabel";
            this.tgmlabel.Size = new System.Drawing.Size(137, 25);
            this.tgmlabel.TabIndex = 22;
            this.tgmlabel.Text = "Thời gian mở";
            // 
            // xoa
            // 
            this.xoa.BackColor = System.Drawing.Color.PeachPuff;
            this.xoa.ForeColor = System.Drawing.Color.Peru;
            this.xoa.Location = new System.Drawing.Point(1010, 22);
            this.xoa.Name = "xoa";
            this.xoa.Size = new System.Drawing.Size(100, 36);
            this.xoa.TabIndex = 10;
            this.xoa.Text = "Xoá";
            this.xoa.UseVisualStyleBackColor = false;
            this.xoa.Click += new System.EventHandler(this.button7_Click);
            // 
            // sua
            // 
            this.sua.BackColor = System.Drawing.Color.PeachPuff;
            this.sua.ForeColor = System.Drawing.Color.Peru;
            this.sua.Location = new System.Drawing.Point(904, 22);
            this.sua.Name = "sua";
            this.sua.Size = new System.Drawing.Size(100, 36);
            this.sua.TabIndex = 9;
            this.sua.Text = "Sửa";
            this.sua.UseVisualStyleBackColor = false;
            this.sua.Click += new System.EventHandler(this.button6_Click);
            // 
            // them
            // 
            this.them.BackColor = System.Drawing.Color.PeachPuff;
            this.them.ForeColor = System.Drawing.Color.Peru;
            this.them.Location = new System.Drawing.Point(798, 22);
            this.them.Name = "them";
            this.them.Size = new System.Drawing.Size(100, 36);
            this.them.TabIndex = 8;
            this.them.Text = "Thêm";
            this.them.UseVisualStyleBackColor = false;
            this.them.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(403, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox1.Size = new System.Drawing.Size(160, 26);
            this.textBox1.TabIndex = 33;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.iconButton1);
            this.groupBox2.Controls.Add(this.them);
            this.groupBox2.Controls.Add(this.sua);
            this.groupBox2.Controls.Add(this.xoa);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(16, 169);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1167, 64);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(122, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 20);
            this.label1.TabIndex = 39;
            this.label1.Text = "Tìm kiếm theo \"Mã phòng đọc\" ";
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.PeachPuff;
            this.iconButton1.ForeColor = System.Drawing.Color.Peru;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconButton1.IconColor = System.Drawing.Color.Peru;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 20;
            this.iconButton1.Location = new System.Drawing.Point(569, 21);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(27, 27);
            this.iconButton1.TabIndex = 32;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.Transparent;
            this.title.Location = new System.Drawing.Point(479, 9);
            this.title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(296, 31);
            this.title.TabIndex = 38;
            this.title.Text = "Danh sách phòng đọc";
            // 
            // Danhsachphongdoc
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(1196, 590);
            this.Controls.Add(this.title);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Danhsachphongdoc";
            this.Text = "Danhsachphongdoc";
            this.Load += new System.EventHandler(this.Danhsachphongdoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox mpdtxt;
        private System.Windows.Forms.TextBox slstxt;
        private System.Windows.Forms.Label mpdlabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox scstxt;
        private System.Windows.Forms.Label scslabel;
        private System.Windows.Forms.Label slslabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label tgdlabel;
        private System.Windows.Forms.Label tgmlabel;
        private System.Windows.Forms.Label scmtlabel;
        private System.Windows.Forms.TextBox scmttxt;
        private System.Windows.Forms.Label slmtlabel;
        private System.Windows.Forms.TextBox slmttxt;
        private System.Windows.Forms.DateTimePicker tgmtxt;
        private System.Windows.Forms.DateTimePicker tgdtxt;
        private System.Windows.Forms.Button xoa;
        private System.Windows.Forms.Button sua;
        private System.Windows.Forms.Button them;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Maphong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Succhuasach;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soluongsach;
        private System.Windows.Forms.DataGridViewTextBoxColumn Suchuamaytinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soluongmaytinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thoigianmo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thoigiandong;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label label1;
    }
}