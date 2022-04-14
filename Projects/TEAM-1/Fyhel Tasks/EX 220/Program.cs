using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_220
{
    class Program
    {
        //Написати overload методи Add які в залежності від параметрів або додають цифрові значення, або об'єднують введені тексти. Передбачити аргументи за замовчуванням і використання глобальних змінних.

        static int resultInt = 0;//global variables
        static string resultStr = string.Empty;
        
        static void Add(string lineStr)//string overload
        {
            resultStr += lineStr+" ";
        }
        static void Add(int numberInt)//integer overload
        {
            resultInt += numberInt;
        }
        static void Main(string[] args)
        {

            string inputStr = String.Empty;
            bool isNumber = true;


            Console.WriteLine("\nEnter number or string:");
            inputStr = Console.ReadLine();

            for (int i = 0; i < inputStr.Length; i++)//checking if input string is number
                if ((int)inputStr[i] > 57 || (int)inputStr[i] < 48)
                    isNumber = false;


            if (isNumber)
            {
                while (inputStr.Equals(""))//checking for right input
                {
                    Console.WriteLine("Wrong input, try again");
                    inputStr = Console.ReadLine();
                }
                    Add(int.Parse(inputStr));

                Console.WriteLine("Enter another number: ");
            }

            else if (!isNumber)
            {
                while (inputStr.Equals(""))//checking for right input
                {
                    Console.WriteLine("Wrong input, try again");
                    inputStr = Console.ReadLine();
                }
                Add(inputStr);
                Console.WriteLine("Enter another string: ");
            }

            else
                Console.WriteLine("ERROR, wrong input");

            inputStr = Console.ReadLine();
            while (!inputStr.Equals("END"))
            {


                if (isNumber)
                {
                    if (!inputStr.Equals(""))
                        Add(int.Parse(inputStr));
                    else
                        Console.WriteLine("Wrong input, try again");
                    Console.WriteLine("Result of adding numbers = " + resultInt + "\n\nEnter another number or \"END\" to stop");
                }

                else if (!isNumber)
                {
                    if (!inputStr.Equals(""))
                        Add(inputStr);
                    else
                        Console.WriteLine("Wrong input, try again");
                    Console.WriteLine("Result of combining strings : " + resultStr+"\n\nEnter another string or \"END\" to stop");
                }
                else
                    Console.WriteLine("ERROR, wrong input");//checking for right input

                inputStr = Console.ReadLine();
            }

        }
    }
}
