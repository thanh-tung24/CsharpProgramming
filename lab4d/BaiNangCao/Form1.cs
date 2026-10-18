using System;
using System.Windows.Forms;

namespace BaiNangCao
{
    public partial class Form1 : Form
    {
        private int tongSoKhachHang = 0;
        private double tongTienDoanhThu = 0;
        private double tienHienTai = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KhoiTaoBanDau();
        }

        private void KhoiTaoBanDau()
        {
            txt_TenKhach.Clear();
            txt_SoKhach.Clear();
            chk_SinhVien.Checked = false;

            rdo_CafeDen.Checked = false;
            rdo_CafeDa.Checked = false;
            rdo_CafeSua.Checked = false;
            rdo_CafeSuaDa.Checked = false;
            rdo_CafeKem.Checked = false;

            chk_BanhMyTrung.Checked = false;
            chk_BanhMyCa.Checked = false;
            chk_MyTomTrung.Checked = false;
            chk_MyXaoBo.Checked = false;
            chk_MyCay.Checked = false;

            btn_TinhTien.Enabled = false;
            btn_NhapLai.Enabled = false;
            btn_ThanhToan.Enabled = false;

            txt_TenKhach.Focus();
        }

        private void txt_SoKhach_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void DuLieu_ThayDoi(object sender, EventArgs e)
        {
            bool coNuoc = rdo_CafeDen.Checked || rdo_CafeDa.Checked || rdo_CafeSua.Checked || rdo_CafeSuaDa.Checked || rdo_CafeKem.Checked;
            bool hopLe = !string.IsNullOrWhiteSpace(txt_TenKhach.Text) &&
                         int.TryParse(txt_SoKhach.Text.Trim(), out int sl) && sl > 0 &&
                         coNuoc;

            btn_TinhTien.Enabled = hopLe;
        }

        private void btn_TinhTien_Click(object sender, EventArgs e)
        {
            double tienNuoc = 0;
            if (rdo_CafeDen.Checked) tienNuoc = 20000;
            else if (rdo_CafeDa.Checked) tienNuoc = 25000;
            else if (rdo_CafeSua.Checked) tienNuoc = 25000;
            else if (rdo_CafeSuaDa.Checked) tienNuoc = 30000;
            else if (rdo_CafeKem.Checked) tienNuoc = 35000;

            double tienThucAn = 0;
            if (chk_BanhMyTrung.Checked) tienThucAn += 15000;
            if (chk_BanhMyCa.Checked) tienThucAn += 15000;
            if (chk_MyTomTrung.Checked) tienThucAn += 20000;
            if (chk_MyXaoBo.Checked) tienThucAn += 30000;
            if (chk_MyCay.Checked) tienThucAn += 50000;

            int soLuongKhach = int.Parse(txt_SoKhach.Text.Trim());
            tienHienTai = (tienNuoc + tienThucAn) * soLuongKhach;

            if (chk_SinhVien.Checked)
            {
                tienHienTai *= 0.8; // Giảm giá 20% cho sinh viên
            }

            MessageBox.Show($"Khách hàng: {txt_TenKhach.Text}\nSố tiền cần trả: {tienHienTai:N0} VNĐ", "Hóa đơn thanh toán");

            btn_NhapLai.Enabled = true;
            btn_ThanhToan.Enabled = true;
            btn_TinhTien.Enabled = false;
        }

        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {
            tongSoKhachHang += int.Parse(txt_SoKhach.Text.Trim());
            tongTienDoanhThu += tienHienTai;

            txt_TongKhach.Text = tongSoKhachHang.ToString();
            txt_TongTien.Text = $"{tongTienDoanhThu:N0} VNĐ";

            btn_ThanhToan.Enabled = false;
            KhoiTaoBanDau();
        }

        private void btn_NhapLai_Click(object sender, EventArgs e)
        {
            KhoiTaoBanDau();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có chắc chắn muốn thoát khỏi chương trình?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No) e.Cancel = true;
        }
    }
}