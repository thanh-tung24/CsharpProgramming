namespace BTVN
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
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblSoNgayO = new System.Windows.Forms.Label();
            this.txt_HoTen = new System.Windows.Forms.TextBox();
            this.txt_DiaChi = new System.Windows.Forms.TextBox();
            this.txt_SoNgayO = new System.Windows.Forms.TextBox();
            this.gbLoaiPhong = new System.Windows.Forms.GroupBox();
            this.rdo_Ba = new System.Windows.Forms.RadioButton();
            this.rdo_Doi = new System.Windows.Forms.RadioButton();
            this.rdo_Don = new System.Windows.Forms.RadioButton();
            this.gbTienNghi = new System.Windows.Forms.GroupBox();
            this.chk_NuocNong = new System.Windows.Forms.CheckBox();
            this.chk_Internet = new System.Windows.Forms.CheckBox();
            this.chk_Tivi = new System.Windows.Forms.CheckBox();
            this.gbDichVu = new System.Windows.Forms.GroupBox();
            this.chk_AnSang = new System.Windows.Forms.CheckBox();
            this.chk_Karaoke = new System.Windows.Forms.CheckBox();
            this.btn_ThanhToan = new System.Windows.Forms.Button();
            this.btn_NhapMoi = new System.Windows.Forms.Button();
            this.lblThanhTien = new System.Windows.Forms.Label();
            this.txt_ThanhTien = new System.Windows.Forms.TextBox();
            this.gbTongKet = new System.Windows.Forms.GroupBox();
            this.btn_TongKet = new System.Windows.Forms.Button();
            this.txt_TongTien = new System.Windows.Forms.TextBox();
            this.txt_SoLuotNguoi = new System.Windows.Forms.TextBox();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.lblSoLuotNguoi = new System.Windows.Forms.Label();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.gbLoaiPhong.SuspendLayout();
            this.gbTienNghi.SuspendLayout();
            this.gbDichVu.SuspendLayout();
            this.gbTongKet.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblTieuDe.Location = new System.Drawing.Point(140, 15);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(434, 24);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "KHÁCH SẠN THANH THANH - TRẢ PHÒNG";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(25, 60);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(57, 13);
            this.lblHoTen.TabIndex = 1;
            this.lblHoTen.Text = "Họ và tên:";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(25, 95);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(43, 13);
            this.lblDiaChi.TabIndex = 2;
            this.lblDiaChi.Text = "Địa chỉ:";
            // 
            // lblSoNgayO
            // 
            this.lblSoNgayO.AutoSize = true;
            this.lblSoNgayO.Location = new System.Drawing.Point(25, 130);
            this.lblSoNgayO.Name = "lblSoNgayO";
            this.lblSoNgayO.Size = new System.Drawing.Size(56, 13);
            this.lblSoNgayO.TabIndex = 3;
            this.lblSoNgayO.Text = "Số ngày ở:";
            // 
            // txt_HoTen
            // 
            this.txt_HoTen.Location = new System.Drawing.Point(95, 57);
            this.txt_HoTen.Name = "txt_HoTen";
            this.txt_HoTen.Size = new System.Drawing.Size(275, 20);
            this.txt_HoTen.TabIndex = 4;
            this.txt_HoTen.TextChanged += new System.EventHandler(this.DuLieu_ThayDoi);
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.Location = new System.Drawing.Point(95, 92);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(275, 20);
            this.txt_DiaChi.TabIndex = 5;
            this.txt_DiaChi.TextChanged += new System.EventHandler(this.DuLieu_ThayDoi);
            // 
            // txt_SoNgayO
            // 
            this.txt_SoNgayO.Location = new System.Drawing.Point(95, 127);
            this.txt_SoNgayO.Name = "txt_SoNgayO";
            this.txt_SoNgayO.Size = new System.Drawing.Size(100, 20);
            this.txt_SoNgayO.TabIndex = 6;
            this.txt_SoNgayO.TextChanged += new System.EventHandler(this.DuLieu_ThayDoi);
            this.txt_SoNgayO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_SoNgayO_KeyPress);
            // 
            // gbLoaiPhong
            // 
            this.gbLoaiPhong.Controls.Add(this.rdo_Ba);
            this.gbLoaiPhong.Controls.Add(this.rdo_Doi);
            this.gbLoaiPhong.Controls.Add(this.rdo_Don);
            this.gbLoaiPhong.Location = new System.Drawing.Point(28, 165);
            this.gbLoaiPhong.Name = "gbLoaiPhong";
            this.gbLoaiPhong.Size = new System.Drawing.Size(110, 110);
            this.gbLoaiPhong.TabIndex = 7;
            this.gbLoaiPhong.TabStop = false;
            this.gbLoaiPhong.Text = "Loại phòng";
            // 
            // rdo_Ba
            // 
            this.rdo_Ba.AutoSize = true;
            this.rdo_Ba.Location = new System.Drawing.Point(10, 75);
            this.rdo_Ba.Name = "rdo_Ba";
            this.rdo_Ba.Size = new System.Drawing.Size(71, 17);
            this.rdo_Ba.TabIndex = 2;
            this.rdo_Ba.Text = "Phòng ba";
            this.rdo_Ba.UseVisualStyleBackColor = true;
            // 
            // rdo_Doi
            // 
            this.rdo_Doi.AutoSize = true;
            this.rdo_Doi.Location = new System.Drawing.Point(10, 48);
            this.rdo_Doi.Name = "rdo_Doi";
            this.rdo_Doi.Size = new System.Drawing.Size(74, 17);
            this.rdo_Doi.TabIndex = 1;
            this.rdo_Doi.Text = "Phòng đôi";
            this.rdo_Doi.UseVisualStyleBackColor = true;
            // 
            // rdo_Don
            // 
            this.rdo_Don.AutoSize = true;
            this.rdo_Don.Checked = true;
            this.rdo_Don.Location = new System.Drawing.Point(10, 22);
            this.rdo_Don.Name = "rdo_Don";
            this.rdo_Don.Size = new System.Drawing.Size(78, 17);
            this.rdo_Don.TabIndex = 0;
            this.rdo_Don.TabStop = true;
            this.rdo_Don.Text = "Phòng đơn";
            this.rdo_Don.UseVisualStyleBackColor = true;
            // 
            // gbTienNghi
            // 
            this.gbTienNghi.Controls.Add(this.chk_NuocNong);
            this.gbTienNghi.Controls.Add(this.chk_Internet);
            this.gbTienNghi.Controls.Add(this.chk_Tivi);
            this.gbTienNghi.Location = new System.Drawing.Point(145, 165);
            this.gbTienNghi.Name = "gbTienNghi";
            this.gbTienNghi.Size = new System.Drawing.Size(125, 110);
            this.gbTienNghi.TabIndex = 8;
            this.gbTienNghi.TabStop = false;
            this.gbTienNghi.Text = "Tiện nghi";
            // 
            // chk_NuocNong
            // 
            this.chk_NuocNong.AutoSize = true;
            this.chk_NuocNong.Location = new System.Drawing.Point(10, 75);
            this.chk_NuocNong.Name = "chk_NuocNong";
            this.chk_NuocNong.Size = new System.Drawing.Size(102, 17);
            this.chk_NuocNong.TabIndex = 2;
            this.chk_NuocNong.Text = "Máy nước nóng";
            this.chk_NuocNong.UseVisualStyleBackColor = true;
            // 
            // chk_Internet
            // 
            this.chk_Internet.AutoSize = true;
            this.chk_Internet.Location = new System.Drawing.Point(10, 48);
            this.chk_Internet.Name = "chk_Internet";
            this.chk_Internet.Size = new System.Drawing.Size(62, 17);
            this.chk_Internet.TabIndex = 1;
            this.chk_Internet.Text = "Internet";
            this.chk_Internet.UseVisualStyleBackColor = true;
            // 
            // chk_Tivi
            // 
            this.chk_Tivi.AutoSize = true;
            this.chk_Tivi.Location = new System.Drawing.Point(10, 22);
            this.chk_Tivi.Name = "chk_Tivi";
            this.chk_Tivi.Size = new System.Drawing.Size(43, 17);
            this.chk_Tivi.TabIndex = 0;
            this.chk_Tivi.Text = "Tivi";
            this.chk_Tivi.UseVisualStyleBackColor = true;
            // 
            // gbDichVu
            // 
            this.gbDichVu.Controls.Add(this.chk_AnSang);
            this.gbDichVu.Controls.Add(this.chk_Karaoke);
            this.gbDichVu.Location = new System.Drawing.Point(277, 165);
            this.gbDichVu.Name = "gbDichVu";
            this.gbDichVu.Size = new System.Drawing.Size(100, 110);
            this.gbDichVu.TabIndex = 9;
            this.gbDichVu.TabStop = false;
            this.gbDichVu.Text = "Dịch vụ";
            // 
            // chk_AnSang
            // 
            this.chk_AnSang.AutoSize = true;
            this.chk_AnSang.Location = new System.Drawing.Point(10, 52);
            this.chk_AnSang.Name = "chk_AnSang";
            this.chk_AnSang.Size = new System.Drawing.Size(65, 17);
            this.chk_AnSang.TabIndex = 1;
            this.chk_AnSang.Text = "Ăn sáng";
            this.chk_AnSang.UseVisualStyleBackColor = true;
            // 
            // chk_Karaoke
            // 
            this.chk_Karaoke.AutoSize = true;
            this.chk_Karaoke.Location = new System.Drawing.Point(10, 25);
            this.chk_Karaoke.Name = "chk_Karaoke";
            this.chk_Karaoke.Size = new System.Drawing.Size(66, 17);
            this.chk_Karaoke.TabIndex = 0;
            this.chk_Karaoke.Text = "Karaoke";
            this.chk_Karaoke.UseVisualStyleBackColor = true;
            // 
            // btn_ThanhToan
            // 
            this.btn_ThanhToan.Location = new System.Drawing.Point(405, 57);
            this.btn_ThanhToan.Name = "btn_ThanhToan";
            this.btn_ThanhToan.Size = new System.Drawing.Size(90, 30);
            this.btn_ThanhToan.TabIndex = 10;
            this.btn_ThanhToan.Text = "Thanh toán";
            this.btn_ThanhToan.UseVisualStyleBackColor = true;
            this.btn_ThanhToan.Click += new System.EventHandler(this.btn_ThanhToan_Click);
            // 
            // btn_NhapMoi
            // 
            this.btn_NhapMoi.Location = new System.Drawing.Point(510, 57);
            this.btn_NhapMoi.Name = "btn_NhapMoi";
            this.btn_NhapMoi.Size = new System.Drawing.Size(90, 30);
            this.btn_NhapMoi.TabIndex = 11;
            this.btn_NhapMoi.Text = "Nhập mới";
            this.btn_NhapMoi.UseVisualStyleBackColor = true;
            this.btn_NhapMoi.Click += new System.EventHandler(this.btn_NhapMoi_Click);
            // 
            // lblThanhTien
            // 
            this.lblThanhTien.AutoSize = true;
            this.lblThanhTien.Location = new System.Drawing.Point(405, 102);
            this.lblThanhTien.Name = "lblThanhTien";
            this.lblThanhTien.Size = new System.Drawing.Size(61, 13);
            this.lblThanhTien.TabIndex = 12;
            this.lblThanhTien.Text = "Thành tiền:";
            // 
            // txt_ThanhTien
            // 
            this.txt_ThanhTien.Location = new System.Drawing.Point(475, 99);
            this.txt_ThanhTien.Name = "txt_ThanhTien";
            this.txt_ThanhTien.ReadOnly = true;
            this.txt_ThanhTien.Size = new System.Drawing.Size(185, 20);
            this.txt_ThanhTien.TabIndex = 13;
            // 
            // gbTongKet
            // 
            this.gbTongKet.Controls.Add(this.btn_TongKet);
            this.gbTongKet.Controls.Add(this.txt_TongTien);
            this.gbTongKet.Controls.Add(this.txt_SoLuotNguoi);
            this.gbTongKet.Controls.Add(this.lblTongTien);
            this.gbTongKet.Controls.Add(this.lblSoLuotNguoi);
            this.gbTongKet.Location = new System.Drawing.Point(405, 135);
            this.gbTongKet.Name = "gbTongKet";
            this.gbTongKet.Size = new System.Drawing.Size(255, 110);
            this.gbTongKet.TabIndex = 14;
            this.gbTongKet.TabStop = false;
            this.gbTongKet.Text = "Thông tin tổng kết";
            // 
            // btn_TongKet
            // 
            this.btn_TongKet.Location = new System.Drawing.Point(10, 20);
            this.btn_TongKet.Name = "btn_TongKet";
            this.btn_TongKet.Size = new System.Drawing.Size(80, 28);
            this.btn_TongKet.TabIndex = 4;
            this.btn_TongKet.Text = "Tổng Kết";
            this.btn_TongKet.UseVisualStyleBackColor = true;
            this.btn_TongKet.Click += new System.EventHandler(this.btn_TongKet_Click);
            // 
            // txt_TongTien
            // 
            this.txt_TongTien.Location = new System.Drawing.Point(95, 78);
            this.txt_TongTien.Name = "txt_TongTien";
            this.txt_TongTien.ReadOnly = true;
            this.txt_TongTien.Size = new System.Drawing.Size(150, 20);
            this.txt_TongTien.TabIndex = 3;
            // 
            // txt_SoLuotNguoi
            // 
            this.txt_SoLuotNguoi.Location = new System.Drawing.Point(95, 52);
            this.txt_SoLuotNguoi.Name = "txt_SoLuotNguoi";
            this.txt_SoLuotNguoi.ReadOnly = true;
            this.txt_SoLuotNguoi.Size = new System.Drawing.Size(150, 20);
            this.txt_SoLuotNguoi.TabIndex = 2;
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Location = new System.Drawing.Point(10, 81);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(65, 13);
            this.lblTongTien.TabIndex = 1;
            this.lblTongTien.Text = "Tổng số tiền:";
            // 
            // lblSoLuotNguoi
            // 
            this.lblSoLuotNguoi.AutoSize = true;
            this.lblSoLuotNguoi.Location = new System.Drawing.Point(10, 55);
            this.lblSoLuotNguoi.Name = "lblSoLuotNguoi";
            this.lblSoLuotNguoi.Size = new System.Drawing.Size(72, 13);
            this.lblSoLuotNguoi.TabIndex = 0;
            this.lblSoLuotNguoi.Text = "Số lượt người:";
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(405, 252);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(90, 28);
            this.btn_Thoat.TabIndex = 15;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 295);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.gbTongKet);
            this.Controls.Add(this.txt_ThanhTien);
            this.Controls.Add(this.lblThanhTien);
            this.Controls.Add(this.btn_NhapMoi);
            this.Controls.Add(this.btn_ThanhToan);
            this.Controls.Add(this.gbDichVu);
            this.Controls.Add(this.gbTienNghi);
            this.Controls.Add(this.gbLoaiPhong);
            this.Controls.Add(this.txt_SoNgayO);
            this.Controls.Add(this.txt_DiaChi);
            this.Controls.Add(this.txt_HoTen);
            this.Controls.Add(this.lblSoNgayO);
            this.Controls.Add(this.lblDiaChi);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.lblTieuDe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDangkyKS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbLoaiPhong.ResumeLayout(false);
            this.gbLoaiPhong.PerformLayout();
            this.gbTienNghi.ResumeLayout(false);
            this.gbTienNghi.PerformLayout();
            this.gbDichVu.ResumeLayout(false);
            this.gbDichVu.PerformLayout();
            this.gbTongKet.ResumeLayout(false);
            this.gbTongKet.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblSoNgayO;
        private System.Windows.Forms.TextBox txt_HoTen;
        private System.Windows.Forms.TextBox txt_DiaChi;
        private System.Windows.Forms.TextBox txt_SoNgayO;
        private System.Windows.Forms.GroupBox gbLoaiPhong;
        private System.Windows.Forms.RadioButton rdo_Ba;
        private System.Windows.Forms.RadioButton rdo_Doi;
        private System.Windows.Forms.RadioButton rdo_Don;
        private System.Windows.Forms.GroupBox gbTienNghi;
        private System.Windows.Forms.CheckBox chk_NuocNong;
        private System.Windows.Forms.CheckBox chk_Internet;
        private System.Windows.Forms.CheckBox chk_Tivi;
        private System.Windows.Forms.GroupBox gbDichVu;
        private System.Windows.Forms.CheckBox chk_AnSang;
        private System.Windows.Forms.CheckBox chk_Karaoke;
        private System.Windows.Forms.Button btn_ThanhToan;
        private System.Windows.Forms.Button btn_NhapMoi;
        private System.Windows.Forms.Label lblThanhTien;
        private System.Windows.Forms.TextBox txt_ThanhTien;
        private System.Windows.Forms.GroupBox gbTongKet;
        private System.Windows.Forms.Button btn_TongKet;
        private System.Windows.Forms.TextBox txt_TongTien;
        private System.Windows.Forms.TextBox txt_SoLuotNguoi;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label lblSoLuotNguoi;
        private System.Windows.Forms.Button btn_Thoat;
    }
}