using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Bai2
{
    public partial class FrmBai2 : Form
    {
        public FrmBai2()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            DangKySuKien();
        }

        private void DangKySuKien()
        {
            this.Text = "Đăng ký tài khoản";

            if (this.Controls.Find("txtEmail", true).Length > 0)
                this.Controls.Find("txtEmail", true)[0].Leave += TxtEmail_Leave;

            if (this.Controls.Find("txtXacNhanMatKhau", true).Length > 0)
                this.Controls.Find("txtXacNhanMatKhau", true)[0].KeyDown += TxtXacNhanMatKhau_KeyDown;

            if (this.Controls.Find("btnDangKy", true).Length > 0)
                this.Controls.Find("btnDangKy", true)[0].Click += BtnDangKy_Click;

            this.FormClosing += FrmBai2_FormClosing;
        }

        private void TxtEmail_Leave(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (txt == null) return;

            string emailPattern = @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$";
            if (!string.IsNullOrWhiteSpace(txt.Text) && !Regex.IsMatch(txt.Text.Trim(), emailPattern))
            {
                if (errorProvider1 != null)
                    errorProvider1.SetError(txt, "Địa chỉ email không đúng định dạng!");
            }
            else
            {
                if (errorProvider1 != null)
                    errorProvider1.SetError(txt, string.Empty);
            }
        }

        private void TxtXacNhanMatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ThucHienDangKy();
                e.SuppressKeyPress = true;
            }
        }

        private void BtnDangKy_Click(object sender, EventArgs e)
        {
            ThucHienDangKy();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThucHienDangKy();
        }

        private void ThucHienDangKy()
        {
            if (errorProvider1 != null)
                errorProvider1.Clear();

            bool coLoi = false;

            Control[] arrTen = this.Controls.Find("txtTenDangNhap", true);
            Control[] arrEmail = this.Controls.Find("txtEmail", true);
            Control[] arrMatKhau = this.Controls.Find("txtMatKhau", true);
            Control[] arrXacNhan = this.Controls.Find("txtXacNhanMatKhau", true);

            string tenDangNhap = arrTen.Length > 0 ? arrTen[0].Text.Trim() : "";
            string email = arrEmail.Length > 0 ? arrEmail[0].Text.Trim() : "";
            string matKhau = arrMatKhau.Length > 0 ? arrMatKhau[0].Text : "";
            string xacNhanMK = arrXacNhan.Length > 0 ? arrXacNhan[0].Text : "";

            if (string.IsNullOrWhiteSpace(tenDangNhap))
            {
                if (errorProvider1 != null && arrTen.Length > 0)
                    errorProvider1.SetError(arrTen[0], "Tên đăng nhập không được để trống!");
                coLoi = true;
            }

            string emailPattern = @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$";
            if (string.IsNullOrWhiteSpace(email))
            {
                if (errorProvider1 != null && arrEmail.Length > 0)
                    errorProvider1.SetError(arrEmail[0], "Email không được để trống!");
                coLoi = true;
            }
            else if (!Regex.IsMatch(email, emailPattern))
            {
                if (errorProvider1 != null && arrEmail.Length > 0)
                    errorProvider1.SetError(arrEmail[0], "Email không đúng định dạng!");
                coLoi = true;
            }

            if (string.IsNullOrEmpty(matKhau))
            {
                if (errorProvider1 != null && arrMatKhau.Length > 0)
                    errorProvider1.SetError(arrMatKhau[0], "Mật khẩu không được để trống!");
                coLoi = true;
            }

            if (string.IsNullOrEmpty(xacNhanMK))
            {
                if (errorProvider1 != null && arrXacNhan.Length > 0)
                    errorProvider1.SetError(arrXacNhan[0], "Vui lòng xác nhận mật khẩu!");
                coLoi = true;
            }
            else if (matKhau != xacNhanMK)
            {
                if (errorProvider1 != null && arrXacNhan.Length > 0)
                    errorProvider1.SetError(arrXacNhan[0], "Mật khẩu xác nhận không khớp!");
                coLoi = true;
            }

            if (coLoi)
            {
                MessageBox.Show("Vui lòng hoàn thành chính xác các thông tin có dấu (*)",
                                "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string thongTin = $"ĐĂNG KÝ THÀNH CÔNG!\n\n" +
                                  $"- Tên đăng nhập: {tenDangNhap}\n" +
                                  $"- Email: {email}\n" +
                                  $"- Mật khẩu: {matKhau}";

                MessageBox.Show(thongTin, "Thông tin tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FrmBai2_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn đóng form đăng ký?",
                                             "Xác nhận",
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);
            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnDangKy_Click_1(object sender, EventArgs e)
        {

        }
    }
}