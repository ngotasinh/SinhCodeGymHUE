using System;
using System.Collections.Generic;
using System.Text;

namespace bai1
{
    class BasicExercises28
    {
        static void Main()
        {
            int[] array1 = { 1, 3, -5, 4 };
            int[] array2 = { 1, 4, -5, -2 };
            for(int i=0; i < array1.Length; i++)
            {
                Console.Write(array1[i] * array2[i] + " ");
                Console.ReadKey();
            }
        }
    }
}
