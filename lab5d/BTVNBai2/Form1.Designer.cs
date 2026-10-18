namespace BTVNBai2
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.mnuHeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBaiTapTaiLop = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBai1TaiLop = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBai2TaiLop = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBaiTapNangCao = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBai1NangCao = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBaiTapVeNha = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBTVN1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lblHuongDan = new System.Windows.Forms.Label();
            this.menuStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuStripMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHeThong,
            this.mnuBaiTapTaiLop,
            this.mnuBaiTapNangCao,
            this.mnuBaiTapVeNha});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(800, 31);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "menuStripMain";
            // 
            // mnuHeThong
            // 
            this.mnuHeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuThoat});
            this.mnuHeThong.Name = "mnuHeThong";
            this.mnuHeThong.Size = new System.Drawing.Size(96, 27);
            this.mnuHeThong.Text = "&Hệ Thống";
            // 
            // mnuThoat
            // 
            this.mnuThoat.Name = "mnuThoat";
            this.mnuThoat.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.mnuThoat.Size = new System.Drawing.Size(200, 28);
            this.mnuThoat.Text = "Thoát";
            this.mnuThoat.Click += new System.EventHandler(this.mnuThoat_Click);
            // 
            // mnuBaiTapTaiLop
            // 
            this.mnuBaiTapTaiLop.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBai1TaiLop,
            this.mnuBai2TaiLop});
            this.mnuBaiTapTaiLop.Name = "mnuBaiTapTaiLop";
            this.mnuBaiTapTaiLop.Size = new System.Drawing.Size(146, 27);
            this.mnuBaiTapTaiLop.Text = "Bài Tập Tại &Lớp";
            // 
            // mnuBai1TaiLop
            // 
            this.mnuBai1TaiLop.Name = "mnuBai1TaiLop";
            this.mnuBai1TaiLop.Size = new System.Drawing.Size(306, 28);
            this.mnuBai1TaiLop.Text = "Bài 1: Quản lý sinh viên";
            this.mnuBai1TaiLop.Click += new System.EventHandler(this.mnuBai1TaiLop_Click);
            // 
            // mnuBai2TaiLop
            // 
            this.mnuBai2TaiLop.Name = "mnuBai2TaiLop";
            this.mnuBai2TaiLop.Size = new System.Drawing.Size(306, 28);
            this.mnuBai2TaiLop.Text = "Bài 2: Quản lý tài khoản";
            this.mnuBai2TaiLop.Click += new System.EventHandler(this.mnuBai2TaiLop_Click);
            // 
            // mnuBaiTapNangCao
            // 
            this.mnuBaiTapNangCao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBai1NangCao});
            this.mnuBaiTapNangCao.Name = "mnuBaiTapNangCao";
            this.mnuBaiTapNangCao.Size = new System.Drawing.Size(161, 27);
            this.mnuBaiTapNangCao.Text = "Bài Tập &Nâng Cao";
            // 
            // mnuBai1NangCao
            // 
            this.mnuBai1NangCao.Name = "mnuBai1NangCao";
            this.mnuBai1NangCao.Size = new System.Drawing.Size(263, 28);
            this.mnuBai1NangCao.Text = "Bài 1: Quản lý học viên";
            this.mnuBai1NangCao.Click += new System.EventHandler(this.mnuBai1NangCao_Click);
            // 
            // mnuBaiTapVeNha
            // 
            this.mnuBaiTapVeNha.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBTVN1});
            this.mnuBaiTapVeNha.Name = "mnuBaiTapVeNha";
            this.mnuBaiTapVeNha.Size = new System.Drawing.Size(143, 27);
            this.mnuBaiTapVeNha.Text = "Bài Tập Về &Nhà";
            // 
            // mnuBTVN1
            // 
            this.mnuBTVN1.Name = "mnuBTVN1";
            this.mnuBTVN1.Size = new System.Drawing.Size(277, 28);
            this.mnuBTVN1.Text = "Bài 1: Đếm ngược thời gian";
            this.mnuBTVN1.Click += new System.EventHandler(this.mnuBTVN1_Click);
            // 
            // lblHuongDan
            // 
            this.lblHuongDan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblHuongDan.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Italic);
            this.lblHuongDan.ForeColor = System.Drawing.Color.DimGray;
            this.lblHuongDan.Location = new System.Drawing.Point(0, 460);
            this.lblHuongDan.Name = "lblHuongDan";
            this.lblHuongDan.Size = new System.Drawing.Size(800, 40);
            this.lblHuongDan.TabIndex = 1;
            this.lblHuongDan.Text = "Chọn bài tập từ thanh Menu phía trên để khởi chạy chức năng.";
            this.lblHuongDan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.lblHuongDan);
            this.Controls.Add(this.menuStripMain);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CHƯƠNG TRÌNH TỔNG HỢP LAB 05d";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem mnuHeThong;
        private System.Windows.Forms.ToolStripMenuItem mnuThoat;
        private System.Windows.Forms.ToolStripMenuItem mnuBaiTapTaiLop;
        private System.Windows.Forms.ToolStripMenuItem mnuBai1TaiLop;
        private System.Windows.Forms.ToolStripMenuItem mnuBai2TaiLop;
        private System.Windows.Forms.ToolStripMenuItem mnuBaiTapNangCao;
        private System.Windows.Forms.ToolStripMenuItem mnuBai1NangCao;
        private System.Windows.Forms.ToolStripMenuItem mnuBaiTapVeNha;
        private System.Windows.Forms.ToolStripMenuItem mnuBTVN1;
        private System.Windows.Forms.Label lblHuongDan;
    }
}