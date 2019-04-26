using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM02
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnBanHang_Click(object sender, EventArgs e)
        {
            panelHover.Location = btnBanHang.Location;
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            panelHover.Location = btnSanPham.Location;
            frmSanPham frm = frmSanPham.CreateInstance();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            panelHover.Location = btnHoaDon.Location;
            frmDonHang frm = frmDonHang.CreateInstance();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            panelHover.Location = btnKhachHang.Location;
            frmKhachHang frm = frmKhachHang.CreateInstance();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnHangTV_Click(object sender, EventArgs e)
        {
            panelHover.Location = btnHangTV.Location;
            frmHangThanhVien frm = frmHangThanhVien.CreateInstance();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnKiemDuyet_Click(object sender, EventArgs e)
        {
            panelHover.Location = btnKiemDuyet.Location;
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            panelHover.Location = btnNhanVien.Location;
            frmNhanVien frm = frmNhanVien.CreateInstance();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
