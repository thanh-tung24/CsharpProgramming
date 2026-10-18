namespace BaiNangCao
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuCapNhat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNhapHocVienMoi = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChuyenSangLopB = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChuyenSangLopA = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuXoaHocVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKetThuc = new System.Windows.Forms.ToolStripMenuItem();
            this.lblLopA = new System.Windows.Forms.Label();
            this.lblLopB = new System.Windows.Forms.Label();
            this.lstLopA = new System.Windows.Forms.ListBox();
            this.lstLopB = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCapNhat,
            this.mnuKetThuc});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(460, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuCapNhat
            // 
            this.mnuCapNhat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNhapHocVienMoi,
            this.mnuChuyenSangLopB,
            this.mnuChuyenSangLopA,
            this.mnuXoaHocVien});
            this.mnuCapNhat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.mnuCapNhat.Name = "mnuCapNhat";
            this.mnuCapNhat.Size = new System.Drawing.Size(86, 24);
            this.mnuCapNhat.Text = "Cập nhật";
            // 
            // mnuNhapHocVienMoi
            // 
            this.mnuNhapHocVienMoi.Name = "mnuNhapHocVienMoi";
            this.mnuNhapHocVienMoi.Size = new System.Drawing.Size(224, 26);
            this.mnuNhapHocVienMoi.Text = "Nhập học viên mới";
            this.mnuNhapHocVienMoi.Click += new System.EventHandler(this.mnuNhapHocVienMoi_Click);
            // 
            // mnuChuyenSangLopB
            // 
            this.mnuChuyenSangLopB.Name = "mnuChuyenSangLopB";
            this.mnuChuyenSangLopB.Size = new System.Drawing.Size(224, 26);
            this.mnuChuyenSangLopB.Text = "Chuyển sang lớp B";
            this.mnuChuyenSangLopB.Click += new System.EventHandler(this.mnuChuyenSangLopB_Click);
            // 
            // mnuChuyenSangLopA
            // 
            this.mnuChuyenSangLopA.Name = "mnuChuyenSangLopA";
            this.mnuChuyenSangLopA.Size = new System.Drawing.Size(224, 26);
            this.mnuChuyenSangLopA.Text = "Chuyển sang lớp A";
            this.mnuChuyenSangLopA.Click += new System.EventHandler(this.mnuChuyenSangLopA_Click);
            // 
            // mnuXoaHocVien
            // 
            this.mnuXoaHocVien.Name = "mnuXoaHocVien";
            this.mnuXoaHocVien.Size = new System.Drawing.Size(224, 26);
            this.mnuXoaHocVien.Text = "Xóa học viên";
            this.mnuXoaHocVien.Click += new System.EventHandler(this.mnuXoaHocVien_Click);
            // 
            // mnuKetThuc
            // 
            this.mnuKetThuc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.mnuKetThuc.Name = "mnuKetThuc";
            this.mnuKetThuc.Size = new System.Drawing.Size(82, 24);
            this.mnuKetThuc.Text = "Kết thúc";
            this.mnuKetThuc.Click += new System.EventHandler(this.mnuKetThuc_Click);
            // 
            // lblLopA
            // 
            this.lblLopA.AutoSize = true;
            this.lblLopA.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblLopA.Location = new System.Drawing.Point(30, 45);
            this.lblLopA.Name = "lblLopA";
            this.lblLopA.Size = new System.Drawing.Size(59, 21);
            this.lblLopA.TabIndex = 1;
            this.lblLopA.Text = "Lớp A";
            // 
            // lblLopB
            // 
            this.lblLopB.AutoSize = true;
            this.lblLopB.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblLopB.Location = new System.Drawing.Point(245, 45);
            this.lblLopB.Name = "lblLopB";
            this.lblLopB.Size = new System.Drawing.Size(58, 21);
            this.lblLopB.TabIndex = 2;
            this.lblLopB.Text = "Lớp B";
            // 
            // lstLopA
            // 
            this.lstLopA.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lstLopA.FormattingEnabled = true;
            this.lstLopA.ItemHeight = 21;
            this.lstLopA.Location = new System.Drawing.Point(30, 75);
            this.lstLopA.Name = "lstLopA";
            this.lstLopA.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstLopA.Size = new System.Drawing.Size(185, 235);
            this.lstLopA.TabIndex = 3;
            // 
            // lstLopB
            // 
            this.lstLopB.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lstLopB.FormattingEnabled = true;
            this.lstLopB.ItemHeight = 21;
            this.lstLopB.Location = new System.Drawing.Point(245, 75);
            this.lstLopB.Name = "lstLopB";
            this.lstLopB.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstLopB.Size = new System.Drawing.Size(185, 235);
            this.lstLopB.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 335);
            this.Controls.Add(this.lstLopB);
            this.Controls.Add(this.lstLopA);
            this.Controls.Add(this.lblLopB);
            this.Controls.Add(this.lblLopA);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý học viên";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuCapNhat;
        private System.Windows.Forms.ToolStripMenuItem mnuNhapHocVienMoi;
        private System.Windows.Forms.ToolStripMenuItem mnuChuyenSangLopB;
        private System.Windows.Forms.ToolStripMenuItem mnuChuyenSangLopA;
        private System.Windows.Forms.ToolStripMenuItem mnuXoaHocVien;
        private System.Windows.Forms.ToolStripMenuItem mnuKetThuc;
        private System.Windows.Forms.Label lblLopA;
        private System.Windows.Forms.Label lblLopB;
        private System.Windows.Forms.ListBox lstLopA;
        private System.Windows.Forms.ListBox lstLopB;
    }
}