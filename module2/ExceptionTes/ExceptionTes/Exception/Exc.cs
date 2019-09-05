using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ExceptionTes.Exception
{
    public class Exc
    {
        public static string input = $"D:\\SinhCodeGymHUE\\module2\\ExceptionTes\\input.txt";
        public static string output = $"D:\\SinhCodeGymHUE\\module2\\ExceptionTes\\out.txt";
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

            WriteFile(Array, n);
            ReadFile(n);


        }
        public static void WriteFile(int[] Array, int n)
        {
            FileStream fileName = new FileStream($"D:\\SinhCodeGymHUE\\module2\\ExceptionTes\\input.txt", FileMode.Create);
            
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                writer.WriteLine(n);
                writer.WriteLine("{0}", string.Join(" ", Array));
            }
            fileName.Close();
        }
        public static void ReadFile(int n)
        {
            int[] ArrayNumber = new int[n];
            int sumNumber = 0;
            FileStream file = new FileStream(input, FileMode.Open);
            using (StreamReader reader = new StreamReader(file))
            {
                int index = 1;
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    if (index == 1)
                    {
                        index++;
                        continue;
                    }
                    reader.ReadLine();
                    var ArrayString = line.Split(" ");
                    int sum = 0;
                    for (int i = 0; i < ArrayString.Length; i++)
                    {
                        ArrayNumber[i] = int.Parse(ArrayString[i]);
                        sum += ArrayNumber[i];
                    }
                    sumNumber = sum;
                }
            }
            file.Close();

            FileStream file1 = new FileStream(output, FileMode.Create);
            int[] ArrayMod2 = new int[10];
            for (int i = 0; i < ArrayNumber.Length; i++)
            {
                if (ArrayNumber[i] % 2 == 0)
                {
                    ArrayMod2[i] = ArrayNumber[i];
                }
            }

            for (int i = 0; i < ArrayNumber.Length; i++)
            {
                for (int j = ArrayNumber.Length - 1; j > i; j--)
                {
                    if (ArrayNumber[j] < ArrayNumber[j - 1])
                    {
                        var temp = ArrayNumber[j];
                        ArrayNumber[j] = ArrayNumber[j - 1];
                        ArrayNumber[j - 1] = temp;
                    }
                }
            }

            using (StreamWriter sw = new StreamWriter(file1))
            {
                sw.WriteLine($"Tong gia tri {sumNumber}");
                sw.Write("Cac so chan la : ");
                for (int i = 0; i < ArrayMod2.Length; i++)
                {
                    if (ArrayMod2[i] != 0)
                    {

                        sw.Write($"{ArrayMod2[i]}  ");
                    }
                }
                sw.WriteLine();
                sw.WriteLine($"Array Sort: {string.Join(" ", ArrayNumber)}");
            }
            file1.Close();
        }
    }
}
