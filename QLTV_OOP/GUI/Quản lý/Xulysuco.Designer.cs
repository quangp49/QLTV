
namespace QLTV_OOP.GUI.Quản_lý
{
    partial class Xulysuco
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.searchSucotxt = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.searchSucoBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.mptxtBOX = new System.Windows.Forms.TextBox();
            this.tensucotxtBox = new System.Windows.Forms.TextBox();
            this.nguoimuontxtBox = new System.Windows.Forms.TextBox();
            this.dstxtBox = new System.Windows.Forms.TextBox();
            this.tensachtxtBox = new System.Windows.Forms.TextBox();
            this.boithuongtxtBox = new System.Windows.Forms.TextBox();
            this.listSuco = new System.Windows.Forms.DataGridView();
            this.Maphieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tensuco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tennguoidoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Madausach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tensach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Boithuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thoigian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listSuco)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(520, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Xử lý sự cố";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::QLTV_OOP.Properties.Resources.bug;
            this.pictureBox1.Location = new System.Drawing.Point(398, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.searchSucotxt);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.searchSucoBtn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Location = new System.Drawing.Point(242, 284);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(655, 97);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // searchSucotxt
            // 
            this.searchSucotxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchSucotxt.Location = new System.Drawing.Point(213, 46);
            this.searchSucotxt.Name = "searchSucotxt";
            this.searchSucotxt.Size = new System.Drawing.Size(186, 27);
            this.searchSucotxt.TabIndex = 29;
            this.searchSucotxt.TextChanged += new System.EventHandler(this.searchSucotxt_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Enabled = false;
            this.pictureBox2.Image = global::QLTV_OOP.Properties.Resources.search2;
            this.pictureBox2.Location = new System.Drawing.Point(461, 46);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 27);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 28;
            this.pictureBox2.TabStop = false;
            // 
            // searchSucoBtn
            // 
            this.searchSucoBtn.BackColor = System.Drawing.Color.PeachPuff;
            this.searchSucoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchSucoBtn.ForeColor = System.Drawing.Color.Peru;
            this.searchSucoBtn.Location = new System.Drawing.Point(451, 41);
            this.searchSucoBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchSucoBtn.Name = "searchSucoBtn";
            this.searchSucoBtn.Size = new System.Drawing.Size(142, 36);
            this.searchSucoBtn.TabIndex = 27;
            this.searchSucoBtn.Text = "      Tìm kiếm";
            this.searchSucoBtn.UseVisualStyleBackColor = false;
            this.searchSucoBtn.Click += new System.EventHandler(this.searchSucoBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tìm kiếm sự cố";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(91, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã phiếu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(91, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tên sự cố";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(413, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tên người mượn";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(413, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Mã đầu sách";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(795, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Tên sách";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(795, 215);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "Bồi thường";
            // 
            // mptxtBOX
            // 
            this.mptxtBOX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mptxtBOX.Location = new System.Drawing.Point(218, 144);
            this.mptxtBOX.Name = "mptxtBOX";
            this.mptxtBOX.Size = new System.Drawing.Size(167, 27);
            this.mptxtBOX.TabIndex = 8;
            // 
            // tensucotxtBox
            // 
            this.tensucotxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tensucotxtBox.Location = new System.Drawing.Point(218, 217);
            this.tensucotxtBox.Name = "tensucotxtBox";
            this.tensucotxtBox.Size = new System.Drawing.Size(167, 27);
            this.tensucotxtBox.TabIndex = 9;
            // 
            // nguoimuontxtBox
            // 
            this.nguoimuontxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nguoimuontxtBox.Location = new System.Drawing.Point(587, 145);
            this.nguoimuontxtBox.Name = "nguoimuontxtBox";
            this.nguoimuontxtBox.Size = new System.Drawing.Size(167, 27);
            this.nguoimuontxtBox.TabIndex = 10;
            // 
            // dstxtBox
            // 
            this.dstxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dstxtBox.Location = new System.Drawing.Point(587, 216);
            this.dstxtBox.Name = "dstxtBox";
            this.dstxtBox.Size = new System.Drawing.Size(167, 27);
            this.dstxtBox.TabIndex = 11;
            // 
            // tensachtxtBox
            // 
            this.tensachtxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tensachtxtBox.Location = new System.Drawing.Point(916, 145);
            this.tensachtxtBox.Name = "tensachtxtBox";
            this.tensachtxtBox.Size = new System.Drawing.Size(167, 27);
            this.tensachtxtBox.TabIndex = 12;
            // 
            // boithuongtxtBox
            // 
            this.boithuongtxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boithuongtxtBox.Location = new System.Drawing.Point(916, 214);
            this.boithuongtxtBox.Name = "boithuongtxtBox";
            this.boithuongtxtBox.Size = new System.Drawing.Size(167, 27);
            this.boithuongtxtBox.TabIndex = 13;
            // 
            // listSuco
            // 
            this.listSuco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listSuco.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Maphieu,
            this.Tensuco,
            this.Tennguoidoc,
            this.Madausach,
            this.Tensach,
            this.Boithuong,
            this.Thoigian});
            this.listSuco.Location = new System.Drawing.Point(127, 409);
            this.listSuco.Name = "listSuco";
            this.listSuco.RowHeadersWidth = 51;
            this.listSuco.RowTemplate.Height = 24;
            this.listSuco.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listSuco.Size = new System.Drawing.Size(928, 150);
            this.listSuco.TabIndex = 14;
            this.listSuco.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listSuco_CellClick);
            // 
            // Maphieu
            // 
            this.Maphieu.DataPropertyName = "Maphieu";
            this.Maphieu.HeaderText = "Mã phiếu";
            this.Maphieu.MinimumWidth = 6;
            this.Maphieu.Name = "Maphieu";
            this.Maphieu.Width = 125;
            // 
            // Tensuco
            // 
            this.Tensuco.DataPropertyName = "Tensuco";
            this.Tensuco.HeaderText = "Tên sự cố";
            this.Tensuco.MinimumWidth = 6;
            this.Tensuco.Name = "Tensuco";
            this.Tensuco.Width = 125;
            // 
            // Tennguoidoc
            // 
            this.Tennguoidoc.DataPropertyName = "Tennguoidoc";
            this.Tennguoidoc.HeaderText = "Tên người đọc";
            this.Tennguoidoc.MinimumWidth = 6;
            this.Tennguoidoc.Name = "Tennguoidoc";
            this.Tennguoidoc.Width = 125;
            // 
            // Madausach
            // 
            this.Madausach.DataPropertyName = "Madausach";
            this.Madausach.HeaderText = "Mã đầu sách";
            this.Madausach.MinimumWidth = 6;
            this.Madausach.Name = "Madausach";
            this.Madausach.Width = 125;
            // 
            // Tensach
            // 
            this.Tensach.DataPropertyName = "Tensach";
            this.Tensach.HeaderText = "Tên sách";
            this.Tensach.MinimumWidth = 6;
            this.Tensach.Name = "Tensach";
            this.Tensach.Width = 125;
            // 
            // Boithuong
            // 
            this.Boithuong.DataPropertyName = "Boithuong";
            this.Boithuong.HeaderText = "Bồi thường";
            this.Boithuong.MinimumWidth = 6;
            this.Boithuong.Name = "Boithuong";
            this.Boithuong.Width = 125;
            // 
            // Thoigian
            // 
            this.Thoigian.DataPropertyName = "Thoigian";
            this.Thoigian.HeaderText = "Thời gian";
            this.Thoigian.MinimumWidth = 6;
            this.Thoigian.Name = "Thoigian";
            this.Thoigian.Width = 125;
            // 
            // Xulysuco
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(1196, 590);
            this.Controls.Add(this.listSuco);
            this.Controls.Add(this.boithuongtxtBox);
            this.Controls.Add(this.tensachtxtBox);
            this.Controls.Add(this.dstxtBox);
            this.Controls.Add(this.nguoimuontxtBox);
            this.Controls.Add(this.tensucotxtBox);
            this.Controls.Add(this.mptxtBOX);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Xulysuco";
            this.Text = "Xử lý sự cố";
            this.Load += new System.EventHandler(this.Xulysuco_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listSuco)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox mptxtBOX;
        private System.Windows.Forms.TextBox tensucotxtBox;
        private System.Windows.Forms.TextBox nguoimuontxtBox;
        private System.Windows.Forms.TextBox dstxtBox;
        private System.Windows.Forms.TextBox tensachtxtBox;
        private System.Windows.Forms.TextBox boithuongtxtBox;
        private System.Windows.Forms.TextBox searchSucotxt;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button searchSucoBtn;
        private System.Windows.Forms.DataGridView listSuco;
        private System.Windows.Forms.DataGridViewTextBoxColumn Maphieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tensuco;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tennguoidoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Madausach;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tensach;
        private System.Windows.Forms.DataGridViewTextBoxColumn Boithuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thoigian;
    }
}