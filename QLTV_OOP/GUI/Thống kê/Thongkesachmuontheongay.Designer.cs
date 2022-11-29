
namespace QLTV_OOP.GUI.Thống_kê
{
    partial class Thongkesachmuontheongay
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
            this.listbookmuontheongay = new System.Windows.Forms.DataGridView();
            this.Maphieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Madausach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Matuasach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tensach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngaymuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tentacgia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Trangthai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.endDTP = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.startDTP = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.totalBooktxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.listbookmuontheongay)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listbookmuontheongay
            // 
            this.listbookmuontheongay.BackgroundColor = System.Drawing.Color.White;
            this.listbookmuontheongay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listbookmuontheongay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Maphieu,
            this.Madausach,
            this.Matuasach,
            this.Tensach,
            this.Ngaymuon,
            this.Tentacgia,
            this.NXB,
            this.Gia,
            this.Trangthai});
            this.listbookmuontheongay.Location = new System.Drawing.Point(169, 332);
            this.listbookmuontheongay.Name = "listbookmuontheongay";
            this.listbookmuontheongay.RowHeadersWidth = 51;
            this.listbookmuontheongay.RowTemplate.Height = 24;
            this.listbookmuontheongay.Size = new System.Drawing.Size(859, 171);
            this.listbookmuontheongay.TabIndex = 9;
            // 
            // Maphieu
            // 
            this.Maphieu.DataPropertyName = "Maphieu";
            this.Maphieu.HeaderText = "Mã phiếu";
            this.Maphieu.MinimumWidth = 6;
            this.Maphieu.Name = "Maphieu";
            this.Maphieu.Width = 125;
            // 
            // Madausach
            // 
            this.Madausach.DataPropertyName = "Madausach";
            this.Madausach.HeaderText = "Mã đầu sách";
            this.Madausach.MinimumWidth = 6;
            this.Madausach.Name = "Madausach";
            this.Madausach.Width = 125;
            // 
            // Matuasach
            // 
            this.Matuasach.DataPropertyName = "Matuasach";
            this.Matuasach.HeaderText = "Mã tựa sách";
            this.Matuasach.MinimumWidth = 6;
            this.Matuasach.Name = "Matuasach";
            this.Matuasach.Width = 125;
            // 
            // Tensach
            // 
            this.Tensach.DataPropertyName = "Tensach";
            this.Tensach.HeaderText = "Tên sách";
            this.Tensach.MinimumWidth = 6;
            this.Tensach.Name = "Tensach";
            this.Tensach.Width = 125;
            // 
            // Ngaymuon
            // 
            this.Ngaymuon.DataPropertyName = "Ngaymuon";
            this.Ngaymuon.HeaderText = "Ngày mượn";
            this.Ngaymuon.MinimumWidth = 6;
            this.Ngaymuon.Name = "Ngaymuon";
            this.Ngaymuon.Width = 125;
            // 
            // Tentacgia
            // 
            this.Tentacgia.DataPropertyName = "Tentacgia";
            this.Tentacgia.HeaderText = "Tên tác giả";
            this.Tentacgia.MinimumWidth = 6;
            this.Tentacgia.Name = "Tentacgia";
            this.Tentacgia.Width = 125;
            // 
            // NXB
            // 
            this.NXB.DataPropertyName = "NXB";
            this.NXB.HeaderText = "NXB";
            this.NXB.MinimumWidth = 6;
            this.NXB.Name = "NXB";
            this.NXB.Width = 125;
            // 
            // Gia
            // 
            this.Gia.DataPropertyName = "Gia";
            this.Gia.HeaderText = "Gia";
            this.Gia.MinimumWidth = 6;
            this.Gia.Name = "Gia";
            this.Gia.Width = 125;
            // 
            // Trangthai
            // 
            this.Trangthai.DataPropertyName = "Trangthai";
            this.Trangthai.HeaderText = "Trạng thái";
            this.Trangthai.MinimumWidth = 6;
            this.Trangthai.Name = "Trangthai";
            this.Trangthai.Width = 125;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.searchBtn);
            this.groupBox1.Controls.Add(this.endDTP);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.startDTP);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Location = new System.Drawing.Point(169, 146);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(859, 163);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn ngày";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = global::QLTV_OOP.Properties.Resources.search2;
            this.pictureBox1.Location = new System.Drawing.Point(355, 92);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.Color.PeachPuff;
            this.searchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.ForeColor = System.Drawing.Color.Peru;
            this.searchBtn.Location = new System.Drawing.Point(345, 87);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(159, 57);
            this.searchBtn.TabIndex = 27;
            this.searchBtn.Text = "        Tìm kiếm";
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // endDTP
            // 
            this.endDTP.CustomFormat = "dd/MM/yyyy";
            this.endDTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endDTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endDTP.Location = new System.Drawing.Point(626, 45);
            this.endDTP.Name = "endDTP";
            this.endDTP.Size = new System.Drawing.Size(200, 27);
            this.endDTP.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(23, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bắt đầu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(519, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Kết thúc";
            // 
            // startDTP
            // 
            this.startDTP.CustomFormat = "dd/MM/yyyy";
            this.startDTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startDTP.Location = new System.Drawing.Point(128, 47);
            this.startDTP.Name = "startDTP";
            this.startDTP.Size = new System.Drawing.Size(200, 27);
            this.startDTP.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(333, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(577, 44);
            this.label1.TabIndex = 7;
            this.label1.Text = "Thống kê sách mượn theo ngày";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(179, 529);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(216, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tổng sách đã mượn: ";
            // 
            // totalBooktxt
            // 
            this.totalBooktxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalBooktxt.Location = new System.Drawing.Point(401, 526);
            this.totalBooktxt.Name = "totalBooktxt";
            this.totalBooktxt.ReadOnly = true;
            this.totalBooktxt.Size = new System.Drawing.Size(178, 30);
            this.totalBooktxt.TabIndex = 11;
            // 
            // Thongkesachmuontheongay
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(1196, 590);
            this.Controls.Add(this.totalBooktxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listbookmuontheongay);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Thongkesachmuontheongay";
            this.Text = "Thongkesachmuontheongay";
            this.Load += new System.EventHandler(this.Thongkesachmuontheongay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listbookmuontheongay)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView listbookmuontheongay;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.DateTimePicker endDTP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker startDTP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Maphieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Madausach;
        private System.Windows.Forms.DataGridViewTextBoxColumn Matuasach;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tensach;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngaymuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tentacgia;
        private System.Windows.Forms.DataGridViewTextBoxColumn NXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Trangthai;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox totalBooktxt;
    }
}