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
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.lblTenKhach = new System.Windows.Forms.Label();
            this.lblSoKhach = new System.Windows.Forms.Label();
            this.txt_TenKhach = new System.Windows.Forms.TextBox();
            this.txt_SoKhach = new System.Windows.Forms.TextBox();
            this.chk_SinhVien = new System.Windows.Forms.CheckBox();
            this.gbNuocUong = new System.Windows.Forms.GroupBox();
            this.rdo_CafeKem = new System.Windows.Forms.RadioButton();
            this.rdo_CafeSuaDa = new System.Windows.Forms.RadioButton();
            this.rdo_CafeSua = new System.Windows.Forms.RadioButton();
            this.rdo_CafeDa = new System.Windows.Forms.RadioButton();
            this.rdo_CafeDen = new System.Windows.Forms.RadioButton();
            this.gbThucAn = new System.Windows.Forms.GroupBox();
            this.chk_MyCay = new System.Windows.Forms.CheckBox();
            this.chk_MyXaoBo = new System.Windows.Forms.CheckBox();
            this.chk_MyTomTrung = new System.Windows.Forms.CheckBox();
            this.chk_BanhMyCa = new System.Windows.Forms.CheckBox();
            this.chk_BanhMyTrung = new System.Windows.Forms.CheckBox();
            this.btn_TinhTien = new System.Windows.Forms.Button();
            this.btn_NhapLai = new System.Windows.Forms.Button();
            this.btn_ThanhToan = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.lblTongKhach = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.txt_TongKhach = new System.Windows.Forms.TextBox();
            this.txt_TongTien = new System.Windows.Forms.TextBox();
            this.gbNuocUong.SuspendLayout();
            this.gbThucAn.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblTieuDe.Location = new System.Drawing.Point(125, 15);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(193, 26);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "CAFE SINH VIÊN";
            // 
            // lblTenKhach
            // 
            this.lblTenKhach.AutoSize = true;
            this.lblTenKhach.Location = new System.Drawing.Point(30, 60);
            this.lblTenKhach.Name = "lblTenKhach";
            this.lblTenKhach.Size = new System.Drawing.Size(89, 13);
            this.lblTenKhach.TabIndex = 1;
            this.lblTenKhach.Text = "Tên khách hàng:";
            // 
            // lblSoKhach
            // 
            this.lblSoKhach.AutoSize = true;
            this.lblSoKhach.Location = new System.Drawing.Point(30, 90);
            this.lblSoKhach.Name = "lblSoKhach";
            this.lblSoKhach.Size = new System.Drawing.Size(82, 13);
            this.lblSoKhach.TabIndex = 2;
            this.lblSoKhach.Text = "Số khách hàng:";
            // 
            // txt_TenKhach
            // 
            this.txt_TenKhach.Location = new System.Drawing.Point(130, 57);
            this.txt_TenKhach.Name = "txt_TenKhach";
            this.txt_TenKhach.Size = new System.Drawing.Size(265, 20);
            this.txt_TenKhach.TabIndex = 3;
            this.txt_TenKhach.TextChanged += new System.EventHandler(this.DuLieu_ThayDoi);
            // 
            // txt_SoKhach
            // 
            this.txt_SoKhach.Location = new System.Drawing.Point(130, 87);
            this.txt_SoKhach.Name = "txt_SoKhach";
            this.txt_SoKhach.Size = new System.Drawing.Size(265, 20);
            this.txt_SoKhach.TabIndex = 4;
            this.txt_SoKhach.TextChanged += new System.EventHandler(this.DuLieu_ThayDoi);
            this.txt_SoKhach.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_SoKhach_KeyPress);
            // 
            // chk_SinhVien
            // 
            this.chk_SinhVien.AutoSize = true;
            this.chk_SinhVien.Location = new System.Drawing.Point(130, 120);
            this.chk_SinhVien.Name = "chk_SinhVien";
            this.chk_SinhVien.Size = new System.Drawing.Size(76, 17);
            this.chk_SinhVien.TabIndex = 5;
            this.chk_SinhVien.Text = "Sinh viên ?";
            this.chk_SinhVien.UseVisualStyleBackColor = true;
            // 
            // gbNuocUong
            // 
            this.gbNuocUong.Controls.Add(this.rdo_CafeKem);
            this.gbNuocUong.Controls.Add(this.rdo_CafeSuaDa);
            this.gbNuocUong.Controls.Add(this.rdo_CafeSua);
            this.gbNuocUong.Controls.Add(this.rdo_CafeDa);
            this.gbNuocUong.Controls.Add(this.rdo_CafeDen);
            this.gbNuocUong.Location = new System.Drawing.Point(33, 150);
            this.gbNuocUong.Name = "gbNuocUong";
            this.gbNuocUong.Size = new System.Drawing.Size(180, 150);
            this.gbNuocUong.TabIndex = 6;
            this.gbNuocUong.TabStop = false;
            this.gbNuocUong.Text = "Nước uống";
            // 
            // rdo_CafeKem
            // 
            this.rdo_CafeKem.AutoSize = true;
            this.rdo_CafeKem.Location = new System.Drawing.Point(15, 115);
            this.rdo_CafeKem.Name = "rdo_CafeKem";
            this.rdo_CafeKem.Size = new System.Drawing.Size(70, 17);
            this.rdo_CafeKem.TabIndex = 4;
            this.rdo_CafeKem.Text = "Cafe kem";
            this.rdo_CafeKem.UseVisualStyleBackColor = true;
            this.rdo_CafeKem.CheckedChanged += new System.EventHandler(this.DuLieu_ThayDoi);
            // 
            // rdo_CafeSuaDa
            // 
            this.rdo_CafeSuaDa.AutoSize = true;
            this.rdo_CafeSuaDa.Location = new System.Drawing.Point(15, 92);
            this.rdo_CafeSuaDa.Name = "rdo_CafeSuaDa";
            this.rdo_CafeSuaDa.Size = new System.Drawing.Size(83, 17);
            this.rdo_CafeSuaDa.TabIndex = 3;
            this.rdo_CafeSuaDa.Text = "Cafe sữa đá";
            this.rdo_CafeSuaDa.UseVisualStyleBackColor = true;
            this.rdo_CafeSuaDa.CheckedChanged += new System.EventHandler(this.DuLieu_ThayDoi);
            // 
            // rdo_CafeSua
            // 
            this.rdo_CafeSua.AutoSize = true;
            this.rdo_CafeSua.Location = new System.Drawing.Point(15, 69);
            this.rdo_CafeSua.Name = "rdo_CafeSua";
            this.rdo_CafeSua.Size = new System.Drawing.Size(67, 17);
            this.rdo_CafeSua.TabIndex = 2;
            this.rdo_CafeSua.Text = "Cafe sữa";
            this.rdo_CafeSua.UseVisualStyleBackColor = true;
            this.rdo_CafeSua.CheckedChanged += new System.EventHandler(this.DuLieu_ThayDoi);
            // 
            // rdo_CafeDa
            // 
            this.rdo_CafeDa.AutoSize = true;
            this.rdo_CafeDa.Location = new System.Drawing.Point(15, 46);
            this.rdo_CafeDa.Name = "rdo_CafeDa";
            this.rdo_CafeDa.Size = new System.Drawing.Size(62, 17);
            this.rdo_CafeDa.TabIndex = 1;
            this.rdo_CafeDa.Text = "Cafe đá";
            this.rdo_CafeDa.UseVisualStyleBackColor = true;
            this.rdo_CafeDa.CheckedChanged += new System.EventHandler(this.DuLieu_ThayDoi);
            // 
            // rdo_CafeDen
            // 
            this.rdo_CafeDen.AutoSize = true;
            this.rdo_CafeDen.Location = new System.Drawing.Point(15, 23);
            this.rdo_CafeDen.Name = "rdo_CafeDen";
            this.rdo_CafeDen.Size = new System.Drawing.Size(68, 17);
            this.rdo_CafeDen.TabIndex = 0;
            this.rdo_CafeDen.Text = "Cafe đen";
            this.rdo_CafeDen.UseVisualStyleBackColor = true;
            this.rdo_CafeDen.CheckedChanged += new System.EventHandler(this.DuLieu_ThayDoi);
            // 
            // gbThucAn
            // 
            this.gbThucAn.Controls.Add(this.chk_MyCay);
            this.gbThucAn.Controls.Add(this.chk_MyXaoBo);
            this.gbThucAn.Controls.Add(this.chk_MyTomTrung);
            this.gbThucAn.Controls.Add(this.chk_BanhMyCa);
            this.gbThucAn.Controls.Add(this.chk_BanhMyTrung);
            this.gbThucAn.Location = new System.Drawing.Point(225, 150);
            this.gbThucAn.Name = "gbThucAn";
            this.gbThucAn.Size = new System.Drawing.Size(185, 150);
            this.gbThucAn.TabIndex = 7;
            this.gbThucAn.TabStop = false;
            this.gbThucAn.Text = "Thức ăn";
            // 
            // chk_MyCay
            // 
            this.chk_MyCay.AutoSize = true;
            this.chk_MyCay.Location = new System.Drawing.Point(15, 115);
            this.chk_MyCay.Name = "chk_MyCay";
            this.chk_MyCay.Size = new System.Drawing.Size(60, 17);
            this.chk_MyCay.TabIndex = 4;
            this.chk_MyCay.Text = "Mỳ cay";
            this.chk_MyCay.UseVisualStyleBackColor = true;
            // 
            // chk_MyXaoBo
            // 
            this.chk_MyXaoBo.AutoSize = true;
            this.chk_MyXaoBo.Location = new System.Drawing.Point(15, 92);
            this.chk_MyXaoBo.Name = "chk_MyXaoBo";
            this.chk_MyXaoBo.Size = new System.Drawing.Size(76, 17);
            this.chk_MyXaoBo.TabIndex = 3;
            this.chk_MyXaoBo.Text = "Mỳ xào bò";
            this.chk_MyXaoBo.UseVisualStyleBackColor = true;
            // 
            // chk_MyTomTrung
            // 
            this.chk_MyTomTrung.AutoSize = true;
            this.chk_MyTomTrung.Location = new System.Drawing.Point(15, 69);
            this.chk_MyTomTrung.Name = "chk_MyTomTrung";
            this.chk_MyTomTrung.Size = new System.Drawing.Size(87, 17);
            this.chk_MyTomTrung.TabIndex = 2;
            this.chk_MyTomTrung.Text = "Mỳ tôm trứng";
            this.chk_MyTomTrung.UseVisualStyleBackColor = true;
            // 
            // chk_BanhMyCa
            // 
            this.chk_BanhMyCa.AutoSize = true;
            this.chk_BanhMyCa.Location = new System.Drawing.Point(15, 46);
            this.chk_BanhMyCa.Name = "chk_BanhMyCa";
            this.chk_BanhMyCa.Size = new System.Drawing.Size(79, 17);
            this.chk_BanhMyCa.TabIndex = 1;
            this.chk_BanhMyCa.Text = "Bánh mỳ cá";
            this.chk_BanhMyCa.UseVisualStyleBackColor = true;
            // 
            // chk_BanhMyTrung
            // 
            this.chk_BanhMyTrung.AutoSize = true;
            this.chk_BanhMyTrung.Location = new System.Drawing.Point(15, 23);
            this.chk_BanhMyTrung.Name = "chk_BanhMyTrung";
            this.chk_BanhMyTrung.Size = new System.Drawing.Size(93, 17);
            this.chk_BanhMyTrung.TabIndex = 0;
            this.chk_BanhMyTrung.Text = "Bánh mỳ trứng";
            this.chk_BanhMyTrung.UseVisualStyleBackColor = true;
            // 
            // btn_TinhTien
            // 
            this.btn_TinhTien.Location = new System.Drawing.Point(33, 315);
            this.btn_TinhTien.Name = "btn_TinhTien";
            this.btn_TinhTien.Size = new System.Drawing.Size(80, 30);
            this.btn_TinhTien.TabIndex = 8;
            this.btn_TinhTien.Text = "Tính tiền";
            this.btn_TinhTien.UseVisualStyleBackColor = true;
            this.btn_TinhTien.Click += new System.EventHandler(this.btn_TinhTien_Click);
            // 
            // btn_NhapLai
            // 
            this.btn_NhapLai.Location = new System.Drawing.Point(130, 315);
            this.btn_NhapLai.Name = "btn_NhapLai";
            this.btn_NhapLai.Size = new System.Drawing.Size(80, 30);
            this.btn_NhapLai.TabIndex = 9;
            this.btn_NhapLai.Text = "Nhập lại";
            this.btn_NhapLai.UseVisualStyleBackColor = true;
            this.btn_NhapLai.Click += new System.EventHandler(this.btn_NhapLai_Click);
            // 
            // btn_ThanhToan
            // 
            this.btn_ThanhToan.Location = new System.Drawing.Point(225, 315);
            this.btn_ThanhToan.Name = "btn_ThanhToan";
            this.btn_ThanhToan.Size = new System.Drawing.Size(85, 30);
            this.btn_ThanhToan.TabIndex = 10;
            this.btn_ThanhToan.Text = "Thanh toán";
            this.btn_ThanhToan.UseVisualStyleBackColor = true;
            this.btn_ThanhToan.Click += new System.EventHandler(this.btn_ThanhToan_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(325, 315);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(85, 30);
            this.btn_Thoat.TabIndex = 11;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // lblTongKhach
            // 
            this.lblTongKhach.AutoSize = true;
            this.lblTongKhach.Location = new System.Drawing.Point(30, 365);
            this.lblTongKhach.Name = "lblTongKhach";
            this.lblTongKhach.Size = new System.Drawing.Size(94, 13);
            this.lblTongKhach.TabIndex = 12;
            this.lblTongKhach.Text = "Tổng khách hàng:";
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Location = new System.Drawing.Point(30, 395);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(109, 13);
            this.lblTongTien.TabIndex = 13;
            this.lblTongTien.Text = "Tổng tiền thanh toán:";
            // 
            // txt_TongKhach
            // 
            this.txt_TongKhach.Location = new System.Drawing.Point(145, 362);
            this.txt_TongKhach.Name = "txt_TongKhach";
            this.txt_TongKhach.ReadOnly = true;
            this.txt_TongKhach.Size = new System.Drawing.Size(265, 20);
            this.txt_TongKhach.TabIndex = 14;
            // 
            // txt_TongTien
            // 
            this.txt_TongTien.Location = new System.Drawing.Point(145, 392);
            this.txt_TongTien.Name = "txt_TongTien";
            this.txt_TongTien.ReadOnly = true;
            this.txt_TongTien.Size = new System.Drawing.Size(265, 20);
            this.txt_TongTien.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 435);
            this.Controls.Add(this.txt_TongTien);
            this.Controls.Add(this.txt_TongKhach);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.lblTongKhach);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_ThanhToan);
            this.Controls.Add(this.btn_NhapLai);
            this.Controls.Add(this.btn_TinhTien);
            this.Controls.Add(this.gbThucAn);
            this.Controls.Add(this.gbNuocUong);
            this.Controls.Add(this.chk_SinhVien);
            this.Controls.Add(this.txt_SoKhach);
            this.Controls.Add(this.txt_TenKhach);
            this.Controls.Add(this.lblSoKhach);
            this.Controls.Add(this.lblTenKhach);
            this.Controls.Add(this.lblTieuDe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thanh toán tiền";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbNuocUong.ResumeLayout(false);
            this.gbNuocUong.PerformLayout();
            this.gbThucAn.ResumeLayout(false);
            this.gbThucAn.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblTenKhach;
        private System.Windows.Forms.Label lblSoKhach;
        private System.Windows.Forms.TextBox txt_TenKhach;
        private System.Windows.Forms.TextBox txt_SoKhach;
        private System.Windows.Forms.CheckBox chk_SinhVien;
        private System.Windows.Forms.GroupBox gbNuocUong;
        private System.Windows.Forms.RadioButton rdo_CafeKem;
        private System.Windows.Forms.RadioButton rdo_CafeSuaDa;
        private System.Windows.Forms.RadioButton rdo_CafeSua;
        private System.Windows.Forms.RadioButton rdo_CafeDa;
        private System.Windows.Forms.RadioButton rdo_CafeDen;
        private System.Windows.Forms.GroupBox gbThucAn;
        private System.Windows.Forms.CheckBox chk_MyCay;
        private System.Windows.Forms.CheckBox chk_MyXaoBo;
        private System.Windows.Forms.CheckBox chk_MyTomTrung;
        private System.Windows.Forms.CheckBox chk_BanhMyCa;
        private System.Windows.Forms.CheckBox chk_BanhMyTrung;
        private System.Windows.Forms.Button btn_TinhTien;
        private System.Windows.Forms.Button btn_NhapLai;
        private System.Windows.Forms.Button btn_ThanhToan;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Label lblTongKhach;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.TextBox txt_TongKhach;
        private System.Windows.Forms.TextBox txt_TongTien;
    }
}