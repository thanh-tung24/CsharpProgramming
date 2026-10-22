using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLSinhVien
{
    public partial class frmMonHoc : Form
    {
        SqlConnection conn = new SqlConnection(DbConfig.connectionString);

        public frmMonHoc()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaMH.Text) || string.IsNullOrWhiteSpace(txtTenMH.Text))
            {
                MessageBox.Show("Mã môn học và Tên môn học không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();

                string sql = "INSERT INTO MonHoc (MaMonHoc, TenMonHoc) VALUES (@MaMH, @TenMH)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaMH", txtMaMH.Text.Trim());
                cmd.Parameters.AddWithValue("@TenMH", txtTenMH.Text.Trim());

                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm môn học thành công!", "Thông báo");
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
            if (string.IsNullOrWhiteSpace(txtMaMH.Text))
            {
                MessageBox.Show("Mã môn học không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();

                string sql = "DELETE FROM MonHoc WHERE MaMonHoc = @MaMH";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaMH", txtMaMH.Text.Trim());

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                    MessageBox.Show("Xóa môn học thành công!", "Thông báo");
                else
                    MessageBox.Show("Không tìm thấy mã môn học!", "Thông báo");
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
            if (string.IsNullOrWhiteSpace(txtMaMH.Text) || string.IsNullOrWhiteSpace(txtTenMH.Text))
            {
                MessageBox.Show("Mã môn học và Tên môn học không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();

                string sql = "UPDATE MonHoc SET TenMonHoc = @TenMH WHERE MaMonHoc = @MaMH";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaMH", txtMaMH.Text.Trim());
                cmd.Parameters.AddWithValue("@TenMH", txtTenMH.Text.Trim());

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                    MessageBox.Show("Cập nhật môn học thành công!", "Thông báo");
                else
                    MessageBox.Show("Không tìm thấy mã môn học!", "Thông báo");
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