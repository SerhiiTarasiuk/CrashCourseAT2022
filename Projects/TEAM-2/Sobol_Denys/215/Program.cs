using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//"7. Написати програму, яка виводить на екран - наступну фігуру:
//"" * ********************
//**
//**
//**
//**
//*********************
//ширина і висота фігури встановлюються користувачем з клавіатури."
namespace hw_215
{
    class hw_215
    {
        static void Main(string[] args)
        {
            int weight, height;
            bool user_weight = true, user_height = true;

            while (user_weight)
            {
                Console.Write("Enter positive number - weight: ");
                if (int.TryParse(Console.ReadLine(), out weight))
                {
                    if (weight > 0)
                    {
                        while (user_height)
                        {
                            Console.Write("Enter positive number - height: ");
                            if (int.TryParse(Console.ReadLine(), out height))
                            {
                                if (height > 0)
                                {
                                    DrawRectangle(weight, height);
                                    user_height = false;
                                }
                            }
                        }

                        user_weight = false;
                    }
                }
            }
        }
        static void DrawRectangle(int weight, int height)
        {
            for (int x = 0; x < height; x++)
            {
                for (int y = 0; y < weight; y++)
                {
                    if (x == 0 || x == height - 1)
                        Console.Write("*");
                    else if (y == 0 || y == weight - 1)
                        Console.Write("*");
                    else Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}