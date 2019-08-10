using System;
using System.Collections.Generic;
using System.Text;

namespace bai1
{
    class tess
    {
        static void Main()
        {
           
            int[] arr = new[] { 2, 5, 9, 10 };
            int max = arr[0];

            for (int i=1; i<arr.Length; i++)
            {
                
                if (arr[i]>max)
                {
                    max = arr[i];
                }
            }
            Console.WriteLine(max);

            int tam;
            int first = 0;
            int last = arr.Length - 1;
            for(int i=0; i< last; i++)
            {
                tam = arr[first];
                arr[first] = arr[last];
                arr[last] = tam;
            }

            foreach(int item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
