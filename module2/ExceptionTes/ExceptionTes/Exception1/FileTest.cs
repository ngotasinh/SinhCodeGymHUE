using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ExceptionTes.Exception1
{
    public class FileTest
    {
        private string nameInput;
        private string nameOutput;
        private int[] ArrayMod2 = new int[10];

        public string NameInput { get => nameInput; set => nameInput = value; }
        public string NameOutput { get => nameOutput; set => nameOutput = value; }

        #region HÀM GHI VÀO FILE INPUT:
        public void WriterFile(int[] Array, int n)
        {
            FileStream file = new FileStream(NameInput, FileMode.Create);
            using (StreamWriter writer = new StreamWriter(file))
            {
                writer.WriteLine(n);
                writer.WriteLine("{0}", string.Join(" ", Array));
            }
            file.Close();
        }
        #endregion


        public void ReadFile(int n)
        {
            int[] ArrayNumber = new int[n];
            int sumNumber = 0;
            FileStream file = new FileStream(NameInput, FileMode.Open);
            using (StreamReader reader = new StreamReader(file))
            {
                int index = 1;
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    if (index == 1)
                    {
                        Console.WriteLine(line);
                        index++;
                        continue;
                    }
                    Console.WriteLine(line);
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



            FileStream file1 = new FileStream(NameOutput, FileMode.Create);
            DivideBy2(ArrayNumber);
            Sort(ArrayNumber);

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


        public void DivideBy2(int[] ArrayNumber)
        {
        
            for (int i = 0; i < ArrayNumber.Length; i++)
            {
                if (ArrayNumber[i] % 2 == 0)
                {
                    ArrayMod2[i] = ArrayNumber[i];
                }
            }
        }


        public void Sort(int[] ArrayNumber)
        {
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
        }
    }
}
    

