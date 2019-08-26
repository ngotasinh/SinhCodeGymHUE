using System;
using System.Collections.Generic;
using System.Text;

namespace Bai3.QuanLyDanhSach
{
    public class BookTest
    {
        public static Book newBook = new Book();
        public static int Id =0;
        static void Main()
        {
            Menu();
        }
        public static void Menu()
        {
            int option = 0;
            do
            {
                Console.WriteLine("*************Menu************");
                Console.WriteLine("1.\tInput new book");
                Console.WriteLine("2.\tView list of books");
                Console.WriteLine("3.\tAverage Price");
                Console.WriteLine("4.\tExit");
                if (int.TryParse(Console.ReadLine(), out int number))
                {
                    option = number;
                }

            }
            while (option <= 0 || option >= 4);
            Process(option);
        }
        public static void Process(int selected)
        {
            switch (selected)
            {
                case 1:
                    {
                        Console.WriteLine("Input new book .......");
                        Id += 1;
                        CreateNew();
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("View list of books............");
                        newBook.DisPlay();
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Average Price...........");
                        break;
                    }
                case 4:
                default:
                    {
                        Environment.Exit(Environment.ExitCode);
                        break;
                    }
            }
            Menu();
        }
        public static void CreateNew()
        {
            newBook.Id = Id;
            Console.Write("Input Name:  ");
            newBook.Name = Console.ReadLine();

            Console.Write("Input Author:  ");
            newBook.Author = Console.ReadLine();

            Console.Write("Input PublishDate:  ");
            newBook.PublishDate = Console.ReadLine();

            Console.Write("Input Language:  ");
            newBook.Language = Console.ReadLine();

            Console.WriteLine("Input Rate:  ");
            for (int i = 0; i < newBook.PriceList.Length; i++)
            {
                Console.Write("Input Rate {0}:  ", i + 1);
                newBook.PriceList[i] = int.Parse(Console.ReadLine());
            }
            newBook.Insert(Id);
        }
    }
}
