/*
Методи, аргументи методів. Сигнатура. Перезавантажені (overload) методи.  Аргументи за замовчуванням. Глобальні та локальні змінні.

Написати overload методи RemoveFromString, які приймають текст і видаляють з нього або певний набір символів, або символ\символи за порядковим номером в тексті.
Реалізувати використання аргументів за замовчуванням та глобальних\локальних змінних
*/

using System;

namespace ex221
{
    internal class Program
    {
        static string RemoveFromString(string str, int[] index)
        {
            string tmp = "";
            char[] char_array = new char[str.Length];

            str.CopyTo(0, char_array, 0, str.Length);
            for (int i = 0; i < index.Length; i++)
            {
                if (index[i] >= 0 && index[i] < char_array.Length) char_array[index[i]] = '\0';
            }

            for (int i = 0; i < char_array.Length; i++)
            {
                if (char_array[i] != '\0') tmp += char_array[i];
            }
            return tmp;
        }


        static string RemoveFromString(string str, char[] index)
        {
            string tmp = "";
            char[] char_array = new char[str.Length];

            str.CopyTo(0, char_array, 0, str.Length);
            for (int i = 0; i < index.Length; i++)
            {
                for (int j = 0; j < char_array.Length; j++)
                {
                    if (char_array[j] == index[i]) char_array[j] = '\0';
                }
            }

            for (int i = 0; i < char_array.Length; i++)
            {
                if (char_array[i] != '\0') tmp += char_array[i];
            }
            return tmp;
        }


        static void Main(string[] args)
        {
            char[] char_arr = { 'o', 'r', 'e' };
            int[] int_arr = { 1, 2, 5 };
            Console.WriteLine("Початкова строка\n");
            Console.WriteLine("Hello World!\n");
            Console.Write("Видаляємо символи - ");
            for (int i = 0; i < char_arr.Length; i++) Console.Write(char_arr[i] + " ");
            Console.WriteLine("\nРезультат роботи");
            Console.WriteLine(RemoveFromString("Hello World!", char_arr));

            Console.WriteLine("\nПочаткова строка\n");
            Console.WriteLine("Hello World!\n");
            Console.Write("Видаляємо символи які знаходяться в позиції - ");
            for (int i = 0; i < int_arr.Length; i++) Console.Write(int_arr[i] + " ");
            Console.WriteLine("\nРезультат роботи");
            Console.WriteLine(RemoveFromString("Hello World!", int_arr));
            Console.ReadKey();
        }
    }
}
