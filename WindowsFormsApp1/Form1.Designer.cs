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
            this.btnNgauNhien = new System.Windows.Forms.Button();
            this.lstTen = new System.Windows.Forms.ListBox();
            this.btnXoaDangChon = new System.Windows.Forms.Button();
            this.btnXoaTenSon = new System.Windows.Forms.Button();
            this.btnXoaHoLe = new System.Windows.Forms.Button();
            this.btnChuyenHoa = new System.Windows.Forms.Button();
            this.btnChuyenThuong = new System.Windows.Forms.Button();
            this.btnHoaDauTu = new System.Windows.Forms.Button();
            this.btnXoaTatCa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNgauNhien
            // 
            this.btnNgauNhien.Location = new System.Drawing.Point(20, 20);
            this.btnNgauNhien.Name = "btnNgauNhien";
            this.btnNgauNhien.Size = new System.Drawing.Size(260, 40);
            this.btnNgauNhien.TabIndex = 0;
            this.btnNgauNhien.Text = "Nhập tên ngẫu nhiên";
            this.btnNgauNhien.UseVisualStyleBackColor = true;
            this.btnNgauNhien.Click += new System.EventHandler(this.btnNgauNhien_Click);
            // 
            // lstTen
            // 
            this.lstTen.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lstTen.FormattingEnabled = true;
            this.lstTen.ItemHeight = 21;
            this.lstTen.Location = new System.Drawing.Point(20, 75);
            this.lstTen.Name = "lstTen";
            this.lstTen.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstTen.Size = new System.Drawing.Size(260, 319);
            this.lstTen.TabIndex = 1;
            this.lstTen.DoubleClick += new System.EventHandler(this.lstTen_DoubleClick);
            // 
            // btnXoaDangChon
            // 
            this.btnXoaDangChon.Location = new System.Drawing.Point(310, 75);
            this.btnXoaDangChon.Name = "btnXoaDangChon";
            this.btnXoaDangChon.Size = new System.Drawing.Size(280, 36);
            this.btnXoaDangChon.TabIndex = 2;
            this.btnXoaDangChon.Text = "Xóa Phần tử đang chọn";
            this.btnXoaDangChon.UseVisualStyleBackColor = true;
            this.btnXoaDangChon.Click += new System.EventHandler(this.btnXoaDangChon_Click);
            // 
            // btnXoaTenSon
            // 
            this.btnXoaTenSon.Location = new System.Drawing.Point(310, 122);
            this.btnXoaTenSon.Name = "btnXoaTenSon";
            this.btnXoaTenSon.Size = new System.Drawing.Size(280, 36);
            this.btnXoaTenSon.TabIndex = 3;
            this.btnXoaTenSon.Text = "Xóa phần tử có tên là Sơn";
            this.btnXoaTenSon.UseVisualStyleBackColor = true;
            this.btnXoaTenSon.Click += new System.EventHandler(this.btnXoaTenSon_Click);
            // 
            // btnXoaHoLe
            // 
            this.btnXoaHoLe.Location = new System.Drawing.Point(310, 169);
            this.btnXoaHoLe.Name = "btnXoaHoLe";
            this.btnXoaHoLe.Size = new System.Drawing.Size(280, 36);
            this.btnXoaHoLe.TabIndex = 4;
            this.btnXoaHoLe.Text = "Xóa Phần tử có họ là Lê";
            this.btnXoaHoLe.UseVisualStyleBackColor = true;
            this.btnXoaHoLe.Click += new System.EventHandler(this.btnXoaHoLe_Click);
            // 
            // btnChuyenHoa
            // 
            this.btnChuyenHoa.Location = new System.Drawing.Point(310, 216);
            this.btnChuyenHoa.Name = "btnChuyenHoa";
            this.btnChuyenHoa.Size = new System.Drawing.Size(280, 36);
            this.btnChuyenHoa.TabIndex = 5;
            this.btnChuyenHoa.Text = "Chuyển PT đang chọn thành chữ HOA";
            this.btnChuyenHoa.UseVisualStyleBackColor = true;
            this.btnChuyenHoa.Click += new System.EventHandler(this.btnChuyenHoa_Click);
            // 
            // btnChuyenThuong
            // 
            this.btnChuyenThuong.Location = new System.Drawing.Point(310, 263);
            this.btnChuyenThuong.Name = "btnChuyenThuong";
            this.btnChuyenThuong.Size = new System.Drawing.Size(280, 36);
            this.btnChuyenThuong.TabIndex = 6;
            this.btnChuyenThuong.Text = "Chuyển PT đang chọn thành chữ thường";
            this.btnChuyenThuong.UseVisualStyleBackColor = true;
            this.btnChuyenThuong.Click += new System.EventHandler(this.btnChuyenThuong_Click);
            // 
            // btnHoaDauTu
            // 
            this.btnHoaDauTu.Location = new System.Drawing.Point(310, 310);
            this.btnHoaDauTu.Name = "btnHoaDauTu";
            this.btnHoaDauTu.Size = new System.Drawing.Size(280, 42);
            this.btnHoaDauTu.TabIndex = 7;
            this.btnHoaDauTu.Text = "Chuyển PT đang chọn thành viết Hoa\r\nđầu mỗi từ";
            this.btnHoaDauTu.UseVisualStyleBackColor = true;
            this.btnHoaDauTu.Click += new System.EventHandler(this.btnHoaDauTu_Click);
            // 
            // btnXoaTatCa
            // 
            this.btnXoaTatCa.Location = new System.Drawing.Point(310, 360);
            this.btnXoaTatCa.Name = "btnXoaTatCa";
            this.btnXoaTatCa.Size = new System.Drawing.Size(280, 36);
            this.btnXoaTatCa.TabIndex = 8;
            this.btnXoaTatCa.Text = "Xóa tất cả các Phần tử";
            this.btnXoaTatCa.UseVisualStyleBackColor = true;
            this.btnXoaTatCa.Click += new System.EventHandler(this.btnXoaTatCa_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 415);
            this.Controls.Add(this.btnXoaTatCa);
            this.Controls.Add(this.btnHoaDauTu);
            this.Controls.Add(this.btnChuyenThuong);
            this.Controls.Add(this.btnChuyenHoa);
            this.Controls.Add(this.btnXoaHoLe);
            this.Controls.Add(this.btnXoaTenSon);
            this.Controls.Add(this.btnXoaDangChon);
            this.Controls.Add(this.lstTen);
            this.Controls.Add(this.btnNgauNhien);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmChuoi";
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnNgauNhien;
        private System.Windows.Forms.ListBox lstTen;
        private System.Windows.Forms.Button btnXoaDangChon;
        private System.Windows.Forms.Button btnXoaTenSon;
        private System.Windows.Forms.Button btnXoaHoLe;
        private System.Windows.Forms.Button btnChuyenHoa;
        private System.Windows.Forms.Button btnChuyenThuong;
        private System.Windows.Forms.Button btnHoaDauTu;
        private System.Windows.Forms.Button btnXoaTatCa;
    }
}