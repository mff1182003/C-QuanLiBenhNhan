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
    public partial class TraGiuong : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=MSI\\SQLEXPRESS;Initial Catalog=Danhsachbenhnhan;Integrated Security=True");
        public TraGiuong()
        {
            InitializeComponent();
        }
        private String IDgiuong;
        public void setIDgiuong(String IDGiuong)
        {
            this.IDgiuong = IDGiuong;
        }
        private string Ngaynhan;
        public void setngaynhan(String ngaynhan)
        {
            this.Ngaynhan = ngaynhan;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            PhongDaCap phongDaCap = new PhongDaCap();
            phongDaCap.ShowDialog();
        }
        public void Tragiuong()
        {
            try
            {
                string idBill = txtIDbill.Text.Trim();
                string idGuong = lbIDgiuong.Text.Trim();
                string status = "Trống";
                string ngaytra = dateNgaytra.Text.Trim();
                string IDbenhnhan = " ";
                conn.Open();

                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                //Nhập vào store dữ liệu
                SqlCommand cmd = new SqlCommand("[Bill_ins]", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@idBill", SqlDbType.NVarChar, 50).Value = idBill;
                cmd.Parameters.Add("@datecheckout", SqlDbType.Date).Value = ngaytra;
                cmd.Parameters.Add("@IDgiuong", SqlDbType.NVarChar, 50).Value = idGuong;
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                //nhập vào bảng giường trạng thái
                MessageBox.Show("Thành công!", "Thông báo trả giường");
                string lenh = "update Giuong set Status=N'" + status + "', IDbenhnhan='" + IDbenhnhan + "'where IDgiuong='" + idGuong + "'";
                SqlCommand command = new SqlCommand(lenh, conn);
                command.ExecuteNonQuery();
                command.Dispose();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Trả giường không thành công! Thử lại", "Thông báo");
            }
        }
        public void sosanh()
        {
           

        }
        private void button1_Click(object sender, EventArgs e)
        {


            string nv=  DateTime.Now.ToString();
            string nr=dateNgaytra.Text.Trim();
                if (DateTime.Compare(DateTime.Parse(nv), DateTime.Parse(nr)) >= 0)
                {
                    MessageBox.Show("Mời nhập lại, ngày trả lớn hơn ngày trả", "Thông báo");
                }
                else
                {
                    Tragiuong();
                }
        }

        private void TraGiuong_Load(object sender, EventArgs e)
        {
            lbIDgiuong.Text = IDgiuong;
        }
    }
}
