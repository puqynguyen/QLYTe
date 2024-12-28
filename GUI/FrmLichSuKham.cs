using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS.BUS;
using DTO.Entities;

namespace GUI
{
    public partial class FrmLichSuKham : Form
    {
        LichSuKhamBUS BUS = new LichSuKhamBUS();
        public FrmLichSuKham()
        {
            InitializeComponent();
            Fill(BUS.LayTatCaLichSuKham());
        }
        public FrmLichSuKham(int maBN)
        {
            InitializeComponent();
            txtTimKiem.Text = maBN.ToString();
        }
        private void Fill(List<KhamBenh> list)
        {
            dgv.Rows.Clear();
            foreach (KhamBenh x in list)
            {
                int index = dgv.Rows.Add();
                dgv.Rows[index].Cells[0].Value = x.MaKhamBenh;
                dgv.Rows[index].Cells[1].Value = x.BenhNhan.HoTen;
                dgv.Rows[index].Cells[2].Value = x.BacSi.HoTen;
                dgv.Rows[index].Cells[3].Value = x.NgayKham;
            }
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgv.Columns[0].Index >= 0)
            {
                int maX = Convert.ToInt32(dgv.Rows[e.RowIndex].Cells[0].Value);
                KhamBenh x = BUS.TimKiemTheoMaKhamBenh(maX);
                txtMaBenhNhan.Text = x.MaBenhNhan.ToString();
                txtMaKhamBenh.Text = x.MaKhamBenh.ToString();
                txtMaBenhNhan.Text = x.MaBenhNhan.ToString();
                txtTenBenhNhan.Text = x.BenhNhan.HoTen;
                txtMaBacSi.Text = x.MaBacSi.ToString();
                txtTenBacSi.Text = x.BacSi.HoTen;
                txtKhoa.Text = x.BacSi.Khoa.TenKhoa;
                txtNgayKham.Text = x.NgayKham.ToString();
                txtTrieuChung.Text = x.TrieuChung;
                txtChuanDoan.Text = x.ChanDoan.ToString();
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string input = txtTimKiem.Text.Trim();
            List<KhamBenh> result;

            if (string.IsNullOrEmpty(input))
            {
                result = BUS.LayTatCaLichSuKham();
            }
            else if (int.TryParse(input, out int maBenhNhan))
            {
                result = BUS.LayLichSuKhamTheoBenhNhan(maBenhNhan);
            }
            else
            {
                result = BUS.LayTatCaLichSuKham()
                            .Where(k => k.BenhNhan.HoTen.ToLower().Contains(input.ToLower()))
                            .ToList();
            }
            Fill(result);
        }


    }
}
