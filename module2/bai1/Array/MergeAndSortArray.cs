using System;
using System.Collections.Generic;
using System.Text;

namespace BTmang
{
    class MergeAndSortArray
    {
        static void Main()
        {
            Console.Write("Enter the array element number 1: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the array element number 2: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            int[] Array1 = new int[number1];
            int[] Array2 = new int[number2];
            int[] NewArray = new int[number1 + number2];
            for (int i = 0; i < Array1.Length; i++)
            {
                Console.WriteLine("enter element {0}", i);
                Array1[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int j = 0; j < Array2.Length; j++)
            {
                Console.WriteLine("enter element {0}", j);
                Array2[j] = Convert.ToInt32(Console.ReadLine());
            }
            Array1.CopyTo(NewArray, 0);
            Array2.CopyTo(NewArray, Array1.Length);
            Array.Sort(NewArray);
            foreach (var i in NewArray)
            {
                Console.Write(i);
            }
        }
    }
}
