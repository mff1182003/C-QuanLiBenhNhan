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
    public partial class SuaThuoc : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=MSI\\SQLEXPRESS;Initial Catalog=Danhsachbenhnhan;Integrated Security=True");
        public SuaThuoc()
        {
            InitializeComponent();
        }
        private String ID;
        public void setID(String IDBN)
        {
            this.ID = IDBN;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLyThuoc quanLyThuoc = new QuanLyThuoc();
            quanLyThuoc.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                String sua = "update Thuoc1 Set IDthuoc=@IDthuoc, Tenthuoc=@Tenthuoc, Soluong=@Soluong,Gia=@Gia, Ngaynhap=@Ngaynhap, Ngayhethan=@Ngayhethan where IDthuoc =@IDthuoc ";
                SqlCommand cmd = new SqlCommand(sua, conn);
                cmd.Parameters.AddWithValue("IDthuoc", txtIDthuoc.Text);
                cmd.Parameters.AddWithValue("Tenthuoc", txtTenThuoc.Text);
                cmd.Parameters.AddWithValue("Soluong", txtSL.Text);
                cmd.Parameters.AddWithValue("Gia", txtGiaThuoc.Text);
                cmd.Parameters.AddWithValue("Ngaynhap", dateNgaynhap.Value);
                cmd.Parameters.AddWithValue("Ngayhethan", datehethan.Value);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                conn.Close();
                MessageBox.Show("Sửa thành công!");
            }catch(Exception ex)
            {
                MessageBox.Show("Lỗi!", "Thông báo");
            }
        }

        private void SuaThuoc_Load(object sender, EventArgs e)
        {
             txtIDthuoc.Text=ID;
        }
    }
}
