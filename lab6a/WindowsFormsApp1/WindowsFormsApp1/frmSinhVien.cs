using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLSinhVien
{
    public partial class frmSinhVien : Form
    {
        SqlConnection conn = new SqlConnection(DbConfig.connectionString);

        public frmSinhVien()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaLop.Text) || string.IsNullOrWhiteSpace(txtMaSV.Text) ||
                string.IsNullOrWhiteSpace(txtHoTen.Text) || string.IsNullOrWhiteSpace(dtpNgaySinh.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();

                string sql = "INSERT INTO SinhVien (MaSinhVien, HoTen, NgaySinh, MaLop) VALUES (@MaSV, @HoTen, @NgaySinh, @MaLop)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaSV", txtMaSV.Text.Trim());
                cmd.Parameters.AddWithValue("@HoTen", txtHoTen.Text.Trim());
                cmd.Parameters.AddWithValue("@NgaySinh", DateTime.Parse(dtpNgaySinh.Text));
                cmd.Parameters.AddWithValue("@MaLop", txtMaLop.Text.Trim());

                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm sinh viên thành công!", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thất bại");
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaSV.Text) || string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Mã sinh viên và Họ tên không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();

                string sql = "DELETE FROM SinhVien WHERE MaSinhVien = @MaSV AND HoTen = @HoTen";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaSV", txtMaSV.Text.Trim());
                cmd.Parameters.AddWithValue("@HoTen", txtHoTen.Text.Trim());

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                    MessageBox.Show("Xóa sinh viên thành công!", "Thông báo");
                else
                    MessageBox.Show("Không tìm thấy sinh viên phù hợp!", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thất bại");
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaSV.Text))
            {
                MessageBox.Show("Mã sinh viên không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool hasMaLop = !string.IsNullOrWhiteSpace(txtMaLop.Text);
            bool hasHoTen = !string.IsNullOrWhiteSpace(txtHoTen.Text);
            bool hasNgaySinh = !string.IsNullOrWhiteSpace(dtpNgaySinh.Text);

            if (!hasMaLop && !hasHoTen && !hasNgaySinh)
            {
                MessageBox.Show("Mã lớp, Họ tên hoặc Ngày sinh phải có ít nhất 1 trường có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();

                string sql = "UPDATE SinhVien SET ";
                bool first = true;

                if (hasHoTen) { sql += "HoTen = @HoTen"; first = false; }
                if (hasNgaySinh) { if (!first) sql += ", "; sql += "NgaySinh = @NgaySinh"; first = false; }
                if (hasMaLop) { if (!first) sql += ", "; sql += "MaLop = @MaLop"; }

                sql += " WHERE MaSinhVien = @MaSV";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaSV", txtMaSV.Text.Trim());
                if (hasHoTen) cmd.Parameters.AddWithValue("@HoTen", txtHoTen.Text.Trim());
                if (hasNgaySinh) cmd.Parameters.AddWithValue("@NgaySinh", DateTime.Parse(dtpNgaySinh.Text));
                if (hasMaLop) cmd.Parameters.AddWithValue("@MaLop", txtMaLop.Text.Trim());

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                    MessageBox.Show("Cập nhật sinh viên thành công!", "Thông báo");
                else
                    MessageBox.Show("Không tìm thấy sinh viên!", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thất bại");
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }
        }
    }
}