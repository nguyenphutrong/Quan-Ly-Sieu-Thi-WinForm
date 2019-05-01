using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM02
{
    class ClassQuanLyChiTietDonHang
    {
        private static ClassQuanLyChiTietDonHang instance;

        public ClassQuanLyChiTietDonHang()
        {
        }

        public static ClassQuanLyChiTietDonHang Intance
        {
            get { if (instance == null) instance = new ClassQuanLyChiTietDonHang(); return instance; }
            set => instance = value;
        }

        public List<ClassChiTietDH> LoadData(string id)
        {
            List<ClassChiTietDH> list = new List<ClassChiTietDH>();

            string query = "select * from ChiTietDonHang where madonhang='"+id+"'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                list.Add(new ClassChiTietDH(item));
            }

            return list;
        }

        public bool LuuDonHang(string madh,string masp, int sl, int gia)
        {
            
            string query = String.Format("insert into ChiTietDonHang values('{0}','{1}','{2}','{3}')", madh,masp,sl,gia);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

    }
}
