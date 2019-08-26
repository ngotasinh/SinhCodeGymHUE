using System;
using System.Collections.Generic;
using System.Text;

namespace Bai3.QuanLyDanhSach
{
    public class Book : IBook
    {
        protected int id;
        protected string name;
        protected string publishDate;
        protected string author;
        protected string language;
        protected float averagePrice;
        public int[] PriceList = new int[5];
        public NewItem[] ArrayList = new NewItem[100];

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string PublishDate { get => publishDate; set => publishDate = value; }
        public string Author { get => author; set => author = value; }
        public string Language { get => language; set => language = value; }
        public float AveragePrice { get => averagePrice; }

        public void DisPlay()
        {
            foreach (var item in ArrayList)
            {
                if (item != null)
                {
                    Console.WriteLine("****************************************************************************************");
                    Console.WriteLine(" Id : {0} Name: {1} \tPublish Date: {2} \tAuthor: {3} \tlanguage: {4} \tAveragePrice: {5}",
                 item.Id, item.Name,item.PublicshDate, item.Author, item.Language, item.AverageRate);
                }
            }  
        }
        public void Calculate()
        {
            int post = 0;
            for (int i = 0; i < PriceList.Length; i++)
            {
                post += PriceList[i];
            }
            averagePrice = (float)(post / PriceList.Length);
        }
        public void Insert(int index)
        {
            Calculate();
            var newItem = new NewItem()
            {
                Id = id,
                Name = name,
                Author = author,
                PublicshDate = publishDate,
                Language = language,
                AverageRate = averagePrice
            };
            ArrayList[index] = newItem;
        }
    }
}
