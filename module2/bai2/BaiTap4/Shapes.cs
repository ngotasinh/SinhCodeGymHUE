using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTap4
{
    public class Shapes
    {
        private int x;
        private int y;
     
        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }

        public Shapes()
        {
            x = 2;
            y = 6;
        }
        public Shapes(int X, int Y)
        {
            x = X;
            y = Y;
        }
        public int area()
        {
            return x * y;
        }
        public int perimeter()
        {
            return (x + y) * 2;
        }
    }
    public class Square : Shapes
    {
        public Square(int X, int Y) : base(X, Y)
        {

        }
    }
    public class rectangle : Shapes
    {

    }

    public class Draw
    {
        public static void Main()
        {
            Shapes myShapes = new Shapes(20, 30);
            Console.WriteLine( myShapes.area());
            Console.WriteLine(myShapes.perimeter());



            Square mySquare = new Square(2, 6);
            Console.WriteLine(mySquare.area());
            Console.WriteLine(mySquare.perimeter());

            mySquare.X = 50;
            mySquare.Y = 50;
            Console.WriteLine(mySquare.area());
            Console.WriteLine(mySquare.perimeter());
        }
    }
}
