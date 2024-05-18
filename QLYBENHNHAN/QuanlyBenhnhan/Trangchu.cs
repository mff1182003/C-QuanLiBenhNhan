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

namespace QuanlyBenhnhan
{
    public partial class Trangchu : Form
    {
        public Trangchu()
        {
            InitializeComponent();
        }
        private void danhSáchBệnhNhânToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Hide();
            DanhSachBenhNhan danhSachBenhNhan = new DanhSachBenhNhan();
            danhSachBenhNhan.ShowDialog();
        }

        private void danhSáchPhòngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            DanhsachPhong danhsachPhong = new DanhsachPhong();
            danhsachPhong.ShowDialog();
        }

        private void quảnLýThuốcToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            QuanLyThuoc quanLyThuoc = new QuanLyThuoc();
            quanLyThuoc.ShowDialog();
        }

        private void cấpThuốcToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Hide();
            NhapThuoc nhapThuoc = new NhapThuoc();
            nhapThuoc.ShowDialog();  
        }
        private void đăngXuấtToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Hide();
            TaiKhoan login = new TaiKhoan();
            login.ShowDialog();
        }

        private void xuấtHóaĐơnToolStripMenuItem2_Click(object sender, EventArgs e)
        {
           
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=MSI\\SQLEXPRESS;Initial Catalog=Danhsachbenhnhan;Integrated Security=True");
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                String timkiem = txtTimkiem.Text.Trim();
                String sql = "Select * from Benhnhan Where IDbenhnhan=@IDbenhnhan or Hovaten=@Hovaten";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@IDbenhnhan", timkiem);
                cmd.Parameters.AddWithValue("@Hovaten", timkiem);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.SelectCommand = cmd;
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                conn.Close();
                GrvBenhNhan.DataSource = dt;
                GrvBenhNhan.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thông tin cần tìm bị lỗi", "Thông báo");
            }
        }

        private void Trangchu_Load(object sender, EventArgs e)
        {

        }

        private void hoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            HoadonPhong hoadonPhong = new HoadonPhong();
            hoadonPhong.ShowDialog();
        }

        private void hóaĐơnThuốcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            HoaDonThuoc hoaDonThuoc = new HoaDonThuoc();
            hoaDonThuoc.ShowDialog();
        }
    }
}
