using System;
using System.Collections.Generic;
using System.Text;

namespace bai1
{
    class BasicExercises37
    {
        static void Main()
        {
            Console.WriteLine("input the string");
            string str = Console.ReadLine();
            Console.WriteLine(str.Substring(1, 2).Equals("HP") ? str.Remove(1, 2) : str);
        }
    }
}
