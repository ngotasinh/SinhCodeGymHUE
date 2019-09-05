using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ExceptionTes.Exception
{
    public class Exc2
    {
        public static void Main()
        {
            #region Khởi tạo mảng :
            Console.Write("Please enter an integer is size of array:  ");
            int size = int.Parse(Console.ReadLine());

            int[,] Array = new int[size, size];
            for (int row = 0; row < Array.GetLength(0); row++)
            {
                for (int col = 0; col < Array.GetLength(1); col++)
                {
                    Console.Write("Enter element [{0},{1}] into the array:  ", row, col);
                    Array[row, col] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("***********************************");
            }
            #endregion

            WriterFile(Array, size);
        }

        public static void WriterFile(int[,] Array, int n)
        {

            FileStream ArrInput = new FileStream(@"D:\SinhCodeGymHUE\module2\ExceptionTes\ExceptionTes\Exception\ArrInput.txt", FileMode.Create);
            using (StreamWriter sw = new StreamWriter(ArrInput))
            {
                sw.WriteLine(n);
                for (int row = 0; row < Array.GetLength(0); row++)
                {
                    for (int col = 0; col < Array.GetLength(1); col++)
                    {
                        sw.Write($"{Array[row, col]} ");
                    }
                    sw.WriteLine();
                }
            }
            ArrInput.Close();
        }

        public static void ReadAndWriterFile(int n)
        {
            int[] Array = new int[n];
            FileStream file = new FileStream(@"D:\SinhCodeGymHUE\module2\ExceptionTes\ExceptionTes\Exception\ArrInput.txt", FileMode.Open);
            using (StreamReader sr = new StreamReader("ArrInput.txt"))
            {
                int index = 0;
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (index == 0)
                    {
                        index++;
                        continue;
                    }
                    if (index > 0 && index <= n)
                    {
                        for (int i = index - 1; i < Array.Length; i++)
                        {
                            int[] ArrLine = null;
                            for (int j = 0; j < line.Length; j++)
                            {
                                if (line[j] != ' ')
                                {
                                   /* ArrLine[j] = int.Parse(line[j]);*/
                                }
                            }
                        }

                        for (int i = 0; i < line.Length; i++)
                        {
                            if (line[i] != ' ')
                            {

                            }
                        }
                    }

                }
            }
        }
    }
}
