using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task221
{
    class Program
    {
        //Написати overload методи RemoveFromString, які приймають текст і видаляють з нього
        // або певний набір символів, або символ\символи за порядковим номером в тексті.
        //Реалізувати використання аргументів за замовчуванням та глобальних\локальних змінних
        static void Main(string[] args)
        {
            string str = "";
            List<char> chars = new List<char>();
            List<int> serial_nums = new List<int>();
            Console.Write(" Enter any words :  ");
            str = Console.ReadLine();
            Console.WriteLine(" Enter 3 chars what you want remove : ");
            chars.Add(char.Parse(Console.ReadLine()));
            chars.Add(char.Parse(Console.ReadLine()));
            chars.Add(char.Parse(Console.ReadLine()));
            Console.WriteLine(" Enter 3 serial numbers where you want remove symb : ");
            serial_nums.Add(Int32.Parse(Console.ReadLine()));
            serial_nums.Add(Int32.Parse(Console.ReadLine()));
            serial_nums.Add(Int32.Parse(Console.ReadLine()));

            Console.WriteLine(" You use RemoveFromString what remove some chars");
            str = RemoveFromString(str, chars);
            Console.WriteLine("\t" + str + "\n You use RemoveFromString what remove chars on serial numbers");
            str = RemoveFromString(str, serial_nums);
            Console.WriteLine("\t" + str);
        }

        private static string RemoveFromString(string str, List<char> chars)
        {
            foreach (var item in chars)
            {
                str = str.Replace(item.ToString(), "");
            }
            return str; 
        }
        private static string RemoveFromString(string str, List<int> serial_nums)
        {
            foreach (var item in serial_nums)
            {
                str = str.Remove(item, 1);
            }
            return str;
        }
    }
}
