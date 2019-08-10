using System;
using System.Collections.Generic;
using System.Text;

namespace bai1
{
    class BasicExercises9
    {
        static void Main()
        {
            double number1, number2, number3, number4;
            Console.WriteLine("input the first number");
            number1 = double.Parse(Console.ReadLine());
            Console.WriteLine("input the second number");
            number2 = double.Parse(Console.ReadLine());
            Console.WriteLine("input the third number");
            number3 = double.Parse(Console.ReadLine());
            Console.WriteLine("input the four number");
            number4 = double.Parse(Console.ReadLine());

            double result = (number1 + number2 + number3 + number4) / 4;
            Console.WriteLine("The average of: {0},{1},{2},{3} is {4}", number1, number2, number3, number4, result);
        }
    }
}
