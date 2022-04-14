/*
ООП 
Перегружені конструктори. this

Створити абстрактний базовий клас Employer (службовець) з віртуальною функцією Print (). Створіть три класи нащадки: President, Manager, Worker.
Перевизначите функцію Print () для виведення інформації, що відповідає кожному типу службовця.
*/
using System;

namespace ex316
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employer[] personal = {new President("Olga", "Sumska", 3500, "Alex Smith", "BMW"),
                                    new Manager("Aleksander", "Makedonskiy", 1500, 302),
                                    new Manager("Taras", "Shevshenko", 1800, 301),
                                    new Worker("Natalka", "Poltavka", 800, "Developer"),
                                    new Worker("Olena", "Triyanska", 600, "Developer"),
                                    new Worker("Mikola", "Tesla", 750, "Developer"),
                                    new Worker("Mikola", "Hohol", 700, "Developer"),
                                    new Worker("Olga", "Kiyvska", 650, "Developer") };
            foreach (Employer emp in personal) { emp.Print(); emp.Say(); Console.WriteLine(); }
            Console.ReadKey();
        }
    }
}
