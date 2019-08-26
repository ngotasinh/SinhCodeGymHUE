using System;
using System.Collections.Generic;
using System.Text;
using Bai3.XayDungMenu.Models;

namespace Bai3.QuanLySDT
{
    public class NewsTest
    {
        public static News news = new News();
        public static int Id = 0;

        public static void Main()
        {
            IntMenu();
            
        }
        public static void IntMenu()
        {
            int option = 0;
            do
            {
                Console.WriteLine("Managemet New");
                Console.WriteLine("1. Insert new");
                Console.WriteLine("2. View list news");
                Console.WriteLine("3. Average rate");
                Console.WriteLine("4. Exit");
                Console.WriteLine("Please select an option");
                Console.WriteLine("Option: ");
                if(int.TryParse(Console.ReadLine(), out var number))
                {
                    option = number;
                }
            }
            while (option > 4 || option <= 0);
            Process(option);
        }
        public static void Process(int selected)
        {
            switch (selected)
            {
                case 1:
                    {
                        Console.WriteLine("Insert new .......");
                        Id += 1;
                        CreateNew();
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("View list news............");
                        news.DisPlay();
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Average rate...........");
                        break;
                    }
                case 4:
                default:
                    {
                        Environment.Exit(Environment.ExitCode);
                        break;
                    }
            }
            IntMenu();
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
