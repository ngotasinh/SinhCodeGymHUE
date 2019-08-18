using System;
using System.Collections.Generic;
using System.Text;

namespace bai1
{
    class BasicExercises41
    {
        static void Main()
        {
            Console.WriteLine("input the string");
            string str = Console.ReadLine();
            for( int i=1; i<4; i++)
            {
                if (str[i] =='w')
                {
                    Console.WriteLine("true");
                }
            }
        }
    }
}
