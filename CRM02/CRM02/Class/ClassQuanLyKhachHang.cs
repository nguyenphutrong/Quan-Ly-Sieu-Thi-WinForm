using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public bool XoaKhachHang(string id)
        {
            string query = "delete from KhachHang where makhachhang='" + id + "'";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool ThemKhachHang(ClassKhachHang kh)
        {
            string query = String.Format("insert into KhachHang values('{0}',N'{1}','{2}',N'{3}','{4}','{5}','{6}','{7}')", kh.MaKH, kh.HoTen, kh.NgaySinh,kh.DiaChi,kh.DienThoai,kh.DiemThuong,kh.HangThanhVien,kh.NgayDK);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool SuaKhachHang(ClassKhachHang kh)
        {
            string query = String.Format("update KhachHang set hoten=N'{0}', ngaysinh='{1}',diachi=N'{2}',dienthoai='{3}' where makhachhang='{4}'", kh.HoTen, kh.NgaySinh, kh.DiaChi, kh.DienThoai,kh.MaKH);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool SuaHangKhachHang(string makh ,string hangtemp)
        {
            string query = String.Format("update KhachHang set mahang='{0}' where makhachhang='{1}'", hangtemp, makh);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool TichDiem(string id,int diem)
        {
            string query = String.Format("update KhachHang set diemthuong='{0}' where makhachhang='{1}'", diem,id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
     

    }
}
