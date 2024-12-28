using System;
using System.Collections.Generic;
using System.Linq;
using DTO.Entities;

namespace DAL.DAL
{
    public class BacSiDAL
    {
        private readonly DBContext _context;

        public BacSiDAL()
        {
            _context = new DBContext();
        }

        // Thêm bác sĩ
        public bool Them(BacSi bacSi)
        {
            try
            {
                _context.BacSis.Add(bacSi); 
                _context.SaveChanges();    
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
        }

        // Sửa thông tin bác sĩ
        public bool Sua(BacSi bacSi)
        {
            try
            {
                var bacSiToUpdate = _context.BacSis.FirstOrDefault(b => b.MaBacSi == bacSi.MaBacSi);
                if (bacSiToUpdate != null)
                {
                    bacSiToUpdate.HoTen = bacSi.HoTen;
                    bacSiToUpdate.MaKhoa = bacSi.MaKhoa;
                    bacSiToUpdate.SoDienThoai = bacSi.SoDienThoai;
                    bacSiToUpdate.Email = bacSi.Email;

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

        // Xóa bác sĩ
        public bool Xoa(int maBacSi)
        {
            try
            {
                var bacSiToDelete = _context.BacSis.FirstOrDefault(b => b.MaBacSi == maBacSi);
                if (bacSiToDelete != null)
                {
                    _context.BacSis.Remove(bacSiToDelete); 
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

        // Tìm kiếm bác sĩ theo mã
        public BacSi TimKiem(int maBacSi)
        {
            try
            {
                return _context.BacSis.FirstOrDefault(b => b.MaBacSi == maBacSi); // Tìm kiếm chính xác theo mã
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return null; // Trả về null nếu không tìm thấy hoặc có lỗi
            }
        }


        // Lấy danh sách tất cả bác sĩ
        public List<BacSi> LayDanhSach()
        {
            try
            {
                return _context.BacSis.ToList(); // Lấy toàn bộ danh sách bác sĩ
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return new List<BacSi>();
            }
        }
    }
}
