using System;
using System.Collections.Generic;
using System.Text;

namespace CauTrucDuLieuVaGiaiThuat1.GiaiThua
{
    public class GaiThua
    {
        public static void Main()
        {
            Console.Write("Input n =  ");
            var n = int.Parse(Console.ReadLine());

            Console.WriteLine("{0}! = {1}", n, TinhGiaiThua(n));
        }

        public static long TinhGiaiThua(int n)
        {
            if( n == 0 || n == 1)
            {
                return 1;
            }
            else
            {
                return n * TinhGiaiThua(n - 1); 
            }
        }
    }
}
