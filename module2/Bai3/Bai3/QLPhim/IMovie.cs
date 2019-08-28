using System;
using System.Collections.Generic;
using System.Text;

namespace Bai3.QLPhim
{
    public interface IMovie
    {
        int ID { get; set; }
        string Name { get; set; }
        DateTime PublishDate { get; set; }
        string Director { get; set; }
        string Subtitle { get; set; }
        double AverageRate { get; set; }

        string DisPlay();
    }
}
