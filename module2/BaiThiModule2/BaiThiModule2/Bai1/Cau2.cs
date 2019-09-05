using System;
using System.Collections.Generic;
using System.Text;

namespace BaiThiModule2.Bai1
{
    public class Cau2
    {
        public static int[] Array;
        static void Main()
        {
            InitMenu();

        }
        public static void InitMenu()
        {
            int option = 0;
            do
            {
                Console.WriteLine("Managemet New");
                Console.WriteLine("1. Tao Mang");
                Console.WriteLine("2. Kiem Tra Mang");
                Console.WriteLine("3. Sap xep mang");
                Console.WriteLine("4. Tim kiem mang");
                Console.WriteLine("5. Exit");
                Console.WriteLine("Please select an option");
                Console.WriteLine("Option: ");
                if (int.TryParse(Console.ReadLine(), out var number))
                {
                    option = number;
                }
            }
            while (option > 6 || option <= 0);
            Process(option);
        }
        public static void Process(int selected)
        {
            switch (selected)
            {
                case 1:
                    {
                        Console.WriteLine("Tao mang .......");
                        InitArray();
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Kiem Tra Mang............");
                        Console.WriteLine(IsIncreaseArray(Array)); 
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Sap xep mang...........");
                        SelectedSort(Array);
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Tim kiem mang...........");
                        Console.Write("Nhap gia tri can tim:  ");
                        int n = int.Parse(Console.ReadLine());
                        Find(Array,n);
                        break;
                    }
                case 5:
                default:
                    {
                        Environment.Exit(Environment.ExitCode);
                        break;
                    }
            }
            InitMenu();
        }
        public static int[] InitArray()
        {
            Console.Write("Nhap vao size của mang: ");
            int size = int.Parse(Console.ReadLine());
             Array = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Nhap phan tu thu {i} cua mang:  ");
                Array[i]=int.Parse(Console.ReadLine());
            }
            return Array;
        }
        public static bool IsIncreaseArray(int[] Arr)
        {
            for (int i = 0; i < Arr.Length - 1; i++)
            {
                for (int j = i+1; j < Arr.Length; j++)
                {
                    if(Arr[i]> Arr[j])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public static void SelectedSort(int[] A)
        {
            for (int i = 0; i < A.Length - 1; i++)
            {
                var min = A[i];
                var pos = i;
                for (int j = i + 1; j < A.Length; j++)
                {
                    if (A[j] < min)
                    {
                        min = A[j];
                        pos = j;
                    }
                }
                var temp = A[i];
                A[i] = A[pos];
                A[pos] = temp;
            }
        }
        public static string Find(int[] A, int n)
        {
            int min = 0;
            int max = A.Length - 1;
            int mid = 0;
            while (min <= max)
            {
                mid = (max + min) / 2;
                if (A[mid] == n)
                {
                    return $"Tim thay gia tri {n} tai vi tri {mid}";
                }
                else if (A[mid] < n)
                {
                    min = mid + 1;
                }
                else
                {
                    max = mid - 1;
                }
            }
            return $"Khong tim thay";
        }
    }
}
