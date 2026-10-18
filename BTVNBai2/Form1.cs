using System;
using System.Windows.Forms;

namespace BTVNBai2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Hàm hỗ trợ mở Form con theo mô hình MDI: nếu form đã mở thì activate, chưa mở thì tạo mới
        private void MoFormCon(Form frm)
        {
            foreach (Form formCon in this.MdiChildren)
            {
                if (formCon.GetType() == frm.GetType())
                {
                    formCon.Activate();
                    return;
                }
            }

            frm.MdiParent = this;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }

        // Mở Bài 1 tại lớp: Quản lý sinh viên (ListView)
        private void mnuBai1TaiLop_Click(object sender, EventArgs e)
        {
            MoFormCon(new Bai1.Form1());
        }

        // Mở Bài 2 tại lớp: Quản lý tài khoản (ListView)
        private void mnuBai2TaiLop_Click(object sender, EventArgs e)
        {
            MoFormCon(new Bai2.Form1());
        }

        // Mở Bài nâng cao: Quản lý học viên (Lớp A, Lớp B)
        private void mnuBai1NangCao_Click(object sender, EventArgs e)
        {
            MoFormCon(new BaiNangCao.Form1());
        }

        // Mở Bài tập về nhà 1: Đếm ngược thời gian
        private void mnuBTVN1_Click(object sender, EventArgs e)
        {
            MoFormCon(new BTVNBai1.Form1());
        }

        // Thoát ứng dụng
        private void mnuThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có chắc chắn muốn thoát khỏi chương trình tổng hợp?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}