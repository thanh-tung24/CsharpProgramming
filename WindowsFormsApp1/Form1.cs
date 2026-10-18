using System;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace BaiNangCao
{
    public partial class Form1 : Form
    {
        // Mảng Họ, Tên lót, Tên theo yêu cầu đề bài
        private string[] HO = { "Lê", "Nguyễn", "Lý", "Trần", "Lâm", "Hồ", "Lai", "Huỳnh", "La" };
        private string[] TENLOT = { "Quang", "Thành", "Ngọc", "Anh", "Xuân", "Bảo", "Cẩm", "Thị", "Kim", "Thái", "Hồng" };
        private string[] TEN = { "Hà", "Danh", "Sơn", "Mai", "Thắng", "Kỳ", "Thành", "Lâm", "Tâm", "Phụng", "Thắm" };

        public Form1()
        {
            InitializeComponent();
        }

        // Tạo ngẫu nhiên 50 tên
        private void btnNgauNhien_Click(object sender, EventArgs e)
        {
            lstTen.Items.Clear();
            Random rand = new Random();

            for (int i = 0; i < 50; i++)
            {
                string ho = HO[rand.Next(HO.Length)];
                string lot = TENLOT[rand.Next(TENLOT.Length)];
                string ten = TEN[rand.Next(TEN.Length)];

                lstTen.Items.Add($"{ho} {lot} {ten}");
            }
        }

        // Xóa các phần tử đang được chọn
        private void btnXoaDangChon_Click(object sender, EventArgs e)
        {
            if (lstTen.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một phần tử để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Xóa theo thứ tự giảm dần của chỉ số để không bị lệch index
            for (int i = lstTen.SelectedIndices.Count - 1; i >= 0; i--)
            {
                lstTen.Items.RemoveAt(lstTen.SelectedIndices[i]);
            }
        }

        // Xóa tất cả các phần tử có tên là "Sơn"
        private void btnXoaTenSon_Click(object sender, EventArgs e)
        {
            for (int i = lstTen.Items.Count - 1; i >= 0; i--)
            {
                string item = lstTen.Items[i].ToString().Trim();
                string[] parts = item.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (parts.Length > 0 && string.Compare(parts[parts.Length - 1], "Sơn", true) == 0)
                {
                    lstTen.Items.RemoveAt(i);
                }
            }
        }

        // Xóa tất cả các phần tử có họ là "Lê"
        private void btnXoaHoLe_Click(object sender, EventArgs e)
        {
            for (int i = lstTen.Items.Count - 1; i >= 0; i--)
            {
                string item = lstTen.Items[i].ToString().Trim();
                string[] parts = item.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (parts.Length > 0 && string.Compare(parts[0], "Lê", true) == 0)
                {
                    lstTen.Items.RemoveAt(i);
                }
            }
        }

        // Chuyển phần tử đang chọn thành chữ HOA
        private void btnChuyenHoa_Click(object sender, EventArgs e)
        {
            if (lstTen.SelectedIndices.Count == 0) return;

            var selectedIndices = lstTen.SelectedIndices.Cast<int>().ToList();
            foreach (int index in selectedIndices)
            {
                lstTen.Items[index] = lstTen.Items[index].ToString().ToUpper();
            }
        }

        // Chuyển phần tử đang chọn thành chữ thường
        private void btnChuyenThuong_Click(object sender, EventArgs e)
        {
            if (lstTen.SelectedIndices.Count == 0) return;

            var selectedIndices = lstTen.SelectedIndices.Cast<int>().ToList();
            foreach (int index in selectedIndices)
            {
                lstTen.Items[index] = lstTen.Items[index].ToString().ToLower();
            }
        }

        // Chuyển phần tử đang chọn thành viết hoa đầu mỗi từ
        private void btnHoaDauTu_Click(object sender, EventArgs e)
        {
            if (lstTen.SelectedIndices.Count == 0) return;

            TextInfo textInfo = new CultureInfo("vi-VN", false).TextInfo;
            var selectedIndices = lstTen.SelectedIndices.Cast<int>().ToList();

            foreach (int index in selectedIndices)
            {
                string chuoiHienTai = lstTen.Items[index].ToString().ToLower();
                lstTen.Items[index] = textInfo.ToTitleCase(chuoiHienTai);
            }
        }

        // Xóa tất cả phần tử trong ListBox
        private void btnXoaTatCa_Click(object sender, EventArgs e)
        {
            lstTen.Items.Clear();
        }

        // Nhấp đúp chuột vào phần tử để sửa tên thông qua InputBox
        private void lstTen_DoubleClick(object sender, EventArgs e)
        {
            if (lstTen.SelectedIndex != -1)
            {
                int index = lstTen.SelectedIndex;
                string tenCu = lstTen.Items[index].ToString();

                string tenMoi = Interaction.InputBox("Nhập họ tên mới thay thế:", "Chỉnh sửa họ tên", tenCu);

                if (!string.IsNullOrWhiteSpace(tenMoi))
                {
                    lstTen.Items[index] = tenMoi.Trim();
                }
            }
        }
    }
}