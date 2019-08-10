using System;
using System.Collections.Generic;
using System.Text;

namespace bai1
{
    class BasicExercises19
    {
        static void Main()
        {
            Console.WriteLine("input the number1");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("input the number2");
            int number2 = Convert.ToInt32(Console.ReadLine());

            if (number1 == number2)
            {
                Console.WriteLine("({0} + {1}).3 = {2}", number1, number2, (number1 + number2) * 3);
            }
            else
                Console.WriteLine("{0} + {1} = {2}", number1, number2, number1 + number2);
        }
    }
}
