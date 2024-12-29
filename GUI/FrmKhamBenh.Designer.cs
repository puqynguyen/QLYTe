namespace GUI
{
    partial class FrmKhamBenh
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
            this.btnChonBenhNhan = new System.Windows.Forms.Button();
            this.btnChonBacSi = new System.Windows.Forms.Button();
            this.txtTenBN = new System.Windows.Forms.Label();
            this.txtEmailBS = new System.Windows.Forms.Label();
            this.txtKhoa = new System.Windows.Forms.Label();
            this.txtTenBS = new System.Windows.Forms.Label();
            this.txtCCCD = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTrieuChung = new System.Windows.Forms.RichTextBox();
            this.txtChuanDoan = new System.Windows.Forms.RichTextBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.TenThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LieuLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CachDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnHoanThanh = new System.Windows.Forms.Button();
            this.txtGhiChu = new System.Windows.Forms.RichTextBox();
            this.txtMaBN = new System.Windows.Forms.Label();
            this.txtMaBS = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // btnChonBenhNhan
            // 
            this.btnChonBenhNhan.Location = new System.Drawing.Point(12, 12);
            this.btnChonBenhNhan.Name = "btnChonBenhNhan";
            this.btnChonBenhNhan.Size = new System.Drawing.Size(133, 23);
            this.btnChonBenhNhan.TabIndex = 0;
            this.btnChonBenhNhan.Text = "Chọn Bệnh Nhân";
            this.btnChonBenhNhan.UseVisualStyleBackColor = true;
            this.btnChonBenhNhan.Click += new System.EventHandler(this.btnChonBenhNhan_Click);
            // 
            // btnChonBacSi
            // 
            this.btnChonBacSi.Location = new System.Drawing.Point(12, 41);
            this.btnChonBacSi.Name = "btnChonBacSi";
            this.btnChonBacSi.Size = new System.Drawing.Size(133, 23);
            this.btnChonBacSi.TabIndex = 1;
            this.btnChonBacSi.Text = "Chọn Bác Sĩ";
            this.btnChonBacSi.UseVisualStyleBackColor = true;
            this.btnChonBacSi.Click += new System.EventHandler(this.btnChonBacSi_Click);
            // 
            // txtTenBN
            // 
            this.txtTenBN.AutoSize = true;
            this.txtTenBN.Location = new System.Drawing.Point(339, 15);
            this.txtTenBN.Name = "txtTenBN";
            this.txtTenBN.Size = new System.Drawing.Size(16, 16);
            this.txtTenBN.TabIndex = 2;
            this.txtTenBN.Text = "...";
            // 
            // txtEmailBS
            // 
            this.txtEmailBS.AutoSize = true;
            this.txtEmailBS.Location = new System.Drawing.Point(635, 44);
            this.txtEmailBS.Name = "txtEmailBS";
            this.txtEmailBS.Size = new System.Drawing.Size(16, 16);
            this.txtEmailBS.TabIndex = 3;
            this.txtEmailBS.Text = "...";
            // 
            // txtKhoa
            // 
            this.txtKhoa.AutoSize = true;
            this.txtKhoa.Location = new System.Drawing.Point(487, 44);
            this.txtKhoa.Name = "txtKhoa";
            this.txtKhoa.Size = new System.Drawing.Size(16, 16);
            this.txtKhoa.TabIndex = 4;
            this.txtKhoa.Text = "...";
            // 
            // txtTenBS
            // 
            this.txtTenBS.AutoSize = true;
            this.txtTenBS.Location = new System.Drawing.Point(339, 44);
            this.txtTenBS.Name = "txtTenBS";
            this.txtTenBS.Size = new System.Drawing.Size(16, 16);
            this.txtTenBS.TabIndex = 5;
            this.txtTenBS.Text = "...";
            // 
            // txtCCCD
            // 
            this.txtCCCD.AutoSize = true;
            this.txtCCCD.Location = new System.Drawing.Point(635, 15);
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.Size = new System.Drawing.Size(16, 16);
            this.txtCCCD.TabIndex = 6;
            this.txtCCCD.Text = "...";
            // 
            // txtSDT
            // 
            this.txtSDT.AutoSize = true;
            this.txtSDT.Location = new System.Drawing.Point(487, 15);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(16, 16);
            this.txtSDT.TabIndex = 7;
            this.txtSDT.Text = "...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Triệu chứng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Chuẩn đoán";
            // 
            // txtTrieuChung
            // 
            this.txtTrieuChung.Location = new System.Drawing.Point(105, 119);
            this.txtTrieuChung.Name = "txtTrieuChung";
            this.txtTrieuChung.Size = new System.Drawing.Size(218, 86);
            this.txtTrieuChung.TabIndex = 11;
            this.txtTrieuChung.Text = "";
            // 
            // txtChuanDoan
            // 
            this.txtChuanDoan.Location = new System.Drawing.Point(105, 225);
            this.txtChuanDoan.Name = "txtChuanDoan";
            this.txtChuanDoan.Size = new System.Drawing.Size(218, 86);
            this.txtChuanDoan.TabIndex = 12;
            this.txtChuanDoan.Text = "";
            // 
            // dgv
            // 
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenThuoc,
            this.LieuLuong,
            this.SoLuong,
            this.CachDung});
            this.dgv.Location = new System.Drawing.Point(329, 119);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(650, 192);
            this.dgv.TabIndex = 14;
            // 
            // TenThuoc
            // 
            this.TenThuoc.HeaderText = "Tên Thuốc";
            this.TenThuoc.MinimumWidth = 6;
            this.TenThuoc.Name = "TenThuoc";
            // 
            // LieuLuong
            // 
            this.LieuLuong.HeaderText = "Liều Lượng";
            this.LieuLuong.MinimumWidth = 6;
            this.LieuLuong.Name = "LieuLuong";
            // 
            // SoLuong
            // 
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            // 
            // CachDung
            // 
            this.CachDung.HeaderText = "Cách Dùng";
            this.CachDung.MinimumWidth = 6;
            this.CachDung.Name = "CachDung";
            // 
            // btnHoanThanh
            // 
            this.btnHoanThanh.Location = new System.Drawing.Point(866, 418);
            this.btnHoanThanh.Name = "btnHoanThanh";
            this.btnHoanThanh.Size = new System.Drawing.Size(104, 23);
            this.btnHoanThanh.TabIndex = 15;
            this.btnHoanThanh.Text = "Hoàn Thành";
            this.btnHoanThanh.UseVisualStyleBackColor = true;
            this.btnHoanThanh.Click += new System.EventHandler(this.btnHoanThanh_Click);
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(329, 317);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(650, 60);
            this.txtGhiChu.TabIndex = 16;
            this.txtGhiChu.Text = "Ghi Chú*";
            // 
            // txtMaBN
            // 
            this.txtMaBN.AutoSize = true;
            this.txtMaBN.Location = new System.Drawing.Point(191, 15);
            this.txtMaBN.Name = "txtMaBN";
            this.txtMaBN.Size = new System.Drawing.Size(16, 16);
            this.txtMaBN.TabIndex = 17;
            this.txtMaBN.Text = "...";
            this.txtMaBN.TextChanged += new System.EventHandler(this.txtMaBenhNhan_TextChanged);
            // 
            // txtMaBS
            // 
            this.txtMaBS.AutoSize = true;
            this.txtMaBS.Location = new System.Drawing.Point(191, 44);
            this.txtMaBS.Name = "txtMaBS";
            this.txtMaBS.Size = new System.Drawing.Size(16, 16);
            this.txtMaBS.TabIndex = 18;
            this.txtMaBS.Text = "...";
            // 
            // FrmKhamBenh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 453);
            this.Controls.Add(this.txtMaBS);
            this.Controls.Add(this.txtMaBN);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.btnHoanThanh);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.txtChuanDoan);
            this.Controls.Add(this.txtTrieuChung);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txtCCCD);
            this.Controls.Add(this.txtTenBS);
            this.Controls.Add(this.txtKhoa);
            this.Controls.Add(this.txtEmailBS);
            this.Controls.Add(this.txtTenBN);
            this.Controls.Add(this.btnChonBacSi);
            this.Controls.Add(this.btnChonBenhNhan);
            this.Name = "FrmKhamBenh";
            this.Text = "FrmKhamBenh";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChonBenhNhan;
        private System.Windows.Forms.Button btnChonBacSi;
        private System.Windows.Forms.Label txtTenBN;
        private System.Windows.Forms.Label txtEmailBS;
        private System.Windows.Forms.Label txtKhoa;
        private System.Windows.Forms.Label txtTenBS;
        private System.Windows.Forms.Label txtCCCD;
        private System.Windows.Forms.Label txtSDT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txtTrieuChung;
        private System.Windows.Forms.RichTextBox txtChuanDoan;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn LieuLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn CachDung;
        private System.Windows.Forms.Button btnHoanThanh;
        private System.Windows.Forms.RichTextBox txtGhiChu;
        private System.Windows.Forms.Label txtMaBN;
        private System.Windows.Forms.Label txtMaBS;
    }
}