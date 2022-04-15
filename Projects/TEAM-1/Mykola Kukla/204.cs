







//4.Напишіть програму, яка обчислює квадрат будь-якого, введеного числа.

namespace Tasks
{
    class Program
    {

        static void Main(string[] args)
        {
            string w;

            int  a, b;

            Console.WriteLine("Enter the length of one side of the square ");

            w = Console.ReadLine();

            a = Convert.ToInt32(w);

            Console.WriteLine("Enter the length of the other side of the square ");

            w = Console.ReadLine();

            b = Convert.ToInt32(w);

            int result = (a * b);

            Console.WriteLine("The area is equal to " + result);




        }

    }
}
