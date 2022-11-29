
namespace QLTV_OOP.GUI.Quản_lý
{
    partial class Phieutra
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
            this.tnmtxtBOX = new System.Windows.Forms.ComboBox();
            this.mpLb = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.traPhieuBtn = new FontAwesome.Sharp.IconButton();
            this.listBookhentra = new System.Windows.Forms.DataGridView();
            this.Choose = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.nhtDTP = new System.Windows.Forms.DateTimePicker();
            this.nmDTP = new System.Windows.Forms.DateTimePicker();
            this.ManvLb = new System.Windows.Forms.Label();
            this.mpttxtBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ntDTP = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listBookhentra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tnmtxtBOX
            // 
            this.tnmtxtBOX.Enabled = false;
            this.tnmtxtBOX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tnmtxtBOX.FormattingEnabled = true;
            this.tnmtxtBOX.Location = new System.Drawing.Point(732, 152);
            this.tnmtxtBOX.Name = "tnmtxtBOX";
            this.tnmtxtBOX.Size = new System.Drawing.Size(204, 28);
            this.tnmtxtBOX.TabIndex = 49;
            // 
            // mpLb
            // 
            this.mpLb.AutoSize = true;
            this.mpLb.Enabled = false;
            this.mpLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mpLb.ForeColor = System.Drawing.Color.Red;
            this.mpLb.Location = new System.Drawing.Point(186, 190);
            this.mpLb.Name = "mpLb";
            this.mpLb.Size = new System.Drawing.Size(0, 20);
            this.mpLb.TabIndex = 48;
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
            this.iconButton1.Location = new System.Drawing.Point(781, 622);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(148, 50);
            this.iconButton1.TabIndex = 47;
            this.iconButton1.Text = "    Hủy";
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // traPhieuBtn
            // 
            this.traPhieuBtn.BackColor = System.Drawing.Color.PeachPuff;
            this.traPhieuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.traPhieuBtn.ForeColor = System.Drawing.Color.Peru;
            this.traPhieuBtn.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.traPhieuBtn.IconColor = System.Drawing.Color.Red;
            this.traPhieuBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.traPhieuBtn.IconSize = 40;
            this.traPhieuBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.traPhieuBtn.Location = new System.Drawing.Point(611, 622);
            this.traPhieuBtn.Name = "traPhieuBtn";
            this.traPhieuBtn.Size = new System.Drawing.Size(147, 50);
            this.traPhieuBtn.TabIndex = 46;
            this.traPhieuBtn.Text = "      Trả sách";
            this.traPhieuBtn.UseVisualStyleBackColor = false;
            this.traPhieuBtn.Click += new System.EventHandler(this.traPhieuBtn_Click);
            // 
            // listBookhentra
            // 
            this.listBookhentra.BackgroundColor = System.Drawing.Color.White;
            this.listBookhentra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listBookhentra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Choose,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.listBookhentra.Location = new System.Drawing.Point(58, 421);
            this.listBookhentra.Name = "listBookhentra";
            this.listBookhentra.RowHeadersWidth = 51;
            this.listBookhentra.RowTemplate.Height = 24;
            this.listBookhentra.Size = new System.Drawing.Size(916, 178);
            this.listBookhentra.TabIndex = 45;
            this.listBookhentra.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listBookhentra_CellContentClick_1);
            // 
            // Choose
            // 
            this.Choose.HeaderText = "Trả sách";
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(53, 378);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(209, 25);
            this.label5.TabIndex = 44;
            this.label5.Text = "Danh sách đầu sách";
            // 
            // nhtDTP
            // 
            this.nhtDTP.CustomFormat = "dd/MM/yyyy";
            this.nhtDTP.Enabled = false;
            this.nhtDTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nhtDTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.nhtDTP.Location = new System.Drawing.Point(732, 231);
            this.nhtDTP.Name = "nhtDTP";
            this.nhtDTP.Size = new System.Drawing.Size(204, 27);
            this.nhtDTP.TabIndex = 43;
            // 
            // nmDTP
            // 
            this.nmDTP.CustomFormat = "dd/MM/yyyy";
            this.nmDTP.Enabled = false;
            this.nmDTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmDTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.nmDTP.Location = new System.Drawing.Point(186, 234);
            this.nmDTP.Name = "nmDTP";
            this.nmDTP.Size = new System.Drawing.Size(204, 27);
            this.nmDTP.TabIndex = 42;
            // 
            // ManvLb
            // 
            this.ManvLb.AutoSize = true;
            this.ManvLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManvLb.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ManvLb.Location = new System.Drawing.Point(53, 155);
            this.ManvLb.Name = "ManvLb";
            this.ManvLb.Size = new System.Drawing.Size(101, 25);
            this.ManvLb.TabIndex = 38;
            this.ManvLb.Text = "Mã phiếu";
            // 
            // mpttxtBox
            // 
            this.mpttxtBox.Enabled = false;
            this.mpttxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mpttxtBox.Location = new System.Drawing.Point(186, 156);
            this.mpttxtBox.Name = "mpttxtBox";
            this.mpttxtBox.Size = new System.Drawing.Size(204, 27);
            this.mpttxtBox.TabIndex = 37;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::QLTV_OOP.Properties.Resources.phieumuonIcon;
            this.pictureBox1.Location = new System.Drawing.Point(306, 33);
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
            this.label1.Location = new System.Drawing.Point(381, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 38);
            this.label1.TabIndex = 35;
            this.label1.Text = "Phiếu trả sách";
            // 
            // ntDTP
            // 
            this.ntDTP.CustomFormat = "dd/MM/yyyy";
            this.ntDTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ntDTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ntDTP.Location = new System.Drawing.Point(186, 307);
            this.ntDTP.Name = "ntDTP";
            this.ntDTP.Size = new System.Drawing.Size(204, 27);
            this.ntDTP.TabIndex = 51;
            this.ntDTP.ValueChanged += new System.EventHandler(this.ntDTP_ValueChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(542, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 25);
            this.label2.TabIndex = 52;
            this.label2.Text = "Tên người mượn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(53, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 25);
            this.label3.TabIndex = 53;
            this.label3.Text = "Ngày mượn";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(53, 309);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 25);
            this.label6.TabIndex = 54;
            this.label6.Text = "Ngày trả";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(542, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 25);
            this.label7.TabIndex = 55;
            this.label7.Text = "Ngày hẹn trả";
            // 
            // Phieutra
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(1022, 686);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ntDTP);
            this.Controls.Add(this.tnmtxtBOX);
            this.Controls.Add(this.mpLb);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.traPhieuBtn);
            this.Controls.Add(this.listBookhentra);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nhtDTP);
            this.Controls.Add(this.nmDTP);
            this.Controls.Add(this.ManvLb);
            this.Controls.Add(this.mpttxtBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Phieutra";
            this.Text = "Phieutra";
            this.Load += new System.EventHandler(this.Phieutra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listBookhentra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox tnmtxtBOX;
        private System.Windows.Forms.Label mpLb;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton traPhieuBtn;
        private System.Windows.Forms.DataGridView listBookhentra;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker nhtDTP;
        private System.Windows.Forms.DateTimePicker nmDTP;
        private System.Windows.Forms.Label ManvLb;
        private System.Windows.Forms.TextBox mpttxtBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker ntDTP;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Choose;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}