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
    public partial class PhongDaCap : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=MSI\\SQLEXPRESS;Initial Catalog=Danhsachbenhnhan;Integrated Security=True");
        public PhongDaCap()
        {
            InitializeComponent();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                TraGiuong traGiuong = new TraGiuong();
                traGiuong.setIDgiuong(GrvGiuong.SelectedCells[0].Value.ToString());
                traGiuong.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hệ thống lỗi", "Thông báo");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide  ();
            DanhsachPhong danhsachPhong = new DanhsachPhong();
            danhsachPhong.ShowDialog();
        }
        public void khoa()
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand("SELECT Tenkhoa FROM     Khoabenh", conn);
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                cmd.Dispose();
                conn.Close();
                DataRow r = dt.NewRow();
                r["Tenkhoa"] = "-- Chọn khoa --";
                dt.Rows.InsertAt(r, 0);
                cbKhoa.DataSource = dt;
                cbKhoa.DisplayMember = "Tenkhoa";
                cbKhoa.ValueMember = "Tenkhoa";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hệ thống lỗi", "Thông báo");
            }
        }
        public void loadPhong()
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand("SELECT Phong.Tenphong     FROM     Khoabenh INNER JOIN Phong ON Khoabenh.IDkhoa = Phong.IDkhoa  WHERE (Khoabenh.Tenkhoa = N'"+cbKhoa.Text+"')", conn);
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                cmd.Dispose();
                conn.Close();
                DataRow r = dt.NewRow();
                r["Tenphong"] = "-- Chọn phòng --";
                dt.Rows.InsertAt(r, 0);
                cbPhong.DataSource = dt;
                cbPhong.DisplayMember = "Tenphong";
                cbPhong.ValueMember = "Tenphong";
            }catch (Exception ex)
            {
                MessageBox.Show("Hệ thống lỗi", "Thông báo");
            }

        }
        private void cbPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string lenh = @"SELECT Giuong.IDgiuong, Khoabenh.Tenkhoa, Phong.Tenphong, Giuong.Tengiuong, Giuong.Status, Benhnhan.IDbenhnhan, Benhnhan.Hovaten
                            FROM     Phong INNER JOIN
                  Giuong ON Phong.IDphong = Giuong.IDphong INNER JOIN
                  Benhnhan ON Giuong.IDbenhnhan = Benhnhan.IDbenhnhan INNER JOIN
                  Khoabenh ON Phong.IDkhoa = Khoabenh.IDkhoa
                        WHERE  (Giuong.Status = N'Có người') AND (Phong.Tenphong = N'" + cbPhong.Text + "' And (Khoabenh.Tenkhoa=N'"+cbKhoa.Text+"'))";
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand(lenh, conn);
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                cmd.Dispose();
                conn.Close();
                GrvGiuong.DataSource = dt;
            }catch(Exception ex)
            {
                MessageBox.Show("Hệ thống lỗi", "Thông báo");
            }
        }

        private void PhongDaCap_Load(object sender, EventArgs e)
        {
            
            khoa();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            
             
               loadPhong();
           
        }
    }
}
