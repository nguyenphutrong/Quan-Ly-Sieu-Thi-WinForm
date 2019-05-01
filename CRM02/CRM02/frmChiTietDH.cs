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
    public partial class frmChiTietDH : Form
    {
        private string maDH = "";
        public string MaDH { get => maDH; set => maDH = value; }

        public frmChiTietDH()
        {
            InitializeComponent();
        }

        

        private void frmChiTietDH_Load(object sender, EventArgs e)
        {
            if (maDH != "")
            {
                List<ClassChiTietDH> list = ClassQuanLyChiTietDonHang.Intance.LoadData(maDH);
                dataGridView1.DataSource = list;
                dataGridView1.Columns[0].HeaderText = "Mã sản phẩm";
                dataGridView1.Columns[1].HeaderText = "Tên sản phẩm";
                dataGridView1.Columns[2].HeaderText = "Đơn giá";
                dataGridView1.Columns[3].HeaderText = "Số lượng";
                dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.DataSource = list;
            }
            

        }
    }
}
