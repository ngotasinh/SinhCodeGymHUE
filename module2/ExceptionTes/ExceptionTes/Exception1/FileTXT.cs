using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionTes.Exception1
{
    public class FileTXT
    {
        public static void Main()
        {

            #region NHẬP SIZE VÀ TẠO MẢNG.
            Console.Write("Input size of Array:  ");
            int n = int.Parse(Console.ReadLine());
            int[] Array = new int[n];
            Console.WriteLine("Enter the elements of the array");
            for (int i = 0; i < Array.Length; i++)
            {
                Console.Write("Enter element {0} of the array:  ", i + 1);
                Array[i] = int.Parse(Console.ReadLine());
            }
            #endregion

            #region GHI FILE..........
            FileTest file = new FileTest();
            file.NameInput = @"D:\SinhCodeGymHUE\module2\ExceptionTes\ExceptionTes\Exception1\input.txt";
            file.WriterFile(Array, n);
            #endregion

            #region ĐỌC FILE VÀ THỰC HIỆN CHỨC NĂNG....................
            file.NameOutput = @"D:\SinhCodeGymHUE\module2\ExceptionTes\ExceptionTes\Exception1\output.txt";
            file.ReadFile(n);
            #endregion

        }
    }
}
