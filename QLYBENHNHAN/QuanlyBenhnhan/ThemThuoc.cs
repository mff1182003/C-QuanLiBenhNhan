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
    public partial class ThemThuoc : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=MSI\\SQLEXPRESS;Initial Catalog=Danhsachbenhnhan;Integrated Security=True");
        public ThemThuoc()
        {
            InitializeComponent();
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
                String id = textIDT.Text.Trim();
                if (textIDT.Text.Trim() == "")
                {
                    textIDT.Focus();
                    MessageBox.Show("ID Trống?");
                    return;
                }

                String tenthuoc = textTent.Text.Trim();
                int Soluong = int.Parse(textSL.Text.Trim());
                String ngaynhap = dateNgaynhap.Value.ToString();
                String ngayhethan = datehethan.Value.ToString();
                int gia = int.Parse(textGia.Text.Trim());
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand("Thuoc_ins", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@IDthuoc", SqlDbType.NVarChar, 50).Value = id;
                cmd.Parameters.Add("@Tenthuoc", SqlDbType.NVarChar, 50).Value = tenthuoc;
                cmd.Parameters.Add("@Ngaynhap", SqlDbType.Date).Value = ngaynhap;
                cmd.Parameters.Add("@Ngayhethan", SqlDbType.Date).Value = ngayhethan;
                cmd.Parameters.Add("@Soluong", SqlDbType.Int).Value = Soluong;
                cmd.Parameters.Add("@Gia", SqlDbType.Int).Value = gia;
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                conn.Close();
                MessageBox.Show("Thêm Thành công!");
            }catch (Exception ex)
            {
                MessageBox.Show("Lỗi!", "Thông báo");
            }
        }
    }
}
