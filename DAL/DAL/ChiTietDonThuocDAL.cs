using System;
using System.Collections.Generic;
using System.Linq;
using DTO.Entities;

namespace DAL.DAL
{
    public class ChiTietDonThuocDAL
    {
        private readonly DBContext _context;

        public ChiTietDonThuocDAL()
        {
            _context = new DBContext();
        }

        // Thêm chi tiết đơn thuốc
        public bool Them(ChiTietDonThuoc chiTiet)
        {
            try
            {
                _context.ChiTietDonThuocs.Add(chiTiet); 
                _context.SaveChanges();                
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
        }

        // Sửa chi tiết đơn thuốc
        public bool Sua(ChiTietDonThuoc chiTiet)
        {
            try
            {
                // Tìm đối tượng cần sửa
                var chiTietToUpdate = _context.ChiTietDonThuocs.FirstOrDefault(c => c.MaChiTiet == chiTiet.MaChiTiet);
                if (chiTietToUpdate != null)
                {
                    chiTietToUpdate.MaDonThuoc = chiTiet.MaDonThuoc;
                    chiTietToUpdate.TenThuoc = chiTiet.TenThuoc;
                    chiTietToUpdate.LieuLuong = chiTiet.LieuLuong;
                    chiTietToUpdate.SoLuong = chiTiet.SoLuong;
                    chiTietToUpdate.CachDung = chiTiet.CachDung;

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

        // Xóa chi tiết đơn thuốc
        public bool Xoa(int maChiTiet)
        {
            try
            {
                // Tìm đối tượng cần xóa
                var chiTietToDelete = _context.ChiTietDonThuocs.FirstOrDefault(c => c.MaChiTiet == maChiTiet);
                if (chiTietToDelete != null)
                {
                    _context.ChiTietDonThuocs.Remove(chiTietToDelete); // Xóa đối tượng khỏi DbSet
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

        // Lấy danh sách tất cả chi tiết đơn thuốc
        public List<ChiTietDonThuoc> LayDanhSach()
        {
            try
            {
                return _context.ChiTietDonThuocs.ToList(); // Lấy toàn bộ danh sách
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return new List<ChiTietDonThuoc>();
            }
        }
    }
}
