using System;
using System.Collections.Generic;
using System.Text;

namespace BaiThiModule2.Bai1
{
    public class Cau1
    {
        static int[,] Array;
        static int n, m;
        static int[] SumArray;
        public static void Main()
        {
            Console.Write("Nhap vao so nguyen duong n:  ");
            n = int.Parse(Console.ReadLine());
            Console.Write("Nhap vao so nguyen duong m:  ");
            m = int.Parse(Console.ReadLine());
            InitMatrix();
            Sum(Array, n);
            ShowMaxRow(SumArray);


        }
        public static void InitMatrix()
        {
            Array = new int[n, m];
            for (int row = 0; row < Array.GetLength(0); row++)
            {
                for (int col = 0; col < Array.GetLength(1); col++)
                {
                    Console.WriteLine($"Nhap phan tu [{row},{col}]");
                    Array[row, col] = int.Parse(Console.ReadLine());
                }
            }
        }
        public static int[] Sum(int[,] array,int n)
        {
             SumArray = new int[n];
            for (int row = 0; row < array.GetLength(0); row++)
            {
                SumArray[row] = 0;
                for (int col = 0; col < array.GetLength(1); col++)
                {
                    SumArray[row] += array[row, col];
                }
            }
            return SumArray;
        }
        public static void ShowMaxRow(int[] array)
        {
            int maxRow = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > maxRow)
                {
                    maxRow = array[i];
                }
            }
            Console.WriteLine($"Max Row: {maxRow}");
            
        }
    }
}
