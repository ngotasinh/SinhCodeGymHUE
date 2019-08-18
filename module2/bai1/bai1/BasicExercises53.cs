using System;
using System.Collections.Generic;
using System.Text;

namespace bai1
{
    class BasicExercises53
    { static void Main()
        {
            int[] nums = { 2, 4, 7, 8, 6 };
            foreach (var n in nums)
            {
                Console.WriteLine(n % 2 != 0);
            }
        }
    }
}
