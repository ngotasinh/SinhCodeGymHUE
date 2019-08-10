using System;
using System.Collections.Generic;
using System.Text;

namespace bai1
{
    class BasicExercises21
    {
        static void Main()
        {
            int x, y;

            Console.WriteLine("Input an integer:");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input another integer:");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(x == 20 || y == 20 || (x + y == 20));
        }
    }

}
