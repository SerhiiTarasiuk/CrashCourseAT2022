using System;

namespace _209
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter symbol: ");
            char symbol = Convert.ToChar(Console.ReadLine());
            Console.Write("Enter length: ");
            int length = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter orientation Horisontal or Vertical: "); // Enter only "Horisontal" or "Vertical"
            string orientation = Console.ReadLine();
            switch (orientation)
            {
                case "Horisontal":
                    for (int i = 1; i <= length; i++)
                    {
                        Console.Write(symbol);
                    }
                    break;
                case "Vertical":
                    for (int i = 1; i <= length; i++)
                    {
                        Console.WriteLine(symbol);
                    }
                    break;
                default:
                    Console.WriteLine("Unknown orientation");
                    break;
            }
        }
    }
}

