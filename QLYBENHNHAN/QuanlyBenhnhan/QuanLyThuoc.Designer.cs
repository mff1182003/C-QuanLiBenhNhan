namespace QuanlyBenhnhan
{
    partial class QuanLyThuoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLyThuoc));
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.grvthuoc = new System.Windows.Forms.DataGridView();
            this.IDthuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tenthuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngaynhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngayhethan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.thêmThuốcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sửaThuốcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaThuốcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.grvthuoc)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(24, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(587, 51);
            this.label1.TabIndex = 177;
            this.label1.Text = "DANH SÁCH THUỐC";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(798, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(152, 35);
            this.button5.TabIndex = 175;
            this.button5.Text = "Quay lại";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(755, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 32);
            this.button1.TabIndex = 171;
            this.button1.Text = "Tìm kiếm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // grvthuoc
            // 
            this.grvthuoc.BackgroundColor = System.Drawing.Color.White;
            this.grvthuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvthuoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDthuoc,
            this.Tenthuoc,
            this.Soluong,
            this.Gia,
            this.Ngaynhap,
            this.Ngayhethan});
            this.grvthuoc.GridColor = System.Drawing.Color.White;
            this.grvthuoc.Location = new System.Drawing.Point(7, 114);
            this.grvthuoc.Name = "grvthuoc";
            this.grvthuoc.RowHeadersWidth = 51;
            this.grvthuoc.RowTemplate.Height = 24;
            this.grvthuoc.Size = new System.Drawing.Size(931, 468);
            this.grvthuoc.TabIndex = 170;
            // 
            // IDthuoc
            // 
            this.IDthuoc.DataPropertyName = "IDthuoc";
            this.IDthuoc.HeaderText = "ID thuốc";
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
            this.Gia.HeaderText = "Giá";
            this.Gia.MinimumWidth = 6;
            this.Gia.Name = "Gia";
            this.Gia.Width = 125;
            // 
            // Ngaynhap
            // 
            this.Ngaynhap.DataPropertyName = "Ngaynhap";
            this.Ngaynhap.HeaderText = "Ngày nhập";
            this.Ngaynhap.MinimumWidth = 6;
            this.Ngaynhap.Name = "Ngaynhap";
            this.Ngaynhap.Width = 125;
            // 
            // Ngayhethan
            // 
            this.Ngayhethan.DataPropertyName = "Ngayhethan";
            this.Ngayhethan.HeaderText = "Ngày hết hạn";
            this.Ngayhethan.MinimumWidth = 6;
            this.Ngayhethan.Name = "Ngayhethan";
            this.Ngayhethan.Width = 125;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.txtTimKiem);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.grvthuoc);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(12, 98);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(953, 560);
            this.panel1.TabIndex = 178;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(491, 76);
            this.txtTimKiem.Multiline = true;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(258, 32);
            this.txtTimKiem.TabIndex = 176;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmThuốcToolStripMenuItem,
            this.sửaThuốcToolStripMenuItem,
            this.xóaThuốcToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(953, 30);
            this.menuStrip1.TabIndex = 177;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // thêmThuốcToolStripMenuItem
            // 
            this.thêmThuốcToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thêmThuốcToolStripMenuItem.Name = "thêmThuốcToolStripMenuItem";
            this.thêmThuốcToolStripMenuItem.Size = new System.Drawing.Size(115, 26);
            this.thêmThuốcToolStripMenuItem.Text = "Thêm thuốc";
            this.thêmThuốcToolStripMenuItem.Click += new System.EventHandler(this.thêmThuốcToolStripMenuItem_Click);
            // 
            // sửaThuốcToolStripMenuItem
            // 
            this.sửaThuốcToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sửaThuốcToolStripMenuItem.Name = "sửaThuốcToolStripMenuItem";
            this.sửaThuốcToolStripMenuItem.Size = new System.Drawing.Size(102, 26);
            this.sửaThuốcToolStripMenuItem.Text = "Sửa thuốc";
            this.sửaThuốcToolStripMenuItem.Click += new System.EventHandler(this.sửaThuốcToolStripMenuItem_Click);
            // 
            // xóaThuốcToolStripMenuItem
            // 
            this.xóaThuốcToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xóaThuốcToolStripMenuItem.Name = "xóaThuốcToolStripMenuItem";
            this.xóaThuốcToolStripMenuItem.Size = new System.Drawing.Size(104, 26);
            this.xóaThuốcToolStripMenuItem.Text = "Xóa thuốc";
            this.xóaThuốcToolStripMenuItem.Click += new System.EventHandler(this.xóaThuốcToolStripMenuItem_Click);
            // 
            // QuanLyThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(978, 663);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "QuanLyThuoc";
            this.Text = "QuanLyThuoc";
            this.Load += new System.EventHandler(this.QuanLyThuoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvthuoc)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView grvthuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDthuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tenthuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngaynhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngayhethan;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thêmThuốcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sửaThuốcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaThuốcToolStripMenuItem;
        private System.Windows.Forms.TextBox txtTimKiem;
    }
}