namespace QuanlyBenhnhan
{
    partial class Trangchu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Trangchu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.GrvBenhNhan = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tuoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCCD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dantoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sodienthoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nghenghiep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaBHYT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lienhekhancap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngayvaovien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngayravien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Benhchuandoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.danhSáchBệnhNhânToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchPhòngToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýThuốcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cấpThuốcToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.xuấtHóaĐơnToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.hoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hóaĐơnThuốcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrvBenhNhan)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.GrvBenhNhan);
            this.panel1.Controls.Add(this.btnTimKiem);
            this.panel1.Controls.Add(this.txtTimkiem);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(9, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1141, 665);
            this.panel1.TabIndex = 27;
            // 
            // GrvBenhNhan
            // 
            this.GrvBenhNhan.BackgroundColor = System.Drawing.Color.White;
            this.GrvBenhNhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrvBenhNhan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.Ngaysinh,
            this.Tuoi,
            this.CCCD,
            this.Gioitinh,
            this.Dantoc,
            this.Sodienthoai,
            this.Nghenghiep,
            this.Diachi,
            this.MaBHYT,
            this.Lienhekhancap,
            this.Ngayvaovien,
            this.Ngayravien,
            this.dataGridViewTextBoxColumn3,
            this.Benhchuandoan});
            this.GrvBenhNhan.Location = new System.Drawing.Point(3, 151);
            this.GrvBenhNhan.Name = "GrvBenhNhan";
            this.GrvBenhNhan.RowHeadersWidth = 51;
            this.GrvBenhNhan.RowTemplate.Height = 24;
            this.GrvBenhNhan.Size = new System.Drawing.Size(1135, 511);
            this.GrvBenhNhan.TabIndex = 183;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IDbenhnhan";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID Bệnh nhân";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Hovaten";
            this.dataGridViewTextBoxColumn2.HeaderText = "Họ và tên";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // Ngaysinh
            // 
            this.Ngaysinh.DataPropertyName = "Ngaysinh";
            this.Ngaysinh.HeaderText = "Ngày sinh";
            this.Ngaysinh.MinimumWidth = 6;
            this.Ngaysinh.Name = "Ngaysinh";
            this.Ngaysinh.Width = 125;
            // 
            // Tuoi
            // 
            this.Tuoi.DataPropertyName = "Tuoi";
            this.Tuoi.HeaderText = "Tuổi";
            this.Tuoi.MinimumWidth = 6;
            this.Tuoi.Name = "Tuoi";
            this.Tuoi.Width = 125;
            // 
            // CCCD
            // 
            this.CCCD.DataPropertyName = "CCCD";
            this.CCCD.HeaderText = "CCCD";
            this.CCCD.MinimumWidth = 6;
            this.CCCD.Name = "CCCD";
            this.CCCD.Width = 125;
            // 
            // Gioitinh
            // 
            this.Gioitinh.DataPropertyName = "Gioitinh";
            this.Gioitinh.HeaderText = "Giới tính";
            this.Gioitinh.MinimumWidth = 6;
            this.Gioitinh.Name = "Gioitinh";
            this.Gioitinh.Width = 125;
            // 
            // Dantoc
            // 
            this.Dantoc.DataPropertyName = "Dantoc";
            this.Dantoc.HeaderText = "Dân tộc";
            this.Dantoc.MinimumWidth = 6;
            this.Dantoc.Name = "Dantoc";
            this.Dantoc.Width = 125;
            // 
            // Sodienthoai
            // 
            this.Sodienthoai.DataPropertyName = "Sodienthoai";
            this.Sodienthoai.HeaderText = "Số điện thoại";
            this.Sodienthoai.MinimumWidth = 6;
            this.Sodienthoai.Name = "Sodienthoai";
            this.Sodienthoai.Width = 125;
            // 
            // Nghenghiep
            // 
            this.Nghenghiep.DataPropertyName = "Nghenghiep";
            this.Nghenghiep.HeaderText = "Nghề nghiệp";
            this.Nghenghiep.MinimumWidth = 6;
            this.Nghenghiep.Name = "Nghenghiep";
            this.Nghenghiep.Width = 125;
            // 
            // Diachi
            // 
            this.Diachi.DataPropertyName = "Diachi";
            this.Diachi.HeaderText = "Địa chỉ ";
            this.Diachi.MinimumWidth = 6;
            this.Diachi.Name = "Diachi";
            this.Diachi.Width = 125;
            // 
            // MaBHYT
            // 
            this.MaBHYT.DataPropertyName = "MaBHYT";
            this.MaBHYT.HeaderText = "Mã BHYT";
            this.MaBHYT.MinimumWidth = 6;
            this.MaBHYT.Name = "MaBHYT";
            this.MaBHYT.Width = 125;
            // 
            // Lienhekhancap
            // 
            this.Lienhekhancap.DataPropertyName = "Lienhekhancap";
            this.Lienhekhancap.HeaderText = "Liên hệ khẩn cấp";
            this.Lienhekhancap.MinimumWidth = 6;
            this.Lienhekhancap.Name = "Lienhekhancap";
            this.Lienhekhancap.Width = 125;
            // 
            // Ngayvaovien
            // 
            this.Ngayvaovien.DataPropertyName = "Ngayvaovien";
            this.Ngayvaovien.HeaderText = "Ngày vào viện";
            this.Ngayvaovien.MinimumWidth = 6;
            this.Ngayvaovien.Name = "Ngayvaovien";
            this.Ngayvaovien.Width = 125;
            // 
            // Ngayravien
            // 
            this.Ngayravien.DataPropertyName = "Ngayravien";
            this.Ngayravien.HeaderText = "Ngày ra viện";
            this.Ngayravien.MinimumWidth = 6;
            this.Ngayravien.Name = "Ngayravien";
            this.Ngayravien.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Khoanoitru";
            this.dataGridViewTextBoxColumn3.HeaderText = "Khoa nội trú";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // Benhchuandoan
            // 
            this.Benhchuandoan.DataPropertyName = "Benhchuandoan";
            this.Benhchuandoan.HeaderText = "Bệnh chuẩn đoán";
            this.Benhchuandoan.MinimumWidth = 6;
            this.Benhchuandoan.Name = "Benhchuandoan";
            this.Benhchuandoan.Width = 125;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(866, 94);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(178, 32);
            this.btnTimKiem.TabIndex = 180;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.Location = new System.Drawing.Point(629, 94);
            this.txtTimkiem.Multiline = true;
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(214, 32);
            this.txtTimkiem.TabIndex = 179;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhSáchBệnhNhânToolStripMenuItem2,
            this.danhSáchPhòngToolStripMenuItem1,
            this.quảnLýThuốcToolStripMenuItem,
            this.cấpThuốcToolStripMenuItem2,
            this.xuấtHóaĐơnToolStripMenuItem2,
            this.đăngXuấtToolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1141, 30);
            this.menuStrip1.TabIndex = 27;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // danhSáchBệnhNhânToolStripMenuItem2
            // 
            this.danhSáchBệnhNhânToolStripMenuItem2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.danhSáchBệnhNhânToolStripMenuItem2.Name = "danhSáchBệnhNhânToolStripMenuItem2";
            this.danhSáchBệnhNhânToolStripMenuItem2.Size = new System.Drawing.Size(188, 26);
            this.danhSáchBệnhNhânToolStripMenuItem2.Text = "Danh sách bệnh nhân";
            this.danhSáchBệnhNhânToolStripMenuItem2.Click += new System.EventHandler(this.danhSáchBệnhNhânToolStripMenuItem2_Click);
            // 
            // danhSáchPhòngToolStripMenuItem1
            // 
            this.danhSáchPhòngToolStripMenuItem1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.danhSáchPhòngToolStripMenuItem1.Name = "danhSáchPhòngToolStripMenuItem1";
            this.danhSáchPhòngToolStripMenuItem1.Size = new System.Drawing.Size(157, 26);
            this.danhSáchPhòngToolStripMenuItem1.Text = "Danh sách phòng";
            this.danhSáchPhòngToolStripMenuItem1.Click += new System.EventHandler(this.danhSáchPhòngToolStripMenuItem1_Click);
            // 
            // quảnLýThuốcToolStripMenuItem
            // 
            this.quảnLýThuốcToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quảnLýThuốcToolStripMenuItem.Name = "quảnLýThuốcToolStripMenuItem";
            this.quảnLýThuốcToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.quảnLýThuốcToolStripMenuItem.Text = "Quản lý thuốc";
            this.quảnLýThuốcToolStripMenuItem.Click += new System.EventHandler(this.quảnLýThuốcToolStripMenuItem_Click_1);
            // 
            // cấpThuốcToolStripMenuItem2
            // 
            this.cấpThuốcToolStripMenuItem2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cấpThuốcToolStripMenuItem2.Name = "cấpThuốcToolStripMenuItem2";
            this.cấpThuốcToolStripMenuItem2.Size = new System.Drawing.Size(110, 26);
            this.cấpThuốcToolStripMenuItem2.Text = "Cấp Thuốc";
            this.cấpThuốcToolStripMenuItem2.Click += new System.EventHandler(this.cấpThuốcToolStripMenuItem2_Click);
            // 
            // xuấtHóaĐơnToolStripMenuItem2
            // 
            this.xuấtHóaĐơnToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hoToolStripMenuItem,
            this.hóaĐơnThuốcToolStripMenuItem});
            this.xuấtHóaĐơnToolStripMenuItem2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuấtHóaĐơnToolStripMenuItem2.Name = "xuấtHóaĐơnToolStripMenuItem2";
            this.xuấtHóaĐơnToolStripMenuItem2.Size = new System.Drawing.Size(138, 26);
            this.xuấtHóaĐơnToolStripMenuItem2.Text = "Xuất Hóa Đơn";
            this.xuấtHóaĐơnToolStripMenuItem2.Click += new System.EventHandler(this.xuấtHóaĐơnToolStripMenuItem2_Click);
            // 
            // hoToolStripMenuItem
            // 
            this.hoToolStripMenuItem.Name = "hoToolStripMenuItem";
            this.hoToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.hoToolStripMenuItem.Text = "Hóa đơn giường";
            this.hoToolStripMenuItem.Click += new System.EventHandler(this.hoToolStripMenuItem_Click);
            // 
            // hóaĐơnThuốcToolStripMenuItem
            // 
            this.hóaĐơnThuốcToolStripMenuItem.Name = "hóaĐơnThuốcToolStripMenuItem";
            this.hóaĐơnThuốcToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.hóaĐơnThuốcToolStripMenuItem.Text = "Hóa đơn thuốc";
            this.hóaĐơnThuốcToolStripMenuItem.Click += new System.EventHandler(this.hóaĐơnThuốcToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem2
            // 
            this.đăngXuấtToolStripMenuItem2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.đăngXuấtToolStripMenuItem2.Name = "đăngXuấtToolStripMenuItem2";
            this.đăngXuấtToolStripMenuItem2.Size = new System.Drawing.Size(102, 26);
            this.đăngXuấtToolStripMenuItem2.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem2.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem2_Click);
            // 
            // Trangchu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1197, 750);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Trangchu";
            this.Text = "Trang chủ";
            this.Load += new System.EventHandler(this.Trangchu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrvBenhNhan)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem danhSáchBệnhNhânToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem danhSáchPhòngToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýThuốcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cấpThuốcToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem xuấtHóaĐơnToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem2;
        private System.Windows.Forms.TextBox txtTimkiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.ToolStripMenuItem hoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hóaĐơnThuốcToolStripMenuItem;
        private System.Windows.Forms.DataGridView GrvBenhNhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tuoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCCD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dantoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sodienthoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nghenghiep;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBHYT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lienhekhancap;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngayvaovien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngayravien;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Benhchuandoan;
    }
}

