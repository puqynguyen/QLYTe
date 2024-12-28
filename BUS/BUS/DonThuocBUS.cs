using System;
using System.Collections.Generic;
using DAL.DAL;
using DTO.Entities;

namespace BUS.BUS
{
    public class DonThuocBUS
    {
        private DonThuocDAL donThuocDAL;

        public DonThuocBUS()
        {
            donThuocDAL = new DonThuocDAL();
        }

        // Thêm đơn thuốc
        public bool ThemDonThuoc(DonThuoc donThuoc)
        {
            return donThuocDAL.Them(donThuoc);
        }

        // Sửa đơn thuốc
        public bool SuaDonThuoc(DonThuoc donThuoc)
        {
            return donThuocDAL.Sua(donThuoc);
        }

        // Xóa đơn thuốc
        public bool XoaDonThuoc(int maDonThuoc)
        {
            return donThuocDAL.Xoa(maDonThuoc);
        }

        // Tìm kiếm đơn thuốc
        public List<DonThuoc> TimKiemDonThuoc(string keyword)
        {
            return donThuocDAL.TimKiem(keyword);
        }

        // Lấy danh sách đơn thuốc
        public List<DonThuoc> LayDanhSachDonThuoc()
        {
            return donThuocDAL.LayDanhSach();
        }

    }
}
