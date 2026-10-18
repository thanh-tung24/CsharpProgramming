using System;
using System.Windows.Forms;

namespace Bai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Chặn nhập ký tự không phải số nguyên dương
        private void txtNhapSo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // Button Cập nhật: Thêm số vào ComboBox
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string chuoiNhap = txtNhapSo.Text.Trim();

            if (string.IsNullOrEmpty(chuoiNhap))
            {
                MessageBox.Show("Vui lòng nhập một số nguyên dương!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNhapSo.Focus();
                return;
            }

            if (!int.TryParse(chuoiNhap, out int so) || so <= 0)
            {
                MessageBox.Show("Giá trị nhập phải là số nguyên dương lớn hơn 0!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNhapSo.SelectAll();
                txtNhapSo.Focus();
                return;
            }

            // Kiểm tra số đã tồn tại trong ComboBox chưa
            if (cboSo.Items.Contains(so))
            {
                MessageBox.Show("Số này đã tồn tại trong danh sách chọn!", "Trùng dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                cboSo.Items.Add(so);
                cboSo.SelectedItem = so;
            }

            txtNhapSo.Clear();
            txtNhapSo.Focus();
        }

        // Khi chọn một số trong ComboBox -> Nạp tất cả ước số vào ListBox
        private void cboSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstUocSo.Items.Clear();

            if (cboSo.SelectedItem != null && int.TryParse(cboSo.SelectedItem.ToString(), out int n))
            {
                for (int i = 1; i <= n; i++)
                {
                    if (n % i == 0)
                    {
                        lstUocSo.Items.Add(i);
                    }
                }
            }
        }

        // Button Tính tổng các ước số
        private void btnTongUocSo_Click(object sender, EventArgs e)
        {
            if (lstUocSo.Items.Count == 0)
            {
                MessageBox.Show("Chưa có ước số nào trong danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int tong = 0;
            foreach (var item in lstUocSo.Items)
            {
                tong += Convert.ToInt32(item);
            }

            MessageBox.Show($"Tổng các ước số là: {tong}", "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Button Đếm số lượng các ước số chẵn
        private void btnSoLuongUocSoChan_Click(object sender, EventArgs e)
        {
            if (lstUocSo.Items.Count == 0)
            {
                MessageBox.Show("Chưa có ước số nào trong danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int dem = 0;
            foreach (var item in lstUocSo.Items)
            {
                if (Convert.ToInt32(item) % 2 == 0)
                {
                    dem++;
                }
            }

            MessageBox.Show($"Số lượng các ước số chẵn là: {dem}", "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Hàm kiểm tra số nguyên tố
        private bool KiemTraNguyenTo(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i * i <= n; i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }

        // Button Đếm số lượng các ước số nguyên tố
        private void btnSoLuongUocSoNguyenTo_Click(object sender, EventArgs e)
        {
            if (lstUocSo.Items.Count == 0)
            {
                MessageBox.Show("Chưa có ước số nào trong danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int dem = 0;
            foreach (var item in lstUocSo.Items)
            {
                if (KiemTraNguyenTo(Convert.ToInt32(item)))
                {
                    dem++;
                }
            }

            MessageBox.Show($"Số lượng các ước số nguyên tố là: {dem}", "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Button Thoát và xác nhận khi đóng Form
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có chắc chắn muốn thoát khỏi chương trình?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}