namespace QLSinhVien
{
    partial class frmDanhSachDiem
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.lblMH = new System.Windows.Forms.Label();
            this.lblTongDiem = new System.Windows.Forms.Label();
            this.cboMonHoc = new System.Windows.Forms.ComboBox();
            this.btnLoc = new System.Windows.Forms.Button();
            this.txtTongDiem = new System.Windows.Forms.TextBox();
            this.lvDiem = new System.Windows.Forms.ListView();
            this.colSTT = new System.Windows.Forms.ColumnHeader();
            this.colTenSV = new System.Windows.Forms.ColumnHeader();
            this.colNgaySinh = new System.Windows.Forms.ColumnHeader();
            this.colTenMH = new System.Windows.Forms.ColumnHeader();
            this.colDiem = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();

            this.lblMH.Text = "Môn học:"; this.lblMH.Location = new System.Drawing.Point(30, 25);
            this.cboMonHoc.Location = new System.Drawing.Point(100, 22); this.cboMonHoc.Size = new System.Drawing.Size(200, 23); this.cboMonHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.btnLoc.Text = "Lọc dữ liệu"; this.btnLoc.Location = new System.Drawing.Point(320, 20); this.btnLoc.Size = new System.Drawing.Size(100, 27);
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);

            this.lvDiem.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { this.colSTT, this.colTenSV, this.colNgaySinh, this.colTenMH, this.colDiem });
            this.lvDiem.GridLines = true; this.lvDiem.FullRowSelect = true; this.lvDiem.View = System.Windows.Forms.View.Details;
            this.lvDiem.Location = new System.Drawing.Point(30, 60); this.lvDiem.Size = new System.Drawing.Size(560, 250);

            this.colSTT.Text = "STT"; this.colSTT.Width = 40;
            this.colTenSV.Text = "Tên SV"; this.colTenSV.Width = 140;
            this.colNgaySinh.Text = "Ngày sinh"; this.colNgaySinh.Width = 120;
            this.colTenMH.Text = "Tên môn học"; this.colTenMH.Width = 150;
            this.colDiem.Text = "Điểm"; this.colDiem.Width = 80;

            this.lblTongDiem.Text = "Tổng điểm:"; this.lblTongDiem.Location = new System.Drawing.Point(380, 325);
            this.txtTongDiem.Location = new System.Drawing.Point(460, 322); this.txtTongDiem.Size = new System.Drawing.Size(130, 23); this.txtTongDiem.ReadOnly = true;

            this.ClientSize = new System.Drawing.Size(620, 365);
            this.Controls.AddRange(new System.Windows.Forms.Control[] { this.lblMH, this.cboMonHoc, this.btnLoc, this.lvDiem, this.lblTongDiem, this.txtTongDiem });
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách sinh viên";
            this.Load += new System.EventHandler(this.frmDanhSachDiem_Load);
            this.ResumeLayout(false); this.PerformLayout();
        }
        #endregion

        private System.Windows.Forms.Label lblMH, lblTongDiem;
        private System.Windows.Forms.ComboBox cboMonHoc;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.TextBox txtTongDiem;
        private System.Windows.Forms.ListView lvDiem;
        private System.Windows.Forms.ColumnHeader colSTT, colTenSV, colNgaySinh, colTenMH, colDiem;
    }
}