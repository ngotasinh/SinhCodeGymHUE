﻿using System;
using System.Collections.Generic;
using System.Text;

namespace bai1
{
    class BasicExercises17
    {
        static void Main()
        {
            string str;
            Console.Write("Input a string : ");
            str = Console.ReadLine();
            if (str.Length >= 1)
            {
                var s = str.Substring(0, 1);
                Console.WriteLine(s + str + s);
            }
        }
    }
}
