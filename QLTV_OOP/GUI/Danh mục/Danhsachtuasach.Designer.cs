
namespace QLTV_OOP.GUI.Danh_mục
{
    partial class Danhsachtuasach
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
            this.dataGridViewTuasach = new System.Windows.Forms.DataGridView();
            this.Matuasach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tentuasach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tentacgia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTuasach)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTuasach
            // 
            this.dataGridViewTuasach.AllowUserToAddRows = false;
            this.dataGridViewTuasach.AllowUserToDeleteRows = false;
            this.dataGridViewTuasach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTuasach.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewTuasach.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewTuasach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTuasach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Matuasach,
            this.Tentuasach,
            this.Tentacgia,
            this.NXB,
            this.Gia,
            this.Soluong});
            this.dataGridViewTuasach.GridColor = System.Drawing.Color.White;
            this.dataGridViewTuasach.Location = new System.Drawing.Point(103, 100);
            this.dataGridViewTuasach.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewTuasach.Name = "dataGridViewTuasach";
            this.dataGridViewTuasach.ReadOnly = true;
            this.dataGridViewTuasach.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridViewTuasach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTuasach.Size = new System.Drawing.Size(960, 324);
            this.dataGridViewTuasach.TabIndex = 14;
            // 
            // Matuasach
            // 
            this.Matuasach.DataPropertyName = "Matuasach";
            this.Matuasach.HeaderText = "Mã tựa sách";
            this.Matuasach.MinimumWidth = 6;
            this.Matuasach.Name = "Matuasach";
            this.Matuasach.ReadOnly = true;
            // 
            // Tentuasach
            // 
            this.Tentuasach.DataPropertyName = "Tensach";
            this.Tentuasach.HeaderText = "Tên tựa sách";
            this.Tentuasach.MinimumWidth = 6;
            this.Tentuasach.Name = "Tentuasach";
            this.Tentuasach.ReadOnly = true;
            // 
            // Tentacgia
            // 
            this.Tentacgia.DataPropertyName = "Tentacgia";
            this.Tentacgia.HeaderText = "Tên tác giả";
            this.Tentacgia.MinimumWidth = 6;
            this.Tentacgia.Name = "Tentacgia";
            this.Tentacgia.ReadOnly = true;
            // 
            // NXB
            // 
            this.NXB.DataPropertyName = "NXB";
            this.NXB.HeaderText = "NXB";
            this.NXB.MinimumWidth = 6;
            this.NXB.Name = "NXB";
            this.NXB.ReadOnly = true;
            // 
            // Gia
            // 
            this.Gia.DataPropertyName = "Gia";
            this.Gia.HeaderText = "Giá";
            this.Gia.MinimumWidth = 6;
            this.Gia.Name = "Gia";
            this.Gia.ReadOnly = true;
            // 
            // Soluong
            // 
            this.Soluong.DataPropertyName = "Soluong";
            this.Soluong.HeaderText = "Số lượng";
            this.Soluong.MinimumWidth = 6;
            this.Soluong.Name = "Soluong";
            this.Soluong.ReadOnly = true;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.Transparent;
            this.title.Location = new System.Drawing.Point(440, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(272, 31);
            this.title.TabIndex = 12;
            this.title.Text = "Danh sách tựa sách";
            // 
            // Danhsachtuasach
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(1196, 590);
            this.Controls.Add(this.dataGridViewTuasach);
            this.Controls.Add(this.title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Danhsachtuasach";
            this.Text = "Danhsachtuasach";
            this.Load += new System.EventHandler(this.Danhsachtuasach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTuasach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTuasach;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Matuasach;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tentuasach;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tentacgia;
        private System.Windows.Forms.DataGridViewTextBoxColumn NXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soluong;
    }
}