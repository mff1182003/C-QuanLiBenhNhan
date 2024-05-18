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
    public partial class ThemBenhNhan : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=MSI\\SQLEXPRESS;Initial Catalog=Danhsachbenhnhan;Integrated Security=True");
        public ThemBenhNhan()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            DanhSachBenhNhan danhSachBenhNhan = new DanhSachBenhNhan();
            danhSachBenhNhan.ShowDialog();
        }
        private int checkTrungid(String id, ref int kq)
        {
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand("ChecktrungIDbenhnhan", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter param = new SqlParameter("@ketqua", SqlDbType.Int);
            cmd.Parameters.Add("@IDBenhnhan", SqlDbType.NVarChar, 50).Value = id;
            cmd.Parameters.Add(param).Direction = ParameterDirection.Output;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
            kq = (int)param.Value;
            return kq;
        }
        public void loadDanToc()
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand("Select Dantoc from dantoc", conn);
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                cmd.Dispose();
                conn.Close();
                DataRow r = dt.NewRow();
                r["Dantoc"] = "--Chọn dân tộc--";
                dt.Rows.InsertAt(r, 0);
                CbDantoc.DataSource = dt;
                CbDantoc.DisplayMember = "Dantoc";
                CbDantoc.ValueMember = "Dantoc";
            }catch(Exception ex)
            {
                MessageBox.Show("Lỗi cập nhật", "Thông báo");
            }
        }
        public void loadKhoaBenh()
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
                r["Tenkhoa"] = "--Chọn khoa bệnh--";
                dt.Rows.InsertAt(r, 0);
                cbKhoa.DataSource = dt;
                cbKhoa.DisplayMember = "Tenkhoa";
                cbKhoa.ValueMember = "Tenkhoa";
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi cập nhật", "Thông báo");
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                String gt = "";
                String id = textIDBN.Text.Trim();
                if (textIDBN.Text.Trim() == "")
                {
                    textIDBN.Focus();
                    MessageBox.Show("ID Trống?");
                    return;
                }
                int kq = 0;
                checkTrungid(id, ref kq);
                if (kq == 1)
                {
                    textIDBN.Focus();
                    MessageBox.Show("ID đã tồn tại!");
                    return;
                }
                String hoten = txtHoTen.Text.Trim();
                if (txtHoTen.Text.Trim() == "")
                {
                    txtHoTen.Focus();
                    MessageBox.Show("Họ tên Trống?");
                    return;
                }
                String ngaysinh = dateNgaysinh.Value.ToString();
                int tuoi = int.Parse(txtTuoi.Text.Trim());
                if (txtTuoi.Text.Trim() == "")
                {
                    txtTuoi.Focus();
                    MessageBox.Show("Nhập tuổi?", "Thông báo");
                    return;
                }
                String nghe = txtNgheNghiep.Text.Trim();
                if (txtNgheNghiep.Text.Trim() == "")
                {
                    txtNgheNghiep.Focus();
                    MessageBox.Show("Nhập nghề nghiệp?", "Thông báo");
                    return;
                }
                int lh = int.Parse(txtLH.Text.Trim());
                if (txtLH.Text.Trim() == "")
                {
                    txtLH.Focus();
                    MessageBox.Show("Nhập liên hệ?", "Thông báo");
                    return;
                }

                String nt = cbKhoa.SelectedValue.ToString();
                double cccd = double.Parse(txtCCCD.Text.Trim());
                String dc = txtDiaChi.Text.Trim();
                if (txtDiaChi.Text.Trim() == "")
                {
                    txtDiaChi.Focus();
                    MessageBox.Show("Nhập Địa chỉ?", "Thông báo");
                    return;
                }
                String bhyt = txtBHYT.Text.Trim();
                if (chkBaohiem.Checked == false) { bhyt = "Không có"; }
                else if (chkBaohiem.Checked == true)
                {
                    if (txtBHYT.Text.Trim() == "")
                    {
                        txtBHYT.Focus();
                        MessageBox.Show("Nhâp mã bảo hiểm");
                        return;
                    }
                }
                String benh = txtBenh.Text.Trim();

                if (radNam.Checked == null && radNu.Checked == null)
                {
                    MessageBox.Show("Mời chọn giới tính", "Thông báo");
                }
                else if (radNam.Checked == true)
                {
                    gt = "Nam";
                }
                else if (radNu.Checked == true)
                {
                    gt = "Nữ";
                }
                String dantoc = CbDantoc.SelectedValue.ToString();
                String nv = dateNgayVao.Value.ToString();
                String nr = dateNgayRa.Value.ToString();
                if (DateTime.Compare(DateTime.Parse(nv), DateTime.Parse(nr)) > 0)
                {
                    MessageBox.Show("Mời nhập lại, ngày vào phải nhỏ hơn ngày ra", "Thông báo");
                }
                else
                {
                    int sdt = int.Parse(txtSDT.Text.Trim());
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    string a = "";
                    if (chkBaohiem.Checked == true)
                    {
                        a = "30%";
                    }
                    if (chkBaohiem.Checked == false)
                    {
                        a = "0%";
                    }
                    SqlCommand cmd = new SqlCommand("Benhnhan_ins", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@IDbenhnhan", SqlDbType.NVarChar, 50).Value = id;
                    cmd.Parameters.Add("@Hovaten", SqlDbType.NVarChar, 50).Value = hoten;
                    cmd.Parameters.Add("@Ngaysinh", SqlDbType.Date).Value = ngaysinh;
                    cmd.Parameters.Add("@Tuoi", SqlDbType.Int).Value = tuoi;
                    cmd.Parameters.Add("@CCCD", SqlDbType.Int).Value = cccd;
                    cmd.Parameters.Add("@Gioitinh", SqlDbType.NVarChar, 50).Value = gt;
                    cmd.Parameters.Add("@Dantoc", SqlDbType.NVarChar, 50).Value = dantoc;
                    cmd.Parameters.Add("@Sodienthoai", SqlDbType.Int).Value = sdt;
                    cmd.Parameters.Add("@Nghenghiep", SqlDbType.NVarChar, 50).Value = nghe;
                    cmd.Parameters.Add("@Diachi", SqlDbType.NVarChar, 50).Value = dc;
                    cmd.Parameters.Add("@MaBHYT", SqlDbType.NVarChar, 50).Value = bhyt;
                    cmd.Parameters.Add("@Lienhekhancap", SqlDbType.Int).Value = lh;
                    cmd.Parameters.Add("@Ngayvaovien", SqlDbType.Date).Value = nv;
                    cmd.Parameters.Add("@Ngayravien", SqlDbType.Date).Value = nr;
                    cmd.Parameters.Add("@Khoanoitru", SqlDbType.NVarChar, 50).Value = nt;
                    cmd.Parameters.Add("@Benhchuandoan", SqlDbType.NVarChar, 50).Value = benh;
                    cmd.Parameters.Add("@CoBaoHiem", SqlDbType.NVarChar, 100).Value = a;
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    conn.Close();
                    MessageBox.Show("Thêm Thành công!");
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Kiểm tra lại thông tin", "Thông báo");
            }
            
        }

        private void ThemBenhNhan_Load(object sender, EventArgs e)
        {
            loadDanToc();
            loadKhoaBenh();
        }

        private void radNam_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkBaohiem_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBaohiem.Checked == true) { txtBHYT.ReadOnly =false; }
            if(chkBaohiem.Checked == false) { txtBHYT.ReadOnly=true; }
        }

        private void dateNgaysinh_ValueChanged(object sender, EventArgs e)
        {
            string now = DateTime.Now.ToString();
            string nv = dateNgaysinh.Text.Trim();
            if (DateTime.Compare(DateTime.Parse(nv), DateTime.Parse(now)) > 0)
            {
                MessageBox.Show("Mời nhập lại, ngày sinh nhỏ hơn hôm nay", "Thông báo");
            }
        }
    }
}


