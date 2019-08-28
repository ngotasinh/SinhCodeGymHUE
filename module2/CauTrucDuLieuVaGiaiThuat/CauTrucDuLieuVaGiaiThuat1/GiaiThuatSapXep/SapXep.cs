using System;
using System.Collections.Generic;
using System.Text;

namespace CauTrucDuLieuVaGiaiThuat1.GiaiThuatSapXep
{
    public class SapXep
    {
        public static void Main()
        {
            // Sắp xếp chọn:

            //int[] Array = { 2, 5, 4, 7, 8, 2, 9, 6, 4, 5, 8, 1, 2 };
            //Console.WriteLine("Array ban dau: [{0}]", string.Join(",", Array));
            //SapXepChon(Array);
            //Console.WriteLine("Array sau khi sap xep: [{0}]", string.Join(",", Array));

            // sắp xếp chèn:
            //int[] Array = { 1, 5, 7, 3, 9, 1, 4 };

            //Console.WriteLine("Array da sap xep là: [{0}]", string.Join(",", SapXepChen(Array)));

            //  NỔI BỌT;
            int[] Array = { 1, 5, 7, 3, 9, 1, 4 };

            Console.WriteLine("Array da sap xep là: [{0}]", string.Join(",", NoiBot(Array)));

        }
        
        public static void SapXepChon(int[] A)
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

        public static int[] SapXepChen(int[] Arr)
        {
            int value, index;
            for (int i = 1; i < Arr.Length; i++)
            {
                value = Arr[i];
                index = i - 1;
                while ((index >= 0) && (Arr[index] > value))
                {
                    Arr[index + 1] = Arr[index];
                    index--;
                }
                Arr[index + 1] = value;
            }
            return Arr;
        }
        public static int[] NoiBot(int[] Arr)
        {
            for (int i = 0; i < Arr.Length - 1; i++)
            {
                for (int j = 0; j < Arr.Length -1 -i ; j++)
                {
                    if (Arr[j] > Arr[j + 1])
                    {
                        int temp = Arr[j];
                        Arr[j] = Arr[j + 1];
                        Arr[j + 1] = temp;
                    }
                }

            }
            return Arr;
        }
    }
}
