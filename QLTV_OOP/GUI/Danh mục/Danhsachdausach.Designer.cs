
namespace QLTV_OOP.GUI.Danh_mục
{
    partial class Danhsachdausach
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
            this.dataGridViewDausach = new System.Windows.Forms.DataGridView();
            this.madausach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Matuasach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tensach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tentacgia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nxb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaynhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tinhtrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deletebtn = new System.Windows.Forms.Button();
            this.Changebtn = new System.Windows.Forms.Button();
            this.Addbtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Maphongcbx = new System.Windows.Forms.ComboBox();
            this.Ngaynhapdtp = new System.Windows.Forms.DateTimePicker();
            this.Tinhtrangtxt = new System.Windows.Forms.TextBox();
            this.Giatxt = new System.Windows.Forms.TextBox();
            this.NXBtxt = new System.Windows.Forms.TextBox();
            this.Tentacgiatxt = new System.Windows.Forms.TextBox();
            this.Tensachtxt = new System.Windows.Forms.TextBox();
            this.Matuasachtxt = new System.Windows.Forms.TextBox();
            this.Madausachtxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Findtxt = new System.Windows.Forms.TextBox();
            this.Findbtn = new FontAwesome.Sharp.IconButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDausach)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewDausach
            // 
            this.dataGridViewDausach.AllowUserToAddRows = false;
            this.dataGridViewDausach.AllowUserToDeleteRows = false;
            this.dataGridViewDausach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDausach.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewDausach.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewDausach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDausach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.madausach,
            this.Matuasach,
            this.Tensach,
            this.tentacgia,
            this.nxb,
            this.gia,
            this.ngaynhap,
            this.maphong,
            this.Tinhtrang});
            this.dataGridViewDausach.GridColor = System.Drawing.Color.White;
            this.dataGridViewDausach.Location = new System.Drawing.Point(12, 286);
            this.dataGridViewDausach.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewDausach.Name = "dataGridViewDausach";
            this.dataGridViewDausach.ReadOnly = true;
            this.dataGridViewDausach.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridViewDausach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDausach.Size = new System.Drawing.Size(1153, 278);
            this.dataGridViewDausach.TabIndex = 14;
            this.dataGridViewDausach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDausach_CellClick);
            // 
            // madausach
            // 
            this.madausach.DataPropertyName = "Madausach";
            this.madausach.HeaderText = "Mã Đầu Sách";
            this.madausach.MinimumWidth = 6;
            this.madausach.Name = "madausach";
            this.madausach.ReadOnly = true;
            // 
            // Matuasach
            // 
            this.Matuasach.DataPropertyName = "Matuasach";
            this.Matuasach.HeaderText = "Mã tựa sách";
            this.Matuasach.MinimumWidth = 6;
            this.Matuasach.Name = "Matuasach";
            this.Matuasach.ReadOnly = true;
            // 
            // Tensach
            // 
            this.Tensach.DataPropertyName = "Tensach";
            this.Tensach.HeaderText = "Tên sách";
            this.Tensach.MinimumWidth = 6;
            this.Tensach.Name = "Tensach";
            this.Tensach.ReadOnly = true;
            // 
            // tentacgia
            // 
            this.tentacgia.DataPropertyName = "Tentacgia";
            this.tentacgia.HeaderText = "Tên tác giả";
            this.tentacgia.MinimumWidth = 6;
            this.tentacgia.Name = "tentacgia";
            this.tentacgia.ReadOnly = true;
            // 
            // nxb
            // 
            this.nxb.DataPropertyName = "NXB";
            this.nxb.HeaderText = "NXB";
            this.nxb.MinimumWidth = 6;
            this.nxb.Name = "nxb";
            this.nxb.ReadOnly = true;
            // 
            // gia
            // 
            this.gia.DataPropertyName = "Gia";
            this.gia.HeaderText = "Giá";
            this.gia.MinimumWidth = 6;
            this.gia.Name = "gia";
            this.gia.ReadOnly = true;
            // 
            // ngaynhap
            // 
            this.ngaynhap.DataPropertyName = "Ngaynhap";
            this.ngaynhap.HeaderText = "Ngày nhập";
            this.ngaynhap.MinimumWidth = 6;
            this.ngaynhap.Name = "ngaynhap";
            this.ngaynhap.ReadOnly = true;
            // 
            // maphong
            // 
            this.maphong.DataPropertyName = "Maphong";
            this.maphong.HeaderText = "Mã phòng";
            this.maphong.MinimumWidth = 6;
            this.maphong.Name = "maphong";
            this.maphong.ReadOnly = true;
            // 
            // Tinhtrang
            // 
            this.Tinhtrang.DataPropertyName = "Tinhtrang";
            this.Tinhtrang.HeaderText = "Tình trạng";
            this.Tinhtrang.MinimumWidth = 6;
            this.Tinhtrang.Name = "Tinhtrang";
            this.Tinhtrang.ReadOnly = true;
            // 
            // Deletebtn
            // 
            this.Deletebtn.BackColor = System.Drawing.Color.PeachPuff;
            this.Deletebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deletebtn.ForeColor = System.Drawing.Color.Peru;
            this.Deletebtn.Location = new System.Drawing.Point(1023, 21);
            this.Deletebtn.Margin = new System.Windows.Forms.Padding(4);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(94, 33);
            this.Deletebtn.TabIndex = 12;
            this.Deletebtn.Text = "Xoá";
            this.Deletebtn.UseVisualStyleBackColor = false;
            this.Deletebtn.Click += new System.EventHandler(this.Deletebtn_Click);
            // 
            // Changebtn
            // 
            this.Changebtn.BackColor = System.Drawing.Color.PeachPuff;
            this.Changebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Changebtn.ForeColor = System.Drawing.Color.Peru;
            this.Changebtn.Location = new System.Drawing.Point(921, 21);
            this.Changebtn.Margin = new System.Windows.Forms.Padding(4);
            this.Changebtn.Name = "Changebtn";
            this.Changebtn.Size = new System.Drawing.Size(94, 33);
            this.Changebtn.TabIndex = 11;
            this.Changebtn.Text = "Sửa";
            this.Changebtn.UseVisualStyleBackColor = false;
            this.Changebtn.Click += new System.EventHandler(this.Changebtn_Click);
            // 
            // Addbtn
            // 
            this.Addbtn.BackColor = System.Drawing.Color.PeachPuff;
            this.Addbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addbtn.ForeColor = System.Drawing.Color.Peru;
            this.Addbtn.Location = new System.Drawing.Point(819, 21);
            this.Addbtn.Margin = new System.Windows.Forms.Padding(4);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(94, 33);
            this.Addbtn.TabIndex = 10;
            this.Addbtn.Text = "Thêm";
            this.Addbtn.UseVisualStyleBackColor = false;
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Maphongcbx);
            this.groupBox1.Controls.Add(this.Ngaynhapdtp);
            this.groupBox1.Controls.Add(this.Tinhtrangtxt);
            this.groupBox1.Controls.Add(this.Giatxt);
            this.groupBox1.Controls.Add(this.NXBtxt);
            this.groupBox1.Controls.Add(this.Tentacgiatxt);
            this.groupBox1.Controls.Add(this.Tensachtxt);
            this.groupBox1.Controls.Add(this.Matuasachtxt);
            this.groupBox1.Controls.Add(this.Madausachtxt);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 44);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1153, 144);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin đầu sách";
            // 
            // Maphongcbx
            // 
            this.Maphongcbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Maphongcbx.FormattingEnabled = true;
            this.Maphongcbx.Location = new System.Drawing.Point(952, 76);
            this.Maphongcbx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Maphongcbx.Name = "Maphongcbx";
            this.Maphongcbx.Size = new System.Drawing.Size(187, 28);
            this.Maphongcbx.TabIndex = 17;
            // 
            // Ngaynhapdtp
            // 
            this.Ngaynhapdtp.CustomFormat = "dd/MM/yyyy";
            this.Ngaynhapdtp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ngaynhapdtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Ngaynhapdtp.Location = new System.Drawing.Point(952, 38);
            this.Ngaynhapdtp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Ngaynhapdtp.Name = "Ngaynhapdtp";
            this.Ngaynhapdtp.Size = new System.Drawing.Size(187, 26);
            this.Ngaynhapdtp.TabIndex = 16;
            // 
            // Tinhtrangtxt
            // 
            this.Tinhtrangtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tinhtrangtxt.Location = new System.Drawing.Point(952, 115);
            this.Tinhtrangtxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Tinhtrangtxt.Name = "Tinhtrangtxt";
            this.Tinhtrangtxt.Size = new System.Drawing.Size(187, 26);
            this.Tinhtrangtxt.TabIndex = 15;
            // 
            // Giatxt
            // 
            this.Giatxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Giatxt.Location = new System.Drawing.Point(571, 114);
            this.Giatxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Giatxt.Name = "Giatxt";
            this.Giatxt.Size = new System.Drawing.Size(195, 26);
            this.Giatxt.TabIndex = 14;
            // 
            // NXBtxt
            // 
            this.NXBtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NXBtxt.Location = new System.Drawing.Point(571, 78);
            this.NXBtxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NXBtxt.Name = "NXBtxt";
            this.NXBtxt.Size = new System.Drawing.Size(195, 26);
            this.NXBtxt.TabIndex = 13;
            // 
            // Tentacgiatxt
            // 
            this.Tentacgiatxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tentacgiatxt.Location = new System.Drawing.Point(571, 42);
            this.Tentacgiatxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Tentacgiatxt.Name = "Tentacgiatxt";
            this.Tentacgiatxt.Size = new System.Drawing.Size(195, 26);
            this.Tentacgiatxt.TabIndex = 12;
            // 
            // Tensachtxt
            // 
            this.Tensachtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tensachtxt.Location = new System.Drawing.Point(185, 114);
            this.Tensachtxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Tensachtxt.Name = "Tensachtxt";
            this.Tensachtxt.Size = new System.Drawing.Size(190, 26);
            this.Tensachtxt.TabIndex = 11;
            // 
            // Matuasachtxt
            // 
            this.Matuasachtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Matuasachtxt.Location = new System.Drawing.Point(185, 78);
            this.Matuasachtxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Matuasachtxt.Name = "Matuasachtxt";
            this.Matuasachtxt.Size = new System.Drawing.Size(190, 26);
            this.Matuasachtxt.TabIndex = 10;
            // 
            // Madausachtxt
            // 
            this.Madausachtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Madausachtxt.Location = new System.Drawing.Point(185, 42);
            this.Madausachtxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Madausachtxt.Name = "Madausachtxt";
            this.Madausachtxt.Size = new System.Drawing.Size(190, 26);
            this.Madausachtxt.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(822, 114);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 25);
            this.label9.TabIndex = 8;
            this.label9.Text = "Tình trạng";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(822, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "Mã phòng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(822, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Ngày nhập";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(434, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Giá";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(434, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "NXB";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(434, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tên tác giả";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên sách";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã tựa sách";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã đầu sách";
            // 
            // Findtxt
            // 
            this.Findtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Findtxt.Location = new System.Drawing.Point(405, 30);
            this.Findtxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Findtxt.Name = "Findtxt";
            this.Findtxt.Size = new System.Drawing.Size(212, 27);
            this.Findtxt.TabIndex = 16;
            // 
            // Findbtn
            // 
            this.Findbtn.BackColor = System.Drawing.Color.PeachPuff;
            this.Findbtn.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.Findbtn.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.Findbtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Findbtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Findbtn.IconSize = 20;
            this.Findbtn.Location = new System.Drawing.Point(624, 27);
            this.Findbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Findbtn.Name = "Findbtn";
            this.Findbtn.Size = new System.Drawing.Size(36, 33);
            this.Findbtn.TabIndex = 17;
            this.Findbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Findbtn.UseVisualStyleBackColor = false;
            this.Findbtn.Click += new System.EventHandler(this.Findbtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.Addbtn);
            this.groupBox2.Controls.Add(this.Findbtn);
            this.groupBox2.Controls.Add(this.Changebtn);
            this.groupBox2.Controls.Add(this.Deletebtn);
            this.groupBox2.Controls.Add(this.Findtxt);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(12, 206);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(1153, 62);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(170, 35);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(205, 20);
            this.label10.TabIndex = 39;
            this.label10.Text = "Tìm kiếm theo  \"Tên sách\"";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.Transparent;
            this.title.Location = new System.Drawing.Point(468, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(279, 31);
            this.title.TabIndex = 9;
            this.title.Text = "Danh sách đầu sách";
            // 
            // Danhsachdausach
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(1196, 590);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridViewDausach);
            this.Controls.Add(this.title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Danhsachdausach";
            this.Text = "Danhsachdausach";
            this.Load += new System.EventHandler(this.Danhsachdausach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDausach)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDausach;
        private System.Windows.Forms.Button Deletebtn;
        private System.Windows.Forms.Button Changebtn;
        private System.Windows.Forms.Button Addbtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Tinhtrangtxt;
        private System.Windows.Forms.TextBox Giatxt;
        private System.Windows.Forms.TextBox NXBtxt;
        private System.Windows.Forms.TextBox Tentacgiatxt;
        private System.Windows.Forms.TextBox Tensachtxt;
        private System.Windows.Forms.TextBox Matuasachtxt;
        private System.Windows.Forms.TextBox Madausachtxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Maphongcbx;
        private System.Windows.Forms.DateTimePicker Ngaynhapdtp;
        private System.Windows.Forms.TextBox Findtxt;
        private FontAwesome.Sharp.IconButton Findbtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn madausach;
        private System.Windows.Forms.DataGridViewTextBoxColumn Matuasach;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tensach;
        private System.Windows.Forms.DataGridViewTextBoxColumn tentacgia;
        private System.Windows.Forms.DataGridViewTextBoxColumn nxb;
        private System.Windows.Forms.DataGridViewTextBoxColumn gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaynhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn maphong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tinhtrang;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label label10;
    }
}