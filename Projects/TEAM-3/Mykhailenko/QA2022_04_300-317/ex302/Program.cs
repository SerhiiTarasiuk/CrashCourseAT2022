/*
ООП
Класи і конструктори

Написати клас Студент. Також реалізувати клас, що описує групу студентів. Передбачити можливість визначення середньої успішності групи за певним предметом.
*/
using System;

namespace ex302
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student st1 = new Student("Alex", "Smith");
            Student st2 = new Student("Taras", "Shevshenko");
            Student st3 = new Student("Mikola", "Hohol");
            Student st4 = new Student("Alexandr", "Makedonskiy");
            Student st5 = new Student("Olga", "Kiyvska");
            Student st6 = new Student("Mikola", "Tesla");
            Student st7 = new Student("Natalka", "Poltavka");
            Student st8 = new Student("Olena", "Triyanska");
            Student st9 = new Student("Olga", "Sumska");

            Group gr1 = new Group("Sp22", "Programming");
            Group gr2 = new Group("Ek22", "Economic");


            st1.AddPredmet("C#", 5);
            st1.AddPredmet("Math",4);
            st1.AddPredmet("TheoryDB", 3);

            st2.AddPredmet("C#", 4);
            st2.AddPredmet("Math", 5);
            st2.AddPredmet("TheoryDB", 5);

            st3.AddPredmet("C#", 5);
            st3.AddPredmet("Math", 4);
            st3.AddPredmet("TheoryDB", 5);

            st4.AddPredmet("C#", 3);
            st4.AddPredmet("Math", 4);
            st4.AddPredmet("TheoryDB", 3);

            st5.AddPredmet("C#", 5);
            st5.AddPredmet("Math", 5);
            st5.AddPredmet("TheoryDB", 5);

            st6.AddPredmet("Economics", 5);
            st6.AddPredmet("Math", 4);
            st6.AddPredmet("English", 3);

            st7.AddPredmet("Economics", 3);
            st7.AddPredmet("Math", 3);
            st7.AddPredmet("English", 4);

            st8.AddPredmet("Economics", 5);
            st8.AddPredmet("Math", 4);
            st8.AddPredmet("English", 5);

            st9.AddPredmet("Economics", 5);
            st9.AddPredmet("Math", 5);
            st9.AddPredmet("English", 5);

            gr1.AddStudent(st1);
            gr1.AddStudent(st2);
            gr1.AddStudent(st3);
            gr1.AddStudent(st4);
            gr1.AddStudent(st5);
            gr2.AddStudent(st6);
            gr2.AddStudent(st7);
            gr2.AddStudent(st8);
            gr2.AddStudent(st9);

            gr1.PrintJornalGroup();
            Console.WriteLine();
            gr2.PrintJornalGroup();
            Console.WriteLine("\nAgv mark for Math");
            Console.WriteLine("For group : {0} agv mark : {1}", gr1.Name, gr1.AgvMark("Math"));
            Console.WriteLine("For group : {0} agv mark : {1}", gr2.Name, gr2.AgvMark("Math"));

            Console.ReadKey();


        }
    }
}
