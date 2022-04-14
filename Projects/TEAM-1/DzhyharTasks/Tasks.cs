using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DzhyharTasks

{

    public class Tasks
    {



        public Tasks task201()
        {
            Console.Write("Введіть перше число: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введіть друге число: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Середнє арифматичне:  {(a + b) / 2}");
            return this;

        }
        public Tasks task202()
        {
            Console.Write("Введіть кількість гривень: ");
            double d = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Буде в доларах:  { d / 29.24} Буде в євро: {d / 31.92}");
            return this;
        }
        public Tasks task203()
        {
            Console.WriteLine($"To be or not to be \n \\Shakespeare\\ ");
            return this;
        }
        public Tasks task204()
        {
            Console.Write("Введіть число: ");
            double g = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Квадрат числа буде: {g * g}");
            return this;
        }
        public Tasks task205()
        {
            Console.Write("Введіть перше число: ");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введіть друге число: ");
            double e = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введіть третє число: ");
            double f = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Сума чисел буде:  {c + e + f} Добуток чисел буде {c * e * f} ");
            return this;
        }
    }
}