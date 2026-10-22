namespace QLSinhVien
{
    partial class frmDiem_Combo
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
            this.lblSV = new System.Windows.Forms.Label();
            this.lblMH = new System.Windows.Forms.Label();
            this.lblDiem = new System.Windows.Forms.Label();
            this.cboSinhVien = new System.Windows.Forms.ComboBox();
            this.cboMonHoc = new System.Windows.Forms.ComboBox();
            this.txtDiem = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.SuspendLayout();

            this.lblSV.Text = "Sinh viên:"; this.lblSV.Location = new System.Drawing.Point(30, 25);
            this.lblMH.Text = "Môn học:"; this.lblMH.Location = new System.Drawing.Point(30, 60);
            this.lblDiem.Text = "Điểm:"; this.lblDiem.Location = new System.Drawing.Point(30, 95);

            this.cboSinhVien.Location = new System.Drawing.Point(100, 22); this.cboSinhVien.Size = new System.Drawing.Size(200, 23); this.cboSinhVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMonHoc.Location = new System.Drawing.Point(100, 57); this.cboMonHoc.Size = new System.Drawing.Size(200, 23); this.cboMonHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtDiem.Location = new System.Drawing.Point(100, 92); this.txtDiem.Size = new System.Drawing.Size(200, 23);

            this.btnThem.Text = "Thêm"; this.btnThem.Location = new System.Drawing.Point(30, 140); this.btnThem.Size = new System.Drawing.Size(75, 30); this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            this.btnXoa.Text = "Xóa"; this.btnXoa.Location = new System.Drawing.Point(125, 140); this.btnXoa.Size = new System.Drawing.Size(75, 30); this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            this.btnSua.Text = "Sửa"; this.btnSua.Location = new System.Drawing.Point(225, 140); this.btnSua.Size = new System.Drawing.Size(75, 30); this.btnSua.Click += new System.EventHandler(this.btnSua_Click);

            this.ClientSize = new System.Drawing.Size(330, 190);
            this.Controls.AddRange(new System.Windows.Forms.Control[] { this.lblSV, this.lblMH, this.lblDiem, this.cboSinhVien, this.cboMonHoc, this.txtDiem, this.btnThem, this.btnXoa, this.btnSua });
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDiem_combo";
            this.Load += new System.EventHandler(this.frmDiem_Combo_Load);
            this.ResumeLayout(false); this.PerformLayout();
        }
        #endregion

        private System.Windows.Forms.Label lblSV, lblMH, lblDiem;
        private System.Windows.Forms.ComboBox cboSinhVien, cboMonHoc;
        private System.Windows.Forms.TextBox txtDiem;
        private System.Windows.Forms.Button btnThem, btnXoa, btnSua;
    }
}