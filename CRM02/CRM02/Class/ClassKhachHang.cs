using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM02
{
    public class ClassKhachHang
    {

        private static ClassKhachHang instance;

        private string maKH;
        private string hoTen;
        private string ngaySinh;
        private string diaChi;
        private string dienThoai;
        private int diemThuong;
        private string hangThanhVien;
        private string ngayDK;

        public ClassKhachHang(string maKH, string hoTen, string ngaySinh, string diaChi, string dienThoai, int diemThuong, string hangThanhVien, string ngayDK)
        {
            this.maKH = maKH;
            this.hoTen = hoTen;
            this.ngaySinh = ngaySinh;
            this.diaChi = diaChi;
            this.dienThoai = dienThoai;
            this.diemThuong = diemThuong;
            this.hangThanhVien = hangThanhVien;
            this.ngayDK = ngayDK;
        }

        public ClassKhachHang() { }
      
        public static ClassKhachHang Instance { get { if (instance == null) { instance = new ClassKhachHang(); } return instance; } private set => instance = value; }
        public string MaKH { get => maKH; set => maKH = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string DienThoai { get => dienThoai; set => dienThoai = value; }
        public int DiemThuong { get => diemThuong; set => diemThuong = value; }
        public string HangThanhVien { get => hangThanhVien; set => hangThanhVien = value; }
        public string NgayDK { get => ngayDK; set => ngayDK = value; }

        public ClassKhachHang(DataRow row)
        {
            this.MaKH = row["makhachhang"].ToString();
            this.HoTen = row["hoten"].ToString();
            this.NgaySinh = String.Format("{0:dd/MM/yyyy}", row["ngaysinh"]);
            this.DiaChi = row["diachi"].ToString();
            this.DienThoai = row["dienthoai"].ToString();
            this.DiemThuong = (int)row["diemthuong"];
            this.HangThanhVien = row["mahang"].ToString();
            this.NgayDK = String.Format("{0:dd/MM/yyyy}", row["ngaydangki"]);
        }

    }
}
