using System;
using System.Globalization;

namespace Lab1
{
    public class Lab1
    {
        public static double f1(double a)
        {
            var b = 1 - 0.25 * Math.Pow(Math.Sin(2 * a), 2) + Math.Cos(2 * a);
            return b;
        }
        public static double f2(double a)
        {
            var b = Math.Pow(Math.Cos(a),2) + Math.Pow(Math.Cos(a), 4);
            return b;
        }
        static int Main(string[] args)
        {
            int f = 1;
            do
            {
                Console.WriteLine("Введите параметр а:");
                double a = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine($"z1: {f1(a):0.00}\nz2: {f2(a):0.00}");
                Console.WriteLine("Чтобы повторить выполнение нажмите 1, чтобы остановить-0");
                f=Convert.ToInt32(Console.ReadLine());
            } while (f == 1);
            return 0;
        }
    }
}
    
