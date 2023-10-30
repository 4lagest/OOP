using System;
using System.Globalization;

namespace DZ1
{
    class Programm
    {
        static double f1(double a, double b, double c)
        {
            return (double)(c-a)*(b-a);
        }
        public static int Main()
        {
            int f = 1;
            do
            {
                Console.WriteLine("Введите значения параметра A:");
                double a = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Введите значения параметра В:");
                double b = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Введите значения параметра С:");
                double c = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (a >= b)
                {
                    Console.WriteLine("Ошибка(A>=B)");
                }
                else if (b <= a)
                {
                    Console.WriteLine("Ошибка(B<=A)");
                }
                else if ((c <= a) ^ (c >= b))
                {
                    Console.WriteLine("Ошибка(C не входит в отрезок между А и В или принимает равные им значения)");
                }
                else if ((c > a) && (c < b))
                {
                    Console.WriteLine($"Значение произведения длин отрезков AC и CB: {f1(a, b, c):0.00}");
                }
                Console.WriteLine("Чтобы повторить выполнение нажмите 1, чтобы остановить-0");
                f = Convert.ToInt32(Console.ReadLine());
            }while (f == 1);
            return 0;
        }
    }
}
