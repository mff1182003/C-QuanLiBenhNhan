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
    public partial class CapGiuong : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=MSI\\SQLEXPRESS;Initial Catalog=Danhsachbenhnhan;Integrated Security=True");
        public CapGiuong()
        {
            InitializeComponent();
        }
        private String IDgiuong;
        public void setIDgiuong(String IDGiuong)
        {
            this.IDgiuong = IDGiuong;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            PhongTrong phongTrong = new PhongTrong();
            phongTrong.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string now = DateTime.Now.ToString();
                string nv = dateNgaycap.Text.Trim();
                if (DateTime.Compare(DateTime.Parse(nv), DateTime.Parse(now)) > 0)
                {
                    MessageBox.Show("Mời nhập lại, ngày nhận nhỏ hơn hôm nay", "Thông báo");
                }
                else
                {
                    string idGuong = lbIDgiuong.Text.Trim();
                    string idBenhnhan = grvThongtinbenhnhan.SelectedCells[0].Value.ToString();
                    string status = "Có người";
                    String ngaycap = dateNgaycap.Value.ToString();
                    string IDvao = txtIDvao.Text.Trim();
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    SqlCommand cmd = new SqlCommand("[Bill2_ins]", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@idBill2", SqlDbType.NVarChar, 100).Value = IDvao;
                    cmd.Parameters.Add("@datecheckin", SqlDbType.Date).Value = ngaycap;
                    cmd.Parameters.Add("@IDbenhnhan", SqlDbType.NVarChar, 100).Value = idBenhnhan;
                    cmd.Parameters.Add("@IDgiuong", SqlDbType.NVarChar, 100).Value = idGuong;
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    //nhập vào bảng giường trạng thái
                    string lenh = "update Giuong set Status=N'" + status + "', IDbenhnhan='" + idBenhnhan + "'where IDgiuong='" + idGuong + "'";
                    SqlCommand command = new SqlCommand(lenh, conn);
                    command.ExecuteNonQuery();
                    command.Dispose();
                    conn.Close();
                    MessageBox.Show("Cấp giường thành công", "Thông báo");
                }
            }catch (Exception ex)
            {
                MessageBox.Show("Mã bệnh nhân đã được cấp", "Thông báo");
            }
        }

        private void CapGiuong_Load(object sender, EventArgs e)
        {
            lbIDgiuong.Text = IDgiuong;
        }

        private void btnTimkieem_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                String timkiem = txtTimkiem.Text.Trim();
                String sql = "Select IDbenhnhan, Hovaten from Benhnhan Where IDbenhnhan=@IDbenhnhan or Hovaten=@Hovaten";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@IDbenhnhan", timkiem);
                cmd.Parameters.AddWithValue("@Hovaten", timkiem);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.SelectCommand = cmd;
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                conn.Close();
                grvThongtinbenhnhan.DataSource = dt;
                grvThongtinbenhnhan.Refresh();
            }catch (Exception ex)
            {
                MessageBox.Show("Thông tin cần tìm bị lỗi", "Thông báo");
            }
        }
    }
}
