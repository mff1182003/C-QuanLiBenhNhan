using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using e_excel = Microsoft.Office.Interop.Excel;
namespace QuanlyBenhnhan
{
    public partial class HoadonPhong : Form
    {
        public HoadonPhong()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=MSI\\SQLEXPRESS;Initial Catalog=Danhsachbenhnhan;Integrated Security=True");
        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Close();
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string timkiem = txtTimkiem.Text;
                string lenh = " SELECT Benhnhan.IDbenhnhan, Benhnhan.Hovaten, Khoabenh.Tenkhoa, Phong.Tenphong, Giuong.Tengiuong, Giuong.Giaphong, Bill2.dateCheckIn, Bill.datecheckout,DATEDIFF(day, Bill2.dateCheckIn, Bill.datecheckout) as DATEDIFF , (DATEDIFF(day, Bill2.dateCheckIn, Bill.datecheckout) * Giuong.Giaphong) as Total, Benhnhan.CoBaoHiem FROM     Bill2 INNER JOIN Giuong ON Bill2.IDgiuong = Giuong.IDgiuong INNER JOIN   Phong ON Giuong.IDphong = Phong.IDphong INNER JOIN  Khoabenh ON Phong.IDkhoa = Khoabenh.IDkhoa INNER JOIN  Bill ON Giuong.IDgiuong = Bill.IDgiuong INNER JOIN Benhnhan ON Bill2.IDbenhnhan = Benhnhan.IDbenhnhan WHERE(Benhnhan.IDbenhnhan = N'" + timkiem + "') OR(Benhnhan.Hovaten = N'" + timkiem + "')";
                SqlCommand cmd = new SqlCommand(lenh, conn);
                cmd.Parameters.AddWithValue("@IDbenhnhan", timkiem);
                cmd.Parameters.AddWithValue("@Hovaten", timkiem);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                GrvXuat.DataSource = dt;
                GrvXuat.Refresh();
                SqlDataReader sqlDataReader = cmd.ExecuteReader();
                if (sqlDataReader.Read())
                {
                    txt1.Text = sqlDataReader.GetString(10);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi không thể tìm thấy bệnh nhân", "Thông báo");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Trangchu trangchu = new Trangchu();
            trangchu.ShowDialog();
        }
        private void btnExcel_Click(object sender, EventArgs e)
        {
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
                oSheet.Name = "sheetname";
                //Tiêu đề bệnh viện
                e_excel.Range bv = (e_excel.Range)oSheet.Cells[3, 2];
                bv.Font.Size = 10;
                bv.Font.Color = Color.Black;
                bv.Font.Italic = true;
                bv.Value = "BỆNH VIỆN NỘI TRÚ";
                // IN CHỮ HÓA ĐƠN
                e_excel.Range hd = (e_excel.Range)oSheet.Cells[5, 5];
                hd.Font.Size = 18;
                hd.Font.Bold = true;
                hd.Font.Color = Color.Black;
                hd.Value = "HÓA ĐƠN THANH TOÁN TIỀN GIƯỜNG";
                //IN TIÊU ĐỀ
                e_excel.Range cl1 = oSheet.Range["B8"];
                cl1.Value2 = "MÃ BỆNH NHÂN";
                cl1.ColumnWidth = 15.0;
                e_excel.Range cl2 = oSheet.Range["B9"];
                cl2.Value2 = "HỌ VÀ TÊN";
                cl2.ColumnWidth = 25.0;
                e_excel.Range rHead = oSheet.get_Range("B8", "C9");
                rHead.Font.Bold = true;
                // Kẻ viền
                rHead.Borders.LineStyle = e_excel.Constants.xlSolid;
                oSheet.Range["B11:J11"].Font.Size = 15;
                oSheet.Range["B11:J11"].Font.Bold = true;
                oSheet.Range["B11"].Value = "STT";
                e_excel.Range cl3 = oSheet.Range["C11"];
                cl3.Value2 = "TÊN KHOA";
                cl3.ColumnWidth = 20.0;
                e_excel.Range cl4 = oSheet.Range["D11"];
                cl4.Value2 = "TÊN PHÒNG";
                cl4.ColumnWidth = 20.0;
                e_excel.Range cl5 = oSheet.Range["E11"];
                cl5.Value2 = "TÊN GIƯỜNG";
                cl5.ColumnWidth = 20.0;
                e_excel.Range cl6 = oSheet.Range["F11"];
                cl6.Value2 = "GIÁ GIƯỜNG";
                cl6.ColumnWidth = 20.0;
                e_excel.Range cl7_1 = oSheet.Range["G11"];
                cl7_1.Value2 = "NGÀY NHẬN GIƯỜNG";
                cl7_1.ColumnWidth = 30.0;
                e_excel.Range cl7 = oSheet.get_Range("G12", "G100");
                cl7.Columns.NumberFormat = "dd/mm/yyyy";
                e_excel.Range cl8_1 = oSheet.Range["H11"];
                cl8_1.Value2 = "NGÀY TRẢ GIƯỜNG";
                e_excel.Range cl8 = oSheet.get_Range("H12", "H100");
                cl8.ColumnWidth = 30.0;
                cl8.Columns.NumberFormat = "dd/mm/yyyy";
                e_excel.Range cl9 = oSheet.Range["I11"];
                cl9.Value2 = "SỐ NGÀY Ở";
                cl9.ColumnWidth = 20;

                e_excel.Range rowBH = oSheet.get_Range("F9", "G9");
                rowBH.Borders.LineStyle = e_excel.Constants.xlSolid;
                
                if (txt1.Text == "30%")
                {
                    
                    oSheet.Range["F9"].Value = "Có bảo hiểm";
                    oSheet.Range["G9"].Value = 0.3;
                }
                else
                if (txt1.Text =="0%")
                {
                    oSheet.Range["F9"].Value = "Không có bảo hiểm";
                    oSheet.Range["G9"].Value ="0";
                }


                //
                e_excel.Range TOP = oSheet.get_Range("B10", "J10");
                e_excel.Range cl20 = oSheet.Range["C9"];
                cl20.ColumnWidth = 20.0;
                //IN DANH SÁCH

                int dong = 12;
                int cach = dong + GrvXuat.Rows.Count;
                for (int i = 0; i < GrvXuat.Rows.Count - 1; i++)
                {
                    double a = 0;
                    oSheet.Range["B" + (dong + i).ToString()].Value = (i + 1).ToString();
                    oSheet.Range["C8"].Value = GrvXuat.Rows[i].Cells[0].Value.ToString();
                    oSheet.Range["C9"].Value ="=TRIM(I"+(cach+1000) +")";
                    oSheet.Range["G9"].Value= GrvXuat.Rows[i].Cells[10].Value.ToString();
                    oSheet.Range["I" + (cach + 1000).ToString()].Value = GrvXuat.Rows[i].Cells[1].Value.ToString();
                    oSheet.Range["C" + (dong + i).ToString()].Value = GrvXuat.Rows[i].Cells[2].Value.ToString();
                    oSheet.Range["D" + (dong + i).ToString()].Value = GrvXuat.Rows[i].Cells[3].Value.ToString();
                    oSheet.Range["E" + (dong + i).ToString()].Value = GrvXuat.Rows[i].Cells[4].Value.ToString();
                    oSheet.Range["F" + (dong + i).ToString()].Value = GrvXuat.Rows[i].Cells[5].Value.ToString() + "  Đồng";
                    oSheet.Range["G" + (dong + i).ToString()].Value = GrvXuat.Rows[i].Cells[6].Value.ToString();
                    oSheet.Range["H" + (dong + i).ToString()].Value = GrvXuat.Rows[i].Cells[7].Value.ToString();
                    oSheet.Range["I" + (dong + i).ToString()].Value = GrvXuat.Rows[i].Cells[8].Value.ToString()+"  Ngày";
                    double.TryParse(GrvXuat.Rows[i].Cells[9].Value.ToString(),out a) ;
                    oSheet.Range["I" + (cach).ToString()].Value= string.Format("{0:#,##0,###}", a)+"  Đồng";
                    oSheet.Range["H" + (cach + 1).ToString()].Value = "BẢO HIỂM HỖ TRỢ";
                    oSheet.Range["I" + (cach + 1).ToString()].Value = "=-G9*"+a;
                    oSheet.Range["I"+(cach+2).ToString()].Value= string.Format("{0:#,##0,###}", "=" + a + "-(G9*" + a + ")");
                }
                
                //căn giữa
                e_excel.Range c4 = oSheet.get_Range("A1", "Q1000");
                oSheet.get_Range("A1", "Q1000").HorizontalAlignment = e_excel.XlHAlign.xlHAlignCenter;
                //
                e_excel.Range rowHead = oSheet.get_Range("B11", "I" + (cach-1).ToString());
                //
                //Kẻ viền
                e_excel.Range range = oSheet.get_Range("A1:" + "J" + (cach + 8).ToString(), Type.Missing);
                range.BorderAround(Type.Missing, e_excel.XlBorderWeight.xlThick, e_excel.XlColorIndex.xlColorIndexAutomatic, Type.Missing);
                //
                rowHead.Borders.LineStyle = e_excel.Constants.xlSolid;
                oSheet.Range["H" + cach.ToString()].Value = "TỔNG TIỀN";
                oSheet.Range["H" + (cach+2).ToString()].Value = "THANH TOÁN";
                e_excel.Range rowHe = oSheet.get_Range("H"+(cach).ToString(), "I" + (cach+2).ToString());
                rowHe.Font.Bold = true;
                rowHe.Borders.LineStyle = e_excel.Constants.xlSolid;
                e_excel.Range cl10 = oSheet.Range["I"+cach.ToString()];
                cl10.ColumnWidth = 20.0;
                e_excel.Range rowHn = oSheet.get_Range("G" + (cach + 4).ToString());
                rowHn.Value = "Hà nội, ngày...";
                rowHn.Font.Size = 9;
                rowHn.Font.Color = Color.Black;
                rowHn.Font.Italic = true;
                e_excel.Range rowKY = oSheet.get_Range("G" + (cach + 5).ToString());
                rowKY.Value = "Người nộp tiền";
                rowKY.Font.Size = 10;
                rowHn.Font.Color = Color.Black;
                rowKY.Font.Italic = true;
                //ĐẶT TÊN SHEET
                oSheet.Name = "HD GIƯỜNG";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không tìm thấy thông tin", "Thông báo");
            }
        }
       
    }

}
