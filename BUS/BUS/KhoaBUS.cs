using System.Collections.Generic;
using System.Data;
using DAL.DAL;
using DTO.Entities;

namespace BUS.BUS
{
    public class KhoaBUS
    {
        private KhoaDAL khoaDAL;

        public KhoaBUS()
        {
            khoaDAL = new KhoaDAL();
        }

        public List<Khoa> LayDanhSachKhoa()
        {
            return khoaDAL.LayDanhSach();
        }

        public bool ThemKhoa(Khoa khoa)
        {
            return khoaDAL.Them(khoa);
        }

        public bool SuaKhoa(Khoa khoa)
        {
            return khoaDAL.Sua(khoa);
        }

        public bool XoaKhoa(int maKhoa)
        {
            return khoaDAL.Xoa(maKhoa); 
        }

        public Khoa TimKiemKhoa(int maKhoa)
        {
            return khoaDAL.TimKiem(maKhoa);
        }
    }
}
