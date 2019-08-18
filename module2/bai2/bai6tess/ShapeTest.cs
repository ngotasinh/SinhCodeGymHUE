using System;
using System.Collections.Generic;
using System.Text;

namespace bai6tess
{
    class ShapeTest
    {
        public static void Main()
        {
            var rect = new Rectangle();
            rect.Side1 = 5;
            rect.Side2 = 6;
            rect.side();
            Console.WriteLine("Area is: {0}", rect.Area());
            Console.WriteLine("Perimeter is: {0}", rect.Perimeter());
        }
        
    }
}
