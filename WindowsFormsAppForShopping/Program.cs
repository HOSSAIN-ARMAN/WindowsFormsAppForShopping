using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppForShopping
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Category());
            //Application.Run(new Product());
            //Application.Run(new Customer());
            //Application.Run(new Supplier());
            //Application.Run(new Purchase());
            Application.Run(new SalesModule());
        }
    }
}
