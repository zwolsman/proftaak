﻿using System;
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
            Application.Run(new frmModifyMaterial());
        }
    }
}
