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
    public partial class DanhsachPhong : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=MSI\\SQLEXPRESS;Initial Catalog=Danhsachbenhnhan;Integrated Security=True");
        public DanhsachPhong()
        {
            InitializeComponent();
        }
        public void loadPhong()
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand("SELECT Giuong.IDgiuong, Giuong.Tengiuong, Giuong.Status, Phong.Tenphong FROM     Giuong INNER JOIN   Phong ON Giuong.IDphong = Phong.IDphong", conn);
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                cmd.Dispose();
                conn.Close();
                grvGiuong.DataSource = dt;
                grvGiuong.Refresh();

            }catch (Exception ex)
            {
                MessageBox.Show("Lỗi hiển thị", "Thông báo");
            }
        }
        private void DanhsachPhong_Load(object sender, EventArgs e)
        {
            loadPhong();
        }

        private void phòngTrốngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            PhongTrong phongTrong = new PhongTrong();
            phongTrong.ShowDialog();
        }

        private void phòngĐãCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this .Hide();
            PhongDaCap phongDaCap = new PhongDaCap();
            phongDaCap.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Trangchu trangchu= new Trangchu();
            trangchu.ShowDialog();
        }
    }
}
