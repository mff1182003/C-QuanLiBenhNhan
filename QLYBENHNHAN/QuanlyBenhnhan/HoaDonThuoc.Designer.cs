namespace QuanlyBenhnhan
{
    partial class HoaDonThuoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HoaDonThuoc));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.grvthuoc = new System.Windows.Forms.DataGridView();
            this.IDbenhnhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hovaten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenthuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giathuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CoBaoHiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.LBTongtien = new System.Windows.Forms.Label();
            this.btnExcel = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvthuoc)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1094, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 35);
            this.button1.TabIndex = 202;
            this.button1.Text = "Quay lại";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(24, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(382, 47);
            this.label1.TabIndex = 201;
            this.label1.Text = "HÓA ĐƠN THUỐC";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.grvthuoc);
            this.groupBox3.Controls.Add(this.txt1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(5, 107);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1223, 403);
            this.groupBox3.TabIndex = 199;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin thuốc đã mua";
            // 
            // grvthuoc
            // 
            this.grvthuoc.BackgroundColor = System.Drawing.Color.White;
            this.grvthuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvthuoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDbenhnhan,
            this.Hovaten,
            this.tenthuoc,
            this.count,
            this.giathuoc,
            this.Total,
            this.CoBaoHiem});
            this.grvthuoc.Location = new System.Drawing.Point(19, 25);
            this.grvthuoc.Name = "grvthuoc";
            this.grvthuoc.RowHeadersWidth = 51;
            this.grvthuoc.RowTemplate.Height = 24;
            this.grvthuoc.Size = new System.Drawing.Size(1198, 372);
            this.grvthuoc.TabIndex = 2;
            this.grvthuoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvthuoc_CellClick);
            // 
            // IDbenhnhan
            // 
            this.IDbenhnhan.DataPropertyName = "IDbenhnhan";
            this.IDbenhnhan.HeaderText = "Mã bệnh nhân";
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
            // tenthuoc
            // 
            this.tenthuoc.DataPropertyName = "tenthuoc";
            this.tenthuoc.HeaderText = "Tên thuốc";
            this.tenthuoc.MinimumWidth = 6;
            this.tenthuoc.Name = "tenthuoc";
            this.tenthuoc.Width = 125;
            // 
            // count
            // 
            this.count.DataPropertyName = "Soluong";
            this.count.HeaderText = "Số lượng";
            this.count.MinimumWidth = 6;
            this.count.Name = "count";
            this.count.Width = 125;
            // 
            // giathuoc
            // 
            this.giathuoc.DataPropertyName = "Gia";
            this.giathuoc.HeaderText = "Giá thuốc";
            this.giathuoc.MinimumWidth = 6;
            this.giathuoc.Name = "giathuoc";
            this.giathuoc.Width = 125;
            // 
            // Total
            // 
            this.Total.DataPropertyName = "Total";
            this.Total.HeaderText = "Tổng tiền";
            this.Total.MinimumWidth = 6;
            this.Total.Name = "Total";
            this.Total.Width = 125;
            // 
            // CoBaoHiem
            // 
            this.CoBaoHiem.DataPropertyName = "CoBaoHiem";
            this.CoBaoHiem.HeaderText = "Có bảo hiểm";
            this.CoBaoHiem.MinimumWidth = 6;
            this.CoBaoHiem.Name = "CoBaoHiem";
            this.CoBaoHiem.Width = 125;
            // 
            // txt1
            // 
            this.txt1.BackColor = System.Drawing.Color.White;
            this.txt1.ForeColor = System.Drawing.Color.White;
            this.txt1.Location = new System.Drawing.Point(41, 361);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(86, 24);
            this.txt1.TabIndex = 203;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnTimkiem);
            this.groupBox1.Controls.Add(this.txtTimkiem);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(406, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(451, 51);
            this.groupBox1.TabIndex = 198;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm bệnh nhân";
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Location = new System.Drawing.Point(313, 17);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(104, 28);
            this.btnTimkiem.TabIndex = 4;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.Location = new System.Drawing.Point(17, 21);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(279, 24);
            this.txtTimkiem.TabIndex = 2;
            // 
            // LBTongtien
            // 
            this.LBTongtien.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBTongtien.ForeColor = System.Drawing.Color.Red;
            this.LBTongtien.Location = new System.Drawing.Point(641, 513);
            this.LBTongtien.Name = "LBTongtien";
            this.LBTongtien.Size = new System.Drawing.Size(216, 56);
            this.LBTongtien.TabIndex = 0;
            this.LBTongtien.Text = " ";
            this.LBTongtien.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExcel
            // 
            this.btnExcel.Location = new System.Drawing.Point(906, 68);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(129, 36);
            this.btnExcel.TabIndex = 0;
            this.btnExcel.Text = "In hóa đơn";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // HoaDonThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1296, 627);
            this.Controls.Add(this.LBTongtien);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "HoaDonThuoc";
            this.Text = "HoaDonThuoc";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvthuoc)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView grvthuoc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.TextBox txtTimkiem;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Label LBTongtien;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDbenhnhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hovaten;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenthuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn count;
        private System.Windows.Forms.DataGridViewTextBoxColumn giathuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn CoBaoHiem;
        private System.Windows.Forms.TextBox txt1;
    }
}