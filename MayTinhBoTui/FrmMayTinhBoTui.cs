using System;
using System.Drawing;
using System.Windows.Forms;

namespace MayTinhBoTui
{
    public partial class FrmMayTinhBoTui : Form
    {
        // Biến lưu trữ giá trị và phép toán
        private double giaTriThuNhat = 0;
        private string phepToanHienTai = "";
        private bool dangNhapSoMoi = true;

        public FrmMayTinhBoTui()
        {
            InitializeComponent(); // Nạp giao diện từ Designer
            this.StartPosition = FormStartPosition.CenterScreen;
            KhoiTaoSuKienMayTinh();
        }

        private void KhoiTaoSuKienMayTinh()
        {
            this.Text = "Máy Tính Bỏ Túi";

            // Đặt giá trị ban đầu cho ô hiển thị
            Control[] arrHienThi = this.Controls.Find("txtHienThi", true);
            if (arrHienThi.Length > 0)
            {
                arrHienThi[0].Text = "0";
            }

            // Tự động gán sự kiện cho các Button theo chữ hiển thị trên nút
            GánSuKienChoCacNut(this);
        }

        private void GánSuKienChoCacNut(Control parent)
        {
            foreach (Control ctr in parent.Controls)
            {
                if (ctr is Button btn)
                {
                    string txt = btn.Text.Trim();

                    // Các nút số từ 0 đến 9
                    if (txt.Length == 1 && char.IsDigit(txt[0]))
                    {
                        btn.Click += NutSo_Click;
                    }
                    // Các nút phép tính cơ bản
                    else if (txt == "+" || txt == "-" || txt == "*" || txt == "/")
                    {
                        btn.Click += NutPhepToan_Click;
                    }
                    // Nút Dấu bằng
                    else if (txt == "=")
                    {
                        btn.Click += NutBang_Click;
                    }
                    // Nút Xóa C
                    else if (txt.ToUpper() == "C")
                    {
                        btn.Click += NutXoaC_Click;
                    }
                }
                else if (ctr.HasChildren)
                {
                    GánSuKienChoCacNut(ctr);
                }
            }
        }

        private TextBox LayManHinh()
        {
            Control[] arr = this.Controls.Find("txtHienThi", true);
            if (arr.Length > 0 && arr[0] is TextBox txt)
                return txt;

            foreach (Control c in this.Controls)
            {
                if (c is TextBox t) return t;
            }
            return null;
        }

        #region Xử lý click phím số (0 - 9)
        private void NutSo_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            TextBox manHinh = LayManHinh();
            if (btn == null || manHinh == null) return;

            string chuSo = btn.Text.Trim();

            if (dangNhapSoMoi || manHinh.Text == "0" || manHinh.Text == "Lỗi")
            {
                manHinh.Text = chuSo;
                dangNhapSoMoi = false;
            }
            else
            {
                if (manHinh.Text.Length < 14)
                {
                    manHinh.Text += chuSo;
                }
            }
        }
        #endregion

        #region Xử lý phép tính (+, -, *, /)
        private void NutPhepToan_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            TextBox manHinh = LayManHinh();
            if (btn == null || manHinh == null) return;

            if (!dangNhapSoMoi && !string.IsNullOrEmpty(phepToanHienTai))
            {
                ThucHienTinhToan();
            }

            if (double.TryParse(manHinh.Text, out double so))
            {
                giaTriThuNhat = so;
            }

            phepToanHienTai = btn.Text.Trim();
            dangNhapSoMoi = true;
        }
        #endregion

        #region Xử lý nút Bằng (=)
        private void NutBang_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(phepToanHienTai))
            {
                ThucHienTinhToan();
                phepToanHienTai = "";
            }
        }

        private void ThucHienTinhToan()
        {
            TextBox manHinh = LayManHinh();
            if (manHinh == null) return;

            if (!double.TryParse(manHinh.Text, out double giaTriThuHai))
                return;

            double ketQua = 0;

            switch (phepToanHienTai)
            {
                case "+":
                    ketQua = giaTriThuNhat + giaTriThuHai;
                    break;
                case "-":
                    ketQua = giaTriThuNhat - giaTriThuHai;
                    break;
                case "*":
                    ketQua = giaTriThuNhat * giaTriThuHai;
                    break;
                case "/":
                    if (giaTriThuHai == 0)
                    {
                        manHinh.Text = "Lỗi";
                        dangNhapSoMoi = true;
                        MessageBox.Show("Không thể chia cho số 0!", "Lỗi toán học", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    ketQua = giaTriThuNhat / giaTriThuHai;
                    break;
                default:
                    return;
            }

            manHinh.Text = ketQua.ToString("G10");
            giaTriThuNhat = ketQua;
            dangNhapSoMoi = true;
        }
        #endregion

        #region Xử lý nút Xóa (C)
        private void NutXoaC_Click(object sender, EventArgs e)
        {
            TextBox manHinh = LayManHinh();
            if (manHinh != null)
            {
                manHinh.Text = "0";
            }
            giaTriThuNhat = 0;
            phepToanHienTai = "";
            dangNhapSoMoi = true;
        }
        #endregion

        #region Các hàm tránh lỗi Designer
        private void FrmMayTinhBoTui_Load(object sender, EventArgs e) { }
        private void btn2_Click(object sender, EventArgs e) { }
        private void txtHienThi_TextChanged(object sender, EventArgs e) { }
        #endregion
    }
}