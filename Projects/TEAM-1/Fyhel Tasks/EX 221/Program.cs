using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_221
{
    class Program
    {
        static string textInStr = "abcbcdedefg hijklmnop";
        static string RemoveFromString(int serialNumToRemove )
        {
            string textOutStr = "";
            if (serialNumToRemove > 0 && serialNumToRemove <=textInStr.Length)
            {
                for (int i = 0; i < textInStr.Length; i++)
                {
                    if (i!= serialNumToRemove-1)
                        textOutStr += textInStr[i];
                }
                return textOutStr;
            }
            else
            {
                Console.WriteLine("There is no coincidence in the text");
                return textInStr;
            }
        }

        static string RemoveFromString(string symbolsForRemoving )
        {
            string textOutStr = "";
            bool isAbleToRemove = false;
            int counterForRemoveStr = 0, saveEndOfSerial=0 ;
            for (int i = 0; i < textInStr.Length; i++)
            {
                if (textInStr[i].Equals(symbolsForRemoving[counterForRemoveStr]))//checking for coincidence
                {

                    if (counterForRemoveStr == symbolsForRemoving.Length - 1)
                    {
                        isAbleToRemove = true;
                        saveEndOfSerial = i;
                        break;
                    }
                    counterForRemoveStr++;
                }
                else//if symbol not equal to appropriate symbol
                {
                    if (counterForRemoveStr != 0)
                        i--;

                    counterForRemoveStr = 0;
                }
            }

            if (isAbleToRemove)
            {
                for (int i = 0; i < textInStr.Length; i++)
                {
                    if (i <= saveEndOfSerial - symbolsForRemoving.Length || i > saveEndOfSerial)
                        textOutStr += textInStr[i];
                }
                return textOutStr;
            }
            else 
            {
                Console.WriteLine("There is no coincidence in the text");
                return textInStr;
            }
    }


    static void Main(string[] args)
        {
            //Написати overload методи RemoveFromString, які приймають текст і видаляють з нього або певний набір символів, або символ\символи за порядковим номером в тексті. Реалізувати використання аргументів за замовчуванням та глобальних\локальних змінних
         
            int varriantOfRemoving=0, serialNumToRemove = -1;
            string  inputStr;
            
            Console.WriteLine(textInStr+ "\n\nPrint: \n\n1 : to remove group of symbols\n2 : to remove one symbol by serial number ");//choose varriant
            inputStr = Console.ReadLine();

            while ( inputStr.Equals("") || inputStr[0] < 48 || inputStr[0] > 57)//checking for right input
            {
                Console.WriteLine("Wrong inpyt, try again");
                inputStr = Console.ReadLine();
            }
            varriantOfRemoving = int.Parse(inputStr);


            if (varriantOfRemoving == 1)//group of symbol
            {
                Console.WriteLine("Enter group of symbols to remove");
                inputStr = Console.ReadLine();

                while (inputStr.Equals(""))//checking for right input
                {
                    Console.WriteLine("Wrong inpyt string, try again");
                    inputStr = Console.ReadLine();
                }

                textInStr = RemoveFromString(inputStr);
                Console.WriteLine("\n\nNew text:\n" + textInStr);
            }
            else if (varriantOfRemoving == 2)//one symbol
            {
                Console.WriteLine("Enter serial number of symbol to remove");

                inputStr = Console.ReadLine();
                while (inputStr.Equals("") || inputStr[0] < 48 || inputStr[0] > 57)//checking for right input
                {
                    Console.WriteLine("Wrong inpyt number, try again");
                    inputStr = Console.ReadLine();
                }
                serialNumToRemove = int.Parse(inputStr);

                textInStr = RemoveFromString(serialNumToRemove);
                Console.WriteLine("\n\nNew text:\n" + textInStr);
            }
            else
                Console.WriteLine("Wrong varriant. Bue-bue");
            Console.ReadLine();
        }
    }
}
