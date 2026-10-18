using System;
using System.Windows.Forms;

namespace Bai2
{
    public partial class Form1 : Form
    {
        private TreeNode rootNode;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Tạo root node Danh sách lớp
            rootNode = new TreeNode("Danh sách lớp");
            trvDanhSachLop.Nodes.Add(rootNode);

            // Các lớp khởi tạo ban đầu
            string[] dsLop = { "05DHTH1", "05DHTH2", "05DHTH3", "05DHTH4" };
            foreach (string lop in dsLop)
            {
                rootNode.Nodes.Add(new TreeNode(lop));
                cboLop.Items.Add(lop);
            }

            if (cboLop.Items.Count > 0)
            {
                cboLop.SelectedIndex = 0;
            }

            rootNode.Expand();
            chkThemLop.Checked = false;
            gbThongTinLop.Visible = false;
        }

        // Ẩn/hiện GroupBox Thông tin lớp theo CheckBox
        private void chkThemLop_CheckedChanged(object sender, EventArgs e)
        {
            gbThongTinLop.Visible = chkThemLop.Checked;
            if (chkThemLop.Checked)
            {
                txtTenLop.Focus();
            }
        }

        // Button Thêm lớp
        private void btnThemLop_Click(object sender, EventArgs e)
        {
            string tenLop = txtTenLop.Text.Trim();

            if (string.IsNullOrEmpty(tenLop))
            {
                MessageBox.Show("Vui lòng nhập tên lớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenLop.Focus();
                return;
            }

            // Kiểm tra trùng tên lớp
            foreach (TreeNode node in rootNode.Nodes)
            {
                if (string.Compare(node.Text, tenLop, true) == 0)
                {
                    MessageBox.Show("Tên lớp này đã tồn tại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTenLop.SelectAll();
                    txtTenLop.Focus();
                    return;
                }
            }

            rootNode.Nodes.Add(new TreeNode(tenLop));
            cboLop.Items.Add(tenLop);
            cboLop.SelectedItem = tenLop;

            txtTenLop.Clear();
            txtTenLop.Focus();
            rootNode.Expand();
        }

        // Hàm kiểm tra trùng mã SV trên toàn bộ TreeView
        private bool KiemTraTrungMaSV(TreeNode node, string maSV)
        {
            // Node cấp 2 chứa format: "MãSV, HọTên"
            if (node.Level == 2 && node.Tag != null)
            {
                string[] thongTin = (string[])node.Tag;
                if (string.Compare(thongTin[0], maSV, true) == 0)
                {
                    return true;
                }
            }

            foreach (TreeNode child in node.Nodes)
            {
                if (KiemTraTrungMaSV(child, maSV))
                    return true;
            }

            return false;
        }

        // Button Cập Nhật: Thêm sinh viên vào lớp đang chọn ở ComboBox
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string maSV = txtMaSV.Text.Trim();
            string hoTen = txtHoTen.Text.Trim();
            string diaChi = txtDiaChi.Text.Trim();

            if (string.IsNullOrEmpty(maSV) || string.IsNullOrEmpty(hoTen) || string.IsNullOrEmpty(diaChi))
            {
                MessageBox.Show("Vui lòng điền đầy đủ Mã SV, Họ Tên và Địa Chỉ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cboLop.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn lớp để thêm sinh viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra trùng mã SV
            if (KiemTraTrungMaSV(rootNode, maSV))
            {
                MessageBox.Show("Mã sinh viên này đã tồn tại trong danh sách!", "Cảnh báo trùng mã", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaSV.SelectAll();
                txtMaSV.Focus();
                return;
            }

            // Tìm node lớp tương ứng
            string lopChon = cboLop.SelectedItem.ToString();
            TreeNode nodeLop = null;
            foreach (TreeNode n in rootNode.Nodes)
            {
                if (n.Text == lopChon)
                {
                    nodeLop = n;
                    break;
                }
            }

            if (nodeLop != null)
            {
                TreeNode nodeSV = new TreeNode($"{maSV}, {hoTen}");
                nodeSV.Tag = new string[] { maSV, hoTen, diaChi, lopChon };

                TreeNode nodeDiaChi = new TreeNode(diaChi);
                nodeSV.Nodes.Add(nodeDiaChi);

                nodeLop.Nodes.Add(nodeSV);
                nodeLop.Expand();
                nodeSV.Expand();

                // Xóa trắng ô nhập liệu sinh viên
                txtMaSV.Clear();
                txtHoTen.Clear();
                txtDiaChi.Clear();
                txtMaSV.Focus();
            }
        }

        // Khi click vào một node trên TreeView: hiển thị thông tin sinh viên lên Textbox
        private void trvDanhSachLop_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode selectedNode = e.Node;

            if (selectedNode.Level == 2 && selectedNode.Tag != null)
            {
                string[] thongTin = (string[])selectedNode.Tag;
                txtMaSV.Text = thongTin[0];
                txtHoTen.Text = thongTin[1];
                txtDiaChi.Text = thongTin[2];
                cboLop.SelectedItem = thongTin[3];
            }
            else if (selectedNode.Level == 3 && selectedNode.Parent != null && selectedNode.Parent.Tag != null)
            {
                string[] thongTin = (string[])selectedNode.Parent.Tag;
                txtMaSV.Text = thongTin[0];
                txtHoTen.Text = thongTin[1];
                txtDiaChi.Text = thongTin[2];
                cboLop.SelectedItem = thongTin[3];
            }
        }

        // Button Xóa: Chỉ cho phép xóa node sinh viên
        private void btnXoa_Click(object sender, EventArgs e)
        {
            TreeNode selectedNode = trvDanhSachLop.SelectedNode;

            if (selectedNode == null)
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần xóa trên TreeView!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Xác định đúng node sinh viên (Level 2)
            TreeNode nodeCanXoa = null;
            if (selectedNode.Level == 2)
            {
                nodeCanXoa = selectedNode;
            }
            else if (selectedNode.Level == 3)
            {
                nodeCanXoa = selectedNode.Parent;
            }
            else
            {
                MessageBox.Show("Chỉ được phép xóa một sinh viên, không thể xóa node lớp hoặc thư mục gốc!", "Lỗi thao tác", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult r = MessageBox.Show($"Bạn có chắc chắn muốn xóa sinh viên: {nodeCanXoa.Text}?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                nodeCanXoa.Remove();
                txtMaSV.Clear();
                txtHoTen.Clear();
                txtDiaChi.Clear();
            }
        }
    }
}