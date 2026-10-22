using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLSinhVien
{
    public partial class frmDiem : Form
    {
        SqlConnection conn = new SqlConnection(DbConfig.connectionString);

        public frmDiem()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaSV.Text) || string.IsNullOrWhiteSpace(txtMaMH.Text) || string.IsNullOrWhiteSpace(txtDiem.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã sinh viên, Mã môn học và Điểm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!float.TryParse(txtDiem.Text.Trim(), out float diem))
            {
                MessageBox.Show("Điểm phải là số hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();

                string sql = "INSERT INTO Diem (MaSinhVien, MaMonHoc, Diem) VALUES (@MaSV, @MaMH, @Diem)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaSV", txtMaSV.Text.Trim());
                cmd.Parameters.AddWithValue("@MaMH", txtMaMH.Text.Trim());
                cmd.Parameters.AddWithValue("@Diem", diem);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm điểm thành công!", "Thông báo");
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
            if (string.IsNullOrWhiteSpace(txtMaSV.Text) || string.IsNullOrWhiteSpace(txtMaMH.Text))
            {
                MessageBox.Show("Mã sinh viên và Mã môn học không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();

                string sql = "DELETE FROM Diem WHERE MaSinhVien = @MaSV AND MaMonHoc = @MaMH";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaSV", txtMaSV.Text.Trim());
                cmd.Parameters.AddWithValue("@MaMH", txtMaMH.Text.Trim());

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                    MessageBox.Show("Xóa điểm thành công!", "Thông báo");
                else
                    MessageBox.Show("Không tìm thấy dòng điểm tương ứng!", "Thông báo");
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
            if (string.IsNullOrWhiteSpace(txtMaSV.Text) || string.IsNullOrWhiteSpace(txtMaMH.Text) || string.IsNullOrWhiteSpace(txtDiem.Text))
            {
                MessageBox.Show("Mã sinh viên, Mã môn học và Điểm không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!float.TryParse(txtDiem.Text.Trim(), out float diem))
            {
                MessageBox.Show("Điểm chỉ được nhập số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();

                string sql = "UPDATE Diem SET Diem = @Diem WHERE MaSinhVien = @MaSV AND MaMonHoc = @MaMH";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaSV", txtMaSV.Text.Trim());
                cmd.Parameters.AddWithValue("@MaMH", txtMaMH.Text.Trim());
                cmd.Parameters.AddWithValue("@Diem", diem);

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                    MessageBox.Show("Cập nhật điểm thành công!", "Thông báo");
                else
                    MessageBox.Show("Không tìm thấy thông tin điểm!", "Thông báo");
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