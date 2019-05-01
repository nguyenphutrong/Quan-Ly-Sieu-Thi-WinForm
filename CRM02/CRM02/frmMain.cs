using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
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

        private void HienThiForm(Form frm)
        {
            frm.MdiParent = this;
            frm.Show();
            frm.BringToFront();
        }

        private void btnBanHang_Click(object sender, EventArgs e)
        {
            panelHover.Location = btnBanHang.Location;
            HienThiForm(frmBanHang.CreateInstance());
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            panelHover.Location = btnSanPham.Location;
            HienThiForm(frmSanPham.CreateInstance());
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            panelHover.Location = btnHoaDon.Location;
            HienThiForm(frmDonHang.CreateInstance());
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            panelHover.Location = btnKhachHang.Location;
            HienThiForm(frmKhachHang.CreateInstance());
        }

        private void btnHangTV_Click(object sender, EventArgs e)
        {
            panelHover.Location = btnHangTV.Location;
            HienThiForm(frmHangThanhVien.CreateInstance());
        }

        private void btnKiemDuyet_Click(object sender, EventArgs e)
        {
            panelHover.Location = btnKiemDuyet.Location;
            HienThiForm(FormKiemDuyetLenHang.CreateInstance());
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            panelHover.Location = btnNhanVien.Location;
            HienThiForm(frmNhanVien.CreateInstance());
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát?","Thông báo",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
            
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            LoadDataUser();
            HienThiForm(frmBanHang.CreateInstance());
        }

        private void LoadDataUser()
        {
            ClassNhanVien user = ClassQuanLyNhanVien.Intance.LoadUserById(Properties.Settings.Default.LoginUser);
            labelUsername.Text = user.TenNhanVien;
            if (user.HinhAnh != null)
            {
                byte[] bytes = user.HinhAnh;
                MemoryStream ms = new MemoryStream(bytes);
                ptbAvatar.Image = Image.FromStream(ms);


            }

        }
    }
}
