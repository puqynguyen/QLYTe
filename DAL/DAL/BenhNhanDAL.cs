using System;
using System.Collections.Generic;
using System.Linq;
using DTO.Entities;

namespace DAL.DAL
{
    public class BenhNhanDAL
    {
        private readonly DBContext _context;

        public BenhNhanDAL()
        {
            _context = new DBContext();
        }

        // Thêm bệnh nhân
        public bool Them(BenhNhan benhNhan)
        {
            try
            {
                _context.BenhNhans.Add(benhNhan); 
                _context.SaveChanges();          
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
        }

        // Sửa thông tin bệnh nhân
        public bool Sua(BenhNhan benhNhan)
        {
            try
            {
                // Tìm đối tượng cần sửa
                var benhNhanToUpdate = _context.BenhNhans.FirstOrDefault(b => b.MaBenhNhan == benhNhan.MaBenhNhan);
                if (benhNhanToUpdate != null)
                {
                    benhNhanToUpdate.HoTen = benhNhan.HoTen;
                    benhNhanToUpdate.NgaySinh = benhNhan.NgaySinh;
                    benhNhanToUpdate.GioiTinh = benhNhan.GioiTinh;
                    benhNhanToUpdate.DiaChi = benhNhan.DiaChi;
                    benhNhanToUpdate.SoDienThoai = benhNhan.SoDienThoai;
                    benhNhanToUpdate.CMND_CCCD = benhNhan.CMND_CCCD;

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

        // Xóa bệnh nhân
        public bool Xoa(int maBenhNhan)
        {
            try
            {
                // Tìm đối tượng cần xóa
                var benhNhanToDelete = _context.BenhNhans.FirstOrDefault(b => b.MaBenhNhan == maBenhNhan);
                if (benhNhanToDelete != null)
                {
                    _context.BenhNhans.Remove(benhNhanToDelete); // Xóa đối tượng khỏi DbSet
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

        // Lấy lịch sử khám bệnh của một bệnh nhân
        public List<KhamBenh> LayLichSuKhamBenh(int maBenhNhan)
        {
            try
            {
                return _context.KhamBenhs
                               .Where(k => k.MaBenhNhan == maBenhNhan)
                               .ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return new List<KhamBenh>();
            }
        }

        // Lấy danh sách tất cả bệnh nhân
        public List<BenhNhan> LayDanhSach()
        {
            try
            {
                return _context.BenhNhans.ToList(); // Lấy toàn bộ danh sách
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return new List<BenhNhan>();
            }
        }


        public BenhNhan TimKiem(int maBenhNhan)
        {
            try
            {
                return _context.BenhNhans.FirstOrDefault(b => b.MaBenhNhan == maBenhNhan);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return null; 
            }
        }


    }
}
