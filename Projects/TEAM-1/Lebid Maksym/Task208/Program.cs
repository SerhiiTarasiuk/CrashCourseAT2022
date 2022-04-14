using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task208
{
    class Program
    {
        //Відомо, що 1 дюйм дорівнює 2.54 см. Розробити додаток, що переводять дюйми в сантиметри і навпаки. Діалог з користувачем реалізувати через систему меню.
        static void Main(string[] args)
        {
            int choice;
            float var;
            Console.WriteLine("Enter 1 for cm to inch, and 2 for inch to cm");
            choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter amount: ");
            var = Convert.ToSingle(Console.ReadLine());
            if (choice == 1)
            {
                var /= 2.54f;
                Console.WriteLine($"{var} inch");
            }
            else if (choice == 2)
            {
                var *= 2.54f;
                Console.WriteLine($"{var} cm");
            }
            else Console.WriteLine("Wrong number");
        }
    }
}
