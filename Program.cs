using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Шаверма_мейкер
{
    static class Data
    {
        public static int Summ { get; set; } //глобальная переменная стоимости шавы
        public static int Ost { get; set; } //глобальная переменная шкалы остроты
        public static int Calories { get; set; } //глобальная переменная калорий

    }
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
            Application.Run(new Form1());
        }
    }
}
