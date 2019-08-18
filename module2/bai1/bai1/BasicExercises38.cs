using System;
using System.Collections.Generic;
using System.Text;

namespace bai1
{
    class BasicExercises38
    {
        static void Main()
        {
            Console.WriteLine("input the string(: ");
            var input = Console.ReadLine();

            string two = input.Substring(0, 2);

            Console.WriteLine((string.Equals(two, "ph", StringComparison.OrdinalIgnoreCase)) ? two : input);
        }
    }
}
