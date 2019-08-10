using System;
using System.Collections.Generic;
using System.Text;

namespace bai1
{
    class BasicExercises22
    {
        static void Main()
        {
            Console.WriteLine("\nInput an integer:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(result(x));
        }

        static bool result(int n)
        {
            if (Math.Abs(n - 100) <= 20 || Math.Abs(n - 200) <= 20)
                return true;
                return false;
        }
    }
}
