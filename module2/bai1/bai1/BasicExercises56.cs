﻿using System;
using System.Collections.Generic;
using System.Text;

namespace bai1
{
    class BasicExercises56
    {
        public static bool checkPalindrome(string inputString)
        {
            char[] c = inputString.ToCharArray();
            Array.Reverse(c);
            return new string(c).Equals(inputString);
        }
        public static void Main()
        {
            Console.WriteLine(checkPalindrome("aaa"));
            Console.WriteLine(checkPalindrome("abc"));
            Console.WriteLine(checkPalindrome("madam"));
            Console.WriteLine(checkPalindrome("1234"));

        }
    }
}
