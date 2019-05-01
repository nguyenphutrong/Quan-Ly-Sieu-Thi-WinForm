using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM02
{
    class ClassChiTietDH
    {
        private static ClassChiTietDH instance;

        private string maSanPham;
        private string tenSanPham;
        private int soLuong;
        private int donGia;
        


        public ClassChiTietDH() { }

        public ClassChiTietDH(string maSanPham, string tenSanPham, int donGia, int soLuong)
        {
            this.maSanPham = maSanPham;
            this.tenSanPham = tenSanPham;
            this.donGia = donGia;
            this.soLuong = soLuong;
        }

        public static ClassChiTietDH Instance { get { if (instance == null) { instance = new ClassChiTietDH(); } return instance; } private set => instance = value; }
        public string MaSanPham { get => maSanPham; set => maSanPham = value; }
        public string TenSanPham { get => tenSanPham; set => tenSanPham = value; }
        public int DonGia { get => donGia; set => donGia = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }


        public ClassChiTietDH(DataRow row)
        {
            this.maSanPham = row["masanpham"].ToString();
            this.tenSanPham = ClassQuanLySanPham.Intance.GetDataById(row["masanpham"].ToString()).TenSanPham ;
            this.donGia = int.Parse(row["giaban"].ToString());
            this.soLuong = int.Parse(row["soluong"].ToString());
        }


    }
}
