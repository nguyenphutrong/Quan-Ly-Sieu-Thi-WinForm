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
    public partial class frmHangThanhVien : Form
    {
        public frmHangThanhVien()
        {
            InitializeComponent();
            LoadDataHangTV();
        }
        private static frmHangThanhVien _singleton;

        public static frmHangThanhVien CreateInstance()
        {
            if (_singleton == null)
            {
                _singleton = new frmHangThanhVien();
            }
            return _singleton;
        }

        #region Method

        private void LoadDataHangTV()
        {

            List<ClassHangThanhVien> list = ClassDSHangThanhVien.Intance.LoadDanhSachHangTV(); 

            dataGridViewHTV.DataSource = list;

            dataGridViewHTV.Columns[0].HeaderText = "Mã Hạng";
            dataGridViewHTV.Columns[1].HeaderText = "Tên Hạng";
            dataGridViewHTV.Columns[2].HeaderText = "Điều Kiện";
            dataGridViewHTV.Columns[3].HeaderText = "Quyền Lợi";
            foreach (DataGridViewColumn col in dataGridViewHTV.Columns)
            {
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            dataGridViewHTV.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        #endregion

        #region Events
        private void dataGridViewHTV_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewHTV.CurrentRow != null)
            {
                DataGridViewRow row = dataGridViewHTV.CurrentRow;
                int i = 0;
                txtMaHang.Text = row.Cells[i++].Value.ToString();
                txtTenHang.Text = row.Cells[i++].Value.ToString();
                txtDKLH.Text = row.Cells[i++].Value.ToString();
                txtQL.Text = row.Cells[i++].Value.ToString();
            }
        }
        #endregion
    }
}
