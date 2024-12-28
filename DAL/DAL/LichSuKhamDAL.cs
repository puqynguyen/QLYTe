using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using DTO.Entities;

namespace DAL.DAL
{
    public class LichSuKhamDAL
    {
        public List<KhamBenh> LayTatCaLichSuKham()
        {
            try
            {
                using (var db = new DBContext())
                {
                    return db.KhamBenhs
                             .Include("BacSi")
                             .Include("BenhNhan")
                             .ToList();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return new List<KhamBenh>();
            }
        }

        // Method to find a medical record by MaKhamBenh
        public KhamBenh TimKiemTheoMaKhamBenh(int maKhamBenh)
        {
            try
            {
                using (var db = new DBContext())
                {
                    return db.KhamBenhs
                     .Include("BacSi.Khoa") // Include related Khoa through BacSi
                     .Include("BenhNhan") // Include related BenhNhan
                     .FirstOrDefault(k => k.MaKhamBenh == maKhamBenh);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return null;
            }
        }
    }
}
