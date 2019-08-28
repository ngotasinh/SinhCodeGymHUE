using System;
using System.Collections.Generic;
using System.Text;

namespace Bai3.QLPhim
{
    public class Movie : IMovie
    {
        protected int id;
        protected string name;
        protected DateTime publishDate;
        protected string director;
        protected string subtiile;
        protected double averageRate;
        public double[] RateList = new double[3];

        public int ID { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public DateTime PublishDate { get => publishDate; set => publishDate = value; }
        public string Director { get => director; set => director =value; }
        public string Subtitle { get => subtiile; set => subtiile = value; }
        public double AverageRate { get => averageRate; set => averageRate = value; }

        public string DisPlay()
        {
            return $"Name: {name}\t PublishDate: {publishDate}\t Director: {director}\t Language: {subtiile}\t AverageRate: {averageRate}";
        }
        public double Calculate()
        {
            double Total = 0.0;
            foreach (var item in RateList)
            {
                Total = Total + item;
            }
            averageRate = Total /RateList.Length;
            return averageRate;
        }
    }
}
