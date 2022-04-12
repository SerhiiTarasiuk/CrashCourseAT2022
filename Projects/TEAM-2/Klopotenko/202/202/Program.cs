using System;

namespace _202
{
    class Program
    {
        static void Main(string[] args)
        {
            double uah = 100;
            double exchangeRate = 32.06;
            Console.WriteLine($"{uah} UAH is {uah * exchangeRate} EUR");
        }
    }
}
