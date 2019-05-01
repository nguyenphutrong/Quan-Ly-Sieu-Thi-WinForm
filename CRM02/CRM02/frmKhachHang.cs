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
    public partial class frmKhachHang : Form
    {
        private string sStatus = "";
        public frmKhachHang()
        {
            InitializeComponent();
            LoadDataKhachHang();
            FillCombobox();          
        }

        private static frmKhachHang _singleton;

        public static frmKhachHang CreateInstance()
        {
            if (_singleton == null)
            {
                _singleton = new frmKhachHang();
            }
            return _singleton;
        }

        private void LoadDataKhachHang()
        {
            List<ClassKhachHang> list = ClassQuanLyKhachHang.Intance.LoadDanhSachKhachHang();

            dataGridView1.DataSource = list;

            dataGridView1.Columns[0].HeaderText = "Mã Khách Hàng";
            dataGridView1.Columns[1].HeaderText = "Họ tên";
            dataGridView1.Columns[2].HeaderText = "Ngày sinh";
            dataGridView1.Columns[3].HeaderText = "Địa chỉ";
            dataGridView1.Columns[4].HeaderText = "Điện thoại";
            dataGridView1.Columns[5].HeaderText = "Điểm thưởng";
            dataGridView1.Columns[6].HeaderText = "Hạng thành viên";
            dataGridView1.Columns[7].HeaderText = "Ngày đăng ký";
            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            dataGridView1.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                item.Cells[6].Value = ClassDSHangThanhVien.Intance.getDataById(item.Cells[6].Value.ToString()).TenHang;
            }
        }

        private void ClearText()
        {
            txtMaKH.Text = "";
            txtTenKH.Text = "";
            cboDay.SelectedIndex = -1;
            cboMonth.SelectedIndex = -1;
            cboYear.SelectedIndex = -1;
            txtDiaChi.Text = "";
            txtDienThoai.Text = "";
            txtDiemThuong.Text = "";
            cboHangTV.SelectedIndex = -1;
            txtNgayDK.Text = "";
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                DataGridViewRow row = dataGridView1.CurrentRow;
                int i = 0;
                txtMaKH.Text = row.Cells[i++].Value.ToString();
                txtTenKH.Text = row.Cells[i++].Value.ToString();
                string ngaySinh = row.Cells[i++].Value.ToString();
                string[] Words = ngaySinh.Split(new char[] { '/' });
                int count = 0;
                foreach (string Word in Words)
                {
                    count += 1;
                    if (count == 1) { cboDay.SelectedIndex = int.Parse(Word) - 1; }
                    if (count == 2) { cboMonth.SelectedIndex = int.Parse(Word) -1; }
                    if (count == 3) { cboYear.SelectedIndex = DateTime.Now.Year -  int.Parse(Word); }
                }

                txtDiaChi.Text = row.Cells[i++].Value.ToString();
                txtDienThoai.Text = row.Cells[i++].Value.ToString();
                txtDiemThuong.Text = row.Cells[i++].Value.ToString();
                cboHangTV.Text = row.Cells[i++].Value.ToString();
                txtNgayDK.Text = row.Cells[i++].Value.ToString();
                DongTextBox();
                sStatus = "";
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ClearText();
            sStatus = "Add";
            MoTextBox();
            txtDiemThuong.Text = "0";
            txtNgayDK.Text = DateTime.Now.ToShortDateString();
            cboHangTV.SelectedValue = "si";
            txtMaKH.Focus();
        }

        private void MoTextBox()
        {
            
            txtTenKH.Enabled = true;
            cboDay.Enabled = true;
            cboMonth.Enabled = true;
            cboYear.Enabled = true;
            txtDiaChi.Enabled = true;
            txtDienThoai.Enabled = true;

            if (sStatus == "Add")
            {
                txtMaKH.Enabled = true;        
            }
        }
        private void DongTextBox()
        {
            txtTenKH.Enabled = false;
            cboDay.Enabled = false;
            cboMonth.Enabled = false;
            cboYear.Enabled = false;
            txtDiaChi.Enabled = false;
            txtDienThoai.Enabled = false;

            txtMaKH.Enabled = false;
            txtDiemThuong.Enabled = false;
            cboHangTV.Enabled = false;
            txtNgayDK.Enabled = false;
        }

        private void FillCombobox()
        {
            for (int i = 0; i < 31; i++)
            {
                cboDay.Items.Add(i+1);
            }
            for (int i = 0; i < 12; i++)
            {
                cboMonth.Items.Add(i+1);
            }
            for (int i = DateTime.Now.Year; i > 1900  ; i--)
            {
                cboYear.Items.Add(i);
            }

            List<ClassHangThanhVien> list = ClassDSHangThanhVien.Intance.LoadDanhSachHangTV();
            cboHangTV.DataSource = list;
            cboHangTV.DisplayMember = "TenHang";
            cboHangTV.ValueMember = "MaHang";

            cboDay.SelectedIndex = -1;
            cboMonth.SelectedIndex =  - 1;
            cboYear.SelectedIndex = -1;
            cboHangTV.SelectedIndex = -1;
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (sStatus != "" || txtMaKH.Text=="")
            {
                MessageBox.Show("Bạn chưa chọn khách hàng muốn xóa!", "Thông báo");
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa!","Thông báo",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (dataGridView1.SelectedRows == null)
                {
                    MessageBox.Show("Bạn chưa chọn khách hàng cần xóa","Thông báo");
                }
                else
                {
                    if (ClassQuanLyKhachHang.Intance.XoaKhachHang(txtMaKH.Text))
                    {
                        MessageBox.Show("Đã xóa", "Thông báo");
                        LoadDataKhachHang();
                    }
                    else
                    {
                        MessageBox.Show("Lỗi. Không thể xóa.", "Thông báo");
                    }

                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows == null || txtMaKH.Text =="")
            {
                MessageBox.Show("Bạn chưa chọn khách hàng cần sửa", "Thông báo");
            }
            else
            {
                MoTextBox();
                txtMaKH.Enabled = false;


                sStatus = "Update";
                txtTenKH.Focus();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sNgaySinh = cboMonth.Text + "/" + cboDay.Text + "/" + cboYear.Text;
            //string sNgaySinh = cboDay.Text + "/" + cboMonth.Text + "/" + cboYear.Text;
            ClassKhachHang kh = new ClassKhachHang(txtMaKH.Text, txtTenKH.Text, sNgaySinh, txtDiaChi.Text, txtDienThoai.Text, int.Parse(txtDiemThuong.Text), cboHangTV.SelectedValue.ToString(), txtNgayDK.Text);
            if ((kh.MaKH == "") || (kh.HoTen == "") || (kh.NgaySinh == "") || (kh.DiaChi == "") || (kh.DienThoai == "") || (kh.HangThanhVien == ""))
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin!", "Thông báo");
            }
            else
            {
                if (sStatus == "Add")
                {
                    if (ClassQuanLyKhachHang.Intance.ThemKhachHang(kh))
                    {
                        MessageBox.Show("Thêm thành công", "Thông báo");
                        LoadDataKhachHang();
                        DongTextBox();
                    }
                    else
                    {
                        MessageBox.Show("Lỗi. Không thể thêm.", "Thông báo");
                    }
                }
                else if (sStatus == "Update")
                {
                    if (ClassQuanLyKhachHang.Intance.SuaKhachHang(kh))
                    {
                        MessageBox.Show("Sửa thành công", "Thông báo");
                        LoadDataKhachHang();
                        DongTextBox();
                    }
                    else
                    {
                        MessageBox.Show("Lỗi. Không thể sửa.", "Thông báo");
                    }
                }                
            }
        }

        private void frmKhachHang_FormClosed(object sender, FormClosedEventArgs e)
        {
            _singleton = null;
        }
    }
}
