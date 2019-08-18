using System;
using System.Collections.Generic;
using System.Text;

namespace bai1
{
    class BasicExercises54
    {
        static void Main()
        {
            Console.WriteLine("input a year");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} in the century: {1}", year, (int)(year / 100));
        }
    }
}
