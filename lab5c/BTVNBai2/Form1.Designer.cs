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
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.lblNhap = new System.Windows.Forms.Label();
            this.txtNhap = new System.Windows.Forms.TextBox();
            this.btnNhap = new System.Windows.Forms.Button();
            this.lstSo = new System.Windows.Forms.ListBox();
            this.gbXuLy = new System.Windows.Forms.GroupBox();
            this.btnChonLe = new System.Windows.Forms.Button();
            this.btnChonChan = new System.Windows.Forms.Button();
            this.btnThayBinhPhuong = new System.Windows.Forms.Button();
            this.btnTangMoiPhanTu = new System.Windows.Forms.Button();
            this.btnXoaDangChon = new System.Windows.Forms.Button();
            this.btnXoaDauCuoi = new System.Windows.Forms.Button();
            this.btnTongPhanTu = new System.Windows.Forms.Button();
            this.btnKetThuc = new System.Windows.Forms.Button();
            this.gbXuLy.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblTieuDe.Location = new System.Drawing.Point(180, 15);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(143, 36);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "LISTBOX";
            // 
            // lblNhap
            // 
            this.lblNhap.AutoSize = true;
            this.lblNhap.Location = new System.Drawing.Point(25, 60);
            this.lblNhap.Name = "lblNhap";
            this.lblNhap.Size = new System.Drawing.Size(52, 16);
            this.lblNhap.TabIndex = 1;
            this.lblNhap.Text = "Listbox:";
            // 
            // txtNhap
            // 
            this.txtNhap.Location = new System.Drawing.Point(25, 80);
            this.txtNhap.Name = "txtNhap";
            this.txtNhap.Size = new System.Drawing.Size(175, 22);
            this.txtNhap.TabIndex = 2;
            this.txtNhap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNhap_KeyPress);
            // 
            // btnNhap
            // 
            this.btnNhap.Location = new System.Drawing.Point(25, 110);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(175, 30);
            this.btnNhap.TabIndex = 3;
            this.btnNhap.Text = "&Nhập";
            this.btnNhap.UseVisualStyleBackColor = true;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // lstSo
            // 
            this.lstSo.FormattingEnabled = true;
            this.lstSo.ItemHeight = 16;
            this.lstSo.Location = new System.Drawing.Point(25, 150);
            this.lstSo.Name = "lstSo";
            this.lstSo.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstSo.Size = new System.Drawing.Size(175, 228);
            this.lstSo.TabIndex = 4;
            // 
            // gbXuLy
            // 
            this.gbXuLy.Controls.Add(this.btnChonLe);
            this.gbXuLy.Controls.Add(this.btnChonChan);
            this.gbXuLy.Controls.Add(this.btnThayBinhPhuong);
            this.gbXuLy.Controls.Add(this.btnTangMoiPhanTu);
            this.gbXuLy.Controls.Add(this.btnXoaDangChon);
            this.gbXuLy.Controls.Add(this.btnXoaDauCuoi);
            this.gbXuLy.Controls.Add(this.btnTongPhanTu);
            this.gbXuLy.Location = new System.Drawing.Point(220, 60);
            this.gbXuLy.Name = "gbXuLy";
            this.gbXuLy.Size = new System.Drawing.Size(260, 318);
            this.gbXuLy.TabIndex = 5;
            this.gbXuLy.TabStop = false;
            this.gbXuLy.Text = "Xử lý Listbox";
            // 
            // btnChonLe
            // 
            this.btnChonLe.Location = new System.Drawing.Point(15, 272);
            this.btnChonLe.Name = "btnChonLe";
            this.btnChonLe.Size = new System.Drawing.Size(230, 32);
            this.btnChonLe.TabIndex = 6;
            this.btnChonLe.Text = "Chọn số lẻ";
            this.btnChonLe.UseVisualStyleBackColor = true;
            this.btnChonLe.Click += new System.EventHandler(this.btnChonLe_Click);
            // 
            // btnChonChan
            // 
            this.btnChonChan.Location = new System.Drawing.Point(15, 230);
            this.btnChonChan.Name = "btnChonChan";
            this.btnChonChan.Size = new System.Drawing.Size(230, 32);
            this.btnChonChan.TabIndex = 5;
            this.btnChonChan.Text = "Chọn số chẵn";
            this.btnChonChan.UseVisualStyleBackColor = true;
            this.btnChonChan.Click += new System.EventHandler(this.btnChonChan_Click);
            // 
            // btnThayBinhPhuong
            // 
            this.btnThayBinhPhuong.Location = new System.Drawing.Point(15, 188);
            this.btnThayBinhPhuong.Name = "btnThayBinhPhuong";
            this.btnThayBinhPhuong.Size = new System.Drawing.Size(230, 32);
            this.btnThayBinhPhuong.TabIndex = 4;
            this.btnThayBinhPhuong.Text = "Thay bằng bình phương";
            this.btnThayBinhPhuong.UseVisualStyleBackColor = true;
            this.btnThayBinhPhuong.Click += new System.EventHandler(this.btnThayBinhPhuong_Click);
            // 
            // btnTangMoiPhanTu
            // 
            this.btnTangMoiPhanTu.Location = new System.Drawing.Point(15, 146);
            this.btnTangMoiPhanTu.Name = "btnTangMoiPhanTu";
            this.btnTangMoiPhanTu.Size = new System.Drawing.Size(230, 32);
            this.btnTangMoiPhanTu.TabIndex = 3;
            this.btnTangMoiPhanTu.Text = "Tăng mỗi phần tử lên 2";
            this.btnTangMoiPhanTu.UseVisualStyleBackColor = true;
            this.btnTangMoiPhanTu.Click += new System.EventHandler(this.btnTangMoiPhanTu_Click);
            // 
            // btnXoaDangChon
            // 
            this.btnXoaDangChon.Location = new System.Drawing.Point(15, 104);
            this.btnXoaDangChon.Name = "btnXoaDangChon";
            this.btnXoaDangChon.Size = new System.Drawing.Size(230, 32);
            this.btnXoaDangChon.TabIndex = 2;
            this.btnXoaDangChon.Text = "Xóa Phần tử đang chọn";
            this.btnXoaDangChon.UseVisualStyleBackColor = true;
            this.btnXoaDangChon.Click += new System.EventHandler(this.btnXoaDangChon_Click);
            // 
            // btnXoaDauCuoi
            // 
            this.btnXoaDauCuoi.Location = new System.Drawing.Point(15, 62);
            this.btnXoaDauCuoi.Name = "btnXoaDauCuoi";
            this.btnXoaDauCuoi.Size = new System.Drawing.Size(230, 32);
            this.btnXoaDauCuoi.TabIndex = 1;
            this.btnXoaDauCuoi.Text = "Xóa Phần tử đầu và cuối";
            this.btnXoaDauCuoi.UseVisualStyleBackColor = true;
            this.btnXoaDauCuoi.Click += new System.EventHandler(this.btnXoaDauCuoi_Click);
            // 
            // btnTongPhanTu
            // 
            this.btnTongPhanTu.Location = new System.Drawing.Point(15, 20);
            this.btnTongPhanTu.Name = "btnTongPhanTu";
            this.btnTongPhanTu.Size = new System.Drawing.Size(230, 32);
            this.btnTongPhanTu.TabIndex = 0;
            this.btnTongPhanTu.Text = "Tổng các phần tử trong List";
            this.btnTongPhanTu.UseVisualStyleBackColor = true;
            this.btnTongPhanTu.Click += new System.EventHandler(this.btnTongPhanTu_Click);
            // 
            // btnKetThuc
            // 
            this.btnKetThuc.Location = new System.Drawing.Point(25, 390);
            this.btnKetThuc.Name = "btnKetThuc";
            this.btnKetThuc.Size = new System.Drawing.Size(455, 35);
            this.btnKetThuc.TabIndex = 6;
            this.btnKetThuc.Text = "KẾT THÚC";
            this.btnKetThuc.UseVisualStyleBackColor = true;
            this.btnKetThuc.Click += new System.EventHandler(this.btnKetThuc_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnNhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 440);
            this.Controls.Add(this.btnKetThuc);
            this.Controls.Add(this.gbXuLy);
            this.Controls.Add(this.lstSo);
            this.Controls.Add(this.btnNhap);
            this.Controls.Add(this.txtNhap);
            this.Controls.Add(this.lblNhap);
            this.Controls.Add(this.lblTieuDe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmListBox";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbXuLy.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblNhap;
        private System.Windows.Forms.TextBox txtNhap;
        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.ListBox lstSo;
        private System.Windows.Forms.GroupBox gbXuLy;
        private System.Windows.Forms.Button btnTongPhanTu;
        private System.Windows.Forms.Button btnXoaDauCuoi;
        private System.Windows.Forms.Button btnXoaDangChon;
        private System.Windows.Forms.Button btnTangMoiPhanTu;
        private System.Windows.Forms.Button btnThayBinhPhuong;
        private System.Windows.Forms.Button btnChonChan;
        private System.Windows.Forms.Button btnChonLe;
        private System.Windows.Forms.Button btnKetThuc;
    }
}