using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_222___226
{
    class MyFunc
    {
        public int EnterInteger()
        {

            string inputStr = Console.ReadLine();
            while (inputStr.Equals("") || inputStr[0] < 48 || inputStr[0] > 57)//checking for right input
            {
                Console.WriteLine("Wrong input number, try again");
                inputStr = Console.ReadLine();
            }
            return int.Parse(inputStr);
        }//Checking for inputing only intger number
    }
}
