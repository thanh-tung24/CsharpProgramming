using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BaiNangCao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Nạp học viên mẫu ban đầu theo hình tài liệu
            lstLopA.Items.Add("Trần Hùng"); //[cite: 32]
            lstLopA.Items.Add("Nguyễn Hưng"); //[cite: 32]
            lstLopA.Items.Add("Lâm Tử"); //[cite: 32]

            lstLopB.Items.Add("Tuấn Hưng"); //[cite: 32]
            lstLopB.Items.Add("Hồng Ngọc"); //[cite: 32]
            lstLopB.Items.Add("Anh Minh"); //[cite: 32]
            lstLopB.Items.Add("Bảo Lâm"); //[cite: 32]
        }

        // 1. Nhập học viên mới: mở Form con frmNhapHocVien
        private void mnuNhapHocVienMoi_Click(object sender, EventArgs e)
        {
            using (frmNhapHocVien frm = new frmNhapHocVien()) //[cite: 33]
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    if (frm.LopDuocChon == "Lớp A") //[cite: 33]
                    {
                        lstLopA.Items.Add(frm.HoTenHocVien); //[cite: 33]
                    }
                    else
                    {
                        lstLopB.Items.Add(frm.HoTenHocVien); //[cite: 33]
                    }
                }
            }
        }

        // 2. Chuyển các mục đang chọn từ Lớp A sang Lớp B
        private void mnuChuyenSangLopB_Click(object sender, EventArgs e)
        {
            if (lstLopA.SelectedIndices.Count == 0) //[cite: 33]
            {
                MessageBox.Show("Vui lòng chọn học viên ở Lớp A cần chuyển!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); //[cite: 33]
                return;
            }

            // Gom các phần tử được chọn
            List<object> dsChon = new List<object>();
            foreach (var item in lstLopA.SelectedItems)
            {
                dsChon.Add(item);
            }

            // Chuyển sang Lớp B và xóa ở Lớp A
            foreach (var item in dsChon)
            {
                lstLopB.Items.Add(item);
                lstLopA.Items.Remove(item);
            }
        }

        // 3. Chuyển các mục đang chọn từ Lớp B sang Lớp A
        private void mnuChuyenSangLopA_Click(object sender, EventArgs e)
        {
            if (lstLopB.SelectedIndices.Count == 0) //[cite: 33]
            {
                MessageBox.Show("Vui lòng chọn học viên ở Lớp B cần chuyển!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); //[cite: 33]
                return;
            }

            // Gom các phần tử được chọn
            List<object> dsChon = new List<object>();
            foreach (var item in lstLopB.SelectedItems)
            {
                dsChon.Add(item);
            }

            // Chuyển sang Lớp A và xóa ở Lớp B
            foreach (var item in dsChon)
            {
                lstLopA.Items.Add(item);
                lstLopB.Items.Remove(item);
            }
        }

        // 4. Xóa học viên đang chọn trong cả Lớp A và Lớp B
        private void mnuXoaHocVien_Click(object sender, EventArgs e)
        {
            if (lstLopA.SelectedIndices.Count == 0 && lstLopB.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một học viên để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult r = MessageBox.Show("Bạn có chắc chắn muốn xóa các học viên đang chọn?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                // Xóa ở Lớp A từ cuối danh sách lên
                for (int i = lstLopA.SelectedIndices.Count - 1; i >= 0; i--) //[cite: 33]
                {
                    lstLopA.Items.RemoveAt(lstLopA.SelectedIndices[i]); //[cite: 33]
                }

                // Xóa ở Lớp B từ cuối danh sách lên
                for (int i = lstLopB.SelectedIndices.Count - 1; i >= 0; i--) //[cite: 33]
                {
                    lstLopB.Items.RemoveAt(lstLopB.SelectedIndices[i]); //[cite: 33]
                }
            }
        }

        // 5. Kết thúc chương trình có hỏi xác nhận
        private void mnuKetThuc_Click(object sender, EventArgs e)
        {
            this.Close(); //[cite: 32]
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có chắc chắn muốn dừng chương trình?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question); //[cite: 32]
            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}