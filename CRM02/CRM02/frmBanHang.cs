using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM02
{
    public partial class frmBanHang : Form
    {
        public frmBanHang()
        {
            InitializeComponent();
        }
        private static frmBanHang _singleton;
        public static frmBanHang CreateInstance()
        {
            if (_singleton == null)
            {
                _singleton = new frmBanHang();
            }
            return _singleton;
        }
    }
}
