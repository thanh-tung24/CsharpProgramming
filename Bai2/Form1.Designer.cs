namespace Bai2
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
            this.trvDanhSachLop = new System.Windows.Forms.TreeView();
            this.lblChonLop = new System.Windows.Forms.Label();
            this.cboLop = new System.Windows.Forms.ComboBox();
            this.gbThongTinSV = new System.Windows.Forms.GroupBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblMaSV = new System.Windows.Forms.Label();
            this.chkThemLop = new System.Windows.Forms.CheckBox();
            this.gbThongTinLop = new System.Windows.Forms.GroupBox();
            this.btnThemLop = new System.Windows.Forms.Button();
            this.txtTenLop = new System.Windows.Forms.TextBox();
            this.lblTenLop = new System.Windows.Forms.Label();
            this.gbThongTinSV.SuspendLayout();
            this.gbThongTinLop.SuspendLayout();
            this.SuspendLayout();
            // 
            // trvDanhSachLop
            // 
            this.trvDanhSachLop.Location = new System.Drawing.Point(12, 12);
            this.trvDanhSachLop.Name = "trvDanhSachLop";
            this.trvDanhSachLop.Size = new System.Drawing.Size(280, 480);
            this.trvDanhSachLop.TabIndex = 0;
            this.trvDanhSachLop.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvDanhSachLop_AfterSelect);
            // 
            // lblChonLop
            // 
            this.lblChonLop.AutoSize = true;
            this.lblChonLop.Location = new System.Drawing.Point(320, 20);
            this.lblChonLop.Name = "lblChonLop";
            this.lblChonLop.Size = new System.Drawing.Size(64, 16);
            this.lblChonLop.TabIndex = 1;
            this.lblChonLop.Text = "Chọn Lớp";
            // 
            // cboLop
            // 
            this.cboLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLop.FormattingEnabled = true;
            this.cboLop.Location = new System.Drawing.Point(400, 16);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new System.Drawing.Size(270, 24);
            this.cboLop.TabIndex = 2;
            // 
            // gbThongTinSV
            // 
            this.gbThongTinSV.Controls.Add(this.btnXoa);
            this.gbThongTinSV.Controls.Add(this.btnCapNhat);
            this.gbThongTinSV.Controls.Add(this.txtDiaChi);
            this.gbThongTinSV.Controls.Add(this.txtHoTen);
            this.gbThongTinSV.Controls.Add(this.txtMaSV);
            this.gbThongTinSV.Controls.Add(this.lblDiaChi);
            this.gbThongTinSV.Controls.Add(this.lblHoTen);
            this.gbThongTinSV.Controls.Add(this.lblMaSV);
            this.gbThongTinSV.Location = new System.Drawing.Point(310, 60);
            this.gbThongTinSV.Name = "gbThongTinSV";
            this.gbThongTinSV.Size = new System.Drawing.Size(370, 240);
            this.gbThongTinSV.TabIndex = 3;
            this.gbThongTinSV.TabStop = false;
            this.gbThongTinSV.Text = "Thông tin sinh viên";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(235, 185);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 35);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(100, 185);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(100, 35);
            this.btnCapNhat.TabIndex = 6;
            this.btnCapNhat.Text = "Cập Nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(100, 135);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(245, 22);
            this.txtDiaChi.TabIndex = 5;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(100, 85);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(245, 22);
            this.txtHoTen.TabIndex = 3;
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(100, 35);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(245, 22);
            this.txtMaSV.TabIndex = 1;
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(20, 138);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(49, 16);
            this.lblDiaChi.TabIndex = 4;
            this.lblDiaChi.Text = "Địa Chỉ";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(20, 88);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(52, 16);
            this.lblHoTen.TabIndex = 2;
            this.lblHoTen.Text = "Họ Tên";
            // 
            // lblMaSV
            // 
            this.lblMaSV.AutoSize = true;
            this.lblMaSV.Location = new System.Drawing.Point(20, 38);
            this.lblMaSV.Name = "lblMaSV";
            this.lblMaSV.Size = new System.Drawing.Size(47, 16);
            this.lblMaSV.TabIndex = 0;
            this.lblMaSV.Text = "Mã SV";
            // 
            // chkThemLop
            // 
            this.chkThemLop.AutoSize = true;
            this.chkThemLop.Location = new System.Drawing.Point(310, 320);
            this.chkThemLop.Name = "chkThemLop";
            this.chkThemLop.Size = new System.Drawing.Size(89, 20);
            this.chkThemLop.TabIndex = 4;
            this.chkThemLop.Text = "Thêm lớp";
            this.chkThemLop.UseVisualStyleBackColor = true;
            this.chkThemLop.CheckedChanged += new System.EventHandler(this.chkThemLop_CheckedChanged);
            // 
            // gbThongTinLop
            // 
            this.gbThongTinLop.Controls.Add(this.btnThemLop);
            this.gbThongTinLop.Controls.Add(this.txtTenLop);
            this.gbThongTinLop.Controls.Add(this.lblTenLop);
            this.gbThongTinLop.Location = new System.Drawing.Point(310, 350);
            this.gbThongTinLop.Name = "gbThongTinLop";
            this.gbThongTinLop.Size = new System.Drawing.Size(370, 130);
            this.gbThongTinLop.TabIndex = 5;
            this.gbThongTinLop.TabStop = false;
            this.gbThongTinLop.Text = "Thông tin lớp";
            this.gbThongTinLop.Visible = false;
            // 
            // btnThemLop
            // 
            this.btnThemLop.Location = new System.Drawing.Point(235, 75);
            this.btnThemLop.Name = "btnThemLop";
            this.btnThemLop.Size = new System.Drawing.Size(100, 35);
            this.btnThemLop.TabIndex = 2;
            this.btnThemLop.Text = "Thêm lớp";
            this.btnThemLop.UseVisualStyleBackColor = true;
            this.btnThemLop.Click += new System.EventHandler(this.btnThemLop_Click);
            // 
            // txtTenLop
            // 
            this.txtTenLop.Location = new System.Drawing.Point(100, 35);
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Size = new System.Drawing.Size(245, 22);
            this.txtTenLop.TabIndex = 1;
            // 
            // lblTenLop
            // 
            this.lblTenLop.AutoSize = true;
            this.lblTenLop.Location = new System.Drawing.Point(20, 38);
            this.lblTenLop.Name = "lblTenLop";
            this.lblTenLop.Size = new System.Drawing.Size(56, 16);
            this.lblTenLop.TabIndex = 0;
            this.lblTenLop.Text = "Tên lớp";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 510);
            this.Controls.Add(this.gbThongTinLop);
            this.Controls.Add(this.chkThemLop);
            this.Controls.Add(this.gbThongTinSV);
            this.Controls.Add(this.cboLop);
            this.Controls.Add(this.lblChonLop);
            this.Controls.Add(this.trvDanhSachLop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý sinh viên";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbThongTinSV.ResumeLayout(false);
            this.gbThongTinSV.PerformLayout();
            this.gbThongTinLop.ResumeLayout(false);
            this.gbThongTinLop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TreeView trvDanhSachLop;
        private System.Windows.Forms.Label lblChonLop;
        private System.Windows.Forms.ComboBox cboLop;
        private System.Windows.Forms.GroupBox gbThongTinSV;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblMaSV;
        private System.Windows.Forms.CheckBox chkThemLop;
        private System.Windows.Forms.GroupBox gbThongTinLop;
        private System.Windows.Forms.Button btnThemLop;
        private System.Windows.Forms.TextBox txtTenLop;
        private System.Windows.Forms.Label lblTenLop;
    }
}