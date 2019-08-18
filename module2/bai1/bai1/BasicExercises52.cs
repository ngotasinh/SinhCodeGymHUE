using System;
using System.Collections.Generic;
using System.Text;

namespace bai1
{
    class BasicExercises52
    {
        static void Main()
        {
            int[] arr1 = { 1, 2, 3 };
            int[] arr2 = { 4, 5, 6 };
            int[] arr3 = { 7, 8, 9 };
            int[] result = { arr1[1], arr2[1], arr3[1] };
            Console.WriteLine("newArray: [{0}]", string.Join(",", result));
            Console.ReadKey();
        }
    }
}
