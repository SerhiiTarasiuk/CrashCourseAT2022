using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_1
{
    static class zadachi
    {
      //сероеднє двох чисел
        public static float serednie(float num1,float num2)
        {
            return (num1 + num2) / 2;
        }
        public static float ChangeGryvna(int gryvna, char flag, int kursdol=31,int kursevro=33)
        {
            if (flag == 'd') return (float)gryvna / kursdol;
            else return gryvna / kursevro;
        }
        public static int Shakespiere()
        {
           Console.WriteLine("To be or not to be\n \\ Shakespeare \\");
            return 0;
        }
        public static double Square(double num)
        {
            return num * num;
        }
        public static double SumMult(double num1, double num2,double num3)
        {
            Console.WriteLine(num1 +num2 + num3);
            Console.WriteLine( num1 * num2 * num3);
            return 0;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            float a = 2, b = 6.4f;
            int grn;
            Console.WriteLine("Середнє");
            Console.WriteLine(zadachi.serednie(a, b)) ;
            Console.WriteLine("Обмін гривні. Введіть гривні");
            grn=int.Parse(Console.ReadLine());
            Console.WriteLine("Результат:");
            Console.WriteLine(zadachi.ChangeGryvna(grn,'d'));
             Console.ReadLine();
        }
    }
}
