using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    static class Data
    {
        public static float E { get; set; }
        public static float I { get; set; }
        public static float S { get; set; }
        public static float N { get; set; }
        public static float T { get; set; }
        public static float F { get; set; }
        public static float J { get; set; }
        public static float P { get; set; }
        public static bool pol { get; set; }//women or men
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
            Application.Run(new MainForm());
        }
    }
}
