using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM02
{
    public class ClassNhanVien
    {

        private static ClassNhanVien instance;

        private string tenDangNhap;
        private string tenNhanVien;

        public ClassNhanVien(string tenDangNhap, string tenNhanVien)
        {
            this.tenDangNhap = tenDangNhap;
            this.tenNhanVien = tenNhanVien;
        }

        public ClassNhanVien() { }
      
        public static ClassNhanVien Instance { get { if (instance == null) { instance = new ClassNhanVien(); } return instance; } private set => instance = value; }
        public string TenDangNhap { get => tenDangNhap; set => tenDangNhap = value; }
        public string TenNhanVien { get => tenNhanVien; set => tenNhanVien = value; }
        

        public ClassNhanVien(DataRow row)
        {
            this.TenDangNhap = row["tendangnhap"].ToString();
            this.TenNhanVien = row["tennguoidung"].ToString();
        }




    }
}
