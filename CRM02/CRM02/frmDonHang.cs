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
    public partial class frmDonHang : Form
    {
        public frmDonHang()
        {
            InitializeComponent();
            LoadDataDonHang();
        }
        private static frmDonHang _singleton;

        public static frmDonHang CreateInstance()
        {
            if (_singleton == null)
            {
                _singleton = new frmDonHang();
            }
            return _singleton;
        }
        #region Method

        private void LoadDataDonHang()
        {


            List<ClassDonHang> list = ClassQuanLyDonHang.Intance.LoadDanhSachDonHang();

            dataGridView1.DataSource = list;

            dataGridView1.Columns[0].HeaderText = "Mã đơn Hàng";
            dataGridView1.Columns[1].HeaderText = "Mã Khách Hàng";
            dataGridView1.Columns[2].HeaderText = "Thành tiền";
            dataGridView1.Columns[3].HeaderText = "Người Tạo";
            dataGridView1.Columns[4].HeaderText = "Ngày tạo";
            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        #endregion

        #region Events
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                DataGridViewRow row = dataGridView1.CurrentRow;
                int i = 0;
                txtMaDH.Text = row.Cells[i++].Value.ToString();
                txtMaKH.Text = row.Cells[i++].Value.ToString();
                txtThanhTien.Text = row.Cells[i++].Value.ToString();
                txtNgayTao.Text = row.Cells[i++].Value.ToString();
                txtNuoiTao.Text = row.Cells[i++].Value.ToString();
            }
        }
        #endregion

        private void frmDonHang_FormClosed(object sender, FormClosedEventArgs e)
        {
            _singleton = null;
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Index >= 0)
            {
                frmChiTietDH frm = new frmChiTietDH();
                frm.MaDH = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                frm.Text = "Chi tiết đơn hàng: " + dataGridView1.CurrentRow.Cells[0].Value.ToString();
                frm.ShowDialog();
            }
        }
    }
}
