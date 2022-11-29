
namespace QLTV_OOP.GUI.Quản_lý
{
    partial class Chitietphieu
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
            this.tenNguoidocCbb = new System.Windows.Forms.ComboBox();
            this.mpLb = new System.Windows.Forms.Label();
            this.datagridview = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.ngaytraDtp = new System.Windows.Forms.DateTimePicker();
            this.ngaymuonDtp = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ManvLb = new System.Windows.Forms.Label();
            this.maphieuTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.addPhieuBtn = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tenNguoidocCbb
            // 
            this.tenNguoidocCbb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenNguoidocCbb.FormattingEnabled = true;
            this.tenNguoidocCbb.Location = new System.Drawing.Point(738, 148);
            this.tenNguoidocCbb.Name = "tenNguoidocCbb";
            this.tenNguoidocCbb.Size = new System.Drawing.Size(204, 28);
            this.tenNguoidocCbb.TabIndex = 34;
            this.tenNguoidocCbb.SelectedIndexChanged += new System.EventHandler(this.tenNguoidocCbb_SelectedIndexChanged_1);
            // 
            // mpLb
            // 
            this.mpLb.AutoSize = true;
            this.mpLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mpLb.ForeColor = System.Drawing.Color.Red;
            this.mpLb.Location = new System.Drawing.Point(192, 186);
            this.mpLb.Name = "mpLb";
            this.mpLb.Size = new System.Drawing.Size(0, 20);
            this.mpLb.TabIndex = 33;
            // 
            // datagridview
            // 
            this.datagridview.BackgroundColor = System.Drawing.Color.White;
            this.datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.datagridview.Location = new System.Drawing.Point(59, 351);
            this.datagridview.Name = "datagridview";
            this.datagridview.RowHeadersWidth = 51;
            this.datagridview.RowTemplate.Height = 24;
            this.datagridview.Size = new System.Drawing.Size(916, 197);
            this.datagridview.TabIndex = 30;
            this.datagridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridview_CellContentClick_1);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Madausach";
            this.Column1.HeaderText = "Mã đầu sách";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Tensach";
            this.Column2.HeaderText = "Tên sách";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Tentacgia";
            this.Column3.HeaderText = "Tên tác giả";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "NXB";
            this.Column4.HeaderText = "NXB";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Tinhtrang";
            this.Column5.HeaderText = "Tình trạng";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Gia";
            this.Column6.HeaderText = "Giá";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(59, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(209, 25);
            this.label5.TabIndex = 29;
            this.label5.Text = "Danh sách đầu sách";
            // 
            // ngaytraDtp
            // 
            this.ngaytraDtp.CustomFormat = "dd/MM/yyyy";
            this.ngaytraDtp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ngaytraDtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ngaytraDtp.Location = new System.Drawing.Point(738, 227);
            this.ngaytraDtp.Name = "ngaytraDtp";
            this.ngaytraDtp.Size = new System.Drawing.Size(204, 27);
            this.ngaytraDtp.TabIndex = 28;
            this.ngaytraDtp.ValueChanged += new System.EventHandler(this.ngaytraDtp_ValueChanged_1);
            // 
            // ngaymuonDtp
            // 
            this.ngaymuonDtp.CustomFormat = "dd/MM/yyyy";
            this.ngaymuonDtp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ngaymuonDtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ngaymuonDtp.Location = new System.Drawing.Point(192, 230);
            this.ngaymuonDtp.Name = "ngaymuonDtp";
            this.ngaymuonDtp.Size = new System.Drawing.Size(204, 27);
            this.ngaymuonDtp.TabIndex = 27;
            this.ngaymuonDtp.ValueChanged += new System.EventHandler(this.ngaymuonDtp_ValueChanged_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(548, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 25);
            this.label4.TabIndex = 26;
            this.label4.Text = "Ngày trả";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(59, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 25);
            this.label3.TabIndex = 25;
            this.label3.Text = "Ngày mượn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(548, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 25);
            this.label2.TabIndex = 24;
            this.label2.Text = "Tên người mượn";
            // 
            // ManvLb
            // 
            this.ManvLb.AutoSize = true;
            this.ManvLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManvLb.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ManvLb.Location = new System.Drawing.Point(59, 151);
            this.ManvLb.Name = "ManvLb";
            this.ManvLb.Size = new System.Drawing.Size(101, 25);
            this.ManvLb.TabIndex = 23;
            this.ManvLb.Text = "Mã phiếu";
            // 
            // maphieuTxtBox
            // 
            this.maphieuTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maphieuTxtBox.Location = new System.Drawing.Point(192, 152);
            this.maphieuTxtBox.Name = "maphieuTxtBox";
            this.maphieuTxtBox.Size = new System.Drawing.Size(204, 27);
            this.maphieuTxtBox.TabIndex = 22;
            this.maphieuTxtBox.TextChanged += new System.EventHandler(this.maphieuTxtBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(387, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 38);
            this.label1.TabIndex = 20;
            this.label1.Text = "Phiếu mượn sách";
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.PeachPuff;
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.Peru;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.iconButton1.IconColor = System.Drawing.Color.Red;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 40;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(782, 576);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(148, 50);
            this.iconButton1.TabIndex = 32;
            this.iconButton1.Text = "    Hủy";
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click_1);
            // 
            // addPhieuBtn
            // 
            this.addPhieuBtn.BackColor = System.Drawing.Color.PeachPuff;
            this.addPhieuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPhieuBtn.ForeColor = System.Drawing.Color.Peru;
            this.addPhieuBtn.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.addPhieuBtn.IconColor = System.Drawing.Color.Red;
            this.addPhieuBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.addPhieuBtn.IconSize = 40;
            this.addPhieuBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addPhieuBtn.Location = new System.Drawing.Point(612, 576);
            this.addPhieuBtn.Name = "addPhieuBtn";
            this.addPhieuBtn.Size = new System.Drawing.Size(147, 50);
            this.addPhieuBtn.TabIndex = 31;
            this.addPhieuBtn.Text = "      Thêm phiếu";
            this.addPhieuBtn.UseVisualStyleBackColor = false;
            this.addPhieuBtn.Click += new System.EventHandler(this.addPhieuBtn_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::QLTV_OOP.Properties.Resources.phieumuonIcon;
            this.pictureBox1.Location = new System.Drawing.Point(312, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // Chitietphieu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(1022, 663);
            this.Controls.Add(this.tenNguoidocCbb);
            this.Controls.Add(this.mpLb);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.addPhieuBtn);
            this.Controls.Add(this.datagridview);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ngaytraDtp);
            this.Controls.Add(this.ngaymuonDtp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ManvLb);
            this.Controls.Add(this.maphieuTxtBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Chitietphieu";
            this.Text = "Chitietphieu";
            this.Load += new System.EventHandler(this.Chitietphieu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox tenNguoidocCbb;
        private System.Windows.Forms.Label mpLb;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton addPhieuBtn;
        private System.Windows.Forms.DataGridView datagridview;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker ngaytraDtp;
        private System.Windows.Forms.DateTimePicker ngaymuonDtp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ManvLb;
        private System.Windows.Forms.TextBox maphieuTxtBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}