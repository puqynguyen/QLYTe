using System;
using System.Collections.Generic;
using System.Linq;
using DTO.Entities;

namespace DAL.DAL
{
    public class KhoaDAL
    {
        private readonly DBContext _context;

        public KhoaDAL()
        {
            _context = new DBContext();
        }

        // Lấy danh sách tất cả các khoa
        public List<Khoa> LayDanhSach()
        {
            try
            {
                return _context.Khoas.ToList(); // Lấy toàn bộ danh sách khoa từ bảng Khoa
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return new List<Khoa>();
            }
        }

        // Thêm khoa
        public bool Them(Khoa khoa)
        {
            try
            {
                _context.Khoas.Add(khoa); 
                _context.SaveChanges();  
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
        }

        // Sửa khoa
        public bool Sua(Khoa khoa)
        {
            try
            {
                // Tìm đối tượng Khoa cần sửa
                var khoaToUpdate = _context.Khoas.FirstOrDefault(k => k.MaKhoa == khoa.MaKhoa);
                if (khoaToUpdate != null)
                {
                    khoaToUpdate.TenKhoa = khoa.TenKhoa;
                    khoaToUpdate.MoTa = khoa.MoTa;

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

        // Xóa khoa
        public bool Xoa(int maKhoa)
        {
            try
            {
                // Tìm đối tượng Khoa cần xóa
                var khoaToDelete = _context.Khoas.FirstOrDefault(k => k.MaKhoa == maKhoa);
                if (khoaToDelete != null)
                {
                    _context.Khoas.Remove(khoaToDelete); // Xóa đối tượng Khoa khỏi DbSet
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

        // Tìm kiếm khoa theo mã
        public Khoa TimKiem(int maKhoa)
        {
            try
            {
                return _context.Khoas.FirstOrDefault(k => k.MaKhoa == maKhoa); 
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return null; 
            }
        }
    }
}
