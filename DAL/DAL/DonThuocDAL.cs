using System;
using System.Collections.Generic;
using System.Linq;
using DTO.Entities;

namespace DAL.DAL
{
    public class DonThuocDAL
    {
        private readonly DBContext _context;

        public DonThuocDAL()
        {
            _context = new DBContext();
        }

        // Thêm đơn thuốc
        public bool Them(DonThuoc donThuoc)
        {
            try
            {
                _context.DonThuocs.Add(donThuoc); 
                _context.SaveChanges();          
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
        }

        // Sửa đơn thuốc
        public bool Sua(DonThuoc donThuoc)
        {
            try
            {
                // Tìm đối tượng DonThuoc cần sửa
                var donThuocToUpdate = _context.DonThuocs.FirstOrDefault(d => d.MaDonThuoc == donThuoc.MaDonThuoc);
                if (donThuocToUpdate != null)
                {
                    donThuocToUpdate.MaKhamBenh = donThuoc.MaKhamBenh;
                    donThuocToUpdate.NgayKeDon = donThuoc.NgayKeDon;
                    donThuocToUpdate.GhiChu = donThuoc.GhiChu;

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

        // Xóa đơn thuốc
        public bool Xoa(int maDonThuoc)
        {
            try
            {
                // Tìm đối tượng DonThuoc cần xóa
                var donThuocToDelete = _context.DonThuocs.FirstOrDefault(d => d.MaDonThuoc == maDonThuoc);
                if (donThuocToDelete != null)
                {
                    _context.DonThuocs.Remove(donThuocToDelete); 
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


        public DonThuoc TimKiem(int maDonThuoc)
        {
            try
            {
                return _context.DonThuocs.FirstOrDefault(b => b.MaDonThuoc == maDonThuoc); // Tìm kiếm chính xác theo mã
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return null; // Trả về null nếu không tìm thấy hoặc có lỗi
            }
        }





        // Lấy danh sách tất cả đơn thuốc
        public List<DonThuoc> LayDanhSach()
        {
            try
            {
                return _context.DonThuocs.ToList(); // Lấy toàn bộ danh sách từ bảng DonThuoc
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return new List<DonThuoc>();
            }
        }
    }
}
