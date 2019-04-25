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


    }
}
