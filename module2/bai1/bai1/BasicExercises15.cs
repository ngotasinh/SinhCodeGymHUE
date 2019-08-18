using System;
using System.Collections.Generic;
using System.Text;

namespace bai1
{
    class BasicExexrcises15
    {
        static void Main()
        {
            Console.WriteLine("input the string:");
            string str = Console.ReadLine();
            Console.WriteLine("input the index:");
            int index = int.Parse(Console.ReadLine());
            string result = string.Empty;
            for(int i=0; i< str.Length; i++)
            {
                if( i != index)
                {
                    result += str[i];
                }
            }
            /*Console.WriteLine(str.Remove(index,1));*/
        }
    }
}
