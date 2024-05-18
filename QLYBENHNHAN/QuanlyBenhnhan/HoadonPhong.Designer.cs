namespace QuanlyBenhnhan
{
    partial class HoadonPhong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HoadonPhong));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.GrvXuat = new System.Windows.Forms.DataGridView();
            this.IDbenhnhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tenkhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tenphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tengiuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Giaphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngaycap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datecheckout = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATEDIFF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CoBaoHiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.btnExcel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrvXuat)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(28, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 47);
            this.label1.TabIndex = 189;
            this.label1.Text = "HÓA ĐƠN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.GrvXuat);
            this.groupBox2.Controls.Add(this.txt1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(3, 117);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1489, 461);
            this.groupBox2.TabIndex = 188;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin giường";
            // 
            // GrvXuat
            // 
            this.GrvXuat.BackgroundColor = System.Drawing.Color.White;
            this.GrvXuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrvXuat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDbenhnhan,
            this.HO,
            this.Tenkhoa,
            this.Tenphong,
            this.Tengiuong,
            this.Giaphong,
            this.Ngaycap,
            this.datecheckout,
            this.DATEDIFF,
            this.thanhtien,
            this.CoBaoHiem});
            this.GrvXuat.Location = new System.Drawing.Point(6, 23);
            this.GrvXuat.Name = "GrvXuat";
            this.GrvXuat.RowHeadersWidth = 51;
            this.GrvXuat.RowTemplate.Height = 24;
            this.GrvXuat.Size = new System.Drawing.Size(1463, 455);
            this.GrvXuat.TabIndex = 1;
            // 
            // IDbenhnhan
            // 
            this.IDbenhnhan.DataPropertyName = "IDbenhnhan";
            this.IDbenhnhan.HeaderText = "ID bệnh nhân";
            this.IDbenhnhan.MinimumWidth = 6;
            this.IDbenhnhan.Name = "IDbenhnhan";
            this.IDbenhnhan.Width = 125;
            // 
            // HO
            // 
            this.HO.DataPropertyName = "Hovaten";
            this.HO.HeaderText = "Họ và Tên";
            this.HO.MinimumWidth = 6;
            this.HO.Name = "HO";
            this.HO.Width = 125;
            // 
            // Tenkhoa
            // 
            this.Tenkhoa.DataPropertyName = "Tenkhoa";
            this.Tenkhoa.HeaderText = "Tên khoa";
            this.Tenkhoa.MinimumWidth = 6;
            this.Tenkhoa.Name = "Tenkhoa";
            this.Tenkhoa.Width = 125;
            // 
            // Tenphong
            // 
            this.Tenphong.DataPropertyName = "Tenphong";
            this.Tenphong.HeaderText = "Tên phòng";
            this.Tenphong.MinimumWidth = 6;
            this.Tenphong.Name = "Tenphong";
            this.Tenphong.Width = 125;
            // 
            // Tengiuong
            // 
            this.Tengiuong.DataPropertyName = "Tengiuong";
            this.Tengiuong.HeaderText = "Tên giường";
            this.Tengiuong.MinimumWidth = 6;
            this.Tengiuong.Name = "Tengiuong";
            this.Tengiuong.Width = 125;
            // 
            // Giaphong
            // 
            this.Giaphong.DataPropertyName = "Giaphong";
            this.Giaphong.HeaderText = "Giá giường";
            this.Giaphong.MinimumWidth = 6;
            this.Giaphong.Name = "Giaphong";
            this.Giaphong.Width = 125;
            // 
            // Ngaycap
            // 
            this.Ngaycap.DataPropertyName = "datecheckin";
            this.Ngaycap.HeaderText = "Ngày cấp giường";
            this.Ngaycap.MinimumWidth = 6;
            this.Ngaycap.Name = "Ngaycap";
            this.Ngaycap.Width = 125;
            // 
            // datecheckout
            // 
            this.datecheckout.DataPropertyName = "datecheckout";
            this.datecheckout.HeaderText = "Ngày trả giường";
            this.datecheckout.MinimumWidth = 6;
            this.datecheckout.Name = "datecheckout";
            this.datecheckout.Width = 125;
            // 
            // DATEDIFF
            // 
            this.DATEDIFF.DataPropertyName = "DATEDIFF";
            this.DATEDIFF.HeaderText = "Số ngày ở";
            this.DATEDIFF.MinimumWidth = 6;
            this.DATEDIFF.Name = "DATEDIFF";
            this.DATEDIFF.Width = 125;
            // 
            // thanhtien
            // 
            this.thanhtien.DataPropertyName = "Total";
            this.thanhtien.HeaderText = "Thành tiền";
            this.thanhtien.MinimumWidth = 6;
            this.thanhtien.Name = "thanhtien";
            this.thanhtien.Width = 125;
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
            this.txt1.ForeColor = System.Drawing.Color.White;
            this.txt1.Location = new System.Drawing.Point(20, 445);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(86, 24);
            this.txt1.TabIndex = 204;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnTimkiem);
            this.groupBox1.Controls.Add(this.txtTimkiem);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(388, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(439, 56);
            this.groupBox1.TabIndex = 187;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm bệnh nhân";
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Location = new System.Drawing.Point(329, 11);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(104, 45);
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
            // btnExcel
            // 
            this.btnExcel.Location = new System.Drawing.Point(934, 66);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(129, 50);
            this.btnExcel.TabIndex = 0;
            this.btnExcel.Text = "In hóa đơn";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1173, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 45);
            this.button1.TabIndex = 197;
            this.button1.Text = "Quay lại";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // HoadonPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1521, 609);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "HoadonPhong";
            this.Text = "HoadonPhong";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrvXuat)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView GrvXuat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.TextBox txtTimkiem;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDbenhnhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn HO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tenkhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tenphong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tengiuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Giaphong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngaycap;
        private System.Windows.Forms.DataGridViewTextBoxColumn datecheckout;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATEDIFF;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhtien;
        private System.Windows.Forms.DataGridViewTextBoxColumn CoBaoHiem;
        private System.Windows.Forms.TextBox txt1;
    }
}