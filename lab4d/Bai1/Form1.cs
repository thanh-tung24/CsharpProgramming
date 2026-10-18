using Bai1;
using System;
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
            rdo_BacNhat.Checked = true;
            CapNhatTrangThai();
        }

        private void rdo_BacNhat_CheckedChanged(object sender, EventArgs e)
        {
            lbl_c.Visible = !rdo_BacNhat.Checked;
            txt_c.Visible = !rdo_BacNhat.Checked;
            txt_c.Text = "";
            KiemTraDuLieuNhap();
        }

        private void rdo_BacHai_CheckedChanged(object sender, EventArgs e)
        {
            lbl_c.Visible = rdo_BacHai.Checked;
            txt_c.Visible = rdo_BacHai.Checked;
            KiemTraDuLieuNhap();
        }

        private void txt_TextChanged(object sender, EventArgs e)
        {
            KiemTraDuLieuNhap();
        }

        private void KiemTraDuLieuNhap()
        {
            bool hopLe = double.TryParse(txt_a.Text.Trim(), out _) &&
                         double.TryParse(txt_b.Text.Trim(), out _);

            if (rdo_BacHai.Checked)
            {
                hopLe = hopLe && double.TryParse(txt_c.Text.Trim(), out _);
            }

            btn_Giai.Enabled = hopLe;
        }

        private void btn_Giai_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txt_a.Text.Trim());
            double b = double.Parse(txt_b.Text.Trim());
            double c = rdo_BacHai.Checked ? double.Parse(txt_c.Text.Trim()) : 0;

            PhuongTrinhBacHai pt = new PhuongTrinhBacHai(a, b, c);
            txt_KetQua.Text = rdo_BacNhat.Checked ? pt.GiaiBacNhat() : pt.GiaiBacHai();
            btn_Giai.Enabled = false;
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No) e.Cancel = true;
        }

        private void CapNhatTrangThai()
        {
            btn_Giai.Enabled = false;
            lbl_c.Visible = false;
            txt_c.Visible = false;
        }
    }
}