using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BTVN1
{
    public partial class Form1 : Form
    {
        // Danh sách từ điển lưu bằng Dictionary
        private Dictionary<string, string> dictAnhViet = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        private Dictionary<string, string> dictVietAnh = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KhoiTaoTuDien();
        }

        private void KhoiTaoTuDien()
        {
            // Danh sách từ Anh - Việt mẫu từ tài liệu
            dictAnhViet.Add("student", "Sinh viên, học sinh");
            dictAnhViet.Add("teacher", "Giáo viên, giảng viên");
            dictAnhViet.Add("worker", "Công nhân, người lao động");
            dictAnhViet.Add("hat", "Cái mũ, cái nón");
            dictAnhViet.Add("head", "Cái đầu");
            dictAnhViet.Add("mouse", "Con chuột");
            dictAnhViet.Add("cat", "Con mèo");
            dictAnhViet.Add("dog", "Con chó");
            dictAnhViet.Add("snake", "Con rắn");
            dictAnhViet.Add("lamb", "Con cừu con");
            dictAnhViet.Add("lion", "Con sư tử");
            dictAnhViet.Add("frog", "Con ếch");
            dictAnhViet.Add("sheep", "Con cừu");

            // Nạp dữ liệu vào Tab Anh - Việt
            foreach (var item in dictAnhViet)
            {
                cboTuAV.Items.Add(item.Key);
                lstTuAV.Items.Add(item.Key);

                // Đồng thời tạo dữ liệu ngược cho Tab Việt - Anh
                if (!dictVietAnh.ContainsKey(item.Value))
                {
                    dictVietAnh.Add(item.Value, item.Key);
                    cboTuVA.Items.Add(item.Value);
                    lstTuVA.Items.Add(item.Value);
                }
            }

            if (lstTuAV.Items.Count > 0)
            {
                lstTuAV.SelectedIndex = 0;
            }
            if (lstTuVA.Items.Count > 0)
            {
                lstTuVA.SelectedIndex = 0;
            }
        }

        // Tra từ Anh - Việt
        private void TraTuAnhViet(string tu)
        {
            if (dictAnhViet.ContainsKey(tu))
            {
                txtNghiaAV.Text = dictAnhViet[tu];
                cboTuAV.Text = tu;
                lstTuAV.SelectedItem = tu;
            }
            else
            {
                txtNghiaAV.Text = "Không tìm thấy nghĩa của từ này.";
            }
        }

        private void lstTuAV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstTuAV.SelectedItem != null)
            {
                TraTuAnhViet(lstTuAV.SelectedItem.ToString());
            }
        }

        private void lstTuAV_DoubleClick(object sender, EventArgs e)
        {
            if (lstTuAV.SelectedItem != null)
            {
                TraTuAnhViet(lstTuAV.SelectedItem.ToString());
            }
        }

        private void cboTuAV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTuAV.SelectedItem != null)
            {
                TraTuAnhViet(cboTuAV.SelectedItem.ToString());
            }
        }

        private void cboTuAV_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TraTuAnhViet(cboTuAV.Text.Trim());
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        // Tra từ Việt - Anh
        private void TraTuVietAnh(string tu)
        {
            if (dictVietAnh.ContainsKey(tu))
            {
                txtNghiaVA.Text = dictVietAnh[tu];
                cboTuVA.Text = tu;
                lstTuVA.SelectedItem = tu;
            }
            else
            {
                txtNghiaVA.Text = "Không tìm thấy nghĩa của từ này.";
            }
        }

        private void lstTuVA_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstTuVA.SelectedItem != null)
            {
                TraTuVietAnh(lstTuVA.SelectedItem.ToString());
            }
        }

        private void lstTuVA_DoubleClick(object sender, EventArgs e)
        {
            if (lstTuVA.SelectedItem != null)
            {
                TraTuVietAnh(lstTuVA.SelectedItem.ToString());
            }
        }

        private void cboTuVA_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTuVA.SelectedItem != null)
            {
                TraTuVietAnh(cboTuVA.SelectedItem.ToString());
            }
        }

        private void cboTuVA_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TraTuVietAnh(cboTuVA.Text.Trim());
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có chắc muốn thoát khỏi từ điển?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}