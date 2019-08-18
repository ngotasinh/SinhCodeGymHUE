using System;

namespace bai1
{
    class BasicExercises58
    {
        public static int consecutive_array(int[] Array)
        {
            System.Array.Sort(Array);
            int count = 0;
            for (int i = 0; i < Array.Length - 1; i++)
            {
                count += Array[i + 1] - Array[i] - 1;
            }
            return count;
        }

        public static void Main()
        {
            Console.WriteLine(consecutive_array(new int[] { 1, 3, 5, 6, 9 }));
            Console.WriteLine(consecutive_array(new int[] { 0, 10 }));
        }
    }
}
