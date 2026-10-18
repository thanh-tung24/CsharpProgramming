using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Bai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Nạp danh sách dân tộc vào ComboBox
            string[] dsDanToc = { "Kinh", "Hoa", "K'Me", "H'Mong", "Tày", "Nùng", "Khác" };
            cboDanToc.Items.AddRange(dsDanToc);
            cboDanToc.SelectedIndex = 0;
        }

        // Lấy chuỗi danh sách các ngoại ngữ được tích chọn
        private string LayChuoiNgoaiNgu()
        {
            List<string> nn = new List<string>();
            if (chkAnh.Checked) nn.Add("Anh");
            if (chkPhap.Checked) nn.Add("Pháp");
            if (chkHoa.Checked) nn.Add("Hoa");

            return nn.Count > 0 ? string.Join(", ", nn) : "Không";
        }

        // Kiểm tra trùng mã sinh viên trên ListView
        private bool KiemTraTrungMaSV(string maSV)
        {
            foreach (ListViewItem item in lvwSinhVien.Items)
            {
                if (string.Compare(item.SubItems[1].Text.Trim(), maSV.Trim(), true) == 0)
                {
                    return true;
                }
            }
            return false;
        }

        // Làm trắng form nhập liệu
        private void XoaTrangNhapLieu()
        {
            txtHoTen.Clear();
            txtMaSV.Clear();
            txtMaSV.ReadOnly = false;
            radNam.Checked = true;
            chkAnh.Checked = false;
            chkPhap.Checked = false;
            chkHoa.Checked = false;
            cboDanToc.SelectedIndex = 0;
            txtHoTen.Focus();
        }

        // Button Thêm sinh viên
        private void btnThem_Click(object sender, EventArgs e)
        {
            string hoTen = txtHoTen.Text.Trim();
            string maSV = txtMaSV.Text.Trim();

            if (string.IsNullOrEmpty(hoTen))
            {
                MessageBox.Show("Vui lòng nhập họ và tên sinh viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoTen.Focus();
                return;
            }

            if (string.IsNullOrEmpty(maSV))
            {
                MessageBox.Show("Vui lòng nhập mã sinh viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaSV.Focus();
                return;
            }

            // Kiểm tra không cho trùng mã SV theo yêu cầu đề bài
            if (KiemTraTrungMaSV(maSV))
            {
                MessageBox.Show("Mã sinh viên này đã tồn tại, vui lòng nhập mã khác!", "Trùng dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaSV.SelectAll();
                txtMaSV.Focus();
                return;
            }

            string gioiTinh = radNam.Checked ? "Nam" : "Nữ";
            string ngoaiNgu = LayChuoiNgoaiNgu();
            string danToc = cboDanToc.SelectedItem != null ? cboDanToc.SelectedItem.ToString() : "Kinh";

            // Tạo ListViewItem với cột đầu là Họ tên, các cột sau là SubItems
            ListViewItem item = new ListViewItem(hoTen);
            item.SubItems.Add(maSV);
            item.SubItems.Add(gioiTinh);
            item.SubItems.Add(ngoaiNgu);
            item.SubItems.Add(danToc);

            lvwSinhVien.Items.Add(item);
            XoaTrangNhapLieu();
        }

        // Khi chọn 1 dòng trên ListView: hiển thị ngược lại lên controls và khóa mã SV
        private void lvwSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwSinhVien.SelectedItems.Count > 0)
            {
                ListViewItem item = lvwSinhVien.SelectedItems[0];
                txtHoTen.Text = item.SubItems[0].Text;
                txtMaSV.Text = item.SubItems[1].Text;
                txtMaSV.ReadOnly = true; // Theo yêu cầu: không cho sửa Mã sinh viên

                if (item.SubItems[2].Text == "Nam") radNam.Checked = true;
                else radNu.Checked = true;

                string ngoaiNgu = item.SubItems[3].Text;
                chkAnh.Checked = ngoaiNgu.Contains("Anh");
                chkPhap.Checked = ngoaiNgu.Contains("Pháp");
                chkHoa.Checked = ngoaiNgu.Contains("Hoa");

                cboDanToc.SelectedItem = item.SubItems[4].Text;
            }
            else
            {
                txtMaSV.ReadOnly = false;
            }
        }

        // Button Sửa thông tin
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lvwSinhVien.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần sửa trong danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string hoTen = txtHoTen.Text.Trim();
            if (string.IsNullOrEmpty(hoTen))
            {
                MessageBox.Show("Họ tên không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoTen.Focus();
                return;
            }

            ListViewItem item = lvwSinhVien.SelectedItems[0];
            item.SubItems[0].Text = hoTen;
            // item.SubItems[1].Text giữ nguyên (không cho sửa Mã SV)
            item.SubItems[2].Text = radNam.Checked ? "Nam" : "Nữ";
            item.SubItems[3].Text = LayChuoiNgoaiNgu();
            item.SubItems[4].Text = cboDanToc.SelectedItem != null ? cboDanToc.SelectedItem.ToString() : "Kinh";

            MessageBox.Show("Cập nhật thông tin sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            XoaTrangNhapLieu();
        }

        // Thực hiện xóa sinh viên đang chọn
        private void ThucHienXoa()
        {
            if (lvwSinhVien.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần xóa trong danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult r = MessageBox.Show("Bạn có chắc chắn muốn xóa sinh viên này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                lvwSinhVien.Items.Remove(lvwSinhVien.SelectedItems[0]);
                XoaTrangNhapLieu();
            }
        }

        // Button Xóa
        private void btnXoa_Click(object sender, EventArgs e)
        {
            ThucHienXoa();
        }

        // Xóa bằng chuột phải (ContextMenuStrip)
        private void mnuContextXoa_Click(object sender, EventArgs e)
        {
            ThucHienXoa();
        }

        // Xác nhận trước khi đóng Form
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