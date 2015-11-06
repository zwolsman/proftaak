using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseLibrary;

namespace MateriaalBeheer
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DatabaseManager.Initialize("sa", "Wachtwoord1", "127.0.0.1", "proftaak");
            DatabaseManager.Open();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Uncomment one of the commented lines below to test
            //Application.Run(new frmModifyMaterial());
            //Application.Run(new frmRentMaterial());
            //Application.Run(new frmSelectEvent());
        }
    }
}
