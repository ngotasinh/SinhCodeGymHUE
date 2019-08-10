using System;
using System.Collections.Generic;
using System.Text;

namespace bai1
{
    class BasicExercises20
    {
        static void Main()
        {
            Console.WriteLine(result(2, 3));
            Console.WriteLine(result(4, 3));
        }
        static int result(int a, int b)
        {
            if (a > b)
            {
                return (a - b) * 2;
            }
            else return b - a;
        }

    }
}
