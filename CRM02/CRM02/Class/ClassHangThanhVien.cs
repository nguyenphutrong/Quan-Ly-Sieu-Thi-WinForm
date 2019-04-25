using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM02
{
    public class ClassHangThanhVien
    {
        //TODO:hangthanhvien(mahang, tenhang, dieukienlenhang, quyenloi)
        private static ClassHangThanhVien instance;

        private string maHang;
        private string tenHang;
        private string dklenhang;
        private string quyenloi;

        public ClassHangThanhVien(string mahang, string tenhang, string dieukienlenhang, string quyenloi)
        {
            this.maHang = mahang;
            this.tenHang = tenhang;
            this.dklenhang = dieukienlenhang;
            this.quyenloi = quyenloi;
        }

        public ClassHangThanhVien() { }

        public static ClassHangThanhVien Instace { get { if (instance == null) { instance = new ClassHangThanhVien(); } return instance; } private set => instance = value; }

        public string MaHang { get => maHang; set => maHang = value; }
        public string TenHang { get => tenHang; set => tenHang = value; }
        public string Dklenhang { get => dklenhang; set => dklenhang = value; }
        public string Quyenloi { get => quyenloi; set => quyenloi = value; }

        public ClassHangThanhVien(DataRow row)
        {
            this.MaHang = row["mahang"].ToString();
            this.TenHang = row["tenhang"].ToString();
            this.Dklenhang = row["dieukienlenhang"].ToString();
            this.Quyenloi = row["quyenloi"].ToString();
        }
    }
}
