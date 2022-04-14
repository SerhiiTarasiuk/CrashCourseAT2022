/*
Методи, аргументи методів. Сигнатура. Перезавантажені (overload) методи.  Аргументи за замовчуванням. Глобальні та локальні змінні.

Написати overload методи Add які в залежності від параметрів або додають цифрові значення, або об'єднують введені тексти.
Передбачити аргументи за замовчуванням і використання глобальних змінних.
*/

using System;

namespace ex220
{
    internal class Program
    {
        static int count = 0;
        public static int Add(int a, int b, int c = 0)
        {
            count++;
            return a + b + c;
        }
        public static double Add(double a, double b, double c = 0d)
        {
            count++;
            return a + b + c;
        }
        public static string Add(string a, string b)
        {
            count++;
            return a + b;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Приклад використання перезавантажених (overload) методів\n\nДодавання цілих чисел");
            Console.WriteLine("Додавання двох цілих чисел {0} + {1} = {2}", 2, 3, Add(2, 3));
            Console.WriteLine("Додавання трьох цілих чисел з використанням того ж самого методу {0} + {1} + {2} = {3}\n", 2, 3, 5, Add(2, 3, 5));
            Console.WriteLine("Додавання дробних чисел");
            Console.WriteLine("Додавання двох дробних чисел {0} + {1} = {2}", 2.7, 3.5, Add(2.7, 3.5));
            Console.WriteLine("Додавання трьох дробних чисел з використанням того ж самого методу {0} + {1} + {2} = {3}\n", 2.7, 3.5, 5.3, Add(2.7, 3.5, 5.3));
            Console.WriteLine("Додавання (обєднання) слів");
            Console.WriteLine("Обєднання двох слів {0} + {1} = {2}\n", "Hello ", "world", Add("Hello ", "world"));
            Console.WriteLine("Загальна кількість визовів методів в цьому додатку = {0}", count);
            Console.ReadKey();
        }
    }
}
