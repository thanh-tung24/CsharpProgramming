namespace Bai1
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
            this.gbNhapSo = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.cboSo = new System.Windows.Forms.ComboBox();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.txtNhapSo = new System.Windows.Forms.TextBox();
            this.gbDanhSachUocSo = new System.Windows.Forms.GroupBox();
            this.lstUocSo = new System.Windows.Forms.ListBox();
            this.btnTongUocSo = new System.Windows.Forms.Button();
            this.btnSoLuongUocSoChan = new System.Windows.Forms.Button();
            this.btnSoLuongUocSoNguyenTo = new System.Windows.Forms.Button();
            this.gbNhapSo.SuspendLayout();
            this.gbDanhSachUocSo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbNhapSo
            // 
            this.gbNhapSo.Controls.Add(this.btnThoat);
            this.gbNhapSo.Controls.Add(this.cboSo);
            this.gbNhapSo.Controls.Add(this.btnCapNhat);
            this.gbNhapSo.Controls.Add(this.txtNhapSo);
            this.gbNhapSo.Location = new System.Drawing.Point(20, 20);
            this.gbNhapSo.Name = "gbNhapSo";
            this.gbNhapSo.Size = new System.Drawing.Size(260, 260);
            this.gbNhapSo.TabIndex = 0;
            this.gbNhapSo.TabStop = false;
            this.gbNhapSo.Text = "Nhập Số";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(145, 205);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(95, 35);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "&Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // cboSo
            // 
            this.cboSo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSo.FormattingEnabled = true;
            this.cboSo.Location = new System.Drawing.Point(15, 80);
            this.cboSo.Name = "cboSo";
            this.cboSo.Size = new System.Drawing.Size(225, 24);
            this.cboSo.TabIndex = 2;
            this.cboSo.SelectedIndexChanged += new System.EventHandler(this.cboSo_SelectedIndexChanged);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(145, 30);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(95, 30);
            this.btnCapNhat.TabIndex = 1;
            this.btnCapNhat.Text = "&Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // txtNhapSo
            // 
            this.txtNhapSo.Location = new System.Drawing.Point(15, 34);
            this.txtNhapSo.Name = "txtNhapSo";
            this.txtNhapSo.Size = new System.Drawing.Size(120, 22);
            this.txtNhapSo.TabIndex = 0;
            this.txtNhapSo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNhapSo_KeyPress);
            // 
            // gbDanhSachUocSo
            // 
            this.gbDanhSachUocSo.Controls.Add(this.lstUocSo);
            this.gbDanhSachUocSo.Location = new System.Drawing.Point(295, 20);
            this.gbDanhSachUocSo.Name = "gbDanhSachUocSo";
            this.gbDanhSachUocSo.Size = new System.Drawing.Size(265, 140);
            this.gbDanhSachUocSo.TabIndex = 1;
            this.gbDanhSachUocSo.TabStop = false;
            this.gbDanhSachUocSo.Text = "Danh sách các ước số";
            // 
            // lstUocSo
            // 
            this.lstUocSo.FormattingEnabled = true;
            this.lstUocSo.ItemHeight = 16;
            this.lstUocSo.Location = new System.Drawing.Point(15, 25);
            this.lstUocSo.Name = "lstUocSo";
            this.lstUocSo.Size = new System.Drawing.Size(235, 100);
            this.lstUocSo.TabIndex = 0;
            // 
            // btnTongUocSo
            // 
            this.btnTongUocSo.Location = new System.Drawing.Point(295, 170);
            this.btnTongUocSo.Name = "btnTongUocSo";
            this.btnTongUocSo.Size = new System.Drawing.Size(265, 30);
            this.btnTongUocSo.TabIndex = 2;
            this.btnTongUocSo.Text = "&Tổng các ước số";
            this.btnTongUocSo.UseVisualStyleBackColor = true;
            this.btnTongUocSo.Click += new System.EventHandler(this.btnTongUocSo_Click);
            // 
            // btnSoLuongUocSoChan
            // 
            this.btnSoLuongUocSoChan.Location = new System.Drawing.Point(295, 210);
            this.btnSoLuongUocSoChan.Name = "btnSoLuongUocSoChan";
            this.btnSoLuongUocSoChan.Size = new System.Drawing.Size(265, 30);
            this.btnSoLuongUocSoChan.TabIndex = 3;
            this.btnSoLuongUocSoChan.Text = "Số &lượng các ước số chẵn";
            this.btnSoLuongUocSoChan.UseVisualStyleBackColor = true;
            this.btnSoLuongUocSoChan.Click += new System.EventHandler(this.btnSoLuongUocSoChan_Click);
            // 
            // btnSoLuongUocSoNguyenTo
            // 
            this.btnSoLuongUocSoNguyenTo.Location = new System.Drawing.Point(295, 250);
            this.btnSoLuongUocSoNguyenTo.Name = "btnSoLuongUocSoNguyenTo";
            this.btnSoLuongUocSoNguyenTo.Size = new System.Drawing.Size(265, 30);
            this.btnSoLuongUocSoNguyenTo.TabIndex = 4;
            this.btnSoLuongUocSoNguyenTo.Text = "Số lượng các ước số &nguyên tố";
            this.btnSoLuongUocSoNguyenTo.UseVisualStyleBackColor = true;
            this.btnSoLuongUocSoNguyenTo.Click += new System.EventHandler(this.btnSoLuongUocSoNguyenTo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 300);
            this.Controls.Add(this.btnSoLuongUocSoNguyenTo);
            this.Controls.Add(this.btnSoLuongUocSoChan);
            this.Controls.Add(this.btnTongUocSo);
            this.Controls.Add(this.gbDanhSachUocSo);
            this.Controls.Add(this.gbNhapSo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Combobox";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.gbNhapSo.ResumeLayout(false);
            this.gbNhapSo.PerformLayout();
            this.gbDanhSachUocSo.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox gbNhapSo;
        private System.Windows.Forms.TextBox txtNhapSo;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.ComboBox cboSo;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox gbDanhSachUocSo;
        private System.Windows.Forms.ListBox lstUocSo;
        private System.Windows.Forms.Button btnTongUocSo;
        private System.Windows.Forms.Button btnSoLuongUocSoChan;
        private System.Windows.Forms.Button btnSoLuongUocSoNguyenTo;
    }
}