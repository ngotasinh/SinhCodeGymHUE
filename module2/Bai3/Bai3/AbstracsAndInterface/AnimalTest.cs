using System;
using System.Collections.Generic;
using System.Text;

namespace Bai3.AbstracsAndInterface
{
    public class AnimalTest
    {
        public static void Main()
        {
            Console.WriteLine("***************Chicken******************");
            var chip = new Chicken();
            Console.WriteLine("Chip say: {0}", chip.MakeSound());
            Console.WriteLine("Chip eats: {0}", chip.howtoEat());
            Console.WriteLine("***************Tiger******************");
            var purma = new Tiger();
            Console.WriteLine("Tiger say: {0}", purma.MakeSound());
            Console.WriteLine("***************Apple******************");
            var myApple = new Apple();
            Console.WriteLine("Apple eats: {0}", myApple.howtoEat());
        }
    }
}
