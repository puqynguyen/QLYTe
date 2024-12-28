using System.Collections.Generic;
using DAL.DAL;
using DTO.Entities;

namespace BUS.BUS
{
    public class ChiTietDonThuocBUS
    {
        private ChiTietDonThuocDAL chiTietDonThuocDAL;

        public ChiTietDonThuocBUS()
        {
            chiTietDonThuocDAL = new ChiTietDonThuocDAL();
        }

        // Thêm chi tiết đơn thuốc
        public bool ThemChiTietDonThuoc(ChiTietDonThuoc chiTiet)
        {
            return chiTietDonThuocDAL.Them(chiTiet);
        }

        // Sửa chi tiết đơn thuốc
        public bool SuaChiTietDonThuoc(ChiTietDonThuoc chiTiet)
        {
            return chiTietDonThuocDAL.Sua(chiTiet);
        }

        // Xóa chi tiết đơn thuốc
        public bool XoaChiTietDonThuoc(int maChiTiet)
        {
            return chiTietDonThuocDAL.Xoa(maChiTiet);
        }

        // Lấy danh sách chi tiết đơn thuốc
        public List<ChiTietDonThuoc> LayDanhSachChiTietDonThuoc()
        {
            return chiTietDonThuocDAL.LayDanhSach();
        }
    }
}
