using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//"4. Користувач вводить з клавіатури число - програма повинна показати скільки в даному числі цифр. Число вводиться повністю в одну змінну.
//Примітка: Наприклад, користувач ввів число 11123445555. На екрані має з'явитися повідомлення про те, що в числі 5 цифр."
namespace _212
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number");
            int num = Convert.ToInt32(Console.ReadLine());
            var list = new List<int>();
            int res = 0;
            do
            {
                res = num % 10;
                list.Add(res);
                num /= 10;
            } while (num != 0);

            var unique = list.Distinct();
            var length = unique.Count();
            foreach (var i in unique)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine($"В числe {length} цифр");

        }
    }
}
