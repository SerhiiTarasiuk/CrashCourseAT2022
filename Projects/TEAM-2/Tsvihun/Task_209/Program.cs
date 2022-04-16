/*
209. 
Розробити програму, яка виводить на екран горизонтальну лінію з символів. Кількість символів, 
який використовувати символ, і яка буде лінія - вертикальна, або горизонтальна - вказує користувач.
 */
using System;

public class Newclass
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter symbol: ");
        char symbol = Console.ReadLine()[0];

        Console.WriteLine("Enter line length: ");
        int length = Convert.ToInt32(Console.ReadLine());   // Number of symbols

        Console.WriteLine("Choose direction: \n1 - horizontal\n2 - vertical");
        string direction = Console.ReadLine();  // Horizontal or vertical line

        switch (direction)
        {
            case "1":
                for (int i = 0; i < length; i++)
                {
                    Console.Write(symbol);
                };
                break;
            case "2":
                for (int i = 0; i < length; i++)
                {
                    Console.WriteLine(symbol);
                };
                break;
            default:
                Console.WriteLine("Choose only 1 or 2");
                break;
        }
    }
}