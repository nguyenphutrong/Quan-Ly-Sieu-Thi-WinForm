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
        private string sStatus = "";
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
                DongTextBox();
                sStatus = "";
            }
            
        }
        #endregion

        private void frmHangThanhVien_FormClosed(object sender, FormClosedEventArgs e)
        {
            _singleton = null;
        }
        private void ClearText()
        {
            txtMaHang.Text = "";
            txtTenHang.Text = "";
            txtDKLH.Text = "";
            txtQL.Text = "";
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            ClearText();
            sStatus = "Add";
            MoTextBox();
            txtMaHang.Focus();
        }
        private void MoTextBox()
        {
            txtTenHang.Enabled = true;
            txtDKLH.Enabled = true;
            txtQL.Enabled = true;

            if (sStatus == "Add")
            {
                txtMaHang.Enabled = true;
            }
        }
        private void DongTextBox()
        {
            txtMaHang.Enabled = false;
            txtTenHang.Enabled = false;
            txtDKLH.Enabled = false;
            txtQL.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ClassHangThanhVien htv = new ClassHangThanhVien(txtMaHang.Text, txtTenHang.Text, txtDKLH.Text, txtQL.Text);
            if ((htv.MaHang == "") || (htv.TenHang == "") || (htv.Dklenhang == "") || (htv.Quyenloi == ""))
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin!", "Thông báo");
            }
            else
            {
                if (sStatus == "Add")
                {
                    if (ClassDSHangThanhVien.Intance.ThemHangThanhVien(htv))
                    {
                        MessageBox.Show("Thêm thành công", "Thông báo");
                        LoadDataHangTV();
                        DongTextBox();
                    }
                    else
                    {
                        MessageBox.Show("Lỗi. Không thể thêm.", "Thông báo");
                    }
                }
                else if (sStatus == "Update")
                {
                    if (ClassDSHangThanhVien.Intance.SuaHangThanhVien(htv))
                    {
                        MessageBox.Show("Sửa thành công", "Thông báo");
                        LoadDataHangTV();
                        DongTextBox();
                    }
                    else
                    {
                        MessageBox.Show("Lỗi. Không thể sửa.", "Thông báo");
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Vì khi xóa hạng kèm theo đó là sẽ xóa luôn các hạng của các khách hàng, cần cập nhật khách hàng lại. Vì vậy theo tui nghĩ nên chỉ cho chỉnh sửa hạng và thêm hạng thôi. xóa thì phải làm thêm.

            if (sStatus != "" || txtMaHang.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn hạng muốn xóa!", "Thông báo");
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa!", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (dataGridViewHTV.SelectedRows == null)
                {
                    MessageBox.Show("Bạn chưa chọn hạng cần xóa", "Thông báo");
                }
                else
                {
                    if (ClassDSHangThanhVien.Intance.XoaHangThanhVien(txtMaHang.Text))
                    {
                        MessageBox.Show("Đã xóa", "Thông báo");
                        LoadDataHangTV();
                    }
                    else
                    {
                        MessageBox.Show("Lỗi. Không thể xóa.", "Thông báo");
                    }

                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridViewHTV.SelectedRows == null || txtMaHang.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn hạng cần sửa", "Thông báo");
            }
            else
            {
                MoTextBox();
                txtMaHang.Enabled = false;


                sStatus = "Update";
                txtTenHang.Focus();
            }
        }
    }
}
