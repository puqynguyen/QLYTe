using DTO.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAL
{
     public class KhamBenhDAL
    {
        private string connectionString = "DBContextYT";
        public bool Them(KhamBenh khamBenh)
        {
            string query = @"
                INSERT INTO KhamBenh (MaBenhNhan, MaBacSi, NgayKham, ChanDoan, Thuoc, GhiChu)
                VALUES (@MaBenhNhan, @MaBacSi, @NgayKham, @ChanDoan, @Thuoc, @GhiChu);";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@MaBenhNhan", khamBenh.MaBenhNhan);
                    command.Parameters.AddWithValue("@MaBacSi", khamBenh.MaBacSi);
                    command.Parameters.AddWithValue("@NgayKham", khamBenh.NgayKham);
                    command.Parameters.AddWithValue("@ChanDoan", khamBenh.ChanDoan);
                    command.Parameters.AddWithValue("@Thuoc", khamBenh.Thuoc);
                    command.Parameters.AddWithValue("@GhiChu", khamBenh.GhiChu);

                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    // Log lỗi hoặc xử lý lỗi
                    Console.WriteLine(ex.Message);
                    return false;
                }
            }
        }


    }



}
