using System;
using System.Windows.Forms;

namespace Bai2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Trạng thái ban đầu: nút Lưu, Xóa bị vô hiệu hóa
            btnLuu.Enabled = false;
            btnXoa.Enabled = false;
            KhoaCacTextBox(true);
        }

        // Khóa hoặc mở các ô TextBox
        private void KhoaCacTextBox(bool khoa)
        {
            txtSoTaiKhoan.ReadOnly = khoa;
            txtTenKhachHang.ReadOnly = khoa;
            txtDiaChi.ReadOnly = khoa;
            txtSoTien.ReadOnly = khoa;
        }

        // Xóa nội dung trong các ô TextBox
        private void XoaTrangTextBox()
        {
            txtSoTaiKhoan.Clear();
            txtTenKhachHang.Clear();
            txtDiaChi.Clear();
            txtSoTien.Clear();
        }

        // Chặn người dùng nhập ký tự không phải số ở ô Số tiền
        private void txtSoTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // Đánh lại số thứ tự (STT) và tính tổng tiền cho tất cả mẫu tin trong ListView
        private void CapNhatSTTVaTongTien()
        {
            long tongTien = 0;
            for (int i = 0; i < lvwTaiKhoan.Items.Count; i++)
            {
                lvwTaiKhoan.Items[i].SubItems[0].Text = (i + 1).ToString();

                // Lấy giá trị số tiền đã lưu (lưu ở Tag dưới dạng số nguyên gốc)
                if (lvwTaiKhoan.Items[i].Tag != null)
                {
                    tongTien += Convert.ToInt64(lvwTaiKhoan.Items[i].Tag);
                }
            }

            txtTongTien.Text = string.Format("{0:N0}", tongTien);
        }

        // Kiểm tra xem số tài khoản đã có trong ListView chưa
        private bool KiemTraTrungSoTaiKhoan(string stk)
        {
            foreach (ListViewItem item in lvwTaiKhoan.Items)
            {
                if (string.Compare(item.SubItems[1].Text.Trim(), stk.Trim(), true) == 0)
                {
                    return true;
                }
            }
            return false;
        }

        // Button "Thêm" / "Hủy"
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (btnThem.Text == "Thêm")
            {
                btnThem.Text = "Hủy";
                btnLuu.Enabled = true;
                btnXoa.Enabled = false;

                KhoaCacTextBox(false);
                XoaTrangTextBox();
                txtSoTaiKhoan.Focus();
            }
            else // Khi đang là "Hủy"
            {
                btnThem.Text = "Thêm";
                btnLuu.Enabled = false;
                btnXoa.Enabled = lvwTaiKhoan.SelectedItems.Count > 0;

                XoaTrangTextBox();
                KhoaCacTextBox(true);
            }
        }

        // Button "Lưu": Lưu thông tin từ các TextBox vào ListView
        private void btnLuu_Click(object sender, EventArgs e)
        {
            string stk = txtSoTaiKhoan.Text.Trim();
            string tenKH = txtTenKhachHang.Text.Trim();
            string diaChi = txtDiaChi.Text.Trim();
            string chuoiSoTien = txtSoTien.Text.Trim();

            if (string.IsNullOrEmpty(stk) || string.IsNullOrEmpty(tenKH) || string.IsNullOrEmpty(diaChi) || string.IsNullOrEmpty(chuoiSoTien))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tất cả thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!long.TryParse(chuoiSoTien, out long soTien) || soTien < 0)
            {
                MessageBox.Show("Số tiền trong tài khoản phải là một số nguyên dương hợp lệ!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSoTien.SelectAll();
                txtSoTien.Focus();
                return;
            }

            if (KiemTraTrungSoTaiKhoan(stk))
            {
                MessageBox.Show("Số tài khoản này đã tồn tại trong hệ thống!", "Trùng dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSoTaiKhoan.SelectAll();
                txtSoTaiKhoan.Focus();
                return;
            }

            // Tạo dòng mới trên ListView
            ListViewItem item = new ListViewItem(""); // Cột STT sẽ được hàm đánh số lại
            item.SubItems.Add(stk);
            item.SubItems.Add(tenKH);
            item.SubItems.Add(diaChi);
            item.SubItems.Add(string.Format("{0:N0}", soTien));
            item.Tag = soTien; // Lưu giá trị số gốc để dễ tính tổng

            lvwTaiKhoan.Items.Add(item);
            CapNhatSTTVaTongTien();

            // Trả trạng thái giao diện về ban đầu sau khi lưu
            btnThem.Text = "Thêm";
            btnLuu.Enabled = false;
            XoaTrangTextBox();
            KhoaCacTextBox(true);
        }

        // Khi click chọn một dòng khách hàng trong ListView
        private void lvwTaiKhoan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwTaiKhoan.SelectedItems.Count > 0)
            {
                btnXoa.Enabled = true;

                ListViewItem item = lvwTaiKhoan.SelectedItems[0];
                txtSoTaiKhoan.Text = item.SubItems[1].Text;
                txtTenKhachHang.Text = item.SubItems[2].Text;
                txtDiaChi.Text = item.SubItems[3].Text;
                txtSoTien.Text = item.Tag != null ? item.Tag.ToString() : item.SubItems[4].Text.Replace(",", "");
            }
            else
            {
                btnXoa.Enabled = false;
            }
        }

        // Button "Xóa": Xóa mẫu tin hiện hành
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lvwTaiKhoan.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một khách hàng cần xóa trong danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult r = MessageBox.Show("Bạn có chắc chắn muốn xóa tài khoản này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                lvwTaiKhoan.Items.Remove(lvwTaiKhoan.SelectedItems[0]);
                XoaTrangTextBox();
                CapNhatSTTVaTongTien();
                btnXoa.Enabled = false;
            }
        }

        // Button "Thoát"
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