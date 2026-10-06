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
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.lblNhapMang = new System.Windows.Forms.Label();
            this.lblKetQuaMang = new System.Windows.Forms.Label();
            this.txt_NhapMang = new System.Windows.Forms.TextBox();
            this.txt_KetQuaMang = new System.Windows.Forms.TextBox();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.gbSapXep = new System.Windows.Forms.GroupBox();
            this.btn_ThucHienSX = new System.Windows.Forms.Button();
            this.rdo_SapXepGiam = new System.Windows.Forms.RadioButton();
            this.rdo_SapXepTang = new System.Windows.Forms.RadioButton();
            this.gbTimKiem = new System.Windows.Forms.GroupBox();
            this.btn_Tim = new System.Windows.Forms.Button();
            this.txt_SoTimDuoc = new System.Windows.Forms.TextBox();
            this.lblSoTim = new System.Windows.Forms.Label();
            this.txt_TimViTri = new System.Windows.Forms.TextBox();
            this.txt_TimGiaTri = new System.Windows.Forms.TextBox();
            this.rdo_TimViTri = new System.Windows.Forms.RadioButton();
            this.rdo_TimGiaTri = new System.Windows.Forms.RadioButton();
            this.gbXoa = new System.Windows.Forms.GroupBox();
            this.btn_ThucHienXoa = new System.Windows.Forms.Button();
            this.txt_XoaViTri = new System.Windows.Forms.TextBox();
            this.txt_XoaGiaTri = new System.Windows.Forms.TextBox();
            this.rdo_XoaViTri = new System.Windows.Forms.RadioButton();
            this.rdo_XoaGiaTri = new System.Windows.Forms.RadioButton();
            this.gbThem = new System.Windows.Forms.GroupBox();
            this.btn_ThucHienThem = new System.Windows.Forms.Button();
            this.txt_ViTriThem = new System.Windows.Forms.TextBox();
            this.txt_GiaTriThem = new System.Windows.Forms.TextBox();
            this.lblViTriThem = new System.Windows.Forms.Label();
            this.lblGiaTriThem = new System.Windows.Forms.Label();
            this.gbTong = new System.Windows.Forms.GroupBox();
            this.btn_Tong = new System.Windows.Forms.Button();
            this.txt_TongLe = new System.Windows.Forms.TextBox();
            this.txt_TongChan = new System.Windows.Forms.TextBox();
            this.txt_TongMang = new System.Windows.Forms.TextBox();
            this.lblTongLe = new System.Windows.Forms.Label();
            this.lblTongChan = new System.Windows.Forms.Label();
            this.lblTongMang = new System.Windows.Forms.Label();
            this.gbMaxMin = new System.Windows.Forms.GroupBox();
            this.btn_TimMaxMin = new System.Windows.Forms.Button();
            this.txt_Min = new System.Windows.Forms.TextBox();
            this.txt_Max = new System.Windows.Forms.TextBox();
            this.lblMin = new System.Windows.Forms.Label();
            this.lblMax = new System.Windows.Forms.Label();
            this.gbThayThe = new System.Windows.Forms.GroupBox();
            this.btn_ThucHienThayThe = new System.Windows.Forms.Button();
            this.txt_SoThayTheMoi = new System.Windows.Forms.TextBox();
            this.txt_ThayTheGiaTri = new System.Windows.Forms.TextBox();
            this.lblSoThayThe = new System.Windows.Forms.Label();
            this.lblThayTheGiaTri = new System.Windows.Forms.Label();
            this.gbSapXep.SuspendLayout();
            this.gbTimKiem.SuspendLayout();
            this.gbXoa.SuspendLayout();
            this.gbThem.SuspendLayout();
            this.gbTong.SuspendLayout();
            this.gbMaxMin.SuspendLayout();
            this.gbThayThe.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.ForeColor = System.Drawing.Color.Red;
            this.lblTieuDe.Location = new System.Drawing.Point(170, 15);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(200, 25);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "Mảng Số Nguyên";
            // 
            // lblNhapMang
            // 
            this.lblNhapMang.AutoSize = true;
            this.lblNhapMang.Location = new System.Drawing.Point(25, 55);
            this.lblNhapMang.Name = "lblNhapMang";
            this.lblNhapMang.Size = new System.Drawing.Size(65, 13);
            this.lblNhapMang.TabIndex = 1;
            this.lblNhapMang.Text = "Nhập mảng:";
            // 
            // lblKetQuaMang
            // 
            this.lblKetQuaMang.AutoSize = true;
            this.lblKetQuaMang.Location = new System.Drawing.Point(25, 88);
            this.lblKetQuaMang.Name = "lblKetQuaMang";
            this.lblKetQuaMang.Size = new System.Drawing.Size(76, 13);
            this.lblKetQuaMang.TabIndex = 2;
            this.lblKetQuaMang.Text = "Kết quả mảng:";
            // 
            // txt_NhapMang
            // 
            this.txt_NhapMang.Location = new System.Drawing.Point(105, 52);
            this.txt_NhapMang.Name = "txt_NhapMang";
            this.txt_NhapMang.Size = new System.Drawing.Size(315, 20);
            this.txt_NhapMang.TabIndex = 3;
            // 
            // txt_KetQuaMang
            // 
            this.txt_KetQuaMang.Location = new System.Drawing.Point(105, 85);
            this.txt_KetQuaMang.Name = "txt_KetQuaMang";
            this.txt_KetQuaMang.ReadOnly = true;
            this.txt_KetQuaMang.Size = new System.Drawing.Size(315, 20);
            this.txt_KetQuaMang.TabIndex = 4;
            // 
            // btn_Reset
            // 
            this.btn_Reset.Location = new System.Drawing.Point(435, 50);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(75, 25);
            this.btn_Reset.TabIndex = 5;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(435, 83);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(75, 25);
            this.btn_Thoat.TabIndex = 6;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // gbSapXep
            // 
            this.gbSapXep.Controls.Add(this.btn_ThucHienSX);
            this.gbSapXep.Controls.Add(this.rdo_SapXepGiam);
            this.gbSapXep.Controls.Add(this.rdo_SapXepTang);
            this.gbSapXep.Location = new System.Drawing.Point(28, 120);
            this.gbSapXep.Name = "gbSapXep";
            this.gbSapXep.Size = new System.Drawing.Size(482, 55);
            this.gbSapXep.TabIndex = 7;
            this.gbSapXep.TabStop = false;
            this.gbSapXep.Text = "Sắp Xếp";
            // 
            // btn_ThucHienSX
            // 
            this.btn_ThucHienSX.Location = new System.Drawing.Point(380, 18);
            this.btn_ThucHienSX.Name = "btn_ThucHienSX";
            this.btn_ThucHienSX.Size = new System.Drawing.Size(85, 25);
            this.btn_ThucHienSX.TabIndex = 2;
            this.btn_ThucHienSX.Text = "Thực Hiện";
            this.btn_ThucHienSX.UseVisualStyleBackColor = true;
            this.btn_ThucHienSX.Click += new System.EventHandler(this.btn_ThucHienSX_Click);
            // 
            // rdo_SapXepGiam
            // 
            this.rdo_SapXepGiam.AutoSize = true;
            this.rdo_SapXepGiam.Location = new System.Drawing.Point(230, 22);
            this.rdo_SapXepGiam.Name = "rdo_SapXepGiam";
            this.rdo_SapXepGiam.Size = new System.Drawing.Size(94, 17);
            this.rdo_SapXepGiam.TabIndex = 1;
            this.rdo_SapXepGiam.Text = "Sắp xếp Giảm";
            this.rdo_SapXepGiam.UseVisualStyleBackColor = true;
            // 
            // rdo_SapXepTang
            // 
            this.rdo_SapXepTang.AutoSize = true;
            this.rdo_SapXepTang.Checked = true;
            this.rdo_SapXepTang.Location = new System.Drawing.Point(60, 22);
            this.rdo_SapXepTang.Name = "rdo_SapXepTang";
            this.rdo_SapXepTang.Size = new System.Drawing.Size(93, 17);
            this.rdo_SapXepTang.TabIndex = 0;
            this.rdo_SapXepTang.TabStop = true;
            this.rdo_SapXepTang.Text = "Sắp xếp Tăng";
            this.rdo_SapXepTang.UseVisualStyleBackColor = true;
            // 
            // gbTimKiem
            // 
            this.gbTimKiem.Controls.Add(this.btn_Tim);
            this.gbTimKiem.Controls.Add(this.txt_SoTimDuoc);
            this.gbTimKiem.Controls.Add(this.lblSoTim);
            this.gbTimKiem.Controls.Add(this.txt_TimViTri);
            this.gbTimKiem.Controls.Add(this.txt_TimGiaTri);
            this.gbTimKiem.Controls.Add(this.rdo_TimViTri);
            this.gbTimKiem.Controls.Add(this.rdo_TimGiaTri);
            this.gbTimKiem.Location = new System.Drawing.Point(28, 185);
            this.gbTimKiem.Name = "gbTimKiem";
            this.gbTimKiem.Size = new System.Drawing.Size(230, 115);
            this.gbTimKiem.TabIndex = 8;
            this.gbTimKiem.TabStop = false;
            this.gbTimKiem.Text = "Tìm Kiếm";
            // 
            // btn_Tim
            // 
            this.btn_Tim.Location = new System.Drawing.Point(170, 78);
            this.btn_Tim.Name = "btn_Tim";
            this.btn_Tim.Size = new System.Drawing.Size(50, 24);
            this.btn_Tim.TabIndex = 6;
            this.btn_Tim.Text = "Tìm";
            this.btn_Tim.UseVisualStyleBackColor = true;
            this.btn_Tim.Click += new System.EventHandler(this.btn_Tim_Click);
            // 
            // txt_SoTimDuoc
            // 
            this.txt_SoTimDuoc.Location = new System.Drawing.Point(95, 80);
            this.txt_SoTimDuoc.Name = "txt_SoTimDuoc";
            this.txt_SoTimDuoc.ReadOnly = true;
            this.txt_SoTimDuoc.Size = new System.Drawing.Size(65, 20);
            this.txt_SoTimDuoc.TabIndex = 5;
            // 
            // lblSoTim
            // 
            this.lblSoTim.AutoSize = true;
            this.lblSoTim.Location = new System.Drawing.Point(10, 83);
            this.lblSoTim.Name = "lblSoTim";
            this.lblSoTim.Size = new System.Drawing.Size(73, 13);
            this.lblSoTim.TabIndex = 4;
            this.lblSoTim.Text = "Số tìm được là:";
            // 
            // txt_TimViTri
            // 
            this.txt_TimViTri.Location = new System.Drawing.Point(145, 48);
            this.txt_TimViTri.Name = "txt_TimViTri";
            this.txt_TimViTri.Size = new System.Drawing.Size(75, 20);
            this.txt_TimViTri.TabIndex = 3;
            // 
            // txt_TimGiaTri
            // 
            this.txt_TimGiaTri.Location = new System.Drawing.Point(145, 18);
            this.txt_TimGiaTri.Name = "txt_TimGiaTri";
            this.txt_TimGiaTri.Size = new System.Drawing.Size(75, 20);
            this.txt_TimGiaTri.TabIndex = 2;
            // 
            // rdo_TimViTri
            // 
            this.rdo_TimViTri.AutoSize = true;
            this.rdo_TimViTri.Location = new System.Drawing.Point(10, 50);
            this.rdo_TimViTri.Name = "rdo_TimViTri";
            this.rdo_TimViTri.Size = new System.Drawing.Size(89, 17);
            this.rdo_TimViTri.TabIndex = 1;
            this.rdo_TimViTri.Text = "Tìm vị trí cần:";
            this.rdo_TimViTri.UseVisualStyleBackColor = true;
            // 
            // rdo_TimGiaTri
            // 
            this.rdo_TimGiaTri.AutoSize = true;
            this.rdo_TimGiaTri.Checked = true;
            this.rdo_TimGiaTri.Location = new System.Drawing.Point(10, 20);
            this.rdo_TimGiaTri.Name = "rdo_TimGiaTri";
            this.rdo_TimGiaTri.Size = new System.Drawing.Size(95, 17);
            this.rdo_TimGiaTri.TabIndex = 0;
            this.rdo_TimGiaTri.TabStop = true;
            this.rdo_TimGiaTri.Text = "Tìm giá trị cần:";
            this.rdo_TimGiaTri.UseVisualStyleBackColor = true;
            // 
            // gbXoa
            // 
            this.gbXoa.Controls.Add(this.btn_ThucHienXoa);
            this.gbXoa.Controls.Add(this.txt_XoaViTri);
            this.gbXoa.Controls.Add(this.txt_XoaGiaTri);
            this.gbXoa.Controls.Add(this.rdo_XoaViTri);
            this.gbXoa.Controls.Add(this.rdo_XoaGiaTri);
            this.gbXoa.Location = new System.Drawing.Point(280, 185);
            this.gbXoa.Name = "gbXoa";
            this.gbXoa.Size = new System.Drawing.Size(230, 115);
            this.gbXoa.TabIndex = 9;
            this.gbXoa.TabStop = false;
            this.gbXoa.Text = "Xóa";
            // 
            // btn_ThucHienXoa
            // 
            this.btn_ThucHienXoa.Location = new System.Drawing.Point(145, 80);
            this.btn_ThucHienXoa.Name = "btn_ThucHienXoa";
            this.btn_ThucHienXoa.Size = new System.Drawing.Size(75, 24);
            this.btn_ThucHienXoa.TabIndex = 4;
            this.btn_ThucHienXoa.Text = "Xóa";
            this.btn_ThucHienXoa.UseVisualStyleBackColor = true;
            this.btn_ThucHienXoa.Click += new System.EventHandler(this.btn_ThucHienXoa_Click);
            // 
            // txt_XoaViTri
            // 
            this.txt_XoaViTri.Location = new System.Drawing.Point(145, 48);
            this.txt_XoaViTri.Name = "txt_XoaViTri";
            this.txt_XoaViTri.Size = new System.Drawing.Size(75, 20);
            this.txt_XoaViTri.TabIndex = 3;
            // 
            // txt_XoaGiaTri
            // 
            this.txt_XoaGiaTri.Location = new System.Drawing.Point(145, 18);
            this.txt_XoaGiaTri.Name = "txt_XoaGiaTri";
            this.txt_XoaGiaTri.Size = new System.Drawing.Size(75, 20);
            this.txt_XoaGiaTri.TabIndex = 2;
            // 
            // rdo_XoaViTri
            // 
            this.rdo_XoaViTri.AutoSize = true;
            this.rdo_XoaViTri.Location = new System.Drawing.Point(10, 50);
            this.rdo_XoaViTri.Name = "rdo_XoaViTri";
            this.rdo_XoaViTri.Size = new System.Drawing.Size(92, 17);
            this.rdo_XoaViTri.TabIndex = 1;
            this.rdo_XoaViTri.Text = "Tìm vị trí xóa:";
            this.rdo_XoaViTri.UseVisualStyleBackColor = true;
            // 
            // rdo_XoaGiaTri
            // 
            this.rdo_XoaGiaTri.AutoSize = true;
            this.rdo_XoaGiaTri.Checked = true;
            this.rdo_XoaGiaTri.Location = new System.Drawing.Point(10, 20);
            this.rdo_XoaGiaTri.Name = "rdo_XoaGiaTri";
            this.rdo_XoaGiaTri.Size = new System.Drawing.Size(98, 17);
            this.rdo_XoaGiaTri.TabIndex = 0;
            this.rdo_XoaGiaTri.TabStop = true;
            this.rdo_XoaGiaTri.Text = "Tìm giá trị xóa:";
            this.rdo_XoaGiaTri.UseVisualStyleBackColor = true;
            // 
            // gbThem
            // 
            this.gbThem.Controls.Add(this.btn_ThucHienThem);
            this.gbThem.Controls.Add(this.txt_ViTriThem);
            this.gbThem.Controls.Add(this.txt_GiaTriThem);
            this.gbThem.Controls.Add(this.lblViTriThem);
            this.gbThem.Controls.Add(this.lblGiaTriThem);
            this.gbThem.Location = new System.Drawing.Point(28, 310);
            this.gbThem.Name = "gbThem";
            this.gbThem.Size = new System.Drawing.Size(230, 115);
            this.gbThem.TabIndex = 10;
            this.gbThem.TabStop = false;
            this.gbThem.Text = "Thêm";
            // 
            // btn_ThucHienThem
            // 
            this.btn_ThucHienThem.Location = new System.Drawing.Point(145, 80);
            this.btn_ThucHienThem.Name = "btn_ThucHienThem";
            this.btn_ThucHienThem.Size = new System.Drawing.Size(75, 24);
            this.btn_ThucHienThem.TabIndex = 4;
            this.btn_ThucHienThem.Text = "Thêm";
            this.btn_ThucHienThem.UseVisualStyleBackColor = true;
            this.btn_ThucHienThem.Click += new System.EventHandler(this.btn_ThucHienThem_Click);
            // 
            // txt_ViTriThem
            // 
            this.txt_ViTriThem.Location = new System.Drawing.Point(145, 48);
            this.txt_ViTriThem.Name = "txt_ViTriThem";
            this.txt_ViTriThem.Size = new System.Drawing.Size(75, 20);
            this.txt_ViTriThem.TabIndex = 3;
            // 
            // txt_GiaTriThem
            // 
            this.txt_GiaTriThem.Location = new System.Drawing.Point(145, 18);
            this.txt_GiaTriThem.Name = "txt_GiaTriThem";
            this.txt_GiaTriThem.Size = new System.Drawing.Size(75, 20);
            this.txt_GiaTriThem.TabIndex = 2;
            // 
            // lblViTriThem
            // 
            this.lblViTriThem.AutoSize = true;
            this.lblViTriThem.Location = new System.Drawing.Point(10, 50);
            this.lblViTriThem.Name = "lblViTriThem";
            this.lblViTriThem.Size = new System.Drawing.Size(84, 13);
            this.lblViTriThem.TabIndex = 1;
            this.lblViTriThem.Text = "Tại vị trí thêm:";
            // 
            // lblGiaTriThem
            // 
            this.lblGiaTriThem.AutoSize = true;
            this.lblGiaTriThem.Location = new System.Drawing.Point(10, 20);
            this.lblGiaTriThem.Name = "lblGiaTriThem";
            this.lblGiaTriThem.Size = new System.Drawing.Size(89, 13);
            this.lblGiaTriThem.TabIndex = 0;
            this.lblGiaTriThem.Text = "Giá trị cần thêm:";
            // 
            // gbTong
            // 
            this.gbTong.Controls.Add(this.btn_Tong);
            this.gbTong.Controls.Add(this.txt_TongLe);
            this.gbTong.Controls.Add(this.txt_TongChan);
            this.gbTong.Controls.Add(this.txt_TongMang);
            this.gbTong.Controls.Add(this.lblTongLe);
            this.gbTong.Controls.Add(this.lblTongChan);
            this.gbTong.Controls.Add(this.lblTongMang);
            this.gbTong.Location = new System.Drawing.Point(280, 310);
            this.gbTong.Name = "gbTong";
            this.gbTong.Size = new System.Drawing.Size(230, 115);
            this.gbTong.TabIndex = 11;
            this.gbTong.TabStop = false;
            this.gbTong.Text = "Tổng";
            // 
            // btn_Tong
            // 
            this.btn_Tong.Location = new System.Drawing.Point(155, 20);
            this.btn_Tong.Name = "btn_Tong";
            this.btn_Tong.Size = new System.Drawing.Size(65, 80);
            this.btn_Tong.TabIndex = 6;
            this.btn_Tong.Text = "Tổng";
            this.btn_Tong.UseVisualStyleBackColor = true;
            this.btn_Tong.Click += new System.EventHandler(this.btn_Tong_Click);
            // 
            // txt_TongLe
            // 
            this.txt_TongLe.Location = new System.Drawing.Point(80, 80);
            this.txt_TongLe.Name = "txt_TongLe";
            this.txt_TongLe.ReadOnly = true;
            this.txt_TongLe.Size = new System.Drawing.Size(60, 20);
            this.txt_TongLe.TabIndex = 5;
            // 
            // txt_TongChan
            // 
            this.txt_TongChan.Location = new System.Drawing.Point(80, 50);
            this.txt_TongChan.Name = "txt_TongChan";
            this.txt_TongChan.ReadOnly = true;
            this.txt_TongChan.Size = new System.Drawing.Size(60, 20);
            this.txt_TongChan.TabIndex = 4;
            // 
            // txt_TongMang
            // 
            this.txt_TongMang.Location = new System.Drawing.Point(80, 20);
            this.txt_TongMang.Name = "txt_TongMang";
            this.txt_TongMang.ReadOnly = true;
            this.txt_TongMang.Size = new System.Drawing.Size(60, 20);
            this.txt_TongMang.TabIndex = 3;
            // 
            // lblTongLe
            // 
            this.lblTongLe.AutoSize = true;
            this.lblTongLe.Location = new System.Drawing.Point(10, 83);
            this.lblTongLe.Name = "lblTongLe";
            this.lblTongLe.Size = new System.Drawing.Size(46, 13);
            this.lblTongLe.TabIndex = 2;
            this.lblTongLe.Text = "Tổng lẻ:";
            // 
            // lblTongChan
            // 
            this.lblTongChan.AutoSize = true;
            this.lblTongChan.Location = new System.Drawing.Point(10, 53);
            this.lblTongChan.Name = "lblTongChan";
            this.lblTongChan.Size = new System.Drawing.Size(62, 13);
            this.lblTongChan.TabIndex = 1;
            this.lblTongChan.Text = "Tổng chẵn:";
            // 
            // lblTongMang
            // 
            this.lblTongMang.AutoSize = true;
            this.lblTongMang.Location = new System.Drawing.Point(10, 23);
            this.lblTongMang.Name = "lblTongMang";
            this.lblTongMang.Size = new System.Drawing.Size(65, 13);
            this.lblTongMang.TabIndex = 0;
            this.lblTongMang.Text = "Tổng mảng:";
            // 
            // gbMaxMin
            // 
            this.gbMaxMin.Controls.Add(this.btn_TimMaxMin);
            this.gbMaxMin.Controls.Add(this.txt_Min);
            this.gbMaxMin.Controls.Add(this.txt_Max);
            this.gbMaxMin.Controls.Add(this.lblMin);
            this.gbMaxMin.Controls.Add(this.lblMax);
            this.gbMaxMin.Location = new System.Drawing.Point(28, 435);
            this.gbMaxMin.Name = "gbMaxMin";
            this.gbMaxMin.Size = new System.Drawing.Size(230, 95);
            this.gbMaxMin.TabIndex = 12;
            this.gbMaxMin.TabStop = false;
            this.gbMaxMin.Text = "Max - Min";
            // 
            // btn_TimMaxMin
            // 
            this.btn_TimMaxMin.Location = new System.Drawing.Point(155, 20);
            this.btn_TimMaxMin.Name = "btn_TimMaxMin";
            this.btn_TimMaxMin.Size = new System.Drawing.Size(65, 55);
            this.btn_TimMaxMin.TabIndex = 4;
            this.btn_TimMaxMin.Text = "Tìm";
            this.btn_TimMaxMin.UseVisualStyleBackColor = true;
            this.btn_TimMaxMin.Click += new System.EventHandler(this.btn_TimMaxMin_Click);
            // 
            // txt_Min
            // 
            this.txt_Min.Location = new System.Drawing.Point(85, 55);
            this.txt_Min.Name = "txt_Min";
            this.txt_Min.ReadOnly = true;
            this.txt_Min.Size = new System.Drawing.Size(55, 20);
            this.txt_Min.TabIndex = 3;
            // 
            // txt_Max
            // 
            this.txt_Max.Location = new System.Drawing.Point(85, 22);
            this.txt_Max.Name = "txt_Max";
            this.txt_Max.ReadOnly = true;
            this.txt_Max.Size = new System.Drawing.Size(55, 20);
            this.txt_Max.TabIndex = 2;
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Location = new System.Drawing.Point(10, 58);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(76, 13);
            this.lblMin.TabIndex = 1;
            this.lblMin.Text = "Giá trị nhỏ nhất:";
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Location = new System.Drawing.Point(10, 25);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(74, 13);
            this.lblMax.TabIndex = 0;
            this.lblMax.Text = "Giá trị lớn nhất:";
            // 
            // gbThayThe
            // 
            this.gbThayThe.Controls.Add(this.btn_ThucHienThayThe);
            this.gbThayThe.Controls.Add(this.txt_SoThayTheMoi);
            this.gbThayThe.Controls.Add(this.txt_ThayTheGiaTri);
            this.gbThayThe.Controls.Add(this.lblSoThayThe);
            this.gbThayThe.Controls.Add(this.lblThayTheGiaTri);
            this.gbThayThe.Location = new System.Drawing.Point(280, 435);
            this.gbThayThe.Name = "gbThayThe";
            this.gbThayThe.Size = new System.Drawing.Size(230, 95);
            this.gbThayThe.TabIndex = 13;
            this.gbThayThe.TabStop = false;
            this.gbThayThe.Text = "Thay Thế";
            // 
            // btn_ThucHienThayThe
            // 
            this.btn_ThucHienThayThe.Location = new System.Drawing.Point(145, 55);
            this.btn_ThucHienThayThe.Name = "btn_ThucHienThayThe";
            this.btn_ThucHienThayThe.Size = new System.Drawing.Size(75, 25);
            this.btn_ThucHienThayThe.TabIndex = 4;
            this.btn_ThucHienThayThe.Text = "Thay thế";
            this.btn_ThucHienThayThe.UseVisualStyleBackColor = true;
            this.btn_ThucHienThayThe.Click += new System.EventHandler(this.btn_ThucHienThayThe_Click);
            // 
            // txt_SoThayTheMoi
            // 
            this.txt_SoThayTheMoi.Location = new System.Drawing.Point(95, 58);
            this.txt_SoThayTheMoi.Name = "txt_SoThayTheMoi";
            this.txt_SoThayTheMoi.Size = new System.Drawing.Size(45, 20);
            this.txt_SoThayTheMoi.TabIndex = 3;
            // 
            // txt_ThayTheGiaTri
            // 
            this.txt_ThayTheGiaTri.Location = new System.Drawing.Point(95, 22);
            this.txt_ThayTheGiaTri.Name = "txt_ThayTheGiaTri";
            this.txt_ThayTheGiaTri.Size = new System.Drawing.Size(45, 20);
            this.txt_ThayTheGiaTri.TabIndex = 2;
            // 
            // lblSoThayThe
            // 
            this.lblSoThayThe.AutoSize = true;
            this.lblSoThayThe.Location = new System.Drawing.Point(10, 61);
            this.lblSoThayThe.Name = "lblSoThayThe";
            this.lblSoThayThe.Size = new System.Drawing.Size(78, 13);
            this.lblSoThayThe.TabIndex = 1;
            this.lblSoThayThe.Text = "Số thay thế là:";
            // 
            // lblThayTheGiaTri
            // 
            this.lblThayTheGiaTri.AutoSize = true;
            this.lblThayTheGiaTri.Location = new System.Drawing.Point(10, 25);
            this.lblThayTheGiaTri.Name = "lblThayTheGiaTri";
            this.lblThayTheGiaTri.Size = new System.Drawing.Size(81, 13);
            this.lblThayTheGiaTri.TabIndex = 0;
            this.lblThayTheGiaTri.Text = "Giá trị thay thế:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 545);
            this.Controls.Add(this.gbThayThe);
            this.Controls.Add(this.gbMaxMin);
            this.Controls.Add(this.gbTong);
            this.Controls.Add(this.gbThem);
            this.Controls.Add(this.gbXoa);
            this.Controls.Add(this.gbTimKiem);
            this.Controls.Add(this.gbSapXep);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.txt_KetQuaMang);
            this.Controls.Add(this.txt_NhapMang);
            this.Controls.Add(this.lblKetQuaMang);
            this.Controls.Add(this.lblNhapMang);
            this.Controls.Add(this.lblTieuDe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mảng Số Nguyên";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.gbSapXep.ResumeLayout(false);
            this.gbSapXep.PerformLayout();
            this.gbTimKiem.ResumeLayout(false);
            this.gbTimKiem.PerformLayout();
            this.gbXoa.ResumeLayout(false);
            this.gbXoa.PerformLayout();
            this.gbThem.ResumeLayout(false);
            this.gbThem.PerformLayout();
            this.gbTong.ResumeLayout(false);
            this.gbTong.PerformLayout();
            this.gbMaxMin.ResumeLayout(false);
            this.gbMaxMin.PerformLayout();
            this.gbThayThe.ResumeLayout(false);
            this.gbThayThe.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblNhapMang;
        private System.Windows.Forms.Label lblKetQuaMang;
        private System.Windows.Forms.TextBox txt_NhapMang;
        private System.Windows.Forms.TextBox txt_KetQuaMang;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.GroupBox gbSapXep;
        private System.Windows.Forms.Button btn_ThucHienSX;
        private System.Windows.Forms.RadioButton rdo_SapXepGiam;
        private System.Windows.Forms.RadioButton rdo_SapXepTang;
        private System.Windows.Forms.GroupBox gbTimKiem;
        private System.Windows.Forms.Button btn_Tim;
        private System.Windows.Forms.TextBox txt_SoTimDuoc;
        private System.Windows.Forms.Label lblSoTim;
        private System.Windows.Forms.TextBox txt_TimViTri;
        private System.Windows.Forms.TextBox txt_TimGiaTri;
        private System.Windows.Forms.RadioButton rdo_TimViTri;
        private System.Windows.Forms.RadioButton rdo_TimGiaTri;
        private System.Windows.Forms.GroupBox gbXoa;
        private System.Windows.Forms.Button btn_ThucHienXoa;
        private System.Windows.Forms.TextBox txt_XoaViTri;
        private System.Windows.Forms.TextBox txt_XoaGiaTri;
        private System.Windows.Forms.RadioButton rdo_XoaViTri;
        private System.Windows.Forms.RadioButton rdo_XoaGiaTri;
        private System.Windows.Forms.GroupBox gbThem;
        private System.Windows.Forms.Button btn_ThucHienThem;
        private System.Windows.Forms.TextBox txt_ViTriThem;
        private System.Windows.Forms.TextBox txt_GiaTriThem;
        private System.Windows.Forms.Label lblViTriThem;
        private System.Windows.Forms.Label lblGiaTriThem;
        private System.Windows.Forms.GroupBox gbTong;
        private System.Windows.Forms.Button btn_Tong;
        private System.Windows.Forms.TextBox txt_TongLe;
        private System.Windows.Forms.TextBox txt_TongChan;
        private System.Windows.Forms.TextBox txt_TongMang;
        private System.Windows.Forms.Label lblTongLe;
        private System.Windows.Forms.Label lblTongChan;
        private System.Windows.Forms.Label lblTongMang;
        private System.Windows.Forms.GroupBox gbMaxMin;
        private System.Windows.Forms.Button btn_TimMaxMin;
        private System.Windows.Forms.TextBox txt_Min;
        private System.Windows.Forms.TextBox txt_Max;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.GroupBox gbThayThe;
        private System.Windows.Forms.Button btn_ThucHienThayThe;
        private System.Windows.Forms.TextBox txt_SoThayTheMoi;
        private System.Windows.Forms.TextBox txt_ThayTheGiaTri;
        private System.Windows.Forms.Label lblSoThayThe;
        private System.Windows.Forms.Label lblThayTheGiaTri;
    }
}