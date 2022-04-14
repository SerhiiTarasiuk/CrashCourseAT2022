using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_222___226
{
    class EX_224
    {//Дано масив випадкових чисел в діапазоні від -20 до +20.
     //Необхідно знайти позиції крайніх негативних елементів (самого лівого негативного елементу і самого правого негативного елементу)
     //і впорядкувати елементи, що знаходяться між ними.

        public void main()
        {
            Random rand = new Random();
       
            int massivLength = 15;
            int negativeLeftPos=-1, negativeRightPos=-1;
            int[] massivInt = new int[massivLength];
            int[] massivForSort;

            for (int i = 0; i < massivInt.Length;i++)
            { 
                massivInt[i] = rand.Next(-20, 20);
                Console.Write(massivInt[i] + ", ");
            }

            for (int i = 0; i < massivInt.Length; i++)
            {
                if(massivInt[i]<0 && negativeLeftPos<0)
                    negativeLeftPos = i+1;

                if (massivInt[massivInt.Length-i-1] < 0 && negativeRightPos < 0)
                    negativeRightPos = massivInt.Length - i -1;
            }

            massivForSort = new int[negativeRightPos - negativeLeftPos];

            for (int i = negativeLeftPos; i < negativeRightPos;i++)
            {
                massivForSort[i- negativeLeftPos] = massivInt[i];
            }

            Array.Sort(massivForSort);

            Console.Write($"\n\nFirst negative element: {massivInt[negativeLeftPos-1]} , last negative element: {massivInt[negativeRightPos]} \n\n Sorted massiv :\n\n");
            for (int i = negativeLeftPos; i < negativeRightPos; i++)
            {
                massivInt[i] = massivForSort[i - negativeLeftPos];
            }

            foreach (var i in massivInt)
                Console.Write(i + ", ");
            Console.ReadLine();
        }
    }
}
