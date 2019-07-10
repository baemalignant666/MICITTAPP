using MicittApp.UI.OnPromises.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MicittApp.UI.OnPromises
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        public static class MystaticValues
        {
            public static string IdSession = "N/A";
        }
        static ApplicationContext MainContext = new ApplicationContext();
        [STAThread]
        static void Main()
        {
           
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                MainContext.MainForm = new frmLogin();
                Application.Run(MainContext);
        }
        public static void SetMainForm(Form MainForm)
        {
            MainContext.MainForm = MainForm;
        }
        public static void ShowMainForm()
        {
            MainContext.MainForm.Show();
        }
    }
}
