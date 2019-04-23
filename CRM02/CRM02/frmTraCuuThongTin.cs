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
    public partial class frmTraCuuThongTin : Form
    {
        public frmTraCuuThongTin()
        {
            InitializeComponent();
        }

        private void buttonTraCuu_Click(object sender, EventArgs e)
        {
            if (textBoxSDT.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập số điện thoại!","Thông báo");
            }
            else
            {
                ClassKhachHang khachhang = ClassQuanLyKhachHang.Intance.TraCuuKhachHang(textBoxSDT.Text);
                if(khachhang == null)
                {
                    MessageBox.Show("Không tìm thấy!", "Thông báo");
                    tabControlMain.Visible = false;
                }
                else
                {
                    tabControlMain.Visible = true;
                    labelHoTen.Text = khachhang.HoTen.ToUpper();
                    labelHang.Text = "Hạng thành viên: "+ khachhang.HangThanhVien;
                    labelDiemThuong.Text = "Điểm thưởng: " + khachhang.DiemThuong.ToString();
                }

            }
        }
    }
}
