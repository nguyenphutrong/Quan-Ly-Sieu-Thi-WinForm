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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string tendangnhap = textBoxTenDanhNhap.Text;
            string matkhau = textBoxMatKhau.Text;

            if (tendangnhap == "" || matkhau == "")
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin","Thông báo");
        
            }
            else if (Login(tendangnhap, matkhau))
            {
                frmMain frm = new frmMain();
                clearTextBox();
                this.Hide();
                frm.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu", "Thông báo");
                textBoxTenDanhNhap.Focus();
            }

        }

        private bool Login(string tendangnhap, string matkhau)
        {
            return ClassQuanLyNhanVien.Intance.DangNhap(tendangnhap,matkhau);
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tính năng sắp có!", "Thông báo");
        }

        private void buttonTraCuuTT_Click(object sender, EventArgs e)
        {
            frmTraCuuThongTin frm = new frmTraCuuThongTin();
            clearTextBox();            
            clearTextBox();
            frm.ShowDialog();
            this.Show();
        }

        private void clearTextBox()
        {
            textBoxTenDanhNhap.Text = "";
            textBoxMatKhau.Text = "";
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            
        }
    }
}
