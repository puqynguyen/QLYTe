using DAL.DAL;
using DTO.Entities;
using System.Collections.Generic;

namespace BUS.BUS
{
    public class BacSiBUS
    {
        private BacSiDAL bacSiDAL;

        public BacSiBUS()
        {
            bacSiDAL = new BacSiDAL();
        }

        // Thêm bác sĩ
        public bool ThemBacSi(BacSi bacSi)
        {
            return bacSiDAL.Them(bacSi);
        }

        // Sửa bác sĩ
        public bool SuaBacSi(BacSi bacSi)
        {
            return bacSiDAL.Sua(bacSi);
        }

        // Xóa bác sĩ
        public bool XoaBacSi(int maBacSi)
        {
            return bacSiDAL.Xoa(maBacSi);
        }

        // Tìm kiếm bác sĩ
        public BacSi TimKiemBacSi(int maBacSi)
        {
            return bacSiDAL.TimKiem(maBacSi);
        }

        // Lấy danh sách bác sĩ
        public List<BacSi> LayDanhSachBacSi()
        {
            return bacSiDAL.LayDanhSach();
        }


    }
}
