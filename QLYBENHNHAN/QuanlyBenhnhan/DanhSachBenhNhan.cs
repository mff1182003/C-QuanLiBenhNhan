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
using e_excel = Microsoft.Office.Interop.Excel;

namespace QuanlyBenhnhan
{
    public partial class DanhSachBenhNhan : Form
    {
        public DanhSachBenhNhan()
        {
            InitializeComponent();
        }

        private void thêmBệnhNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThemBenhNhan TBN = new ThemBenhNhan();
            TBN.ShowDialog();
        }

        private void cậpNhậtToolStripMenuItem_Click(object sender, EventArgs e, CapNhatBenhNhan capNhatBenhNhan)
        {
            this.Hide();


            capNhatBenhNhan.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Trangchu trangchu = new Trangchu();
            trangchu.ShowDialog();
        }
        public void load_BenhNhan()
        {
            try
            {
                SqlConnection conn = new SqlConnection("Data Source=MSI\\SQLEXPRESS;Initial Catalog=Danhsachbenhnhan;Integrated Security=True");
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                String sql = "Select * From Benhnhan";
                SqlCommand cmd = new SqlCommand(@sql, conn);
                SqlDataAdapter adapter1 = new SqlDataAdapter(cmd);
                adapter1.SelectCommand = cmd;
                DataTable dt = new DataTable();
                adapter1.Fill(dt);
                conn.Close();
                GrvBenhNhan.DataSource = dt;
                GrvBenhNhan.Refresh();
            }
            catch (Exception ex) {
                MessageBox.Show("Hệ thống lỗi", "Thông báo");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DanhSachBenhNhan_Load(object sender, EventArgs e)
        {
            load_BenhNhan();
        }
        SqlConnection conn = new SqlConnection("Data Source=MSI\\SQLEXPRESS;Initial Catalog=Danhsachbenhnhan;Integrated Security=True");
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                String timkiem = txtTimkiem.Text.Trim();
                String sql = "Select * from Benhnhan Where IDbenhnhan=@IDbenhnhan or Hovaten=@Hovaten";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@IDbenhnhan", timkiem);
                cmd.Parameters.AddWithValue("@Hovaten", timkiem);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.SelectCommand = cmd;
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                conn.Close();
                GrvBenhNhan.DataSource = dt;
                GrvBenhNhan.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thông tin cần tìm bị lỗi", "Thông báo");
            }
        }

