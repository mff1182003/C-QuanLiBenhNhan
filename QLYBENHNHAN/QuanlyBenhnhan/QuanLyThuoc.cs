using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanlyBenhnhan
{
    public partial class QuanLyThuoc : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=MSI\\SQLEXPRESS;Initial Catalog=Danhsachbenhnhan;Integrated Security=True");
        public QuanLyThuoc()
        {
            InitializeComponent();
        }

        private void thêmThuốcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThemThuoc themThuoc = new ThemThuoc();
            themThuoc.ShowDialog();
        }

        private void sửaThuốcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                SuaThuoc suaThuoc = new SuaThuoc();
                suaThuoc.setID(grvthuoc.SelectedCells[0].Value.ToString());
                suaThuoc.ShowDialog();
            }catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống", "Thông báo");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Trangchu trangchu = new Trangchu();
            trangchu.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                String timkiem = txtTimKiem.Text.Trim();
                String sql = "Select * from Thuoc1 Where IDthuoc=@IDthuoc or Tenthuoc=@Tenthuoc";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@IDthuoc", timkiem);
                cmd.Parameters.AddWithValue("@Tenthuoc", timkiem);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.SelectCommand = cmd;
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                conn.Close();
                grvthuoc.DataSource = dt;
                grvthuoc.Refresh();
            }catch(Exception ex)
            {
                MessageBox.Show("Không tìm thấy thông tin", "Thông báo");
            }
        }

        private void QuanLyThuoc_Load(object sender, EventArgs e)
        {
            grvthuoc.Refresh();
        }

        private void xóaThuốcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                String ID = grvthuoc.SelectedCells[0].Value.ToString();
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string sql = "delete from Thuoc1 where IDthuoc ='" + ID + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                conn.Close();
                MessageBox.Show("Xóa thành công!");
                grvthuoc.Refresh();
            }catch (Exception ex) {
                MessageBox.Show("Không thể xóa", "Thông báo");
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
