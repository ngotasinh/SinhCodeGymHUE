using System;
using System.Collections.Generic;
using System.Text;

namespace CauTrucDuLieuVaGiaiThuat1.SumArrayKhuDeQuy
{
    public class SumArray
    {
        public static void Main()
        {
            int[] B = { 1, 3, 5, 7, 3, 4, 8, 9, 6, 9 };
            Console.WriteLine("Sum of Array B is : {0}", Sum(B, B.Length));
        }
        public static  long Sum(int[] A, int n)
        {
            if(n == 0)
            {
                return 0;
            }
            else
            {
                return Sum(A, n - 1) + A[n - 1];
            }
        }
    }
}
