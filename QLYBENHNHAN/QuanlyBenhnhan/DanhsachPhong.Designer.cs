namespace QuanlyBenhnhan
{
    partial class DanhsachPhong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DanhsachPhong));
            this.panel1 = new System.Windows.Forms.Panel();
            this.grvGiuong = new System.Windows.Forms.DataGridView();
            this.Tenphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDgiuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tengiuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.phòngTrốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phòngĐãCấpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvGiuong)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.grvGiuong);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(14, 81);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(712, 448);
            this.panel1.TabIndex = 1;
            // 
            // grvGiuong
            // 
            this.grvGiuong.BackgroundColor = System.Drawing.Color.White;
            this.grvGiuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvGiuong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tenphong,
            this.IDgiuong,
            this.Tengiuong,
            this.Status});
            this.grvGiuong.Location = new System.Drawing.Point(3, 107);
            this.grvGiuong.Name = "grvGiuong";
            this.grvGiuong.RowHeadersWidth = 51;
            this.grvGiuong.RowTemplate.Height = 24;
            this.grvGiuong.Size = new System.Drawing.Size(706, 316);
            this.grvGiuong.TabIndex = 1;
            // 
            // Tenphong
            // 
            this.Tenphong.DataPropertyName = "Tenphong";
            this.Tenphong.HeaderText = "Tên phòng";
            this.Tenphong.MinimumWidth = 6;
            this.Tenphong.Name = "Tenphong";
            this.Tenphong.Width = 125;
            // 
            // IDgiuong
            // 
            this.IDgiuong.DataPropertyName = "IDgiuong";
            this.IDgiuong.HeaderText = "Mã giường";
            this.IDgiuong.MinimumWidth = 6;
            this.IDgiuong.Name = "IDgiuong";
            this.IDgiuong.Width = 125;
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
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.phòngTrốngToolStripMenuItem,
            this.phòngĐãCấpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(11, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(712, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // phòngTrốngToolStripMenuItem
            // 
            this.phòngTrốngToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phòngTrốngToolStripMenuItem.Name = "phòngTrốngToolStripMenuItem";
            this.phòngTrốngToolStripMenuItem.Size = new System.Drawing.Size(117, 26);
            this.phòngTrốngToolStripMenuItem.Text = "Phòng trống";
            this.phòngTrốngToolStripMenuItem.Click += new System.EventHandler(this.phòngTrốngToolStripMenuItem_Click);
            // 
            // phòngĐãCấpToolStripMenuItem
            // 
            this.phòngĐãCấpToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phòngĐãCấpToolStripMenuItem.Name = "phòngĐãCấpToolStripMenuItem";
            this.phòngĐãCấpToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
            this.phòngĐãCấpToolStripMenuItem.Text = "Phòng đã cấp";
            this.phòngĐãCấpToolStripMenuItem.Click += new System.EventHandler(this.phòngĐãCấpToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(16, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(411, 65);
            this.label1.TabIndex = 186;
            this.label1.Text = "DANH SÁCH PHÒNG";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(480, 12);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 48);
            this.button1.TabIndex = 196;
            this.button1.Text = "Quay lại";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DanhsachPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(739, 532);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DanhsachPhong";
            this.Text = "DanhsachPhong";
            this.Load += new System.EventHandler(this.DanhsachPhong_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvGiuong)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem phòngTrốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phòngĐãCấpToolStripMenuItem;
        private System.Windows.Forms.DataGridView grvGiuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tenphong;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDgiuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tengiuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}