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
        public frmKhachHang()
        {
            InitializeComponent();
            LoadDataKhachHang();
        }

        #region Method

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
        }

        #endregion

        #region Events
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                DataGridViewRow row = dataGridView1.CurrentRow;
                int i = 0;
                txtMaKH.Text = row.Cells[i++].Value.ToString();
                txtTenKH.Text = row.Cells[i++].Value.ToString();
                txtNgaySinh.Text = row.Cells[i++].Value.ToString();
                txtDiaChi.Text = row.Cells[i++].Value.ToString();
                txtDienThoai.Text = row.Cells[i++].Value.ToString();
                txtDiemThuong.Text = row.Cells[i++].Value.ToString();
                txtHangTV.Text = row.Cells[i++].Value.ToString();
                txtNgayDK.Text = row.Cells[i++].Value.ToString();
            }
        }
        #endregion
    }
}
