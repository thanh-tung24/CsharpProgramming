using System;
using System.Windows.Forms;

namespace BaiNangCao
{
    public partial class frmNhapHocVien : Form
    {
        // Thuộc tính công khai để Form chính lấy dữ liệu
        public string HoTenHocVien { get; private set; }
        public string LopDuocChon { get; private set; }

        public frmNhapHocVien()
        {
            InitializeComponent();
        }

        private void frmNhapHocVien_Load(object sender, EventArgs e)
        {
            if (cboLop.Items.Count > 0)
            {
                cboLop.SelectedIndex = 0;
            }
            txtHoTen.Focus();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string hoTen = txtHoTen.Text.Trim();

            if (string.IsNullOrEmpty(hoTen))
            {
                MessageBox.Show("Vui lòng nhập họ và tên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); //[cite: 33]
                txtHoTen.Focus(); //[cite: 33]
                return;
            }

            HoTenHocVien = hoTen;
            LopDuocChon = cboLop.SelectedItem.ToString();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close(); //[cite: 33]
        }
    }
}