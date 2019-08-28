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
            //int[] Array = { 1, 5, 7, 3, 9, 1, 4 };

            //Console.WriteLine("Array da sap xep là: [{0}]", string.Join(",", NoiBot(Array)));

            // QuickSort.................
            int[] Array = { 1, 2, 7, 3, 9, 1, 4 };
            QuickSort(Array, 0, Array.Length-1);
            Console.WriteLine("Array da sap xep là: [{0}]", string.Join(",", Array));
            Console.Write("Nhap so can tim:  ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(TimKiemNhiPhan(Array, 0, Array.Length-1, n));

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
                for (int j = Arr.Length- 1; j > i ; j--)
                {
                    if (Arr[j] < Arr[j-1])
                    {
                        int temp = Arr[j];
                        Arr[j] = Arr[j - 1];
                        Arr[j - 1] = temp;
                    }
                }

            }
            return Arr;
        }
        public static void QuickSort(int[] Arr, int left, int right)
        {
            if(left >= right) return; 
            int pivot = Arr[(left+right)/2];
            int i = left; int j = right;
            do
            {
                while (Arr[i] < pivot) i++;
                while (Arr[j] > pivot) j--;
                if (i <= j)
                {
                    int temp = Arr[i];
                    Arr[i] = Arr[j];
                    Arr[j] = temp;
                    i++;
                    j--;
                }
            }
            while (j > i);
            QuickSort(Arr, left, j);
            QuickSort(Arr, i, right);
        }
        public static string TimKiemNhiPhan(int[] Arr, int left, int right, int value)
        {
            while(left <= right)
            {
                int mid = (left + right) / 2;
                if(Arr[mid] == value)
                {
                    return $"Tim thay gia tri {value} tai vi tri {mid}";
                }
                else
                {
                    if (Arr[mid] > value)
                    {
                        right = mid - 1;
                    }
                    else
                    {
                        left = mid + 1;
                    }
                }
            }
            return $"Khong tim thay";
        }
    }
}
