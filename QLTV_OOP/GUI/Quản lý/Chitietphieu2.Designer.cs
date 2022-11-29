
namespace QLTV_OOP.GUI.Quản_lý
{
    partial class Chitietphieu2
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
            this.tnmCbb = new System.Windows.Forms.ComboBox();
            this.mpLb = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ntDtp = new System.Windows.Forms.DateTimePicker();
            this.nmDtp = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ManvLb = new System.Windows.Forms.Label();
            this.mptxtBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBookdamuon = new System.Windows.Forms.DataGridView();
            this.thoatBtn = new FontAwesome.Sharp.IconButton();
            this.updateBtn = new FontAwesome.Sharp.IconButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Choose = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBookdamuon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tnmCbb
            // 
            this.tnmCbb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tnmCbb.FormattingEnabled = true;
            this.tnmCbb.Location = new System.Drawing.Point(733, 155);
            this.tnmCbb.Name = "tnmCbb";
            this.tnmCbb.Size = new System.Drawing.Size(204, 28);
            this.tnmCbb.TabIndex = 47;
            this.tnmCbb.SelectedIndexChanged += new System.EventHandler(this.tnmCbb_SelectedIndexChanged);
            // 
            // mpLb
            // 
            this.mpLb.AutoSize = true;
            this.mpLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mpLb.ForeColor = System.Drawing.Color.Red;
            this.mpLb.Location = new System.Drawing.Point(220, 194);
            this.mpLb.Name = "mpLb";
            this.mpLb.Size = new System.Drawing.Size(0, 20);
            this.mpLb.TabIndex = 46;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(87, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(279, 25);
            this.label5.TabIndex = 44;
            this.label5.Text = "Danh sách sách được mượn";
            // 
            // ntDtp
            // 
            this.ntDtp.CustomFormat = "dd/MM/yyyy";
            this.ntDtp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ntDtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ntDtp.Location = new System.Drawing.Point(733, 234);
            this.ntDtp.Name = "ntDtp";
            this.ntDtp.Size = new System.Drawing.Size(204, 27);
            this.ntDtp.TabIndex = 43;
            this.ntDtp.ValueChanged += new System.EventHandler(this.ntDtp_ValueChanged);
            // 
            // nmDtp
            // 
            this.nmDtp.CustomFormat = "dd/MM/yyyy";
            this.nmDtp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmDtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.nmDtp.Location = new System.Drawing.Point(220, 238);
            this.nmDtp.Name = "nmDtp";
            this.nmDtp.Size = new System.Drawing.Size(204, 27);
            this.nmDtp.TabIndex = 42;
            this.nmDtp.ValueChanged += new System.EventHandler(this.nmDtp_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(543, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 25);
            this.label4.TabIndex = 41;
            this.label4.Text = "Ngày trả";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(87, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 25);
            this.label3.TabIndex = 40;
            this.label3.Text = "Ngày mượn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(543, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 25);
            this.label2.TabIndex = 39;
            this.label2.Text = "Tên người mượn";
            // 
            // ManvLb
            // 
            this.ManvLb.AutoSize = true;
            this.ManvLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManvLb.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ManvLb.Location = new System.Drawing.Point(87, 159);
            this.ManvLb.Name = "ManvLb";
            this.ManvLb.Size = new System.Drawing.Size(101, 25);
            this.ManvLb.TabIndex = 38;
            this.ManvLb.Text = "Mã phiếu";
            // 
            // mptxtBox
            // 
            this.mptxtBox.Enabled = false;
            this.mptxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mptxtBox.Location = new System.Drawing.Point(220, 160);
            this.mptxtBox.Name = "mptxtBox";
            this.mptxtBox.Size = new System.Drawing.Size(204, 27);
            this.mptxtBox.TabIndex = 37;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::QLTV_OOP.Properties.Resources.phieumuonIcon;
            this.pictureBox1.Location = new System.Drawing.Point(306, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(381, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 38);
            this.label1.TabIndex = 35;
            this.label1.Text = "Phiếu mượn sách";
            // 
            // listBookdamuon
            // 
            this.listBookdamuon.BackgroundColor = System.Drawing.Color.White;
            this.listBookdamuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listBookdamuon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Choose,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.listBookdamuon.Location = new System.Drawing.Point(92, 370);
            this.listBookdamuon.Name = "listBookdamuon";
            this.listBookdamuon.RowHeadersWidth = 51;
            this.listBookdamuon.RowTemplate.Height = 24;
            this.listBookdamuon.Size = new System.Drawing.Size(845, 197);
            this.listBookdamuon.TabIndex = 48;
            this.listBookdamuon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listBookdamuon_CellContentClick);
            // 
            // thoatBtn
            // 
            this.thoatBtn.BackColor = System.Drawing.Color.PeachPuff;
            this.thoatBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thoatBtn.ForeColor = System.Drawing.Color.Peru;
            this.thoatBtn.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.thoatBtn.IconColor = System.Drawing.Color.Red;
            this.thoatBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.thoatBtn.IconSize = 40;
            this.thoatBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.thoatBtn.Location = new System.Drawing.Point(767, 582);
            this.thoatBtn.Name = "thoatBtn";
            this.thoatBtn.Size = new System.Drawing.Size(157, 63);
            this.thoatBtn.TabIndex = 49;
            this.thoatBtn.Text = "    Hủy";
            this.thoatBtn.UseVisualStyleBackColor = false;
            this.thoatBtn.Click += new System.EventHandler(this.thoatBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.Color.PeachPuff;
            this.updateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.ForeColor = System.Drawing.Color.Peru;
            this.updateBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.updateBtn.IconColor = System.Drawing.Color.White;
            this.updateBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.updateBtn.Location = new System.Drawing.Point(563, 582);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(148, 63);
            this.updateBtn.TabIndex = 50;
            this.updateBtn.Text = "Lưu phiếu mượn";
            this.updateBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Enabled = false;
            this.pictureBox2.Image = global::QLTV_OOP.Properties.Resources.saveIcon;
            this.pictureBox2.Location = new System.Drawing.Point(573, 588);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(44, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 51;
            this.pictureBox2.TabStop = false;
            // 
            // Choose
            // 
            this.Choose.HeaderText = "Chọn sách";
            this.Choose.MinimumWidth = 6;
            this.Choose.Name = "Choose";
            this.Choose.Width = 125;
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
            this.Column5.DataPropertyName = "Trangthai";
            this.Column5.HeaderText = "Trạng thái";
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
            // Chitietphieu2
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(1022, 663);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.thoatBtn);
            this.Controls.Add(this.listBookdamuon);
            this.Controls.Add(this.tnmCbb);
            this.Controls.Add(this.mpLb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ntDtp);
            this.Controls.Add(this.nmDtp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ManvLb);
            this.Controls.Add(this.mptxtBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Chitietphieu2";
            this.Text = "Chitietphieu2";
            this.Load += new System.EventHandler(this.Chitietphieu2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBookdamuon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox tnmCbb;
        private System.Windows.Forms.Label mpLb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker ntDtp;
        private System.Windows.Forms.DateTimePicker nmDtp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ManvLb;
        private System.Windows.Forms.TextBox mptxtBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView listBookdamuon;
        private FontAwesome.Sharp.IconButton thoatBtn;
        private FontAwesome.Sharp.IconButton updateBtn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Choose;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}