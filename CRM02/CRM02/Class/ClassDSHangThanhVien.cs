using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM02
{
    class ClassDSHangThanhVien
    {
        private static ClassDSHangThanhVien instance;

        public ClassDSHangThanhVien()
        {
        }

        public static ClassDSHangThanhVien Intance
        {
            get { if (instance == null) instance = new ClassDSHangThanhVien(); return instance; }
            set => instance = value;
        }

        public List<ClassHangThanhVien> LoadDanhSachHangTV()
        {
            List<ClassHangThanhVien> list = new List<ClassHangThanhVien>();

            string query = "select * from hangthanhvien";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                list.Add(new ClassHangThanhVien(item));
            }

            return list;
        }

        public ClassHangThanhVien getDataById(string id)
        {
            ClassHangThanhVien item = new ClassHangThanhVien();               
            string query = "select * from hangthanhvien where mahang='" + id + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            if (data.Rows.Count > 0)
            {
                item =  new ClassHangThanhVien(data.Rows[0]);
            }

            return item;
        }

        public bool XoaHangThanhVien(string id)
        {
            string query = "delete from HangThanhVien where mahang='" + id + "'";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool ThemHangThanhVien(ClassHangThanhVien kh)
        {
            string query = String.Format("insert into HangThanhVien values('{0}','{1}','{2}','{3}')", kh.MaHang, kh.TenHang, kh.Dklenhang, kh.Quyenloi);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool SuaHangThanhVien(ClassHangThanhVien kh)
        {
            string query = String.Format("update HangThanhVien set tenhang='{0}', dieukienlenhang='{1}',quyenloi='{2}' where mahang='{3}'", kh.TenHang, kh.Dklenhang, kh.Quyenloi, kh.MaHang);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }


    }
}
