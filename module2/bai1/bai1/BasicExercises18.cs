using System;
using System.Collections.Generic;
using System.Text;

namespace bai1
{
    class BasicExercises18
    {
        static void Main()
        {
            Console.WriteLine("input the number1");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("input the number2");
            int number2 = int.Parse(Console.ReadLine());

            Console.WriteLine(number1 > 0 && number2 < 0 || number1 < 0 && number2 > 0);
        }
    }
}
