using System;
using System.Drawing;
using System.Windows.Forms;

namespace BTVNBai1
{
    public partial class Form1 : Form
    {
        private int tongGiay = 60;

        public Form1()
        {
            InitializeComponent();
        }

        // Chặn nhập ký tự không phải số nguyên dương
        private void txtNhapGiay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // Định dạng thời gian theo format HH:mm:ss
        private void CapNhatHienThi(int soGiay)
        {
            TimeSpan time = TimeSpan.FromSeconds(soGiay);
            lblDongHo.Text = time.ToString(@"hh\:mm\:ss");
        }

        // Bắt đầu đếm ngược
        private void btnBatDau_Click(object sender, EventArgs e)
        {
            if (!timerDemNguoc.Enabled)
            {
                if (int.TryParse(txtNhapGiay.Text.Trim(), out int giayNhap) && giayNhap > 0)
                {
                    if (tongGiay <= 0)
                    {
                        tongGiay = giayNhap;
                    }
                    CapNhatHienThi(tongGiay);
                    timerDemNguoc.Start();

                    btnBatDau.Enabled = false;
                    btnTamDung.Enabled = true;
                    txtNhapGiay.ReadOnly = true;
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập số giây hợp lệ lớn hơn 0!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNhapGiay.Focus();
                }
            }
        }

        // Tạm dừng đếm
        private void btnTamDung_Click(object sender, EventArgs e)
        {
            timerDemNguoc.Stop();
            btnBatDau.Enabled = true;
            btnTamDung.Enabled = false;
        }

        // Đặt lại thời gian ban đầu
        private void btnDatLai_Click(object sender, EventArgs e)
        {
            timerDemNguoc.Stop();
            if (int.TryParse(txtNhapGiay.Text.Trim(), out int giayNhap) && giayNhap > 0)
            {
                tongGiay = giayNhap;
            }
            else
            {
                tongGiay = 60;
                txtNhapGiay.Text = "60";
            }

            CapNhatHienThi(tongGiay);
            lblDongHo.ForeColor = Color.Red;
            btnBatDau.Enabled = true;
            btnTamDung.Enabled = false;
            txtNhapGiay.ReadOnly = false;
        }

        // Sự kiện Tick của Timer chạy mỗi 1 giây (1000ms)
        private void timerDemNguoc_Tick(object sender, EventArgs e)
        {
            if (tongGiay > 0)
            {
                tongGiay--;
                CapNhatHienThi(tongGiay);
            }
            else
            {
                timerDemNguoc.Stop();
                btnBatDau.Enabled = true;
                btnTamDung.Enabled = false;
                txtNhapGiay.ReadOnly = false;
                MessageBox.Show("Hết giờ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Xác nhận khi thoát
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            timerDemNguoc.Stop();
        }
    }
}