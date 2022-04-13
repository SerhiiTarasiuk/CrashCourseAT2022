/*
Робота з масивами.Сортування масивів.

Написати перевантажені функції для знаходження коренів лінійного (a* x + b = 0) і квадратного(a* x2 + b* x + c = 0) рівнянь.
Зауваження: у функції передаються коефіцієнти рівнянь.
*/

using System;



namespace ex222
{
    internal class Program
    {

        public static double calc_ur(double a, double b) { return (-b) / a; }

        public static double[] calc_ur(double a, double b, double c)
        {
            double[] result = new double[3];
            result[0] = 0d; //признак того що корнів немає

            double d = Math.Pow(b, 2) - 4 * a * c;
            if (d < 0) return result;
            else
            {
                result[0] = 2;
                result[1] = ((-b) + Math.Sqrt(d)) / (2 * a);
                result[2] = ((-b) - Math.Sqrt(d)) / (2 * a);
                return result;
            }
        }

        public static void print_sqrt(double[] t)
        {
            if (t[0] == 0) Console.WriteLine("Дискриминант менше нуля, корнів немає");
            else Console.WriteLine("x1={0}; x2={1}", t[1], t[2]);
        }
        static void Main(string[] args)
        {
            double[] a;
            Console.WriteLine("Рішення лінійного рівняння {0}*x+{1}=0 x={2}\n", 2, 3, calc_ur(2, 3));
            Console.WriteLine("Рішення квадратного рівняння {0}*x*x+{1}*x+{2}=0", 1, 8, 12);
            a = calc_ur(1, 8, 12);
            print_sqrt(a);
            Console.WriteLine("Рішення квадратного рівняння {0}*x*x+{1}*x+{2}=0", 1, 5, 20);
            a = calc_ur(1, 5, 20);
            print_sqrt(a);
            Console.ReadKey();
        }
    }
}
