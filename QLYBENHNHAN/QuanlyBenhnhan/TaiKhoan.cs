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
    public partial class TaiKhoan : Form
    {
        public TaiKhoan()
        {
            InitializeComponent();
        }

        private void HienthiMK_CheckedChanged(object sender, EventArgs e)
        {
            if (txtMatkhau.PasswordChar == '*')
            {
                HienthiMK.Checked = true;
                txtMatkhau.PasswordChar = '\0';
            }
            else if (txtMatkhau.PasswordChar == '\0')
            {
                HienthiMK.Checked = false;
                txtMatkhau.PasswordChar = '*';
            }
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=MSI\\SQLEXPRESS;Initial Catalog=Danhsachbenhnhan;Integrated Security=True");
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            string TK = txtTaikhoan.Text;
            string MK = txtMatkhau.Text;
            if (TK.Trim() == "") { MessageBox.Show("Vui lòng nhập tài khoản"); }
            else
            if (MK.Trim() == "") { MessageBox.Show("Vui lòng nhập mật khẩu"); }
            else
            {
                string sql = "Select * from Login where Taikhoan='" + TK + "'and Matkhau='" + MK + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read() == true)
                {
                    this.Hide();
                    Trangchu trangchu = new Trangchu();
                    trangchu.ShowDialog();
                    this.Show();
                }
                else
                {
                    DialogResult dt = MessageBox.Show("Đăng nhập thất bại. Bạn có muốn điền lại không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dt == DialogResult.No)
                    {
                        Close();
                    }
                }
            }
        }
    }
}
