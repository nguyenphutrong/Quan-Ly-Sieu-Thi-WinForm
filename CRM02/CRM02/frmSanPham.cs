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
    public partial class frmSanPham : Form
    {
        public frmSanPham()
        {
            InitializeComponent();
            LoadDataSanPham();
        }
        private static frmSanPham _singleton;

        public static frmSanPham CreateInstance()
        {
            if (_singleton == null)
            {
                _singleton = new frmSanPham();
            }
            return _singleton;
        }

        #region Method

        private void LoadDataSanPham()
        {
            List<ClassSanPham> list = ClassQuanLySanPham.Intance.LoadDanhSachSanPham();

            dataGridView1.DataSource = list;

            dataGridView1.Columns[0].HeaderText = "Mã Sản Phẩm";
            dataGridView1.Columns[1].HeaderText = "Tên Sản Phẩm";
            dataGridView1.Columns[2].HeaderText = "Đơn Giá";

            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        #endregion

        #region Events
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                DataGridViewRow row = dataGridView1.CurrentRow;
                int i = 0;
                txtMaSanPham.Text = row.Cells[i++].Value.ToString();
                txtTenSanPham.Text = row.Cells[i++].Value.ToString();
                txtDonGia.Text = row.Cells[i++].Value.ToString();
            }
        }
        #endregion

        private void frmSanPham_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void frmSanPham_FormClosed(object sender, FormClosedEventArgs e)
        {
            _singleton = null;

        }
    }
}
