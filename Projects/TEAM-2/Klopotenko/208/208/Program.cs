using System;

namespace _208
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose what do you want to do. \"Convert centimeters " +
                "to inches\" or \"Convert inches to centimeters\": ");
            /* Enter only Convert centimeters to inches or 
            Convert inches to centimeters */

            string whatToDo = Console.ReadLine();
            if(whatToDo == "Convert centimeters to inches")
            {
                Console.Write("Enter the value of centimeters: ");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"{a} centimeters is {a / 2.54} inches");
            }
            if (whatToDo == "Convert inches to centimeters")
            {
                Console.Write("Enter the value of inches: ");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"{a} inches is {a * 2.54} centimeters");
            }

        }
    }
}
