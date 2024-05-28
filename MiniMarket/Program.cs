using MiniMarket.GUI;
using MiniMarket.PATTERN;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniMarket
{
    internal static class Program
    {
        // Khởi tạo một Subject để quản lý notify việc thay đổi số lượng sản phầm
        public static ProductQuantityChangeSubject ProductQuantityChangeSubject = new ProductQuantityChangeSubject();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //var currentCulture = CultureInfo.GetCultureInfo("vi-VN").Clone() as CultureInfo;
            //CultureInfo.DefaultThreadCurrentCulture = currentCulture;
            //CultureInfo.DefaultThreadCurrentUICulture = currentCulture;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormLogin());
        }
    }
}
