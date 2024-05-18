using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanlyBenhnhan
{
    public partial class CapNhatBenhNhan : Form
    {
        public CapNhatBenhNhan()
        {
            InitializeComponent();
        }
    
        private String ID;
        private string A;
        private void setA(String hoTen)
        {
            this.A = hoTen;
        }
        public void setID(String IDBN)
        {
            this.ID = IDBN;
        }
        private string CCCD;
        public void setCCCD(String cccd)
        {
            this.CCCD = cccd;
        }
        private string Tuoi;
        public void setTuoi(String tuoi)
        {
            this.Tuoi = tuoi;
        }
        private string ht;
        public void setHT(string ht)
        {
            this.ht = ht;
        }
        private string Sdt;
        public void setSDT(String sDT)
        {
            this.Sdt = sDT;
        }
        private string NgheNghiep;
        public void setNghenghiep(String nGheNghiep)
        {
            this.NgheNghiep = nGheNghiep;
        }
        private string DiaChi;
        public void setDiachi(String diachi)
        {
            this.DiaChi = diachi;
        }
        private string BHYT;
        public void setbhyt(string Bhyt)
        {
            this.BHYT = Bhyt;
        }
        private string LH;
        public void setlh(string Lh)
        {
            this.LH = Lh;
        }
        private string Benh;
        public void setbenh(string BENH)
        {
            this.Benh = BENH;
        }
        private string Khoa;
        public void setKhoa(string khoa)
        {
            this.Khoa = khoa;
        }
        private string dantoc;
        public void setDantoc(string Dantoc)
        {
            this.dantoc = Dantoc;
        }
        
        SqlConnection conn = new SqlConnection("Data Source=MSI\\SQLEXPRESS;Initial Catalog=Danhsachbenhnhan;Integrated Security=True");
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            DanhSachBenhNhan danhSachBenhNhan=new DanhSachBenhNhan();
            danhSachBenhNhan.ShowDialog();
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
            }
            catch (Exception ex)
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
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi cập nhật", "Thông báo");
            }
        }
        private void CapNhatBenhNhan_Load(object sender, EventArgs e)
        {
           
            cbKhoa.SelectedItem = Khoa;
            txtIDBN.Text=ID;
            txtHoTen.Text = ht;
            txtCCCD.Text=CCCD;
            txtTuoi.Text=Tuoi;
            txtDiaChi.Text=DiaChi;
            txtBenh.Text=Benh;
            txtBHYT.Text=BHYT;
            txtLH.Text=LH;
            txtNgheNghiep.Text=NgheNghiep;
            txtSDT.Text = Sdt;
            loadDanToc();
            loadKhoaBenh();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            try {
                
                

                CbDantoc.Text = "Kinh";
                String id = txtIDBN.Text.Trim();
                int kq = 0;

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
                String nv = dateNgayVao.Value.ToString();
                String nt = cbKhoa.SelectedValue.ToString();
                if(cbKhoa.Text== "--Chọn khoa bệnh--")
                {
                    
                        nt = "Khoa nội";
                   
                }
                double cccd = double.Parse(txtCCCD.Text.Trim());
                String dc = txtDiaChi.Text.Trim();
                if (txtDiaChi.Text.Trim() == "")
                {
                    txtDiaChi.Focus();
                    MessageBox.Show("Nhập địa chỉ?", "Thông báo");
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
                String gt = "";
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
                if (CbDantoc.Text.ToString()== "--Chọn dân tộc--") {
                    dantoc = "Kinh";
                }
                int sdt = int.Parse(txtSDT.Text.Trim());
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string a = " ";
                if (chkBaohiem.Checked == true)
                {
                    a = "30%";
                }
                if (chkBaohiem.Checked == false)
                {
                    a = "0%";
                }
                String nr = dateNgayRa.Value.ToString();
                if (DateTime.Compare(DateTime.Parse(nv), DateTime.Parse(nr)) >= 0)
                {
                    MessageBox.Show("Mời nhập lại, ngày vào phải nhỏ hơn ngày ra", "Thông báo");
                }
                else
                {
                   
                    SqlCommand cmd = new SqlCommand("Benhnhan_upd", conn);
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
                    MessageBox.Show("Sửa thành công!");
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi thử lại sau", "Thông báo"); } 
        }
           
        private void radNu_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkBaohiem_CheckedChanged(object sender, EventArgs e)
        {
            if(chkBaohiem.Checked==true) { txtBHYT.ReadOnly = false; }
        }

        private void txtBHYT_TextChanged(object sender, EventArgs e)
        {
            if (txtBHYT.Text!=null) { chkBaohiem.Checked = true; }
        }

        private void CbDantoc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateNgaysinh_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
