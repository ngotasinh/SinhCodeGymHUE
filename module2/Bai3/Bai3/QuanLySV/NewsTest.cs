using System;
using System.Collections.Generic;
using System.Text;

namespace Bai3.QuanLySV
{
    public class NewsTest
    {
        public static News news = new News();
        public static int Id = 0;
        public static void Main()
        {

            Menu();

        }


        public static void Menu()
        {
            int option = 0;
            do
            {
                Console.WriteLine("***********Menu Option*************");
                Console.WriteLine("1.\tInsert news");
                Console.WriteLine("2.\tView list news");
                Console.WriteLine("3.\tAverage rate");
                Console.WriteLine("4.\t Exit");
                Console.WriteLine("***********select Option***********");
                if (int.TryParse(Console.ReadLine(), out int number))
                {
                    option = number;
                }
            }
            while (option <= 0 || option >= 5);
            Process(option);
        }
        public static void Process(int number)
        {
            switch (number)
            {
                case 1:
                    {
                        Console.WriteLine("Insert news........... ");
                        Id += 1;
                        CreateNew();
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("View List .........");
                        news.DisPlay();
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Average rate........");
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
            news.Id = Id;
            Console.Write("Input Title:");
            news.Title = Console.ReadLine();

            Console.Write("Input Publish date: ");
            news.PublicshDate = Console.ReadLine();

            Console.Write("Input Author: ");
            news.Author = Console.ReadLine();

            Console.Write("Input Content: ");
            news.Content = Console.ReadLine();

            Console.Write("Input Rate: ");
            for (int i = 0; i < news.RateList.Length; i++)
            {
                Console.WriteLine("Input rate {0} ", i + 1);
                news.RateList[i] = int.Parse(Console.ReadLine());
            }
            news.InsertNews(Id);
        }
    }
}
