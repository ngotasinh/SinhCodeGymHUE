using System;
using System.Collections.Generic;
using System.Text;

namespace bai1
{
    class BasicExercises24
    {
        static void Main()
        {
            string str = "Write a C# Sharp Program to    display  the following pattern using the alphabet.";
            string[] arrSTR = str.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            string element = "";
            int ctr = 0;
            foreach (String Element in arrSTR)
            {
                if (Element.Length > ctr)
                {
                    element = Element;
                    ctr = Element.Length;
                    Console.WriteLine(element);
                }
            }

            Console.WriteLine(element);
            Console.ReadKey();
        }
    }
}
