using System;
using System.Collections.Generic;
using System.Text;

namespace BTmang
{
    class TimPhanTuDuyNhat
    {
        static void Main()
        {
            int n, ctr = 0;
            int i, j, k;
            Console.Write("Input the number of elements to be stored in the array :");
            n = Convert.ToInt32(Console.ReadLine());
            int[] arr1 = new int[n];

            Console.Write("Input {0} elements in the array :\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("\nThe unique elements found in the array are : \n");
            for (i = 0; i < n; i++)
            {
                ctr = 0;
                for (j = 0; j < i ; j++)
                {
                    if (arr1[i] == arr1[j])
                    {
                        ctr++;
                    }
                }
                for (k = i + 1; k < n; k++)
                {
                    if (arr1[i] == arr1[k])
                    {
                        ctr++;
                    }
                }
                if (ctr == 0)
                {
                    Console.Write("{0} ", arr1[i]);
                }
            }
            Console.ReadKey();
        }
    }
}
