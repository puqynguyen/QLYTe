namespace GUI
{
    partial class FrmLichSuKham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLichSuKham));
            this.dgvLichSuKham = new System.Windows.Forms.DataGridView();
            this.MaLichSu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaBenhNhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaBacSi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayKham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKhamBenh = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNgayKham = new System.Windows.Forms.Label();
            this.txtMaBacSi = new System.Windows.Forms.Label();
            this.txtKhoa = new System.Windows.Forms.Label();
            this.txtTenBacSi = new System.Windows.Forms.Label();
            this.txtTenBenhNhan = new System.Windows.Forms.Label();
            this.txtMaBenhNhan = new System.Windows.Forms.Label();
            this.txtMaKhamBenh = new System.Windows.Forms.Label();
            this.txtTrieuChung = new System.Windows.Forms.Label();
            this.txtChuanDoan = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichSuKham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLichSuKham
            // 
            this.dgvLichSuKham.AllowUserToAddRows = false;
            this.dgvLichSuKham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLichSuKham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLichSuKham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLichSu,
            this.MaBenhNhan,
            this.MaBacSi,
            this.NgayKham});
            this.dgvLichSuKham.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvLichSuKham.Location = new System.Drawing.Point(0, 0);
            this.dgvLichSuKham.Name = "dgvLichSuKham";
            this.dgvLichSuKham.ReadOnly = true;
            this.dgvLichSuKham.RowHeadersWidth = 51;
            this.dgvLichSuKham.RowTemplate.Height = 24;
            this.dgvLichSuKham.Size = new System.Drawing.Size(982, 239);
            this.dgvLichSuKham.TabIndex = 1;
            // 
            // MaLichSu
            // 
            this.MaLichSu.DataPropertyName = "MaKhamBenh";
            this.MaLichSu.HeaderText = "Mã Khám Bệnh";
            this.MaLichSu.MinimumWidth = 6;
            this.MaLichSu.Name = "MaLichSu";
            this.MaLichSu.ReadOnly = true;
            // 
            // MaBenhNhan
            // 
            this.MaBenhNhan.DataPropertyName = "TenBenhNhan";
            this.MaBenhNhan.HeaderText = "Tên Bệnh Nhân";
            this.MaBenhNhan.MinimumWidth = 6;
            this.MaBenhNhan.Name = "MaBenhNhan";
            this.MaBenhNhan.ReadOnly = true;
            // 
            // MaBacSi
            // 
            this.MaBacSi.DataPropertyName = "TenBacSi";
            this.MaBacSi.HeaderText = "Tên Bác Sĩ";
            this.MaBacSi.MinimumWidth = 6;
            this.MaBacSi.Name = "MaBacSi";
            this.MaBacSi.ReadOnly = true;
            // 
            // NgayKham
            // 
            this.NgayKham.DataPropertyName = "NgayKham";
            this.NgayKham.HeaderText = "Ngày Khám";
            this.NgayKham.MinimumWidth = 6;
            this.NgayKham.Name = "NgayKham";
            this.NgayKham.ReadOnly = true;
            // 
            // MaKhamBenh
            // 
            this.MaKhamBenh.AutoSize = true;
            this.MaKhamBenh.Location = new System.Drawing.Point(12, 252);
            this.MaKhamBenh.Name = "MaKhamBenh";
            this.MaKhamBenh.Size = new System.Drawing.Size(100, 16);
            this.MaKhamBenh.TabIndex = 2;
            this.MaKhamBenh.Text = "Mã Khám Bệnh:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mã Bệnh Nhân:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tên Bệnh Nhân:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 372);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tên Bác Sĩ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(437, 342);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Chuẩn Đoán:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 402);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Khoa:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 342);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "Mã Bác Sĩ:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(438, 252);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 16);
            this.label8.TabIndex = 10;
            this.label8.Text = "Triệu Chứng:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 432);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 16);
            this.label9.TabIndex = 11;
            this.label9.Text = "Ngày Khám:";
            // 
            // txtNgayKham
            // 
            this.txtNgayKham.AutoSize = true;
            this.txtNgayKham.Location = new System.Drawing.Point(118, 432);
            this.txtNgayKham.Name = "txtNgayKham";
            this.txtNgayKham.Size = new System.Drawing.Size(16, 16);
            this.txtNgayKham.TabIndex = 18;
            this.txtNgayKham.Text = "...";
            // 
            // txtMaBacSi
            // 
            this.txtMaBacSi.AutoSize = true;
            this.txtMaBacSi.Location = new System.Drawing.Point(118, 342);
            this.txtMaBacSi.Name = "txtMaBacSi";
            this.txtMaBacSi.Size = new System.Drawing.Size(16, 16);
            this.txtMaBacSi.TabIndex = 17;
            this.txtMaBacSi.Text = "...";
            // 
            // txtKhoa
            // 
            this.txtKhoa.AutoSize = true;
            this.txtKhoa.Location = new System.Drawing.Point(118, 402);
            this.txtKhoa.Name = "txtKhoa";
            this.txtKhoa.Size = new System.Drawing.Size(16, 16);
            this.txtKhoa.TabIndex = 16;
            this.txtKhoa.Text = "...";
            // 
            // txtTenBacSi
            // 
            this.txtTenBacSi.AutoSize = true;
            this.txtTenBacSi.Location = new System.Drawing.Point(118, 372);
            this.txtTenBacSi.Name = "txtTenBacSi";
            this.txtTenBacSi.Size = new System.Drawing.Size(16, 16);
            this.txtTenBacSi.TabIndex = 15;
            this.txtTenBacSi.Text = "...";
            // 
            // txtTenBenhNhan
            // 
            this.txtTenBenhNhan.AutoSize = true;
            this.txtTenBenhNhan.Location = new System.Drawing.Point(118, 312);
            this.txtTenBenhNhan.Name = "txtTenBenhNhan";
            this.txtTenBenhNhan.Size = new System.Drawing.Size(16, 16);
            this.txtTenBenhNhan.TabIndex = 14;
            this.txtTenBenhNhan.Text = "...";
            // 
            // txtMaBenhNhan
            // 
            this.txtMaBenhNhan.AutoSize = true;
            this.txtMaBenhNhan.Location = new System.Drawing.Point(118, 282);
            this.txtMaBenhNhan.Name = "txtMaBenhNhan";
            this.txtMaBenhNhan.Size = new System.Drawing.Size(16, 16);
            this.txtMaBenhNhan.TabIndex = 13;
            this.txtMaBenhNhan.Text = "...";
            // 
            // txtMaKhamBenh
            // 
            this.txtMaKhamBenh.AutoSize = true;
            this.txtMaKhamBenh.Location = new System.Drawing.Point(118, 252);
            this.txtMaKhamBenh.Name = "txtMaKhamBenh";
            this.txtMaKhamBenh.Size = new System.Drawing.Size(16, 16);
            this.txtMaKhamBenh.TabIndex = 12;
            this.txtMaKhamBenh.Text = "...";
            // 
            // txtTrieuChung
            // 
            this.txtTrieuChung.AutoSize = true;
            this.txtTrieuChung.Location = new System.Drawing.Point(526, 252);
            this.txtTrieuChung.Name = "txtTrieuChung";
            this.txtTrieuChung.Size = new System.Drawing.Size(16, 16);
            this.txtTrieuChung.TabIndex = 20;
            this.txtTrieuChung.Text = "...";
            // 
            // txtChuanDoan
            // 
            this.txtChuanDoan.AutoSize = true;
            this.txtChuanDoan.Location = new System.Drawing.Point(525, 342);
            this.txtChuanDoan.Name = "txtChuanDoan";
            this.txtChuanDoan.Size = new System.Drawing.Size(16, 16);
            this.txtChuanDoan.TabIndex = 19;
            this.txtChuanDoan.Text = "...";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(846, 245);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(124, 22);
            this.txtTimKiem.TabIndex = 21;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(815, 245);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // FrmLichSuKham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 453);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.txtTrieuChung);
            this.Controls.Add(this.txtChuanDoan);
            this.Controls.Add(this.txtNgayKham);
            this.Controls.Add(this.txtMaBacSi);
            this.Controls.Add(this.txtKhoa);
            this.Controls.Add(this.txtTenBacSi);
            this.Controls.Add(this.txtTenBenhNhan);
            this.Controls.Add(this.txtMaBenhNhan);
            this.Controls.Add(this.txtMaKhamBenh);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MaKhamBenh);
            this.Controls.Add(this.dgvLichSuKham);
            this.Name = "FrmLichSuKham";
            this.Text = "Lịch Sử Khám";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichSuKham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLichSuKham;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLichSu;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBenhNhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBacSi;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayKham;
        private System.Windows.Forms.Label MaKhamBenh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label txtNgayKham;
        private System.Windows.Forms.Label txtMaBacSi;
        private System.Windows.Forms.Label txtKhoa;
        private System.Windows.Forms.Label txtTenBacSi;
        private System.Windows.Forms.Label txtTenBenhNhan;
        private System.Windows.Forms.Label txtMaBenhNhan;
        private System.Windows.Forms.Label txtMaKhamBenh;
        private System.Windows.Forms.Label txtTrieuChung;
        private System.Windows.Forms.Label txtChuanDoan;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}