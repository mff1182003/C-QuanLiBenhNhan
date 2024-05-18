namespace QuanlyBenhnhan
{
    partial class DanhSachBenhNhan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DanhSachBenhNhan));
            this.GrvBenhNhan = new System.Windows.Forms.DataGridView();
            this.IDbenhnhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hovaten = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.Khoanoitru = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Benhchuandoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.thêmBệnhNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cậpNhậtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xuấtExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GrvBenhNhan)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrvBenhNhan
            // 
            this.GrvBenhNhan.BackgroundColor = System.Drawing.Color.White;
            this.GrvBenhNhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrvBenhNhan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDbenhnhan,
            this.Hovaten,
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
            this.Khoanoitru,
            this.Benhchuandoan});
            this.GrvBenhNhan.Location = new System.Drawing.Point(5, 116);
            this.GrvBenhNhan.Name = "GrvBenhNhan";
            this.GrvBenhNhan.RowHeadersWidth = 51;
            this.GrvBenhNhan.RowTemplate.Height = 24;
            this.GrvBenhNhan.Size = new System.Drawing.Size(1093, 392);
            this.GrvBenhNhan.TabIndex = 182;
            this.GrvBenhNhan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrvBenhNhan_CellClick);
            this.GrvBenhNhan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrvBenhNhan_CellContentClick);
            // 
            // IDbenhnhan
            // 
            this.IDbenhnhan.DataPropertyName = "IDbenhnhan";
            this.IDbenhnhan.HeaderText = "ID Bệnh nhân";
            this.IDbenhnhan.MinimumWidth = 6;
            this.IDbenhnhan.Name = "IDbenhnhan";
            this.IDbenhnhan.Width = 125;
            // 
            // Hovaten
            // 
            this.Hovaten.DataPropertyName = "Hovaten";
            this.Hovaten.HeaderText = "Họ và tên";
            this.Hovaten.MinimumWidth = 6;
            this.Hovaten.Name = "Hovaten";
            this.Hovaten.Width = 125;
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
            // Khoanoitru
            // 
            this.Khoanoitru.DataPropertyName = "Khoanoitru";
            this.Khoanoitru.HeaderText = "Khoa nội trú";
            this.Khoanoitru.MinimumWidth = 6;
            this.Khoanoitru.Name = "Khoanoitru";
            this.Khoanoitru.Width = 125;
            // 
            // Benhchuandoan
            // 
            this.Benhchuandoan.DataPropertyName = "Benhchuandoan";
            this.Benhchuandoan.HeaderText = "Bệnh chuẩn đoán";
            this.Benhchuandoan.MinimumWidth = 6;
            this.Benhchuandoan.Name = "Benhchuandoan";
            this.Benhchuandoan.Width = 125;
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimkiem.Location = new System.Drawing.Point(674, 3);
            this.txtTimkiem.Multiline = true;
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(218, 35);
            this.txtTimkiem.TabIndex = 178;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Location = new System.Drawing.Point(898, 3);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(200, 35);
            this.btnTimKiem.TabIndex = 175;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.GrvBenhNhan);
            this.panel1.Controls.Add(this.txtTimkiem);
            this.panel1.Controls.Add(this.btnTimKiem);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Location = new System.Drawing.Point(0, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1110, 534);
            this.panel1.TabIndex = 184;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmBệnhNhânToolStripMenuItem,
            this.cậpNhậtToolStripMenuItem,
            this.xóaToolStripMenuItem,
            this.xuấtExcelToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1110, 30);
            this.menuStrip1.TabIndex = 181;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // thêmBệnhNhânToolStripMenuItem
            // 
            this.thêmBệnhNhânToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thêmBệnhNhânToolStripMenuItem.Name = "thêmBệnhNhânToolStripMenuItem";
            this.thêmBệnhNhânToolStripMenuItem.Size = new System.Drawing.Size(151, 26);
            this.thêmBệnhNhânToolStripMenuItem.Text = "Thêm bệnh nhân";
            this.thêmBệnhNhânToolStripMenuItem.Click += new System.EventHandler(this.thêmBệnhNhânToolStripMenuItem_Click);
            // 
            // cậpNhậtToolStripMenuItem
            // 
            this.cậpNhậtToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cậpNhậtToolStripMenuItem.Name = "cậpNhậtToolStripMenuItem";
            this.cậpNhậtToolStripMenuItem.Size = new System.Drawing.Size(93, 26);
            this.cậpNhậtToolStripMenuItem.Text = "Cập nhật";
            this.cậpNhậtToolStripMenuItem.Click += new System.EventHandler(this.cậpNhậtToolStripMenuItem_Click);
            // 
            // xóaToolStripMenuItem
            // 
            this.xóaToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xóaToolStripMenuItem.Name = "xóaToolStripMenuItem";
            this.xóaToolStripMenuItem.Size = new System.Drawing.Size(57, 26);
            this.xóaToolStripMenuItem.Text = "Xóa";
            this.xóaToolStripMenuItem.Click += new System.EventHandler(this.xóaToolStripMenuItem_Click_1);
            // 
            // xuấtExcelToolStripMenuItem
            // 
            this.xuấtExcelToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuấtExcelToolStripMenuItem.Name = "xuấtExcelToolStripMenuItem";
            this.xuấtExcelToolStripMenuItem.Size = new System.Drawing.Size(108, 26);
            this.xuấtExcelToolStripMenuItem.Text = "Xuất excel";
            this.xuấtExcelToolStripMenuItem.Click += new System.EventHandler(this.xuấtExcelToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(629, 47);
            this.label1.TabIndex = 185;
            this.label1.Text = "DANH SÁCH BỆNH NHÂN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(970, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 35);
            this.button1.TabIndex = 195;
            this.button1.Text = "Quay lại";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DanhSachBenhNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1110, 579);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "DanhSachBenhNhan";
            this.Text = "DanhSachBenhNhan";
            this.Load += new System.EventHandler(this.DanhSachBenhNhan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrvBenhNhan)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView GrvBenhNhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDbenhnhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hovaten;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Khoanoitru;
        private System.Windows.Forms.DataGridViewTextBoxColumn Benhchuandoan;
        private System.Windows.Forms.TextBox txtTimkiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thêmBệnhNhânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cậpNhậtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xuấtExcelToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem xóaToolStripMenuItem;
    }
}