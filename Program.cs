using GestionDeGastosMensuales.Data; 
using System;
using System.Windows.Forms;


namespace GestionDeGastosMensuales

{
    
    internal static class Program

    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            using (var db = new GastosDbContext())
            {
                db.Database.EnsureCreated();
            }

            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}
