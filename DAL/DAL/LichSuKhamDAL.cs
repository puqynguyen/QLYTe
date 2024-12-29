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

        // Method to add a new KhamBenh
        public int ThemKhamBenh(KhamBenh khamBenh)
        {
            try
            {
                using (var db = new DBContext())
                {
                    db.KhamBenhs.Add(khamBenh);
                    db.SaveChanges();
                    return khamBenh.MaKhamBenh; // Return the ID of the newly created KhamBenh
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return -1; // Return -1 to indicate an error
            }
        }
    }
}
