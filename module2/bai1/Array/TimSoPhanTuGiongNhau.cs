using System;
using System.Collections.Generic;
using System.Text;

namespace BTmang
{
    class TimSoLonNhatTrongMang
    {
        static void Main()
        {
            Console.Write("Enter the element number of the array: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr1 = new int[n];
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                Console.Write("Phan tu - {0}: ", i);
                arr1[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (arr1[i] == arr1[j])
                    {
                        count++;
                    }
                }
            }

            Console.Write("So phan tu giong nhau trong mang la: {0}", count);

            Console.ReadKey();
        }
    }
}
