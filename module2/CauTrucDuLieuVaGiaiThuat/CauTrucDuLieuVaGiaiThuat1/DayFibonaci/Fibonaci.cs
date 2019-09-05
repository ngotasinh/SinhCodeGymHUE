using System;
using System.Collections.Generic;
using System.Text;

namespace CauTrucDuLieuVaGiaiThuat1.DayFibonaci
{
    public class Fibonaci
    {
        public static void Main()
        {
            Console.Write("Nhap n :");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Tong cua day so fibonaci la: {0}", SumFibonaci(n));

        }
        public static int SumFibonaci(int n)
        {
            if (n == 0 || n == 1)
            {
                return n;
            }
            else
            {
                n = (SumFibonaci(n - 1) + SumFibonaci(n - 2));
                return n;
            }
        }
    }
}
