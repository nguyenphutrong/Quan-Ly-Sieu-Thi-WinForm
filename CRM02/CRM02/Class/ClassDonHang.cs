using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM02
{
    public class ClassDonHang
    {
        private static ClassDonHang instance;
        private string maDH;
        private string maKH;
        private int thanhTien;
        private string nguoiTao;
        private string ngayTao;

        public ClassDonHang(string madonhang, string makhachhang, int thanhtien, string nguoitao, string ngaytao)
        {
            MaDH = madonhang;
            MaKH = makhachhang;
            ThanhTien = thanhtien;
            NguoiTao = nguoitao;
            NgayTao = ngaytao;
        }

        public static ClassDonHang Instance { get { if (instance == null) { instance = new ClassDonHang(); } return instance; } private set => instance = value; }

        public string MaDH { get => maDH; set => maDH = value; }
        public string MaKH { get => maKH; set => maKH = value; }
        public int ThanhTien { get => thanhTien; set => thanhTien = value; }
        public string NguoiTao { get => nguoiTao; set => nguoiTao = value; }
        public string NgayTao { get => ngayTao; set => ngayTao = value; }

        public ClassDonHang(DataRow row)
        {
            this.MaDH = row["madonhang"].ToString();
            this.MaKH = row["makhachhang"].ToString();
            this.ThanhTien = int.Parse(row["thanhtien"].ToString());
            this.NguoiTao = row["nguoitao"].ToString();
            this.NgayTao = row["ngaytao"].ToString();
        }

        public ClassDonHang()
        {
        }
    }
}
