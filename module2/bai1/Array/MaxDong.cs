using System;
using System.Collections.Generic;
using System.Text;

namespace BTmang
{
    class MaxDong
    {
        static void KhoiTaoMang(int[,] a)
        {
            Random rand = new Random();
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i,j] = rand.Next(0, 70);
                }

            }

        }
        static void XuatMang(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                Console.WriteLine();
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write("{0, 4}",a[i,j]);
                }

            }
            Console.WriteLine();
        }
        static void Max(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                int max = a[i,0];
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    max = a[i, j] > max ? a[i, j] : max;
                }
                Console.WriteLine("Max dong {0} là: {1}", i, max);

            }
        }
        static void Main()
        {
            int[,] a = new int[10,10];
            KhoiTaoMang(a);
            XuatMang(a);
            Max(a);
        }

    }
}
