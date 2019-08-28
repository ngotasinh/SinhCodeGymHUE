using System;
using System.Collections.Generic;
using System.Text;

namespace BTCodeGym.ThuatToanCB
{
    public class Timgiatrilonnhat
    {
        public static void Main()
        {
            int[] Array = new int[5];
            CreateArray(Array);
            MaxArray(Array);

        }

        public static void CreateArray(int[] Arr)
        {
            for (int i = 0; i < Arr.Length; i++)
            {
                Console.Write("Enter the {0} element for the array:  ", i + 1);
                Arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Array: [{0}]", string.Join(",",Arr));
        }

        public static void MaxArray(int[] Arr)
        {
            int Max = Arr[0];
            for (int i = 0; i < Arr.Length; i++)
            {
                if(Arr[i]> Max)
                {
                    Max = Arr[i];
                }
            }
            Console.WriteLine("Max of Array: {0}", Max);
        }
    }
}
