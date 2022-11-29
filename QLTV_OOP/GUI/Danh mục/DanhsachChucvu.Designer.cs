
namespace QLTV_OOP.GUI.Danh_mục
{
    partial class DanhsachChucvu
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Luongtxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TenCVtxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MaCVtxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Addbtn = new System.Windows.Forms.Button();
            this.Changebtn = new System.Windows.Forms.Button();
            this.Deletebtn = new System.Windows.Forms.Button();
            this.Findbtn = new FontAwesome.Sharp.IconButton();
            this.Findtxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridViewChucvu = new System.Windows.Forms.DataGridView();
            this.MaCV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenCV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Luong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChucvu)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(407, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách chức vụ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Luongtxt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TenCVtxt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.MaCVtxt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Location = new System.Drawing.Point(146, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(889, 150);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chức vụ";
            // 
            // Luongtxt
            // 
            this.Luongtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Luongtxt.Location = new System.Drawing.Point(586, 38);
            this.Luongtxt.Name = "Luongtxt";
            this.Luongtxt.Size = new System.Drawing.Size(182, 27);
            this.Luongtxt.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(475, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Lương";
            // 
            // TenCVtxt
            // 
            this.TenCVtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenCVtxt.Location = new System.Drawing.Point(195, 102);
            this.TenCVtxt.Name = "TenCVtxt";
            this.TenCVtxt.Size = new System.Drawing.Size(182, 27);
            this.TenCVtxt.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã chức vụ";
            // 
            // MaCVtxt
            // 
            this.MaCVtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaCVtxt.Location = new System.Drawing.Point(195, 42);
            this.MaCVtxt.Name = "MaCVtxt";
            this.MaCVtxt.Size = new System.Drawing.Size(182, 27);
            this.MaCVtxt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã chức vụ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Addbtn);
            this.groupBox2.Controls.Add(this.Changebtn);
            this.groupBox2.Controls.Add(this.Deletebtn);
            this.groupBox2.Controls.Add(this.Findbtn);
            this.groupBox2.Controls.Add(this.Findtxt);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(146, 283);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(889, 84);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // Addbtn
            // 
            this.Addbtn.BackColor = System.Drawing.Color.PeachPuff;
            this.Addbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addbtn.ForeColor = System.Drawing.Color.Peru;
            this.Addbtn.Location = new System.Drawing.Point(517, 33);
            this.Addbtn.Margin = new System.Windows.Forms.Padding(4);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(101, 33);
            this.Addbtn.TabIndex = 19;
            this.Addbtn.Text = "Thêm";
            this.Addbtn.UseVisualStyleBackColor = false;
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // Changebtn
            // 
            this.Changebtn.BackColor = System.Drawing.Color.PeachPuff;
            this.Changebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Changebtn.ForeColor = System.Drawing.Color.Peru;
            this.Changebtn.Location = new System.Drawing.Point(644, 33);
            this.Changebtn.Margin = new System.Windows.Forms.Padding(4);
            this.Changebtn.Name = "Changebtn";
            this.Changebtn.Size = new System.Drawing.Size(101, 33);
            this.Changebtn.TabIndex = 20;
            this.Changebtn.Text = "Sửa";
            this.Changebtn.UseVisualStyleBackColor = false;
            this.Changebtn.Click += new System.EventHandler(this.Changebtn_Click);
            // 
            // Deletebtn
            // 
            this.Deletebtn.BackColor = System.Drawing.Color.PeachPuff;
            this.Deletebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deletebtn.ForeColor = System.Drawing.Color.Peru;
            this.Deletebtn.Location = new System.Drawing.Point(769, 33);
            this.Deletebtn.Margin = new System.Windows.Forms.Padding(4);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(101, 33);
            this.Deletebtn.TabIndex = 21;
            this.Deletebtn.Text = "Xoá";
            this.Deletebtn.UseVisualStyleBackColor = false;
            this.Deletebtn.Click += new System.EventHandler(this.Deletebtn_Click);
            // 
            // Findbtn
            // 
            this.Findbtn.BackColor = System.Drawing.Color.PeachPuff;
            this.Findbtn.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.Findbtn.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.Findbtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Findbtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Findbtn.IconSize = 20;
            this.Findbtn.Location = new System.Drawing.Point(408, 31);
            this.Findbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Findbtn.Name = "Findbtn";
            this.Findbtn.Size = new System.Drawing.Size(36, 33);
            this.Findbtn.TabIndex = 18;
            this.Findbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Findbtn.UseVisualStyleBackColor = false;
            this.Findbtn.Click += new System.EventHandler(this.Findbtn_Click);
            // 
            // Findtxt
            // 
            this.Findtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Findtxt.Location = new System.Drawing.Point(207, 36);
            this.Findtxt.Name = "Findtxt";
            this.Findtxt.Size = new System.Drawing.Size(182, 27);
            this.Findtxt.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tìm kiếm chức vụ";
            // 
            // dataGridViewChucvu
            // 
            this.dataGridViewChucvu.AllowUserToAddRows = false;
            this.dataGridViewChucvu.AllowUserToDeleteRows = false;
            this.dataGridViewChucvu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewChucvu.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewChucvu.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewChucvu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewChucvu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaCV,
            this.TenCV,
            this.Luong});
            this.dataGridViewChucvu.GridColor = System.Drawing.Color.Black;
            this.dataGridViewChucvu.Location = new System.Drawing.Point(146, 399);
            this.dataGridViewChucvu.Name = "dataGridViewChucvu";
            this.dataGridViewChucvu.ReadOnly = true;
            this.dataGridViewChucvu.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridViewChucvu.RowTemplate.Height = 24;
            this.dataGridViewChucvu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewChucvu.Size = new System.Drawing.Size(889, 169);
            this.dataGridViewChucvu.TabIndex = 3;
            this.dataGridViewChucvu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewChucvu_CellClick);
            // 
            // MaCV
            // 
            this.MaCV.DataPropertyName = "MaCV";
            this.MaCV.HeaderText = "Mã chức vụ";
            this.MaCV.MinimumWidth = 6;
            this.MaCV.Name = "MaCV";
            this.MaCV.ReadOnly = true;
            // 
            // TenCV
            // 
            this.TenCV.DataPropertyName = "TenCV";
            this.TenCV.HeaderText = "Tên chức vụ";
            this.TenCV.MinimumWidth = 6;
            this.TenCV.Name = "TenCV";
            this.TenCV.ReadOnly = true;
            // 
            // Luong
            // 
            this.Luong.DataPropertyName = "Luong";
            this.Luong.HeaderText = "Lương";
            this.Luong.MinimumWidth = 6;
            this.Luong.Name = "Luong";
            this.Luong.ReadOnly = true;
            // 
            // DanhsachChucvu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(1196, 590);
            this.Controls.Add(this.dataGridViewChucvu);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DanhsachChucvu";
            this.Text = "DanhsachChucvu";
            this.Load += new System.EventHandler(this.DanhsachChucvu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChucvu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Luongtxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TenCVtxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox MaCVtxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox Findtxt;
        private System.Windows.Forms.Label label5;
        private FontAwesome.Sharp.IconButton Findbtn;
        private System.Windows.Forms.Button Addbtn;
        private System.Windows.Forms.Button Changebtn;
        private System.Windows.Forms.Button Deletebtn;
        private System.Windows.Forms.DataGridView dataGridViewChucvu;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenCV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Luong;
    }
}