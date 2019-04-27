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
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
            LoadDataNhanVien();
        }
        private static frmNhanVien _singleton;

        public static frmNhanVien CreateInstance()
        {
            if (_singleton == null)
            {
                _singleton = new frmNhanVien();
            }
            return _singleton;
        }

        #region Method

        private void LoadDataNhanVien()
        {
            List<ClassNhanVien> list = ClassQuanLyNhanVien.Intance.LoadDanhSachNhanVien();

            dataGridView1.DataSource = list;

            dataGridView1.Columns[0].HeaderText = "Tên Đăng Nhập";
            dataGridView1.Columns[1].HeaderText = "Họ Tên";

            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        #endregion

        #region Events
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                DataGridViewRow row = dataGridView1.CurrentRow;
                int i = 0;
                txtTenDN.Text = row.Cells[i++].Value.ToString();
                txtHoTen.Text = row.Cells[i++].Value.ToString();
            }
        }
        #endregion

        private void frmNhanVien_FormClosed(object sender, FormClosedEventArgs e)
        {
            _singleton = null;
        }
    }
}
