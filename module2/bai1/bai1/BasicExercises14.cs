using System;
using System.Collections.Generic;
using System.Text;

namespace bai1
{
    class BasicExercises14
    {
        static void Main()
        {
            int number;
            Console.WriteLine("input the amount of celsius:");
            number = int.Parse(Console.ReadLine());

            Console.WriteLine("Kelvin = {0}", number + 273);
            Console.WriteLine("Fahrenheit = {0}", number * 1.8 + 32);

        }
    }
}
