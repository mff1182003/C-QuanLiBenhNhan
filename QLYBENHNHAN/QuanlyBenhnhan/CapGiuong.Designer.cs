namespace QuanlyBenhnhan
{
    partial class CapGiuong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CapGiuong));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grvThongtinbenhnhan = new System.Windows.Forms.DataGridView();
            this.IDbenhnhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hovaten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTimkieem = new System.Windows.Forms.Button();
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIDvao = new System.Windows.Forms.TextBox();
            this.dateNgaycap = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.lbIDgiuong = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvThongtinbenhnhan)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.grvThongtinbenhnhan);
            this.groupBox2.Controls.Add(this.btnTimkieem);
            this.groupBox2.Controls.Add(this.txtTimkiem);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(494, 69);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(429, 524);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin Thông tin bệnh nhân";
            // 
            // grvThongtinbenhnhan
            // 
            this.grvThongtinbenhnhan.BackgroundColor = System.Drawing.Color.White;
            this.grvThongtinbenhnhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvThongtinbenhnhan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDbenhnhan,
            this.Hovaten});
            this.grvThongtinbenhnhan.Location = new System.Drawing.Point(6, 81);
            this.grvThongtinbenhnhan.Name = "grvThongtinbenhnhan";
            this.grvThongtinbenhnhan.RowHeadersWidth = 51;
            this.grvThongtinbenhnhan.RowTemplate.Height = 24;
            this.grvThongtinbenhnhan.Size = new System.Drawing.Size(417, 443);
            this.grvThongtinbenhnhan.TabIndex = 7;
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
            // btnTimkieem
            // 
            this.btnTimkieem.Location = new System.Drawing.Point(224, 30);
            this.btnTimkieem.Name = "btnTimkieem";
            this.btnTimkieem.Size = new System.Drawing.Size(109, 30);
            this.btnTimkieem.TabIndex = 6;
            this.btnTimkieem.Text = "Tìm kiếm";
            this.btnTimkieem.UseVisualStyleBackColor = true;
            this.btnTimkieem.Click += new System.EventHandler(this.btnTimkieem_Click);
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.Location = new System.Drawing.Point(6, 30);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(193, 30);
            this.txtTimkiem.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtIDvao);
            this.groupBox1.Controls.Add(this.dateNgaycap);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbIDgiuong);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(26, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(462, 524);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Điền thông tin";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(154, 332);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(135, 43);
            this.button3.TabIndex = 198;
            this.button3.Text = "Lưu";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "ID Bill";
            // 
            // txtIDvao
            // 
            this.txtIDvao.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDvao.Location = new System.Drawing.Point(234, 106);
            this.txtIDvao.Name = "txtIDvao";
            this.txtIDvao.Size = new System.Drawing.Size(199, 30);
            this.txtIDvao.TabIndex = 6;
            // 
            // dateNgaycap
            // 
            this.dateNgaycap.CustomFormat = "dd/MM/yyyy";
            this.dateNgaycap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateNgaycap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateNgaycap.Location = new System.Drawing.Point(234, 174);
            this.dateNgaycap.Name = "dateNgaycap";
            this.dateNgaycap.Size = new System.Drawing.Size(199, 30);
            this.dateNgaycap.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(54, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày cấp giường";
            // 
            // lbIDgiuong
            // 
            this.lbIDgiuong.BackColor = System.Drawing.Color.White;
            this.lbIDgiuong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIDgiuong.Location = new System.Drawing.Point(231, 54);
            this.lbIDgiuong.Name = "lbIDgiuong";
            this.lbIDgiuong.Size = new System.Drawing.Size(202, 25);
            this.lbIDgiuong.TabIndex = 1;
            this.lbIDgiuong.Text = " ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID giường";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(764, 21);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(153, 42);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Quay lại";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(29, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(337, 47);
            this.label4.TabIndex = 186;
            this.label4.Text = "CẤP GIƯỜNG";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CapGiuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(957, 668);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExit);
            this.Name = "CapGiuong";
            this.Text = "CapGiuong";
            this.Load += new System.EventHandler(this.CapGiuong_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvThongtinbenhnhan)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView grvThongtinbenhnhan;
        private System.Windows.Forms.Button btnTimkieem;
        private System.Windows.Forms.TextBox txtTimkiem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIDvao;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DateTimePicker dateNgaycap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbIDgiuong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDbenhnhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hovaten;
    }
}