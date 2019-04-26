using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            panelHover.Location = btnNhanVien.Location;
            HienThiForm(frmNhanVien.CreateInstance());
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            LoadDataUser();
        }

        private void LoadDataUser()
        {
            ClassNhanVien user = ClassQuanLyNhanVien.Intance.LoadUserById(Properties.Settings.Default.LoginUser);
            labelUsername.Text = user.TenNhanVien;
            if (user.HinhAnh != null)
            {
                //byte[] bytes = Encoding.ASCII.GetBytes(user.HinhAnh);
                //MemoryStream ms = new MemoryStream(user.HinhAnh);
                //ptbAvatar.Image = Image.FromStream(ms);
                //ptbAvatar.Image = (Image)converter.ConvertFrom(user.HinhAnh);
                byte[] bytes = user.HinhAnh;
                //mStream.Write(bytes, 0, Convert.ToInt32(bytes.Length));
                MemoryStream ms = new MemoryStream(bytes);
                ptbAvatar.Image = Image.FromStream(ms);


            }

        }
    }
}
