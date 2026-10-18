using System;
using System.Windows.Forms;

namespace Bai5 // Đổi lại theo đúng namespace project của bạn nếu đặt tên khác
{
    public partial class FrmBai5 : Form
    {
        public FrmBai5()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            DangKySuKien();
        }

        private void DangKySuKien()
        {
            this.Text = "Đọc số";

            if (this.Controls.Find("btnDoc", true).Length > 0)
                this.Controls.Find("btnDoc", true)[0].Click += BtnDoc_Click;

            if (this.Controls.Find("btnXoa", true).Length > 0)
                this.Controls.Find("btnXoa", true)[0].Click += BtnXoa_Click;

            if (this.Controls.Find("btnThoat", true).Length > 0)
                this.Controls.Find("btnThoat", true)[0].Click += BtnThoat_Click;

            if (this.Controls.Find("txtSo", true).Length > 0)
            {
                Control txt = this.Controls.Find("txtSo", true)[0];
                txt.KeyPress += TxtSo_KeyPress;
                txt.KeyDown += TxtSo_KeyDown;
            }

            this.FormClosing += FrmBai5_FormClosing;
        }

        #region Xử lý phím nhập số
        private void TxtSo_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Chỉ cho phép nhập chữ số và phím Backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtSo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ThucHienDocSo();
                e.SuppressKeyPress = true;
            }
        }
        #endregion

        #region Thuật toán đọc số từ 1 đến 999
        private string DocSo3ChuSo(int n)
        {
            string[] chuSo = { "không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };

            int tram = n / 100;
            int chuc = (n % 100) / 10;
            int donVi = n % 10;

            string ketQua = "";

            // Xử lý hàng trăm
            if (tram > 0)
            {
                ketQua += chuSo[tram] + " trăm";
            }

            // Xử lý hàng chục
            if (chuc > 1)
            {
                if (tram > 0) ketQua += " ";
                ketQua += chuSo[chuc] + " mươi";
            }
            else if (chuc == 1)
            {
                if (tram > 0) ketQua += " ";
                ketQua += "mười";
            }
            else if (chuc == 0 && tram > 0 && donVi > 0)
            {
                ketQua += " lẻ";
            }

            // Xử lý hàng đơn vị
            if (donVi > 0)
            {
                if (chuc > 0 || tram > 0) ketQua += " ";

                if (donVi == 1 && chuc > 1)
                {
                    ketQua += "mốt";
                }
                else if (donVi == 5 && (chuc > 0 || tram > 0))
                {
                    ketQua += "lăm";
                }
                else
                {
                    ketQua += chuSo[donVi];
                }
            }
            else if (tram == 0 && chuc == 0 && donVi == 0)
            {
                ketQua = "không";
            }

            // Viết hoa chữ cái đầu
            if (ketQua.Length > 0)
            {
                ketQua = char.ToUpper(ketQua[0]) + ketQua.Substring(1);
            }

            return ketQua;
        }
        #endregion

        #region Logic các nút bấm
        private void BtnDoc_Click(object sender, EventArgs e)
        {
            ThucHienDocSo();
        }

        private void ThucHienDocSo()
        {
            Control[] arrSo = this.Controls.Find("txtSo", true);
            Control[] arrKQ = this.Controls.Find("txtKetQua", true);

            string strSo = arrSo.Length > 0 ? arrSo[0].Text.Trim() : "";

            if (!int.TryParse(strSo, out int n) || n < 1 || n > 999)
            {
                MessageBox.Show("Vui lòng nhập số nguyên trong khoảng từ 1 đến 999!",
                                "Lỗi nhập liệu",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                if (arrSo.Length > 0)
                {
                    ((TextBox)arrSo[0]).SelectAll();
                    arrSo[0].Focus();
                }
                return;
            }

            string docChu = DocSo3ChuSo(n);
            if (arrKQ.Length > 0)
            {
                arrKQ[0].Text = docChu;
            }
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            Control[] arrSo = this.Controls.Find("txtSo", true);
            Control[] arrKQ = this.Controls.Find("txtKetQua", true);

            if (arrSo.Length > 0) arrSo[0].Text = "";
            if (arrKQ.Length > 0) arrKQ[0].Text = "";

            if (arrSo.Length > 0)
                arrSo[0].Focus();
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmBai5_FormClosing(object sender, FormClosingEventArgs e)
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

        #region Các hàm tránh lỗi đồng bộ Designer khi nhấp đúp nhầm
        private void FrmBai5_Load(object sender, EventArgs e) { }
        private void button1_Click(object sender, EventArgs e) => BtnDoc_Click(sender, e);
        private void button2_Click(object sender, EventArgs e) => BtnXoa_Click(sender, e);
        private void button3_Click(object sender, EventArgs e) => BtnThoat_Click(sender, e);
        private void txtSo_TextChanged(object sender, EventArgs e) { }
        #endregion
    }
}