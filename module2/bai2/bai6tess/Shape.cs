using System;
using System.Collections.Generic;
using System.Text;

namespace bai6tess
{
    public class Shape
    {
        private Location c = new Location();
       
        public Location C { get => c; set => c = value;}
        public void setLocation(double side1, double side2)
        {
            c.X = side1;
            c.Y = side2;
        }
        public double Area()
        {
            return c.X * c.Y;
        }
        public double Perimeter()
        {
            return (c.X + c.Y) * 2;
        }
    }
}
