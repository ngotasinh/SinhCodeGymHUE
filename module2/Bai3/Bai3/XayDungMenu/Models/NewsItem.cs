using System;
using System.Collections.Generic;
using System.Text;

namespace Bai3.XayDungMenu.Models
{
    public class NewsItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string PublicshDate { get; set; }
        public string Content { get; set; }
        public Double AverageRate { get; set; }
    }
}
