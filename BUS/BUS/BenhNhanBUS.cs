using System;
using System.Collections.Generic;
using DAL.DAL;
using DTO.Entities;

namespace BUS.BUS
{
    public class BenhNhanBUS
    {
        private BenhNhanDAL benhNhanDAL;

        public BenhNhanBUS()
        {
            benhNhanDAL = new BenhNhanDAL();
        }

        // Thêm bệnh nhân
        public bool ThemBenhNhan(BenhNhan benhNhan)
        {
            return benhNhanDAL.Them(benhNhan);
        }

        // Sửa thông tin bệnh nhân
        public bool SuaBenhNhan(BenhNhan benhNhan)
        {
            return benhNhanDAL.Sua(benhNhan);
        }

        // Xóa bệnh nhân
        public bool XoaBenhNhan(int maBenhNhan)
        {
            return benhNhanDAL.Xoa(maBenhNhan);
        }

        // Lấy lịch sử khám bệnh
        public List<KhamBenh> LayLichSuKhamBenh(int maBenhNhan)
        {
            return benhNhanDAL.LayLichSuKhamBenh(maBenhNhan);
        }

        // Lấy danh sách bệnh nhân
        public List<BenhNhan> LayDanhSachBenhNhan()
        {
            return benhNhanDAL.LayDanhSach();
        }
    }
}
