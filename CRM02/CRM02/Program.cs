using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM02
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Creates and initializes a CultureInfo.
            CultureInfo myCI = new CultureInfo("vi-VN", false);

            // Clones myCI and modifies the DTFI and NFI instances associated with the clone.
            CultureInfo myCIclone = (CultureInfo)myCI.Clone();
            myCIclone.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy";
            myCIclone.DateTimeFormat.DateSeparator = "/";
            myCIclone.NumberFormat.CurrencySymbol = "đ";
            myCIclone.NumberFormat.NumberDecimalDigits = 4;
            myCIclone.NumberFormat.PercentSymbol = "%";
            CultureInfo.DefaultThreadCurrentCulture = myCIclone;
            CultureInfo.DefaultThreadCurrentUICulture = myCIclone;

            


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin()); 
        }
    }
}
