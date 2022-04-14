using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_222___226
{
   //Написати функцію, яка сортує масив розмірністю 10 елементів за зростанням або за спаданням,
   //в залежності від третього параметра функції.Якщо він дорівнює 1, сортування йде за спаданням, якщо 0, то по зростанню.
   //Перші 2 параметра функції - це масив і його розмір, третій параметр за замовчуванням дорівнює 1.

    class EX_226 :MyFunc
    {
        private void Sort(int[] massiv, int masLengt,int var)
        {
            switch(var)
            {
                case 1:
                    Array.Sort(massiv);
                    break;
                case 2:
                    Array.Sort(massiv);
                    Array.Reverse(massiv);
                    break;
            }

        }


        public void main()
        {
            int massivLength = 10, varOfSort;
            int[] massiv = new int[massivLength];
            Random rand = new Random();

            for(int i = 0; i < massiv.Length;i++)
            {
                massiv[i] = rand.Next(-5, 10);
            }
            Console.WriteLine("\tMy massiv:");
            foreach (var i in massiv)
            {
                Console.Write(i + ", ");
            }
            Console.WriteLine("\n\nPrint:\n1  -  to sort by rising\n2  -  to sort by falling");
            varOfSort = EnterInteger();

            Sort(massiv,massivLength,varOfSort);

            Console.WriteLine("\n\n\tSorted massiv:");
            foreach (var i in massiv)
            {
                Console.Write(i + ", ");
            }



            Console.ReadLine();
        }
    }
}
