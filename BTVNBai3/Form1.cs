using System;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

namespace BTVNBai3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KhoiTaoCayDanhBa();
        }

        // Tạo sẵn 26 node gốc đại diện các chữ cái từ A đến Z
        private void KhoiTaoCayDanhBa()
        {
            trvDanhBa.Nodes.Clear();
            for (char c = 'A'; c <= 'Z'; c++)
            {
                TreeNode rootLetterNode = new TreeNode(c.ToString());
                rootLetterNode.Name = c.ToString();
                trvDanhBa.Nodes.Add(rootLetterNode);
            }
        }

        // Hàm hỗ trợ chuẩn hóa ký tự tiếng Việt có dấu về ký tự không dấu cơ bản (A-Z)
        private char LayKyTuDauKhongDau(string text)
        {
            if (string.IsNullOrEmpty(text)) return '#';

            string normalized = text.Normalize(NormalizationForm.FormD);
            StringBuilder sb = new StringBuilder();

            foreach (char ch in normalized)
            {
                UnicodeCategory uc = CharUnicodeInfo.GetUnicodeCategory(ch);
                if (uc != UnicodeCategory.NonSpacingMark)
                {
                    sb.Append(ch);
                }
            }

            string result = sb.ToString().Normalize(NormalizationForm.FormC).ToUpper();

            // Xử lý riêng ký tự Đ/đ
            if (result.StartsWith("Đ")) return 'D';

            char firstChar = result[0];
            return (firstChar >= 'A' && firstChar <= 'Z') ? firstChar : '#';
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text.Trim();
            string lastName = txtLastName.Text.Trim();

            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ cả First Name và Last Name!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (string.IsNullOrEmpty(firstName)) txtFirstName.Focus();
                else txtLastName.Focus();
                return;
            }

            // Xác định ký tự đầu tiên của First Name để phân loại node
            char kyTuDau = LayKyTuDauKhongDau(firstName);
            string keyNode = kyTuDau.ToString();

            TreeNode[] nodes = trvDanhBa.Nodes.Find(keyNode, false);
            if (nodes.Length > 0)
            {
                TreeNode mucChuCai = nodes[0];
                string hoVaTenHienThi = $"{firstName}, {lastName}";

                // Kiểm tra trùng tên trong cùng node ký tự
                foreach (TreeNode child in mucChuCai.Nodes)
                {
                    if (string.Compare(child.Text, hoVaTenHienThi, StringComparison.OrdinalIgnoreCase) == 0)
                    {
                        MessageBox.Show("Người này đã có trong danh bạ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }

                TreeNode nodeNguoiMoi = new TreeNode(hoVaTenHienThi);
                mucChuCai.Nodes.Add(nodeNguoiMoi);
                mucChuCai.Expand();
                trvDanhBa.SelectedNode = nodeNguoiMoi;

                // Xóa trắng ô nhập liệu và đưa trỏ chuột về First Name
                txtFirstName.Clear();
                txtLastName.Clear();
                txtFirstName.Focus();
            }
            else
            {
                MessageBox.Show("Ký tự đầu của tên không nằm trong bảng chữ cái A-Z!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có chắc chắn muốn thoát khỏi danh bạ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}