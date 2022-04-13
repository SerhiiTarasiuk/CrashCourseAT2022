/*
ООП 
Перегружені конструктори. this

Створіть клас Passport (паспорт), який буде містити паспортну інформацію про громадянина України. За допомогою механізму наслідування,
реалізуйте клас ForeignPassport (закордонний паспорт) похідний від Passport. Нагадаємо, що закордонний паспорт містить крім паспортних даних,
також дані про візи, номер закордонного паспорта.
*/

using System;
using System.Collections.Generic;

namespace ex315
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Passport p1 = new Passport("Alex", "Smith", new DateTime(1995, 5, 7, 0, 0, 0), "НК1234567", new DateTime(2018, 11, 9, 0, 0, 0), new DateTime(2028, 11, 9, 0, 0, 0));
            Console.WriteLine(p1.Print());
            Console.WriteLine();

            ForeignPassport fp1 = new ForeignPassport("Alex", "Smith", new DateTime(1995, 5, 7, 0, 0, 0), "FD95-1234589", new DateTime(2018, 12, 15, 0, 0, 0), new DateTime(2028, 12, 15, 0, 0, 0));
            Visa v1 = new Visa("Medyka", new DateTime(2021, 6, 5, 15, 20, 0));
            Visa v2 = new Visa("Korczowa", new DateTime(2021, 6, 25, 14, 10, 0));
            Visa v3 = new Visa("Medyka", new DateTime(2021, 7, 21, 9, 15, 0));
            Visa v4 = new Visa("Korczowa", new DateTime(2021, 8, 10, 19, 25, 0));
            fp1.AddVisa(v1);
            fp1.AddVisa(v2);
            fp1.AddVisa(v3);
            fp1.AddVisa(v4);
            Console.WriteLine(fp1.Print());
            Console.ReadKey();
        }
    }
}
