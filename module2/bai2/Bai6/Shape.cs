using System;
using System.Collections.Generic;
using System.Text;


namespace Bai6
{
    public class Shape
    {
        protected Location c = new Location();


        public Shape(double side1, double side2)
        {
            c.X = side1;
            c.Y = side2;
        }

        public string toString(bool type)
        {
            return type ? "area is: " + Area() : "perimeter is" + Perimeter();
        }
       /* public void setLocation(double number1, double number2)
        {
            c.X = number1;
            c.Y = number2;
        }*/
        public virtual double Area()
        {
            return c.X * c.Y;
        }
        public double Perimeter()
        {
            return (c.X + c.Y) * 2;
        }
    }
   
}
