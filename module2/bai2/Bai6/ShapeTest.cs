using System;
using System.Collections.Generic;
using System.Text;

namespace Bai6
{
    public class ShapeTest
    {
        public static void Main()
        {
            var rect = new Rectangle(5.5, 7.5);
            
            Console.WriteLine(rect.toString(true));
            Console.WriteLine(rect.toString(false));

            var cir = new Circle(12.5, 3.14);
            
            Console.WriteLine(cir.toString(true));
            Console.WriteLine(cir.toString(false));
        }
    }
}
