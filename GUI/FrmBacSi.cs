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
    public partial class FrmBacSi : Form
    {
        BacSiBUS bacSiBUS = new BacSiBUS();
        public FrmBacSi()
        {
            InitializeComponent();
        }

        private void FrmBacSi_Load(object sender, EventArgs e)
        {
            ClearAllTextBoxes();
            Fill(bacSiBUS.LayDanhSachBacSi());
            FillCbb();
        }
        private void Fill(List<BacSi> list)
        {
            dgv.Rows.Clear();
            foreach (BacSi bs in list)
            {
                int index = dgv.Rows.Add();
                dgv.Rows[index].Cells[0].Value = bs.MaBacSi;
                dgv.Rows[index].Cells[1].Value = bs.HoTen;
                dgv.Rows[index].Cells[2].Value = bs.MaKhoa;
                dgv.Rows[index].Cells[3].Value = bs.SoDienThoai;
                dgv.Rows[index].Cells[4].Value = bs.Email;
            }
        }
        private void FillCbb()
        {
            KhoaBUS khoaBUS = new KhoaBUS();
            List<Khoa> khoas = new List<Khoa>();
            khoas = khoaBUS.LayDanhSachKhoa();
            cbb.DataSource = khoas;
            cbb.DisplayMember = "TenKhoa";
            cbb.ValueMember = "MaKhoa";
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

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgv.Columns[0].Index >= 0)
            {
                ClearAllTextBoxes();
                int maBS = Convert.ToInt32(dgv.Rows[e.RowIndex].Cells[0].Value);
                BacSi bacsi = bacSiBUS.TimKiemBacSi(maBS);
                txtMaBacSi.Text = bacsi.MaBacSi.ToString();
                txtEmail.Text = bacsi.Email;
                txtHoTen.Text = bacsi.HoTen.ToString();
                cbb.SelectedValue = Convert.ToInt32(bacsi.MaKhoa);
                txtSoDienThoai.Text = bacsi.SoDienThoai;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            BacSi bacSi = new BacSi();
            bacSi.HoTen = txtHoTen.Text;
            bacSi.Email = txtEmail.Text;
            bacSi.SoDienThoai = txtSoDienThoai.Text;
            bacSi.MaKhoa = (int?)cbb.SelectedValue;
            bacSiBUS.ThemBacSi(bacSi);
            Fill(bacSiBUS.LayDanhSachBacSi());
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int maBS = Convert.ToInt32(txtMaBacSi.Text);
            BacSi bacSi = bacSiBUS.TimKiemBacSi(maBS);
            bacSi.HoTen = txtHoTen.Text;
            bacSi.Email = txtEmail.Text;
            bacSi.SoDienThoai = txtSoDienThoai.Text;
            bacSi.MaKhoa = (int?)cbb.SelectedValue;
            bacSiBUS.SuaBacSi(bacSi);
            Fill(bacSiBUS.LayDanhSachBacSi());
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int maBS = Convert.ToInt32(txtMaBacSi.Text);
            bacSiBUS.XoaBacSi(maBS);
            Fill(bacSiBUS.LayDanhSachBacSi());
        }
    }
}
