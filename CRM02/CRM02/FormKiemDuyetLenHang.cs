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
    public partial class FormKiemDuyetLenHang : Form
    {
        public FormKiemDuyetLenHang()
        {
            InitializeComponent();
            LoadCB();
            LoadDataKhachHangSua();
        }

        private static FormKiemDuyetLenHang _singleton;

        public static FormKiemDuyetLenHang CreateInstance()
        {
            if (_singleton == null)
            {
                _singleton = new FormKiemDuyetLenHang();
            }
            return _singleton;
        }

        private void LoadCB()
        {
            List<ClassHangThanhVien> list = ClassDSHangThanhVien.Intance.LoadDanhSachHangTV();
            comboBox1.DataSource = list;
            comboBox1.DisplayMember = "TenHang";
            comboBox1.ValueMember = "MaHang";
            comboBox1.SelectedIndex = -1;
        }

        private void LoadDataKhachHangSua()
        {
            List<ClassKhachHang> list = ClassQuanLyKhachHang.Intance.LoadDanhSachKhachHang();

            List<ClassKhachHang> listkhdoihang = new List<ClassKhachHang>();
            foreach (ClassKhachHang item in list)
            {
                if(item.DiemThuong > 15000 && item.HangThanhVien != "ma")
                {
                    listkhdoihang.Add(item);
                }
                else if (item.DiemThuong >= 5000 && item.DiemThuong < 15000 && item.HangThanhVien != "di")
                {
                    listkhdoihang.Add(item);
                }
                else if (item.DiemThuong >= 2000 && item.DiemThuong < 5000 && item.HangThanhVien != "go")
                {
                    listkhdoihang.Add(item);
                }
                else if (item.DiemThuong < 2000 && item.HangThanhVien != "si")
                {
                    listkhdoihang.Add(item);
                }
            }

            dataGridView1.DataSource = listkhdoihang;

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
                //DateTime ngay = Convert.ToDateTime(item.Cells[2].Value.ToString());
                //item.Cells[2].Value = ngay.ToString("dd/MM/yyyy");
            }
        }

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                comboBox1.Enabled = true;
                DataGridViewRow row = dataGridView1.CurrentRow;
                comboBox1.Text = row.Cells[6].Value.ToString();
            }
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public bool suahang(string makhsua, string hangsua)
        {
            if (ClassQuanLyKhachHang.Intance.SuaHangKhachHang(makhsua, hangsua))
            {
                return true;
            }
            return false;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;
            if (suahang(row.Cells[0].Value.ToString(), comboBox1.SelectedValue.ToString()))
            {
                MessageBox.Show("Sửa thành công", "Thông báo");
                LoadDataKhachHangSua();
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                if(int.Parse(item.Cells[5].Value.ToString()) > 15000)
                {
                    suahang(item.Cells[0].Value.ToString(), "ma");
                }
                else if (int.Parse(item.Cells[5].Value.ToString()) > 5000)
                {
                    suahang(item.Cells[0].Value.ToString(), "di");
                }
                else if (int.Parse(item.Cells[5].Value.ToString()) > 2000)
                {
                    suahang(item.Cells[0].Value.ToString(), "go");
                }
                else 
                {
                    suahang(item.Cells[0].Value.ToString(), "si");
                }
            }
            MessageBox.Show("Sửa thành công", "Thông báo");
            LoadDataKhachHangSua();
        }
    }
}
