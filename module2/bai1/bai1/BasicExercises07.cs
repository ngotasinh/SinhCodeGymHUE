using System;
using System.Collections.Generic;
using System.Text;

namespace bai1
{
    class BasicExercises7
    {
        static void Main()
        {
            int number1, number2;
            Console.WriteLine("input the first Number");
            number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("input the second Number");
            number2 = int.Parse(Console.ReadLine());

            Console.WriteLine("{0} + {1} = {2}", number1, number2, number1 + number2);
            Console.WriteLine("{0} - {1} = {2}", number1, number2, number1 - number2);
            Console.WriteLine("{0} x {1} = {2}", number1, number2, number1 * number2);
            Console.WriteLine("{0} : {1} = {2}", number1, number2, number1 / number2);
            Console.WriteLine("{0} mod {1} = {2}", number1, number2, number1 % number2);
        }
    }
}
