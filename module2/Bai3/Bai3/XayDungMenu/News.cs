using System;
using System.Collections.Generic;
using System.Text;
using Bai3.XayDungMenu.Models;

namespace Bai3.QuanLySDT
{
    public class News : INews
    {
        private int id;
        private string title;
        private string publicshDate;
        private string author;
        private string content;
        private double averageRate;
        public int[] RateList = new int[3];
        public NewsItem[] ArrayList = new NewsItem[100];

        public int Id { get => id; set => id = value; }
        public string Title { get => title; set => title = value; }
        public string PublicshDate { get => publicshDate; set => publicshDate = value; }
        public string Author { get => author; set => author = value; }
        public string Content { get => content; set => content = value; }
        public double AverageRate { get => averageRate; set => averageRate = value; }
        public void DisPlay()
        {
            foreach (var newsItem in ArrayList)
            {
                if (newsItem != null)
                {
                    Console.WriteLine("Id {0} Title {1} PublishDate {2} Author {3} Content {4} AverageRate {5}",
                                newsItem.Id, newsItem.Title,
                                newsItem.PublicshDate, newsItem.Author,
                                newsItem.Content, newsItem.AverageRate);
                }
            }
        }
        public void Calculate()
        {
            var total = 0;
            for (int i = 0; i < RateList.Length; i++)
            {
                total += RateList[i];
            }
            averageRate = (double)(total / RateList.Length);
        }
        public void InsertNews(int index)
        {
            Calculate();
            var newsItem = new NewsItem()
            {
                Id = id,
                Author = author,
                Content = content,
                PublicshDate = publicshDate,
                Title = title,
                AverageRate = averageRate
            };
            ArrayList[index] = newsItem;
        }
    }
}
