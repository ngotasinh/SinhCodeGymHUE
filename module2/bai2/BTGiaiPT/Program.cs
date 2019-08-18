using System;

namespace BTGiaiPT
{
    class QuadraticEquation
    {
        private double a;
        private double b;
        private double c;
        protected double delta;

        public QuadraticEquation()
        {

        }
       
        public QuadraticEquation(double A, double B, double C)
        {
            a = A;
            b = B;
            c = C;
        }

        public double A { get => a; set => a = value; }
        public double B { get => b; set => b = value; }
        public double C { get => c; set => c = value; }

        public double GetDiscriminant()
        {
            return delta = b * b - 4 * a * c;
        }


        public void getRoot()
        {
            if(delta < 0)
            {
                Console.WriteLine("the equation has no solution");
            }
            if(delta == 0)
            {
                Console.WriteLine("Equation has 1 solution x= {0}", -b / (2 * a));
            }
            else
            {
                Console.WriteLine("Root x1= {0} \nRoot x2= {1}", (-b - Math.Sqrt(delta)) / 2 * a, (-b + Math.Sqrt(delta)) / 2 * a);
            }   
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            QuadraticEquation equation = new QuadraticEquation(2, 3, -5);
            Console.WriteLine(equation.GetDiscriminant());
            equation.getRoot();

            QuadraticEquation equation1 = new QuadraticEquation();
            equation1.A = 10;
            equation1.B = -20;
            equation1.C = 10;
            Console.WriteLine(equation1.GetDiscriminant());
            equation1.getRoot();
        }
    }
    
}
