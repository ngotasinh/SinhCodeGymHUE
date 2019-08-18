using System;
using System.Collections.Generic;
using System.Text;

namespace bai1
{
    class BasicExercises33
    {
        static void Main()
        {
            Console.WriteLine("input the number");
            int number = int.Parse(Console.ReadLine());
            if(number>0)
            {
                Console.WriteLine(number % 3 == 0 || number % 7 == 0);
            }
            Console.ReadKey();
        }
    }
}
