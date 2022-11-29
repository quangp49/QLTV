
namespace QLTV_OOP.GUI.Hệ_thống
{
    partial class hethongMain
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
            this.hethongPanel = new System.Windows.Forms.Panel();
            this.authenBtn = new FontAwesome.Sharp.IconButton();
            this.createUserBtn = new FontAwesome.Sharp.IconButton();
            this.changePwBtn = new FontAwesome.Sharp.IconButton();
            this.userInfoBtn = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.authenBtn);
            this.panel1.Controls.Add(this.createUserBtn);
            this.panel1.Controls.Add(this.changePwBtn);
            this.panel1.Controls.Add(this.userInfoBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(304, 590);
            this.panel1.TabIndex = 0;
            // 
            // hethongPanel
            // 
            this.hethongPanel.BackColor = System.Drawing.Color.Peru;
            this.hethongPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hethongPanel.Location = new System.Drawing.Point(304, 0);
            this.hethongPanel.Name = "hethongPanel";
            this.hethongPanel.Size = new System.Drawing.Size(1196, 590);
            this.hethongPanel.TabIndex = 1;
            // 
            // authenBtn
            // 
            this.authenBtn.BackColor = System.Drawing.Color.Peru;
            this.authenBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authenBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.authenBtn.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.authenBtn.IconColor = System.Drawing.Color.White;
            this.authenBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.authenBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.authenBtn.Location = new System.Drawing.Point(21, 376);
            this.authenBtn.Name = "authenBtn";
            this.authenBtn.Size = new System.Drawing.Size(250, 70);
            this.authenBtn.TabIndex = 6;
            this.authenBtn.Text = "Phân quyền";
            this.authenBtn.UseVisualStyleBackColor = false;
            this.authenBtn.Click += new System.EventHandler(this.authenBtn_Click_1);
            // 
            // createUserBtn
            // 
            this.createUserBtn.BackColor = System.Drawing.Color.Peru;
            this.createUserBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createUserBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.createUserBtn.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.createUserBtn.IconColor = System.Drawing.Color.White;
            this.createUserBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.createUserBtn.IconSize = 45;
            this.createUserBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.createUserBtn.Location = new System.Drawing.Point(21, 270);
            this.createUserBtn.Name = "createUserBtn";
            this.createUserBtn.Size = new System.Drawing.Size(250, 70);
            this.createUserBtn.TabIndex = 5;
            this.createUserBtn.Text = "    Đăng ký tài khoản";
            this.createUserBtn.UseVisualStyleBackColor = false;
            this.createUserBtn.Click += new System.EventHandler(this.createUserBtn_Click_1);
            // 
            // changePwBtn
            // 
            this.changePwBtn.BackColor = System.Drawing.Color.Peru;
            this.changePwBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePwBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.changePwBtn.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.changePwBtn.IconColor = System.Drawing.Color.White;
            this.changePwBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.changePwBtn.IconSize = 45;
            this.changePwBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.changePwBtn.Location = new System.Drawing.Point(21, 167);
            this.changePwBtn.Name = "changePwBtn";
            this.changePwBtn.Size = new System.Drawing.Size(250, 70);
            this.changePwBtn.TabIndex = 4;
            this.changePwBtn.Text = "Đổi mật khẩu";
            this.changePwBtn.UseVisualStyleBackColor = false;
            this.changePwBtn.Click += new System.EventHandler(this.changePwBtn_Click_1);
            // 
            // userInfoBtn
            // 
            this.userInfoBtn.BackColor = System.Drawing.Color.Peru;
            this.userInfoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userInfoBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.userInfoBtn.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.userInfoBtn.IconColor = System.Drawing.Color.White;
            this.userInfoBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.userInfoBtn.IconSize = 45;
            this.userInfoBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.userInfoBtn.Location = new System.Drawing.Point(21, 60);
            this.userInfoBtn.Name = "userInfoBtn";
            this.userInfoBtn.Size = new System.Drawing.Size(250, 70);
            this.userInfoBtn.TabIndex = 0;
            this.userInfoBtn.Text = "    Thông tin tài khoản";
            this.userInfoBtn.UseVisualStyleBackColor = false;
            this.userInfoBtn.Click += new System.EventHandler(this.userInfoBtn_Click_1);
            // 
            // hethongMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1500, 590);
            this.Controls.Add(this.hethongPanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "hethongMain";
            this.Text = "hethongMain";
            this.Load += new System.EventHandler(this.hethongMain_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel hethongPanel;
        private FontAwesome.Sharp.IconButton authenBtn;
        private FontAwesome.Sharp.IconButton createUserBtn;
        private FontAwesome.Sharp.IconButton changePwBtn;
        private FontAwesome.Sharp.IconButton userInfoBtn;
    }
}