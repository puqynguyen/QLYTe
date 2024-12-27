namespace GUI
{
    partial class ChiTietDonThuoc
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvChiTietDonThuoc = new System.Windows.Forms.DataGridView();
            this.MaChiTiet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDonThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LieuLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CachDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMaChiTiet = new System.Windows.Forms.TextBox();
            this.txtMaDonThuoc = new System.Windows.Forms.TextBox();
            this.txtTenThuoc = new System.Windows.Forms.TextBox();
            this.txtLieuLuong = new System.Windows.Forms.TextBox();
            this.numSoLuong = new System.Windows.Forms.NumericUpDown();
            this.txtCachDung = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietDonThuoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvChiTietDonThuoc
            // 
            this.dgvChiTietDonThuoc.AllowUserToAddRows = false;
            this.dgvChiTietDonThuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietDonThuoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaChiTiet,
            this.MaDonThuoc,
            this.TenThuoc,
            this.LieuLuong,
            this.SoLuong,
            this.CachDung});
            this.dgvChiTietDonThuoc.Location = new System.Drawing.Point(9, 10);
            this.dgvChiTietDonThuoc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvChiTietDonThuoc.Name = "dgvChiTietDonThuoc";
            this.dgvChiTietDonThuoc.ReadOnly = true;
            this.dgvChiTietDonThuoc.RowHeadersWidth = 51;
            this.dgvChiTietDonThuoc.RowTemplate.Height = 24;
            this.dgvChiTietDonThuoc.Size = new System.Drawing.Size(769, 162);
            this.dgvChiTietDonThuoc.TabIndex = 0;
            // 
            // MaChiTiet
            // 
            this.MaChiTiet.DataPropertyName = "MaChiTiet";
            this.MaChiTiet.HeaderText = "Mã Chi Tiết";
            this.MaChiTiet.MinimumWidth = 6;
            this.MaChiTiet.Name = "MaChiTiet";
            this.MaChiTiet.ReadOnly = true;
            this.MaChiTiet.Width = 125;
            // 
            // MaDonThuoc
            // 
            this.MaDonThuoc.DataPropertyName = "MaDonThuoc";
            this.MaDonThuoc.HeaderText = "Mã Đơn Thuốc";
            this.MaDonThuoc.MinimumWidth = 6;
            this.MaDonThuoc.Name = "MaDonThuoc";
            this.MaDonThuoc.ReadOnly = true;
            this.MaDonThuoc.Width = 125;
            // 
            // TenThuoc
            // 
            this.TenThuoc.DataPropertyName = "TenThuoc";
            this.TenThuoc.HeaderText = "Tên Thuốc";
            this.TenThuoc.MinimumWidth = 6;
            this.TenThuoc.Name = "TenThuoc";
            this.TenThuoc.ReadOnly = true;
            this.TenThuoc.Width = 125;
            // 
            // LieuLuong
            // 
            this.LieuLuong.DataPropertyName = "LieuLuong";
            this.LieuLuong.HeaderText = "Liều Lượng";
            this.LieuLuong.MinimumWidth = 6;
            this.LieuLuong.Name = "LieuLuong";
            this.LieuLuong.ReadOnly = true;
            this.LieuLuong.Width = 125;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            this.SoLuong.Width = 125;
            // 
            // CachDung
            // 
            this.CachDung.DataPropertyName = "CachDung";
            this.CachDung.HeaderText = "Cách Dùng";
            this.CachDung.MinimumWidth = 6;
            this.CachDung.Name = "CachDung";
            this.CachDung.ReadOnly = true;
            this.CachDung.Width = 125;
            // 
            // txtMaChiTiet
            // 
            this.txtMaChiTiet.Location = new System.Drawing.Point(90, 187);
            this.txtMaChiTiet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMaChiTiet.Name = "txtMaChiTiet";
            this.txtMaChiTiet.Size = new System.Drawing.Size(151, 20);
            this.txtMaChiTiet.TabIndex = 1;
            // 
            // txtMaDonThuoc
            // 
            this.txtMaDonThuoc.Location = new System.Drawing.Point(90, 219);
            this.txtMaDonThuoc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMaDonThuoc.Name = "txtMaDonThuoc";
            this.txtMaDonThuoc.Size = new System.Drawing.Size(151, 20);
            this.txtMaDonThuoc.TabIndex = 2;
            // 
            // txtTenThuoc
            // 
            this.txtTenThuoc.Location = new System.Drawing.Point(90, 252);
            this.txtTenThuoc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTenThuoc.Name = "txtTenThuoc";
            this.txtTenThuoc.Size = new System.Drawing.Size(151, 20);
            this.txtTenThuoc.TabIndex = 3;
            // 
            // txtLieuLuong
            // 
            this.txtLieuLuong.Location = new System.Drawing.Point(90, 284);
            this.txtLieuLuong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLieuLuong.Name = "txtLieuLuong";
            this.txtLieuLuong.Size = new System.Drawing.Size(151, 20);
            this.txtLieuLuong.TabIndex = 4;
            // 
            // numSoLuong
            // 
            this.numSoLuong.Location = new System.Drawing.Point(90, 317);
            this.numSoLuong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numSoLuong.Name = "numSoLuong";
            this.numSoLuong.Size = new System.Drawing.Size(150, 20);
            this.numSoLuong.TabIndex = 5;
            // 
            // txtCachDung
            // 
            this.txtCachDung.Location = new System.Drawing.Point(90, 349);
            this.txtCachDung.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCachDung.Name = "txtCachDung";
            this.txtCachDung.Size = new System.Drawing.Size(151, 20);
            this.txtCachDung.TabIndex = 6;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(262, 187);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 24);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(262, 219);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 24);
            this.btnSua.TabIndex = 8;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(262, 252);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 24);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 189);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Mã Chi Tiết:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 222);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Mã Đơn Thuốc:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 254);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Tên Thuốc:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 287);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Liều Lượng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 319);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Số Lượng:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 352);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Cách Dùng:";
            // 
            // FrmChiTietDonThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 368);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtCachDung);
            this.Controls.Add(this.numSoLuong);
            this.Controls.Add(this.txtLieuLuong);
            this.Controls.Add(this.txtTenThuoc);
            this.Controls.Add(this.txtMaDonThuoc);
            this.Controls.Add(this.txtMaChiTiet);
            this.Controls.Add(this.dgvChiTietDonThuoc);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmChiTietDonThuoc";
            this.Text = "Chi Tiết Đơn Thuốc";
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietDonThuoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.DataGridView dgvChiTietDonThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaChiTiet;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDonThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn LieuLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn CachDung;
        private System.Windows.Forms.TextBox txtMaChiTiet;
        private System.Windows.Forms.TextBox txtMaDonThuoc;
        private System.Windows.Forms.TextBox txtTenThuoc;
        private System.Windows.Forms.TextBox txtLieuLuong;
        private System.Windows.Forms.NumericUpDown numSoLuong;
        private System.Windows.Forms.TextBox txtCachDung;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}