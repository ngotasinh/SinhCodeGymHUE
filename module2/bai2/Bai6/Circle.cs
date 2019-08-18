using System;
using System.Collections.Generic;
using System.Text;

namespace Bai6
{
    public class Circle : Shape
    {
        private double radius;
        private  double pi;
        public Circle(double side1, double side2): base(side1, side2)
        {
            radius = side1;
            pi = side2;
        }

       /* public void SetCircle()
        {
            setLocation(radius, pi);
        }
*/
        public override double Area()
        {
            return radius * radius * pi;
        }
    }
}
