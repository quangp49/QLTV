
namespace QLTV_OOP.GUI.Thống_kê
{
    partial class thongkeMain
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
            this.errorBtn = new FontAwesome.Sharp.IconButton();
            this.LuongNVbtn = new FontAwesome.Sharp.IconButton();
            this.thongkePanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.errorBtn);
            this.panel1.Controls.Add(this.LuongNVbtn);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(304, 590);
            this.panel1.TabIndex = 0;
            // 
            // errorBtn
            // 
            this.errorBtn.BackColor = System.Drawing.Color.Peru;
            this.errorBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.errorBtn.IconChar = FontAwesome.Sharp.IconChar.Tasks;
            this.errorBtn.IconColor = System.Drawing.Color.WhiteSmoke;
            this.errorBtn.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.errorBtn.IconSize = 45;
            this.errorBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.errorBtn.Location = new System.Drawing.Point(14, 202);
            this.errorBtn.Name = "errorBtn";
            this.errorBtn.Size = new System.Drawing.Size(265, 67);
            this.errorBtn.TabIndex = 6;
            this.errorBtn.Text = " Thống kê sách mượn theo ngày";
            this.errorBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.errorBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.errorBtn.UseVisualStyleBackColor = false;
            this.errorBtn.Click += new System.EventHandler(this.errorBtn_Click);
            // 
            // LuongNVbtn
            // 
            this.LuongNVbtn.BackColor = System.Drawing.Color.Peru;
            this.LuongNVbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LuongNVbtn.ForeColor = System.Drawing.Color.White;
            this.LuongNVbtn.IconChar = FontAwesome.Sharp.IconChar.MoneyBill;
            this.LuongNVbtn.IconColor = System.Drawing.Color.White;
            this.LuongNVbtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.LuongNVbtn.IconSize = 50;
            this.LuongNVbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LuongNVbtn.Location = new System.Drawing.Point(14, 78);
            this.LuongNVbtn.Name = "LuongNVbtn";
            this.LuongNVbtn.Size = new System.Drawing.Size(265, 67);
            this.LuongNVbtn.TabIndex = 0;
            this.LuongNVbtn.Text = "   Lương nhân viên";
            this.LuongNVbtn.UseVisualStyleBackColor = false;
            this.LuongNVbtn.Click += new System.EventHandler(this.LuongNVbtn_Click);
            // 
            // thongkePanel
            // 
            this.thongkePanel.BackColor = System.Drawing.Color.Peru;
            this.thongkePanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.thongkePanel.Location = new System.Drawing.Point(304, 0);
            this.thongkePanel.Name = "thongkePanel";
            this.thongkePanel.Size = new System.Drawing.Size(1196, 590);
            this.thongkePanel.TabIndex = 1;
            // 
            // thongkeMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1500, 590);
            this.Controls.Add(this.thongkePanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "thongkeMain";
            this.Text = "thongkeMain";
            this.Load += new System.EventHandler(this.thongkeMain_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel thongkePanel;
        private FontAwesome.Sharp.IconButton LuongNVbtn;
        private FontAwesome.Sharp.IconButton errorBtn;
    }
}