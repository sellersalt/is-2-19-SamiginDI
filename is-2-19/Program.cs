using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace is_2_19
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Menu());
        }
        
    }
    class Pod
    {
        public static string DV()
        {
            const string Host = "caseum.ru";
            const int Port = 33333;
            const string Polz = "test_user";
            const string DB = "db_test";
            const string Pass = "test_pass";

            string connStr = $"server={Host};port={Port};user={Polz};" + $"database={DB};password={Pass};";
            return connStr;
        }
    }
}