        private void xóaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            String ID = GrvBenhNhan.SelectedCells[0].Value.ToString();
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            string sql = "delete from Benhnhan where IDbenhnhan ='" + ID + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
            MessageBox.Show("Xóa thành công!");
            load_BenhNhan();
        }
        public void ExportExcel(DataTable tb, string sheetname)
        {
            //Tạo các đối tượng Excel
            try
            {
                e_excel.Application oExcel = new e_excel.Application();
                e_excel.Workbooks oBooks;
                e_excel.Sheets oSheets;
                e_excel.Workbook oBook;
                e_excel.Worksheet oSheet;
                //Tạo mới một Excel WorkBook 
                oExcel.Visible = true;
                oExcel.DisplayAlerts = false;
                oExcel.Application.SheetsInNewWorkbook = 1;
                oBooks = oExcel.Workbooks;
                oBook = (e_excel.Workbook)(oExcel.Workbooks.Add(Type.Missing));
                oSheets = oBook.Worksheets;
                oSheet = (e_excel.Worksheet)oSheets.get_Item(1);
                oSheet.Name = sheetname;
                // Tạo phần đầu nếu muốn
                e_excel.Range head = oSheet.get_Range("A1", "D1");
                head.MergeCells = true;
                head.Value2 = "DANH SÁCH BỆNH NHÂN";
                head.Font.Bold = true;
                head.Font.Name = "Tahoma";
                head.Font.Size = "16";
                head.HorizontalAlignment = e_excel.XlHAlign.xlHAlignCenter;
                // Tạo tiêu đề cột 
                e_excel.Range cl1 = oSheet.get_Range("A3", "A3");
                cl1.Value2 = "MÃ BỆNH NHÂN";
                cl1.ColumnWidth = 15.0;
                e_excel.Range cl2 = oSheet.get_Range("B3", "B3");
                cl2.Value2 = "HỌ VÀ TÊN";
                cl2.ColumnWidth = 25.0;
                e_excel.Range cl3 = oSheet.get_Range("C3", "C3");
                cl3.Value2 = "NGÀY SINH";
                cl3.ColumnWidth = 20.0;
                e_excel.Range cl3_1 = oSheet.get_Range("C4", "C1000");
                cl3_1.Columns.NumberFormat = "dd/mm/yyyy";
                e_excel.Range cl4 = oSheet.get_Range("D3", "D3");
                cl4.Value2 = "TUỔI";
                cl4.ColumnWidth = 10.0;
                e_excel.Range cl5 = oSheet.get_Range("E3", "E3");
                cl5.Value2 = "CCCD";
                cl5.ColumnWidth = 20.0;
                e_excel.Range cl6 = oSheet.get_Range("F3", "F3");
                cl6.Value2 = "GIỚI TÍNH";
                cl6.ColumnWidth = 15.0;
                e_excel.Range cl7 = oSheet.get_Range("G3", "G3");
                cl7.Value2 = "DÂN TỘC";
                cl7.ColumnWidth = 10.0;
                e_excel.Range cl8 = oSheet.get_Range("H3", "H3");
                cl8.Value2 = "SĐT";
                cl8.ColumnWidth = 10.0;
                e_excel.Range cl9 = oSheet.get_Range("I3", "I3");
                cl9.Value2 = "NGHỀ NGHIỆP";
                cl9.ColumnWidth = 20.0;
                e_excel.Range cl10 = oSheet.get_Range("J3", "J3");
                cl10.Value2 = "ĐỊA CHỈ";
                cl10.ColumnWidth = 30.0;
                e_excel.Range cl11 = oSheet.get_Range("K3", "K3");
                cl11.Value2 = "MÃ BHYT";
                cl11.ColumnWidth = 10.0;
                e_excel.Range cl12 = oSheet.get_Range("L3", "L3");
                cl12.Value2 = "LH KHẨN CẤP";
                cl12.ColumnWidth = 20.0;
                e_excel.Range cl13 = oSheet.get_Range("M3", "M3");
                cl13.Value2 = "NGÀY VÀO VIỆN";
                cl13.ColumnWidth = 20.0;
                e_excel.Range cl13_1 = oSheet.get_Range("M4", "M1000");
                cl13_1.Columns.NumberFormat = "dd/mm/yyyy";
                e_excel.Range cl14 = oSheet.get_Range("N3", "N3");
                cl14.Value2 = "NGÀY RA VIỆN";
                cl14.ColumnWidth = 20.0;
                e_excel.Range cl14_1 = oSheet.get_Range("N4", "N1000");
                cl14_1.Columns.NumberFormat = "dd/mm/yyyy";
                e_excel.Range cl15 = oSheet.get_Range("O3", "O3");
                cl15.Value2 = "KHOA NỘI TRÚ";
                cl15.ColumnWidth = 20.0;
                e_excel.Range cl16 = oSheet.get_Range("P3", "P3");
                cl16.Value2 = "BỆNH CHUẨN ĐOÁN";
                cl16.ColumnWidth = 30.0;
                //Microsoft.Office.Interop.Excel.Range cl6 = oSheet.get_Range("F3", "F3");
                //cl6.Value2 = "NGÀY THI";
                //cl6.ColumnWidth = 15.0;
                //Microsoft.Office.Interop.Excel.Range cl6_1 = oSheet.get_Range("F4", "F1000");
                //cl6_1.Columns.NumberFormat = "dd/mm/yyyy";

                e_excel.Range rowHead = oSheet.get_Range("A3", "Q3");
                rowHead.Font.Bold = true;
                // Kẻ viền
                rowHead.Borders.LineStyle = e_excel.Constants.xlSolid;
                // Thiết lập màu nền
                rowHead.Interior.ColorIndex = 15;
                rowHead.HorizontalAlignment = e_excel.XlHAlign.xlHAlignCenter;
                // Tạo mảng đối tượng để lưu dữ toàn bồ dữ liệu trong DataTable,
                // vì dữ liệu được được gán vào các Cell trong Excel phải thông qua object thuần.
                object[,] arr = new object[tb.Rows.Count, tb.Columns.Count];
                //Chuyển dữ liệu từ DataTable vào mảng đối tượng
                for (int r = 0; r < tb.Rows.Count; r++)
                {
                    DataRow dr = tb.Rows[r];
                    for (int c = 0; c < tb.Columns.Count; c++)

                    {
                        arr[r, c] = dr[c];
                    }
                }
                //Thiết lập vùng điền dữ liệu
                int rowStart = 4;
                int columnStart = 1;
                int rowEnd = rowStart + tb.Rows.Count - 1;
                int columnEnd = tb.Columns.Count;
                // Ô bắt đầu điền dữ liệu
                e_excel.Range c1 = (e_excel.Range)oSheet.Cells[rowStart, columnStart];
                // Ô kết thúc điền dữ liệu
                e_excel.Range c2 = (e_excel.Range)oSheet.Cells[rowEnd, columnEnd];
                // Lấy về vùng điền dữ liệu
                e_excel.Range range = oSheet.get_Range(c1, c2);
                //Điền dữ liệu vào vùng đã thiết lập
                range.Value2 = arr;
                // Kẻ viền
                range.Borders.LineStyle = e_excel.Constants.xlSolid;
                // Căn giữa cột STT
                e_excel.Range c3 = (e_excel.Range)oSheet.Cells[rowEnd, columnStart];
                e_excel.Range c4 = oSheet.get_Range(c1, c3);
                oSheet.get_Range(c3, c4).HorizontalAlignment = e_excel.XlHAlign.xlHAlignCenter;
            } catch (Exception ex)
            {
                MessageBox.Show("Lỗi không thể xuất Excel", "Thông báo");
            }
        }
        private void xuấtExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String sql = "Select * from Benhnhan";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            conn.Close();
            //Gọi phương thức exportExcel
            ExportExcel(dt, "Danh sách bệnh nhân");
        }

        private void GrvBenhNhan_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            try { 
                CapNhatBenhNhan capNhatBenhNhan = new CapNhatBenhNhan();
                capNhatBenhNhan.setID(GrvBenhNhan.SelectedCells[0].Value.ToString());
                capNhatBenhNhan.setHT(GrvBenhNhan.SelectedCells[1].Value.ToString());
                capNhatBenhNhan.setKhoa(GrvBenhNhan.SelectedCells[14].Value.ToString());
                capNhatBenhNhan.setDantoc(GrvBenhNhan.SelectedCells[6].Value.ToString());
                capNhatBenhNhan.setTuoi(GrvBenhNhan.SelectedCells[3].Value.ToString());
                capNhatBenhNhan.setSDT(GrvBenhNhan.SelectedCells[7].Value.ToString());
                capNhatBenhNhan.setCCCD(GrvBenhNhan.SelectedCells[4].Value.ToString());
                capNhatBenhNhan.setNghenghiep(GrvBenhNhan.SelectedCells[8].Value.ToString());
                capNhatBenhNhan.setDiachi(GrvBenhNhan.SelectedCells[9].Value.ToString());
                capNhatBenhNhan.setbhyt(GrvBenhNhan.SelectedCells[10].Value.ToString());
                capNhatBenhNhan.setlh(GrvBenhNhan.SelectedCells[11].Value.ToString());
                capNhatBenhNhan.setbenh(GrvBenhNhan.SelectedCells[15].Value.ToString());
                capNhatBenhNhan.ShowDialog();
            }
            catch(Exception ex)
            {
               MessageBox.Show("Mời nhấn vào mã bệnh nhân", "Thông báo");
            }
                
        }

            private void GrvBenhNhan_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {

            }

            private void cậpNhậtToolStripMenuItem_Click(object sender, EventArgs e)
            {
                CapNhatBenhNhan capNhatBenhNhan = new CapNhatBenhNhan();
                capNhatBenhNhan.setID(GrvBenhNhan.SelectedCells[0].Value.ToString());
                capNhatBenhNhan.ShowDialog();
            }
    }
}

