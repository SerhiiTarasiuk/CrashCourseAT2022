using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
static class zadachi
{
    public static bool Parn(int num)
    {
        return (num % 2 == 0);
    }
    public static int DigitAmount(int a)
    { int digit;
        int i = 0, s = 0;
        while (a > 0) { digit = a % 10; a /= 10; i++; s += digit; }
        Console. WriteLine(i + " " + s);
        return 0;
    }
    public static int Inch()
    {
        float rez;
        byte numInput;
        int num;
        Console.WriteLine( " Переводимо дюйим в сантиметри та навпаки. Вибираємо варіант переведення(1/2)" );
        Console.WriteLine(" 1 дюйми->сантиметри");
        Console.WriteLine(" 2 сантиметри->дюйми");
        numInput=byte.Parse(Console.ReadLine());
        Console.WriteLine("Вводимо значення");
        num = int.Parse(Console.ReadLine());
        if (numInput == 1) rez = num * 2.54f; else rez = num / 2.54f;
            Console.WriteLine(rez);
        return 0;
    }
}
namespace Задача6_8
{
    class Program
    {  
        static void Main(string[] args)
        {
            //Console.WriteLine(zadachi.Parn(12));
           // zadachi.DigitAmount(1234);
            zadachi.Inch();
            Console.ReadLine();
        }
    }
}
