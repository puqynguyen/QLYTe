using System;
using System.Collections.Generic;
using System.Linq;
using DTO.Entities;
using DAL.DAL;

namespace BUS.BUS
{
    public class LichSuKhamBUS
    {
        private readonly LichSuKhamDAL _lichSuKhamDAL;

        public LichSuKhamBUS()
        {
            _lichSuKhamDAL = new LichSuKhamDAL();
        }

        public List<KhamBenh> LayTatCaLichSuKham()
        {
            try
            {
                return _lichSuKhamDAL.LayTatCaLichSuKham();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return new List<KhamBenh>();
            }
        }

        public List<KhamBenh> LayLichSuKhamTheoBenhNhan(int maBenhNhan)
        {
            try
            {
                var lichSuKham = _lichSuKhamDAL.LayTatCaLichSuKham()
                    .Where(k => k.MaBenhNhan == maBenhNhan).ToList();

                return lichSuKham;
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
                return _lichSuKhamDAL.TimKiemTheoMaKhamBenh(maKhamBenh);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return null;
            }
        }
    }
}
