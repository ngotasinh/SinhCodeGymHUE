using System;
using System.Collections.Generic;
using System.Text;

namespace bai1
{
    class BasicExercises8
    {
        static void Main()
        {
            Console.WriteLine("input the number");
            int number = int.Parse(Console.ReadLine());

            for(int i=0; i<=10; i++)
            {
                Console.WriteLine("{0} x {1} = {2}", number, i, 5 * i);
            }
        }
    }
}
