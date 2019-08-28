using System;
using System.Collections.Generic;
using System.Text;

namespace CauTrucDuLieuVaGiaiThuat1.SapXepChon1
{
    public class TangDan
    {
        public static void Main()
        {
            int[] Array = { 2, 5, 4, 7, 8, 2, 9, 6, 4, 5, 8, 1, 2 };
            Console.WriteLine("Array ban dau: [{0}]", string.Join(",", Array));
            SelectionSort(Array);
            Console.WriteLine("Array sau khi sap xep: [{0}]", string.Join(",", Array));
        }
        public static void SelectionSort(int[] A)
        {
            for (int i = 0; i < A.Length - 1; i++)
            {
                var min = A[i];
                var pos = i;
                for (int j = i + 1; j < A.Length; j++)
                {
                    if (A[j] < min)
                    {
                        min = A[j];
                        pos = j;
                    }
                }
                var temp = A[i];
                A[i] = A[pos];
                A[pos] = temp;
            }
        }
    }
}
