using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace COCOMO_v_1._0
{
    public class EAF
    {
        public double a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15,a16,a17; // параметры
        public EAF()
        {
            a1 = 1;
            a2 = 1;
            a3 = 1;
            a4 = 1;
            a5 = 1;
            a6 = 1;
            a7 = 1;
            a8 = 1;
            a9 = 1;
            a10 = 1;
            a11 = 1;
            a12 = 1;
            a13 = 1;
            a14 = 1;
            a15 = 1;
            a16 = 1;
            a17 = 1;
        }
        public double CalcEAF()
        {
            double a;
            a = a1 * a2 * a3 * a4 * a5 * a6 * a7 * a8 * a9 * a10 * a11 * a12 * a13 * a14 * a15*a16*a17;
                return a;
        }
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
            Application.Run(new Калькулятор());
        }
    }
}
