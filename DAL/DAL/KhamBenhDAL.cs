using System;
using System.Collections.Generic;
using System.Linq;
using DTO.Entities;

namespace DAL.DAL
{
    public class KhamBenhDAL
    {
        private readonly DBContext _context;

        public KhamBenhDAL()
        {
            _context = new DBContext();
        }

        // Thêm thông tin khám bệnh
        public bool Them(KhamBenh khamBenh)
        {
            try
            {
                _context.KhamBenhs.Add(khamBenh); // Thêm đối tượng KhamBenh vào DbSet
                _context.SaveChanges();          // Lưu thay đổi vào cơ sở dữ liệu
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
        }

        // Sửa thông tin khám bệnh
        public bool Sua(KhamBenh khamBenh)
        {
            try
            {
                // Tìm đối tượng KhamBenh cần sửa
                var khamBenhToUpdate = _context.KhamBenhs.FirstOrDefault(k => k.MaKhamBenh == khamBenh.MaKhamBenh);
                if (khamBenhToUpdate != null)
                {
                    khamBenhToUpdate.MaBenhNhan = khamBenh.MaBenhNhan;
                    khamBenhToUpdate.MaBacSi = khamBenh.MaBacSi;
                    khamBenhToUpdate.NgayKham = khamBenh.NgayKham;
                    khamBenhToUpdate.ChanDoan = khamBenh.ChanDoan;
                    khamBenhToUpdate.Thuoc = khamBenh.Thuoc;
                    khamBenhToUpdate.GhiChu = khamBenh.GhiChu;

                    _context.SaveChanges(); // Lưu thay đổi
                    return true;
                }

                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
        }

        // Xóa thông tin khám bệnh
        public bool Xoa(int id)
        {
            try
            {
                // Tìm đối tượng KhamBenh cần xóa
                var khamBenhToDelete = _context.KhamBenhs.FirstOrDefault(k => k.MaKhamBenh == id);
                if (khamBenhToDelete != null)
                {
                    _context.KhamBenhs.Remove(khamBenhToDelete); 
                    _context.SaveChanges(); 
                    return true;
                }

                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
        }

        // Lấy danh sách tất cả thông tin khám bệnh
        public List<KhamBenh> LayDanhSach()
        {
            try
            {
                return _context.KhamBenhs.ToList(); // Lấy toàn bộ danh sách từ bảng KhamBenh
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return new List<KhamBenh>();
            }
        }


        // Tìm kiếm thông tin khám bệnh theo mã
        public KhamBenh TimKiem(int ma)
        {
            try
            {
                return _context.KhamBenhs.FirstOrDefault(k => k.MaKhamBenh == ma);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return null; // Trả về null nếu không tìm thấy hoặc xảy ra lỗi
            }
        }



    }
}
