using System;
using System.Windows.Forms;

namespace Bai3 // Nếu project của bạn có namespace khác (ví dụ ThucHanhLab4c) thì đổi lại cho trùng khớp
{
    public partial class FrmBai3 : Form
    {
        public FrmBai3()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            DangKySuKien();
        }

        private void DangKySuKien()
        {
            // Tự động gán sự kiện cho các điều khiển nếu có
            if (this.Controls.Find("btnThucHien", true).Length > 0)
                this.Controls.Find("btnThucHien", true)[0].Click += BtnThucHien_Click;

            if (this.Controls.Find("btnTiepTuc", true).Length > 0)
                this.Controls.Find("btnTiepTuc", true)[0].Click += BtnTiepTuc_Click;

            if (this.Controls.Find("btnThoat", true).Length > 0)
                this.Controls.Find("btnThoat", true)[0].Click += BtnThoat_Click;

            // Chặn ký tự không phải số ở 2 ô nhập liệu
            if (this.Controls.Find("txtA", true).Length > 0)
                ((TextBox)this.Controls.Find("txtA", true)[0]).KeyPress += ChiNhapSo_KeyPress;

            if (this.Controls.Find("txtB", true).Length > 0)
                ((TextBox)this.Controls.Find("txtB", true)[0]).KeyPress += ChiNhapSo_KeyPress;

            this.FormClosing += FrmBai3_FormClosing;
        }

        #region Chặn ký tự chữ khi gõ
        private void ChiNhapSo_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Chỉ cho nhập chữ số và phím điều khiển (Backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        #endregion

        #region Thuật toán Euclid tính UCLN và BCNN
        private long TimUCLN(long a, long b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            while (b != 0)
            {
                long temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        private long TimBCNN(long a, long b, long ucln)
        {
            if (ucln == 0) return 0;
            return Math.Abs(a * b) / ucln;
        }
        #endregion

        #region Kiểm tra dữ liệu đầu vào
        private bool KiemTraHopLe(out long a, out long b)
        {
            a = 0;
            b = 0;
            bool hopLe = true;

            if (errorProvider1 != null)
                errorProvider1.Clear();

            Control[] arrA = this.Controls.Find("txtA", true);
            Control[] arrB = this.Controls.Find("txtB", true);

            string strA = arrA.Length > 0 ? arrA[0].Text.Trim() : "";
            string strB = arrB.Length > 0 ? arrB[0].Text.Trim() : "";

            // Kiểm tra a
            if (string.IsNullOrWhiteSpace(strA) || !long.TryParse(strA, out a) || a <= 0)
            {
                if (errorProvider1 != null && arrA.Length > 0)
                    errorProvider1.SetError(arrA[0], "Vui lòng nhập số nguyên dương!");
                hopLe = false;
            }

            // Kiểm tra b
            if (string.IsNullOrWhiteSpace(strB) || !long.TryParse(strB, out b) || b <= 0)
            {
                if (errorProvider1 != null && arrB.Length > 0)
                    errorProvider1.SetError(arrB[0], "Vui lòng nhập số nguyên dương!");
                hopLe = false;
            }

            if (!hopLe)
            {
                MessageBox.Show("Dữ liệu nhập vào phải là các số nguyên dương lớn hơn 0!",
                                "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return hopLe;
        }
        #endregion

        #region Xử lý các nút chức năng
        // Nút Thực hiện tính toán
        private void BtnThucHien_Click(object sender, EventArgs e)
        {
            if (KiemTraHopLe(out long a, out long b))
            {
                long ucln = TimUCLN(a, b);
                long bcnn = TimBCNN(a, b, ucln);

                Control[] arrUCLN = this.Controls.Find("txtUCLN", true);
                Control[] arrBCNN = this.Controls.Find("txtBCNN", true);

                if (arrUCLN.Length > 0) arrUCLN[0].Text = ucln.ToString();
                if (arrBCNN.Length > 0) arrBCNN[0].Text = bcnn.ToString();
            }
        }

        // Nút Tiếp tục (Xóa trắng để tính lượt mới)
        private void BtnTiepTuc_Click(object sender, EventArgs e)
        {
            Control[] arrA = this.Controls.Find("txtA", true);
            Control[] arrB = this.Controls.Find("txtB", true);
            Control[] arrUCLN = this.Controls.Find("txtUCLN", true);
            Control[] arrBCNN = this.Controls.Find("txtBCNN", true);

            if (arrA.Length > 0) arrA[0].Text = "";
            if (arrB.Length > 0) arrB[0].Text = "";
            if (arrUCLN.Length > 0) arrUCLN[0].Text = "";
            if (arrBCNN.Length > 0) arrBCNN[0].Text = "";

            if (errorProvider1 != null)
                errorProvider1.Clear();

            // Đưa con trỏ nhấp nháy về lại ô a
            if (arrA.Length > 0)
                arrA[0].Focus();
        }

        // Nút Thoát
        private void BtnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Xác nhận khi đóng Form
        private void FrmBai3_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn thoát khỏi chương trình?",
                                             "Xác nhận",
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);
            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        #endregion

        #region Các hàm dự phòng trường hợp vô tình double-click vào control
        private void button1_Click(object sender, EventArgs e) => BtnThucHien_Click(sender, e);
        private void button2_Click(object sender, EventArgs e) => BtnTiepTuc_Click(sender, e);
        private void button3_Click(object sender, EventArgs e) => BtnThoat_Click(sender, e);
        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        #endregion
    }
}