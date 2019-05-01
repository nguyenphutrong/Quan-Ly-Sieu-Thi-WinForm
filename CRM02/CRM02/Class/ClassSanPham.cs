using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM02
{
    public class ClassSanPham
    {

        private static ClassSanPham instance;

        private string maSanPham;
        private string tenSanPham;
        private int donGia;

        public ClassSanPham(string maSanPham, string tenSanPham, int donGia)
        {
            this.maSanPham = maSanPham;
            this.tenSanPham = tenSanPham;
            this.donGia = donGia;
        }

        public ClassSanPham() { }
      
        public static ClassSanPham Instance { get { if (instance == null) { instance = new ClassSanPham(); } return instance; } private set => instance = value; }
        public string MaSanPham { get => maSanPham; set => maSanPham = value; }
        public string TenSanPham { get => tenSanPham; set => tenSanPham = value; }
        public int DonGia { get => donGia; set => donGia = value; }

        public ClassSanPham(DataRow row)
        {
            this.MaSanPham = row["masanpham"].ToString();
            this.TenSanPham = row["tensanpham"].ToString();
            this.DonGia = int.Parse(row["dongia"].ToString());

        }

    }
}
