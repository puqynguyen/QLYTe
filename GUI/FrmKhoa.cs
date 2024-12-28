using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS.BUS;
using DTO.Entities;

namespace GUI
{
    public partial class FrmKhoa : Form
    {
        KhoaBUS khoaBUS = new KhoaBUS();
        public FrmKhoa()
        {
            InitializeComponent();
        }

        private void FrmKhoa_Load(object sender, EventArgs e)
        {
            Fill(khoaBUS.LayDanhSachKhoa());
        }
        private void Fill(List<Khoa> list)
        {
            dgv.Rows.Clear();
            foreach (Khoa x in list)
            {
                int index = dgv.Rows.Add();
                dgv.Rows[index].Cells[0].Value = x.MaKhoa;
                dgv.Rows[index].Cells[1].Value = x.TenKhoa;
                dgv.Rows[index].Cells[2].Value = x.MoTa;
            }
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgv.Columns[0].Index >= 0)
            {
                Clear();
                txtMa.Text = dgv.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTen.Text = dgv.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtMoTa.Text = dgv.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
        }
        private void Clear()
        {
            txtMa.Text = "";
            txtTen.Text = "";
            txtMoTa.Text = "";
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            Khoa khoa = new Khoa();
            khoa.MaKhoa = Convert.ToInt32(txtMa.Text);
            khoa.TenKhoa = txtTen.Text;
            khoa.MoTa = txtMoTa.Text;
            khoaBUS.ThemKhoa(khoa);
            Fill(khoaBUS.LayDanhSachKhoa());
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Khoa khoa = new Khoa();
            khoa.MaKhoa = Convert.ToInt32(txtMa.Text);
            khoa.TenKhoa = txtTen.Text;
            khoa.MoTa = txtMoTa.Text;
            khoaBUS.SuaKhoa(khoa);
            Fill(khoaBUS.LayDanhSachKhoa());
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int maKhoa = Convert.ToInt32(txtMa.Text);
            khoaBUS.XoaKhoa(maKhoa);
            Fill(khoaBUS.LayDanhSachKhoa());
        }
    }
}
