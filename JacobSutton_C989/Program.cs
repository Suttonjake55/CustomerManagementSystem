using JacobSutton_C989.DataBase;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace JacobSutton_C989
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            dbConnection.startConnection();
            //Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("es-ES");
            //Thread.CurrentThread.CurrentUICulture = new CultureInfo("es-ES");
            Application.Run(new LoginForm());
            dbConnection.closeConnection();
        }
    }
}
