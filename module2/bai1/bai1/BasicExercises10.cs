using System;
using System.Collections.Generic;
using System.Text;

namespace bai1
{
    class BasicExercises10
    {
        static void Main()
        {
            int number1, number2, number3;
            Console.WriteLine("input the first number");
            number1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("input the second number ");
            number2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("input the third number");
            number3 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Result of specified numbers: {0},{1} and {2}, (x + y).z is {3} and x.y + y.z is {4} ", 
                number1, number2, number3, (number1 + number2) * number3, number1*number2 + number2*number3);
            Console.ReadKey();

        }
    }
}
