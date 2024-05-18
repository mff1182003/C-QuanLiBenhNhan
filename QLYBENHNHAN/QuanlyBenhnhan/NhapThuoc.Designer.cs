namespace QuanlyBenhnhan
{
    partial class NhapThuoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NhapThuoc));
            this.btnExit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grvCapthuoc = new System.Windows.Forms.DataGridView();
            this.idBill3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namethuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToTal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtIDhoadon = new System.Windows.Forms.TextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.nmSoluong = new System.Windows.Forms.NumericUpDown();
            this.IDbenh = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTimBenhNhan = new System.Windows.Forms.TextBox();
            this.txtTimThuoc = new System.Windows.Forms.TextBox();
            this.grvThuoc = new System.Windows.Forms.DataGridView();
            this.IDthuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tenthuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.GrvTen = new System.Windows.Forms.DataGridView();
            this.IDbenhnhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hovaten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvCapthuoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmSoluong)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvThuoc)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrvTen)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(892, -55);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(135, 32);
            this.btnExit.TabIndex = 188;
            this.btnExit.Text = "Quay lại";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(169, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "Mã hóa đơn";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grvCapthuoc);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtIDhoadon);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.nmSoluong);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(45, 318);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(961, 331);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Điền thông tin";
            // 
            // grvCapthuoc
            // 
            this.grvCapthuoc.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grvCapthuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvCapthuoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idBill3,
            this.Hoten,
            this.namethuoc,
            this.Soluong,
            this.Gia,
            this.ToTal});
            this.grvCapthuoc.Location = new System.Drawing.Point(0, 119);
            this.grvCapthuoc.Name = "grvCapthuoc";
            this.grvCapthuoc.RowHeadersWidth = 51;
            this.grvCapthuoc.RowTemplate.Height = 24;
            this.grvCapthuoc.Size = new System.Drawing.Size(955, 193);
            this.grvCapthuoc.TabIndex = 191;
            // 
            // idBill3
            // 
            this.idBill3.DataPropertyName = "idBill3";
            this.idBill3.HeaderText = "Mã hóa đơn thuốc";
            this.idBill3.MinimumWidth = 6;
            this.idBill3.Name = "idBill3";
            this.idBill3.Width = 125;
            // 
            // Hoten
            // 
            this.Hoten.DataPropertyName = "Hovaten";
            this.Hoten.HeaderText = "Họ và tên";
            this.Hoten.MinimumWidth = 6;
            this.Hoten.Name = "Hoten";
            this.Hoten.Width = 125;
            // 
            // namethuoc
            // 
            this.namethuoc.DataPropertyName = "Tenthuoc";
            this.namethuoc.HeaderText = "Tên thuốc";
            this.namethuoc.MinimumWidth = 6;
            this.namethuoc.Name = "namethuoc";
            this.namethuoc.Width = 125;
            // 
            // Soluong
            // 
            this.Soluong.DataPropertyName = "Soluong";
            this.Soluong.HeaderText = "Số lượng";
            this.Soluong.MinimumWidth = 6;
            this.Soluong.Name = "Soluong";
            this.Soluong.Width = 125;
            // 
            // Gia
            // 
            this.Gia.DataPropertyName = "Gia";
            this.Gia.HeaderText = "Giá thuốc";
            this.Gia.MinimumWidth = 6;
            this.Gia.Name = "Gia";
            this.Gia.Width = 125;
            // 
            // ToTal
            // 
            this.ToTal.DataPropertyName = "ToTal";
            this.ToTal.HeaderText = "Thành tiền";
            this.ToTal.MinimumWidth = 6;
            this.ToTal.Name = "ToTal";
            this.ToTal.Width = 125;
            // 
            // txtIDhoadon
            // 
            this.txtIDhoadon.Location = new System.Drawing.Point(304, 9);
            this.txtIDhoadon.Name = "txtIDhoadon";
            this.txtIDhoadon.Size = new System.Drawing.Size(123, 30);
            this.txtIDhoadon.TabIndex = 7;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(304, 81);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(101, 32);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(100, 78);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(101, 35);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Số lượng cấp";
            // 
            // nmSoluong
            // 
            this.nmSoluong.Location = new System.Drawing.Point(304, 45);
            this.nmSoluong.Name = "nmSoluong";
            this.nmSoluong.Size = new System.Drawing.Size(123, 30);
            this.nmSoluong.TabIndex = 1;
            this.nmSoluong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nmSoluong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // IDbenh
            // 
            this.IDbenh.BackColor = System.Drawing.Color.White;
            this.IDbenh.Location = new System.Drawing.Point(48, 300);
            this.IDbenh.Name = "IDbenh";
            this.IDbenh.Size = new System.Drawing.Size(108, 30);
            this.IDbenh.TabIndex = 190;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(264, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 30);
            this.button1.TabIndex = 4;
            this.button1.Text = "Tìm kiếm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtTimBenhNhan);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(37, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(496, 75);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin bênh nhân";
            // 
            // txtTimBenhNhan
            // 
            this.txtTimBenhNhan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimBenhNhan.Location = new System.Drawing.Point(8, 29);
            this.txtTimBenhNhan.Name = "txtTimBenhNhan";
            this.txtTimBenhNhan.Size = new System.Drawing.Size(211, 30);
            this.txtTimBenhNhan.TabIndex = 3;
            // 
            // txtTimThuoc
            // 
            this.txtTimThuoc.Location = new System.Drawing.Point(6, 30);
            this.txtTimThuoc.Name = "txtTimThuoc";
            this.txtTimThuoc.Size = new System.Drawing.Size(226, 30);
            this.txtTimThuoc.TabIndex = 0;
            // 
            // grvThuoc
            // 
            this.grvThuoc.BackgroundColor = System.Drawing.Color.White;
            this.grvThuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvThuoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDthuoc,
            this.Tenthuoc});
            this.grvThuoc.GridColor = System.Drawing.Color.Gray;
            this.grvThuoc.Location = new System.Drawing.Point(6, 80);
            this.grvThuoc.Name = "grvThuoc";
            this.grvThuoc.RowHeadersWidth = 51;
            this.grvThuoc.RowTemplate.Height = 24;
            this.grvThuoc.Size = new System.Drawing.Size(455, 297);
            this.grvThuoc.TabIndex = 2;
            // 
            // IDthuoc
            // 
            this.IDthuoc.DataPropertyName = "IDthuoc";
            this.IDthuoc.HeaderText = "Mã Thuốc";
            this.IDthuoc.MinimumWidth = 6;
            this.IDthuoc.Name = "IDthuoc";
            this.IDthuoc.Width = 125;
            // 
            // Tenthuoc
            // 
            this.Tenthuoc.DataPropertyName = "Tenthuoc";
            this.Tenthuoc.HeaderText = "Tên thuốc";
            this.Tenthuoc.MinimumWidth = 6;
            this.Tenthuoc.Name = "Tenthuoc";
            this.Tenthuoc.Width = 125;
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Location = new System.Drawing.Point(272, 29);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(108, 30);
            this.btnTimkiem.TabIndex = 1;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.grvThuoc);
            this.groupBox3.Controls.Add(this.IDbenh);
            this.groupBox3.Controls.Add(this.btnTimkiem);
            this.groupBox3.Controls.Add(this.txtTimThuoc);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(539, 48);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(467, 383);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin thuốc";
            // 
            // GrvTen
            // 
            this.GrvTen.BackgroundColor = System.Drawing.Color.White;
            this.GrvTen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrvTen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDbenhnhan,
            this.Hovaten,
            this.Ngaysinh});
            this.GrvTen.Location = new System.Drawing.Point(37, 128);
            this.GrvTen.Name = "GrvTen";
            this.GrvTen.RowHeadersWidth = 51;
            this.GrvTen.RowTemplate.Height = 24;
            this.GrvTen.Size = new System.Drawing.Size(502, 180);
            this.GrvTen.TabIndex = 5;
            this.GrvTen.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrvTen_CellClick);
            // 
            // IDbenhnhan
            // 
            this.IDbenhnhan.DataPropertyName = "IDbenhnhan";
            this.IDbenhnhan.HeaderText = "ID bệnh nhân";
            this.IDbenhnhan.MinimumWidth = 6;
            this.IDbenhnhan.Name = "IDbenhnhan";
            this.IDbenhnhan.Width = 125;
            // 
            // Hovaten
            // 
            this.Hovaten.DataPropertyName = "Hovaten";
            this.Hovaten.HeaderText = "Họ và Tên";
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.GrvTen);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Location = new System.Drawing.Point(47, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1022, 652);
            this.panel1.TabIndex = 187;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(827, 7);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(152, 35);
            this.button5.TabIndex = 190;
            this.button5.Text = "Quay lại";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(3, -3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(406, 47);
            this.label4.TabIndex = 190;
            this.label4.Text = "CẤP THUỐC";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NhapThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1093, 688);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panel1);
            this.Name = "NhapThuoc";
            this.Text = "NhapThuoc";
            this.Load += new System.EventHandler(this.NhapThuoc_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvCapthuoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmSoluong)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvThuoc)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrvTen)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtIDhoadon;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nmSoluong;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTimBenhNhan;
        private System.Windows.Forms.TextBox txtTimThuoc;
        private System.Windows.Forms.DataGridView grvThuoc;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView GrvTen;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox IDbenh;
        private System.Windows.Forms.DataGridView grvCapthuoc;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDbenhnhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hovaten;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDthuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tenthuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn idBill3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn namethuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToTal;
    }
}