using System;
using System.Collections.Generic;
using System.Text;

namespace bai6tess
{
    public class Rectangle : Shape
    {
        private double side1;
        private double side2;

        public double Side1 { get => side1; set => side1 = value; }
        public double Side2 { get => side2; set => side2 = value; }
        public void side()
        {
            setLocation(side1, side2);
        }
    }
}
