/*
ООП 
Перегружені конструктори. this

Створіть клас Student, який буде містити інформацію про студента. За допомогою механізму наслідування, реалізуйте клас Aspirant (аспірант - студент,
який готується до захисту кандидатської роботи) похідний від Student.
*/

using System;

namespace ex314
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student st1 = new Student("Alex", "Smith", "Finance", 2);
            Student st2 = new Student("Sarash", "Koval", "Ecomonics", 3);
            Aspirant a1 = new Aspirant("Ben","Stone","Computers",6,"Logical Programming in Prolog","Adam Smith");

            Console.WriteLine(st1.Print());
            Console.WriteLine();
            Console.WriteLine(st2.Print());
            Console.WriteLine();
            Console.WriteLine(a1.Print());
            Console.ReadKey();
        }
    }
}
