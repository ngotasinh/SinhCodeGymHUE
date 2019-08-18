using System;
using System.Collections.Generic;
using System.Text;

namespace bai1
{
    class Ex7
    {
        static void Main()
        {
            Console.Write("Input upto the table number starting from 1 : ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Multiplication table from 1 to {0} \n", n);
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    Console.Write("{0}x{1} = {2}, ", j, i, i * j);
                }
                Console.Write("\n");
            }
            Console.ReadKey();
        }
    }
}
