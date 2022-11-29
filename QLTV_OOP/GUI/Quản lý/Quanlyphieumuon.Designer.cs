
namespace QLTV_OOP.GUI.Quản_lý
{
    partial class Quanlyphieumuon
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Maphieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tennguoidoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngaymuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngaytra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sosach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.updatePMBtn = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.addPhieuBtn = new FontAwesome.Sharp.IconButton();
            this.searchtxtb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Maphieu,
            this.Tennguoidoc,
            this.Ngaymuon,
            this.Ngaytra,
            this.Sosach});
            this.dataGridView1.Location = new System.Drawing.Point(202, 362);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(804, 190);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // Maphieu
            // 
            this.Maphieu.DataPropertyName = "Maphieu";
            this.Maphieu.HeaderText = "Mã phiếu";
            this.Maphieu.MinimumWidth = 6;
            this.Maphieu.Name = "Maphieu";
            this.Maphieu.Width = 150;
            // 
            // Tennguoidoc
            // 
            this.Tennguoidoc.DataPropertyName = "Tennguoidoc";
            this.Tennguoidoc.HeaderText = "Tên người mượn";
            this.Tennguoidoc.MinimumWidth = 6;
            this.Tennguoidoc.Name = "Tennguoidoc";
            this.Tennguoidoc.Width = 150;
            // 
            // Ngaymuon
            // 
            this.Ngaymuon.DataPropertyName = "Ngaymuon";
            this.Ngaymuon.HeaderText = "Ngày mượn";
            this.Ngaymuon.MinimumWidth = 6;
            this.Ngaymuon.Name = "Ngaymuon";
            this.Ngaymuon.Width = 150;
            // 
            // Ngaytra
            // 
            this.Ngaytra.DataPropertyName = "Ngaytra";
            this.Ngaytra.HeaderText = "Ngày trả";
            this.Ngaytra.MinimumWidth = 6;
            this.Ngaytra.Name = "Ngaytra";
            this.Ngaytra.Width = 150;
            // 
            // Sosach
            // 
            this.Sosach.DataPropertyName = "Sosach";
            this.Sosach.HeaderText = "Số sách";
            this.Sosach.MinimumWidth = 6;
            this.Sosach.Name = "Sosach";
            this.Sosach.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(475, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 44);
            this.label1.TabIndex = 3;
            this.label1.Text = " Mượn sách";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.updatePMBtn);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.searchBtn);
            this.groupBox1.Controls.Add(this.addPhieuBtn);
            this.groupBox1.Controls.Add(this.searchtxtb);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Location = new System.Drawing.Point(125, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(939, 203);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";
            // 
            // updatePMBtn
            // 
            this.updatePMBtn.BackColor = System.Drawing.Color.PeachPuff;
            this.updatePMBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatePMBtn.ForeColor = System.Drawing.Color.Peru;
            this.updatePMBtn.IconChar = FontAwesome.Sharp.IconChar.Wrench;
            this.updatePMBtn.IconColor = System.Drawing.Color.Red;
            this.updatePMBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.updatePMBtn.IconSize = 30;
            this.updatePMBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.updatePMBtn.Location = new System.Drawing.Point(518, 139);
            this.updatePMBtn.Name = "updatePMBtn";
            this.updatePMBtn.Size = new System.Drawing.Size(159, 47);
            this.updatePMBtn.TabIndex = 28;
            this.updatePMBtn.Text = "      Sửa phiếu";
            this.updatePMBtn.UseVisualStyleBackColor = false;
            this.updatePMBtn.Click += new System.EventHandler(this.updatePMBtn_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(166, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(265, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "Mã phiếu hoặc tên người mượn";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = global::QLTV_OOP.Properties.Resources.search2;
            this.pictureBox1.Location = new System.Drawing.Point(675, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.Color.PeachPuff;
            this.searchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.ForeColor = System.Drawing.Color.Peru;
            this.searchBtn.Location = new System.Drawing.Point(665, 59);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(142, 36);
            this.searchBtn.TabIndex = 25;
            this.searchBtn.Text = "      Tìm kiếm";
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // addPhieuBtn
            // 
            this.addPhieuBtn.BackColor = System.Drawing.Color.PeachPuff;
            this.addPhieuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPhieuBtn.ForeColor = System.Drawing.Color.Peru;
            this.addPhieuBtn.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.addPhieuBtn.IconColor = System.Drawing.Color.Red;
            this.addPhieuBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.addPhieuBtn.IconSize = 30;
            this.addPhieuBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addPhieuBtn.Location = new System.Drawing.Point(197, 139);
            this.addPhieuBtn.Name = "addPhieuBtn";
            this.addPhieuBtn.Size = new System.Drawing.Size(159, 47);
            this.addPhieuBtn.TabIndex = 4;
            this.addPhieuBtn.Text = "      Thêm phiếu";
            this.addPhieuBtn.UseVisualStyleBackColor = false;
            this.addPhieuBtn.Click += new System.EventHandler(this.addPhieuBtn_Click_1);
            // 
            // searchtxtb
            // 
            this.searchtxtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchtxtb.Location = new System.Drawing.Point(437, 65);
            this.searchtxtb.Name = "searchtxtb";
            this.searchtxtb.Size = new System.Drawing.Size(211, 30);
            this.searchtxtb.TabIndex = 6;
            this.searchtxtb.TextChanged += new System.EventHandler(this.searchtxtb_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(166, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tìm kiếm";
            // 
            // Quanlyphieumuon
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(1196, 590);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Quanlyphieumuon";
            this.Text = "Quanlyphieumuon";
            this.Load += new System.EventHandler(this.Quanlyphieumuon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Maphieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tennguoidoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngaymuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngaytra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sosach;
        private FontAwesome.Sharp.IconButton addPhieuBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox searchtxtb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton updatePMBtn;
    }
}