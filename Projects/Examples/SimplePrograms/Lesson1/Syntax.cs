using System;
using System.Collections.Generic;


namespace Lesson1
{
    class Syntax
    {
        public static void Main(string[] args)
        {
            float floatExample = 1.3f;

            string stringExample = "Simple string";

            var caracterVariable = 'C';

            bool isTrue = false;


            var a = 1;
            int b = 2;

            a = b;


            var result = a + b;
            a++;
            a += 23;
            a -= 34;

            result = a % b;

            isTrue = a <= b;
            isTrue = a == b;

            //тринарний логічний оператор
            var logicalResult = isTrue? tryTrenary() : false;
            
            Console.WriteLine(logicalResult);
            Console.Beep();

            //Бажано використовувати var - компілятор сам визначить і встановить необхідний тип даних для змінної
            var variableExample = "45567";


            DateTime currentDay = DateTime.Today;


            //Масиви
            int[] intArray, intArray2;

            intArray = new int[3] { 1, 2, 3 };

            string[] strArray = new string[3] { "one", "two", "three" };

            int[,] Array2D = new int[4, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 }, { 10, 11, 12 } };


            isTrue = true;


            //Оператори вітвлень 

            /*
            for (int i = 0; i <= 3; i++)
            {
                for (int j = 0; j <= 2; j++)
                {
                    Console.WriteLine($"Array value {Array2D[i, j]}");
                }

            ;

                intArray2 = intArray;
                intArray[0] = 8;

                foreach (var iterator in intArray2)
                {
                    Console.WriteLine($"List value {iterator}");
                }


                string stringExample2 = stringExample;

                stringExample = "Changed string";
                Console.Write(stringExample2);


                //Console.WriteLine("Array value " + intArray[0]);

                //Console.Write(stringExample);



                var fromConsole = Console.ReadLine();

                switch (fromConsole)
                {
                    case "1":
                        Console.WriteLine("variable = 1");
                        break;
                    case "2":
                        Console.WriteLine("variable = 2");
                        break;
                    case "3":
                        Console.WriteLine("variable = 3");
                        break;
                    case "4":
                        Console.WriteLine("variable = 4");
                        break;
                    default:
                        Console.WriteLine("variable by default");
                        break;
                        // goto case "1"; return или throw;
                }

                if (isTrue)
                {
                    Console.WriteLine(isTrue);
                }
                else if (1 != 1)
                {
                    Console.WriteLine(isTrue);
                }


                isTrue = true;


                Console.WriteLine(isTrue ? tryTrinity() : false);

                /*           

                       //for (int i = 0; i <=2; i++)
                       //{
                       //    Console.WriteLine($"Array value {intArray[i]}");
                       //}

                       //List<int> numList = new List<int>();

                       //numList.Add(2);
                       //numList.Add(21);
                       //numList.Add(22);
                       //numList.Add(23);

                       //numList.RemoveAt(2);

                       foreach (var iterator in numList)
                       {
                           Console.WriteLine($"List value {iterator}");
                       }

                       var i = 10;
                       while (i > 1) {
                           Console.WriteLine($"Iteration # {i}");
                           i--;
                       };

                       do
                       {
                           Console.WriteLine($"Iteration # {i}");
                           i--;
                       } while (i > 1);
                */

            //Tuples - кортежі
            (string, int, double) person = ("Tom", 25, 81.23);
            (string, int, double) person1 = person;

            person.Item1 = "changed";

            Console.WriteLine(person1.Item1);


            //Enums - приклад роботи з перечисленнями
            Console.WriteLine(Days.Monday);
            Console.WriteLine((int)Days.Wednesday);


            //    Console.WriteLine($"Press any button to finish program");
            //   Console.ReadLine();
        }

        //оголошення статичного методу tryTrenary()
        //статичні методи належать класу а не об'єкту, для роботи зі статичними методами не потрібно створювати об'єкт
        public static bool tryTrenary()
        {
            Console.WriteLine("Test breakpoins");
            return true;
        }


        //Enums - приклад перечислень
        enum Days
        {
            Monday = 1,
            Tuesday = 2,
            Wednesday = 4,
            Thursday = 4,
            Friday,
            Saturday,
            Sunday
        }
        
    }
}
