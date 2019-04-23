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
    }
}
