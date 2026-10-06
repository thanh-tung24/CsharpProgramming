using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Bai1NangCao
{
    public partial class FrmBai1NangCao : Form
    {
        // Danh sách chứa 15 nút ghế
        private List<Button> danhSachGhe = new List<Button>();

        // Hàm tạo (Constructor)
        public FrmBai1NangCao()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            KhoiTaoDuLieuVaSuKien();
        }

        private void KhoiTaoDuLieuVaSuKien()
        {
            this.Text = "BÁN VÉ RẠP CHIẾU BÓNG";

            // Tìm và đưa tất cả 15 nút ghế vào danh sách
            for (int i = 1; i <= 15; i++)
            {
                Control[] arr = this.Controls.Find("btnGhe" + i, true);
                if (arr.Length == 0)
                    arr = this.Controls.Find("btn" + i, true); // dự phòng tên btn1, btn2,...

                if (arr.Length > 0 && arr[0] is Button btn)
                {
                    btn.BackColor = Color.White;
                    btn.ForeColor = Color.Black;
                    btn.Tag = i; // Lưu số thứ tự ghế vào Tag
                    btn.Click += Ghe_Click;
                    danhSachGhe.Add(btn);
                }
            }

            // Gán sự kiện cho 3 nút chức năng
            GanSuKien("btnChon", BtnChon_Click);
            GanSuKien("btnHuyBo", BtnHuyBo_Click);
            GanSuKien("btnKetThuc", BtnKetThuc_Click);

            this.FormClosing += FrmBanVe_FormClosing;
        }

        private void GanSuKien(string tenControl, EventHandler ev)
        {
            Control[] arr = this.Controls.Find(tenControl, true);
            if (arr.Length > 0)
                arr[0].Click += ev;
        }

        #region Xử lý click chọn ghế
        private void Ghe_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn == null) return;

            // Nếu ghế đã bán (màu vàng)
            if (btn.BackColor == Color.Yellow)
            {
                MessageBox.Show($"Ghế số {btn.Text} đã được bán! Vui lòng chọn ghế khác.",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            // Nếu ghế chưa bán (màu trắng) -> chuyển sang Đang chọn (màu xanh)
            if (btn.BackColor == Color.White)
            {
                btn.BackColor = Color.Blue;
                btn.ForeColor = Color.White;
            }
            // Nếu ghế đang chọn (màu xanh) -> nhấp lại để Hủy chọn (về màu trắng)
            else if (btn.BackColor == Color.Blue)
            {
                btn.BackColor = Color.White;
                btn.ForeColor = Color.Black;
            }
        }
        #endregion

        #region Tính tiền theo lô ghế
        private int LayGiaVe(int soGhe)
        {
            if (soGhe >= 1 && soGhe <= 5)
                return 1000; // Lô A: 1000 đ/vé
            if (soGhe >= 6 && soGhe <= 10)
                return 1500; // Lô B: 1500 đ/vé
            if (soGhe >= 11 && soGhe <= 15)
                return 2000; // Lô C: 2000 đ/vé

            return 0;
        }
        #endregion

        #region Các nút Chức năng: Chọn, Hủy bỏ, Kết thúc
        // Nút CHỌN
        private void BtnChon_Click(object sender, EventArgs e)
        {
            int tongTien = 0;
            int soGheDangChon = 0;

            foreach (Button btn in danhSachGhe)
            {
                // Kiểm tra các ghế đang được chọn (màu xanh)
                if (btn.BackColor == Color.Blue)
                {
                    int soGhe = (int)btn.Tag;
                    tongTien += LayGiaVe(soGhe);
                    soGheDangChon++;

                    // Chuyển sang trạng thái Đã bán (màu vàng)
                    btn.BackColor = Color.Yellow;
                    btn.ForeColor = Color.Black;
                }
            }

            if (soGheDangChon == 0)
            {
                MessageBox.Show("Bạn chưa chọn ghế nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Xuất tổng tiền lên ô txtThanhTien
            Control[] arrThanhTien = this.Controls.Find("txtThanhTien", true);
            if (arrThanhTien.Length > 0)
            {
                arrThanhTien[0].Text = tongTien.ToString("N0") + " VNĐ";
            }
        }

        // Nút HỦY BỎ
        private void BtnHuyBo_Click(object sender, EventArgs e)
        {
            // Trả toàn bộ ghế đang chọn (màu xanh) về màu trắng
            foreach (Button btn in danhSachGhe)
            {
                if (btn.BackColor == Color.Blue)
                {
                    btn.BackColor = Color.White;
                    btn.ForeColor = Color.Black;
                }
            }

            // Đặt Thành tiền về 0
            Control[] arrThanhTien = this.Controls.Find("txtThanhTien", true);
            if (arrThanhTien.Length > 0)
            {
                arrThanhTien[0].Text = "0 VNĐ";
            }
        }

        // Nút KẾT THÚC
        private void BtnKetThuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmBanVe_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn kết thúc chương trình?",
                                             "Xác nhận",
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);
            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        #endregion

        #region Các hàm chống lỗi đồng bộ Designer
        private void FrmBai1NangCao_Load(object sender, EventArgs e) { }
        private void FrmBanVe_Load(object sender, EventArgs e) { }
        private void button1_Click(object sender, EventArgs e) { }
        private void button2_Click(object sender, EventArgs e) { }
        private void button3_Click(object sender, EventArgs e) { }
        #endregion
    }
}