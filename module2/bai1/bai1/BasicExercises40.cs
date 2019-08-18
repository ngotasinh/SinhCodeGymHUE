using System;
using System.Collections.Generic;
using System.Text;

namespace bai1
{
    class BasicExercises40
    {
        static void Main()
        {
            Console.WriteLine("input the number1");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("input the number2");
            int number2 = int.Parse(Console.ReadLine());
            Console.WriteLine("input the number3");

            int result1 = Math.Abs(number1 - 20);
            int result2 = Math.Abs(number2 - 20);
            Console.WriteLine(result1 > result2 ? number2 : number1);
            Console.ReadKey();
        }
    }
}
