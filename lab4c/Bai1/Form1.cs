using System;
using System.Windows.Forms;

namespace ThucHanhLab4c
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DangKySuKien();
        }

        private void DangKySuKien()
        {
            this.Text = "Cộng trừ nhân chia";

            if (this.Controls.Find("txtA", true).Length > 0)
                ((TextBox)this.Controls.Find("txtA", true)[0]).KeyPress += InputNumber_KeyPress;

            if (this.Controls.Find("txtB", true).Length > 0)
                ((TextBox)this.Controls.Find("txtB", true)[0]).KeyPress += InputNumber_KeyPress;

            if (this.Controls.Find("txtKetQua", true).Length > 0)
                ((TextBox)this.Controls.Find("txtKetQua", true)[0]).ReadOnly = true;

            this.FormClosing += Form1_FormClosing;
        }

        #region Mức 2: Chặn ký tự chữ khi gõ phím
        private void InputNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (txt == null) return;

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && txt.Text.Contains("."))
            {
                e.Handled = true;
            }

            if (e.KeyChar == '-' && (txt.SelectionStart != 0 || txt.Text.Contains("-")))
            {
                e.Handled = true;
            }
        }
        #endregion

        #region Mức 1: Kiểm tra tính hợp lệ dữ liệu
        private bool KiemTraDuLieu(out double a, out double b)
        {
            a = 0;
            b = 0;
            bool hopLe = true;

            if (errorProvider1 != null)
                errorProvider1.Clear();

            // Tìm và lấy giá trị của txtA
            Control[] ctrA = this.Controls.Find("txtA", true);
            string valA = ctrA.Length > 0 ? ctrA[0].Text.Trim() : (txtA != null ? txtA.Text.Trim() : "");

            if (string.IsNullOrWhiteSpace(valA) || !double.TryParse(valA, out a))
            {
                if (errorProvider1 != null && ctrA.Length > 0)
                    errorProvider1.SetError(ctrA[0], "Giá trị a phải là số hợp lệ!");
                hopLe = false;
            }

            // Tìm và lấy giá trị của txtB
            Control[] ctrB = this.Controls.Find("txtB", true);
            string valB = ctrB.Length > 0 ? ctrB[0].Text.Trim() : (txtB != null ? txtB.Text.Trim() : "");

            if (string.IsNullOrWhiteSpace(valB) || !double.TryParse(valB, out b))
            {
                if (errorProvider1 != null && ctrB.Length > 0)
                    errorProvider1.SetError(ctrB[0], "Giá trị b phải là số hợp lệ!");
                hopLe = false;
            }

            if (!hopLe)
            {
                MessageBox.Show("Dữ liệu nhập vào chưa đúng định dạng số! Vui lòng kiểm tra lại.",
                                "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return hopLe;
        }

        private void GanKetQua(string ketQua)
        {
            Control[] ctrKQ = this.Controls.Find("txtKetQua", true);
            if (ctrKQ.Length > 0)
                ctrKQ[0].Text = ketQua;
            else if (txtKetQua != null)
                txtKetQua.Text = ketQua;
        }
        #endregion

        #region Các hàm tính toán chính
        private void btnCong_Click(object sender, EventArgs e)
        {
            if (KiemTraDuLieu(out double a, out double b))
            {
                GanKetQua((a + b).ToString());
            }
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            if (KiemTraDuLieu(out double a, out double b))
            {
                GanKetQua((a - b).ToString());
            }
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            if (KiemTraDuLieu(out double a, out double b))
            {
                GanKetQua((a * b).ToString());
            }
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            if (KiemTraDuLieu(out double a, out double b))
            {
                if (b == 0)
                {
                    Control[] ctrB = this.Controls.Find("txtB", true);
                    if (errorProvider1 != null && ctrB.Length > 0)
                        errorProvider1.SetError(ctrB[0], "Không thể chia cho số 0!");

                    MessageBox.Show("Không thể thực hiện phép chia cho 0!", "Lỗi toán học", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    GanKetQua("");
                }
                else
                {
                    GanKetQua((a / b).ToString());
                }
            }
        }
        #endregion

        #region Xác nhận đóng Form
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có thực sự muốn thoát chương trình?",
                                                  "Xác nhận thoát",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        #endregion

        #region Các sự kiện mặc định do Designer tự sinh ra
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void txtA_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtB_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtKetQua_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnCong_Click(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            btnTru_Click(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            btnNhan_Click(sender, e);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            btnChia_Click(sender, e);
        }
        #endregion
    }
}