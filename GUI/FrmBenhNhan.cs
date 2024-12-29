using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS.BUS;
using DTO.Entities;

namespace GUI
{
    public partial class FrmBenhNhan : Form
    {
        public delegate void SelectBenhNhanHandler(int maBenhNhan);
        public event SelectBenhNhanHandler OnSelectBenhNhan;
        BenhNhanBUS BUS = new BenhNhanBUS();
        public FrmBenhNhan()
        {
            InitializeComponent();
            Fill(BUS.LayDanhSachBenhNhan());
        }
        public FrmBenhNhan(bool kham = true)
        {
            InitializeComponent();
            Fill(BUS.LayDanhSachBenhNhan());
            btnThem.Visible = false;
            btnSua.Visible = false;
            btnXoa.Visible = false;
            btnChon.Visible = true;
        }
        private void Fill(List<BenhNhan> list)
        {
            dgv.Rows.Clear();
            foreach (BenhNhan x in list)
            {
                int index = dgv.Rows.Add();
                dgv.Rows[index].Cells[0].Value = x.MaBenhNhan;
                dgv.Rows[index].Cells[1].Value = x.HoTen;
                dgv.Rows[index].Cells[2].Value = x.NgaySinh;
                dgv.Rows[index].Cells[3].Value = x.GioiTinh;
                dgv.Rows[index].Cells[4].Value = x.DiaChi;
                dgv.Rows[index].Cells[5].Value = x.SoDienThoai;
                dgv.Rows[index].Cells[6].Value = x.CMND_CCCD;
                dgv.Rows[index].Cells[7].Value = x.NgayDangKy;
            }
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgv.Columns[0].Index >= 0)
            {
                int maX = Convert.ToInt32(dgv.Rows[e.RowIndex].Cells[0].Value);
                BenhNhan x = BUS.TimKiemBenhNhan(maX);
                txtMaBenhNhan.Text = x.MaBenhNhan.ToString();
                txtCCCD.Text = x.CMND_CCCD;
                txtHoTen.Text = x.HoTen.ToString();
                txtDiaChi.Text = x.DiaChi;
                dtpNgaySinh.Value = x.NgaySinh.Value;
                txtSoDienThoai.Text = x.SoDienThoai;
                txtGioiTinh.Text = x.GioiTinh;
            }
        }
        private void ClearAllTextBoxes()
        {
            DuyetTatCaTextBox(this);
        }

        private void DuyetTatCaTextBox(Control parentControl)
        {
            foreach (Control control in parentControl.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Text = string.Empty;
                }
                if (control.HasChildren)
                {
                    DuyetTatCaTextBox(control);
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            BenhNhan x = new BenhNhan();
            x.HoTen = txtHoTen.Text;
            x.CMND_CCCD = txtCCCD.Text;
            x.DiaChi = txtDiaChi.Text;
            x.GioiTinh = txtGioiTinh.Text;
            x.NgayDangKy = DateTime.Now;
            x.NgaySinh = dtpNgaySinh.Value;
            ClearAllTextBoxes();
            Fill(BUS.LayDanhSachBenhNhan());
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int maX = Convert.ToInt32(txtMaBenhNhan.Text);
            BenhNhan x = BUS.TimKiemBenhNhan(maX);
            x.HoTen = txtHoTen.Text;
            x.DiaChi = txtDiaChi.Text;
            x.GioiTinh = txtGioiTinh.Text;
            x.NgaySinh = dtpNgaySinh.Value;
            x.SoDienThoai = txtSoDienThoai.Text;
            x.CMND_CCCD = txtCCCD.Text;
            BUS.SuaBenhNhan(x);
            ClearAllTextBoxes();
            Fill(BUS.LayDanhSachBenhNhan());
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            int maX = Convert.ToInt32(txtMaBenhNhan.Text);
            BUS.XoaBenhNhan(maX);
            ClearAllTextBoxes();
            Fill(BUS.LayDanhSachBenhNhan());
        }

        private void txtMaBenhNhan_TextChanged(object sender, EventArgs e)
        {
            lblLichSuKham.Visible = true;
            int maX = Convert.ToInt32(txtMaBenhNhan.Text);
            BenhNhan x = BUS.TimKiemBenhNhan(maX);
            lblLichSuKham.Text = "Xem lịch sử khám của:" + x.HoTen;
        }

        private void lblLichSuKham_Click(object sender, EventArgs e)
        {
            int maX = Convert.ToInt32(txtMaBenhNhan.Text);
            FrmLichSuKham frmLichSuKham = new FrmLichSuKham(maX);
            frmLichSuKham.ShowDialog();
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            if (txtMaBenhNhan.Text != "")
            {
                int maBenhNhan = Convert.ToInt32(txtMaBenhNhan.Text);
                OnSelectBenhNhan?.Invoke(maBenhNhan);
                this.Close();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một bệnh nhân!");
            }
        }
    }
}
