using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO.Entities;

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
        public List<BacSi> TimKiemBacSi(string keyword)
        {
            return bacSiDAL.TimKiem(keyword);
        }

        // Lấy danh sách bác sĩ
        public List<BacSi> LayDanhSachBacSi()
        {
            return bacSiDAL.LayDanhSach();
        }


    }
}
