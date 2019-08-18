using System;
using System.Collections.Generic;
using System.Text;

namespace bai1
{
    class BasicExercises34
    {
        static void Main()
        {
            Console.Write("Input a sentence :");
            string input = Console.ReadLine();

            Console.Write("Insert word to check :");
            string word = Console.ReadLine();

            string lowerinput = input.ToLower();

            lowerinput.StartsWith(word.ToLower());
        }
    }
}
