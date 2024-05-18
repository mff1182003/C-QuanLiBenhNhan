using Microsoft.Office.Interop.Excel;
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
    public partial class HoaDonThuoc : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=MSI\\SQLEXPRESS;Initial Catalog=Danhsachbenhnhan;Integrated Security=True");
        public HoaDonThuoc()
        {
            InitializeComponent();
        }
 
        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            try {
                conn.Open();
                string timkiem = txtTimkiem.Text;
                string sql = "SELECT Benhnhan.IDbenhnhan, Benhnhan.Hovaten, Thuoc1.Tenthuoc, Thuoc1.Gia, Bill3.Soluong, (Thuoc1.Gia*Bill3.Soluong) as ToTal, Benhnhan.CoBaoHiem FROM Bill3 INNER JOIN Benhnhan ON Bill3.IDbenhnhan = Benhnhan.IDbenhnhan INNER JOIN Thuoc1 ON Bill3.IDthuoc = Thuoc1.IDthuoc WHERE(Benhnhan.IDbenhnhan = N'" + timkiem + "') OR (Benhnhan.Hovaten = N'" + timkiem + "')";
                SqlCommand sqlCommand = new SqlCommand(sql, conn);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
                sqlDataAdapter.SelectCommand = sqlCommand;
                System.Data.DataTable dt2 = new System.Data.DataTable();
                sqlDataAdapter.Fill(dt2);
                grvthuoc.DataSource = dt2;
                grvthuoc.Refresh();

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                if (sqlDataReader.Read())
                {
                    txt1.Text = sqlDataReader.GetString(6);
                }
                Tongtien();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không tìm thấy thông tin", "Thông báo");
            } 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                Trangchu trangchu = new Trangchu();
                trangchu.ShowDialog();
            }
            catch (Exception ex)
            {
            }
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
                //tiêu đề bệnh viện
                e_excel.Range bv = (e_excel.Range)oSheet.Cells[3, 2];
                bv.Font.Size = 10;
                bv.Font.Color = Color.Black;
                bv.Font.Italic = true;
                bv.Value = "BỆNH VIỆN NỘI TRÚ";
          
                // IN CHỮ HÓA ĐƠN
                e_excel.Range hd = (e_excel.Range)oSheet.Cells[5,4];
                hd.Font.Size = 12;
                hd.Font.Bold = true;
                hd.Font.Color = Color.Black;
                hd.Value = "HÓA ĐƠN THANH TOÁN TIỀN THUỐC";
                //IN TIÊU ĐỀ
                e_excel.Range cl1 = oSheet.Range["B8"];
                cl1.Value2 = "MÃ BỆNH NHÂN";
                cl1.ColumnWidth = 15.0;
                e_excel.Range cl2 = oSheet.Range["B9"];
                cl2.Value2 = "HỌ VÀ TÊN";
                cl2.ColumnWidth = 25.0;
                e_excel.Range rHead = oSheet.get_Range("B8","C9");
                rHead.Font.Bold = true;
                // Kẻ viền
                rHead.Borders.LineStyle = e_excel.Constants.xlSolid;
                oSheet.Range["B11:F11"].Font.Size = 15;
                oSheet.Range["B11:F11"].Font.Bold = true;
                oSheet.Range["B11"].Value = "STT";
                e_excel.Range cl3 = oSheet.Range["C11"];
                cl3.Value2 = "TÊN THUỐC";
                cl3.ColumnWidth = 20.0;
                e_excel.Range cl4 = oSheet.Range["D11"];
                cl4.Value2 = "SỐ LƯỢNG";
                cl4.ColumnWidth = 20.0;
                e_excel.Range cl5 = oSheet.Range["E11"];
                cl5.Value2 = "GIÁ THUỐC";
                cl5.ColumnWidth = 20.0;
                e_excel.Range cl6 = oSheet.Range["F11"];
                cl6.Value2 = "THÀNH TIỀN";
                cl6.ColumnWidth = 20.0;
                e_excel.Range TOP = oSheet.get_Range("B10", "E10");
                e_excel.Range cl9 = oSheet.Range["B9"];
                cl9.ColumnWidth = 20.0;
                //IN DANH SÁCH
                if (txt1.Text == "30%")
                {

                    oSheet.Range["E10"].Value = "Có bảo hiểm";
                    oSheet.Range["F10"].Value = 0.3;
                }
                else
                if (txt1.Text == "0%")
                {
                    oSheet.Range["E10"].Value = "Không có bảo hiểm";
                    oSheet.Range["F10"].Value = "0";
                }
                e_excel.Range Bh = oSheet.get_Range("E10", "F10");
                Bh.Borders.LineStyle = e_excel.Constants.xlSolid;
                Bh.Font.Bold = true;
                int dong = 12;
                int cach = dong + grvthuoc.Rows.Count;
                for (int i = 0; i < grvthuoc.Rows.Count - 1; i++)
                {
                    oSheet.Range["B" + (dong + i).ToString()].Value = (i + 1).ToString();
                    oSheet.Range["C8"].Value = grvthuoc.Rows[i].Cells[0].Value.ToString();
                    oSheet.Range["C9"].Value = "=TRIM(I" + (cach + 1000) + ")";
                    oSheet.Range["I"+(cach+1000)].Value = grvthuoc.Rows[i].Cells[1].Value.ToString();
                    oSheet.Range["C" + (dong + i).ToString()].Value = grvthuoc.Rows[i].Cells[2].Value.ToString();
                    oSheet.Range["D" + (dong + i).ToString()].Value = grvthuoc.Rows[i].Cells[3].Value.ToString();
                    oSheet.Range["E" + (dong + i).ToString()].Value = grvthuoc.Rows[i].Cells[4].Value.ToString() ;
                    oSheet.Range["F" + (dong + i).ToString()].Value = grvthuoc.Rows[i].Cells[5].Value.ToString() ;
                    oSheet.Range["F"+(cach).ToString()].Value="=sum(F"+(dong).ToString()+":"+"F"+(cach-1).ToString()+")";
                    oSheet.Range["F" + (cach+1).ToString()].Value="=-(F"+cach.ToString()+"*"+"F10)";
                }
                
                //căn giữa
                e_excel.Range c4 = oSheet.get_Range("A1", "Q1000");
                oSheet.get_Range("A1", "Q1000").HorizontalAlignment = e_excel.XlHAlign.xlHAlignCenter;
                //
                e_excel.Range rowHead = oSheet.get_Range("B11", "F"+(cach-2).ToString());
                rowHead.Borders.LineStyle = e_excel.Constants.xlSolid;
                rowHead.Font.Bold = true;
                e_excel.Range rowHe = oSheet.get_Range("E"+(cach).ToString(), "F" + (cach+2).ToString());
                rowHe.Borders.LineStyle = e_excel.Constants.xlSolid;
                rowHe.Font.Bold = true;
                // Kẻ viền

                e_excel.Range range = oSheet.get_Range("A1:"+ "G" + (cach + 8).ToString(), Type.Missing);
                range.BorderAround(Type.Missing, e_excel.XlBorderWeight.xlThick, e_excel.XlColorIndex.xlColorIndexAutomatic, Type.Missing);
                //
                oSheet.Range["E" + (cach+1).ToString()].Value = "BẢO HIỂM HỖ TRỢ";
                oSheet.Range["E" + (cach).ToString()].Value = "=E10";
                oSheet.Range["E" + (cach).ToString()].Value = "TỔNG TIỀN";
                oSheet.Range["E" + (cach+2).ToString()].Value = "THANH TOÁN";
                oSheet.Range["F" + (cach+2).ToString()].Value = LBTongtien.Text;
                oSheet.Name = "HD";
                e_excel.Range rowHn = oSheet.get_Range("E" + (cach + 4).ToString());
                rowHn.Value = "Hà nội, ngày...";
                rowHn.Font.Size = 9;
                rowHn.Font.Color = Color.Black;
                rowHn.Font.Italic = true;
                e_excel.Range rowKY = oSheet.get_Range("E" + (cach + 5).ToString());
                rowKY.Value = "Người nộp tiền";
                rowKY.Font.Size = 10;
                rowHn.Font.Color = Color.Black;
                rowKY.Font.Italic = true;
                oSheet.Name = "HD THUỐC";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi không xuất được", "Thông báo");
            }
        }
        private void Tongtien()
        {
            try
            {
                double Tongtien = 0;
                double giagiuong = 0;

                for (int i = 0; i < grvthuoc.Rows.Count; i++)
                {
                    if (grvthuoc.Rows[i].Cells["count"] != null && grvthuoc.Rows[i].Cells["giathuoc"] != null && grvthuoc.Rows[i].Cells["CoBaoHiem"]!=null)
                    {
                        double Thanhtien = 0;
                        double soluong = 0;
                        double giathuoc = 0;
                        double giamgia = 0;
                        if (double.TryParse(grvthuoc.Rows[i].Cells["count"].Value?.ToString(), out soluong) &&
                            double.TryParse(grvthuoc.Rows[i].Cells["giathuoc"].Value?.ToString(), out giathuoc))
                        {
                            Thanhtien = soluong * giathuoc;
                            Tongtien += Thanhtien;
                        }
                    }
                }
                double a=0;
                if(txt1.Text=="0%")
                {
                    giagiuong = Tongtien;
                }else
                if (txt1.Text=="30%")
                {
                    a = Tongtien * 0.3;
                    giagiuong = Tongtien - a;
                }
                LBTongtien.Text  = giagiuong.ToString("N0")+" Đồng ";
                //nhập dữ liệu vào DB thành tiền

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi! thử lại", "Thông báo");
            }
        }


        private void grvthuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}

