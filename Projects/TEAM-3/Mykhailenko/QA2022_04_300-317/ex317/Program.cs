/*
ООП 
Перегружені конструктори. this

Створити абстрактний базовий клас з віртуальною функцією - площа. Створити похідні класи: прямокутник, коло, прямокутний трикутник, трапеція зі своїми функціями площі.
Для перевірки визначити масив посилань на абстрактний клас, яким присвоюються адреси різних об'єктів. Площа трапеції: S = (a + b) h / 2 
*/

using System;

namespace ex317
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Figure[] arr_figure = {new Circle(4),
                                   new Rectangle(3,4),
                                   new RightTriangle(3,4),
                                   new Trapezoid(13,8,7) };
            foreach (Figure figure in arr_figure)
            {
                Console.WriteLine("Square : {0}",figure.Square());
            }
            Console.ReadKey();
        }
    }
}
