using System;
using System.Collections.Generic;
using System.Text;

namespace bai1
{
    class BasicExercises26
    {
        static void Main()
        {
            int sum = 0;
            int number = 0;
            int n = 0;
            while (number <= 500)
            {
                if (isPrime(n))
                {
                    sum += n;
                    number++;
                }
                n++;
            }
            Console.WriteLine("Sum of the first 500 prime numbers: {0}", sum);
        }

        static bool isPrime(int n)
        {
            int x = (int)Math.Floor(Math.Sqrt(n));
            if (n == 0 || n == 1) return false;
            if (n == 2) return true;
            for (int i = 2; i <= x; i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
    }
}
