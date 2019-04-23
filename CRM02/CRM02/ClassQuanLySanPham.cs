using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM02
{
    class ClassQuanLySanPham
    {
        private static ClassQuanLySanPham instance;

        public ClassQuanLySanPham()
        {
        }

        public static ClassQuanLySanPham Intance {
            get{ if (instance== null) instance = new ClassQuanLySanPham(); return instance;}
            set => instance = value;
        }

        public List<ClassSanPham> LoadDanhSachSanPham()
        {
            List<ClassSanPham>  list = new List<ClassSanPham>();

            string query = "select * from sanpham";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                list.Add(new ClassSanPham(item));
            }

            return list;
        }


    }
}
