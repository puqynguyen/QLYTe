using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using DTO.Entities;

namespace DAL.DAL
{
    public class ChiTietDonThuocDAL
    {
        private string connectionString = "DBContextYT"; // Thay bằng chuỗi kết nối thực tế

        // Thêm chi tiết đơn thuốc
        public bool Them(ChiTietDonThuoc chiTiet)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO ChiTietDonThuoc (MaChiTiet, MaDonThuoc, TenThuoc, LieuLuong, SoLuong, CachDung) " +
                               "VALUES (@MaChiTiet, @MaDonThuoc, @TenThuoc, @LieuLuong, @SoLuong, @CachDung)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MaChiTiet", chiTiet.MaChiTiet);
                    command.Parameters.AddWithValue("@MaDonThuoc", chiTiet.MaDonThuoc);
                    command.Parameters.AddWithValue("@TenThuoc", chiTiet.TenThuoc);
                    command.Parameters.AddWithValue("@LieuLuong", chiTiet.LieuLuong ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@SoLuong", chiTiet.SoLuong ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@CachDung", chiTiet.CachDung ?? (object)DBNull.Value);

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                        return false;
                    }
                }
            }
        }

        // Sửa chi tiết đơn thuốc
        public bool Sua(ChiTietDonThuoc chiTiet)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE ChiTietDonThuoc " +
                               "SET MaDonThuoc = @MaDonThuoc, TenThuoc = @TenThuoc, LieuLuong = @LieuLuong, SoLuong = @SoLuong, CachDung = @CachDung " +
                               "WHERE MaChiTiet = @MaChiTiet";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MaChiTiet", chiTiet.MaChiTiet);
                    command.Parameters.AddWithValue("@MaDonThuoc", chiTiet.MaDonThuoc);
                    command.Parameters.AddWithValue("@TenThuoc", chiTiet.TenThuoc);
                    command.Parameters.AddWithValue("@LieuLuong", chiTiet.LieuLuong ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@SoLuong", chiTiet.SoLuong ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@CachDung", chiTiet.CachDung ?? (object)DBNull.Value);

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                        return false;
                    }
                }
            }
        }

        // Xóa chi tiết đơn thuốc
        public bool Xoa(int maChiTiet)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM ChiTietDonThuoc WHERE MaChiTiet = @MaChiTiet";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MaChiTiet", maChiTiet);

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                        return false;
                    }
                }
            }
        }


        public List<ChiTietDonThuoc> LayDanhSach()
        {
            List<ChiTietDonThuoc> danhSachChiTiet = new List<ChiTietDonThuoc>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT MaChiTiet, MaDonThuoc, TenThuoc, LieuLuong, SoLuong, CachDung FROM ChiTietDonThuoc";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ChiTietDonThuoc chiTiet = new ChiTietDonThuoc
                                {
                                    MaChiTiet = reader.GetInt32(0),
                                    MaDonThuoc = reader.GetInt32(1),
                                    TenThuoc = reader.GetString(2),
                                    LieuLuong = reader.IsDBNull(3) ? null : reader.GetString(3),
                                    SoLuong = reader.IsDBNull(4) ? (int?)null : reader.GetInt32(4),
                                    CachDung = reader.IsDBNull(5) ? null : reader.GetString(5)
                                };

                                danhSachChiTiet.Add(chiTiet);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                    }
                }
            }

            return danhSachChiTiet;
        }
    }
}
