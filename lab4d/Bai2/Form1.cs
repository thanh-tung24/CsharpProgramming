using System;
using System.Windows.Forms;

namespace Bai2
{
    public partial class Form1 : Form
    {
        private MangSoNguyen mang;

        public Form1()
        {
            InitializeComponent();
        }

        private bool KhoiTaoMang()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txt_NhapMang.Text))
                {
                    MessageBox.Show("Vui lòng nhập mảng số nguyên!");
                    return false;
                }
                mang = new MangSoNguyen(txt_NhapMang.Text.Trim());
                return true;
            }
            catch
            {
                MessageBox.Show("Dữ liệu mảng không hợp lệ (các số cách nhau bởi dấu cách)!");
                return false;
            }
        }

        private void btn_ThucHienSX_Click(object sender, EventArgs e)
        {
            if (!KhoiTaoMang()) return;

            if (rdo_SapXepTang.Checked) mang.SapXepTang();
            else if (rdo_SapXepGiam.Checked) mang.SapXepGiam();

            txt_KetQuaMang.Text = mang.XuatMang();
        }

        private void btn_Tim_Click(object sender, EventArgs e)
        {
            if (!KhoiTaoMang()) return;

            if (rdo_TimGiaTri.Checked)
            {
                if (int.TryParse(txt_TimGiaTri.Text, out int val))
                {
                    int idx = mang.TimViTriTheoGiaTri(val);
                    txt_SoTimDuoc.Text = idx != -1 ? $"Vị trí: {idx}" : "Không tìm thấy";
                }
                else MessageBox.Show("Giá trị cần tìm phải là số nguyên!");
            }
            else
            {
                if (int.TryParse(txt_TimViTri.Text, out int idx))
                {
                    int res = mang.LayGiaTriTheoViTri(idx);
                    txt_SoTimDuoc.Text = res != -1 ? res.ToString() : "Vị trí ngoài biên";
                }
                else MessageBox.Show("Vị trí cần tìm phải là số nguyên!");
            }
        }

        private void btn_ThucHienXoa_Click(object sender, EventArgs e)
        {
            if (!KhoiTaoMang()) return;

            if (rdo_XoaGiaTri.Checked && int.TryParse(txt_XoaGiaTri.Text, out int val))
            {
                mang.XoaTheoGiaTri(val);
            }
            else if (rdo_XoaViTri.Checked && int.TryParse(txt_XoaViTri.Text, out int idx))
            {
                mang.XoaTheoViTri(idx);
            }
            txt_KetQuaMang.Text = mang.XuatMang();
        }

        private void btn_ThucHienThem_Click(object sender, EventArgs e)
        {
            if (!KhoiTaoMang()) return;

            if (int.TryParse(txt_GiaTriThem.Text, out int val) && int.TryParse(txt_ViTriThem.Text, out int idx))
            {
                mang.ThemPhanTu(val, idx);
                txt_KetQuaMang.Text = mang.XuatMang();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ cho giá trị và vị trí thêm!");
            }
        }

        private void btn_Tong_Click(object sender, EventArgs e)
        {
            if (!KhoiTaoMang()) return;
            txt_TongMang.Text = mang.TongMang().ToString();
            txt_TongChan.Text = mang.TongChan().ToString();
            txt_TongLe.Text = mang.TongLe().ToString();
        }

        private void btn_TimMaxMin_Click(object sender, EventArgs e)
        {
            if (!KhoiTaoMang()) return;
            txt_Max.Text = mang.Max().ToString();
            txt_Min.Text = mang.Min().ToString();
        }

        private void btn_ThucHienThayThe_Click(object sender, EventArgs e)
        {
            if (!KhoiTaoMang()) return;

            if (int.TryParse(txt_ThayTheGiaTri.Text, out int cu) && int.TryParse(txt_SoThayTheMoi.Text, out int moi))
            {
                mang.ThayThe(cu, moi);
                txt_KetQuaMang.Text = mang.XuatMang();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đúng số nguyên cần thay thế!");
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            txt_NhapMang.Clear();
            txt_KetQuaMang.Clear();
            txt_TongMang.Clear();
            txt_TongChan.Clear();
            txt_TongLe.Clear();
            txt_Max.Clear();
            txt_Min.Clear();
            txt_TimGiaTri.Clear();
            txt_TimViTri.Clear();
            txt_SoTimDuoc.Clear();
            txt_XoaGiaTri.Clear();
            txt_XoaViTri.Clear();
            txt_GiaTriThem.Clear();
            txt_ViTriThem.Clear();
            txt_ThayTheGiaTri.Clear();
            txt_SoThayTheMoi.Clear();
            txt_NhapMang.Focus();
        }

        private void btn_Thoat_Click(object sender, EventArgs e) => this.Close();

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No) e.Cancel = true;
        }
    }
}