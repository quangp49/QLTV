
namespace QLTV_OOP.GUI.Quản_lý
{
    partial class quanlyMain
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.trasachBtn = new FontAwesome.Sharp.IconButton();
            this.errorBtn = new FontAwesome.Sharp.IconButton();
            this.qlPhieuBtn = new FontAwesome.Sharp.IconButton();
            this.qlMTBtn = new FontAwesome.Sharp.IconButton();
            this.quanlyPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.trasachBtn);
            this.panel1.Controls.Add(this.errorBtn);
            this.panel1.Controls.Add(this.qlPhieuBtn);
            this.panel1.Controls.Add(this.qlMTBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(304, 590);
            this.panel1.TabIndex = 1;
            // 
            // trasachBtn
            // 
            this.trasachBtn.BackColor = System.Drawing.Color.Peru;
            this.trasachBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trasachBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.trasachBtn.IconChar = FontAwesome.Sharp.IconChar.File;
            this.trasachBtn.IconColor = System.Drawing.Color.WhiteSmoke;
            this.trasachBtn.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.trasachBtn.IconSize = 40;
            this.trasachBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.trasachBtn.Location = new System.Drawing.Point(12, 141);
            this.trasachBtn.Name = "trasachBtn";
            this.trasachBtn.Size = new System.Drawing.Size(265, 67);
            this.trasachBtn.TabIndex = 6;
            this.trasachBtn.Text = "    Quản lý trả sách";
            this.trasachBtn.UseVisualStyleBackColor = false;
            this.trasachBtn.Click += new System.EventHandler(this.trasachBtn_Click);
            // 
            // errorBtn
            // 
            this.errorBtn.BackColor = System.Drawing.Color.Peru;
            this.errorBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.errorBtn.IconChar = FontAwesome.Sharp.IconChar.Bomb;
            this.errorBtn.IconColor = System.Drawing.Color.WhiteSmoke;
            this.errorBtn.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.errorBtn.IconSize = 45;
            this.errorBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.errorBtn.Location = new System.Drawing.Point(12, 334);
            this.errorBtn.Name = "errorBtn";
            this.errorBtn.Size = new System.Drawing.Size(265, 67);
            this.errorBtn.TabIndex = 5;
            this.errorBtn.Text = "          Xử lý sự cố";
            this.errorBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.errorBtn.UseVisualStyleBackColor = false;
            this.errorBtn.Click += new System.EventHandler(this.errorBtn_Click_1);
            // 
            // qlPhieuBtn
            // 
            this.qlPhieuBtn.BackColor = System.Drawing.Color.Peru;
            this.qlPhieuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qlPhieuBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.qlPhieuBtn.IconChar = FontAwesome.Sharp.IconChar.File;
            this.qlPhieuBtn.IconColor = System.Drawing.Color.WhiteSmoke;
            this.qlPhieuBtn.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.qlPhieuBtn.IconSize = 40;
            this.qlPhieuBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.qlPhieuBtn.Location = new System.Drawing.Point(12, 44);
            this.qlPhieuBtn.Name = "qlPhieuBtn";
            this.qlPhieuBtn.Size = new System.Drawing.Size(265, 67);
            this.qlPhieuBtn.TabIndex = 2;
            this.qlPhieuBtn.Text = "    Quản lý mượn sách";
            this.qlPhieuBtn.UseVisualStyleBackColor = false;
            this.qlPhieuBtn.Click += new System.EventHandler(this.qlPhieuBtn_Click_1);
            // 
            // qlMTBtn
            // 
            this.qlMTBtn.BackColor = System.Drawing.Color.Peru;
            this.qlMTBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qlMTBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.qlMTBtn.IconChar = FontAwesome.Sharp.IconChar.Laptop;
            this.qlMTBtn.IconColor = System.Drawing.Color.WhiteSmoke;
            this.qlMTBtn.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.qlMTBtn.IconSize = 45;
            this.qlMTBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.qlMTBtn.Location = new System.Drawing.Point(12, 240);
            this.qlMTBtn.Name = "qlMTBtn";
            this.qlMTBtn.Size = new System.Drawing.Size(265, 67);
            this.qlMTBtn.TabIndex = 4;
            this.qlMTBtn.Text = "        Quản lý máy tính sử dụng";
            this.qlMTBtn.UseVisualStyleBackColor = false;
            this.qlMTBtn.Click += new System.EventHandler(this.qlMTBtn_Click_1);
            // 
            // quanlyPanel
            // 
            this.quanlyPanel.BackColor = System.Drawing.Color.Peru;
            this.quanlyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quanlyPanel.Location = new System.Drawing.Point(304, 0);
            this.quanlyPanel.Name = "quanlyPanel";
            this.quanlyPanel.Size = new System.Drawing.Size(1196, 590);
            this.quanlyPanel.TabIndex = 2;
            // 
            // quanlyMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(1500, 590);
            this.Controls.Add(this.quanlyPanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "quanlyMain";
            this.Text = "quanlyMain";
            this.Load += new System.EventHandler(this.quanlyMain_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel quanlyPanel;
        private FontAwesome.Sharp.IconButton errorBtn;
        private FontAwesome.Sharp.IconButton qlPhieuBtn;
        private FontAwesome.Sharp.IconButton qlMTBtn;
        private FontAwesome.Sharp.IconButton trasachBtn;
    }
}