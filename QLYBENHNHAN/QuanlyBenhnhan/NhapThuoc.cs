using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanlyBenhnhan
{
    public partial class NhapThuoc : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=MSI\\SQLEXPRESS;Initial Catalog=Danhsachbenhnhan;Integrated Security=True");
        public NhapThuoc()
        {
            InitializeComponent();
        }
        
        private void NhapThuoc_Load(object sender, EventArgs e)
        {
            loadBill();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                String timkiem = txtTimBenhNhan.Text.Trim();
                String sql = "Select IDbenhnhan, Hovaten, Ngaysinh from Benhnhan Where IDbenhnhan=@IDbenhnhan or Hovaten=@Hovaten";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@IDbenhnhan", timkiem);
                cmd.Parameters.AddWithValue("@Hovaten", timkiem);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.SelectCommand = cmd;
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                conn.Close();
                loadBill();
                GrvTen.DataSource = dt;
                GrvTen.Refresh();
            }catch (Exception ex)
            {
                MessageBox.Show("Không tìm thấy thông tin", "Thông báo");
            }


        }
        public void loadBill()
        {
            try
            {
                string id = txtTimBenhNhan.Text.Trim();
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                String sql = " SELECT Bill3.idBill3, Benhnhan.Hovaten, Thuoc1.Tenthuoc, Thuoc1.Gia, Bill3.Soluong, (Thuoc1.Gia*Bill3.Soluong) as ToTal FROM Bill3 INNER JOIN Benhnhan ON Bill3.IDbenhnhan = Benhnhan.IDbenhnhan INNER JOIN Thuoc1 ON Bill3.IDthuoc = Thuoc1.IDthuoc WHERE(Benhnhan.IDbenhnhan = N'" + id + "') OR (Benhnhan.Hovaten = N'" + id + "')";
                SqlCommand cmd = new SqlCommand(@sql, conn);
                SqlDataAdapter adapter1 = new SqlDataAdapter(cmd);
                adapter1.SelectCommand = cmd;
                DataTable dt = new DataTable();
                adapter1.Fill(dt);
                conn.Close();
                grvCapthuoc.DataSource = dt;
                grvCapthuoc.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hiển thị", "Thông báo");
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string IDhoadon = txtIDhoadon.Text.Trim();
                string IDBenhnhan = GrvTen.SelectedCells[0].Value.ToString();

                string idThuoc = grvThuoc.SelectedCells[0].Value.ToString();
                int Soluong = int.Parse(nmSoluong.Value.ToString());
                conn.Open();
                string sql = "insert into Bill3 values('" + IDhoadon + "','" + IDBenhnhan + "','" + idThuoc + "','" + Soluong + "')";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                conn.Close();
                loadBill();
                MessageBox.Show("Cấp thuốc thành công!");
            }catch( Exception ex )
            {
                MessageBox.Show("Thông báo lỗi ", "Hệ thống");
            }
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                String timkiem = txtTimThuoc.Text.Trim();
                String sql = "Select IDthuoc,Tenthuoc from Thuoc1 Where IDthuoc=@IDthuoc or Tenthuoc=@Tenthuoc";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@IDthuoc", timkiem);
                cmd.Parameters.AddWithValue("@Tenthuoc", timkiem);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.SelectCommand = cmd;
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                conn.Close();
                grvThuoc.DataSource = dt;
                grvThuoc.Refresh();
            }catch(Exception ex)
            {
                MessageBox.Show("Không tìm thấy thông tin", "Thông báo");
            }   
        }

        private void GrvTen_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IDbenh.Text = GrvTen.SelectedCells[0].Value.ToString();
            loadBill();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                String ID = grvCapthuoc.SelectedCells[0].Value.ToString();
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string sql = "delete from Bill3 where idBill3 ='" + ID + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                conn.Close();
                MessageBox.Show("Xóa thành công!");
                grvCapthuoc.Refresh();
                loadBill();
            }catch (Exception ex)
            {
                MessageBox.Show("Không thể xóa", "Thông báo");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Trangchu trangchu = new Trangchu();
            trangchu.ShowDialog();
        }
    }
}
