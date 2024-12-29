using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS.BUS;
using DTO.Entities;

namespace GUI
{
    public partial class FrmKhamBenh : Form
    {
        public FrmKhamBenh()
        {
            InitializeComponent();
        }

        private void btnChonBenhNhan_Click(object sender, EventArgs e)
        {
            FrmBenhNhan frmBenhNhan = new FrmBenhNhan(true);
            frmBenhNhan.OnSelectBenhNhan += FrmBenhNhan_OnSelectBenhNhan;
            frmBenhNhan.ShowDialog();
        }
        private void FrmBenhNhan_OnSelectBenhNhan(int maBenhNhan)
        {
            txtMaBN.Text = maBenhNhan.ToString();
        }

        private void txtMaBenhNhan_TextChanged(object sender, EventArgs e)
        {
            BenhNhanBUS benhNhanBUS = new BenhNhanBUS();
            int ma = Convert.ToInt32(txtMaBN.Text);
            BenhNhan x = benhNhanBUS.TimKiemBenhNhan(ma);
            txtTenBN.Text = x.HoTen;
            txtSDT.Text = x.SoDienThoai;
            txtCCCD.Text = x.CMND_CCCD;
        }

        private void btnChonBacSi_Click(object sender, EventArgs e)
        {
            FrmBacSi frmBacSi = new FrmBacSi(true);
            frmBacSi.OnSelectBacSi += FrmBacSi_OnSelectBacSi;
            frmBacSi.Refresh();
            frmBacSi.ShowDialog();
        }

        private void FrmBacSi_OnSelectBacSi(int maBacSi)
        {
            txtMaBS.Text = maBacSi.ToString();
            BacSiBUS bacSiBUS = new BacSiBUS();
            BacSi x = bacSiBUS.TimKiemBacSi(maBacSi);
            txtTenBS.Text = x.HoTen;
            txtKhoa.Text = x.Khoa.TenKhoa;
            txtEmailBS.Text = x.Email;
        }

        private void btnHoanThanh_Click(object sender, EventArgs e)
        {
            try
            {
                // Step 1: Create and save a new KhamBenh
                KhamBenh newKhamBenh = new KhamBenh
                {
                    MaBenhNhan = Convert.ToInt32(txtMaBN.Text),
                    MaBacSi = string.IsNullOrWhiteSpace(txtMaBS.Text) ? (int?)null : Convert.ToInt32(txtMaBS.Text),
                    NgayKham = DateTime.Now,
                    TrieuChung = txtTrieuChung.Text,
                    ChanDoan = txtChuanDoan.Text,
                    GhiChu = txtGhiChu.Text
                };

                LichSuKhamBUS lichSuKhamBUS = new LichSuKhamBUS();
                int maKhamBenh = lichSuKhamBUS.ThemKhamBenh(newKhamBenh);

                if (maKhamBenh <= 0)
                {
                    MessageBox.Show("Không thể thêm thông tin khám bệnh!", "Lỗi");
                    return;
                }

                // Step 2: Create and save a new DonThuoc associated with the KhamBenh
                DonThuoc newDonThuoc = new DonThuoc
                {
                    MaKhamBenh = maKhamBenh,
                    NgayKeDon = DateTime.Now
                };

                DonThuocBUS donThuocBUS = new DonThuocBUS();
                int maDonThuoc = donThuocBUS.ThemDonThuoc(newDonThuoc);

                if (maDonThuoc <= 0)
                {
                    MessageBox.Show("Không thể tạo đơn thuốc!", "Lỗi");
                    return;
                }

                // Step 3: Create ChiTietDonThuoc entries for each row in the DataGridView
                ChiTietDonThuocBUS chiTietDonThuocBUS = new ChiTietDonThuocBUS();

                foreach (DataGridViewRow row in dgv.Rows)
                {
                    // Skip empty rows
                    if (row.Cells["TenThuoc"].Value == null || string.IsNullOrWhiteSpace(row.Cells["TenThuoc"].Value.ToString()))
                        continue;

                    ChiTietDonThuoc chiTiet = new ChiTietDonThuoc
                    {
                        MaDonThuoc = maDonThuoc,
                        TenThuoc = row.Cells["TenThuoc"].Value.ToString(),
                        LieuLuong = row.Cells["LieuLuong"].Value?.ToString(),
                        SoLuong = row.Cells["SoLuong"].Value != null ? Convert.ToInt32(row.Cells["SoLuong"].Value) : (int?)null,
                        CachDung = row.Cells["CachDung"].Value?.ToString()
                    };

                    chiTietDonThuocBUS.ThemChiTietDonThuoc(chiTiet);
                }

                // Notify success
                MessageBox.Show($"Khám bệnh và đơn thuốc đã được thêm thành công với Mã Khám Bệnh: {maKhamBenh}", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi");
            }
        }
    }
}
