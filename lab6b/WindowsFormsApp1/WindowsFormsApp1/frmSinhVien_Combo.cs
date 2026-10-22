using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLSinhVien
{
    public partial class frmSinhVien_Combo : Form
    {
        SqlConnection conn = new SqlConnection(DbConfig.connectionString);

        public frmSinhVien_Combo()
        {
            InitializeComponent();
        }

        private void frmSinhVien_Combo_Load(object sender, EventArgs e)
        {
            // Thiết lập định dạng hiển thị ngày/tháng/năm khi Form khởi chạy
            dtpNgaySinh.Format = DateTimePickerFormat.Custom;
            dtpNgaySinh.CustomFormat = "dd/MM/yyyy";

            LoadLop_ComboBox();
        }

        // Load danh sách Lớp từ SQL Server vào ComboBox
        private void LoadLop_ComboBox()
        {
            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT MaLop FROM Lop", conn);
                SqlDataReader rd = cmd.ExecuteReader();
                cboLop.Items.Clear();
                while (rd.Read())
                {
                    cboLop.Items.Add(rd["MaLop"].ToString());
                }
                rd.Close();

                if (cboLop.Items.Count > 0)
                {
                    cboLop.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách lớp: " + ex.Message, "Lỗi");
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }
        }

        // Phương thức kiểm tra trùng khóa chính (Mã sinh viên)
        private bool KT_KhoaChinh(string maSV)
        {
            bool result = false;
            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM SinhVien WHERE MaSinhVien = @MaSV", conn);
                cmd.Parameters.AddWithValue("@MaSV", maSV);
                int count = (int)cmd.ExecuteScalar();
                result = (count > 0);
            }
            catch
            {
                result = false;
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }
            return result;
        }

        // Nút Thêm
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaSV.Text) || string.IsNullOrWhiteSpace(txtHoTen.Text) || cboLop.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tất cả thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra tuổi >= 17 (chỉ tính năm)
            int tuoi = DateTime.Now.Year - dtpNgaySinh.Value.Year;
            if (tuoi < 17)
            {
                MessageBox.Show("Sinh viên phải từ 17 tuổi trở lên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra trùng Mã SV
            if (KT_KhoaChinh(txtMaSV.Text.Trim()))
            {
                MessageBox.Show("Trùng mã sinh viên trong hệ thống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();
                string sql = "INSERT INTO SinhVien (MaSinhVien, HoTen, NgaySinh, MaLop) VALUES (@MaSV, @HoTen, @NgaySinh, @MaLop)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaSV", txtMaSV.Text.Trim());
                cmd.Parameters.AddWithValue("@HoTen", txtHoTen.Text.Trim());
                cmd.Parameters.AddWithValue("@NgaySinh", dtpNgaySinh.Value);
                cmd.Parameters.AddWithValue("@MaLop", cboLop.SelectedItem.ToString());

                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm sinh viên mới thành công!", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm thất bại: " + ex.Message, "Lỗi");
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }
        }

        // Nút Xóa
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaSV.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã sinh viên cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!KT_KhoaChinh(txtMaSV.Text.Trim()))
            {
                MessageBox.Show("Mã sinh viên không tồn tại để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM SinhVien WHERE MaSinhVien = @MaSV", conn);
                cmd.Parameters.AddWithValue("@MaSV", txtMaSV.Text.Trim());

                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa sinh viên thành công!", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa thất bại (Có thể bị vướng dữ liệu bảng Điểm): " + ex.Message, "Lỗi");
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }
        }

        // Nút Sửa
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaSV.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã sinh viên cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!KT_KhoaChinh(txtMaSV.Text.Trim()))
            {
                MessageBox.Show("Mã sinh viên không tồn tại trong CSDL!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();
                string sql = "UPDATE SinhVien SET HoTen = @HoTen, NgaySinh = @NgaySinh, MaLop = @MaLop WHERE MaSinhVien = @MaSV";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaSV", txtMaSV.Text.Trim());
                cmd.Parameters.AddWithValue("@HoTen", txtHoTen.Text.Trim());
                cmd.Parameters.AddWithValue("@NgaySinh", dtpNgaySinh.Value);
                cmd.Parameters.AddWithValue("@MaLop", cboLop.SelectedItem.ToString());

                cmd.ExecuteNonQuery();
                MessageBox.Show("Sửa thông tin sinh viên thành công!", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sửa thất bại: " + ex.Message, "Lỗi");
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }
        }
    }
}