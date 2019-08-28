using System;
using System.Collections.Generic;
using System.Text;

namespace BTCodeGym.ThuatToanCB
{
    public class DaoNguocCacPhanTutrongMang
    {
        public static int[] Array;
        public static int size;
        public static void Main()
        {
            CreateArray();
            PrintArray();
            Reverse();
            PrintArray();
        }


        public static void CreateArray()
        {           
            do
            {
                Console.Write("Enter the size of the array:  ");
                if (int.TryParse(Console.ReadLine(), out size))
                {
                    if (size > 20)
                    {
                        Console.WriteLine("Size does not exceed 20");
                    }
                }
            }
            while (size > 20);
            Array = new int[size];

            for (int i = 0; i < Array.Length; i++)
            {
                Console.Write("Enter the {0} element for the array:  ", i +1);
                Array[i] = int.Parse(Console.ReadLine());
            }
        }

        public static void PrintArray()
        {
            Console.WriteLine("Mang  : [{0}]", string.Join(",", Array));
        }
       
        public static void Reverse()
        {
            for (int i = 0; i < Array.Length /2 ; i++)
            {
                int temp = Array[i];
                Array[i] = Array[size - 1 - i];
                Array[size - 1 - i] = temp;
            }
        }
    }
}
