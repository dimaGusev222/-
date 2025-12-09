using System;
using System.Windows.Forms;

namespace FoodDeliveryApp
{
    internal static class Program
    {
        // ОБЩАЯ строка подключения для всех форм
        // Путь укажи к СВОЕМУ файлу .mdb
        public static string ConnStr =
            @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database\fooddb.mdb";

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1()); // старт с формы авторизации
        }
    }
}
