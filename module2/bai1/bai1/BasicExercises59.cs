using System;
using System.Collections.Generic;
using System.Text;

namespace bai1
{
    class BasicExercises59
    {
        public static bool test_Increasing_Sequence(int[] Array)
        {
            for (int i = 0; i < Array.Length - 1; i++)
            {
                if (Array[i + 1] - Array[i] <= 0) return false;
            }
            return true;
        }

        public static void Main()
        {
            Console.WriteLine(test_Increasing_Sequence(new int[] { 1, 3, 5, 6, 9 }));
            Console.WriteLine(test_Increasing_Sequence(new int[] { 0, 10 }));
            Console.WriteLine(test_Increasing_Sequence(new int[] { 1, 3, 1, 3 }));
        }
    }
}
