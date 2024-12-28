using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO.Entities;

namespace DAL.DAL
{
    public class KhoaDAL
    {
        private string connectionString = "DBContextYT";

        // Lấy danh sách tất cả các khoa
        public List<Khoa> LayDanhSach()
        {
            List<Khoa> danhSachKhoa = new List<Khoa>();

            string query = "SELECT MaKhoa, TenKhoa, MoTa FROM Khoa";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Khoa khoa = new Khoa
                                {
                                    MaKhoa = reader.GetInt32(0),
                                    TenKhoa = reader.GetString(1),
                                    MoTa = reader.IsDBNull(2) ? null : reader.GetString(2)
                                };

                                danhSachKhoa.Add(khoa);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                    }
                }
            }

            return danhSachKhoa;
        }

        // Thêm khoa
        public bool Them(Khoa khoa)
        {
            string query = @"
                INSERT INTO Khoa (MaKhoa, TenKhoa, MoTa)
                VALUES (@MaKhoa, @TenKhoa, @MoTa)";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaKhoa", khoa.MaKhoa);
                command.Parameters.AddWithValue("@TenKhoa", khoa.TenKhoa);
                command.Parameters.AddWithValue("@MoTa", khoa.MoTa);

                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }

        // Sửa khoa
        public bool Sua(Khoa khoa)
        {
            string query = @"
            UPDATE Khoa
            SET TenKhoa = @TenKhoa, MoTa = @MoTa
            WHERE MaKhoa = @MaKhoa";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaKhoa", khoa.MaKhoa);
                command.Parameters.AddWithValue("@TenKhoa", khoa.TenKhoa);
                command.Parameters.AddWithValue("@MoTa", khoa.MoTa);

                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }


        // Xóa khoa
        public bool Xoa(int maKhoa)
        {
            string query = "DELETE FROM Khoa WHERE MaKhoa = @MaKhoa";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaKhoa", maKhoa);

                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }
    }
}
