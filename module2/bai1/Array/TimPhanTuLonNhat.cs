using System;
using System.Collections.Generic;
using System.Text;

namespace BTmang
{
    public class TimPhanTuLonNhat
    {
        public static void Main()
        {
            int[,] Array =
            {
                {1,2,3,4,5 },
                {4,5,6,7,8 }
            };
            Console.WriteLine("Gia tri lon nhat của mang la: {0}",MaxArray(Array));
        }
        public static int MaxArray(int[,] Arr)
        {
            int max = Arr[0,0];
            for (int i = 0; i < Arr.GetLength(0); i++)
            {
                for (int j = 0; j < Arr.GetLength(1); j++)
                {
                    if(Arr[i,j] > max)
                    {
                        max = Arr[i, j];
                    }
                }
            }
            return max;
        }
    }
}
