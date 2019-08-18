using System;
using System.Collections.Generic;
using System.Text;

namespace bai1
{
    class BasicExrcises28
    {
        static void Main()
        {
            string word = "Display the pattern like pyramid using the alphabet";
            var allwords = word.Split(' ');

            for (int i = allwords.Length - 1; i >= 0; i--)
            {
                Console.Write(allwords[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
