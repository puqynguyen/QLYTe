using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BUS.BUS;
using DTO.Entities;

namespace GUI
{
    public partial class FrmDonThuoc : Form
    {
        private int MaKhamBenh;

        public FrmDonThuoc(int maKhamBenh)
        {
            InitializeComponent();
            MaKhamBenh = maKhamBenh;
            try
            {
                DonThuocBUS donThuocBUS = new DonThuocBUS();
                ChiTietDonThuocBUS chiTietDonThuocBUS = new ChiTietDonThuocBUS();
                DonThuoc donThuoc = donThuocBUS.LayDanhSachDonThuoc()
                                               .FirstOrDefault(d => d.MaKhamBenh == MaKhamBenh);

                if (donThuoc != null)
                {
                    List<ChiTietDonThuoc> chiTietDonThuocs = chiTietDonThuocBUS.LayDanhSachChiTietDonThuoc()
                                                                               .Where(ct => ct.MaDonThuoc == donThuoc.MaDonThuoc)
                                                                               .ToList();
                    FillDataGridView(chiTietDonThuocs);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy đơn thuốc cho mã khám bệnh này!", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi");
            }
        }

        private void FillDataGridView(List<ChiTietDonThuoc> chiTietDonThuocs)
        {
            dgv.Rows.Clear();

            foreach (var chiTiet in chiTietDonThuocs)
            {
                int rowIndex = dgv.Rows.Add();
                dgv.Rows[rowIndex].Cells[0].Value = chiTiet.TenThuoc;
                dgv.Rows[rowIndex].Cells["LieuLuong"].Value = chiTiet.LieuLuong;
                dgv.Rows[rowIndex].Cells["SoLuong"].Value = chiTiet.SoLuong;
                dgv.Rows[rowIndex].Cells["CachDung"].Value = chiTiet.CachDung;
            }
        }
    }
}
