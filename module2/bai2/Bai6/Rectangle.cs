using System;
using System.Collections.Generic;
using System.Text;

namespace Bai6
{
    public class Rectangle : Shape
    {
        private double side1;
        private double side2;

        public Rectangle(double side1, double side2) : base(side1, side2)
        {

        }

        /*public void SetSide1(double s1)
        {
            side1 = s1;
        }
        public void SetSide2(double s2)
        {
            side2 = s2;
        }
        
        public void SetSide()
        {
            setLocation(side1, side2);
        }*/

    }
}
