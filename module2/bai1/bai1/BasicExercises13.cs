using System;
using System.Collections.Generic;
using System.Text;

namespace bai1
{
    class BasicExercises13
    {
        static void Main()
        {
            int number;
            Console.WriteLine("input the number");
            number = int.Parse(Console.ReadLine());

            Console.WriteLine("{0}{0}{0}", number);
            Console.WriteLine("{0} {0}", number);
            Console.WriteLine("{0} {0}", number);
            Console.WriteLine("{0} {0}", number);
            Console.WriteLine("{0}{0}{0}", number);
        }
    }
}
