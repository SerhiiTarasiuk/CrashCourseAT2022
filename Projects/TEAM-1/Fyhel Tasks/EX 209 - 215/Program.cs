using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_209___215
{
    class Program
    {
        //1. Розробити програму, яка виводить на екран горизонтальну лінію з символів. Кількість символів, який використовувати символ, і яка буде лінія - вертикальна, або горизонтальна - вказує користувач.
        static void EX_209()
        {
            char symbol = ' ';
            string inputStr=" ";
            int lengthOfLine, varriantOfLine;

            Console.WriteLine("\nEnter symbol for making line:");
            inputStr = Console.ReadLine();
            while(inputStr.Equals(null))//checking for right input
            {
                Console.WriteLine("\nWrong line, try again:");
                inputStr = Console.ReadLine();
            }
            symbol = inputStr[0];


            Console.WriteLine("\nEnter length of line:");
            lengthOfLine = int.Parse(Console.ReadLine());
            while (lengthOfLine == 0)//checking for right input
            {
                Console.WriteLine("\nWrong line length, try again:");
                lengthOfLine = int.Parse(Console.ReadLine());
            }
            
            Console.WriteLine("\nEnter \n\n1 for gorizontal line or \n\n2 for vertical line or \n\n3 for diagonal line:");
            varriantOfLine = int.Parse(Console.ReadLine());
            while (varriantOfLine!=1 && varriantOfLine != 2 && varriantOfLine != 3)//checking for right input
            {
                Console.WriteLine("\nWrong line varriant, try again:");
                varriantOfLine = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\n");


            switch (varriantOfLine)
            {
            case 1:
                    for (int i = 0; i < lengthOfLine; i++)//gorizontal
                        Console.Write(symbol);
                break;

            case 2:
                    for (int i = 0; i < lengthOfLine; i++)//vertical
                        Console.WriteLine(symbol);
                break;

             case 3:
                    for (int i = 0; i < lengthOfLine; i++)//diagonal 
                    {
                        for (int j = 0; j < i; j++)
                            Console.Write(" ");
                        Console.WriteLine(symbol);
                    }
                break;

            default:
                    Console.WriteLine("ERROR");
                break;
            }


            Console.ReadLine();
        }

        //4. Користувач вводить з клавіатури число - програма повинна показати скільки в даному числі цифр. Число вводиться повністю в одну змінну. Примітка: Наприклад, користувач ввів число 11123445555.На екрані має з'явитися повідомлення про те, що в числі 5 цифр."
        static void EX_212()
        {
            string numberInputStr = String.Empty;
            List<int> numbersList = new List<int>();

            Console.WriteLine("\nEnter number:");
            numberInputStr = Console.ReadLine();
            while (numberInputStr.Equals(null))//checking for right input
            {
                Console.WriteLine("\nWrong number, try again:");
                numberInputStr = Console.ReadLine();
            }

            for(int i = 0; i< numberInputStr.Length;i++)//adding symbols to list
            {
                if(numberInputStr[i]<48|| numberInputStr[i]>57)
                {
                    Console.WriteLine("Error, letter in number!!!");
                    break;
                }
                numbersList.Add((int)numberInputStr[i] - 48);
            }

            numbersList = numbersList.Distinct().ToList();//calculating

            Console.WriteLine("\n\nThere are :" + numbersList.Count() + " unique numbers in " + numberInputStr + " .");
            Console.ReadLine();

        }

        //5. Користувач вводить з клавіатури число, необхідно перевернути його (число) і вивести на екран.Примітка: Наприклад, користувач ввів число 12345.На екрані має з'явитися число навпаки - 54321."
        static void EX_213()
        {
            string numberInputStr = String.Empty, numberReverseStr = String.Empty;
            bool isNumber=true;

            Console.WriteLine("\nEnter number:");
            numberInputStr = Console.ReadLine();

            for (int i = 0; i < numberInputStr.Length; i++)//checking if input string is number
                if ((int)numberInputStr[i] > 57 || (int)numberInputStr[i] < 48)
                    isNumber = false;

            while (numberInputStr.Equals(null)|| isNumber == false)//checking for right input
            {
                isNumber = true;
                Console.WriteLine("\nERROR "+ numberInputStr+" is not a number, try again:");
                numberInputStr = Console.ReadLine();

                for (int i = 0; i < numberInputStr.Length; i++)//checking if input string is number again
                    if ((int)numberInputStr[i] > 57 || (int)numberInputStr[i] < 48)
                        isNumber = false;
            }


            for (int i = numberInputStr.Length - 1; i >= 0; i--)//reversing
                numberReverseStr += numberInputStr[i];

            Console.WriteLine("Forvard - " + numberInputStr+"\n\nReverse - "+ numberReverseStr);

            Console.ReadLine();

        }

        //6. Користувач вводить з клавіатури число, необхідно показати на екран суму його цифр.Примітка: Наприклад, користувач ввів число 12345.На екрані має з'явитися повідомлення про те, що сума цифр числа 15."
        static void EX_214()
        {
            string numberInputStr = String.Empty, numberReverseStr = String.Empty;
            bool isNumber = true;
            int sumOfsymbols=0;

            Console.WriteLine("\nEnter number:");
            numberInputStr = Console.ReadLine();

            for (int i = 0; i < numberInputStr.Length; i++)//checking if input string is number
                if ((int)numberInputStr[i] > 57 || (int)numberInputStr[i] < 48)
                    isNumber = false;

            while (numberInputStr.Equals(null) || isNumber == false)//checking for right input
            {
                isNumber = true;
                Console.WriteLine("\nERROR, " + numberInputStr + " is not a number, try again:");
                numberInputStr = Console.ReadLine();

                for (int i = 0; i < numberInputStr.Length; i++)//checking if input string is number again
                    if ((int)numberInputStr[i] > 57 || (int)numberInputStr[i] < 48)
                        isNumber = false;
            }

            for (int i = 0; i < numberInputStr.Length; i++)//calculating
                sumOfsymbols += (int)numberInputStr[i] - 48;


            Console.WriteLine("\nThe sum of symbols in " + numberInputStr + " is " + sumOfsymbols);

            Console.ReadLine();
        }

        //7. Написати програму, яка виводить на екран - наступну фігуру:ширина і висота фігури встановлюються користувачем з клавіатури.
        static void EX_215()
        {
            string inputStr = String.Empty;
            int lengthOfLine = 0, heightOfLine=0;

            Console.WriteLine("\nEnter height of line:");
            inputStr = Console.ReadLine();
            while (inputStr.Equals(null) || inputStr.Equals("0"))//checking for right input height
            {
                Console.WriteLine("\nWrong height, try again:");
                inputStr = Console.ReadLine();
            }
            heightOfLine = int.Parse(inputStr);

            Console.WriteLine("\nEnter length of line:");
            inputStr = Console.ReadLine();
            while (inputStr.Equals(null) || inputStr.Equals("0"))//checking for right input length
            {
                Console.WriteLine("\nWrong length, try again:");
                inputStr = Console.ReadLine();
            }
            lengthOfLine = int.Parse(inputStr);

            Console.Write("\n\n");
            for (int l = 0; l < lengthOfLine; l++)
                Console.Write("*");
            Console.Write("\n");
            for (int h = 0; h < heightOfLine - 2; h++)
            {
                Console.Write("*");
                if (lengthOfLine != 1)
                {
                    for (int l = 0; l < lengthOfLine - 2; l++)
                        Console.Write(" ");
                    Console.Write("*");
                }
                Console.Write("\n");
            }
            if (heightOfLine!=1)
                for (int l = 0; l < lengthOfLine; l++)
                    Console.Write("*");


            Console.ReadLine();

        }
            static void Main(string[] args)
        {
            //EX_209();//1. Розробити програму, яка виводить на екран горизонтальну лінію з символів. Кількість символів, який використовувати символ, і яка буде лінія - вертикальна, або горизонтальна - вказує користувач.
            //EX_212();//4. Користувач вводить з клавіатури число - програма повинна показати скільки в даному числі цифр. Число вводиться повністю в одну змінну. Примітка: Наприклад, користувач ввів число 11123445555.На екрані має з'явитися повідомлення про те, що в числі 5 цифр."
            //EX_213();//5. Користувач вводить з клавіатури число, необхідно перевернути його (число) і вивести на екран.Примітка: Наприклад, користувач ввів число 12345.На екрані має з'явитися число навпаки - 54321."
            //EX_214();//6. Користувач вводить з клавіатури число, необхідно показати на екран суму його цифр.Примітка: Наприклад, користувач ввів число 12345.На екрані має з'явитися повідомлення про те, що сума цифр числа 15."
            //EX_215();//7. Написати програму, яка виводить на екран - наступну фігуру:ширина і висота фігури встановлюються користувачем з клавіатури."
           /*
            
            *********************
            *                   *
            *                   *
            *                   *
            *                   *
            *********************
           
            */

        }
    }
}
