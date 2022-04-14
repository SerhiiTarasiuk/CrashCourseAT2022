/*
ООП 
Перегружені конструктори. this

Розробити клас Person, який містить відповідні члени для зберігання:
імені, віку, статі і телефонного номера.
Напишіть функції-члени, які зможуть змінювати ці члени даних індивідуально. Напишіть функцію-член Person :: Print (), яка виводить відформатовані дані про людину.
*/

using System;

namespace ex303
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Alex", 21, person_sex.m, "+38097-123-45-67");
            Person p2 = new Person("Smith",25,person_sex.m);
            Console.WriteLine("Person p1");
            Console.WriteLine(p1.Print());
            p1.Set_Name("Joe");
            Console.WriteLine("New name of person p1 : " + p1.Get_Name());
            Console.WriteLine(p1.Print());
            p1.Set_Age(28);
            Console.WriteLine("New age of person p1 : " + p1.Get_Age());
            Console.WriteLine(p1.Print());
            Console.WriteLine("Person p2");
            Console.WriteLine(p2.Print());
            p2.Set_Phone("+38063-789-56-12");
            Console.WriteLine("New phone of person p2 : " + p2.Get_Phone());
            Console.WriteLine(p2.Print());
            p2.Set_sex(person_sex.f);
            Console.WriteLine("New sex of person p2 : " + p2.Get_sex() + " ("+p2.Get_sex_toString()+")");
            Console.WriteLine(p2.Print());
            Console.ReadKey();
        }
    }
}
