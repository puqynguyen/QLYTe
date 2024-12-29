using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnBacSi_Click(object sender, EventArgs e)
        {
            FrmBacSi frmBacSi = new FrmBacSi();
            frmBacSi.ShowDialog();
        }

        private void btnKhoa_Click(object sender, EventArgs e)
        {
            FrmKhoa frm = new FrmKhoa();
            frm.ShowDialog();
        }

        private void btnBenhNhan_Click(object sender, EventArgs e)
        {
            FrmBenhNhan frmBenhNhan = new FrmBenhNhan();
            frmBenhNhan.ShowDialog();
        }

        private void btnLichSuKham_Click(object sender, EventArgs e)
        {
            FrmLichSuKham frm = new FrmLichSuKham();
            frm.ShowDialog();
        }

        private void btnDonThuoc_Click(object sender, EventArgs e)
        {
            FrmKhamBenh frmKhamBenh = new FrmKhamBenh();
            frmKhamBenh.ShowDialog();
        }
    }
}
