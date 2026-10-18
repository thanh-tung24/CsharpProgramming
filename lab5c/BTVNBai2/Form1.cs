using System;
using System.Windows.Forms;

namespace BTVNBai2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Nạp dữ liệu mẫu ban đầu như trên đề bài
            int[] mangSo = { 30, 21, 35, 43, 1, 3, 20, 9, 4, 80 };
            foreach (int x in mangSo)
            {
                lstSo.Items.Add(x);
            }
            txtNhap.Focus();
        }

        // Chặn nhập ký tự không phải số nguyên
        private void txtNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // Button Nhập: Thêm số tự nhiên N vào ListBox
        private void btnNhap_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtNhap.Text.Trim(), out int n))
            {
                lstSo.Items.Add(n);
                txtNhap.Clear();
                txtNhap.Focus();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập một số tự nhiên hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNhap.SelectAll();
                txtNhap.Focus();
            }
        }

        // 1. Tính tổng các phần tử trong ListBox
        private void btnTongPhanTu_Click(object sender, EventArgs e)
        {
            if (lstSo.Items.Count == 0)
            {
                MessageBox.Show("ListBox đang trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            long tong = 0;
            foreach (var item in lstSo.Items)
            {
                tong += Convert.ToInt64(item);
            }

            MessageBox.Show($"Tổng các phần tử trong List là: {tong}", "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // 2. Xóa phần tử đầu và cuối của ListBox
        private void btnXoaDauCuoi_Click(object sender, EventArgs e)
        {
            if (lstSo.Items.Count == 0)
            {
                MessageBox.Show("ListBox không có phần tử nào để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (lstSo.Items.Count == 1)
            {
                lstSo.Items.RemoveAt(0);
            }
            else
            {
                lstSo.Items.RemoveAt(lstSo.Items.Count - 1); // Xóa phần tử cuối
                lstSo.Items.RemoveAt(0);                    // Xóa phần tử đầu
            }
        }

        // 3. Xóa các phần tử đang chọn trong ListBox
        private void btnXoaDangChon_Click(object sender, EventArgs e)
        {
            if (lstSo.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một phần tử để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            for (int i = lstSo.SelectedIndices.Count - 1; i >= 0; i--)
            {
                lstSo.Items.RemoveAt(lstSo.SelectedIndices[i]);
            }
        }

        // 4. Tăng giá trị mỗi phần tử lên 2
        private void btnTangMoiPhanTu_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstSo.Items.Count; i++)
            {
                int val = Convert.ToInt32(lstSo.Items[i]);
                lstSo.Items[i] = val + 2;
            }
        }

        // 5. Thay mỗi giá trị của phần tử bằng bình phương của chính nó
        private void btnThayBinhPhuong_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstSo.Items.Count; i++)
            {
                long val = Convert.ToInt64(lstSo.Items[i]);
                lstSo.Items[i] = val * val;
            }
        }

        // 6. Thực hiện chọn các phần tử là số chẵn
        private void btnChonChan_Click(object sender, EventArgs e)
        {
            lstSo.ClearSelected();
            for (int i = 0; i < lstSo.Items.Count; i++)
            {
                if (Convert.ToInt64(lstSo.Items[i]) % 2 == 0)
                {
                    lstSo.SetSelected(i, true);
                }
            }
        }

        // 7. Thực hiện chọn các phần tử là số lẻ
        private void btnChonLe_Click(object sender, EventArgs e)
        {
            lstSo.ClearSelected();
            for (int i = 0; i < lstSo.Items.Count; i++)
            {
                if (Convert.ToInt64(lstSo.Items[i]) % 2 != 0)
                {
                    lstSo.SetSelected(i, true);
                }
            }
        }

        // Nút Kết thúc
        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có chắc chắn muốn kết thúc?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}