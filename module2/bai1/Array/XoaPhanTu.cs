using System;
using System.Collections.Generic;
using System.Text;

namespace BTmang
{
    public class XoaPhanTu
    {
        public static void Main()
        {
            int[] Array = { 1, 3, 5, 7, 9, 4, 5 };
            SortArray(Array, 0, Array.Length - 1);
            Console.WriteLine("Array da sap xep là: [{0}]", string.Join(",", Array));

            Console.WriteLine(Search(Array, 0, Array.Length, 9));
        }

        public static void SortArray(int[] Arr,int left, int right)
        {
            int pivot = Arr[(left + right) / 2];
            int i = left;
            int j = right;

            while(j > i)
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
            if (j > left) SortArray(Arr, left, j);
            if (right > i) SortArray(Arr, i, right);

        }
        public static string Search(int[] Arr, int left, int right, int value)
        {

            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (Arr[mid] == value)
                {
                    return $"{value} found in array at {mid}";
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
            return $"No {value} found in array";
        }

        public static void RemoveArray(int[] Arr, int index)
        {

        }
    }
}
