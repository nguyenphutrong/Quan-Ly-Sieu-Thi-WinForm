using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM02
{
    class ClassQuanLyKhachHang
    {
        private static ClassQuanLyKhachHang instance;

        public ClassQuanLyKhachHang()
        {
        }

        public static ClassQuanLyKhachHang Intance {
            get{ if (instance== null) instance = new ClassQuanLyKhachHang(); return instance;}
            set => instance = value;
        }

        public List<ClassKhachHang> LoadDanhSachKhachHang()
        {
            List<ClassKhachHang>  list = new List<ClassKhachHang>();

            string query = "select * from KhachHang";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                list.Add(new ClassKhachHang(item));
            }
            return list;
        }
        public ClassKhachHang TraCuuKhachHang(string soDienThoai)
        {
            string query = "select * from KhachHang where dienthoai='" + soDienThoai + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            if (data.Rows.Count <= 0)
            {
                return null;
            }
            return new ClassKhachHang(data.Rows[0]);
        }

    }
}
