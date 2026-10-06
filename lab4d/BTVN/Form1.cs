using System;
using System.Windows.Forms;

namespace BTVN
{
    public partial class Form1 : Form
    {
        private int tongLuotNguoi = 0;
        private double tongTienThuDuoc = 0;
        private double thanhTienHienTai = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KhoiTaoForm();
        }

        private void KhoiTaoForm()
        {
            txt_HoTen.Clear();
            txt_DiaChi.Clear();
            txt_SoNgayO.Clear();

            rdo_Don.Checked = true;
            chk_Tivi.Checked = false;
            chk_Internet.Checked = false;
            chk_NuocNong.Checked = false;
            chk_Karaoke.Checked = false;
            chk_AnSang.Checked = false;

            txt_ThanhTien.Text = "";

            btn_ThanhToan.Enabled = false;
            btn_NhapMoi.Enabled = false;
            btn_TongKet.Enabled = false;

            txt_HoTen.Focus();
        }

        private void txt_SoNgayO_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void DuLieu_ThayDoi(object sender, EventArgs e)
        {
            bool hopLe = !string.IsNullOrWhiteSpace(txt_HoTen.Text) &&
                         !string.IsNullOrWhiteSpace(txt_DiaChi.Text) &&
                         int.TryParse(txt_SoNgayO.Text.Trim(), out int ngay) && ngay > 0;

            btn_ThanhToan.Enabled = hopLe;
        }

        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {
            int soNgay = int.Parse(txt_SoNgayO.Text.Trim());

            double giaPhong = 0;
            if (rdo_Don.Checked) giaPhong = 300000;
            else if (rdo_Doi.Checked) giaPhong = 350000;
            else if (rdo_Ba.Checked) giaPhong = 400000;

            double tienTienNghi = 0;
            if (chk_Tivi.Checked) tienTienNghi += 10000;
            if (chk_Internet.Checked) tienTienNghi += 10000;
            if (chk_NuocNong.Checked) tienTienNghi += 10000;

            double tienDichVu = 0;
            if (chk_Karaoke.Checked) tienDichVu += 50000;
            if (chk_AnSang.Checked) tienDichVu += (15000 * soNgay);

            thanhTienHienTai = (giaPhong * soNgay) + tienTienNghi + tienDichVu;
            txt_ThanhTien.Text = $"{thanhTienHienTai:N0} VND";

            tongLuotNguoi++;
            tongTienThuDuoc += thanhTienHienTai;

            btn_ThanhToan.Enabled = false;
            btn_NhapMoi.Enabled = true;
            btn_TongKet.Enabled = true;
        }

        private void btn_NhapMoi_Click(object sender, EventArgs e)
        {
            KhoiTaoForm();
        }

        private void btn_TongKet_Click(object sender, EventArgs e)
        {
            txt_SoLuotNguoi.Text = tongLuotNguoi.ToString();
            txt_TongTien.Text = $"{tongTienThuDuoc:N0} VND";

            tongLuotNguoi = 0;
            tongTienThuDuoc = 0;
            btn_TongKet.Enabled = false;
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