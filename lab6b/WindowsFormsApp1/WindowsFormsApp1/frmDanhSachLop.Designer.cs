namespace QLSinhVien
{
    partial class frmDanhSachLop
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
            this.btnHienThi = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lvLop = new System.Windows.Forms.ListView();
            this.colSTT = new System.Windows.Forms.ColumnHeader();
            this.colMaLop = new System.Windows.Forms.ColumnHeader();
            this.colTenLop = new System.Windows.Forms.ColumnHeader();
            this.colMaKhoa = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();

            this.btnHienThi.Text = "Hiển thị dữ liệu";
            this.btnHienThi.Location = new System.Drawing.Point(30, 20);
            this.btnHienThi.Size = new System.Drawing.Size(120, 30);
            this.btnHienThi.Click += new System.EventHandler(this.btnHienThi_Click);

            this.btnThoat.Text = "Thoát";
            this.btnThoat.Location = new System.Drawing.Point(400, 310);
            this.btnThoat.Size = new System.Drawing.Size(90, 30);
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);

            this.lvLop.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { this.colSTT, this.colMaLop, this.colTenLop, this.colMaKhoa });
            this.lvLop.GridLines = true;
            this.lvLop.FullRowSelect = true;
            this.lvLop.View = System.Windows.Forms.View.Details;
            this.lvLop.Location = new System.Drawing.Point(30, 60);
            this.lvLop.Size = new System.Drawing.Size(460, 230);

            this.colSTT.Text = "STT"; this.colSTT.Width = 50;
            this.colMaLop.Text = "Mã lớp"; this.colMaLop.Width = 100;
            this.colTenLop.Text = "Tên lớp"; this.colTenLop.Width = 200;
            this.colMaKhoa.Text = "Mã khoa"; this.colMaKhoa.Width = 100;

            this.ClientSize = new System.Drawing.Size(520, 360);
            this.Controls.AddRange(new System.Windows.Forms.Control[] { this.btnHienThi, this.lvLop, this.btnThoat });
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách Lớp";
            this.ResumeLayout(false);
        }
        #endregion

        private System.Windows.Forms.Button btnHienThi, btnThoat;
        private System.Windows.Forms.ListView lvLop;
        private System.Windows.Forms.ColumnHeader colSTT, colMaLop, colTenLop, colMaKhoa;
    }
}