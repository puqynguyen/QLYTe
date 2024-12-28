using System;
using System.Collections.Generic;
using DAL.DAL;
using DTO.Entities;

namespace BUS.BUS
{
    public class KhamBenhBUS
    {
        private KhamBenhDAL khamBenhDAL;

        public KhamBenhBUS()
        {
            khamBenhDAL = new KhamBenhDAL();
        }

        public bool ThemKhamBenh(KhamBenh khamBenh)
        {
            return khamBenhDAL.Them(khamBenh);
        }
    }
}
