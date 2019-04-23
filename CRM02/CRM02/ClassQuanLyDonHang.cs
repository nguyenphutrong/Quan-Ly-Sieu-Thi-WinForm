using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM02
{
    class ClassQuanLyDonHang
    {
        private static ClassQuanLyDonHang instance;

        public ClassQuanLyDonHang()
        {
        }

        public static ClassQuanLyDonHang Intance
        {
            get { if (instance == null) instance = new ClassQuanLyDonHang(); return instance; }
            set => instance = value;
        }
        public List<ClassDonHang> LoadDanhSachDonHang()
        {
            List<ClassDonHang> list = new List<ClassDonHang>();

            string query = "select * from donhang";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                list.Add(new ClassDonHang(item));
            }

            return list;
        }

        public List<ClassDonHang> LoadDanhSachDonHangTheoKH(string MaKH)
        {
            List<ClassDonHang> list = new List<ClassDonHang>();

            string query = "select * from donhang where makhachhang ='" + MaKH +"'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                list.Add(new ClassDonHang(item));
            }

            return list;
        }
    }
}
