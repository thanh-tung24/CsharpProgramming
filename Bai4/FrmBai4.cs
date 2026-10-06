using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace Bai4
{
    public partial class FrmBai4 : Form
    {
        // Khai báo quản lý giải phóng bộ nhớ để tránh lỗi Dispose/components ở Designer
        private IContainer components = null;

        // Quản lý hiển thị thông báo lỗi
        private ErrorProvider errorProvider1 = new ErrorProvider();

        // Danh sách lưu trữ động các số đã nhập
        private List<int> danhSachSo = new List<int>();

        public FrmBai4()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            DangKySuKien();
        }

        private void DangKySuKien()
        {
            this.Text = "Thao tác trên dãy số";

            // Gán sự kiện click cho các nút bấm
            if (this.Controls.Find("btnNhap", true).Length > 0)
                this.Controls.Find("btnNhap", true)[0].Click += BtnNhap_Click;

            if (this.Controls.Find("btnTiepTuc", true).Length > 0)
                this.Controls.Find("btnTiepTuc", true)[0].Click += BtnTiepTuc_Click;

            if (this.Controls.Find("btnThoat", true).Length > 0)
                this.Controls.Find("btnThoat", true)[0].Click += BtnThoat_Click;

            // Xử lý sự kiện gõ phím tại ô nhập số
            if (this.Controls.Find("txtNhapSo", true).Length > 0)
            {
                Control txt = this.Controls.Find("txtNhapSo", true)[0];
                txt.KeyPress += TxtNhapSo_KeyPress;
                txt.KeyDown += TxtNhapSo_KeyDown;
            }

            this.FormClosing += FrmBai4_FormClosing;
        }

        #region Xử lý phím gõ ô Nhập số
        private void TxtNhapSo_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (txt == null) return;

            // Chỉ cho nhập chữ số, dấu '-' và phím điều khiển (Backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            // Dấu trừ chỉ được phép ở vị trí đầu tiên
            if (e.KeyChar == '-' && (txt.SelectionStart != 0 || txt.Text.Contains("-")))
            {
                e.Handled = true;
            }
        }

        private void TxtNhapSo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ThucHienNhapSo();
                e.SuppressKeyPress = true; // Chặn tiếng 'ding' của Windows
            }
        }
        #endregion

        #region Logic nhập số và tính toán dãy số
        private void BtnNhap_Click(object sender, EventArgs e)
        {
            ThucHienNhapSo();
        }

        private void ThucHienNhapSo()
        {
            if (errorProvider1 != null)
                errorProvider1.Clear();

            Control[] arrNhap = this.Controls.Find("txtNhapSo", true);
            string valNhap = arrNhap.Length > 0 ? arrNhap[0].Text.Trim() : "";

            if (string.IsNullOrWhiteSpace(valNhap) || !int.TryParse(valNhap, out int soMoi))
            {
                if (errorProvider1 != null && arrNhap.Length > 0)
                    errorProvider1.SetError(arrNhap[0], "Vui lòng nhập một số nguyên hợp lệ!");
                return;
            }

            // Thêm số vào danh sách
            danhSachSo.Add(soMoi);

            // Cập nhật kết quả lên các ô giao diện
            CapNhatKetQua();

            // Xóa trắng ô nhập và focus lại để nhập số tiếp theo
            if (arrNhap.Length > 0)
            {
                arrNhap[0].Text = "";
                arrNhap[0].Focus();
            }
        }

        private void CapNhatKetQua()
        {
            // 1. Hiển thị dãy số
            Control[] arrDaySo = this.Controls.Find("txtDaySo", true);
            if (arrDaySo.Length > 0)
                arrDaySo[0].Text = string.Join("   ", danhSachSo);

            // 2. Tổng dãy số
            long tongDay = danhSachSo.Sum(x => (long)x);
            Control[] arrTongDay = this.Controls.Find("txtTongDaySo", true);
            if (arrTongDay.Length > 0)
                arrTongDay[0].Text = tongDay.ToString();

            // 3. Tổng số chẵn
            long tongChan = danhSachSo.Where(x => x % 2 == 0).Sum(x => (long)x);
            Control[] arrTongChan = this.Controls.Find("txtTongChan", true);
            if (arrTongChan.Length > 0)
                arrTongChan[0].Text = tongChan.ToString();

            // 4. Tổng số lẻ
            long tongLe = danhSachSo.Where(x => x % 2 != 0).Sum(x => (long)x);
            Control[] arrTongLe = this.Controls.Find("txtTongLe", true);
            if (arrTongLe.Length > 0)
                arrTongLe[0].Text = tongLe.ToString();
        }
        #endregion

        #region Các nút Tiếp tục và Thoát
        private void BtnTiepTuc_Click(object sender, EventArgs e)
        {
            danhSachSo.Clear();

            string[] dsTenControl = { "txtNhapSo", "txtDaySo", "txtTongDaySo", "txtTongChan", "txtTongLe" };
            foreach (var ten in dsTenControl)
            {
                Control[] arr = this.Controls.Find(ten, true);
                if (arr.Length > 0) arr[0].Text = "";
            }

            if (errorProvider1 != null)
                errorProvider1.Clear();

            Control[] arrNhap = this.Controls.Find("txtNhapSo", true);
            if (arrNhap.Length > 0)
                arrNhap[0].Focus();
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmBai4_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn thoát chương trình?",
                                             "Xác nhận",
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);
            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        #endregion

        #region Các hàm dự phòng trường hợp nhấp đúp nhầm vào Designer
        private void button1_Click(object sender, EventArgs e) => BtnNhap_Click(sender, e);
        private void button2_Click(object sender, EventArgs e) => BtnTiepTuc_Click(sender, e);
        private void button3_Click(object sender, EventArgs e) => BtnThoat_Click(sender, e);
        private void txtNhapSo_TextChanged(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }
        #endregion
    }
}