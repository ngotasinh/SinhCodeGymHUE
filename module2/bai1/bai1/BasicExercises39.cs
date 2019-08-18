using System;
using System.Collections.Generic;
using System.Text;

namespace bai1
{
    class BasicExercises39
    {
        static void Main()
        {
            Console.WriteLine("input the number1");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("input the number2");
            int number2 = int.Parse(Console.ReadLine());
            Console.WriteLine("input the number3");
            int number3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Largest of three:" + max(number1, number2, number3));
            Console.WriteLine("Lowest of three:" + min(number1, number2, number3));
            Console.ReadKey();
        }
        static int max(int a, int b, int c)
        {
            if(a > b && a > c)
            {
                return a;
            }
            if (b > a && b > c)
            {
                return b;
            }
            return c;
        }

        static int min(int a, int b, int c)
        {
            if (a < b && a < c)
            {
                return a;
            }
            if (b < a && b < c)
            {
                return b;
            }
            return c;
        }
    }
}
