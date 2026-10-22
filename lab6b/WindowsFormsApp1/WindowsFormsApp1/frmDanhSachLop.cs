using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace QLSinhVien
{
    public partial class frmDanhSachLop : Form
    {
        SqlConnection conn = new SqlConnection(DbConfig.connectionString);

        public frmDanhSachLop()
        {
            InitializeComponent();
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT MaLop, TenLop, MaKhoa FROM Lop", conn);
                SqlDataReader rd = cmd.ExecuteReader();

                lvLop.Items.Clear();
                int stt = 1;

                while (rd.Read())
                {
                    ListViewItem item = new ListViewItem(stt.ToString());
                    item.SubItems.Add(rd["MaLop"].ToString());
                    item.SubItems.Add(rd["TenLop"].ToString());
                    item.SubItems.Add(rd["MaKhoa"].ToString());
                    lvLop.Items.Add(item);
                    stt++;
                }
                rd.Close();
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
            finally { if (conn.State == ConnectionState.Open) conn.Close(); }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}