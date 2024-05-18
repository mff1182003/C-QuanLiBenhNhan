﻿namespace QuanlyBenhnhan
{
    partial class PhongTrong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhongTrong));
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCapgiuong = new System.Windows.Forms.Button();
            this.cbPhong = new System.Windows.Forms.ComboBox();
            this.GrvGiuong = new System.Windows.Forms.DataGridView();
            this.IDgiuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tenphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tengiuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.cbKhoa = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.GrvGiuong)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(714, 110);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(116, 37);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Quay Lại";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCapgiuong
            // 
            this.btnCapgiuong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapgiuong.Location = new System.Drawing.Point(564, 110);
            this.btnCapgiuong.Name = "btnCapgiuong";
            this.btnCapgiuong.Size = new System.Drawing.Size(116, 37);
            this.btnCapgiuong.TabIndex = 6;
            this.btnCapgiuong.Text = "Cấp giường";
            this.btnCapgiuong.UseVisualStyleBackColor = true;
            this.btnCapgiuong.Click += new System.EventHandler(this.btnCapgiuong_Click);
            // 
            // cbPhong
            // 
            this.cbPhong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPhong.FormattingEnabled = true;
            this.cbPhong.Location = new System.Drawing.Point(185, 117);
            this.cbPhong.Name = "cbPhong";
            this.cbPhong.Size = new System.Drawing.Size(265, 30);
            this.cbPhong.TabIndex = 5;
            this.cbPhong.SelectedIndexChanged += new System.EventHandler(this.cbPhong_SelectedIndexChanged);
            // 
            // GrvGiuong
            // 
            this.GrvGiuong.BackgroundColor = System.Drawing.Color.White;
            this.GrvGiuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrvGiuong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDgiuong,
            this.Tenphong,
            this.Tengiuong,
            this.Status});
            this.GrvGiuong.Location = new System.Drawing.Point(12, 176);
            this.GrvGiuong.Name = "GrvGiuong";
            this.GrvGiuong.RowHeadersWidth = 51;
            this.GrvGiuong.RowTemplate.Height = 24;
            this.GrvGiuong.Size = new System.Drawing.Size(818, 475);
            this.GrvGiuong.TabIndex = 4;
            // 
            // IDgiuong
            // 
            this.IDgiuong.DataPropertyName = "IDgiuong";
            this.IDgiuong.HeaderText = "Mã giường";
            this.IDgiuong.MinimumWidth = 6;
            this.IDgiuong.Name = "IDgiuong";
            this.IDgiuong.Width = 125;
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
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Trạng thái";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.Width = 125;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(12, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(500, 47);
            this.label1.TabIndex = 187;
            this.label1.Text = "DANH SÁCH PHÒNG TRỐNG";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbKhoa
            // 
            this.cbKhoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbKhoa.FormattingEnabled = true;
            this.cbKhoa.Location = new System.Drawing.Point(185, 64);
            this.cbKhoa.Name = "cbKhoa";
            this.cbKhoa.Size = new System.Drawing.Size(265, 30);
            this.cbKhoa.TabIndex = 188;
            this.cbKhoa.SelectedIndexChanged += new System.EventHandler(this.cbKhoa_SelectedIndexChanged);
            // 
            // PhongTrong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(842, 663);
            this.Controls.Add(this.cbKhoa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCapgiuong);
            this.Controls.Add(this.cbPhong);
            this.Controls.Add(this.GrvGiuong);
            this.Name = "PhongTrong";
            this.Text = "PhongTrong";
            this.Load += new System.EventHandler(this.PhongTrong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrvGiuong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCapgiuong;
        private System.Windows.Forms.ComboBox cbPhong;
        private System.Windows.Forms.DataGridView GrvGiuong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDgiuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tenphong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tengiuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.ComboBox cbKhoa;
    }
}