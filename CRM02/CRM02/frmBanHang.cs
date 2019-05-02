using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM02
{
    public partial class frmBanHang : Form
    {
        private List<ClassChiTietDH> list = new List<ClassChiTietDH>();
        private string makh = "";
        private int diemthuong;
        public frmBanHang()
        {
            InitializeComponent();
        }
        private static frmBanHang _singleton;
        public static frmBanHang CreateInstance()
        {
            if (_singleton == null)
            {
                _singleton = new frmBanHang();
            }
            return _singleton;
        }

        private void frmBanHang_Load(object sender, EventArgs e)
        {

            List<ClassSanPham> list = ClassQuanLySanPham.Intance.LoadDanhSachSanPham();
            AutoCompleteStringCollection arrName = new AutoCompleteStringCollection();
            foreach (ClassSanPham item in list)
            {
                arrName.Add(item.TenSanPham);
            }
            cboSP.AutoCompleteCustomSource = arrName;
            cboSP.DataSource = list;
            cboSP.DisplayMember = "TenSanPham";
            cboSP.ValueMember = "MaSanPham";
            KhoiTaoDHMoi();
        }

        private void KhoiTaoDHMoi()
        {
            txtMaHD.Text = ClassQuanLyDonHang.Intance.LoadMaDH();
            txtNVBH.Text = ClassQuanLyNhanVien.Intance.LoadUserById(Properties.Settings.Default.LoginUser).TenNhanVien;
            txtNgayDH.Text = DateTime.Now.ToShortDateString();
            cboSP.SelectedIndex = -1;
            numSL.Value = 0;
            txtTongTien.Text = string.Format(("{0:C}"), 0);
            txtThanhTien.Text = string.Format(("{0:C}"), 0);
            dataGridView1.DataSource = null;
        }

        private void btnCheckKH_Click(object sender, EventArgs e)
        {
            bool b = CheckKH();            
        }

        private bool CheckKH()
        {
            bool b = false;
            if (txtSoDT.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập số điện thoại!", "Thông báo");
            }
            else
            {
                ClassKhachHang khachhang = ClassQuanLyKhachHang.Intance.TraCuuKhachHang(txtSoDT.Text);
                if (khachhang == null)
                {
                    MessageBox.Show("Không tìm thấy!", "Thông báo");
                }
                else
                {
                    lbTenKH.Text = khachhang.HoTen.ToUpper();
                    makh = khachhang.MaKH;
                    diemthuong = khachhang.DiemThuong;
                    ClassHangThanhVien hang = ClassDSHangThanhVien.Intance.getDataById(khachhang.HangThanhVien);
                    txtGiamGia.Text = hang.Quyenloi;
                    tinhThanhTien();
                    b = true;
                }
            }
            return b;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (cboSP.SelectedIndex >= 0 && numSL.Value > 0)
            {
                ClassSanPham sp = ClassQuanLySanPham.Intance.GetDataById(cboSP.SelectedValue.ToString());
                ClassChiTietDH item = new ClassChiTietDH(sp.MaSanPham,sp.TenSanPham, sp.DonGia, Decimal.ToInt32(numSL.Value));
                list.Add(item);
                resetDGV();
                

                cboSP.SelectedIndex = -1;
                numSL.Value = 0;

                int tongtien = 0;
                
                foreach (ClassChiTietDH p in list)
                {
                    tongtien += p.DonGia * p.SoLuong;
                }
                txtTongTien.Text = string.Format(("{0:C}"), tongtien);
                tinhThanhTien();
            }
        }

        private void resetDGV()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = list;
            dataGridView1.Columns[0].HeaderText = "Mã sản phẩm";
            dataGridView1.Columns[1].HeaderText = "Tên sản phẩm";
            dataGridView1.Columns[2].HeaderText = "Đơn giá";
            dataGridView1.Columns[3].HeaderText = "Số lượng";
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void tinhThanhTien()
        {
            int tongtien = int.Parse(txtTongTien.Text, NumberStyles.Currency);
            string value = txtGiamGia.Text;
            value = value.Replace(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.PercentSymbol, "");
            float giamgia = float.Parse(value) / 100;
            txtThanhTien.Text = string.Format(("{0:C}"), tongtien - tongtien * giamgia);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {            
            if (dataGridView1.CurrentRow.Index >= 0)
            {
                list.RemoveAt(dataGridView1.CurrentRow.Index);
                resetDGV();
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count < 1)
            {
                MessageBox.Show("Bạn chưa chọn sản phẩm", "Thông báo!");                
            }
            else if (CheckKH())
            {
                ClassDonHang dh = new ClassDonHang(txtMaHD.Text, makh, int.Parse(txtThanhTien.Text, NumberStyles.Currency), Properties.Settings.Default.LoginUser, txtNgayDH.Text);
                if (ClassQuanLyDonHang.Intance.LuuDonHang(dh))
                {
                    foreach (ClassChiTietDH item in list)
                    {
                        bool b = ClassQuanLyChiTietDonHang.Intance.LuuDonHang(dh.MaDH, item.MaSanPham, item.SoLuong, item.DonGia);
                    }
                    
                    bool b1 = ClassQuanLyKhachHang.Intance.TichDiem(makh,diemthuong + int.Parse(txtThanhTien.Text, NumberStyles.Currency) / 1000);
                    MessageBox.Show("Lưu thành công", "Thông báo");
                    KhoiTaoDHMoi();
                }
                else
                {
                    MessageBox.Show("Lỗi. Không thể lưu.", "Thông báo");
                }
            }

        }

        private void frmBanHang_FormClosed(object sender, FormClosedEventArgs e)
        {
            _singleton = null;
        }
    }
}