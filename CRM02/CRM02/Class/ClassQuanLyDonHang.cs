using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public string LoadMaDH()
        {
            string madh = "";

            madh = "DH" + DateTime.Now.Day.ToString("00") + DateTime.Now.Month.ToString("00") + DateTime.Now.Year.ToString("0000");

            string query = String.Format("SELECT dbo.fn_Get_MaDonHang_Next( @MaDH )");

            object madh_next = DataProvider.Instance.ExecuteScalar(query, new object[] { madh });

            if (madh_next.ToString() == "")
            {
                madh_next = madh + "001";
            }
            return madh_next.ToString();
        }

        public bool LuuDonHang(ClassDonHang dh)
        {
            string query = String.Format("insert into DonHang values('{0}','{1}','{2}','{3}','{4}')",dh.MaDH,dh.MaKH,dh.ThanhTien,dh.NguoiTao,dh.NgayTao);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

    }
}
